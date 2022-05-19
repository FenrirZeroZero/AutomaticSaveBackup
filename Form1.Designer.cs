
namespace AutomaticSaveBackup
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.ch_Name = new System.Windows.Forms.ColumnHeader();
            this.ch_lastBackup = new System.Windows.Forms.ColumnHeader();
            this.ch_path = new System.Windows.Forms.ColumnHeader();
            this.button_add = new System.Windows.Forms.Button();
            this.button_rest = new System.Windows.Forms.Button();
            this.numUpDown_amountBackup = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxCopyBack = new System.Windows.Forms.CheckBox();
            this.buttonBrowseBackupCopy = new System.Windows.Forms.Button();
            this.label_selectedBackupFolder = new System.Windows.Forms.Label();
            this.checkBox_timer = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amountBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Name,
            this.ch_lastBackup,
            this.ch_path});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(610, 150);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 200;
            // 
            // ch_lastBackup
            // 
            this.ch_lastBackup.Text = "Backup";
            this.ch_lastBackup.Width = 120;
            // 
            // ch_path
            // 
            this.ch_path.Text = "Path";
            this.ch_path.Width = 285;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.Location = new System.Drawing.Point(12, 168);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(147, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_rest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rest.Location = new System.Drawing.Point(547, 168);
            this.button_rest.Name = "button_del";
            this.button_rest.Size = new System.Drawing.Size(75, 23);
            this.button_rest.TabIndex = 2;
            this.button_rest.Text = "Restore";
            this.button_rest.UseVisualStyleBackColor = true;
            this.button_rest.Click += new System.EventHandler(this.button_rest_Click);
            // 
            // numUpDown_amountBackup
            // 
            this.numUpDown_amountBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numUpDown_amountBackup.Location = new System.Drawing.Point(114, 198);
            this.numUpDown_amountBackup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_amountBackup.Name = "numUpDown_amountBackup";
            this.numUpDown_amountBackup.Size = new System.Drawing.Size(43, 23);
            this.numUpDown_amountBackup.TabIndex = 5;
            this.numUpDown_amountBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_amountBackup.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_amountBackup.ValueChanged += new System.EventHandler(this.numUpDown_amountBackup_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Backup Amount:";
            // 
            // checkBoxCopyBack
            // 
            this.checkBoxCopyBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCopyBack.AutoSize = true;
            this.checkBoxCopyBack.Location = new System.Drawing.Point(12, 280);
            this.checkBoxCopyBack.Name = "checkBoxCopyBack";
            this.checkBoxCopyBack.Size = new System.Drawing.Size(113, 19);
            this.checkBoxCopyBack.TabIndex = 7;
            this.checkBoxCopyBack.Text = "Copy Backup to:";
            this.checkBoxCopyBack.UseVisualStyleBackColor = true;
            this.checkBoxCopyBack.CheckedChanged += new System.EventHandler(this.checkBoxCopyBack_CheckedChanged);
            // 
            // buttonBrowseBackupCopy
            // 
            this.buttonBrowseBackupCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrowseBackupCopy.Location = new System.Drawing.Point(131, 277);
            this.buttonBrowseBackupCopy.Name = "buttonBrowseBackupCopy";
            this.buttonBrowseBackupCopy.Size = new System.Drawing.Size(58, 23);
            this.buttonBrowseBackupCopy.TabIndex = 8;
            this.buttonBrowseBackupCopy.Text = "Browse";
            this.buttonBrowseBackupCopy.UseVisualStyleBackColor = true;
            this.buttonBrowseBackupCopy.Click += new System.EventHandler(this.buttonBrowseBackupCopy_Click);
            // 
            // label_selectedBackupFolder
            // 
            this.label_selectedBackupFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_selectedBackupFolder.AutoSize = true;
            this.label_selectedBackupFolder.Location = new System.Drawing.Point(12, 302);
            this.label_selectedBackupFolder.Name = "label_selectedBackupFolder";
            this.label_selectedBackupFolder.Size = new System.Drawing.Size(106, 15);
            this.label_selectedBackupFolder.TabIndex = 9;
            this.label_selectedBackupFolder.Text = "No Folder Selected";
            // 
            // checkBox_timer
            // 
            this.checkBox_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_timer.AutoSize = true;
            this.checkBox_timer.Location = new System.Drawing.Point(553, 295);
            this.checkBox_timer.Name = "checkBox_timer";
            this.checkBox_timer.Size = new System.Drawing.Size(69, 19);
            this.checkBox_timer.TabIndex = 12;
            this.checkBox_timer.Text = "Activate";
            this.checkBox_timer.UseVisualStyleBackColor = true;
            this.checkBox_timer.CheckedChanged += new System.EventHandler(this.checkBox_timer_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 2;
            this.toolTip1.ShowAlways = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Filter:";
            // 
            // textBox_filter
            // 
            this.textBox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_filter.Location = new System.Drawing.Point(232, 169);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(135, 23);
            this.textBox_filter.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 326);
            this.Controls.Add(this.textBox_filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_timer);
            this.Controls.Add(this.label_selectedBackupFolder);
            this.Controls.Add(this.buttonBrowseBackupCopy);
            this.Controls.Add(this.checkBoxCopyBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDown_amountBackup);
            this.Controls.Add(this.button_rest);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listView);
            this.Name = "Form";
            this.Text = "AutomaticSaveBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amountBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_rest;
        private System.Windows.Forms.NumericUpDown numUpDown_amountBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBoxCopyBack;
        private System.Windows.Forms.Button buttonBrowseBackupCopy;
        private System.Windows.Forms.Label label_selectedBackupFolder;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_lastBackup;
        private System.Windows.Forms.ColumnHeader ch_path;
        private System.Windows.Forms.CheckBox checkBox_timer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_filter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

