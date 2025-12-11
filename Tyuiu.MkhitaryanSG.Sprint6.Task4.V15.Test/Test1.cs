using Tyuiu.MkhitaryanSG.Sprint6.Task4.V15.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task4.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();

            var res = ds.GetMassFunction(2, 4);

            CollectionAssert.AreEqual(new double[] { 5.57, 14.02, 12.37 }, res);
        }
    }
}
