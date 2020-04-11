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

    }
}
