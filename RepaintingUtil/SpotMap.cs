using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;

namespace RepaintingUtil
{
    public class SpotMap
    {
        public float[] X { get; set; }
        public float[] Y { get; set; }
        public float[] MeterWeights { get; set; }
        public int LayerIndex { get; set; }
        public double NominalEnergy { get; set; }
        public int ScanSpotNumber { get; set; }
        public double CumMeterWeight { get; set; }
        public float SpotSizeX { get; set; }
        public float SpotSizeY { get; set; }

        public SpotMap()
        {

        }

        public SpotMap(DICOMObject icpStart, DICOMObject icpEnd)
        {
            this.LayerIndex = (int)icpStart.FindFirst(TagHelper.ControlPointIndex).DData / 2 + 1;
            this.NominalEnergy = (double)icpStart.FindFirst(TagHelper.NominalBeamEnergy).DData;
            this.ScanSpotNumber = (int)icpStart.FindFirst(TagHelper.NumberOfScanSpotPositions).DData;
            this.CumMeterWeight = (double)icpEnd.FindFirst(TagHelper.CumulativeMetersetWeight).DData;
            this.X = new float[this.ScanSpotNumber];
            this.Y = new float[this.ScanSpotNumber];
            this.MeterWeights = new float[this.ScanSpotNumber];
            List<float> scanspotmap = (List<float>)icpStart.FindFirst(TagHelper.ScanSpotPositionMap).DData_;
            for (int i = 0; i < ScanSpotNumber; i ++)
            {
                this.X[i] = scanspotmap[i * 2];
                this.Y[i] = scanspotmap[i * 2 + 1];
            }
            List<float> ssmeterw = (List<float>)icpStart.FindFirst(TagHelper.ScanSpotMetersetWeights).DData_;
            for (int i = 0; i < ScanSpotNumber; i++)
                this.MeterWeights[i] = ssmeterw[i];
            List<float> scanspotsize = (List<float>)icpStart.FindFirst(TagHelper.ScanningSpotSize).DData_;
            this.SpotSizeX = scanspotsize[0];
            this.SpotSizeY = scanspotsize[1];
        }

        public SpotMap Copy()
        {
            SpotMap destsm = new SpotMap();
            destsm.X = (float[])this.X.Clone();
            destsm.Y = (float[])this.Y.Clone();
            destsm.MeterWeights = (float[])this.MeterWeights.Clone();
            destsm.LayerIndex = this.LayerIndex;
            destsm.NominalEnergy = this.NominalEnergy;
            destsm.ScanSpotNumber = this.ScanSpotNumber;
            destsm.CumMeterWeight = this.CumMeterWeight;
            destsm.SpotSizeX = this.SpotSizeX;
            destsm.SpotSizeY = this.SpotSizeY;

            return destsm;
        }

        // Split one energy layer to couple energies, usually +/- 0.1 MeV, for all spot > threshold MU, make sure the final one not smaller than smallHUcap
        // Have to set layerIndex and cummeterweight after that
        public List<SpotMap> SplitTo(List<double> energies, double thresholdMU, double smallHUcap, double MUMWratio)
        {
            List<SpotMap> split = new List<SpotMap>();
            energies.Sort();
            energies.Reverse();
            for(int i = 0; i < energies.Count; i++)
            {
                SpotMap sm = this.Copy();
                sm.NominalEnergy = energies[i];
                List<float> x = new List<float>();
                List<float> y = new List<float>();
                List<float> mw = new List<float>();
                for (int j = 0; j < this.ScanSpotNumber; j++)
                {
                    if (sm.NominalEnergy != this.NominalEnergy) //not original layer
                    {
                        if ((this.MeterWeights[j] * MUMWratio > thresholdMU) && (this.MeterWeights[j] * MUMWratio > smallHUcap * energies.Count))
                        {
                            x.Add(this.X[j]);
                            y.Add(this.Y[j]);
                            mw.Add(this.MeterWeights[j] / energies.Count);
                        }
                    }
                    else
                    {
                        if ((this.MeterWeights[j] * MUMWratio > thresholdMU) && (this.MeterWeights[j] * MUMWratio > smallHUcap * energies.Count)) //original layer
                        {
                            x.Add(this.X[j]);
                            y.Add(this.Y[j]);
                            mw.Add(this.MeterWeights[j] / energies.Count);
                        }
                        else
                        {
                            x.Add(this.X[j]);
                            y.Add(this.Y[j]);
                            mw.Add(this.MeterWeights[j]);
                        }
                    }
                }
                sm.ScanSpotNumber = x.Count;
                sm.X = x.ToArray();
                sm.Y = y.ToArray();
                sm.MeterWeights = mw.ToArray();
                sm.CumMeterWeight = mw.Sum();
                if (sm.ScanSpotNumber > 0)
                    split.Add(sm);
            }
            return split;
        }

    }
}
