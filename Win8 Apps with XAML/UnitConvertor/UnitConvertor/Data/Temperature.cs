using System;
using System.Linq;

namespace UnitConvertor.Data
{
    public class Temperature
    {
        public Temperature()
        {
        }

        public float Conversion(float temperature, string initialUnit, string finalUnit)
        {
            float result = 0;
            temperature = InitialUnitToCelsius(initialUnit, temperature);

            return result = CelsiusToFinalUnit(finalUnit, temperature, ref result);
        }

        private float CelsiusToFinalUnit(string finalUnit, float temperature, ref float result)
        {
            switch (finalUnit)
            {
                case "celsius":
                    {
                        return temperature;
                    }
                case "kelvin":
                    {
                        return result = temperature + 273.15f;
                    }
                case "fahrenheit":
                    {
                        return result = temperature * (9f / 5f) + 32;
                    }


            }
            return result;
        }

        private float InitialUnitToCelsius(string initialUnit, float temperature)
        {
            switch (initialUnit)
            {

                case "celsius":
                    {
                        break;
                    }
                case "kelvin":
                    {
                        temperature -= 273.15f;
                        break;
                    }
                case "fahrenheit":
                    {
                        temperature = (temperature - 32) * (5f / 9f);
                        break;
                    }


            }
            return temperature;
        }
    }
}
