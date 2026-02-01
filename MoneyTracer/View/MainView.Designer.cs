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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            label5 = new Label();
            spendingNumUpDown = new NumericUpDown();
            txtBalance = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            homepagePage = new TabPage();
            label1 = new Label();
            cboModeSelector1 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelAddSaving = new Panel();
            btnAddSaving = new Button();
            savingMoneyInputBox = new TextBox();
            savingNameInputBox = new TextBox();
            panelDeleteSaving = new Panel();
            cboDelSavingList = new ComboBox();
            btnDelSaving = new Button();
            savingPanel = new Panel();
            txtboxSavingMoney = new Label();
            txtboxSavingName = new Label();
            panel2 = new Panel();
            txtBuffer = new Label();
            txtTotalSaving = new Label();
            spendingPage = new TabPage();
            label6 = new Label();
            cboModeSelector2 = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelAddSpending = new Panel();
            btnAddSpending = new Button();
            spendingMoneyInputBox = new TextBox();
            spendingNameInputBox = new TextBox();
            panelDeleteSpending = new Panel();
            cboDelSpendingList = new ComboBox();
            butDelSpendingList = new Button();
            spendingPanel = new Panel();
            txtBoxSpendingMoney = new Label();
            txtBoxSpendingName = new Label();
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            _openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)spendingNumUpDown).BeginInit();
            tabControl1.SuspendLayout();
            homepagePage.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelAddSaving.SuspendLayout();
            panelDeleteSaving.SuspendLayout();
            savingPanel.SuspendLayout();
            panel2.SuspendLayout();
            spendingPage.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelAddSpending.SuspendLayout();
            panelDeleteSpending.SuspendLayout();
            spendingPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            tabControl1.Controls.Add(spendingPage);
            tabControl1.Location = new Point(12, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 658);
            tabControl1.TabIndex = 8;
            // 
            // homepagePage
            // 
            homepagePage.BackColor = Color.FloralWhite;
            homepagePage.Controls.Add(label1);
            homepagePage.Controls.Add(cboModeSelector1);
            homepagePage.Controls.Add(flowLayoutPanel1);
            homepagePage.Controls.Add(label5);
            homepagePage.Controls.Add(savingPanel);
            homepagePage.Controls.Add(panel2);
            homepagePage.Location = new Point(4, 28);
            homepagePage.Name = "homepagePage";
            homepagePage.Padding = new Padding(3);
            homepagePage.Size = new Size(465, 626);
            homepagePage.TabIndex = 1;
            homepagePage.Text = "Homepage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 238);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 13;
            label1.Text = "Mode :";
            // 
            // cboModeSelector1
            // 
            cboModeSelector1.FormattingEnabled = true;
            cboModeSelector1.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelector1.Location = new Point(28, 260);
            cboModeSelector1.Name = "cboModeSelector1";
            cboModeSelector1.Size = new Size(82, 27);
            cboModeSelector1.TabIndex = 12;
            cboModeSelector1.SelectedIndexChanged += cboModeSelector1_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panelAddSaving);
            flowLayoutPanel1.Controls.Add(panelDeleteSaving);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(140, 212);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(304, 81);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panelAddSaving
            // 
            panelAddSaving.Controls.Add(btnAddSaving);
            panelAddSaving.Controls.Add(savingMoneyInputBox);
            panelAddSaving.Controls.Add(savingNameInputBox);
            panelAddSaving.Location = new Point(3, 44);
            panelAddSaving.Name = "panelAddSaving";
            panelAddSaving.Size = new Size(289, 34);
            panelAddSaving.TabIndex = 12;
            // 
            // btnAddSaving
            // 
            btnAddSaving.BackgroundImage = (Image)resources.GetObject("btnAddSaving.BackgroundImage");
            btnAddSaving.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddSaving.Location = new Point(245, 3);
            btnAddSaving.Name = "btnAddSaving";
            btnAddSaving.Size = new Size(27, 27);
            btnAddSaving.TabIndex = 10;
            btnAddSaving.UseVisualStyleBackColor = true;
            btnAddSaving.Click += addSavingButton_Click;
            // 
            // savingMoneyInputBox
            // 
            savingMoneyInputBox.Location = new Point(156, 3);
            savingMoneyInputBox.Name = "savingMoneyInputBox";
            savingMoneyInputBox.PlaceholderText = "($$$)";
            savingMoneyInputBox.Size = new Size(81, 27);
            savingMoneyInputBox.TabIndex = 11;
            // 
            // savingNameInputBox
            // 
            savingNameInputBox.Location = new Point(6, 3);
            savingNameInputBox.Name = "savingNameInputBox";
            savingNameInputBox.PlaceholderText = "(Saving Name)";
            savingNameInputBox.Size = new Size(139, 27);
            savingNameInputBox.TabIndex = 11;
            // 
            // panelDeleteSaving
            // 
            panelDeleteSaving.Controls.Add(cboDelSavingList);
            panelDeleteSaving.Controls.Add(btnDelSaving);
            panelDeleteSaving.Location = new Point(3, 4);
            panelDeleteSaving.Name = "panelDeleteSaving";
            panelDeleteSaving.Size = new Size(289, 34);
            panelDeleteSaving.TabIndex = 12;
            // 
            // cboDelSavingList
            // 
            cboDelSavingList.FormattingEnabled = true;
            cboDelSavingList.Location = new Point(6, 3);
            cboDelSavingList.Name = "cboDelSavingList";
            cboDelSavingList.Size = new Size(139, 27);
            cboDelSavingList.TabIndex = 12;
            // 
            // btnDelSaving
            // 
            btnDelSaving.BackgroundImage = (Image)resources.GetObject("btnDelSaving.BackgroundImage");
            btnDelSaving.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelSaving.Location = new Point(156, 3);
            btnDelSaving.Name = "btnDelSaving";
            btnDelSaving.Size = new Size(27, 27);
            btnDelSaving.TabIndex = 10;
            btnDelSaving.UseVisualStyleBackColor = true;
            btnDelSaving.Click += btnDelSaving_Click;
            // 
            // savingPanel
            // 
            savingPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            savingPanel.AutoScroll = true;
            savingPanel.BackColor = Color.LightYellow;
            savingPanel.Controls.Add(txtboxSavingMoney);
            savingPanel.Controls.Add(txtboxSavingName);
            savingPanel.Location = new Point(15, 299);
            savingPanel.Name = "savingPanel";
            savingPanel.Size = new Size(431, 316);
            savingPanel.TabIndex = 9;
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
            panel2.Controls.Add(txtBuffer);
            panel2.Controls.Add(txtBalance);
            panel2.Controls.Add(txtTotalSaving);
            panel2.Location = new Point(15, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 165);
            panel2.TabIndex = 8;
            // 
            // txtBuffer
            // 
            txtBuffer.AutoSize = true;
            txtBuffer.ForeColor = Color.White;
            txtBuffer.Location = new Point(16, 105);
            txtBuffer.Name = "txtBuffer";
            txtBuffer.Size = new Size(166, 19);
            txtBuffer.TabIndex = 10;
            txtBuffer.Text = "Buffer Cash Usage : $0";
            // 
            // txtTotalSaving
            // 
            txtTotalSaving.AutoSize = true;
            txtTotalSaving.Font = new Font("Microsoft JhengHei UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtTotalSaving.ForeColor = Color.White;
            txtTotalSaving.Location = new Point(16, 137);
            txtTotalSaving.Name = "txtTotalSaving";
            txtTotalSaving.Size = new Size(133, 19);
            txtTotalSaving.TabIndex = 2;
            txtTotalSaving.Text = "Bank Total : $300";
            // 
            // spendingPage
            // 
            spendingPage.BackColor = Color.FloralWhite;
            spendingPage.Controls.Add(label6);
            spendingPage.Controls.Add(cboModeSelector2);
            spendingPage.Controls.Add(flowLayoutPanel2);
            spendingPage.Controls.Add(spendingPanel);
            spendingPage.Location = new Point(4, 28);
            spendingPage.Name = "spendingPage";
            spendingPage.Padding = new Padding(3);
            spendingPage.Size = new Size(465, 626);
            spendingPage.TabIndex = 0;
            spendingPage.Text = "Spending";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 41);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 16;
            label6.Text = "Mode :";
            // 
            // cboModeSelector2
            // 
            cboModeSelector2.FormattingEnabled = true;
            cboModeSelector2.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelector2.Location = new Point(20, 63);
            cboModeSelector2.Name = "cboModeSelector2";
            cboModeSelector2.Size = new Size(82, 27);
            cboModeSelector2.TabIndex = 15;
            cboModeSelector2.SelectedIndexChanged += cboModeSelector2_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panelAddSpending);
            flowLayoutPanel2.Controls.Add(panelDeleteSpending);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(132, 15);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(304, 81);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // panelAddSpending
            // 
            panelAddSpending.Controls.Add(btnAddSpending);
            panelAddSpending.Controls.Add(spendingMoneyInputBox);
            panelAddSpending.Controls.Add(spendingNameInputBox);
            panelAddSpending.Location = new Point(3, 44);
            panelAddSpending.Name = "panelAddSpending";
            panelAddSpending.Size = new Size(289, 34);
            panelAddSpending.TabIndex = 12;
            // 
            // btnAddSpending
            // 
            btnAddSpending.BackgroundImage = (Image)resources.GetObject("btnAddSpending.BackgroundImage");
            btnAddSpending.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddSpending.Location = new Point(245, 3);
            btnAddSpending.Name = "btnAddSpending";
            btnAddSpending.Size = new Size(27, 27);
            btnAddSpending.TabIndex = 10;
            btnAddSpending.UseVisualStyleBackColor = true;
            btnAddSpending.Click += btnAddSpending_Click;
            // 
            // spendingMoneyInputBox
            // 
            spendingMoneyInputBox.Location = new Point(156, 3);
            spendingMoneyInputBox.Name = "spendingMoneyInputBox";
            spendingMoneyInputBox.PlaceholderText = "($$$)";
            spendingMoneyInputBox.Size = new Size(81, 27);
            spendingMoneyInputBox.TabIndex = 11;
            // 
            // spendingNameInputBox
            // 
            spendingNameInputBox.Location = new Point(6, 3);
            spendingNameInputBox.Name = "spendingNameInputBox";
            spendingNameInputBox.PlaceholderText = "(Saving Name)";
            spendingNameInputBox.Size = new Size(139, 27);
            spendingNameInputBox.TabIndex = 11;
            // 
            // panelDeleteSpending
            // 
            panelDeleteSpending.Controls.Add(cboDelSpendingList);
            panelDeleteSpending.Controls.Add(butDelSpendingList);
            panelDeleteSpending.Location = new Point(3, 4);
            panelDeleteSpending.Name = "panelDeleteSpending";
            panelDeleteSpending.Size = new Size(289, 34);
            panelDeleteSpending.TabIndex = 12;
            // 
            // cboDelSpendingList
            // 
            cboDelSpendingList.FormattingEnabled = true;
            cboDelSpendingList.Location = new Point(6, 3);
            cboDelSpendingList.Name = "cboDelSpendingList";
            cboDelSpendingList.Size = new Size(139, 27);
            cboDelSpendingList.TabIndex = 12;
            // 
            // butDelSpendingList
            // 
            butDelSpendingList.BackgroundImage = (Image)resources.GetObject("butDelSpendingList.BackgroundImage");
            butDelSpendingList.BackgroundImageLayout = ImageLayout.Zoom;
            butDelSpendingList.Location = new Point(156, 3);
            butDelSpendingList.Name = "butDelSpendingList";
            butDelSpendingList.Size = new Size(27, 27);
            butDelSpendingList.TabIndex = 10;
            butDelSpendingList.UseVisualStyleBackColor = true;
            butDelSpendingList.Click += butDelSpendingList_Click;
            // 
            // spendingPanel
            // 
            spendingPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spendingPanel.AutoScroll = true;
            spendingPanel.BackColor = Color.LightYellow;
            spendingPanel.Controls.Add(txtBoxSpendingMoney);
            spendingPanel.Controls.Add(txtBoxSpendingName);
            spendingPanel.Location = new Point(17, 102);
            spendingPanel.Name = "spendingPanel";
            spendingPanel.Size = new Size(419, 502);
            spendingPanel.TabIndex = 10;
            // 
            // txtBoxSpendingMoney
            // 
            txtBoxSpendingMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBoxSpendingMoney.Location = new Point(248, 19);
            txtBoxSpendingMoney.Name = "txtBoxSpendingMoney";
            txtBoxSpendingMoney.Size = new Size(135, 26);
            txtBoxSpendingMoney.TabIndex = 9;
            txtBoxSpendingMoney.Text = "Money(inactive)";
            txtBoxSpendingMoney.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBoxSpendingName
            // 
            txtBoxSpendingName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBoxSpendingName.Location = new Point(3, 19);
            txtBoxSpendingName.Name = "txtBoxSpendingName";
            txtBoxSpendingName.Size = new Size(162, 26);
            txtBoxSpendingName.TabIndex = 9;
            txtBoxSpendingName.Text = "Name";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(505, 27);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, menuSave });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(47, 23);
            testToolStripMenuItem.Text = "File";
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(165, 26);
            menuOpen.Text = "Open Files";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(165, 26);
            menuSave.Text = "Save Files";
            menuSave.Click += menuSave_Click;
            // 
            // _openFileDialog
            // 
            _openFileDialog.FileName = "openFileDialog123";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(505, 710);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainView";
            Text = "Money Tracer beta";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)spendingNumUpDown).EndInit();
            tabControl1.ResumeLayout(false);
            homepagePage.ResumeLayout(false);
            homepagePage.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panelAddSaving.ResumeLayout(false);
            panelAddSaving.PerformLayout();
            panelDeleteSaving.ResumeLayout(false);
            savingPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            spendingPage.ResumeLayout(false);
            spendingPage.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panelAddSpending.ResumeLayout(false);
            panelAddSpending.PerformLayout();
            panelDeleteSpending.ResumeLayout(false);
            spendingPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private TabControl tabControl1;
        private TabPage homepagePage;
        private TabPage spendingPage;
        private Panel panel2;
        private Label txtTotalSaving;
        private Label txtboxSavingMoney;
        private Label txtboxSavingName;
        private Panel savingPanel;
        private Label txtBuffer;
        private NumericUpDown spendingNumUpDown;
        private Label txtBalance;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private TextBox savingMoneyInputBox;
        private TextBox savingNameInputBox;
        private Button btnAddSaving;
        private Panel panelAddSaving;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelDeleteSaving;
        private ComboBox cboDelSavingList;
        private Button btnDelSaving;
        private ComboBox cboModeSelector1;
        private Label label1;
        private OpenFileDialog _openFileDialog;
        private Label label6;
        private ComboBox cboModeSelector2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelAddSpending;
        private Button btnAddSpending;
        private TextBox spendingMoneyInputBox;
        private TextBox spendingNameInputBox;
        private Panel panelDeleteSpending;
        private ComboBox cboDelSpendingList;
        private Button butDelSpendingList;
        private Panel spendingPanel;
        private Label txtBoxSpendingMoney;
        private Label txtBoxSpendingName;
    }
}
