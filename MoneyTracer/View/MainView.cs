using MoneyTracer.Model;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
//todo : delete saving
//todo : Load file
//todo : check if the money is correct
//todo : a button for adding new saving
//todo : design
//todo : load & save file

namespace MoneyTracer
{
    public partial class MainView : Form
    {

        public int savingTotal = 0;
        public decimal buffer = 0;
        private decimal previousVal = 0;
        private decimal nowVal = 0;
        private int balance = JsonData.BalanceValue;
        private string titleBalance = "Balance : $";
        private string titleCharge = "Buffer Cash Usage : $";
        private string titleTotalSaving = "Total Saving : $";
        private Dictionary<string, int> savingData = JsonData.SavingMoneyData;
        private Dictionary<string, int> weekBudgetData = JsonData.WeekBalanceData;

        public MainView()
        {
            InitializeComponent();
        }

        private string decimalSpreadtor(string val)
        {
            if (val[0] != '-')
            {
                if (val.Length > 3)
                {
                    val = val.Insert(val.Length - 3, ",");
                }
                else if (val.Length > 6)
                {
                    val = val.Insert(val.Length - 6, ",");
                    val = val.Insert(val.Length - 3, ",");
                }
            }
            return val;
        }

        private void AddingNumUpDown(int numUpDownX, ref int numUpDownY, int loopCount, int itemValue)
        {
            numUpDownY += 44;

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Name = $"numericUpDown{loopCount}";
            numericUpDown.Location = new Point(numUpDownX, numUpDownY);
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 1000000;
            numericUpDown.Value = itemValue;
            numericUpDown.Size = new Size(91, 27);
            numericUpDown.TextAlign = HorizontalAlignment.Right;
            numericUpDown.ThousandsSeparator = true;
            numericUpDown.TextChanged += numericUpDown_TextChanged;
            numericUpDown.GotFocus += numericUpDown_focus;
            numericUpDown.MouseWheel += numericUpDown_focus;
            numericUpDown.BackColor = Color.Beige;
            savingPanel.Controls.Add(numericUpDown);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //empty the value
            txtboxSavingName.Text = string.Empty;
            txtboxSavingMoney.Text = string.Empty;
            var panelControls = savingPanel.Controls;
            for (int i = panelControls.Count - 1; i > -1; i--) 
            {
                if (panelControls[i] is NumericUpDown theNumUpDown)
                {
                    savingPanel.Controls.Remove(theNumUpDown);
                }
            }
            

            //set size
            Size sizeOfTxtMoney = new Size(txtboxSavingMoney.Size.Width, 26);
            Size sizeOfTxtName = new Size(txtboxSavingName.Size.Width, 26);
            txtboxSavingMoney.Size = sizeOfTxtMoney;
            txtboxSavingName.Size = sizeOfTxtName;

            int numUpDownX = txtboxSavingMoney.Location.X + 50;
            int numUpDownY = txtboxSavingMoney.Location.Y - 46;
            int loopCount = 0;

            //getting saving data
            foreach (var item in savingData)
            {
                loopCount++;
                savingTotal += item.Value;

                //name lenth limit
                string name = item.Key;
                if (name.Length > 24)
                {
                    name = name.Remove(name.Length - 1, 1);
                    name = name.Insert(name.Length - 1, "...");
                }

                //money comma add
                string moneyVal = item.Value.ToString();
                moneyVal = decimalSpreadtor(moneyVal);

                //insert value
                txtboxSavingName.Text += $"{name}\n\n";
                txtboxSavingMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtboxSavingMoney.Size = AddSizeToTheControl(txtboxSavingMoney.Size);
                txtboxSavingName.Size = AddSizeToTheControl(txtboxSavingName.Size);

                //adding nummeric shit
                AddingNumUpDown(numUpDownX, ref numUpDownY, loopCount, item.Value);
            }

            //Get weekBudget data
            foreach (var item in weekBudgetData)
            {
                loopCount++;
                savingTotal += item.Value;

                //name lenth limit
                string name = item.Key;
                if (name.Length > 24)
                {
                    name = name.Remove(name.Length - 1, 1);
                    name += "...";
                }

                //money comma add
                string moneyVal = item.Value.ToString();
                moneyVal = decimalSpreadtor(moneyVal);

                //insert value
                txtboxSavingName.Text += $"{name}\n\n";
                txtboxSavingMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtboxSavingMoney.Size = AddSizeToTheControl(txtboxSavingMoney.Size);
                txtboxSavingName.Size = AddSizeToTheControl(txtboxSavingName.Size);

                //adding nummeric shit
                AddingNumUpDown(numUpDownX, ref numUpDownY, loopCount, item.Value);

            }

            //get balance value
            txtBalance.Text = titleBalance + decimalSpreadtor(balance.ToString());

            //update total value
            savingTotal += balance;
            txtTotalSaving.Text = titleTotalSaving + decimalSpreadtor(savingTotal.ToString());
        }

