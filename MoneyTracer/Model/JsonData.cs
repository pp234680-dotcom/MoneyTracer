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
        public Saving[] saving { get; set; }
        public Weekbudget[] weekBudget { get; set; }
        public int balance { get; set; }
    }

    public class Saving
    {
        public string name { get; set; }
        public int money { get; set; }
    }

    public class Weekbudget
    {
        public string name { get; set; }
        public int money { get; set; }
    }

    internal class JsonData
    {
        static string outputDataPath = @"C:\Users\jiahe\Documents\C#\MoneyTracer\MoneyTracer\Model\testOutput001.json";
        static string dataPath = @"C:\Users\jiahe\Documents\C#\MoneyTracer\MoneyTracer\Model\test002.json";
        static Rootobject root = JsonConvert.DeserializeObject<Rootobject>(jsonString);

        public static string jsonString
        {
            get { return File.ReadAllText(dataPath); }
        }

        public static Dictionary<string, int> SavingMoneyData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                //get each item
                foreach (Saving item in root.saving)
                {
                    string name = item.name.ToString();
                    int money = Convert.ToInt32(item.money);
                    result.Add(name, money);
                }

                return result;
            }
        }

        public static Dictionary<string, int> WeekBalanceData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();
                
                foreach(Weekbudget item in root.weekBudget)
                {
                    string name = item.name;
                    int money = item.money;
                    result.Add(name, money);
                }

                return result;
            }
        }

        public static int BalanceValue
        {
            get 
            {
                int result = 0;
                result = root.balance;
                return result;
            }
        }

        public static void SavingTheData(Dictionary<string, int> outputSavingData)
        {
            List<Saving> saving = new List<Saving>();

            foreach (var item in outputSavingData)
            {
                Saving tempVar = new Saving();
                tempVar.name = item.Key;
                tempVar.money = item.Value;
                saving.Add(tempVar);
            }

            string outputDataTxt = JsonConvert.SerializeObject(saving);
            StreamWriter _streamWriter = new StreamWriter(outputDataPath);
            _streamWriter.Write(outputDataTxt);
            _streamWriter.Flush();
            _streamWriter.Close();
            //MessageBox.Show(outputDataTxt);

        }
    }
}
