using System;
using System.Linq;

namespace ConsoleApplication1
{
     public class Area
    {
        public Area()
        {
        }

        public float Conversion(float distance, string initialUnit, string finalUnit)
        {
            float result = 0;
            distance = InitialUnitToSquareMeter(initialUnit, distance);
            return SquareMeterToFinalUnit(finalUnit, distance, ref result);
        }

        private float SquareMeterToFinalUnit(string finalUnit, float area, ref float result)
        {
            switch (finalUnit)
            {
              case "acre":
                    {
                        return area *= 0.000247105381f;
                    }
                case "hectare":
                    {
                        return area *= 0.0001f;
                    }
                case "squareMetre":
                    {
                        return area;
                    }
                case "squareFoot":
                    {
                        return area *= 10.7639104f;
                    }
                case "squareKilometre":
                    {
                        return area *= Math.Pow(10, -6);
                    }
                case "squareMile":
                    {
                        return area *= 3.86102159f * (float)Math.Pow(10, -7);
                    }
            }
            return result;
        }

        private float InitialUnitToSquareMeter(string initialUnit, float area)
        {
            switch (initialUnit)
            {

                case "acre":
                    {
                        area *=4046.8564224f;
                        break;
                    }
                case "hectare":
                    {
                        area *=10000f ;
                        break;
                    }
                case "squareMetre":
                    {
                        
                        break;
                    }
                case "squareFoot":
                    {
                        area *= 0.09290304f;
                        break;
                    }
                case "squareKilometre":
                    {
                        area *= 1000000f;
                        break;
                    }
                case "squareMile":
                    {
                        area *= 2589988.11f;
                        break;
                    }
            }
            return area;
        }
    }
}