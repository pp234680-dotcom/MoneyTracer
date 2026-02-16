using MoneyTracer.Controller;
using MoneyTracer.Model;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
//todo : load buffer value
//todo : total saving is a bit weird when add or delete
//todo : week value didn't update when add or delete
//todo : buffer cash page
//todo : load & save the spending data
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
            //offset the value
            DoBalanceUpdate();

            //InitializingAllPage
            InitializingAllPage();
        }

        private void InitializingAllPage()
        {
            //Setup the saving page
            InitializeTheSpendingPage();

            //Setup the wallet page
            InitializeTheWalletPage();

            //Setup the homepage
            InitializeTheHomePage();
        }

        private void ClearAllWalletDisplayValue()
        {
            walletTotal = 0;

            txtWalletName.Text = string.Empty;
            txtWalletMoney.Text = string.Empty;

            var panelControls = panelWallet.Controls;
            for (int i = panelControls.Count - 1; i > -1; i--)
            {
                if (panelControls[i] is NumericUpDown theNumUpDown)
                {
                    panelWallet.Controls.Remove(theNumUpDown);
                }
            }

        }

        private void InitializeTheWalletPage()
        {
            //empty the value
            ClearAllWalletDisplayValue();

            //set size, make txtboxWallet's height stay in 26
            mainViewController.initializeTotalMoneyTxtTSize(txtWalletName, txtWalletMoney);

            //this is for numericUpDown
            int numUpDownX = txtWalletMoney.Location.X + 50;
            int numUpDownY = txtWalletMoney.Location.Y - 46;
            int loopCount = 0;
            GetWalletDataAndAppendThetitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update The Text
            txtWalletTotal.Text = titleTotalWallet + mainViewController.decimalSpreadtor(walletTotal.ToString());
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

        private void ModeSavingSwitchAddOrDel(bool isAddModeNow)
        {
            panelAddSaving.Visible = isAddModeNow;
            panelDeleteSaving.Visible = !isAddModeNow;
        }

        private void ModeSpendingSwitchAddOrDel(bool isAddModeNow)
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

            var panelControls = panelSaving.Controls;
            for (int i = panelControls.Count - 1; i > -1; i--)
            {
                if (panelControls[i] is NumericUpDown theNumUpDown)
                {
                    panelSaving.Controls.Remove(theNumUpDown);
                }
            }
            savingMoneyInputBox.Text = string.Empty;
            savingNameInputBox.Text = string.Empty;
        }

        private void AddSavingDataToDeletingComboBoxItem()
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
                moneyVal = mainViewController.decimalSpreadtor(moneyVal);

                //insert value
                txtWalletName.Text += $"{name}\n\n";
                txtWalletMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtWalletMoney.Size = mainViewController.AddSizeToTheControl(txtWalletMoney.Size);
                txtWalletName.Size = mainViewController.AddSizeToTheControl(txtWalletName.Size);

                //adding nummeric shit
                AddingNumUpDownOnWalletpage(numUpDownX, ref numUpDownY, loopCount, item.Value, panelWallet);


                txtWalletMoney.Visible = false;
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
                moneyVal = mainViewController.decimalSpreadtor(moneyVal);

                //insert value
                txtboxSavingName.Text += $"{name}\n\n";
                txtboxSavingMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtboxSavingMoney.Size = mainViewController.AddSizeToTheControl(txtboxSavingMoney.Size);
                txtboxSavingName.Size = mainViewController.AddSizeToTheControl(txtboxSavingName.Size);

                //adding nummeric shit
                AddingNumUpDownOnHomepage(numUpDownX, ref numUpDownY, loopCount, item.Value, panelSaving);
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
                moneyVal = mainViewController.decimalSpreadtor(moneyVal);

                //insert value
                txtBoxSpendingName.Text += $"{name}\n\n";
                txtBoxSpendingMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtBoxSpendingMoney.Size = mainViewController.AddSizeToTheControl(txtBoxSpendingMoney.Size);
                txtBoxSpendingName.Size = mainViewController.AddSizeToTheControl(txtBoxSpendingName.Size);
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
                moneyVal = mainViewController.decimalSpreadtor(moneyVal);

                //insert value
                txtboxSavingName.Text += $"{name}\n\n";
                txtboxSavingMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtboxSavingMoney.Size = mainViewController.AddSizeToTheControl(txtboxSavingMoney.Size);
                txtboxSavingName.Size = mainViewController.AddSizeToTheControl(txtboxSavingName.Size);

                //adding nummeric shit
                AddingNumUpDownOnHomepage(numUpDownX, ref numUpDownY, loopCount, item.Value, panelSaving);
            }
        }

        private void InitializeTheHomePage()
        {
            //empty the value
            ClearAllSavingDisplayValue();

            //set size, make txtboxSaving's height stay in 26
            mainViewController.initializeTotalMoneyTxtTSize(txtboxSavingName, txtboxSavingMoney);

            //setup numericUpDown value & getting saving data & Get weekBudget data
            int numUpDownX = txtboxSavingMoney.Location.X + 50;
            int numUpDownY = txtboxSavingMoney.Location.Y - 46;
            int loopCount = 0;
            GetSavingDataAndAppendTheTitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);
            GetWeekBudgetDataAndAppendTheTitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update total value
            savingTotal += balance;
            DoValueUpdate();

            //add save data to del list
            AddSavingDataToDeletingComboBoxItem();
        }

        private void ClearAllSpendingDisplayValue()
        {
            txtBoxSpendingName.Text = string.Empty;
            txtBoxSpendingMoney.Text = string.Empty;

            spendingMoneyInputBox.Text = string.Empty;
            spendingNameInputBox.Text = string.Empty;
            spendingTotal = 0;
        }
        private void InitializeTheSpendingPage()
        {
            //empty the value
            ClearAllSpendingDisplayValue();

            //set size, make txtBoxSpending's height stay in 26
            mainViewController.initializeTotalMoneyTxtTSize(txtBoxSpendingName, txtBoxSpendingMoney);

            //this is for numericUpDown
            int numUpDownX = txtBoxSpendingMoney.Location.X + 50;
            int numUpDownY = txtBoxSpendingMoney.Location.Y - 46;
            int loopCount = 0;

            //getting spending data
            GetSpendingDataAndAppendTheTitleAndMoneyVal(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update total value
            txtSpendingTotal.Text = titleTotalSpending + mainViewController.decimalSpreadtor(spendingTotal.ToString());
            txtSpendingHomepage.Text = titleTotalSpending + mainViewController.decimalSpreadtor(spendingTotal.ToString());

            //add spending data to del list
            AddSpendningDataToDelList();
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
                    if (StoredData.bufferLogDictionary.ContainsKey(name) == false) StoredData.bufferLogDictionary.Add(name, 0);
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
            txtBufferHomePage.Text = titleBuffer + mainViewController.decimalSpreadtor(bufferValue.ToString());

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
            txtWalletTotal.Text = titleTotalWallet + mainViewController.decimalSpreadtor(walletTotal.ToString());
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
            decimal tempForBalance = balance + bufferValue - spendingTotal;
            txtBalance.Text = titleBalance + mainViewController.decimalSpreadtor(tempForBalance.ToString());

            decimal tempForSaving = savingTotal - spendingTotal;
            txtTotalSaving.Text = titleTotalSaving + mainViewController.decimalSpreadtor(tempForSaving.ToString());
        }

        private void DoBalanceUpdate()
        {
            //Output Data Will save the data after minus spending
            //So when get back the data should add the spending back, to prevent Balance get reduced repeatly
            foreach (var item in spendingDataDictionary)
            {
                balance += item.Value;
            }
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

        private void SaveDataSaving()
        {
            //get the list first
            List<string> savingNameList = mainViewController.GetAllNameFromLabel(txtboxSavingName);
            List<int> savingMoneyList = mainViewController.GetAllMoneyFromNummericUpDown(panelSaving);

            //add it to dictionary
            Dictionary<string, int> outputSavingData = new Dictionary<string, int>();
            for (int i = 0; i < savingMoneyList.Count; i++)
            {
                outputSavingData.Add(savingNameList[i], savingMoneyList[i]);
            }

            StoredData.storedSavingData = outputSavingData;
            StoredData.storedBalance = mainViewController.GetAllMoneyFromLabelOneLine(txtBalance);
            StoredData.storedSpendingData = mainViewController.GetOutputDataOfCertainTab(txtBoxSpendingName, txtBoxSpendingMoney);
            StoredData.storedWalletData = mainViewController.GetOutputDataOfCertainTab(txtWalletName, panelWallet);

            JsonData.SavingTheData();

        }

        /// <summary>
        /// Do update because if you don't update this, it will refresh with origin data
        /// </summary>
        private void UpdateSavingDictionary()
        {
            List<string> names = mainViewController.GetAllNameFromDictionary(savingDataDictionary);
            List<int> values = mainViewController.GetAllMoneyFromNummericUpDown(panelSaving);

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

            //reload all pages
            InitializingAllPage();
        }

        private void cboModeSelector1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorHomepage.SelectedIndex == 0) ModeSavingSwitchAddOrDel(true);
            else if (cboModeSelectorHomepage.SelectedIndex == 1) ModeSavingSwitchAddOrDel(false);
        }

        private void cboModeSelector2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorSpending.SelectedIndex == 0) ModeSpendingSwitchAddOrDel(true);
            else if (cboModeSelectorSpending.SelectedIndex == 1) ModeSpendingSwitchAddOrDel(false);
        }

        private void btnDelSaving_Click(object sender, EventArgs e)
        {
            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            savingDataDictionary.Remove(cboDelSavingList.Text);

            //reload all pages
            InitializingAllPage();
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
            spendingDataDictionary = JsonData.SpendingData;
            walletDataDictionary = JsonData.WalletData;

            //tempShit - wait to be modify
            bufferValue = 0;
            txtBufferHomePage.Text = titleBuffer + bufferValue.ToString();

            MainView_Load(sender, e);
        }

        private void butDelSpendingList_Click(object sender, EventArgs e)
        {
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            spendingDataDictionary.Remove(cboDelSpendingList.Text);

            //reload all pages
            InitializingAllPage();
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

            //reload all pages
            InitializingAllPage();
        }
        private void spendingMoneyInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            mainViewController.theAddMoneyInputBox_KeyDown(sender, e, btnAddSpending_Click, spendingNameInputBox);
        }

        private void savingMoneyInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            mainViewController.theAddMoneyInputBox_KeyDown(sender, e, addSavingButton_Click, savingNameInputBox);
        }
    }
}
