using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracer.Model
{
    //this is for output saving
    internal class StoredData
    {
        public static Dictionary<string, int> storedSavingData = new Dictionary<string, int>();
        public static int storedBalance = new int();
    }
}
