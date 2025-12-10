using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task3.V7.Lib
{
    public class Class1 : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            int[,] result = (int[,])matrix.Clone();


            int[] thirdCol = new int[rows];
            for (int i = 0; i < rows; i++)
                thirdCol[i] = result[i, 3];


            Array.Sort(thirdCol);


            for (int i = 0; i < rows; i++)
                result[i, 3] = thirdCol[i];

            return result;
        }
    }
}
