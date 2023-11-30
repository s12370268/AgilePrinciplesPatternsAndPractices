using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Library.PayRoll.Interface
{
    public interface ICheckWriter
    {
        void WriteCheck();

        bool ChecksWereWrittenCorrectly();
    }
}
