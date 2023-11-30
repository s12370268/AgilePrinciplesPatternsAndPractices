using Ch4_Library.PayRoll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Library.PayRoll.Mock
{
    public class MockDataBase : IDataBase
    {
        public void GetEmployee()
        {
            throw new NotImplementedException();
        }

        public bool PaymentsWerePostedCorrectly()
        {
            return true;
        }

        public void PutEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
