using MoneyTracer.Controller;
using MoneyTracer.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.Tracing;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

//todo : Add clean wallet button
//todo : Current data shouldn't save the logs
//todo : clip board that contain pic path should still ablt to send screenshot in
//todo : output buffer log is kinda weird, got a oppsite value when load the file
//todo : add Clear buffer page button

//todo : design

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
        private Dictionary<string, int> bufferDataDictionary = JsonData.BufferData;

        /// <summary>
        /// Global Value
        /// </summary>
        private Dictionary<string, int> bankDataDictionary = JsonData.BankData;

        /// <summary>
        /// Global Value
        /// </summary>
        //private Dictionary<string, int> storedBufferData = new Dictionary<string, int>();

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
        public decimal bufferTotal = 0;

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

        /// <summary>
        /// Determine if closing windows need to check, and change the title
        /// </summary>
        private bool isDataModified = false;

        private bool isFirstTimeOpened = true;

        private readonly static string titleApplication = "MoneyTracer";
        private readonly static string titleVersion = "beta 0.6.8.01";
        private readonly string titleMainViewWindowName = $"{titleApplication} {titleVersion}";
        private readonly string titleBalance = "$";
        private readonly string titleBuffer = "$";
        private readonly string titleTotalSaving = "$";
        private readonly string titleTotalSpending = "$";
        private readonly string titleSavingDifferent = "$";
        private readonly string titleTotalWallet = "$";
        private readonly string titleTotalStatus = "";
        private readonly string txtCorrect = "No Difference";
        private readonly string txtIncorrect = "Difference Detected";
        private readonly Color numericUpDownBGColor = Color.FromArgb(255, 250, 250);
        private readonly Color hoverColor = Color.FromArgb(220, 200, 200);
        



        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            //set default open file location for user opening file
            string currentDirectory = Directory.GetCurrentDirectory();
            _openFileDialog.InitialDirectory = currentDirectory + "\\Data";

            txtCurrentBufferSaving.Text = "None";

            //offset the value
            DoBalanceOffset();

            //Initializing AllData Page
            InitializingAllDataPage();

            //Initializing Screenshot Page
            InitializeScreenshotPage();

            //set window title
            SetMainViewWindowTitle();

            //set panel into round corner
            SetPanelRoundCorner();

            //tempShit - Wait to be replaced
            if(isFirstTimeOpened == true)
            {
                cleanTheLog();
                isFirstTimeOpened = false;
            }
        }

        private void InitializingAllDataPage()
        {
            //Setup the saving page
            InitializeTheSpendingPage();

            //Setup the wallet page
            InitializeTheWalletPage();

            //Setup the Buffer Cash page
            InitializeTheBufferPage();

            //Setup the homepage
            InitializeTheHomePage();

            InitialIzePanelDetailOfSaving();
        }

        private List<Panel> GetPanelTagByName(string name)
        {
            List<Panel> panels = new List<Panel>();
            foreach (var item in tabControl1.Controls)
            {
                if (item is TabPage theTab)
                {
                    foreach (var item2 in theTab.Controls)
                    {
                        if (item2 is Panel thePanel)
                        {
                            if (thePanel.Tag == name) panels.Add(thePanel);
                        }
                    }
                }
            }
            return panels;
        }





        private void SetPanelRoundCorner()
        {
            int radius = 10;
            int diameter = radius * 2;

            //round displayer panels corner
            List<Panel> panels1 = GetPanelTagByName("displayer");
            foreach (var thePanel in panels1)
            {
                GraphicsPath theShape = new GraphicsPath();
                theShape.AddArc(0, 0, diameter, diameter, 180, 90);
                theShape.AddArc((thePanel.Width - diameter), 0, diameter, diameter, 270, 90);
                theShape.AddArc((thePanel.Width - diameter), (thePanel.Height) - diameter, diameter, diameter, 0, 90);
                theShape.AddArc(0, (thePanel.Height) - diameter, diameter, diameter, 90, 90);

                //conect startPoint and endPoint
                theShape.CloseFigure();

                thePanel.Region = new Region(theShape);
            }

            //round selector panels corner
            List<Panel> panels2 = GetPanelTagByName("selector");
            foreach (var thePanel in panels2)
            {
                GraphicsPath theShape = new GraphicsPath();
                theShape.AddArc(0, 0, diameter, diameter, 180, 90);
                theShape.AddArc((thePanel.Width - diameter), 0, diameter, diameter, 270, 90);
                theShape.AddLine(thePanel.Width, (0 + diameter), thePanel.Width, (thePanel.Height));
                theShape.AddLine(thePanel.Width, thePanel.Height, 0, thePanel.Height);

                //conect startPoint and endPoint
                theShape.CloseFigure();

                thePanel.Region = new Region(theShape);
            }

            //round selector panels corner
            List<Panel> panels3 = GetPanelTagByName("displayerBottom");
            foreach (var thePanel in panels3)
            {
                GraphicsPath theShape = new GraphicsPath();
                theShape.AddLine(0, 0, thePanel.Width, 0);
                theShape.AddLine(thePanel.Width, 0, thePanel.Width, thePanel.Height);
                theShape.AddArc((thePanel.Width - diameter), (thePanel.Height - diameter), diameter, diameter, 0, 90);
                theShape.AddArc(0, (thePanel.Height - diameter), diameter, diameter, 90, 90);

                //conect startPoint and endPoint
                theShape.CloseFigure();

                thePanel.Region = new Region(theShape);
            }

        }

        private void SetMainViewWindowTitle()
        {
            string theTitleResult = titleMainViewWindowName;
            if (JsonData.LoadFilePath.Contains(JsonData.OutputFileTailNameAndFileExtension) == true)
            {
                string theDataTime = mainViewController.GetTheOpenedDataTime();
                theDataTime = theDataTime.Split(" ")[0];
                if (int.TryParse(theDataTime, out int noUse) == false) theDataTime = string.Empty;
                else theDataTime = theDataTime.Insert(0, " - ");
                theTitleResult = $"{theTitleResult}{theDataTime}";
            }
            Text = theTitleResult;
        }

        private void ClearScreenshotPage()
        {
            //Clean the items first
            for (int i = flowPanelScreenshot.Controls.Count - 1; i >= 0; i--)
            {
                if (flowPanelScreenshot.Controls[i] is PictureBox thePictureBox)
                {
                    cboDelImageList.Items.Remove(thePictureBox.Name);
                    flowPanelScreenshot.Controls.Remove(thePictureBox);
                }
            }

            cboDelImageList.Text = string.Empty;
        }

        private List<string> GetAllPicturePathWithSameTimeAsTheData()
        {
            //Read all picture with the Name that got same time as the data file's time
            //Get all the .png path in the folder
            string folderPath = Path.GetDirectoryName(JsonData.LoadFilePath);
            string[] imagesFilePath = Directory.GetFiles(folderPath, "*.png");
            if (imagesFilePath == null) return new List<string>();

            //Get the time of the data
            string dataTime = mainViewController.GetTheOpenedDataTime();

            //Only keep the file with the same time as ReadData's time
            List<string> picturePaths = new List<string>();
            foreach (var thePath in imagesFilePath)
            {
                if (thePath.Contains(dataTime)) picturePaths.Add(thePath);
            }

            return picturePaths;
        }

        private void AddScreenshotToFlowPanel(List<string> picturePaths)
        {
            foreach (var thePath in picturePaths)
            {
                int num = 0;
                int y = 27;
                foreach (var item in flowPanelScreenshot.Controls)
                {
                    if (item is PictureBox thePictureBox)
                    {
                        string theTempNameForNum = thePictureBox.Name;
                        string theTempNum = theTempNameForNum.Split(" ")[1];
                        num = Convert.ToInt32(theTempNum);

                        y = thePictureBox.Location.Y;
                        y += 150;
                    }
                }
                num++;
                string newPictureName = $"ScreenShot {num}";
                PictureBox newPictureBox = new PictureBox();
                newPictureBox.Name = newPictureName;
                newPictureBox.Size = new Size(460, 130);
                newPictureBox.Location = new Point(27, y);
                Image theScreenshot = Image.FromFile(thePath);
                Bitmap clonedScreenshot = new Bitmap(theScreenshot);
                theScreenshot.Dispose();
                newPictureBox.BackgroundImage = clonedScreenshot;
                newPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                flowPanelScreenshot.Controls.Add(newPictureBox);
                

                cboDelImageList.Items.Add(newPictureName);

                if (cboDelImageList.SelectedIndex == -1) cboDelImageList.SelectedIndex = 0;
            }
        }

        private void InitializeScreenshotPage()
        {
            ClearScreenshotPage();

            //Read all picture with the Name that got same time as the dataFile's time
            List<string> picturePaths = GetAllPicturePathWithSameTimeAsTheData();
            if (picturePaths == null) return;

            AddScreenshotToFlowPanel(picturePaths);
        }

        private void ClearAllWalletDisplayValue()
        {
            walletTotal = 0;

            txtWalletName.Text = string.Empty;
            txtWalletMoney.Text = string.Empty;

            bankNameInputBox.Text = string.Empty;
            bankMoneyInputBox.Text = string.Empty;

            var panelControls = panelWallet.Controls;
            for (int i = panelControls.Count - 1; i > -1; i--)
            {
                if (panelControls[i] is NumericUpDown theNumUpDown)
                {
                    panelWallet.Controls.Remove(theNumUpDown);
                }
            }

        }
        private void ClearAllBufferDisplayValue()
        {
            bufferTotal = 0;

            txtBufferName.Text = string.Empty;
            txtBufferMoney.Text = string.Empty;
        }

        private void InitializeTheBufferPage()
        {
            //empty the value
            ClearAllBufferDisplayValue();

            //set size, make txtboxWallet's height stay in 26
            mainViewController.initializeTotalMoneyTxtTSize(txtBufferName, txtBufferMoney);

            //this is for numericUpDown
            int numUpDownX = txtBufferName.Location.X + 50;
            int numUpDownY = txtBufferMoney.Location.Y - 46;
            int loopCount = 0;
            GetBufferDataAndAppendThetitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update The Text
            bufferTotal *= -1; //Total Should oppsite with bufferDataDictionary, so balance can gain the correct value
            txtBufferHomePage.Text = titleBuffer + mainViewController.decimalSpreadtor(bufferTotal.ToString());
            txtBufferTotal.Text = titleBuffer + mainViewController.decimalSpreadtor(bufferTotal.ToString());
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
            GetBankDataAndAppendThetitleAndNumBox(ref loopCount, ref numUpDownX, ref numUpDownY);

            //update The Text
            txtWalletTotal.Text = titleTotalWallet + mainViewController.decimalSpreadtor(walletTotal.ToString());
            txtWalletHomePage.Text = titleTotalWallet + mainViewController.decimalSpreadtor(walletTotal.ToString());

            //add spending data to del list
            AddBankDataToDeletingComboBoxItem();
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
            numericUpDown.GotFocus += numericUpDownWallet_focus;
            numericUpDown.MouseWheel += numericUpDownWallet_MouseWheelfocus;
            numericUpDown.LostFocus += numericUpDownWallet_OutOfFocus;
            numericUpDown.BackColor = numericUpDownBGColor;
            thePanel.Controls.Add(numericUpDown);
        }

        private void AddingNumUpDownOnHomepage(int numUpDownX, ref int numUpDownY, int loopCount, int itemValue, Panel thePanel)
        {
            numUpDownY += 50;

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
            numericUpDown.MouseWheel += numericUpDown_MouseWheelfocus;
            numericUpDown.LostFocus += numericUpDown_OutOfFocus;
            numericUpDown.BackColor = numericUpDownBGColor;
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

        private void ModeBankSwitchAddOrDel(bool isAddModeNow)
        {
            panelAddBank.Visible = isAddModeNow;
            panelDeleteBank.Visible = !isAddModeNow;
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
            mainViewController.AddDataToDeletingComboBoxItem(cboDelSavingList
                , savingDataDictionary
                , cboModeSelectorHomepage);
        }

        private void AddSpendingDataToDeletingComboBoxItem()
        {
            mainViewController.AddDataToDeletingComboBoxItem(cboDelSpendingList
                , spendingDataDictionary
                , cboModeSelectorSpending);
        }

        private void AddBankDataToDeletingComboBoxItem()
        {
            mainViewController.AddDataToDeletingComboBoxItem(cboDelBankList
                , bankDataDictionary
                , cboModeSelectorBank);
        }

        private void GetWalletDataAndAppendThetitleAndNumBox(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in walletDataDictionary)
            {
                loopCount++;
                walletTotal += item.Value;

                //name length limit
                string name = item.Key;
                if (name.Length > 32)
                {
                    name = name.Remove(name.Length - 1, name.Length - 32);
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

        private void GetBankDataAndAppendThetitleAndNumBox(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in bankDataDictionary)
            {
                loopCount++;
                walletTotal += item.Value;

                //name length limit
                string name = item.Key;
                if (name.Length > 32)
                {
                    name = name.Remove(name.Length - 1, name.Length - 32);
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

        private void GetBufferDataAndAppendThetitleAndNumBox(ref int loopCount, ref int numUpDownX, ref int numUpDownY)
        {
            foreach (var item in bufferDataDictionary)
            {
                loopCount++;
                bufferTotal += item.Value;

                //name length limit
                string name = item.Key;
                if (name.Length > 32)
                {
                    name = name.Remove(name.Length - 1, name.Length - 32);
                    name = name.Insert(name.Length - 1, "...");
                }

                //money comma add
                string moneyVal = item.Value.ToString();
                moneyVal = mainViewController.decimalSpreadtor(moneyVal);

                //insert value
                txtBufferName.Text += $"{name}\n\n";
                txtBufferMoney.Text += $"${moneyVal}\n\n";

                //set size
                txtBufferMoney.Size = mainViewController.AddSizeToTheControl(txtBufferMoney.Size);
                txtBufferName.Size = mainViewController.AddSizeToTheControl(txtBufferName.Size);
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
                //tempShit - think about if the -1 is needed
                theMoney *= -1; //to make savingPage get negative value
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
            savingTotal += Convert.ToInt32(bufferTotal);
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

            //add spending data to del list
            AddSpendingDataToDeletingComboBoxItem();
        }

        private void ThousandSpretorSwitch(NumericUpDown theNumUpDown, EventHandler TextChangedEvent, bool isTurnOn)
        {
            theNumUpDown.TextChanged -= TextChangedEvent;
            theNumUpDown.ThousandsSeparator = isTurnOn;
            theNumUpDown.TextChanged += TextChangedEvent;
        }

        private void numericUpDown_focus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown theNumUpDown)
            {
                //Get current value
                ThousandSpretorSwitch(theNumUpDown, numericUpDown_TextChanged, false);
                nowVal = Convert.ToDecimal(theNumUpDown.Text);

            }
        }
        private void numericUpDown_MouseWheelfocus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown theNumUpDown)
            {
                //Get current value
                theNumUpDown.Focus();
                ThousandSpretorSwitch(theNumUpDown, numericUpDown_TextChanged, false);
                nowVal = Convert.ToDecimal(theNumUpDown.Text);

            }
        }

        private void numericUpDownWallet_focus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown theNumUpDown)
            {
                //Get current value 
                ThousandSpretorSwitch(theNumUpDown, numericUpDownWallet_TextChanged, false);
                nowVal = Convert.ToDecimal(theNumUpDown.Text);
            }
        }

        private void numericUpDownWallet_MouseWheelfocus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown theNumUpDown)
            {
                //Get current value
                theNumUpDown.Focus();
                ThousandSpretorSwitch(theNumUpDown, numericUpDownWallet_TextChanged, false);
                nowVal = Convert.ToDecimal(theNumUpDown.Text);
            }
        }

        private void numericUpDown_OutOfFocus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown theNumUpDown)
            {
                ThousandSpretorSwitch(theNumUpDown, numericUpDown_TextChanged, true);
            }
        }

        private void numericUpDownWallet_OutOfFocus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown theNumUpDown)
            {
                ThousandSpretorSwitch(theNumUpDown, numericUpDownWallet_TextChanged, true);
            }
        }


        private void DisplayCurrentSavingBuffer(string theName)
        {
            int theValue = 0;
            foreach (var item in bufferDataDictionary)
            {
                if (item.Key == theName)
                {
                    theValue = item.Value;
                    break;
                }
            }
            txtCurrentBufferSaving.Text = $"\"{theName}\" : ${mainViewController.decimalSpreadtor(theValue.ToString())}";
        }

        private void UpdateBufferCashLog(NumericUpDown theControl, decimal bufferValue)
        {
            //get sorted num by spliting the name
            string[] splitedString = theControl.Name.Split(" ");
            int sequence = Convert.ToInt32(splitedString[1]) - 1;
            int loopCount = 0;
            bool isSpendingNameFound = false;
            string name = string.Empty;

            //Find saving name in savingDataDictionary
            foreach (var item in savingDataDictionary)
            {
                if (loopCount == sequence)
                {
                    name = item.Key;
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
                    name = item.Key;
                    isSpendingNameFound = true;
                    break;
                }
                loopCount++;
            }

            //check if the if the saving name is exist in stored data, if not, create indexOfName new key
            if (name == string.Empty) return;
            if (bufferDataDictionary.ContainsKey(name) == false) bufferDataDictionary.Add(name, 0);
            bufferDataDictionary[name] += Convert.ToInt32(bufferValue);
            mainViewController.RemoveEmptyDataFromDictionary(ref bufferDataDictionary);

            InitializeTheBufferPage();

            DisplayCurrentSavingBuffer(name);
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            //Set Data as Modified and Check If Current Data Modified
            SetDataModified(true);

            //get the control
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
            bufferTotal -= nowVal - previousVal;

            //update buffer cash data
            UpdateBufferCashLog(theControl, (nowVal - previousVal));

            //Update the display text
            DoValueUpdate();
        }

        private void numericUpDownWallet_TextChanged(object sender, EventArgs e)
        {
            //Set Data as Modified and Check If Current Data Modified
            SetDataModified(true);

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
            txtWalletHomePage.Text = titleTotalWallet + mainViewController.decimalSpreadtor(walletTotal.ToString());

            DoValueUpdate();
        }


        /// <summary>
        /// Calculate and Update display balance & saving text
        /// </summary>
        private void DoValueUpdate()
        {
            decimal tempForBalance = balance + bufferTotal - spendingTotal;
            txtBalance.Text = titleBalance + mainViewController.decimalSpreadtor(tempForBalance.ToString());

            decimal tempForSaving = savingTotal - spendingTotal;
            txtTotalSaving.Text = titleTotalSaving + mainViewController.decimalSpreadtor(tempForSaving.ToString());

            txtBufferHomePage.Text = titleBuffer + mainViewController.decimalSpreadtor(bufferTotal.ToString());


            int tempWallet = mainViewController.GetAllMoneyFromLabelOneLine(txtWalletHomePage);
            int savingDifferent = tempWallet - (int)tempForSaving;
            txtSavingDifferent.Text = titleSavingDifferent + mainViewController.decimalSpreadtor(savingDifferent.ToString());

        }

        private void DoBalanceOffset()
        {
            //tempShit - wait to be modify
            //Loading is kind of weird, so i add this to get correct negative value
            List<string> spendingNames = new List<string>();
            spendingNames = spendingDataDictionary.Keys.ToList();
            for (int i = spendingDataDictionary.Count - 1; i >= 0; i--)
            {
                string currentName = spendingNames[i];
                spendingDataDictionary[currentName] *= -1;
            }

            //Output Data Will save the data after minus spending
            //So when get back the data should add the spending back, to prevent Balance get reduced repeatly
            foreach (var item in spendingDataDictionary)
            {
                balance += item.Value;
            }

            foreach (var item in bufferDataDictionary)
            {
                balance += item.Value;
            }
        }

        private bool IsScreenshotsExist()
        {
            bool result = false;
            foreach (var item in flowPanelScreenshot.Controls)
            {
                if (item is PictureBox theImage)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            bool isScreenshotsExist = IsScreenshotsExist();
            if (isScreenshotsExist == false)
            {
                var userResponse = MessageBox.Show("Screenshots haven¡¦t been added\nDo you want to save data without screenshots?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (userResponse == DialogResult.No) return;
            }


            try
            {
                SaveDataSaving();
                mainViewController.SaveScreenShots(flowPanelScreenshot);

                //Set Data Modified Status as False, and Check If Current Data Modified
                SetDataModified(false);

                MessageBox.Show("File successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Saving Fail \n{ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveDataSaving()
        {
            StoredData.storedSavingData = mainViewController.GetOutputDataOfCertainTab(txtboxSavingName, panelSaving);
            StoredData.storedBalanceData = mainViewController.GetAllMoneyFromLabelOneLine(txtBalance);
            StoredData.storedSpendingData = mainViewController.GetOutputDataOfCertainTab(txtBoxSpendingName, txtBoxSpendingMoney);
            StoredData.storedWalletData = mainViewController.GetOutputDataOfCertainTab(txtWalletName, panelWallet);
            StoredData.storedBufferData = mainViewController.GetOutputDataOfCertainTab(txtBufferName, txtBufferMoney);

            JsonData.SavingTheData(out string theDate);
            Text = $"{titleMainViewWindowName} - {theDate}";

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

        private void UpdateWeekBalanceDictionary()
        {
            List<string> names = mainViewController.GetAllNameFromDictionary(weekBudgetDataDictionary);
            List<int> values = mainViewController.GetAllMoneyFromNummericUpDown(panelSaving);

            int limit = savingDataDictionary.Count;

            //update saving data
            for (int i = limit; i < values.Count; i++)
            {
                int indexOfName = i - limit;
                string theName = names[indexOfName];
                weekBudgetDataDictionary[theName] = values[i];
            }
        }

        private void UpdateWalletDictionary()
        {
            List<string> names = mainViewController.GetAllNameFromDictionary(walletDataDictionary);
            List<int> values = mainViewController.GetAllMoneyFromNummericUpDown(panelWallet);

            //update saving data
            for (int i = 0; i < names.Count; i++)
            {
                walletDataDictionary[names[i]] = values[i];
            }
        }

        private void UpdateBankDictionary()
        {
            List<string> names = mainViewController.GetAllNameFromDictionary(bankDataDictionary);
            List<int> values = mainViewController.GetAllMoneyFromNummericUpDown(panelWallet);

            int limit = walletDataDictionary.Count;

            //update saving data
            for (int i = limit; i < values.Count; i++)
            {
                int indexOfName = i - limit;
                string theName = names[indexOfName];
                bankDataDictionary[theName] = values[i];
            }
        }

        private void UpdateBufferDictionary()
        {
            List<string> names = mainViewController.GetAllNameFromDictionary(bufferDataDictionary);
            List<int> values = mainViewController.GetAllMoneyFromNummericUpDown(panelBuffer);

            int limit = bufferDataDictionary.Count;

            //update saving data
            for (int i = limit; i < values.Count; i++)
            {
                int indexOfName = i - limit;
                string theName = names[indexOfName];
                bufferDataDictionary[theName] = values[i];
            }
        }

        private void UpdateBeforeReload()
        {
            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateSavingDictionary();
            UpdateWeekBalanceDictionary();
            UpdateWalletDictionary();
            UpdateBankDictionary();
            UpdateBufferDictionary();
        }

        private void btnAddASavingOrSpending(TextBox theNameInputBox, TextBox theMoneyInputBox, Dictionary<string, int> theDataDictionary)
        {
            //Check if box is empty
            if (theNameInputBox.Text == string.Empty) return;
            if (theNameInputBox.Text.Count() > 24)
            {
                MessageBox.Show("Name is too long", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (theMoneyInputBox.Text == string.Empty) theMoneyInputBox.Text = "0";

            int inputNum = 0;
            string inputName = theNameInputBox.Text;

            //if there's char are non numbers, cancel the method
            try
            {
                inputNum = Convert.ToInt32(theMoneyInputBox.Text);
            }
            catch
            {
                theMoneyInputBox.Text = string.Empty;
                MessageBox.Show("Please Input Numbers", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if the saving less than 0, return
            if (inputNum < 0) return;

            //check if there's exist saving name
            foreach (string item in theDataDictionary.Keys)
            {
                if (item == inputName) return;
            }

            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            theDataDictionary.Add(inputName, inputNum);

            //Set Data as Modified and Check If Current Data Modified
            SetDataModified(true);

            //reload all pages
            InitializingAllDataPage();
        }

        private void btnAddSaving_Click(object sender, EventArgs e)
        {
            btnAddASavingOrSpending(savingNameInputBox, savingMoneyInputBox, savingDataDictionary);
        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            btnAddASavingOrSpending(spendingNameInputBox, spendingMoneyInputBox, spendingDataDictionary);
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            btnAddASavingOrSpending(bankNameInputBox, bankMoneyInputBox, bankDataDictionary);
        }

        private void cboModeSelectorHomepage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorHomepage.SelectedIndex == 0) ModeSavingSwitchAddOrDel(true);
            else if (cboModeSelectorHomepage.SelectedIndex == 1) ModeSavingSwitchAddOrDel(false);
        }

        private void cboModeSelectorSpending_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorSpending.SelectedIndex == 0) ModeSpendingSwitchAddOrDel(true);
            else if (cboModeSelectorSpending.SelectedIndex == 1) ModeSpendingSwitchAddOrDel(false);
        }

        private void cboModeSelectorBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModeSelectorBank.SelectedIndex == 0) ModeBankSwitchAddOrDel(true);
            else if (cboModeSelectorBank.SelectedIndex == 1) ModeBankSwitchAddOrDel(false);
        }

        private void btnDelASavingOrSpending(Dictionary<string, int> theDataDictionary, ComboBox theComboBoxList)
        {
            //update SavingData & Balance Values just in case be replaced with origin data
            UpdateBeforeReload();

            //after get update, fill the value in, and reload all the values
            theDataDictionary.Remove(theComboBoxList.Text);

            //Set Data as Modified and Check If Current Data Modified
            SetDataModified(true);

            //reload all pages
            InitializingAllDataPage();
        }

        private void btnDelSaving_Click(object sender, EventArgs e)
        {
            if (cboDelSavingList.Items.Count == 0) return;

            //check if user want to remove this deposit
            UpdateSavingDictionary();
            string theSavingName = cboDelSavingList.SelectedItem.ToString();
            if (savingDataDictionary[theSavingName] > 0)
            {
                var a = MessageBox.Show("The saving still remaining money, are you sure you want to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (a == DialogResult.No) return;
            }

            btnDelASavingOrSpending(savingDataDictionary, cboDelSavingList);
        }

        private void butDelSpendingList_Click(object sender, EventArgs e)
        {
            btnDelASavingOrSpending(spendingDataDictionary, cboDelSpendingList);
        }

        private void btnDelBank_Click(object sender, EventArgs e)
        {
            btnDelASavingOrSpending(bankDataDictionary, cboDelBankList);
        }

        private void LoadNewData(object sender, EventArgs e)
        {
            balance = JsonData.BalanceValue;
            savingDataDictionary = JsonData.SavingMoneyData;
            weekBudgetDataDictionary = JsonData.WeekBalanceData;
            spendingDataDictionary = JsonData.SpendingData;
            walletDataDictionary = JsonData.WalletData;
            bufferDataDictionary = JsonData.BufferData;
            bankDataDictionary = JsonData.BankData;

            MainView_Load(sender, e);
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    JsonData.LoadFilePath = _openFileDialog.FileName;
                }
                else
                {
                    return;
                }

                LoadNewData(sender, e);

                DialogResult userResponse = MessageBox.Show("Do you want to clean the log first?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (userResponse == DialogResult.Yes) cleanTheLogToolStripMenuItem_Click(sender, e);

                //Set Data Modified Status as False, and Check If Current Data Modified
                SetDataModified(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void spendingMoneyInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            mainViewController.theAddMoneyInputBox_KeyDown(sender, e, btnAddSpending_Click, spendingNameInputBox);
        }

        private void savingMoneyInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            mainViewController.theAddMoneyInputBox_KeyDown(sender, e, btnAddSaving_Click, savingNameInputBox);
        }

        private void bankMoneyInputBox_Enter(object sender, EventArgs e)
        {
            mainViewController.TextBoxTabIndexChange(bankMoneyInputBox, bankNameInputBox);
        }

        private void bankNameInputBox_Enter(object sender, EventArgs e)
        {
            mainViewController.TextBoxTabIndexChange(bankNameInputBox, bankMoneyInputBox);
        }

        private void savingMoneyInputBox_Enter(object sender, EventArgs e)
        {
            mainViewController.TextBoxTabIndexChange(savingMoneyInputBox, savingNameInputBox);
        }

        private void savingNameInputBox_Enter(object sender, EventArgs e)
        {
            mainViewController.TextBoxTabIndexChange(savingNameInputBox, savingMoneyInputBox);
        }

        private void spendingNameInputBox_Enter(object sender, EventArgs e)
        {
            mainViewController.TextBoxTabIndexChange(spendingNameInputBox, spendingMoneyInputBox);
        }

        private void spendingMoneyInputBox_Enter(object sender, EventArgs e)
        {
            mainViewController.TextBoxTabIndexChange(spendingMoneyInputBox, spendingNameInputBox);
        }

        private void bankMoneyInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            mainViewController.theAddMoneyInputBox_KeyDown(sender, e, btnAddBank_Click, bankNameInputBox);
        }

        private void timerCheckingMoney_Tick(object sender, EventArgs e)
        {
            int theBalance = mainViewController.GetAllMoneyFromLabelOneLine(txtTotalSaving);
            int theWallet = mainViewController.GetAllMoneyFromLabelOneLine(txtWalletHomePage);

            if (theBalance != theWallet)
            {
                txtTotalStaus.Text = titleTotalStatus + txtIncorrect;
                string imagePath = @"image/incorrect.png";
                picBoxCorrect.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                txtTotalStaus.Text = titleTotalStatus + txtCorrect;
                string imagePath = @"image/correct.png";
                picBoxCorrect.BackgroundImage = Image.FromFile(imagePath);
            }
        }

        private void AddImageToScreenshotPage(Image image)
        {
            int num = 0;
            int y = 27;

            foreach (var item in flowPanelScreenshot.Controls)
            {
                if (item is PictureBox thePictureBox)
                {
                    string theTempNameForNum = thePictureBox.Name;
                    string theTempNum = theTempNameForNum.Split(" ")[1];
                    num = Convert.ToInt32(theTempNum);

                    y = thePictureBox.Location.Y;
                    y += 150;
                }
            }
            num++;
            string newPictureName = $"ScreenShot {num}";
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Name = newPictureName;
            newPictureBox.Size = new Size(460, 130);
            newPictureBox.Location = new Point(27, y);
            newPictureBox.BackgroundImage = image;
            newPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            flowPanelScreenshot.Controls.Add(newPictureBox);

            cboDelImageList.Items.Add(newPictureName);

            if (cboDelImageList.SelectedIndex == -1) cboDelImageList.SelectedIndex = 0;

            //Set Data as Modified and Check If Current Data Modified
            SetDataModified(true);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage() == true)
            {
                Image image = Clipboard.GetImage();
                AddImageToScreenshotPage(image);
            }
            else if (Clipboard.ContainsFileDropList())
            {
                var pathList = Clipboard.GetFileDropList();
                foreach(var path in pathList)
                {
                    if(Path.GetExtension(path) == ".png" || Path.GetExtension(path) == ".jpg")
                    {
                        Image originImage = Image.FromFile(path);
                        Bitmap image = new Bitmap(originImage);
                        AddImageToScreenshotPage(image);
                    }
                    else
                    {
                        MessageBox.Show($"\"{Path.GetFileName(path)}\" is not an image.", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else MessageBox.Show("No image in the clipboard", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelImage_Click(object sender, EventArgs e)
        {
            string theName = string.Empty;
            if (cboDelImageList.SelectedItem != null)
            {
                theName = cboDelImageList.SelectedItem.ToString();
            }

            foreach (var item in flowPanelScreenshot.Controls)
            {
                if (item is PictureBox thePictureBox)
                {
                    if (thePictureBox.Name == theName)
                    {
                        flowPanelScreenshot.Controls.Remove(thePictureBox);

                        //Set Data as Modified and Check If Current Data Modified
                        SetDataModified(true);
                    }
                }
            }
            RearrangeScreenshotSequence();

            if (cboDelImageList.Items.Count > 0) cboDelImageList.SelectedIndex = 0;
            else cboDelImageList.Text = string.Empty;
        }

        private void RearrangeScreenshotSequence()
        {
            cboDelImageList.Items.Clear();

            int num = 1;
            foreach (var item in flowPanelScreenshot.Controls)
            {
                if (item is PictureBox thePictureBox)
                {
                    string newPictureName = $"ScreenShot {num}";
                    thePictureBox.Name = newPictureName;
                    num++;
                    cboDelImageList.Items.Add(thePictureBox.Name);
                }
            }
        }

        private void cleanTheLog()
        {
            balance = mainViewController.GetAllMoneyFromLabelOneLine(txtBalance);

            ClearAllSpendingDisplayValue();
            spendingDataDictionary = new Dictionary<string, int>();

            ClearAllBufferDisplayValue();
            bufferDataDictionary = new Dictionary<string, int>();

            //Set Data Modified Status as False, and Check If Current Data Modified
            SetDataModified(false);

            Text = titleMainViewWindowName;

            UpdateBeforeReload();
            InitializingAllDataPage();
        }

        private void cleanTheLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanTheLog();

            MessageBox.Show("All logs have been cleaned", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createANewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if yes, new file
            var result = MessageBox.Show("Are you sure you want to create a new data?\nUnsaved progress can not be recover"
                , "Message"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Information);
            if (result == DialogResult.Cancel) return;

            JsonData.LoadFilePath = JsonData.DefaultLoadFilePath;
            mainViewController.CreatingNewEmptyJsonFileAtDefaultFolder();
            LoadNewData(sender, e);

            //Set Data Modified Status as False, and Check If Current Data Modified
            SetDataModified(false);

            MessageBox.Show("New Data Sucessfully Created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void InitialIzePanelDetailOfSaving()
        {
            //Expand the detail panel, just in case the panel too short and get a wrong value of label size
            int x = txtTotalSaving.Size.Width + 100;
            int y = PanelDetailTotalSaving.Size.Height;
            Size tempSize = new Size(x, y);

            //Get Size of label and set it to detail panel
            PanelDetailTotalSaving.Size = tempSize;
            x = txtTotalSaving.Size.Width + 8;
            tempSize = new Size(x, y);
            PanelDetailTotalSaving.Size = tempSize;
        }

        private void txtTotalSaving_MouseEnter(object sender, EventArgs e)
        {
            PanelDetailTotalSaving.BackColor = hoverColor;
            Cursor = Cursors.Hand;
        }

        private void txtTotalSaving_MouseLeave(object sender, EventArgs e)
        {
            PanelDetailTotalSaving.BackColor = Color.Transparent;
            Cursor = Cursors.Default;
        }

        private void txtTotalSaving_Click(object sender, EventArgs e)
        {
            int tempBalance = mainViewController.GetAllMoneyFromLabelOneLine(txtBalance);
            int tempTotal = mainViewController.GetAllMoneyFromLabelOneLine(txtTotalSaving);
            string message = $"Balance : {tempBalance} + Total Deposit : {tempTotal - tempBalance} = Total Asset : {tempTotal}";

            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            panelBarHomepage.BackColor = Color.Transparent;
            panelBarSpending.BackColor = Color.Transparent;
            panelBarBufferCash.BackColor = Color.Transparent;
            panelBarWallet.BackColor = Color.Transparent;
            panelBarScreenshot.BackColor = Color.Transparent;

            int index = tabControl1.SelectedIndex;

            switch (index)
            {
                case 0:
                    panelBarHomepage.BackColor = Color.White;
                    break;
                case 1:
                    panelBarSpending.BackColor = Color.White;
                    break;
                case 2:
                    panelBarBufferCash.BackColor = Color.White;
                    break;
                case 3:
                    panelBarWallet.BackColor = Color.White;
                    break;
                case 4:
                    panelBarScreenshot.BackColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox thePictureBox)
            {
                thePictureBox.BackColor = hoverColor;
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox thePictureBox)
            {
                thePictureBox.BackColor = Color.Transparent;
            }
        }

        private void panelSaving_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string theFilePath = fileList[0];
                if (Path.GetExtension(theFilePath) != ".json" && Path.GetExtension(theFilePath) != ".dat")
                {
                    MessageBox.Show("Can not open the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                JsonData.LoadFilePath = theFilePath;
                LoadNewData(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void panelSaving_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Check If Current Data Modified, if true then change the title
        /// </summary>
        private void CheckIfCurrentDataModified()
        {
            if (isDataModified == true)
            {
                if (Text.Last() != '*') Text += "*";
                //Text = titleMainViewWindowName + "*";
            }
            else
            {
                if (Text.Last() == '*') Text = Text.Remove(Text.LastIndexOf("*") - 1, 1);
            }
        }

        /// <summary>
        /// Set Data as Modified and Check If Current Data Modified
        /// </summary>
        /// <param name="isModified"></param>
        private void SetDataModified(bool isModified)
        {
            isDataModified = isModified;
            CheckIfCurrentDataModified();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isDataModified == true)
            {
                string msg = "Data has been modified.\nAre you sure you want to exit without saving data?";
                DialogResult response = MessageBox.Show(msg, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                bool isUserRegretClosing = (response == DialogResult.OK) ? false : true;
                e.Cancel = isUserRegretClosing;
            }
        }
    }
}
