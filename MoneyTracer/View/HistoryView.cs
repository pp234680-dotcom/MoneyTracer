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
        public class HistoryItem
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }

            public override string ToString()
            {
                return FileName;
            }
        }


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

            //folder
            List<string> folders = Directory.GetDirectories(@"Data").ToList();

            //get json file paths
            List<string> filePaths = new List<string>();
            foreach(string folder in folders)
            {
                filePaths.AddRange(Directory.GetFiles(folder).ToList());
            }
            filePaths.AddRange(Directory.GetFiles(@"Data").ToList());
            List<string> jsonFilePaths = filePaths.ToList().FindAll(p => Path.GetExtension(p) == ".json");

            //order the sequence
            jsonFilePaths = jsonFilePaths.OrderByDescending(p => p).ToList();
            for (int i = jsonFilePaths.Count - 1; i >= 0; i--)
            {
                //chekc if the first word is number
                string currentPath = Path.GetFileName(jsonFilePaths[i]);
                string firstWord = currentPath[0].ToString();
                if (int.TryParse(firstWord, out int noUseResult))
                {
                    //safe, first word is number, means filename probably start with year
                    continue;
                }
                else
                {
                    jsonFilePaths.Remove(jsonFilePaths[i]);
                }
            }

            //add path to listbox
            foreach (var theFilePath in jsonFilePaths)
            {
                HistoryItem historyPath = new HistoryItem();
                historyPath.FilePath = theFilePath;
                historyPath.FileName = Path.GetFileName(theFilePath);
                HistoryListBox.Items.Add(historyPath);
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
            HistoryItem historyPath = HistoryListBox.SelectedItem as HistoryItem;
            if(historyPath == null || string.IsNullOrEmpty(historyPath.FilePath) == true)
            {
                HistoryListBox.ClearSelected();
                return;
            }

            string path = historyPath.FilePath;

            //return path
            PathClick.Invoke(path);
        }


    }
}
