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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            txtTotalStaus = new Label();
            txtBalance = new Label();
            tabControl1 = new TabControl();
            homepagePage = new TabPage();
            panel10 = new Panel();
            txtSavingDifferent = new Label();
            panel14 = new Panel();
            PanelDetailTotalSaving = new FlowLayoutPanel();
            txtTotalSaving = new Label();
            txtWalletHomePage = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            panelSaving = new Panel();
            txtboxSavingMoney = new Label();
            txtboxSavingName = new Label();
            panel8 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelAddSaving = new Panel();
            btnAddSaving = new Button();
            savingMoneyInputBox = new TextBox();
            savingNameInputBox = new TextBox();
            panelDeleteSaving = new Panel();
            cboDelSavingList = new ComboBox();
            btnDelSaving = new Button();
            label1 = new Label();
            cboModeSelectorHomepage = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            txtCurrentBufferSaving = new Label();
            label9 = new Label();
            txtBufferHomePage = new Label();
            label10 = new Label();
            spendingPage = new TabPage();
            panel12 = new Panel();
            label11 = new Label();
            txtSpendingTotal = new Label();
            panelSpending = new Panel();
            txtBoxSpendingMoney = new Label();
            txtBoxSpendingName = new Label();
            panel2 = new Panel();
            cboModeSelectorSpending = new ComboBox();
            label6 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelAddSpending = new Panel();
            btnAddSpending = new Button();
            spendingMoneyInputBox = new TextBox();
            spendingNameInputBox = new TextBox();
            panelDeleteSpending = new Panel();
            cboDelSpendingList = new ComboBox();
            btnDelSpendingList = new Button();
            bufferPage = new TabPage();
            panel13 = new Panel();
            label13 = new Label();
            txtBufferTotal = new Label();
            panelBuffer = new Panel();
            txtBufferMoney = new Label();
            txtBufferName = new Label();
            walletPage = new TabPage();
            panel9 = new Panel();
            label12 = new Label();
            txtWalletTotal = new Label();
            panel7 = new Panel();
            label2 = new Label();
            cboModeSelectorBank = new ComboBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panelAddBank = new Panel();
            btnAddBank = new Button();
            bankMoneyInputBox = new TextBox();
            bankNameInputBox = new TextBox();
            panelDeleteBank = new Panel();
            cboDelBankList = new ComboBox();
            btnDelBank = new Button();
            panelWallet = new Panel();
            txtWalletMoney = new Label();
            txtWalletName = new Label();
            ScreenshotPage = new TabPage();
            panel4 = new Panel();
            flowPanelScreenshot = new FlowLayoutPanel();
            panel11 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnAddImage = new Button();
            cboDelImageList = new ComboBox();
            btnDelImage = new Button();
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            createANewFileToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            cleanTheLogToolStripMenuItem = new ToolStripMenuItem();
            _openFileDialog = new OpenFileDialog();
            timerCheckingMoney = new System.Windows.Forms.Timer(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            tabControl1.SuspendLayout();
            homepagePage.SuspendLayout();
            panel10.SuspendLayout();
            PanelDetailTotalSaving.SuspendLayout();
            panelSaving.SuspendLayout();
            panel8.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelAddSaving.SuspendLayout();
            panelDeleteSaving.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            spendingPage.SuspendLayout();
            panel12.SuspendLayout();
            panelSpending.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelAddSpending.SuspendLayout();
            panelDeleteSpending.SuspendLayout();
            bufferPage.SuspendLayout();
            panel13.SuspendLayout();
            panelBuffer.SuspendLayout();
            walletPage.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panelAddBank.SuspendLayout();
            panelDeleteBank.SuspendLayout();
            panelWallet.SuspendLayout();
            ScreenshotPage.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // txtTotalStaus
            // 
            txtTotalStaus.AutoSize = true;
            txtTotalStaus.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            txtTotalStaus.ForeColor = Color.Gray;
            txtTotalStaus.Location = new Point(161, 78);
            txtTotalStaus.Name = "txtTotalStaus";
            txtTotalStaus.Size = new Size(118, 21);
            txtTotalStaus.TabIndex = 7;
            txtTotalStaus.Text = "Status : Correct";
            // 
            // txtBalance
            // 
            txtBalance.AutoSize = true;
            txtBalance.Font = new Font("Segoe UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBalance.ForeColor = Color.Black;
            txtBalance.Location = new Point(12, 40);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(191, 36);
            txtBalance.TabIndex = 2;
            txtBalance.Text = "Balance$1,234";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(homepagePage);
            tabControl1.Controls.Add(spendingPage);
            tabControl1.Controls.Add(bufferPage);
            tabControl1.Controls.Add(walletPage);
            tabControl1.Controls.Add(ScreenshotPage);
            tabControl1.Font = new Font("Segoe UI", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(102, 26);
            tabControl1.Location = new Point(7, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(561, 741);
            tabControl1.TabIndex = 8;
            tabControl1.TabStop = false;
            tabControl1.Tag = "selector";
            // 
            // homepagePage
            // 
            homepagePage.BackColor = Color.FromArgb(255, 245, 245);
            homepagePage.BackgroundImage = (Image)resources.GetObject("homepagePage.BackgroundImage");
            homepagePage.Controls.Add(panel10);
            homepagePage.Controls.Add(panelSaving);
            homepagePage.Controls.Add(panel8);
            homepagePage.Controls.Add(panel1);
            homepagePage.Controls.Add(panel6);
            homepagePage.Location = new Point(4, 30);
            homepagePage.Name = "homepagePage";
            homepagePage.Padding = new Padding(3);
            homepagePage.Size = new Size(553, 707);
            homepagePage.TabIndex = 1;
            homepagePage.Text = "Homepage";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(txtSavingDifferent);
            panel10.Controls.Add(txtTotalStaus);
            panel10.Controls.Add(panel14);
            panel10.Controls.Add(PanelDetailTotalSaving);
            panel10.Controls.Add(txtWalletHomePage);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(label7);
            panel10.Location = new Point(17, 138);
            panel10.Name = "panel10";
            panel10.Size = new Size(325, 107);
            panel10.TabIndex = 14;
            panel10.Tag = "displayer";
            // 
            // txtSavingDifferent
            // 
            txtSavingDifferent.AutoSize = true;
            txtSavingDifferent.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSavingDifferent.Location = new Point(159, 27);
            txtSavingDifferent.Name = "txtSavingDifferent";
            txtSavingDifferent.Size = new Size(34, 28);
            txtSavingDifferent.TabIndex = 15;
            txtSavingDifferent.Text = "$0";
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(224, 224, 224);
            panel14.Location = new Point(153, 8);
            panel14.Name = "panel14";
            panel14.Size = new Size(2, 91);
            panel14.TabIndex = 16;
            // 
            // PanelDetailTotalSaving
            // 
            PanelDetailTotalSaving.Controls.Add(txtTotalSaving);
            PanelDetailTotalSaving.Location = new Point(8, 26);
            PanelDetailTotalSaving.Name = "PanelDetailTotalSaving";
            PanelDetailTotalSaving.Size = new Size(135, 30);
            PanelDetailTotalSaving.TabIndex = 3;
            PanelDetailTotalSaving.Tag = "";
            // 
            // txtTotalSaving
            // 
            txtTotalSaving.AutoSize = true;
            txtTotalSaving.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalSaving.ForeColor = Color.Black;
            txtTotalSaving.Location = new Point(3, 0);
            txtTotalSaving.Name = "txtTotalSaving";
            txtTotalSaving.Size = new Size(56, 28);
            txtTotalSaving.TabIndex = 2;
            txtTotalSaving.Text = "$300";
            txtTotalSaving.Click += txtTotalSaving_Click;
            txtTotalSaving.MouseEnter += txtTotalSaving_MouseEnter;
            txtTotalSaving.MouseLeave += txtTotalSaving_MouseLeave;
            // 
            // txtWalletHomePage
            // 
            txtWalletHomePage.AutoSize = true;
            txtWalletHomePage.Font = new Font("Segoe UI", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWalletHomePage.ForeColor = Color.DimGray;
            txtWalletHomePage.Location = new Point(12, 79);
            txtWalletHomePage.Name = "txtWalletHomePage";
            txtWalletHomePage.Size = new Size(94, 20);
            txtWalletHomePage.TabIndex = 2;
            txtWalletHomePage.Text = "Wallet : $123";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(12, 58);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 15;
            label8.Text = "Actual Assets";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 8);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 15;
            label5.Text = "Total Assets";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(159, 8);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 15;
            label7.Text = "Assets Difference";
            // 
            // panelSaving
            // 
            panelSaving.AutoScroll = true;
            panelSaving.BackColor = Color.White;
            panelSaving.Controls.Add(txtboxSavingMoney);
            panelSaving.Controls.Add(txtboxSavingName);
            panelSaving.Location = new Point(17, 336);
            panelSaving.Name = "panelSaving";
            panelSaving.Size = new Size(519, 351);
            panelSaving.TabIndex = 9;
            // 
            // txtboxSavingMoney
            // 
            txtboxSavingMoney.Font = new Font("Noto Sans TC DemiLight", 10.2857141F);
            txtboxSavingMoney.ForeColor = Color.Black;
            txtboxSavingMoney.Location = new Point(345, 10);
            txtboxSavingMoney.Name = "txtboxSavingMoney";
            txtboxSavingMoney.Size = new Size(135, 29);
            txtboxSavingMoney.TabIndex = 9;
            txtboxSavingMoney.Text = "Money(inactive)";
            txtboxSavingMoney.TextAlign = ContentAlignment.TopRight;
            txtboxSavingMoney.Visible = false;
            // 
            // txtboxSavingName
            // 
            txtboxSavingName.Font = new Font("Noto Sans TC DemiLight", 10.2857141F);
            txtboxSavingName.ForeColor = Color.Black;
            txtboxSavingName.Location = new Point(8, 10);
            txtboxSavingName.Name = "txtboxSavingName";
            txtboxSavingName.Size = new Size(238, 29);
            txtboxSavingName.TabIndex = 9;
            txtboxSavingName.Text = "Name";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(244, 214, 214);
            panel8.Controls.Add(flowLayoutPanel1);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(cboModeSelectorHomepage);
            panel8.Location = new Point(17, 267);
            panel8.Name = "panel8";
            panel8.Size = new Size(519, 71);
            panel8.TabIndex = 14;
            panel8.Tag = "selector";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panelAddSaving);
            flowLayoutPanel1.Controls.Add(panelDeleteSaving);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(124, -24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(304, 90);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panelAddSaving
            // 
            panelAddSaving.Controls.Add(btnAddSaving);
            panelAddSaving.Controls.Add(savingMoneyInputBox);
            panelAddSaving.Controls.Add(savingNameInputBox);
            panelAddSaving.Location = new Point(3, 49);
            panelAddSaving.Name = "panelAddSaving";
            panelAddSaving.Size = new Size(289, 38);
            panelAddSaving.TabIndex = 12;
            // 
            // btnAddSaving
            // 
            btnAddSaving.BackgroundImage = (Image)resources.GetObject("btnAddSaving.BackgroundImage");
            btnAddSaving.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddSaving.Location = new Point(245, 3);
            btnAddSaving.Name = "btnAddSaving";
            btnAddSaving.Size = new Size(27, 30);
            btnAddSaving.TabIndex = 10;
            btnAddSaving.TabStop = false;
            btnAddSaving.UseVisualStyleBackColor = true;
            btnAddSaving.Click += btnAddSaving_Click;
            // 
            // savingMoneyInputBox
            // 
            savingMoneyInputBox.BackColor = Color.White;
            savingMoneyInputBox.Font = new Font("Noto Sans TC", 9.07563F);
            savingMoneyInputBox.ForeColor = Color.Black;
            savingMoneyInputBox.Location = new Point(156, 3);
            savingMoneyInputBox.Name = "savingMoneyInputBox";
            savingMoneyInputBox.PlaceholderText = "($$$)";
            savingMoneyInputBox.Size = new Size(81, 29);
            savingMoneyInputBox.TabIndex = 11;
            savingMoneyInputBox.Enter += savingMoneyInputBox_Enter;
            savingMoneyInputBox.KeyDown += savingMoneyInputBox_KeyDown;
            // 
            // savingNameInputBox
            // 
            savingNameInputBox.BackColor = Color.White;
            savingNameInputBox.Font = new Font("Noto Sans TC", 9.07563F);
            savingNameInputBox.ForeColor = Color.Black;
            savingNameInputBox.Location = new Point(6, 3);
            savingNameInputBox.Name = "savingNameInputBox";
            savingNameInputBox.PlaceholderText = "(Saving Name)";
            savingNameInputBox.Size = new Size(139, 29);
            savingNameInputBox.TabIndex = 11;
            savingNameInputBox.Enter += savingNameInputBox_Enter;
            savingNameInputBox.KeyDown += savingMoneyInputBox_KeyDown;
            // 
            // panelDeleteSaving
            // 
            panelDeleteSaving.Controls.Add(cboDelSavingList);
            panelDeleteSaving.Controls.Add(btnDelSaving);
            panelDeleteSaving.Location = new Point(3, 5);
            panelDeleteSaving.Name = "panelDeleteSaving";
            panelDeleteSaving.Size = new Size(289, 38);
            panelDeleteSaving.TabIndex = 12;
            // 
            // cboDelSavingList
            // 
            cboDelSavingList.BackColor = Color.White;
            cboDelSavingList.Font = new Font("Noto Sans TC", 9.07563F);
            cboDelSavingList.ForeColor = Color.Black;
            cboDelSavingList.FormattingEnabled = true;
            cboDelSavingList.Location = new Point(6, 3);
            cboDelSavingList.Name = "cboDelSavingList";
            cboDelSavingList.Size = new Size(139, 29);
            cboDelSavingList.TabIndex = 12;
            // 
            // btnDelSaving
            // 
            btnDelSaving.BackgroundImage = (Image)resources.GetObject("btnDelSaving.BackgroundImage");
            btnDelSaving.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelSaving.Location = new Point(156, 3);
            btnDelSaving.Name = "btnDelSaving";
            btnDelSaving.Size = new Size(27, 30);
            btnDelSaving.TabIndex = 10;
            btnDelSaving.UseVisualStyleBackColor = true;
            btnDelSaving.Click += btnDelSaving_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(9, 4);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 13;
            label1.Text = "Mode :";
            // 
            // cboModeSelectorHomepage
            // 
            cboModeSelectorHomepage.BackColor = Color.White;
            cboModeSelectorHomepage.Font = new Font("Noto Sans TC", 9.07563F);
            cboModeSelectorHomepage.ForeColor = Color.Black;
            cboModeSelectorHomepage.FormattingEnabled = true;
            cboModeSelectorHomepage.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelectorHomepage.Location = new Point(12, 29);
            cboModeSelectorHomepage.Name = "cboModeSelectorHomepage";
            cboModeSelectorHomepage.Size = new Size(82, 29);
            cboModeSelectorHomepage.TabIndex = 12;
            cboModeSelectorHomepage.SelectedIndexChanged += cboModeSelectorHomepage_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBalance);
            panel1.Location = new Point(17, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 106);
            panel1.TabIndex = 14;
            panel1.Tag = "displayer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 3;
            label4.Text = "Weekly Balance";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(txtCurrentBufferSaving);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(txtBufferHomePage);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(356, 138);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 107);
            panel6.TabIndex = 14;
            panel6.Tag = "displayer";
            // 
            // txtCurrentBufferSaving
            // 
            txtCurrentBufferSaving.AutoSize = true;
            txtCurrentBufferSaving.Font = new Font("Segoe UI", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentBufferSaving.ForeColor = Color.Gray;
            txtCurrentBufferSaving.Location = new Point(8, 81);
            txtCurrentBufferSaving.Name = "txtCurrentBufferSaving";
            txtCurrentBufferSaving.Size = new Size(45, 20);
            txtCurrentBufferSaving.TabIndex = 10;
            txtCurrentBufferSaving.Text = "None";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 8);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 15;
            label9.Text = "Reserve Fund";
            // 
            // txtBufferHomePage
            // 
            txtBufferHomePage.AutoSize = true;
            txtBufferHomePage.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBufferHomePage.ForeColor = Color.Black;
            txtBufferHomePage.Location = new Point(8, 29);
            txtBufferHomePage.Name = "txtBufferHomePage";
            txtBufferHomePage.Size = new Size(56, 28);
            txtBufferHomePage.TabIndex = 10;
            txtBufferHomePage.Text = "$123";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(8, 61);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 15;
            label10.Text = "Currently Editing";
            // 
            // spendingPage
            // 
            spendingPage.BackColor = Color.FromArgb(255, 245, 245);
            spendingPage.BackgroundImage = (Image)resources.GetObject("spendingPage.BackgroundImage");
            spendingPage.Controls.Add(panel12);
            spendingPage.Controls.Add(panelSpending);
            spendingPage.Controls.Add(panel2);
            spendingPage.Location = new Point(4, 30);
            spendingPage.Name = "spendingPage";
            spendingPage.Padding = new Padding(3);
            spendingPage.Size = new Size(553, 707);
            spendingPage.TabIndex = 0;
            spendingPage.Text = "Spending";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(label11);
            panel12.Controls.Add(txtSpendingTotal);
            panel12.Location = new Point(17, 15);
            panel12.Name = "panel12";
            panel12.Size = new Size(518, 103);
            panel12.TabIndex = 16;
            panel12.Tag = "displayer";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 13);
            label11.Name = "label11";
            label11.Size = new Size(143, 28);
            label11.TabIndex = 18;
            label11.Text = "Total Spending";
            // 
            // txtSpendingTotal
            // 
            txtSpendingTotal.AutoSize = true;
            txtSpendingTotal.Font = new Font("Segoe UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpendingTotal.Location = new Point(16, 41);
            txtSpendingTotal.Name = "txtSpendingTotal";
            txtSpendingTotal.Size = new Size(75, 36);
            txtSpendingTotal.TabIndex = 17;
            txtSpendingTotal.Text = "$123";
            // 
            // panelSpending
            // 
            panelSpending.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelSpending.AutoScroll = true;
            panelSpending.BackColor = Color.White;
            panelSpending.Controls.Add(txtBoxSpendingMoney);
            panelSpending.Controls.Add(txtBoxSpendingName);
            panelSpending.Location = new Point(17, 205);
            panelSpending.Name = "panelSpending";
            panelSpending.Size = new Size(518, 463);
            panelSpending.TabIndex = 10;
            // 
            // txtBoxSpendingMoney
            // 
            txtBoxSpendingMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBoxSpendingMoney.Location = new Point(345, 12);
            txtBoxSpendingMoney.Name = "txtBoxSpendingMoney";
            txtBoxSpendingMoney.Size = new Size(135, 29);
            txtBoxSpendingMoney.TabIndex = 9;
            txtBoxSpendingMoney.Text = "Money(inactive)";
            txtBoxSpendingMoney.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBoxSpendingName
            // 
            txtBoxSpendingName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBoxSpendingName.Location = new Point(10, 12);
            txtBoxSpendingName.Name = "txtBoxSpendingName";
            txtBoxSpendingName.Size = new Size(162, 29);
            txtBoxSpendingName.TabIndex = 9;
            txtBoxSpendingName.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 214, 214);
            panel2.Controls.Add(cboModeSelectorSpending);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Location = new Point(17, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 71);
            panel2.TabIndex = 15;
            panel2.Tag = "selector";
            // 
            // cboModeSelectorSpending
            // 
            cboModeSelectorSpending.FormattingEnabled = true;
            cboModeSelectorSpending.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelectorSpending.Location = new Point(6, 31);
            cboModeSelectorSpending.Name = "cboModeSelectorSpending";
            cboModeSelectorSpending.Size = new Size(82, 28);
            cboModeSelectorSpending.TabIndex = 15;
            cboModeSelectorSpending.SelectedIndexChanged += cboModeSelectorSpending_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 16;
            label6.Text = "Mode :";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panelAddSpending);
            flowLayoutPanel2.Controls.Add(panelDeleteSpending);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(118, -22);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(304, 90);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // panelAddSpending
            // 
            panelAddSpending.Controls.Add(btnAddSpending);
            panelAddSpending.Controls.Add(spendingMoneyInputBox);
            panelAddSpending.Controls.Add(spendingNameInputBox);
            panelAddSpending.Location = new Point(3, 49);
            panelAddSpending.Name = "panelAddSpending";
            panelAddSpending.Size = new Size(289, 38);
            panelAddSpending.TabIndex = 12;
            // 
            // btnAddSpending
            // 
            btnAddSpending.BackgroundImage = (Image)resources.GetObject("btnAddSpending.BackgroundImage");
            btnAddSpending.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddSpending.Location = new Point(245, 3);
            btnAddSpending.Name = "btnAddSpending";
            btnAddSpending.Size = new Size(27, 30);
            btnAddSpending.TabIndex = 10;
            btnAddSpending.TabStop = false;
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
            spendingMoneyInputBox.Enter += spendingMoneyInputBox_Enter;
            spendingMoneyInputBox.KeyDown += spendingMoneyInputBox_KeyDown;
            // 
            // spendingNameInputBox
            // 
            spendingNameInputBox.Location = new Point(6, 3);
            spendingNameInputBox.Name = "spendingNameInputBox";
            spendingNameInputBox.PlaceholderText = "(Spending Name)";
            spendingNameInputBox.Size = new Size(139, 27);
            spendingNameInputBox.TabIndex = 11;
            spendingNameInputBox.Enter += spendingNameInputBox_Enter;
            spendingNameInputBox.KeyDown += spendingMoneyInputBox_KeyDown;
            // 
            // panelDeleteSpending
            // 
            panelDeleteSpending.Controls.Add(cboDelSpendingList);
            panelDeleteSpending.Controls.Add(btnDelSpendingList);
            panelDeleteSpending.Location = new Point(3, 5);
            panelDeleteSpending.Name = "panelDeleteSpending";
            panelDeleteSpending.Size = new Size(289, 38);
            panelDeleteSpending.TabIndex = 12;
            // 
            // cboDelSpendingList
            // 
            cboDelSpendingList.FormattingEnabled = true;
            cboDelSpendingList.Location = new Point(6, 3);
            cboDelSpendingList.Name = "cboDelSpendingList";
            cboDelSpendingList.Size = new Size(139, 28);
            cboDelSpendingList.TabIndex = 12;
            // 
            // btnDelSpendingList
            // 
            btnDelSpendingList.BackgroundImage = (Image)resources.GetObject("btnDelSpendingList.BackgroundImage");
            btnDelSpendingList.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelSpendingList.Location = new Point(156, 3);
            btnDelSpendingList.Name = "btnDelSpendingList";
            btnDelSpendingList.Size = new Size(27, 30);
            btnDelSpendingList.TabIndex = 10;
            btnDelSpendingList.UseVisualStyleBackColor = true;
            btnDelSpendingList.Click += butDelSpendingList_Click;
            // 
            // bufferPage
            // 
            bufferPage.BackColor = Color.FromArgb(255, 245, 245);
            bufferPage.BackgroundImage = Properties.Resources.shader3;
            bufferPage.Controls.Add(panel13);
            bufferPage.Controls.Add(panelBuffer);
            bufferPage.Location = new Point(4, 30);
            bufferPage.Name = "bufferPage";
            bufferPage.Size = new Size(553, 707);
            bufferPage.TabIndex = 3;
            bufferPage.Text = "Buffer Cash";
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Controls.Add(label13);
            panel13.Controls.Add(txtBufferTotal);
            panel13.Location = new Point(17, 15);
            panel13.Name = "panel13";
            panel13.Size = new Size(518, 103);
            panel13.TabIndex = 17;
            panel13.Tag = "displayer";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(16, 13);
            label13.Name = "label13";
            label13.Size = new Size(174, 28);
            label13.TabIndex = 24;
            label13.Text = "Total Reserve Fund";
            // 
            // txtBufferTotal
            // 
            txtBufferTotal.AutoSize = true;
            txtBufferTotal.Font = new Font("Segoe UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBufferTotal.Location = new Point(16, 41);
            txtBufferTotal.Name = "txtBufferTotal";
            txtBufferTotal.Size = new Size(75, 36);
            txtBufferTotal.TabIndex = 24;
            txtBufferTotal.Text = "$123";
            // 
            // panelBuffer
            // 
            panelBuffer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelBuffer.AutoScroll = true;
            panelBuffer.BackColor = Color.White;
            panelBuffer.Controls.Add(txtBufferMoney);
            panelBuffer.Controls.Add(txtBufferName);
            panelBuffer.Location = new Point(17, 136);
            panelBuffer.Name = "panelBuffer";
            panelBuffer.Size = new Size(518, 530);
            panelBuffer.TabIndex = 23;
            panelBuffer.Tag = "displayer";
            // 
            // txtBufferMoney
            // 
            txtBufferMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBufferMoney.Location = new Point(345, 21);
            txtBufferMoney.Name = "txtBufferMoney";
            txtBufferMoney.Size = new Size(135, 29);
            txtBufferMoney.TabIndex = 9;
            txtBufferMoney.Text = "Money(inactive)";
            txtBufferMoney.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBufferName
            // 
            txtBufferName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBufferName.Location = new Point(10, 21);
            txtBufferName.Name = "txtBufferName";
            txtBufferName.Size = new Size(162, 29);
            txtBufferName.TabIndex = 9;
            txtBufferName.Text = "Name";
            // 
            // walletPage
            // 
            walletPage.BackColor = Color.FromArgb(255, 245, 245);
            walletPage.BackgroundImage = (Image)resources.GetObject("walletPage.BackgroundImage");
            walletPage.Controls.Add(panel9);
            walletPage.Controls.Add(panel7);
            walletPage.Controls.Add(panelWallet);
            walletPage.Location = new Point(4, 30);
            walletPage.Name = "walletPage";
            walletPage.Padding = new Padding(3);
            walletPage.Size = new Size(553, 707);
            walletPage.TabIndex = 2;
            walletPage.Text = "Wallet";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(label12);
            panel9.Controls.Add(txtWalletTotal);
            panel9.Location = new Point(17, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(518, 103);
            panel9.TabIndex = 23;
            panel9.Tag = "displayer";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 13);
            label12.Name = "label12";
            label12.Size = new Size(126, 28);
            label12.TabIndex = 23;
            label12.Text = "Actual Assets";
            // 
            // txtWalletTotal
            // 
            txtWalletTotal.AutoSize = true;
            txtWalletTotal.Font = new Font("Segoe UI", 15.7310925F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWalletTotal.Location = new Point(16, 41);
            txtWalletTotal.Name = "txtWalletTotal";
            txtWalletTotal.Size = new Size(75, 36);
            txtWalletTotal.TabIndex = 22;
            txtWalletTotal.Text = "$123";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(244, 214, 214);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cboModeSelectorBank);
            panel7.Controls.Add(flowLayoutPanel3);
            panel7.Location = new Point(17, 136);
            panel7.Name = "panel7";
            panel7.Size = new Size(518, 71);
            panel7.TabIndex = 15;
            panel7.Tag = "selector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 25;
            label2.Text = "Mode :";
            // 
            // cboModeSelectorBank
            // 
            cboModeSelectorBank.FormattingEnabled = true;
            cboModeSelectorBank.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelectorBank.Location = new Point(6, 32);
            cboModeSelectorBank.Name = "cboModeSelectorBank";
            cboModeSelectorBank.Size = new Size(82, 28);
            cboModeSelectorBank.TabIndex = 24;
            cboModeSelectorBank.SelectedIndexChanged += cboModeSelectorBank_SelectedIndexChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panelAddBank);
            flowLayoutPanel3.Controls.Add(panelDeleteBank);
            flowLayoutPanel3.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel3.Location = new Point(118, -21);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(304, 90);
            flowLayoutPanel3.TabIndex = 23;
            // 
            // panelAddBank
            // 
            panelAddBank.Controls.Add(btnAddBank);
            panelAddBank.Controls.Add(bankMoneyInputBox);
            panelAddBank.Controls.Add(bankNameInputBox);
            panelAddBank.Location = new Point(3, 49);
            panelAddBank.Name = "panelAddBank";
            panelAddBank.Size = new Size(289, 38);
            panelAddBank.TabIndex = 12;
            // 
            // btnAddBank
            // 
            btnAddBank.BackgroundImage = (Image)resources.GetObject("btnAddBank.BackgroundImage");
            btnAddBank.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddBank.Location = new Point(245, 3);
            btnAddBank.Name = "btnAddBank";
            btnAddBank.Size = new Size(27, 30);
            btnAddBank.TabIndex = 10;
            btnAddBank.TabStop = false;
            btnAddBank.UseVisualStyleBackColor = true;
            btnAddBank.Click += btnAddBank_Click;
            // 
            // bankMoneyInputBox
            // 
            bankMoneyInputBox.Location = new Point(156, 3);
            bankMoneyInputBox.Name = "bankMoneyInputBox";
            bankMoneyInputBox.PlaceholderText = "($$$)";
            bankMoneyInputBox.Size = new Size(81, 27);
            bankMoneyInputBox.TabIndex = 11;
            bankMoneyInputBox.Enter += bankMoneyInputBox_Enter;
            bankMoneyInputBox.KeyDown += bankMoneyInputBox_KeyDown;
            // 
            // bankNameInputBox
            // 
            bankNameInputBox.Location = new Point(6, 3);
            bankNameInputBox.Name = "bankNameInputBox";
            bankNameInputBox.PlaceholderText = "(Bank Name)";
            bankNameInputBox.Size = new Size(139, 27);
            bankNameInputBox.TabIndex = 11;
            bankNameInputBox.Enter += bankNameInputBox_Enter;
            bankNameInputBox.KeyDown += bankMoneyInputBox_KeyDown;
            // 
            // panelDeleteBank
            // 
            panelDeleteBank.Controls.Add(cboDelBankList);
            panelDeleteBank.Controls.Add(btnDelBank);
            panelDeleteBank.Location = new Point(3, 5);
            panelDeleteBank.Name = "panelDeleteBank";
            panelDeleteBank.Size = new Size(289, 38);
            panelDeleteBank.TabIndex = 12;
            // 
            // cboDelBankList
            // 
            cboDelBankList.FormattingEnabled = true;
            cboDelBankList.Location = new Point(6, 3);
            cboDelBankList.Name = "cboDelBankList";
            cboDelBankList.Size = new Size(139, 28);
            cboDelBankList.TabIndex = 12;
            // 
            // btnDelBank
            // 
            btnDelBank.BackgroundImage = (Image)resources.GetObject("btnDelBank.BackgroundImage");
            btnDelBank.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelBank.Location = new Point(156, 3);
            btnDelBank.Name = "btnDelBank";
            btnDelBank.Size = new Size(27, 30);
            btnDelBank.TabIndex = 10;
            btnDelBank.UseVisualStyleBackColor = true;
            btnDelBank.Click += btnDelBank_Click;
            // 
            // panelWallet
            // 
            panelWallet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelWallet.AutoScroll = true;
            panelWallet.BackColor = Color.White;
            panelWallet.Controls.Add(txtWalletMoney);
            panelWallet.Controls.Add(txtWalletName);
            panelWallet.Location = new Point(17, 205);
            panelWallet.Name = "panelWallet";
            panelWallet.Size = new Size(518, 463);
            panelWallet.TabIndex = 18;
            // 
            // txtWalletMoney
            // 
            txtWalletMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtWalletMoney.Location = new Point(345, 21);
            txtWalletMoney.Name = "txtWalletMoney";
            txtWalletMoney.Size = new Size(135, 29);
            txtWalletMoney.TabIndex = 9;
            txtWalletMoney.Text = "Money(inactive)";
            txtWalletMoney.TextAlign = ContentAlignment.TopRight;
            // 
            // txtWalletName
            // 
            txtWalletName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtWalletName.Location = new Point(11, 21);
            txtWalletName.Name = "txtWalletName";
            txtWalletName.Size = new Size(162, 29);
            txtWalletName.TabIndex = 9;
            txtWalletName.Text = "Name";
            // 
            // ScreenshotPage
            // 
            ScreenshotPage.BackColor = Color.FromArgb(255, 245, 245);
            ScreenshotPage.BackgroundImage = (Image)resources.GetObject("ScreenshotPage.BackgroundImage");
            ScreenshotPage.Controls.Add(panel4);
            ScreenshotPage.Controls.Add(panel11);
            ScreenshotPage.Location = new Point(4, 30);
            ScreenshotPage.Name = "ScreenshotPage";
            ScreenshotPage.Size = new Size(553, 707);
            ScreenshotPage.TabIndex = 4;
            ScreenshotPage.Text = "Screenshot";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.AutoScroll = true;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(flowPanelScreenshot);
            panel4.Location = new Point(17, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(518, 605);
            panel4.TabIndex = 26;
            // 
            // flowPanelScreenshot
            // 
            flowPanelScreenshot.AutoScroll = true;
            flowPanelScreenshot.Location = new Point(11, 12);
            flowPanelScreenshot.Name = "flowPanelScreenshot";
            flowPanelScreenshot.Size = new Size(492, 590);
            flowPanelScreenshot.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(244, 214, 214);
            panel11.Controls.Add(panel3);
            panel11.Location = new Point(17, 17);
            panel11.Name = "panel11";
            panel11.Size = new Size(518, 54);
            panel11.TabIndex = 16;
            panel11.Tag = "selector";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnAddImage);
            panel3.Controls.Add(cboDelImageList);
            panel3.Controls.Add(btnDelImage);
            panel3.Location = new Point(11, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 38);
            panel3.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Location = new Point(194, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 30);
            panel5.TabIndex = 17;
            // 
            // btnAddImage
            // 
            btnAddImage.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddImage.Location = new Point(6, 6);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(162, 30);
            btnAddImage.TabIndex = 10;
            btnAddImage.TabStop = false;
            btnAddImage.Text = "Add A Screenshot";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // cboDelImageList
            // 
            cboDelImageList.FormattingEnabled = true;
            cboDelImageList.Location = new Point(228, 7);
            cboDelImageList.Name = "cboDelImageList";
            cboDelImageList.Size = new Size(139, 28);
            cboDelImageList.TabIndex = 12;
            // 
            // btnDelImage
            // 
            btnDelImage.BackgroundImage = (Image)resources.GetObject("btnDelImage.BackgroundImage");
            btnDelImage.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelImage.Location = new Point(375, 6);
            btnDelImage.Name = "btnDelImage";
            btnDelImage.Size = new Size(27, 30);
            btnDelImage.TabIndex = 10;
            btnDelImage.UseVisualStyleBackColor = true;
            btnDelImage.Click += btnDelImage_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Snow;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, cleanTheLogToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(571, 27);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createANewFileToolStripMenuItem, menuOpen, menuSave });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(47, 23);
            testToolStripMenuItem.Text = "File";
            // 
            // createANewFileToolStripMenuItem
            // 
            createANewFileToolStripMenuItem.Name = "createANewFileToolStripMenuItem";
            createANewFileToolStripMenuItem.Size = new Size(213, 26);
            createANewFileToolStripMenuItem.Text = "Create a New File";
            createANewFileToolStripMenuItem.Click += createANewFileToolStripMenuItem_Click;
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(213, 26);
            menuOpen.Text = "Open Files";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(213, 26);
            menuSave.Text = "Save Files";
            menuSave.Click += menuSave_Click;
            // 
            // cleanTheLogToolStripMenuItem
            // 
            cleanTheLogToolStripMenuItem.Name = "cleanTheLogToolStripMenuItem";
            cleanTheLogToolStripMenuItem.Size = new Size(119, 23);
            cleanTheLogToolStripMenuItem.Text = "Clean the Log";
            cleanTheLogToolStripMenuItem.ToolTipText = "1234";
            cleanTheLogToolStripMenuItem.Click += cleanTheLogToolStripMenuItem_Click;
            // 
            // _openFileDialog
            // 
            _openFileDialog.Filter = "Json file|*.json|Data File|*.dat";
            // 
            // timerCheckingMoney
            // 
            timerCheckingMoney.Enabled = true;
            timerCheckingMoney.Tick += timerCheckingMoney_Tick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 245);
            ClientSize = new Size(571, 774);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Font = new Font("Noto Sans HK", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainView";
            Text = "Money Tracer";
            Load += MainView_Load;
            tabControl1.ResumeLayout(false);
            homepagePage.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            PanelDetailTotalSaving.ResumeLayout(false);
            PanelDetailTotalSaving.PerformLayout();
            panelSaving.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panelAddSaving.ResumeLayout(false);
            panelAddSaving.PerformLayout();
            panelDeleteSaving.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            spendingPage.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panelSpending.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panelAddSpending.ResumeLayout(false);
            panelAddSpending.PerformLayout();
            panelDeleteSpending.ResumeLayout(false);
            bufferPage.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panelBuffer.ResumeLayout(false);
            walletPage.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panelAddBank.ResumeLayout(false);
            panelAddBank.PerformLayout();
            panelDeleteBank.ResumeLayout(false);
            panelWallet.ResumeLayout(false);
            ScreenshotPage.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTotalStaus;
        private TabControl tabControl1;
        private TabPage homepagePage;
        private TabPage spendingPage;
        private Label txtTotalSaving;
        private Label txtboxSavingMoney;
        private Label txtboxSavingName;
        private Panel panelSaving;
        private Label txtBufferHomePage;
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
        private ComboBox cboModeSelectorHomepage;
        private Label label1;
        private OpenFileDialog _openFileDialog;
        private Label label6;
        private ComboBox cboModeSelectorSpending;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelAddSpending;
        private Button btnAddSpending;
        private TextBox spendingMoneyInputBox;
        private TextBox spendingNameInputBox;
        private Panel panelDeleteSpending;
        private ComboBox cboDelSpendingList;
        private Button btnDelSpendingList;
        private Panel panelSpending;
        private Label txtBoxSpendingMoney;
        private Label txtBoxSpendingName;
        private Label txtSpendingTotal;
        private TabPage walletPage;
        private Label txtWalletTotal;
        private Panel panelWallet;
        private Label txtWalletMoney;
        private Label txtWalletName;
        private TabPage bufferPage;
        private Label txtBufferTotal;
        private Panel panelBuffer;
        private Label txtBufferMoney;
        private Label txtBufferName;
        private Label label2;
        private ComboBox cboModeSelectorBank;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panelAddBank;
        private Button btnAddBank;
        private TextBox bankMoneyInputBox;
        private TextBox bankNameInputBox;
        private Panel panelDeleteBank;
        private ComboBox cboDelBankList;
        private Button btnDelBank;
        private Label txtWalletHomePage;
        private System.Windows.Forms.Timer timerCheckingMoney;
        private TabPage ScreenshotPage;
        private Panel panel3;
        private ComboBox cboDelImageList;
        private Button btnDelImage;
        private Panel panel4;
        private FlowLayoutPanel flowPanelScreenshot;
        private ToolStripMenuItem cleanTheLogToolStripMenuItem;
        private Label txtCurrentBufferSaving;
        private Button btnAddImage;
        private ToolStripMenuItem createANewFileToolStripMenuItem;
        private Panel panel1;
        private Panel panel8;
        private Panel panel6;
        private Panel panel10;
        private Panel panel12;
        private Panel panel2;
        private Panel panel7;
        private Panel panel13;
        private Panel panel9;
        private FlowLayoutPanel PanelDetailTotalSaving;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label txtSavingDifferent;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel14;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel5;
        private Panel panel11;
    }
}
