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
        public static Dictionary<string, int> bufferLogDictionary = new Dictionary<string, int>();
        public static int storedBalance = new int();
        public static BufferLog[] bufferLogs
        {
            get
            {
                //Make dictionary into a Object array
                List<BufferLog> resultList = new List<BufferLog>();
                foreach (var theWord in bufferLogDictionary)
                {
                    BufferLog bufferLog = new BufferLog();
                    bufferLog.name = theWord.Key;
                    bufferLog.money = theWord.Value;
                    resultList.Add(bufferLog);
                }
                return resultList.ToArray();
            }
        }
    }
}
