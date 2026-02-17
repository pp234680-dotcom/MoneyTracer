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
            txtBalance = new Label();
            txtSpendingHomepage = new Label();
            tabControl1 = new TabControl();
            homepagePage = new TabPage();
            label1 = new Label();
            cboModeSelectorHomepage = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelAddSaving = new Panel();
            btnAddSaving = new Button();
            savingMoneyInputBox = new TextBox();
            savingNameInputBox = new TextBox();
            panelDeleteSaving = new Panel();
            cboDelSavingList = new ComboBox();
            btnDelSaving = new Button();
            panelSaving = new Panel();
            txtboxSavingMoney = new Label();
            txtboxSavingName = new Label();
            panel2 = new Panel();
            txtBufferHomePage = new Label();
            txtTotalSaving = new Label();
            spendingPage = new TabPage();
            txtSpendingTotal = new Label();
            label6 = new Label();
            cboModeSelectorSpending = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelAddSpending = new Panel();
            btnAddSpending = new Button();
            spendingMoneyInputBox = new TextBox();
            spendingNameInputBox = new TextBox();
            panelDeleteSpending = new Panel();
            cboDelSpendingList = new ComboBox();
            btnDelSpendingList = new Button();
            panelSpending = new Panel();
            txtBoxSpendingMoney = new Label();
            txtBoxSpendingName = new Label();
            bufferPage = new TabPage();
            txtBufferTotal = new Label();
            panelBuffer = new Panel();
            txtBufferMoney = new Label();
            txtBufferName = new Label();
            walletPage = new TabPage();
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
            txtWalletTotal = new Label();
            panelWallet = new Panel();
            txtWalletMoney = new Label();
            txtWalletName = new Label();
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            _openFileDialog = new OpenFileDialog();
            tabControl1.SuspendLayout();
            homepagePage.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelAddSaving.SuspendLayout();
            panelDeleteSaving.SuspendLayout();
            panelSaving.SuspendLayout();
            panel2.SuspendLayout();
            spendingPage.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelAddSpending.SuspendLayout();
            panelDeleteSpending.SuspendLayout();
            panelSpending.SuspendLayout();
            bufferPage.SuspendLayout();
            panelBuffer.SuspendLayout();
            walletPage.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panelAddBank.SuspendLayout();
            panelDeleteBank.SuspendLayout();
            panelWallet.SuspendLayout();
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
            // txtSpendingHomepage
            // 
            txtSpendingHomepage.AutoSize = true;
            txtSpendingHomepage.ForeColor = Color.White;
            txtSpendingHomepage.Location = new Point(16, 65);
            txtSpendingHomepage.Name = "txtSpendingHomepage";
            txtSpendingHomepage.Size = new Size(106, 19);
            txtSpendingHomepage.TabIndex = 1;
            txtSpendingHomepage.Text = "Spending : $0";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(homepagePage);
            tabControl1.Controls.Add(spendingPage);
            tabControl1.Controls.Add(bufferPage);
            tabControl1.Controls.Add(walletPage);
            tabControl1.Location = new Point(12, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 658);
            tabControl1.TabIndex = 8;
            tabControl1.TabStop = false;
            // 
            // homepagePage
            // 
            homepagePage.BackColor = Color.FloralWhite;
            homepagePage.Controls.Add(label1);
            homepagePage.Controls.Add(cboModeSelectorHomepage);
            homepagePage.Controls.Add(flowLayoutPanel1);
            homepagePage.Controls.Add(label5);
            homepagePage.Controls.Add(panelSaving);
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
            // cboModeSelectorHomepage
            // 
            cboModeSelectorHomepage.FormattingEnabled = true;
            cboModeSelectorHomepage.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelectorHomepage.Location = new Point(28, 260);
            cboModeSelectorHomepage.Name = "cboModeSelectorHomepage";
            cboModeSelectorHomepage.Size = new Size(82, 27);
            cboModeSelectorHomepage.TabIndex = 12;
            cboModeSelectorHomepage.SelectedIndexChanged += cboModeSelectorHomepage_SelectedIndexChanged;
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
            btnAddSaving.TabStop = false;
            btnAddSaving.UseVisualStyleBackColor = true;
            btnAddSaving.Click += btnAddSaving_Click;
            // 
            // savingMoneyInputBox
            // 
            savingMoneyInputBox.Location = new Point(156, 3);
            savingMoneyInputBox.Name = "savingMoneyInputBox";
            savingMoneyInputBox.PlaceholderText = "($$$)";
            savingMoneyInputBox.Size = new Size(81, 27);
            savingMoneyInputBox.TabIndex = 11;
            savingMoneyInputBox.Enter += savingMoneyInputBox_Enter;
            savingMoneyInputBox.KeyDown += savingMoneyInputBox_KeyDown;
            // 
            // savingNameInputBox
            // 
            savingNameInputBox.Location = new Point(6, 3);
            savingNameInputBox.Name = "savingNameInputBox";
            savingNameInputBox.PlaceholderText = "(Saving Name)";
            savingNameInputBox.Size = new Size(139, 27);
            savingNameInputBox.TabIndex = 11;
            savingNameInputBox.Enter += savingNameInputBox_Enter;
            savingNameInputBox.KeyDown += savingMoneyInputBox_KeyDown;
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
            // panelSaving
            // 
            panelSaving.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelSaving.AutoScroll = true;
            panelSaving.BackColor = Color.LightYellow;
            panelSaving.Controls.Add(txtboxSavingMoney);
            panelSaving.Controls.Add(txtboxSavingName);
            panelSaving.Location = new Point(15, 299);
            panelSaving.Name = "panelSaving";
            panelSaving.Size = new Size(431, 316);
            panelSaving.TabIndex = 9;
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
            panel2.Controls.Add(txtSpendingHomepage);
            panel2.Controls.Add(txtBufferHomePage);
            panel2.Controls.Add(txtBalance);
            panel2.Controls.Add(txtTotalSaving);
            panel2.Location = new Point(15, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 165);
            panel2.TabIndex = 8;
            // 
            // txtBufferHomePage
            // 
            txtBufferHomePage.AutoSize = true;
            txtBufferHomePage.ForeColor = Color.White;
            txtBufferHomePage.Location = new Point(16, 105);
            txtBufferHomePage.Name = "txtBufferHomePage";
            txtBufferHomePage.Size = new Size(184, 19);
            txtBufferHomePage.TabIndex = 10;
            txtBufferHomePage.Text = "Buffer Cash Usage : $123";
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
            spendingPage.Controls.Add(txtSpendingTotal);
            spendingPage.Controls.Add(label6);
            spendingPage.Controls.Add(cboModeSelectorSpending);
            spendingPage.Controls.Add(flowLayoutPanel2);
            spendingPage.Controls.Add(panelSpending);
            spendingPage.Location = new Point(4, 28);
            spendingPage.Name = "spendingPage";
            spendingPage.Padding = new Padding(3);
            spendingPage.Size = new Size(465, 626);
            spendingPage.TabIndex = 0;
            spendingPage.Text = "Spending";
            // 
            // txtSpendingTotal
            // 
            txtSpendingTotal.AutoSize = true;
            txtSpendingTotal.Location = new Point(17, 19);
            txtSpendingTotal.Name = "txtSpendingTotal";
            txtSpendingTotal.Size = new Size(162, 19);
            txtSpendingTotal.TabIndex = 17;
            txtSpendingTotal.Text = "Total Spending : $123";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 53);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 16;
            label6.Text = "Mode :";
            // 
            // cboModeSelectorSpending
            // 
            cboModeSelectorSpending.FormattingEnabled = true;
            cboModeSelectorSpending.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelectorSpending.Location = new Point(20, 75);
            cboModeSelectorSpending.Name = "cboModeSelectorSpending";
            cboModeSelectorSpending.Size = new Size(82, 27);
            cboModeSelectorSpending.TabIndex = 15;
            cboModeSelectorSpending.SelectedIndexChanged += cboModeSelectorSpending_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panelAddSpending);
            flowLayoutPanel2.Controls.Add(panelDeleteSpending);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(132, 27);
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
            spendingNameInputBox.PlaceholderText = "(Saving Name)";
            spendingNameInputBox.Size = new Size(139, 27);
            spendingNameInputBox.TabIndex = 11;
            spendingNameInputBox.Enter += spendingNameInputBox_Enter;
            spendingNameInputBox.KeyDown += spendingMoneyInputBox_KeyDown;
            // 
            // panelDeleteSpending
            // 
            panelDeleteSpending.Controls.Add(cboDelSpendingList);
            panelDeleteSpending.Controls.Add(btnDelSpendingList);
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
            // btnDelSpendingList
            // 
            btnDelSpendingList.BackgroundImage = (Image)resources.GetObject("btnDelSpendingList.BackgroundImage");
            btnDelSpendingList.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelSpendingList.Location = new Point(156, 3);
            btnDelSpendingList.Name = "btnDelSpendingList";
            btnDelSpendingList.Size = new Size(27, 27);
            btnDelSpendingList.TabIndex = 10;
            btnDelSpendingList.UseVisualStyleBackColor = true;
            btnDelSpendingList.Click += butDelSpendingList_Click;
            // 
            // panelSpending
            // 
            panelSpending.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelSpending.AutoScroll = true;
            panelSpending.BackColor = Color.LightYellow;
            panelSpending.Controls.Add(txtBoxSpendingMoney);
            panelSpending.Controls.Add(txtBoxSpendingName);
            panelSpending.Location = new Point(17, 119);
            panelSpending.Name = "panelSpending";
            panelSpending.Size = new Size(419, 485);
            panelSpending.TabIndex = 10;
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
            // bufferPage
            // 
            bufferPage.BackColor = Color.FloralWhite;
            bufferPage.Controls.Add(txtBufferTotal);
            bufferPage.Controls.Add(panelBuffer);
            bufferPage.Location = new Point(4, 28);
            bufferPage.Name = "bufferPage";
            bufferPage.Size = new Size(465, 626);
            bufferPage.TabIndex = 3;
            bufferPage.Text = "Buffer Cash";
            // 
            // txtBufferTotal
            // 
            txtBufferTotal.AutoSize = true;
            txtBufferTotal.Location = new Point(17, 19);
            txtBufferTotal.Name = "txtBufferTotal";
            txtBufferTotal.Size = new Size(136, 19);
            txtBufferTotal.TabIndex = 24;
            txtBufferTotal.Text = "Total Buffer : $123";
            // 
            // panelBuffer
            // 
            panelBuffer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelBuffer.AutoScroll = true;
            panelBuffer.BackColor = Color.LightYellow;
            panelBuffer.Controls.Add(txtBufferMoney);
            panelBuffer.Controls.Add(txtBufferName);
            panelBuffer.Location = new Point(17, 55);
            panelBuffer.Name = "panelBuffer";
            panelBuffer.Size = new Size(419, 549);
            panelBuffer.TabIndex = 23;
            // 
            // txtBufferMoney
            // 
            txtBufferMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBufferMoney.Location = new Point(248, 19);
            txtBufferMoney.Name = "txtBufferMoney";
            txtBufferMoney.Size = new Size(135, 26);
            txtBufferMoney.TabIndex = 9;
            txtBufferMoney.Text = "Money(inactive)";
            txtBufferMoney.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBufferName
            // 
            txtBufferName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtBufferName.Location = new Point(3, 19);
            txtBufferName.Name = "txtBufferName";
            txtBufferName.Size = new Size(162, 26);
            txtBufferName.TabIndex = 9;
            txtBufferName.Text = "Name";
            // 
            // walletPage
            // 
            walletPage.BackColor = Color.FloralWhite;
            walletPage.Controls.Add(label2);
            walletPage.Controls.Add(cboModeSelectorBank);
            walletPage.Controls.Add(flowLayoutPanel3);
            walletPage.Controls.Add(txtWalletTotal);
            walletPage.Controls.Add(panelWallet);
            walletPage.Location = new Point(4, 28);
            walletPage.Name = "walletPage";
            walletPage.Padding = new Padding(3);
            walletPage.Size = new Size(465, 626);
            walletPage.TabIndex = 2;
            walletPage.Text = "Wallet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 25;
            label2.Text = "Mode :";
            // 
            // cboModeSelectorBank
            // 
            cboModeSelectorBank.FormattingEnabled = true;
            cboModeSelectorBank.Items.AddRange(new object[] { "Add", "Delete" });
            cboModeSelectorBank.Location = new Point(20, 75);
            cboModeSelectorBank.Name = "cboModeSelectorBank";
            cboModeSelectorBank.Size = new Size(82, 27);
            cboModeSelectorBank.TabIndex = 24;
            cboModeSelectorBank.SelectedIndexChanged += cboModeSelectorBank_SelectedIndexChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panelAddBank);
            flowLayoutPanel3.Controls.Add(panelDeleteBank);
            flowLayoutPanel3.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel3.Location = new Point(132, 27);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(304, 81);
            flowLayoutPanel3.TabIndex = 23;
            // 
            // panelAddBank
            // 
            panelAddBank.Controls.Add(btnAddBank);
            panelAddBank.Controls.Add(bankMoneyInputBox);
            panelAddBank.Controls.Add(bankNameInputBox);
            panelAddBank.Location = new Point(3, 44);
            panelAddBank.Name = "panelAddBank";
            panelAddBank.Size = new Size(289, 34);
            panelAddBank.TabIndex = 12;
            // 
            // btnAddBank
            // 
            btnAddBank.BackgroundImage = (Image)resources.GetObject("btnAddBank.BackgroundImage");
            btnAddBank.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddBank.Location = new Point(245, 3);
            btnAddBank.Name = "btnAddBank";
            btnAddBank.Size = new Size(27, 27);
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
            bankNameInputBox.PlaceholderText = "(Saving Name)";
            bankNameInputBox.Size = new Size(139, 27);
            bankNameInputBox.TabIndex = 11;
            bankNameInputBox.Enter += bankNameInputBox_Enter;
            bankNameInputBox.KeyDown += bankMoneyInputBox_KeyDown;
            // 
            // panelDeleteBank
            // 
            panelDeleteBank.Controls.Add(cboDelBankList);
            panelDeleteBank.Controls.Add(btnDelBank);
            panelDeleteBank.Location = new Point(3, 4);
            panelDeleteBank.Name = "panelDeleteBank";
            panelDeleteBank.Size = new Size(289, 34);
            panelDeleteBank.TabIndex = 12;
            // 
            // cboDelBankList
            // 
            cboDelBankList.FormattingEnabled = true;
            cboDelBankList.Location = new Point(6, 3);
            cboDelBankList.Name = "cboDelBankList";
            cboDelBankList.Size = new Size(139, 27);
            cboDelBankList.TabIndex = 12;
            // 
            // btnDelBank
            // 
            btnDelBank.BackgroundImage = (Image)resources.GetObject("btnDelBank.BackgroundImage");
            btnDelBank.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelBank.Location = new Point(156, 3);
            btnDelBank.Name = "btnDelBank";
            btnDelBank.Size = new Size(27, 27);
            btnDelBank.TabIndex = 10;
            btnDelBank.UseVisualStyleBackColor = true;
            btnDelBank.Click += btnDelBank_Click;
            // 
            // txtWalletTotal
            // 
            txtWalletTotal.AutoSize = true;
            txtWalletTotal.Location = new Point(17, 19);
            txtWalletTotal.Name = "txtWalletTotal";
            txtWalletTotal.Size = new Size(100, 19);
            txtWalletTotal.TabIndex = 22;
            txtWalletTotal.Text = "Wallet : $123";
            // 
            // panelWallet
            // 
            panelWallet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelWallet.AutoScroll = true;
            panelWallet.BackColor = Color.LightYellow;
            panelWallet.Controls.Add(txtWalletMoney);
            panelWallet.Controls.Add(txtWalletName);
            panelWallet.Location = new Point(17, 119);
            panelWallet.Name = "panelWallet";
            panelWallet.Size = new Size(419, 485);
            panelWallet.TabIndex = 18;
            // 
            // txtWalletMoney
            // 
            txtWalletMoney.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtWalletMoney.Location = new Point(248, 19);
            txtWalletMoney.Name = "txtWalletMoney";
            txtWalletMoney.Size = new Size(135, 26);
            txtWalletMoney.TabIndex = 9;
            txtWalletMoney.Text = "Money(inactive)";
            txtWalletMoney.TextAlign = ContentAlignment.TopRight;
            // 
            // txtWalletName
            // 
            txtWalletName.Font = new Font("Microsoft JhengHei UI", 10.2857141F);
            txtWalletName.Location = new Point(3, 19);
            txtWalletName.Name = "txtWalletName";
            txtWalletName.Size = new Size(162, 26);
            txtWalletName.TabIndex = 9;
            txtWalletName.Text = "Name";
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
            tabControl1.ResumeLayout(false);
            homepagePage.ResumeLayout(false);
            homepagePage.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panelAddSaving.ResumeLayout(false);
            panelAddSaving.PerformLayout();
            panelDeleteSaving.ResumeLayout(false);
            panelSaving.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            spendingPage.ResumeLayout(false);
            spendingPage.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panelAddSpending.ResumeLayout(false);
            panelAddSpending.PerformLayout();
            panelDeleteSpending.ResumeLayout(false);
            panelSpending.ResumeLayout(false);
            bufferPage.ResumeLayout(false);
            bufferPage.PerformLayout();
            panelBuffer.ResumeLayout(false);
            walletPage.ResumeLayout(false);
            walletPage.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panelAddBank.ResumeLayout(false);
            panelAddBank.PerformLayout();
            panelDeleteBank.ResumeLayout(false);
            panelWallet.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label txtSpendingHomepage;
        private TabControl tabControl1;
        private TabPage homepagePage;
        private TabPage spendingPage;
        private Panel panel2;
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
    }
}
