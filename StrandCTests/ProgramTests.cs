using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrandC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Furdo testadat1 = new Furdo("Sárvári Gyógy- és Wellnessfürdő;9600 Sárvár, Rákóczi u. 1.;6300;34");
        Furdo testadat2 = new Furdo("Sárvári Gyógy- és Wellnessfürdő;9600 Miskolc, Rákóczi u. 1.;6300;34");
        Furdo testadat3 = new Furdo("Sárvári Gyógy- és Wellnessfürdő;9600 5871, Rákóczi u. 1.;6300;34");
        [TestMethod()]
        public void TelepulesTest()
        {
            Assert.AreEqual("Sárvár", testadat1.Telepules());
        }
        [TestMethod()]
        public void TelepulesTestNemJoVartErtek()
        {
            Assert.AreNotEqual("KIsGéza", testadat1.Telepules());
        }
        [TestMethod()]
        public void TelepulesTestNemJoKapottertek()
        {
            Assert.AreNotEqual("Sárvár", testadat2.Telepules());
        }

    }
}