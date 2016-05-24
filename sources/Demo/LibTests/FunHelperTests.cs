using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTests
{
    [TestClass()]
    public class FunHelperTests
    {
        [TestMethod()]
        public void GetCallingVersionTest()
        {
            Assert.IsNotNull(FunHelper.GetCallingVersion());
        }

        [TestMethod()]
        public void GetVersionTest()
        {
            Assert.IsNotNull(FunHelper.GetVersion());
        }
    }
}