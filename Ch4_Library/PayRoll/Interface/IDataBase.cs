using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Library.PayRoll.Interface
{
    public interface IDataBase
    {
        void GetEmployee();
        void PutEmployee();
        bool PaymentsWerePostedCorrectly();
    }
}
