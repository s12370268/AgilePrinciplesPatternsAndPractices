using Ch4_Library.PayRoll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Library.PayRoll
{
    public class PayRoll
    {
        private readonly IDataBase _db;
        private readonly ICheckWriter _checkWriter;

        public PayRoll(IDataBase db, ICheckWriter checkWriter)
        {
            _db = db;
            _checkWriter = checkWriter;
        }

        public void PayEmployees()
        {
        }
    }
}
