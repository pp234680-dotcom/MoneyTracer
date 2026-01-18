using System.Windows.Forms;

namespace MoneyTracer
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            spendingNumUpDown = new NumericUpDown();
            txtBalance = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            homepagePage = new TabPage();
            panel3 = new Panel();
            txtboxSavingMoney = new Label();
            txtboxSavingName = new Label();
            panel2 = new Panel();
            txtCharge = new Label();
            txtTotalSaving = new Label();
            savingPage = new TabPage();
            spendingPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)spendingNumUpDown).BeginInit();
            tabControl1.SuspendLayout();
            homepagePage.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 19);
            label5.Name = "label5";
            label5.Size = new Size(152, 19);
            label5.TabIndex = 7;
            label5.Text = "Total Status : Correct";
            // 
            // spendingNumUpDown
            // 
            spendingNumUpDown.Location = new Point(108, 61);
            spendingNumUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            spendingNumUpDown.Name = "spendingNumUpDown";
            spendingNumUpDown.Size = new Size(65, 27);
            spendingNumUpDown.TabIndex = 3;
            spendingNumUpDown.ThousandsSeparator = true;
            spendingNumUpDown.ValueChanged += spendingNumUpDown_ValueChanged;
            // 
            // txtBalance
            // 
            txtBalance.AutoSize = true;
            txtBalance.Font = new Font("Microsoft JhengHei UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtBalance.ForeColor = Color.White;
            txtBalance.Location = new Point(16, 21);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(216, 33);
            txtBalance.TabIndex = 2;
            txtBalance.Text = "Balance : $1,234";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 65);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 1;
            label3.Text = "Spending : $0";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(homepagePage);
            tabControl1.Controls.Add(savingPage);
            tabControl1.Controls.Add(spendingPage);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 625);
            tabControl1.TabIndex = 8;
            // 
            // homepagePage
            // 
            homepagePage.BackColor = Color.FloralWhite;
            homepagePage.Controls.Add(label5);
            homepagePage.Controls.Add(panel3);
            homepagePage.Controls.Add(panel2);
            homepagePage.Location = new Point(4, 28);
            homepagePage.Name = "homepagePage";
            homepagePage.Padding = new Padding(3);
            homepagePage.Size = new Size(465, 593);
            homepagePage.TabIndex = 1;
            homepagePage.Text = "Homepage";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.LightYellow;
            panel3.Controls.Add(txtboxSavingMoney);
            panel3.Controls.Add(txtboxSavingName);
            panel3.Location = new Point(15, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 357);
            panel3.TabIndex = 9;
            // 
            // txtboxSavingMoney
            // 
            txtboxSavingMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtboxSavingMoney.Location = new Point(247, 19);
            txtboxSavingMoney.Name = "txtboxSavingMoney";
            txtboxSavingMoney.Size = new Size(135, 26);
            txtboxSavingMoney.TabIndex = 9;
            txtboxSavingMoney.Text = "Money(inactive)";
            txtboxSavingMoney.TextAlign = ContentAlignment.TopRight;
            txtboxSavingMoney.Visible = false;
            // 
            // txtboxSavingName
            // 
            txtboxSavingName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtboxSavingName.Location = new Point(3, 19);
            txtboxSavingName.Name = "txtboxSavingName";
            txtboxSavingName.Size = new Size(238, 26);
            txtboxSavingName.TabIndex = 9;
            txtboxSavingName.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(spendingNumUpDown);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCharge);
            panel2.Controls.Add(txtBalance);
            panel2.Controls.Add(txtTotalSaving);
            panel2.Location = new Point(15, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 165);
            panel2.TabIndex = 8;
            // 
            // txtCharge
            // 
            txtCharge.AutoSize = true;
            txtCharge.ForeColor = Color.White;
            txtCharge.Location = new Point(16, 95);
            txtCharge.Name = "txtCharge";
            txtCharge.Size = new Size(166, 19);
            txtCharge.TabIndex = 10;
            txtCharge.Text = "Buffer Cash Usage : $0";
            // 
            // txtTotalSaving
            // 
            txtTotalSaving.AutoSize = true;
            txtTotalSaving.Font = new Font("Microsoft JhengHei UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtTotalSaving.ForeColor = Color.White;
            txtTotalSaving.Location = new Point(16, 125);
            txtTotalSaving.Name = "txtTotalSaving";
            txtTotalSaving.Size = new Size(133, 19);
            txtTotalSaving.TabIndex = 2;
            txtTotalSaving.Text = "Bank Total : $300";
            // 
            // savingPage
            // 
            savingPage.BackColor = Color.FloralWhite;
            savingPage.Location = new Point(4, 28);
            savingPage.Name = "savingPage";
            savingPage.Padding = new Padding(3);
            savingPage.Size = new Size(465, 593);
            savingPage.TabIndex = 0;
            savingPage.Text = "Saving";
            // 
            // spendingPage
            // 
            spendingPage.Location = new Point(4, 28);
            spendingPage.Name = "spendingPage";
            spendingPage.Padding = new Padding(3);
            spendingPage.Size = new Size(465, 593);
            spendingPage.TabIndex = 2;
            spendingPage.Text = "Spending";
            spendingPage.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(505, 649);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainView";
            Text = "Money Tracer beta 0.1";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)spendingNumUpDown).EndInit();
            tabControl1.ResumeLayout(false);
            homepagePage.ResumeLayout(false);
            homepagePage.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Label label3;
        private TabControl tabControl1;
        private TabPage savingPage;
        private TabPage homepagePage;
        private TabPage spendingPage;
        private Panel panel2;
        private Label txtTotalSaving;
        private Label txtboxSavingMoney;
        private Label txtboxSavingName;
        private Panel panel3;
        private Label txtCharge;
        private NumericUpDown spendingNumUpDown;
        private Label txtBalance;
    }
}
