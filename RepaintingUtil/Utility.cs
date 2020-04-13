using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepaintingUtil
{
    public static class Utility
    {
        public static List<SpotMap> splitSpotMaps(List<SpotMap> spotMaps, double thresholdMU, double MUMWratio, List<double> layers, double enIncrement, double smallHUcap, bool enPlus = true, bool enMinus = true)
        {
            List<SpotMap> splitSpots = new List<SpotMap>();
            foreach (SpotMap s in spotMaps)
                if (layers.Contains(s.NominalEnergy))
                {
                    List<double> energies = new List<double>();
                    if (enPlus) energies.Add(s.NominalEnergy + enIncrement);
                    energies.Add(s.NominalEnergy);
                    if (enMinus) energies.Add(s.NominalEnergy - enIncrement);
                    List<SpotMap> sss = s.SplitTo(energies, thresholdMU, smallHUcap, MUMWratio);
                    foreach(SpotMap ss in sss)
                        splitSpots.Add(ss);
                }
                else
                {
                    splitSpots.Add(s);
                }

            double cmw = 0;
            for (int i = 0; i < splitSpots.Count; i++)
            {
                cmw += splitSpots[i].MeterWeights.Sum();
                splitSpots[i].CumMeterWeight = cmw;
                splitSpots[i].LayerIndex = i;
            }

            return splitSpots;
        }

        static float[] setPosition(float[] origPosition, int[] match)
        {
            List<float> pos = new List<float>();
            for (int i = 0; i < origPosition.Length; i++)
                if (match[i] > 0)
                    pos.Add(origPosition[i]);
            return pos.ToArray();
        }

        static float[] setMeterweight(float[] origMeterWeight, int[] match)
        {
            List<float> mw = new List<float>();
            for (int i = 0; i < origMeterWeight.Length; i++)
                if (match[i] > 0)
                    mw.Add(origMeterWeight[i] / match[i]);
            return mw.ToArray();
        }
    }
}
