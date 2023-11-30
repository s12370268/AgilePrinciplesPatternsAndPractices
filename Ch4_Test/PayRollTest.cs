using Ch4_Library.PayRoll;
using Ch4_Library.PayRoll.Interface;
using Ch4_Library.PayRoll.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Test
{
    [TestClass]
    public class PayRollTest
    {
        [TestMethod]
        public void TestPayRoll()
        {
            IDataBase db = new MockDataBase();
            ICheckWriter cw = new MockCheckWriter();
            PayRoll payRoll = new PayRoll(db, cw);

            payRoll.PayEmployees();

            Assert.IsTrue(cw.ChecksWereWrittenCorrectly());
            Assert.IsTrue(db.PaymentsWerePostedCorrectly());
        }
    }
}
