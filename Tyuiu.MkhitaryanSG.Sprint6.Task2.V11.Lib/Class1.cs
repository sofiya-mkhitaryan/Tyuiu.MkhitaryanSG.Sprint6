using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task2.V11.Lib
{
    public class Class1 : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] value = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1)
                {
                    value[count] = 0;
                }
                else
                {
                    double y = (((Math.Cos(x) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x));
                    value[count] = Math.Round(y, 2);
                }

                count++;
            }

            return value;
        }
    }
}
