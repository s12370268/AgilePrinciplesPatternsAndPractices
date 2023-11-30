using Ch4_Library.PayRoll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Library.PayRoll.Mock
{
    public class MockCheckWriter : ICheckWriter
    {
        public bool ChecksWereWrittenCorrectly()
        {
            return true;
        }

        public void WriteCheck()
        {
            throw new NotImplementedException();
        }
    }
}
