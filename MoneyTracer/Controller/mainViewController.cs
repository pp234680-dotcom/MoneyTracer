using MoneyTracer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracer.Controller
{
    internal class mainViewController
    {
        public static void initializeTotalMoneyTxtTSize(Label theName, Label theMoney)
        {
            //set size, make txtboxWallet's height stay in 26
            Size sizeOfTxtMoney = new Size(theMoney.Size.Width, 26);
            Size sizeOfTxtName = new Size(theName.Size.Width, 26);
            theName.Size = sizeOfTxtName;
            theMoney.Size = sizeOfTxtMoney;
        }

        public static string decimalSpreadtor(string val)
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

        public static Size AddSizeToTheControl(Size theSize)
        {
            int w = theSize.Width;
            int h = theSize.Height;
            h += 43;
            theSize = new Size(w, h);
            return theSize;
        }

        public static List<string> GetAllNameFromLabel(Label theNameLabel)
        {
            string names = theNameLabel.Text;
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

        public static List<string> GetAllNameFromDictionary(Dictionary<string,int> theDataDictionary)
        {
            List<string> savingNameList = new List<string>();
            foreach (var item in theDataDictionary)
            {
                savingNameList.Add(item.Key);
            }

            return savingNameList;
        }

        public static List<int> GetAllMoneyFromNummericUpDown(Panel thePanel)
        {
            List<int> savingMoneyList = new List<int>();

            foreach (var theChar in thePanel.Controls)
            {
                if (theChar is NumericUpDown a)
                {
                    savingMoneyList.Add(Convert.ToInt32(a.Value));
                }
            }

            return savingMoneyList;
        }

        public static int GetAllMoneyFromLabelOneLine(Label theMoneyLabel)
        {
            string a = theMoneyLabel.Text;
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

        public static List<int> GetAllMoneyFromLabel(Label theMoneyLabel)
        {
            List<int> spendingMoneyList = new List<int>();
            string money = theMoneyLabel.Text;
            money = money.Replace("$", string.Empty);
            money = money.Replace(",", string.Empty);
            string tempResult = string.Empty;
            foreach (var theChar in money)
            {
                if (theChar == '\n')
                {
                    if (tempResult == string.Empty) continue;
                    spendingMoneyList.Add(Convert.ToInt32(tempResult) * -1);
                    tempResult = string.Empty;
                }
                else
                {
                    tempResult += theChar;
                }
            }

            return spendingMoneyList;
        }

        public static Dictionary<string, int> GetOutputDataOfCertainTab(Label theNameLabel, Label theMoneyLabel)
        {
            //get spending money val
            List<int> spendingMoneyList = mainViewController.GetAllMoneyFromLabel(theMoneyLabel);

            //get spending money name
            List<string> spendingNameList = mainViewController.GetAllNameFromLabel(theNameLabel);

            //add it to dictionary
            Dictionary<string, int> outputSpendingData = new Dictionary<string, int>();
            for (int i = 0; i < spendingNameList.Count; i++)
            {
                outputSpendingData.Add(spendingNameList[i], spendingMoneyList[i]);
            }

            return outputSpendingData;
        }

        public static Dictionary<string, int> GetOutputDataOfCertainTab(Label theNameLabel, Panel theMoneyPanel)
        {
            //get spending money val
            List<int> spendingMoneyList = mainViewController.GetAllMoneyFromNummericUpDown(theMoneyPanel);

            //get spending money name
            List<string> spendingNameList = mainViewController.GetAllNameFromLabel(theNameLabel);

            //add it to dictionary
            Dictionary<string, int> outputSpendingData = new Dictionary<string, int>();
            for (int i = 0; i < spendingNameList.Count; i++)
            {
                outputSpendingData.Add(spendingNameList[i], spendingMoneyList[i]);
            }

            return outputSpendingData;
        }

        public static int GetNumWithoutAnyCharacter(string theString)
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

        public delegate void ButtonAdd_ClickEvent(object sender, KeyEventArgs e);

        public static void theAddMoneyInputBox_KeyDown(object sender, KeyEventArgs e, ButtonAdd_ClickEvent theEvent, TextBox theNameInputBox)
        {
            if (e.KeyCode == Keys.Enter)
            {
                theEvent(sender, e);
                e.SuppressKeyPress = true; //Damn this thing can prevent getting system Ding sound when press enter
                theNameInputBox.Focus();
            }
        }

        public static void RemoveEmptyDataFromDictionary(ref Dictionary<string, int> theDirctionary)
        {
            List<string> names = new List<string>();
            foreach(var item in theDirctionary)
            {
                names.Add(item.Key);
            }

            for(int i = names.Count-1; i >= 0; i--)
            {
                string theName = names[i];
                if (theDirctionary[theName] == 0) theDirctionary.Remove(theName);
            }
        }

        public static void AddDataToDeletingComboBoxItem(ComboBox theDelSavingComboBox, Dictionary<string,int>theDataDictionary, ComboBox cboModeSelector)
        {
            theDelSavingComboBox.Items.Clear();
            foreach (var item in theDataDictionary)
            {
                theDelSavingComboBox.Items.Add(item.Key);
            }
            if (theDelSavingComboBox.SelectedIndex == -1 && theDelSavingComboBox.Items.Count > 0) theDelSavingComboBox.SelectedIndex = 0;
            else theDelSavingComboBox.Text = string.Empty;

            //Mode select - add or delete
            if (cboModeSelector.SelectedIndex == -1) cboModeSelector.SelectedIndex = 0;
        }

        public static void TextBoxTabIndexChange(TextBox currentOne, TextBox theOtherOne)
        {
            currentOne.TabIndex = 1;
            theOtherOne.TabIndex = 2;
        }

        public static string GetCurrentFileTime()
        {
            DateTime _dateTime = DateTime.Now;
            string theTime = _dateTime.ToString();
            theTime = theTime.Replace("/", string.Empty);
            theTime = theTime.Replace(':', '.');

            return theTime;
        }

        public static void SaveScreenShots(FlowLayoutPanel flowPanelScreenshot)
        {
            if (flowPanelScreenshot.Controls.Count < 1) return;

            string theTime = GetCurrentFileTime();
            int num = 1;

            List<PictureBox> pictureBoxes = new List<PictureBox>();
            foreach (var item in flowPanelScreenshot.Controls)
            {
                if (item is PictureBox thePictureBox)
                {
                    pictureBoxes.Add(thePictureBox);
                }
            }

            foreach (PictureBox thePictureBox in pictureBoxes)
            {
                Image theImage = thePictureBox.BackgroundImage;
                string filePath = $"{JsonData.OutputDataFolder}{theTime} screenshot{num}.png";
                theImage.Save(filePath);
                num++;
            }
        }

        public static void CreatingNewEmptyJsonFileAtDefaultFolder()
        {
            //Creating a new empty Json file
            StreamWriter _streamWriter = new StreamWriter(JsonData.DefaultLoadFilePath);
            _streamWriter.Write(JsonData.emptyJsonString);
            _streamWriter.Flush();
            _streamWriter.Close();
        }
    }
}
