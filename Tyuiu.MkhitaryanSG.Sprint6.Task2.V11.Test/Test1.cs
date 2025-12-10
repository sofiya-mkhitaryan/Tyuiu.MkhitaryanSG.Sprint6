using Tyuiu.MkhitaryanSG.Sprint6.Task2.V11.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task2.V11.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -15.44;
            valueWaitArray[1] = -10.93;
            valueWaitArray[2] = -7.22;
            valueWaitArray[3] = -5.04;
            valueWaitArray[4] = 0.00;
            valueWaitArray[5] = -0.3;
            valueWaitArray[6] = 2.57;
            valueWaitArray[7] = 6.4;
            valueWaitArray[8] = 10.04;
            valueWaitArray[9] = 12.72;
            valueWaitArray[10] = 14.68;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
