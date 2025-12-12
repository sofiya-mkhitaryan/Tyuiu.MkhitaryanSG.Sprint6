using Tyuiu.MkhitaryanSG.Sprint6.Task6.V22.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint6.Task6.V22.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            string wait = "MLgyapdkEPQzlIOuDWllTMRyztkPxzEVkcarVMlQunwTmf";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
