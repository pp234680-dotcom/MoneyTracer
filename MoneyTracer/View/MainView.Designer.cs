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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            homepagePage = new TabPage();
            savingPage = new TabPage();
            panel3 = new Panel();
            txtboxSavingMoney = new Label();
            txtboxSavingName = new Label();
            spendingPage = new TabPage();
            panel2 = new Panel();
            txtCharge = new Label();
            txtBankTotal = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            homepagePage.SuspendLayout();
            savingPage.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 10);
            label5.Name = "label5";
            label5.Size = new Size(152, 19);
            label5.TabIndex = 7;
            label5.Text = "Total Status : Correct";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(18, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 158);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 25);
            label4.Name = "label4";
            label4.Size = new Size(194, 33);
            label4.TabIndex = 2;
            label4.Text = "Balance : $300";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 88);
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
            homepagePage.Controls.Add(panel1);
            homepagePage.Controls.Add(label5);
            homepagePage.Location = new Point(4, 28);
            homepagePage.Name = "homepagePage";
            homepagePage.Padding = new Padding(3);
            homepagePage.Size = new Size(465, 593);
            homepagePage.TabIndex = 0;
            homepagePage.Text = "Homepage";
            // 
            // savingPage
            // 
            savingPage.BackColor = Color.FloralWhite;
            savingPage.Controls.Add(panel3);
            savingPage.Controls.Add(panel2);
            savingPage.Location = new Point(4, 28);
            savingPage.Name = "savingPage";
            savingPage.Padding = new Padding(3);
            savingPage.Size = new Size(465, 593);
            savingPage.TabIndex = 1;
            savingPage.Text = "Saving";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.LightYellow;
            panel3.Controls.Add(txtboxSavingMoney);
            panel3.Controls.Add(txtboxSavingName);
            panel3.Location = new Point(15, 193);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(txtCharge);
            panel2.Controls.Add(txtBankTotal);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 123);
            panel2.TabIndex = 8;
            // 
            // txtCharge
            // 
            txtCharge.AutoSize = true;
            txtCharge.ForeColor = Color.White;
            txtCharge.Location = new Point(171, 72);
            txtCharge.Name = "txtCharge";
            txtCharge.Size = new Size(18, 19);
            txtCharge.TabIndex = 10;
            txtCharge.Text = "0";
            // 
            // txtBankTotal
            // 
            txtBankTotal.AutoSize = true;
            txtBankTotal.Font = new Font("Microsoft JhengHei UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtBankTotal.ForeColor = Color.White;
            txtBankTotal.Location = new Point(17, 20);
            txtBankTotal.Name = "txtBankTotal";
            txtBankTotal.Size = new Size(230, 33);
            txtBankTotal.TabIndex = 2;
            txtBankTotal.Text = "Bank Total : $300";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 72);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 2;
            label1.Text = "Buffer Cash Usage : $";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(507, 649);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainView";
            Text = "Money Tracer beta 0.1";
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            homepagePage.ResumeLayout(false);
            homepagePage.PerformLayout();
            savingPage.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private TabControl tabControl1;
        private TabPage homepagePage;
        private TabPage savingPage;
        private TabPage spendingPage;
        private Panel panel2;
        private Label txtBankTotal;
        private Label label1;
        private Label txtboxSavingMoney;
        private Label txtboxSavingName;
        private Panel panel3;
        private Label txtCharge;
    }
}
