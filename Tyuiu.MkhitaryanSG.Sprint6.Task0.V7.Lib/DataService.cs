//Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task0.V7.Lib
{
    public class DataService : ISprint6Task0V7
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow(x, 3) / (2 * (Math.Pow((x + 5), 2))));
            return Math.Round(res, 3);
        }
    }
}
