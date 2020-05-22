namespace Kvn.HabrQnaNetSamples.Controls
{
    partial class StarterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCompliteTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlDataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlsToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxMenuItem,
            this.treeViewToolStripMenuItem,
            this.bindingFormToolStripMenuItem,
            this.autoCompliteTextBoxToolStripMenuItem,
            this.pictureBoxCtrlToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // comboBoxMenuItem
            // 
            this.comboBoxMenuItem.Name = "comboBoxMenuItem";
            this.comboBoxMenuItem.Size = new System.Drawing.Size(299, 34);
            this.comboBoxMenuItem.Text = "ComboBox";
            this.comboBoxMenuItem.Click += new System.EventHandler(this.comboBoxMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.treeViewToolStripMenuItem.Text = "TreeView";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.TreeViewSampleClick);
            // 
            // bindingFormToolStripMenuItem
            // 
            this.bindingFormToolStripMenuItem.Name = "bindingFormToolStripMenuItem";
            this.bindingFormToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.bindingFormToolStripMenuItem.Text = "BindingForm";
            this.bindingFormToolStripMenuItem.Click += new System.EventHandler(this.bindingFormToolStripMenuItem_Click);
            // 
            // autoCompliteTextBoxToolStripMenuItem
            // 
            this.autoCompliteTextBoxToolStripMenuItem.Name = "autoCompliteTextBoxToolStripMenuItem";
            this.autoCompliteTextBoxToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.autoCompliteTextBoxToolStripMenuItem.Text = "AutoComplete text box";
            this.autoCompliteTextBoxToolStripMenuItem.Click += new System.EventHandler(this.autoCompliteTextBoxToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem,
            this.mySqlDataGridToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.layoutToolStripMenuItem.Text = "Layout";
            this.layoutToolStripMenuItem.Click += new System.EventHandler(this.layoutToolStripMenuItem_Click);
            // 
            // mySqlDataGridToolStripMenuItem
            // 
            this.mySqlDataGridToolStripMenuItem.Name = "mySqlDataGridToolStripMenuItem";
            this.mySqlDataGridToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.mySqlDataGridToolStripMenuItem.Text = "MySqlDataGrid";
            this.mySqlDataGridToolStripMenuItem.Click += new System.EventHandler(this.mySqlDataGridToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBoxCtrlToolStripMenuItem
            // 
            this.pictureBoxCtrlToolStripMenuItem.Name = "pictureBoxCtrlToolStripMenuItem";
            this.pictureBoxCtrlToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.pictureBoxCtrlToolStripMenuItem.Text = "PictureBoxCtrl";
            this.pictureBoxCtrlToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxCtrlToolStripMenuItem_Click);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StarterForm";
            this.Text = "Habr Qna .Net samples";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySqlDataGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCompliteTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxCtrlToolStripMenuItem;
    }
}