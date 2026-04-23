using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter
{
    public static class FeetConverter
    {
        public static double Flometer(double meter)
        {
            return meter / 0.3048;
        }

        public static double TOmeter(double feet)
        {
            return feet * 0.3048;
        }

        //フィートからメートルを求める
        public double FromMeter(double mater)
        {
            return mater / 0.3048;
        }
        //メートルからフィートを求める
        public double ToFeet(double feet)
        {
            return feet * 0.3048;
        }
    }
}
