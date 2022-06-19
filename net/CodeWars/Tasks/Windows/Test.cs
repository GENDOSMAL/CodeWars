using NUnit.Framework;

namespace Tasks.Windows
{
    [TestFixture]
    public class Test
    {
        [TestCase(1, "-----\n" +
                     "|.|.|\n" +
                     "|-+-|\n" +
                     "|.|.|\n" +
                     "-----")]
        [TestCase(3, "---------\n" +
                     "|...|...|\n" +
                     "|...|...|\n" +
                     "|...|...|\n" +
                     "|---+---|\n" +
                     "|...|...|\n" +
                     "|...|...|\n" +
                     "|...|...|\n" +
                     "---------")]
        public void FixedTests(int num, string expected)
        {
            Assert.AreEqual(expected, WinwdowTaskImpl.MakeAWindow(num));
        }
    }
}