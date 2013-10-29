using System;
using System.Linq;

namespace UnitConvertor.ConversionFormulas
{
        public class Distance
    {
        public Distance()
        {

        }
        public float Conversion(float distance, string initialUnit, string finalUnit)
        {
            float result = 0;
            distance = InitialUnitToMeter(initialUnit, distance);

            return MeterToFinalUnit(finalUnit, distance, ref result);
        }

        private float MeterToFinalUnit(string finalUnit, float distance, ref float result)
        {
            switch (finalUnit)
            {
                case "mm":
                    {
                        return result = distance * 1000;
                    }
                case "cm":
                    {
                        return result = distance * 100;
                    }
                case "dm":
                    {
                        return result = distance * 10;
                    }
                case "m":
                    {
                        return result = distance * 1;
                    }
                case "km":
                    {
                        return result = distance / 1000;
                    }
                case "inch":
                    {
                        return result = distance * 39.3700787f;
                    }
                case "foot":
                    {
                        return result = distance * 3.2808399f;
                    }
                case "yard":
                    {
                        return result = distance * 1.0936133f;
                    }
                case "mile":
                    {
                        return result = distance * 0.000621371192f;
                    }
            }
            return result;
        }

        private float InitialUnitToMeter(string initialUnit, float distance)
        {
            switch (initialUnit)
            {

                case "mm":
                    {
                        distance /= 1000;
                        break;
                    }
                case "cm":
                    {
                        distance /= 100;
                        break;
                    }
                case "dm":
                    {
                        distance /= 10;
                        break;
                    }
                case "m":
                    {
                        break;
                    }
                case "km":
                    {
                        distance *= 1000;
                        break;
                    }
                case "inch":
                    {
                        distance *= 0.0254f;
                        break;
                    }
                case "foot":
                    {
                        distance *= 0.3048f;
                        break;
                    }
                case "yard":
                    {
                        distance *= 0.9144f;
                        break;
                    }
                case "mile":
                    {
                        distance *= 1609.344f;
                        break;
                    }
            }
            return distance;
        }
    }

}
