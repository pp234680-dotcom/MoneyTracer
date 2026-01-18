using MoneyTracer.Model;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace MoneyTracer
{
    public partial class MainView : Form
    {
        public int savingTotal = 0;
        public decimal recharge = 0;
        private decimal rechargeSize1 = 0;
        private decimal previousVal1 = 0;
        private decimal nowVal1 = 0;
        private decimal rechargeSize2 = 0;
        private decimal previousVal2 = 0;
        private decimal nowVal2 = 0;
        private bool isTypeIn = false;

        public MainView()
        {
            InitializeComponent();
        }

        private string decimalSpreadtor(string val)
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
            return val;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            txtboxSavingName.Text = string.Empty;
            txtboxSavingMoney.Text = string.Empty;
            Dictionary<string, int> savingData = testJsonData.SavingMoneyData;
            int loopCount = 0;
            int numUpDownX = txtboxSavingMoney.Location.X + 50;
            int numUpDownY = txtboxSavingMoney.Location.Y - 46;

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
                numUpDownY += 44;
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Name = $"numericUpDown{loopCount}";
                numericUpDown.Location = new Point(numUpDownX, numUpDownY);
                numericUpDown.Minimum = 0;
                numericUpDown.Maximum = 1000000;
                numericUpDown.Value = item.Value;
                numericUpDown.Size = new Size(91, 27);
                numericUpDown.TextAlign = HorizontalAlignment.Right;
                numericUpDown.ThousandsSeparator = true;
                numericUpDown.TextChanged += numericUpDown_TextChanged;
                //numericUpDown.ValueChanged += numericUpDown_ValueChanged;
                numericUpDown.GotFocus += numericUpDown_focus;
                numericUpDown.MouseWheel += numericUpDown_focus;
                numericUpDown.BackColor = Color.Beige;
                panel3.Controls.Add(numericUpDown);
            }

            //update total value
            string savingTotolToString = savingTotal.ToString();
            savingTotolToString = decimalSpreadtor(savingTotolToString);
            txtBankTotal.Text = $"Total Saving : ${savingTotolToString}";
        }

        private static Size AddSizeToTheControl(Size theSize)
        {
            int w = theSize.Width;
            int h = theSize.Height;
            h += 40;
            theSize = new Size(w, h);
            return theSize;
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //if (sender is NumericUpDown a)
            //{
            //    previousVal1 = Convert.ToDecimal(a.Text);
            //    nowVal1 = a.Value;
            //    rechargeSize1 = nowVal1 - previousVal1;
            //    recharge -= rechargeSize1;
            //    txtBankTotal.Focus();
            //}
            //if (isTypeIn)
            //{
            //    isTypeIn = false;
            //    return;
            //}
            //txtCharge.Text = recharge.ToString();

        }

        private void numericUpDown_focus(object sender, EventArgs e)
        {
            if (sender is NumericUpDown a)
            {
                //Get current value 
                nowVal2 = Convert.ToDecimal(a.Text);
            }
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown a)
            {
                //Text content validity check
                if (string.IsNullOrEmpty(a.Text)) a.Text = "0";
                if (a.Text[0] == ',') a.Text = a.Text.Remove(0, 1);

                //check if user use type in method
                if (Convert.ToDecimal(a.Text) != a.Value) return;

                //make current value as previous value
                previousVal2 = nowVal2;
                
                //update the current value
                nowVal2 = Convert.ToDecimal(a.Text);
            }

            //tell another method current is type in mode
            isTypeIn = true;

            //subtract each other
            rechargeSize2 = nowVal2 - previousVal2;
            recharge -= rechargeSize2;
            txtCharge.Text = recharge.ToString();
        }

        
    }
}