        private static Size AddSizeToTheControl(Size theSize)
        {
            int w = theSize.Width;
            int h = theSize.Height;
            h += 43;
            theSize = new Size(w, h);
            return theSize;
        }

        private void numericUpDown_focus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown a)
            {
                //Get current value 
                nowVal = Convert.ToDecimal(a.Text);
            }
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown a)
            {
                //Text content validity check
                if (string.IsNullOrEmpty(a.Text)) a.Text = "0";
                if (a.Text[0] == ',') a.Text = a.Text.Remove(0, 1);

                //make current value as previous value
                previousVal = nowVal;

                //update the current value
                nowVal = Convert.ToDecimal(a.Text);
            }

            //subtract each other
            buffer -= nowVal - previousVal;
            txtCharge.Text = titleCharge + decimalSpreadtor(buffer.ToString());

            DoValueUpdate();
        }

        private void spendingNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            DoValueUpdate();
        }

        private void DoValueUpdate()
        {
            decimal temp = balance - spendingNumUpDown.Value + buffer;
            txtBalance.Text = titleBalance + decimalSpreadtor(temp.ToString());

            decimal temp2 = savingTotal - spendingNumUpDown.Value;
            txtTotalSaving.Text = titleTotalSaving + decimalSpreadtor(temp2.ToString());
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveDataSaving();
            MessageBox.Show("File successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private List<string> GetAllSavingName()
        {
            string names = txtboxSavingName.Text;
            string tempResult = string.Empty;
            List<string> savingNameList = new List<string>();

            //detect per character until find "\n"
            foreach (var theChar in names)
            {
                if (theChar == '\n')
                {
                    if (tempResult == string.Empty) continue;
                    savingNameList.Add(tempResult);
                    tempResult = string.Empty;
                }
                else
                {
                    tempResult += theChar;
                }
            }

            return savingNameList;
        }

        private List<int> GetAllSavingMoney()
        {
            List<int> savingMoneyList = new List<int>();

            foreach (var theChar in savingPanel.Controls)
            {
                if (theChar is NumericUpDown a)
                {
                    savingMoneyList.Add(Convert.ToInt32(a.Value));
                }
            }

            return savingMoneyList;
        }

        private int GetBalanceNum()
        {
            string a = txtBalance.Text;
            string result = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                char theChar = a[i];
                if (theChar == '-')
                {
                    result += theChar;
                }
                else if (theChar > 47 && theChar < 58)
                {
                    result += theChar;
                }
            }

            return Convert.ToInt32(result);
        }

        private void SaveDataSaving()
        {
            //get the list first
            List<string> savingNameList = GetAllSavingName();
            List<int> savingMoneyList = GetAllSavingMoney();

            Dictionary<string, int> outputSavingData = new Dictionary<string, int>();
            //add it to dictionary
            for (int i = 0; i < savingMoneyList.Count; i++)
            {
                outputSavingData.Add(savingNameList[i], savingMoneyList[i]);
                //MessageBox.Show($"{savingNameList[i]} : {savingMoneyList[i]}");
            }

            balance = GetBalanceNum();


            StoredData.storedSavingData = outputSavingData;
            StoredData.storedBalance = balance;
            JsonData.SavingTheData();

        }

        private int GetNumWithoutAnyCharacter(string theString)
        {
            string result = string.Empty;
            foreach (char theChar in theString)
            {
                if (theChar == '-')
                {
                    result += theChar;
                }
                else if (theChar > 47 && theChar < 58)
                {
                    result += theChar;
                }
            }
            return Convert.ToInt32(result);
        }

        private void UpdateSavingDictionary()
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();

            foreach(var item in savingData)
            {
                names.Add(item.Key);
            }

            foreach(var item in savingPanel.Controls)
            {
                if(item is NumericUpDown theNumUpDown)
                {
                    values.Add(Convert.ToInt32(theNumUpDown.Value));
                }
            }

            for(int i = 0; i< names.Count; i++)
            {
                savingData[names[i]] = values[i];
            }

        }

        private void addSavingButton_Click(object sender, EventArgs e)
        {
            if (savingNameInputBox.Text == string.Empty) return;
            if (savingMoneyInputBox.Text == string.Empty) return;

            int inputNum = 0;
            string inputName = savingNameInputBox.Text;

            try
            {
                inputNum = Convert.ToInt32(savingMoneyInputBox.Text);
            }
            catch
            {
                return;
            }

            if (inputNum < 0) return;

            foreach(string item in savingData.Keys)
            {
                if (item == inputName) return;
            }

            UpdateSavingDictionary();
            balance = GetNumWithoutAnyCharacter(txtBalance.Text);

            savingData.Add(inputName, inputNum);
            MainView_Load(sender, e);
        }
    }
}
