using System;
using System.Linq;

namespace ConsoleApplication1
{
    public class Speed
    {
        public Speed()
        {
        }

        public float Conversion(float speed, string initialUnit, string finalUnit)
        {
            float result = 0;
            speed = InitialUnitToMetersPerSecond(initialUnit, speed);

            return result = MetrePerSecondToFinalUnit(finalUnit, speed, ref result);
        }

        private float MetrePerSecondToFinalUnit(string finalUnit, float speed, ref float result)
        {
            switch (finalUnit)
            {
                case "km/h":
                    {
                        return result = speed * 3.6f;
                    }
                case "m/s":
                    {
                        return speed;
                    }
                case "mi/h":
                    {
                        return result = speed * 2.23693629f;
                    }


            }
            return result;
        }

        private float InitialUnitToMetersPerSecond(string initialUnit, float speed)
        {
            switch (initialUnit)
            {

                case "km/h":
                    {
                        speed *= 0.277777778f;
                        break;
                    }
                case "m/s":
                    {

                        break;
                    }
                case "mi/h":
                    {
                        speed *= 0.44704f;
                        break;
                    }


            }
            return speed;
        }


    }
}
