using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MoneyTracer.Model
{
    public class Rootobject
    {
        public List<Saving> saving { get; set; }
    }

    public class Saving
    {
        public string name { get; set; }
        public int money { get; set; }
    }


    internal class testJsonData
    {
        static string dataPath = @"C:\Users\jiahe\Documents\C#\MoneyTracer\MoneyTracer\Model\test001.json";
        public static string userMoney
        {
            get { return File.ReadAllText(dataPath); }
        }

        public static Dictionary<string, int> SavingMoneyData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                //get the root array first
                Rootobject rootArray = JsonConvert.DeserializeObject<Rootobject>(userMoney);

                //get each item
                foreach (Saving item in rootArray.saving)
                {
                    string name = item.name.ToString();
                    int money = Convert.ToInt32(item.money);
                    result.Add(name, money);
                }

                return result;
            }
        }
    }
}
