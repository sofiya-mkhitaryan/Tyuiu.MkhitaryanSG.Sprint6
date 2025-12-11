using Tyuiu.MkhitaryanSG.Sprint6.Task5.V8.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task5.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V8.txt";
            Class1 service = new Class1();
            CollectionAssert.AreEqual(new double[] { -13, -19, -9.82, -9.71, -0.11, -17.36, -12, -12.35 }, service.LoadFromDataFile(path));
        }
    }
}
