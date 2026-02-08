using MoneyTracer.Model;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
//todo : update spending by spending page
//todo : output buffer value
//todo : load & save the spending data
//todo : saving should be interact with spending
//todo : check if the money is correct
//todo : design

//not that important
//todo : Loading default file
//todo : save files location

namespace MoneyTracer
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Global Value
        /// </summary>
        private int balance = JsonData.BalanceValue;

        /// <summary>
        /// Global Value
        /// </summary>
        private Dictionary<string, int> savingDataDictionary = JsonData.SavingMoneyData;

        /// <summary>
        /// Global Value
        /// </summary>
        private Dictionary<string, int> weekBudgetDataDictionary = JsonData.WeekBalanceData;

        /// <summary>
        /// Global Value
        /// </summary>
        private Dictionary<string, int> spendingDataDictionary = JsonData.SpendingData;

        /// <summary>
        /// Global Value
        /// </summary>
        private Dictionary<string, int> walletDataDictionary = JsonData.WalletData;

        /// <summary>
        /// Global Value
        /// </summary>
        //private Dictionary<string, int> bufferLogDictionary = new Dictionary<string, int>();

        /// <summary>
        /// Display spending in view
        /// </summary>
        public int savingTotal = 0;

        /// <summary>
        /// Display spending in view
        /// </summary>
        public int spendingTotal = 0;

        /// <summary>
        /// Display buffer in view
        /// </summary>
        public decimal bufferValue = 0;

        /// <summary>
        /// Display spending in view
        /// </summary>
        public decimal walletTotal = 0;

        /// <summary>
        /// Count the buffer
        /// </summary>
        private decimal previousVal = 0;

        /// <summary>
        /// Count the buffer
        /// </summary>
        private decimal nowVal = 0;

        private readonly string titleBalance = "Balance : $";
        private readonly string titleBuffer = "Buffer Cash Usage : $";
        private readonly string titleTotalSaving = "Total Saving : $";
        private readonly string titleTotalSpending = "Total Spending : $";
        private readonly string titleTotalWallet = "Wallet : $";


        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //Setup the homepage
            initializeTheHomePage();

            //Setup the saving page
            initializeTheSpendingPage();

            //Setup the wallet page
            initializeTheWalletPage();
        }

        private void ClearAllWalletDisplayValue()
        {
            walletTotal = 0;

            txtBoxWalletName.Text = string.Empty;
            txtBoxWalletMoney.Text = string.Empty;
            var panelControls = walletPanel.Controls;
            for (int i = panelControls.Count - 1; i > -1; i--)
            {
                if (panelControls[i] is NumericUpDown theNumUpDown)
                {
                    walletPanel.Controls.Remove(theNumUpDown);
                }
            }

        }

        private void initializeTheWalletPage()
        {
            //empty the value
            ClearAllWalletDisplayValue();

            //set size, make txtboxWallet's height stay in 26
            Size sizeOfTxtMoney = new Size(txtBoxWalletMoney.Size.Width, 26);
            Size sizeOfTxtName = new Size(txtBoxWalletName.Size.Width, 26);
            txtBoxWalletMoney.Size = sizeOfTxtMoney;
            txtBoxWalletName.Size = sizeOfTxtName;

            //this is for numericUpDown
            int numUpDownX = txtBoxWalletMoney.Location.X + 50;
            int numUpDownY = txtBoxWalletMoney.Location.Y - 46;
            int loopCount = 0;

            //getting wallet data
            //modifying
            GetWalletDataAndAppendThetitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update total value
            //walletTotal += balance; ???

            txtWalletTotal.Text = titleTotalWallet + decimalSpreadtor(walletTotal.ToString());
        }

        private string decimalSpreadtor(string val)
        {
            if (val[0] != '-')
            {
                if (val.Length > 6)
                {
                    MessageBox.Show("shit");
                    val = val.Insert(val.Length - 6, ",");
                    val = val.Insert(val.Length - 3, ",");
                }
                else if (val.Length > 3)
                {
                    val = val.Insert(val.Length - 3, ",");
                }
                
            }
            else if (val[0] == '-')
            {
                if (val.Length > 7)
                {
                    val = val.Insert(val.Length - 6, ",");
                    val = val.Insert(val.Length - 3, ",");
                }
                else if (val.Length > 4)
                {
                    val = val.Insert(val.Length - 3, ",");
                }
                
            }
            return val;
        }

        private void AddingNumUpDownOnWalletpage(int numUpDownX, ref int numUpDownY, int loopCount, int itemValue, Panel thePanel)
        {
            numUpDownY += 44;

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Name = $"numericUpDownWallet {loopCount}"; //space is required, because it'll split by space later
            numericUpDown.Location = new Point(numUpDownX, numUpDownY);
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 1000000;
            numericUpDown.Value = itemValue;
            numericUpDown.Size = new Size(91, 27);
            numericUpDown.TextAlign = HorizontalAlignment.Right;
            numericUpDown.ThousandsSeparator = true;
            numericUpDown.TextChanged += numericUpDownWallet_TextChanged;
            numericUpDown.GotFocus += numericUpDown_focus;
            numericUpDown.MouseWheel += numericUpDown_focus;
            numericUpDown.BackColor = Color.Beige;
            thePanel.Controls.Add(numericUpDown);
        }

        private void AddingNumUpDownOnHomepage(int numUpDownX, ref int numUpDownY, int loopCount, int itemValue, Panel thePanel)
        {
            numUpDownY += 44;

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Name = $"numericUpDown {loopCount}"; //space is required, because it'll split by space later
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
            thePanel.Controls.Add(numericUpDown);
        }

        private void ModeSwitch1AddOrDel(bool isAddModeNow)
        {
            panelAddSaving.Visible = isAddModeNow;
            panelDeleteSaving.Visible = !isAddModeNow;
        }

        private void ModeSwitch2AddOrDel(bool isAddModeNow)
        {
            panelAddSpending.Visible = isAddModeNow;
            panelDeleteSpending.Visible = !isAddModeNow;
        }

        private void ClearAllSavingDisplayValue()
        {
            savingTotal = 0;

            previousVal = 0;
            nowVal = 0;

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
            savingMoneyInputBox.Text = string.Empty;
            savingNameInputBox.Text = string.Empty;
            
        }

        private void AddSaveDataToDelList()
        {
            cboDelSavingList.Items.Clear();
            foreach (var item in savingDataDictionary)
            {
                cboDelSavingList.Items.Add(item.Key);
            }
            if (cboDelSavingList.SelectedIndex == -1 && cboDelSavingList.Items.Count > 0) cboDelSavingList.SelectedIndex = 0;
            else cboDelSavingList.Text = string.Empty;

            //Mode select - add or delete
            if (cboModeSelectorHomepage.SelectedIndex == -1) cboModeSelectorHomepage.SelectedIndex = 0;
        }

        private void AddSpendningDataToDelList()
        {
            cboDelSpendingList.Items.Clear();
            foreach (var item in spendingDataDictionary)
            {
                cboDelSpendingList.Items.Add(item.Key);
            }
            if (cboDelSpendingList.SelectedIndex == -1 && cboDelSpendingList.Items.Count > 0) cboDelSpendingList.SelectedIndex = 0;
            else cboDelSpendingList.Text = string.Empty;

            //Mode select - add or delete
            if (cboModeSelectorSpending.SelectedIndex == -1) cboModeSelectorSpending.SelectedIndex = 0;
        }

        private void GetWalletDataAndAppendThetitleAndNumBox(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in walletDataDictionary)
            {
                loopCount++;
                walletTotal += item.Value;

                //name length limit
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
                txtBoxWalletName.Text += $"{name}\n\n";
                txtBoxWalletMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtBoxWalletMoney.Size = AddSizeToTheControl(txtBoxWalletMoney.Size);
                txtBoxWalletName.Size = AddSizeToTheControl(txtBoxWalletName.Size);

                //adding nummeric shit
                AddingNumUpDownOnWalletpage(numUpDownX, ref numUpDownY, loopCount, item.Value, walletPanel);


                txtBoxWalletMoney.Visible = false;
            }
        }

        private void GetSavingDataAndAppendTheTitleAndNumBox(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in savingDataDictionary)
            {
                loopCount++;
                savingTotal += item.Value;

                //name length limit
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
                AddingNumUpDownOnHomepage(numUpDownX, ref numUpDownY, loopCount, item.Value, savingPanel);
            }
        }

        private void GetSpendingDataAndAppendTheTitleAndMoneyVal(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in spendingDataDictionary)
            {
                loopCount++;
                spendingTotal += item.Value;

                //name length limit
                string name = item.Key;
                if (name.Length > 24)
                {
                    name = name.Remove(name.Length - 1, 1);
                    name = name.Insert(name.Length - 1, "...");
                }

                //money comma add
                int theMoney = item.Value;
                theMoney *= -1;
                string moneyVal = theMoney.ToString();
                moneyVal = decimalSpreadtor(moneyVal);

                //insert value
                txtBoxSpendingName.Text += $"{name}\n\n";
                txtBoxSpendingMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtBoxSpendingMoney.Size = AddSizeToTheControl(txtBoxSpendingMoney.Size);
                txtBoxSpendingName.Size = AddSizeToTheControl(txtBoxSpendingName.Size);
            }
        }

        private void GetWeekBudgetDataAndAppendTheTitleAndNumBox(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in weekBudgetDataDictionary)
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
                AddingNumUpDownOnHomepage(numUpDownX, ref numUpDownY, loopCount, item.Value, savingPanel);
            }
        }

        private void initializeTheHomePage()
        {
            //empty the value
            ClearAllSavingDisplayValue();

            //set size, make txtboxSaving's height stay in 26
            Size sizeOfTxtMoney = new Size(txtboxSavingMoney.Size.Width, 26);
            Size sizeOfTxtName = new Size(txtboxSavingName.Size.Width, 26);
            txtboxSavingMoney.Size = sizeOfTxtMoney;
            txtboxSavingName.Size = sizeOfTxtName;

            //this is for numericUpDown
            int numUpDownX = txtboxSavingMoney.Location.X + 50;
            int numUpDownY = txtboxSavingMoney.Location.Y - 46;
            int loopCount = 0;

            //getting saving data
            GetSavingDataAndAppendTheTitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //Get weekBudget data
            GetWeekBudgetDataAndAppendTheTitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //get balance value
            txtBalance.Text = titleBalance + decimalSpreadtor(balance.ToString());

            //update total value
            savingTotal += balance;
            txtTotalSaving.Text = titleTotalSaving + decimalSpreadtor(savingTotal.ToString());
            txtBalance.Text = titleBalance + decimalSpreadtor((balance + bufferValue).ToString());

            //add save data to del list
            AddSaveDataToDelList();
        }

        private void ClearAllSpendingDisplayValue()
        {
            txtBoxSpendingName.Text = string.Empty;
            txtBoxSpendingMoney.Text = string.Empty;

            spendingMoneyInputBox.Text = string.Empty;
            spendingNameInputBox.Text = string.Empty;
            spendingTotal = 0;
        }
        private void initializeTheSpendingPage()
        {
            //empty the value
            ClearAllSpendingDisplayValue();

            //set size, make txtBoxSpending's height stay in 26
            Size sizeOfTxtMoney = new Size(txtBoxSpendingMoney.Size.Width, 26);
            Size sizeOfTxtName = new Size(txtBoxSpendingName.Size.Width, 26);
            txtBoxSpendingMoney.Size = sizeOfTxtMoney;
            txtBoxSpendingName.Size = sizeOfTxtName;

            //this is for numericUpDown
            int numUpDownX = txtBoxSpendingMoney.Location.X + 50;
            int numUpDownY = txtBoxSpendingMoney.Location.Y - 46;
            int loopCount = 0;

            //getting spending data
            GetSpendingDataAndAppendTheTitleAndMoneyVal(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update total value
            txtSpendingTotal.Text = titleTotalSpending + decimalSpreadtor(spendingTotal.ToString());

            //add spending data to del list
            AddSpendningDataToDelList();
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

        private void UpdateBufferCashLog(NumericUpDown theControl, decimal bufferValue)
        {
            //test if i can get the name of control
            //labelTest.Text = theControl.Name;

            //get sorted num by spliting the name
            string[] splitedString = theControl.Name.Split(" ");
            int sequence = Convert.ToInt32(splitedString[1]) - 1;
            int loopCount = 0;
            bool isSpendingNameFound = false;

            //Find saving name in savingDataDictionary
            foreach (var item in savingDataDictionary)
            {
                if (loopCount == sequence)
                {
                    string name = item.Key;

                    //check if the if the saving name is exist in stored data, if not, create a new key
                    if (StoredData.bufferLogDictionary.ContainsKey(name) == false) StoredData.bufferLogDictionary.Add(name, 0);
                    StoredData.bufferLogDictionary[name] += Convert.ToInt32(bufferValue);

                    //display my debug infomation
                    //labelTest.Text += $"\n{name}";

                    isSpendingNameFound = true;
                    break;
                }
                loopCount++;
            }
            foreach (var item in weekBudgetDataDictionary)
            {
                if (isSpendingNameFound == true) break;
                if (loopCount == sequence)
                {
                    string name = item.Key;

                    //check if the if the saving name is exist in stored data, if not, create a new key
                    if (StoredData.bufferLogDictionary.ContainsKey(name) == false) StoredData.bufferLogDictionary.Add(name,0);
                    StoredData.bufferLogDictionary[name] += Convert.ToInt32(bufferValue);

                    //display my debug infomation
                    //labelTest.Text += $"\n{name}";

                    isSpendingNameFound = true;
                    break;
                }
                loopCount++;
            }
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            NumericUpDown theControl = new NumericUpDown();
            if (sender is NumericUpDown a)
            {
                theControl = a;
                //Text content validity check
                if (string.IsNullOrEmpty(a.Text)) a.Text = "0";
                if (a.Text[0] == ',') a.Text = a.Text.Remove(0, 1);
                a.Text = a.Text.Replace("-", string.Empty); //just in case that convert to int failly

                //make current value as previous value
                previousVal = nowVal;

                //update the current value
                nowVal = Convert.ToDecimal(a.Text);            
            }

            //subtract each other
            bufferValue -= nowVal - previousVal;
            txtBuffer.Text = titleBuffer + decimalSpreadtor(bufferValue.ToString());

            //update buffer cash data
            UpdateBufferCashLog(theControl, (nowVal - previousVal));

            //Update the display text
            DoValueUpdate();
        }

        private void numericUpDownWallet_TextChanged(object sender, EventArgs e)
        {
            NumericUpDown theControl = new NumericUpDown();
            if (sender is NumericUpDown a)
            {
                theControl = a;
                //Text content validity check
                if (string.IsNullOrEmpty(a.Text)) a.Text = "0";
                if (a.Text[0] == ',') a.Text = a.Text.Remove(0, 1);
                a.Text = a.Text.Replace("-", string.Empty); //just in case that convert to int failly

                //make current value as previous value
                previousVal = nowVal;

                //update the current value
                nowVal = Convert.ToDecimal(a.Text);
            }

            //subtract each other
            walletTotal += nowVal - previousVal;
            txtWalletTotal.Text = titleTotalWallet + decimalSpreadtor(walletTotal.ToString());

            //update buffer cash data
            //UpdateBufferCashLog(theControl, (nowVal - previousVal));

            //Update the display text
            //DoValueUpdate();
        }

        private void spendingNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            DoValueUpdate();
        }


        /// <summary>
        /// Calculate and Update display balance & saving text
        /// </summary>
        private void DoValueUpdate()
        {
            decimal temp = balance - spendingNumUpDown.Value + bufferValue;
            txtBalance.Text = titleBalance + decimalSpreadtor(temp.ToString());

            decimal temp2 = savingTotal - spendingNumUpDown.Value;
            txtTotalSaving.Text = titleTotalSaving + decimalSpreadtor(temp2.ToString());
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDataSaving();
                MessageBox.Show("File successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Saving Fail \n{ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private Dictionary<string, int> GetOutputWalletData()
        {
            //get wallet money val
            List<int> walletMoneyList = new List<int>();
            foreach (var theChar in walletPanel.Controls)
            {
                if (theChar is NumericUpDown a)
                {
                    walletMoneyList.Add(Convert.ToInt32(a.Value));
                }
            }

            //get wallet money name
            List<string> walletNameList = new List<string>();
            foreach (var item in walletDataDictionary)
            {
                walletNameList.Add(item.Key);
            }

            Dictionary<string, int> outputWalletData = new Dictionary<string, int>();
            //add it to dictionary
            for (int i = 0; i < walletNameList.Count; i++)
            {
                outputWalletData.Add(walletNameList[i], walletMoneyList[i]);
            }

            return outputWalletData;
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
            StoredData.storedWalletData = GetOutputWalletData();

            JsonData.SavingTheData();

        }

        private int GetNumWithoutAnyCharacter(string theString)
        {
            string result = string.Empty;

            //fillter only pass '0'~'9' or '-'
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

        /// <summary>
        /// Do update because if you don't update this, it will refresh with origin data
        /// </summary>
        private void UpdateSavingDictionary()
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();

            //get all names again
            foreach (var item in savingDataDictionary)
            {
                names.Add(item.Key);
            }

            //get all money again
            foreach (var item in savingPanel.Controls)
            {
                if (item is NumericUpDown theNumUpDown)
                {
                    values.Add(Convert.ToInt32(theNumUpDown.Value));
                }
            }

            //update saving data
            for (int i = 0; i < names.Count; i++)
            {
                savingDataDictionary[names[i]] = values[i];
            }
        }

        private void UpdateBeforeReload()
        {
            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateSavingDictionary();
            //balance = GetNumWithoutAnyCharacter(txtBalance.Text); //shit this thing will cause balance repeatly minus buffer
        }
        private void addSavingButton_Click(object sender, EventArgs e)
        {
            //Check if box is empty
            if (savingNameInputBox.Text == string.Empty) return;
            if (savingMoneyInputBox.Text == string.Empty) return;

            int inputNum = 0;
            string inputName = savingNameInputBox.Text;

            //if there's char are non numbers, cancel the method
            try
            {
                inputNum = Convert.ToInt32(savingMoneyInputBox.Text);
            }
            catch
            {
                return;
            }

            //if the saving less than 0, return
            if (inputNum < 0) return;

            //check if there's exist saving name
            foreach (string item in savingDataDictionary.Keys)
            {
                if (item == inputName) return;
            }

            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            savingDataDictionary.Add(inputName, inputNum);
            MainView_Load(sender, e);
        }

        private void cboModeSelector1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorHomepage.SelectedIndex == 0) ModeSwitch1AddOrDel(true);
            else if (cboModeSelectorHomepage.SelectedIndex == 1) ModeSwitch1AddOrDel(false);
        }

        private void cboModeSelector2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorSpending.SelectedIndex == 0) ModeSwitch2AddOrDel(true);
            else if (cboModeSelectorSpending.SelectedIndex == 1) ModeSwitch2AddOrDel(false);
        }

        private void btnDelSaving_Click(object sender, EventArgs e)
        {
            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            savingDataDictionary.Remove(cboDelSavingList.Text);
            MainView_Load(sender, e);
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                JsonData.LoadFilePath = _openFileDialog.FileName;
            }

            balance = JsonData.BalanceValue;
            savingDataDictionary = JsonData.SavingMoneyData;
            weekBudgetDataDictionary = JsonData.WeekBalanceData;

            bufferValue = 0;
            txtBuffer.Text = titleBuffer + bufferValue.ToString();
            MainView_Load(sender, e);
        }

        private void butDelSpendingList_Click(object sender, EventArgs e)
        {
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            spendingDataDictionary.Remove(cboDelSpendingList.Text);
            MainView_Load(sender, e);
        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            //Check if box is empty
            if (spendingNameInputBox.Text == string.Empty) return;
            if (spendingMoneyInputBox.Text == string.Empty) return;

            int inputNum = 0;
            string inputName = spendingNameInputBox.Text;

            //if there's char are non numbers, cancel the method
            try
            {
                inputNum = Convert.ToInt32(spendingMoneyInputBox.Text);
            }
            catch
            {
                return;
            }

            //check if there's exist spending name
            foreach (string item in spendingDataDictionary.Keys)
            {
                if (item == inputName) return;
            }

            //update spendingData & Balance Values just in case be replaced with origin data
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            spendingDataDictionary.Add(inputName, inputNum);
            MainView_Load(sender, e);
        }
    }
}
