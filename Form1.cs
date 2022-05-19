using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticSaveBackup
{
    public partial class Form : System.Windows.Forms.Form
    {
        static int backupCounter = 1;
        static int backupAmount = 10;
        static bool copyToBackup = false;
        static string BackupPath = "";
        static string copyToBackupPath = "";
        static DateTime lastBackup = new DateTime();

        public Form()
        {
            InitializeComponent();
            timer.Interval = 1000;
            string tooltip = "Add an Text based filter foor the files to backup" + System.Environment.NewLine +
                            "Sepperate multiple options with an ;" + System.Environment.NewLine +
                            "* can be used as an wildcard for any amount of character" + System.Environment.NewLine +
                            "? can be used as an wildcard for a single character" + System.Environment.NewLine +
                            "Example: *.save;savefile.xlm";
            this.toolTip1.SetToolTip(textBox_filter, tooltip);
            this.toolTip1.SetToolTip(label2, tooltip);
            this.toolTip1.SetToolTip(button_rest, "Select a file to restore based on the selected file in the backup list");
            this.toolTip1.SetToolTip(buttonBrowseBackupCopy, "Select a folder to save the files. Default is a subfolder called 'Backup' in the file location");

            numUpDown_amountBackup.Value = Properties.Settings.Default.backupAmount;
            checkBoxCopyBack.Checked = Properties.Settings.Default.copyToFolder;
            copyToBackupPath = Properties.Settings.Default.copyToFolderPath;
            BackupPath = Properties.Settings.Default.lastPath;
            textBox_filter.Text = Properties.Settings.Default.filter;
            if (!String.IsNullOrWhiteSpace(BackupPath))
                fillList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            BackupPath = folderBrowserDialog2.SelectedPath;

            fillList();
        }

        private void fillList()
        {
            List<String> searchPattern = new List<string>();

            if (!String.IsNullOrWhiteSpace(textBox_filter.Text))
            {
                searchPattern = textBox_filter.Text.Split(";").ToList();
            }

            if (!String.IsNullOrWhiteSpace(BackupPath))
            {
                this.toolTip1.SetToolTip(button_add, BackupPath);
                listView.Items.Clear();
                if (searchPattern.Count == 0)
                    searchPattern.Add("*");

                foreach (string pattern in searchPattern)
                {
                    var files = Directory.GetFiles(BackupPath, pattern).ToList();

                    foreach (string fileString in files)
                    {
                        ListViewItem newItem = new ListViewItem(Path.GetFileName(fileString));
                        newItem.SubItems.Add(new DateTime().ToString());
                        newItem.SubItems.Add(Path.GetDirectoryName(fileString));
                        listView.Items.Add(newItem);
                    }
                }

            }
        }

        private void numUpDown_amountBackup_ValueChanged(object sender, EventArgs e)
        {
            backupAmount = (int)numUpDown_amountBackup.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                bool doBackup = false;
                foreach (ListViewItem item in listView.Items)
                {
                    string filename = item.SubItems[2].Text + @"/" + item.Text;
                    DateTime fileDate = File.GetLastWriteTime(filename);
                    DateTime fileDate2 = DateTime.Parse(item.SubItems[1].Text);
                    if (fileDate > fileDate2.AddSeconds(1))
                    {
                        doBackup = true;
                    }
                }
                if (doBackup)
                {
                    foreach (ListViewItem item in listView.Items)
                    {
                        string folderName = item.SubItems[2].Text;
                        string filename = folderName + @"/" + item.Text;
                        DateTime fileDate = File.GetLastWriteTime(filename);
                        DateTime fileDate2 = DateTime.Parse(item.SubItems[1].Text);

                        if (copyToBackup && !String.IsNullOrWhiteSpace(copyToBackupPath))
                            folderName = copyToBackupPath;
                        folderName += @"\Backup\" + Path.GetFileNameWithoutExtension(filename);
                        Directory.CreateDirectory(folderName);

                        string filenameTarget = folderName + @"/" + backupCounter + "_" + item.Text;
                        lastBackup = fileDate;
                        item.SubItems[1].Text = fileDate.ToString();
                        File.Copy(filename, filenameTarget, true);
                    }
                    backupCounter++;
                    if (backupCounter > backupAmount)
                        backupCounter = 1;
                }
            }
        }

        private void checkBoxCopyBack_CheckedChanged(object sender, EventArgs e)
        {
            copyToBackup = checkBoxCopyBack.Checked;
        }

        private void buttonBrowseBackupCopy_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            copyToBackupPath = folderBrowserDialog1.SelectedPath;
            label_selectedBackupFolder.Text = copyToBackupPath;
        }

        private void checkBox_timer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_timer.Checked && !timer.Enabled)
            {
                timer.Start();
            }
            else if (!checkBox_timer.Checked && timer.Enabled)
            {
                timer.Stop();
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.backupAmount = (int)numUpDown_amountBackup.Value;
            Properties.Settings.Default.copyToFolder = checkBoxCopyBack.Checked;
            Properties.Settings.Default.copyToFolderPath = copyToBackupPath;
            Properties.Settings.Default.lastPath = BackupPath;
            Properties.Settings.Default.filter = textBox_filter.Text;
            Properties.Settings.Default.Save();
        }

        private void button_rest_Click(object sender, EventArgs e)
        {
            string folderName = "";
            string filename = "";
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            if (items.Count > 0)
            {
                foreach (ListViewItem item in items)
                {
                    folderName = item.SubItems[2].Text;
                    filename = folderName + @"/" + item.Text;
                }
                if (copyToBackup && !String.IsNullOrWhiteSpace(copyToBackupPath))
                    folderName = copyToBackupPath;
                folderName += @"\Backup\" + Path.GetFileNameWithoutExtension(filename);
                Directory.CreateDirectory(folderName);
                openFileDialog1.InitialDirectory = folderName;
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
            }
            else
                MessageBox.Show("Please select a file in the List to restore");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = openFileDialog1.FileNames;
            string folderName = "";
            string filename = "";
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            if (items.Count > 0)
            {
                foreach (ListViewItem item in items)
                {
                    folderName = item.SubItems[2].Text;
                    filename = folderName + @"/" + item.Text;
                }
            }
            foreach (string file in files)
            {
                File.Copy(file, filename, true);
            }
        }
    }
}
