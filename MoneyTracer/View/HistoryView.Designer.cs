namespace MoneyTracer.View
{
    partial class HistoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryView));
            HistoryListBox = new ListBox();
            SuspendLayout();
            // 
            // HistoryListBox
            // 
            HistoryListBox.FormattingEnabled = true;
            HistoryListBox.ItemHeight = 19;
            HistoryListBox.Items.AddRange(new object[] { "1", "23", "45345" });
            HistoryListBox.Location = new Point(22, 24);
            HistoryListBox.Name = "HistoryListBox";
            HistoryListBox.Size = new Size(337, 346);
            HistoryListBox.TabIndex = 0;
            HistoryListBox.SelectedIndexChanged += HistoryListBox_SelectedIndexChanged;
            // 
            // HistoryView
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 400);
            Controls.Add(HistoryListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HistoryView";
            Text = "History";
            TopMost = true;
            Load += HistoryView_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox HistoryListBox;
    }
}