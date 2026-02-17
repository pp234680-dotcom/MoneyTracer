using MoneyTracer.Controller;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;



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

        public BufferLog[] bufferLogs { get; set; }
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

    public class BufferLog
    {
        public string name { get; set; }
        public int money { get; set; }
    }

    internal class JsonData
    {
        public static readonly string OutputDataFolder = @"Data\";
        static string OutputDataPath = OutputDataFolder;
        public static string LoadFilePath = @"Data\current_data.json";
        public static readonly string DefaultLoadFilePath = @"Data\current_data.json";

        static readonly string emptyJsonString = "{\n\t\"balance\": 0,\n\t\"saving\": [],\n\t\"weekBudget\": [\n\t\t{\n\t\t\t\"name\": \"Investment\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"Week 1\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"Week 2\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"Week 3\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"Week 4\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"Week 5\",\n\t\t\t\"money\": 0\n\t\t}\n\t],\n\t\"Wallet\": [\n\t\t{\n\t\t\t\"name\": \"money1000\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"money500\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"money100\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"money50\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"money10\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"money5\",\n\t\t\t\"money\": 0\n\t\t},\n\t\t{\n\t\t\t\"name\": \"money1\",\n\t\t\t\"money\": 0\n\t\t}\n\t],\n\t\"Bank\": [],\n\t\"Spending\": [],\n\t\"bufferLogs\": []\n}";

        static string JsonString
        {
            get
            {
                try
                {
                    //Checking if the json file is valid
                    string temp = File.ReadAllText(LoadFilePath);
                    JsonConvert.DeserializeObject<Rootobject>(temp);
                }
                catch(Exception ex)
                {
                    //change the path to default path
                    LoadFilePath = DefaultLoadFilePath;

                    //check if the defalut path folder is exist, if not then create a folder
                    if (File.Exists(DefaultLoadFilePath) == false)
                    {
                        string parent = Path.GetDirectoryName(DefaultLoadFilePath);
                        Directory.CreateDirectory(parent);
                    }

                    //Creating a new empty Json file
                    StreamWriter _streamWriter = new StreamWriter(DefaultLoadFilePath);
                    _streamWriter.Write(emptyJsonString);
                    _streamWriter.Flush();
                    _streamWriter.Close();
                }
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

        /// <summary>
        /// Generate file name by the date of the day, and the file path 
        /// </summary>
        private static void GetOutputFilePath()
        {
            string time = mainViewController.GetCurrentFileTime();

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

        public static Dictionary<string, int> WalletData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                foreach (Wallet item in _rootObject.Wallet)
                {
                    string name = item.name;
                    int money = item.money;
                    result.Add(name, money);
                }

                return result;
            }
        }

        public static Dictionary<string, int> BufferData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                foreach (BufferLog item in _rootObject.bufferLogs)
                {
                    string name = item.name;
                    int money = item.money;
                    result.Add(name, money);
                }

                return result;
            }
        }

        public static Dictionary<string, int> BankData
        {
            get
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                foreach (Bank item in _rootObject.Bank)
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
            List<Spending> spendings = new List<Spending>();
            List<Wallet> walletMoney = new List<Wallet>();
            List<Bank> bankMoney = new List<Bank>();
            List<BufferLog> bufferMoney = new List<BufferLog>();

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

            foreach (var item in StoredData.storedSpendingData)
            {
                Spending theCash = new Spending();
                theCash.name = item.Key;
                theCash.money = item.Value;
                spendings.Add(theCash);
            }

            foreach (var item in StoredData.storedWalletData)
            {
                if (item.Key.Contains("Money"))
                {
                    Wallet theCash = new Wallet();
                    theCash.name = item.Key;
                    theCash.money = item.Value;
                    walletMoney.Add(theCash);
                }
                else
                {
                    Bank theMoney = new Bank();
                    theMoney.name = item.Key;
                    theMoney.money = item.Value;
                    bankMoney.Add(theMoney);
                }
            }

            foreach (var theWord in StoredData.storedBufferData)
            {
                BufferLog theMoney = new BufferLog();
                theMoney.name = theWord.Key;
                theMoney.money = theWord.Value;
                bufferMoney.Add(theMoney);
            }

            Rootobject rootobject = new Rootobject();
            rootobject.saving = savings.ToArray();
            rootobject.weekBudget = weekbudgets.ToArray();
            rootobject.balance = StoredData.storedBalanceData;
            rootobject.bufferLogs = bufferMoney.ToArray();
            rootobject.Spending = spendings.ToArray();
            rootobject.Wallet = walletMoney.ToArray();
            rootobject.Bank = bankMoney.ToArray();

            string outputDataTxt = JsonConvert.SerializeObject(rootobject);
            StreamWriter _streamWriter = new StreamWriter(OutputDataPath);
            _streamWriter.Write(outputDataTxt);
            _streamWriter.Flush();
            _streamWriter.Close();
        }
    }
}
