using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Exo07___Structs
{
    public struct EquationSecondDegre
    {
        public double A;
        public double B;
        public double C;

        public bool ResoudreV3(out double? X1, out double? X2)
        {
            X1 = X2 = null;
            if (Delta() < 0) return false;
            X1 = CalculX(-Math.Sqrt(Delta()));
            if (Delta() > 0) X2 = CalculX(Math.Sqrt(Delta()));
            return true;
        }

        public bool ResoudreV2(out double? X1, out double? X2)
        {
            X1 = X2 = null;
            double delta = (B * B) - (4 * A * C);
            if (delta < 0) return false;
            X1 = CalculX(-Math.Sqrt(delta));
            if (delta > 0) X2 = CalculX(Math.Sqrt(delta));
            return true;
        }

        public bool ResoudreV1(out double? X1, out double? X2)
        {
            X1 = X2 = null;
            double delta = (B * B) - (4 * A * C);
            if (delta < 0) return false;
            else if (delta == 0) X1 = -B / (2 * A);
            else
            {
                X1 = (-B - Math.Sqrt(delta)) / (2 * A);
                X2 = (-B + Math.Sqrt(delta)) / (2 * A);
            }
            return true;
        }

        private double Delta()
        {
            return (B * B) - (4 * A * C);
        }

        private double CalculX (double racineDeDelta)
        {
            return (-B + racineDeDelta) / (2 * A);
        }
    }
}
