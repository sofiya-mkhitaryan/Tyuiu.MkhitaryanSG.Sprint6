//Прочитать данные из файла InPutFileTask5V8.txt. Вывести в dataGridView.
//Дан список из чисел. Вывести все числа, меньше 0. Построить диаграмму по этим значениям.
//Графический интерфейс пользователя оформить по примеру из лекции.
//У вещественных значений округлить до трёх знаков после запятой.
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task5.V8.Lib
{
    public class Class1 : ISprint6Task5V8
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] res = new double[0];
            foreach (string line in lines)
            {
                string[] numberStrings = line.Split(' ');
                foreach (string numberString in numberStrings)
                {
                    double parsedNumber;
                    if (double.TryParse(numberString, out parsedNumber) && parsedNumber < 0)
                    {
                        Array.Resize(ref res, res.Length + 1);
                        res[res.Length - 1] = Math.Round(parsedNumber, 3);
                    }
                }
            }
            return res;
        }
    }
}
