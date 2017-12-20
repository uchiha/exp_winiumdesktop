using exp_winiumdesktop.pages;
using exp_winiumdesktop_tests.Common.Test;
using NUnit.Framework;
using System.Threading;

namespace exp_winiumdesktop_tests
{

    [TestFixture]
    public class InitialTestOne : BaseTest
    {

        [Test]
        public void TextCompare()
        {
            MainWindow mWindow = new MainWindow(driver);
            mWindow.NewTextCompareSession();
            TextComparePage tComp = new TextComparePage(driver);
            tComp.typeFileNameAndLocLeft("this is async test");
            Thread.Sleep(1000);
        }
    }
}
