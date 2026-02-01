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
        public int balance { get; set; }
        public Saving[] saving { get; set; }
        public Weekbudget[] weekBudget { get; set; }
        public Wallet[] Wallet { get; set; }
        public Bank[] Bank { get; set; }
        public Spending[] Spending { get; set; }
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

    public class Wallet
    {
        public string name { get; set; }
        public int money { get; set; }
    }

    public class Bank
    {
        public string name { get; set; }
        public int money { get; set; }
    }

    public class Spending
    {
        public string name { get; set; }
        public int money { get; set; }
    }



    internal class JsonData
    {
        static string OutputDataFolder = @"C:\Users\jiahe\Documents\C#\MoneyTracer\MoneyTracer\Model\";
        static string OutputDataPath = OutputDataFolder;
        public static string LoadFilePath = @"C:\Users\jiahe\Documents\C#\MoneyTracer\MoneyTracer\Model\current_data.json";
        static string JsonString
        {
            get
            {
                return File.ReadAllText(LoadFilePath);
            }
        }

        static Rootobject _rootObject
        {
            get
            {
                return JsonConvert.DeserializeObject<Rootobject>(JsonString);
            }
        }


        private static void GetOutputFilePath()
        {

            DateTime _dateTime = DateTime.Now;
            string time = _dateTime.ToString();
            time = time.Replace('/', '_');
            time = time.Replace(':', '.');

            string fileName = $"{time} savingData.json";
            OutputDataPath = OutputDataFolder + fileName;
        }

        public static Dictionary<string, int> SavingMoneyData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                //get each item
                foreach (Saving item in _rootObject.saving)
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

                foreach (Weekbudget item in _rootObject.weekBudget)
                {
                    string name = item.name;
                    int money = item.money;
                    result.Add(name, money);
                }

                return result;
            }
        }

        public static Dictionary<string, int> SpendingData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                foreach (Spending item in _rootObject.Spending)
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
                result = _rootObject.balance;
                return result;
            }
        }

        public static void SavingTheData()
        {
            GetOutputFilePath();

            List<Saving> savings = new List<Saving>();
            List<Weekbudget> weekbudgets = new List<Weekbudget>();

            foreach (var item in StoredData.storedSavingData)
            {
                if (item.Key.Contains("Investment") || item.Key.Contains("Week"))
                {
                    Weekbudget theWeekBudget = new Weekbudget();
                    theWeekBudget.name = item.Key;
                    theWeekBudget.money = item.Value;
                    weekbudgets.Add(theWeekBudget);
                }
                else
                {
                    Saving theSaving = new Saving();
                    theSaving.name = item.Key;
                    theSaving.money = item.Value;
                    savings.Add(theSaving);
                }
            }
            Rootobject rootobject = new Rootobject();
            rootobject.saving = savings.ToArray();
            rootobject.weekBudget = weekbudgets.ToArray();
            rootobject.balance = StoredData.storedBalance;

            string outputDataTxt = JsonConvert.SerializeObject(rootobject);
            StreamWriter _streamWriter = new StreamWriter(OutputDataPath);
            _streamWriter.Write(outputDataTxt);
            _streamWriter.Flush();
            _streamWriter.Close();
        }
    }
}
