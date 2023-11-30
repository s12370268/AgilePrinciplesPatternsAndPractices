using Ch4_Library.PayRoll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Library.PayRoll.Mock
{
    public class MockEmployee : IEmployee
    {
        public void CalculatePay()
        {
            throw new NotImplementedException();
        }

        public void PostPayment()
        {
            throw new NotImplementedException();
        }
    }
}
