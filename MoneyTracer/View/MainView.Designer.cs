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
            txtSpendingHomepage = new Label();
            tabControl1 = new TabControl();
            homepagePage = new TabPage();
            panel10 = new Panel();
            txtTotalSaving = new Label();
            txtWalletHomePage = new Label();
            panel11 = new Panel();
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
            panel5 = new Panel();
            panel6 = new Panel();
            currentBufferSaving = new Label();
            txtBufferHomePage = new Label();
            panel1 = new Panel();
            spendingPage = new TabPage();
            panel12 = new Panel();
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
            txtBufferTotal = new Label();
            panelBuffer = new Panel();
            txtBufferMoney = new Label();
            txtBufferName = new Label();
            walletPage = new TabPage();
            panel9 = new Panel();
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
            flowLayoutPanel4 = new FlowLayoutPanel();
            panel3 = new Panel();
            btnAddImage = new Button();
            cboDelImageList = new ComboBox();
            btnDelImage = new Button();
            panel4 = new Panel();
            flowPanelScreenshot = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            createANewFileToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            cleanTheLogToolStripMenuItem = new ToolStripMenuItem();
            _openFileDialog = new OpenFileDialog();
            timerCheckingMoney = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            homepagePage.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panelSaving.SuspendLayout();
            panel8.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelAddSaving.SuspendLayout();
            panelDeleteSaving.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
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
            flowLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTotalStaus
            // 
            txtTotalStaus.AutoSize = true;
            txtTotalStaus.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            txtTotalStaus.ForeColor = Color.Black;
            txtTotalStaus.Location = new Point(3, 3);
            txtTotalStaus.Name = "txtTotalStaus";
            txtTotalStaus.Size = new Size(156, 21);
            txtTotalStaus.TabIndex = 7;
            txtTotalStaus.Text = "Total Status : Correct";
            // 
            // txtBalance
            // 
            txtBalance.AutoSize = true;
            txtBalance.Font = new Font("Noto Sans TC", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtBalance.ForeColor = Color.Black;
            txtBalance.Location = new Point(0, 11);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(162, 29);
            txtBalance.TabIndex = 2;
            txtBalance.Text = "Balance : $1,234";
            // 
            // txtSpendingHomepage
            // 
            txtSpendingHomepage.AutoSize = true;
            txtSpendingHomepage.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            txtSpendingHomepage.ForeColor = Color.Black;
            txtSpendingHomepage.Location = new Point(3, 8);
            txtSpendingHomepage.Name = "txtSpendingHomepage";
            txtSpendingHomepage.Size = new Size(101, 21);
            txtSpendingHomepage.TabIndex = 1;
            txtSpendingHomepage.Text = "Spending : $0";
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
            tabControl1.Size = new Size(473, 741);
            tabControl1.TabIndex = 8;
            tabControl1.TabStop = false;
            // 
            // homepagePage
            // 
            homepagePage.BackColor = Color.FromArgb(255, 245, 245);
            homepagePage.BackgroundImage = (Image)resources.GetObject("homepagePage.BackgroundImage");
            homepagePage.Controls.Add(panel10);
            homepagePage.Controls.Add(panel11);
            homepagePage.Controls.Add(panelSaving);
            homepagePage.Controls.Add(panel8);
            homepagePage.Controls.Add(panel5);
            homepagePage.Controls.Add(panel6);
            homepagePage.Controls.Add(panel1);
            homepagePage.Location = new Point(4, 30);
            homepagePage.Name = "homepagePage";
            homepagePage.Padding = new Padding(3);
            homepagePage.Size = new Size(465, 707);
            homepagePage.TabIndex = 1;
            homepagePage.Text = "Homepage";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(txtTotalSaving);
            panel10.Controls.Add(txtWalletHomePage);
            panel10.Location = new Point(253, 55);
            panel10.Name = "panel10";
            panel10.Size = new Size(190, 107);
            panel10.TabIndex = 14;
            // 
            // txtTotalSaving
            // 
            txtTotalSaving.AutoSize = true;
            txtTotalSaving.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            txtTotalSaving.ForeColor = Color.Black;
            txtTotalSaving.Location = new Point(4, 19);
            txtTotalSaving.Name = "txtTotalSaving";
            txtTotalSaving.Size = new Size(136, 21);
            txtTotalSaving.TabIndex = 2;
            txtTotalSaving.Text = "Total Saving : $300";
            // 
            // txtWalletHomePage
            // 
            txtWalletHomePage.AutoSize = true;
            txtWalletHomePage.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            txtWalletHomePage.ForeColor = Color.Black;
            txtWalletHomePage.Location = new Point(4, 69);
            txtWalletHomePage.Name = "txtWalletHomePage";
            txtWalletHomePage.Size = new Size(95, 21);
            txtWalletHomePage.TabIndex = 2;
            txtWalletHomePage.Text = "Wallet : $123";
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(txtSpendingHomepage);
            panel11.Location = new Point(15, 124);
            panel11.Name = "panel11";
            panel11.Size = new Size(220, 39);
            panel11.TabIndex = 14;
            // 
            // panelSaving
            // 
            panelSaving.AutoScroll = true;
            panelSaving.BackColor = Color.White;
            panelSaving.Controls.Add(txtboxSavingMoney);
            panelSaving.Controls.Add(txtboxSavingName);
            panelSaving.Location = new Point(15, 336);
            panelSaving.Name = "panelSaving";
            panelSaving.Size = new Size(431, 351);
            panelSaving.TabIndex = 9;
            // 
            // txtboxSavingMoney
            // 
            txtboxSavingMoney.Font = new Font("Noto Sans TC DemiLight", 10.2857141F);
            txtboxSavingMoney.ForeColor = Color.Black;
            txtboxSavingMoney.Location = new Point(252, 10);
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
            panel8.BackColor = Color.FromArgb(244, 234, 234);
            panel8.Controls.Add(flowLayoutPanel1);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(cboModeSelectorHomepage);
            panel8.Location = new Point(15, 267);
            panel8.Name = "panel8";
            panel8.Size = new Size(431, 71);
            panel8.TabIndex = 14;
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
            label1.Font = new Font("Noto Sans TC", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 4);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
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
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txtTotalStaus);
            panel5.Location = new Point(15, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 29);
            panel5.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(currentBufferSaving);
            panel6.Controls.Add(txtBufferHomePage);
            panel6.Location = new Point(15, 179);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 72);
            panel6.TabIndex = 14;
            // 
            // currentBufferSaving
            // 
            currentBufferSaving.AutoSize = true;
            currentBufferSaving.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            currentBufferSaving.ForeColor = Color.Black;
            currentBufferSaving.Location = new Point(5, 40);
            currentBufferSaving.Name = "currentBufferSaving";
            currentBufferSaving.Size = new Size(184, 21);
            currentBufferSaving.TabIndex = 10;
            currentBufferSaving.Text = "Current Saving Buffer : $0";
            // 
            // txtBufferHomePage
            // 
            txtBufferHomePage.AutoSize = true;
            txtBufferHomePage.Font = new Font("Noto Sans TC DemiLight", 9.07563F);
            txtBufferHomePage.ForeColor = Color.Black;
            txtBufferHomePage.Location = new Point(5, 9);
            txtBufferHomePage.Name = "txtBufferHomePage";
            txtBufferHomePage.Size = new Size(176, 21);
            txtBufferHomePage.TabIndex = 10;
            txtBufferHomePage.Text = "Buffer Cash Usage : $123";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtBalance);
            panel1.Location = new Point(15, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 52);
            panel1.TabIndex = 14;
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
            spendingPage.Size = new Size(465, 707);
            spendingPage.TabIndex = 0;
            spendingPage.Text = "Spending";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(txtSpendingTotal);
            panel12.Location = new Point(17, 15);
            panel12.Name = "panel12";
            panel12.Size = new Size(416, 29);
            panel12.TabIndex = 16;
            // 
            // txtSpendingTotal
            // 
            txtSpendingTotal.AutoSize = true;
            txtSpendingTotal.Location = new Point(4, 3);
            txtSpendingTotal.Name = "txtSpendingTotal";
            txtSpendingTotal.Size = new Size(152, 20);
            txtSpendingTotal.TabIndex = 17;
            txtSpendingTotal.Text = "Total Spending : $123";
            // 
            // panelSpending
            // 
            panelSpending.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelSpending.AutoScroll = true;
            panelSpending.BackColor = Color.White;
            panelSpending.Controls.Add(txtBoxSpendingMoney);
            panelSpending.Controls.Add(txtBoxSpendingName);
            panelSpending.Location = new Point(17, 132);
            panelSpending.Name = "panelSpending";
            panelSpending.Size = new Size(419, 536);
            panelSpending.TabIndex = 10;
            // 
            // txtBoxSpendingMoney
            // 
            txtBoxSpendingMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBoxSpendingMoney.Location = new Point(248, 12);
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
            panel2.BackColor = Color.FromArgb(244, 234, 234);
            panel2.Controls.Add(cboModeSelectorSpending);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Location = new Point(17, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 71);
            panel2.TabIndex = 15;
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
            bufferPage.BackgroundImage = (Image)resources.GetObject("bufferPage.BackgroundImage");
            bufferPage.Controls.Add(panel13);
            bufferPage.Controls.Add(panelBuffer);
            bufferPage.Location = new Point(4, 30);
            bufferPage.Name = "bufferPage";
            bufferPage.Size = new Size(465, 707);
            bufferPage.TabIndex = 3;
            bufferPage.Text = "Buffer Cash";
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Controls.Add(txtBufferTotal);
            panel13.Location = new Point(17, 18);
            panel13.Name = "panel13";
            panel13.Size = new Size(416, 29);
            panel13.TabIndex = 17;
            // 
            // txtBufferTotal
            // 
            txtBufferTotal.AutoSize = true;
            txtBufferTotal.Location = new Point(3, 4);
            txtBufferTotal.Name = "txtBufferTotal";
            txtBufferTotal.Size = new Size(129, 20);
            txtBufferTotal.TabIndex = 24;
            txtBufferTotal.Text = "Total Buffer : $123";
            // 
            // panelBuffer
            // 
            panelBuffer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelBuffer.AutoScroll = true;
            panelBuffer.BackColor = Color.White;
            panelBuffer.Controls.Add(txtBufferMoney);
            panelBuffer.Controls.Add(txtBufferName);
            panelBuffer.Location = new Point(17, 66);
            panelBuffer.Name = "panelBuffer";
            panelBuffer.Size = new Size(419, 590);
            panelBuffer.TabIndex = 23;
            // 
            // txtBufferMoney
            // 
            txtBufferMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBufferMoney.Location = new Point(248, 21);
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
            walletPage.Size = new Size(465, 707);
            walletPage.TabIndex = 2;
            walletPage.Text = "Wallet";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(txtWalletTotal);
            panel9.Location = new Point(17, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(416, 29);
            panel9.TabIndex = 23;
            // 
            // txtWalletTotal
            // 
            txtWalletTotal.AutoSize = true;
            txtWalletTotal.Location = new Point(4, 4);
            txtWalletTotal.Name = "txtWalletTotal";
            txtWalletTotal.Size = new Size(94, 20);
            txtWalletTotal.TabIndex = 22;
            txtWalletTotal.Text = "Wallet : $123";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(244, 234, 234);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cboModeSelectorBank);
            panel7.Controls.Add(flowLayoutPanel3);
            panel7.Location = new Point(17, 66);
            panel7.Name = "panel7";
            panel7.Size = new Size(419, 71);
            panel7.TabIndex = 15;
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
            panelWallet.Location = new Point(17, 132);
            panelWallet.Name = "panelWallet";
            panelWallet.Size = new Size(419, 536);
            panelWallet.TabIndex = 18;
            // 
            // txtWalletMoney
            // 
            txtWalletMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtWalletMoney.Location = new Point(248, 21);
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
            ScreenshotPage.Controls.Add(flowLayoutPanel4);
            ScreenshotPage.Controls.Add(panel4);
            ScreenshotPage.Location = new Point(4, 30);
            ScreenshotPage.Name = "ScreenshotPage";
            ScreenshotPage.Size = new Size(465, 707);
            ScreenshotPage.TabIndex = 4;
            ScreenshotPage.Text = "Screenshot";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(244, 234, 234);
            flowLayoutPanel4.Controls.Add(panel3);
            flowLayoutPanel4.Location = new Point(23, 25);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(419, 46);
            flowLayoutPanel4.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(244, 234, 234);
            panel3.Controls.Add(btnAddImage);
            panel3.Controls.Add(cboDelImageList);
            panel3.Controls.Add(btnDelImage);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 38);
            panel3.TabIndex = 12;
            // 
            // btnAddImage
            // 
            btnAddImage.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddImage.Location = new Point(240, 4);
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
            cboDelImageList.Location = new Point(6, 5);
            cboDelImageList.Name = "cboDelImageList";
            cboDelImageList.Size = new Size(139, 28);
            cboDelImageList.TabIndex = 12;
            // 
            // btnDelImage
            // 
            btnDelImage.BackgroundImage = (Image)resources.GetObject("btnDelImage.BackgroundImage");
            btnDelImage.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelImage.Location = new Point(156, 4);
            btnDelImage.Name = "btnDelImage";
            btnDelImage.Size = new Size(27, 30);
            btnDelImage.TabIndex = 10;
            btnDelImage.UseVisualStyleBackColor = true;
            btnDelImage.Click += btnDelImage_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.AutoScroll = true;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(flowPanelScreenshot);
            panel4.Location = new Point(23, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(419, 605);
            panel4.TabIndex = 26;
            // 
            // flowPanelScreenshot
            // 
            flowPanelScreenshot.AutoScroll = true;
            flowPanelScreenshot.Location = new Point(11, 12);
            flowPanelScreenshot.Name = "flowPanelScreenshot";
            flowPanelScreenshot.Size = new Size(397, 506);
            flowPanelScreenshot.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Snow;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, cleanTheLogToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(487, 27);
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
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 245);
            ClientSize = new Size(487, 774);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Font = new Font("Noto Sans HK", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainView";
            Text = "Money Tracer beta";
            Load += MainView_Load;
            tabControl1.ResumeLayout(false);
            homepagePage.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panelSaving.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panelAddSaving.ResumeLayout(false);
            panelAddSaving.PerformLayout();
            panelDeleteSaving.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
            flowLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTotalStaus;
        private Label txtSpendingHomepage;
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
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel3;
        private ComboBox cboDelImageList;
        private Button btnDelImage;
        private Panel panel4;
        private FlowLayoutPanel flowPanelScreenshot;
        private ToolStripMenuItem cleanTheLogToolStripMenuItem;
        private Label currentBufferSaving;
        private Button btnAddImage;
        private ToolStripMenuItem createANewFileToolStripMenuItem;
        private Panel panel1;
        private Panel panel8;
        private Panel panel5;
        private Panel panel11;
        private Panel panel6;
        private Panel panel10;
        private Panel panel12;
        private Panel panel2;
        private Panel panel7;
        private Panel panel13;
        private Panel panel9;
    }
}
