using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracer.View
{
    public partial class HistoryView : Form
    {
        //event for invoking
        public event Action<string> PathClick;


        public HistoryView()
        {
            InitializeComponent();
        }


        //Current index
        private int _selectedIndex { get; set; } = -1;


        private void HistoryView_Load(object sender, EventArgs e)
        {
            //clear existed paths
            HistoryListBox.Items.Clear();

            //folder, currently not using
            string[] HaveNotUse_Folders = Directory.GetDirectories(@"Data");

            //get json file paths
            string[] filePaths = Directory.GetFiles(@"Data");
            List<string> jsonFilePaths = filePaths.ToList().FindAll(p => Path.GetExtension(p) == ".json");

            //add path to listbox
            foreach (var theFilePath in jsonFilePaths)
            {
                HistoryListBox.Items.Add(theFilePath);
            }
        }

        public void HistoryListBox_ClearSelected()
        {
            HistoryListBox.ClearSelected();
        }

        private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if previous index is same as currently don't update
            if (_selectedIndex == HistoryListBox.SelectedIndex)
            {
                HistoryListBox.ClearSelected();
                return;
            }
            
            //update current index
            _selectedIndex = HistoryListBox.SelectedIndex;

            //get path
            string path = HistoryListBox.SelectedItem as string;
            if (string.IsNullOrEmpty(path) == true)
            {
                HistoryListBox.ClearSelected();
                return;
            }

            //return path
            PathClick.Invoke(path);
        }


    }
}
