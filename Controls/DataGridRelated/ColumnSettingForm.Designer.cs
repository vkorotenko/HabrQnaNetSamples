namespace Kvn.HabrQnaNetSamples.Controls.DataGridRelated
{
    partial class ColumnSettingForm
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
            this.habraLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstHelpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // habraLinkLabel
            // 
            this.habraLinkLabel.AutoSize = true;
            this.habraLinkLabel.Location = new System.Drawing.Point(12, 9);
            this.habraLinkLabel.Name = "habraLinkLabel";
            this.habraLinkLabel.Size = new System.Drawing.Size(225, 20);
            this.habraLinkLabel.TabIndex = 0;
            this.habraLinkLabel.TabStop = true;
            this.habraLinkLabel.Text = "https://qna.habr.com/q/777563";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ValuesColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(386, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Названия";
            this.NameColumn.MinimumWidth = 8;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // ValuesColumn
            // 
            this.ValuesColumn.HeaderText = "Значения";
            this.ValuesColumn.MinimumWidth = 8;
            this.ValuesColumn.Name = "ValuesColumn";
            this.ValuesColumn.ReadOnly = true;
            this.ValuesColumn.Width = 150;
            // 
            // firstHelpLabel
            // 
            this.firstHelpLabel.AutoSize = true;
            this.firstHelpLabel.Location = new System.Drawing.Point(16, 33);
            this.firstHelpLabel.Name = "firstHelpLabel";
            this.firstHelpLabel.Size = new System.Drawing.Size(196, 20);
            this.firstHelpLabel.TabIndex = 2;
            this.firstHelpLabel.Text = "Ручная привязка данных";
            // 
            // ColumnSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.firstHelpLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.habraLinkLabel);
            this.Name = "ColumnSettingForm";
            this.Text = "ColumnSettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel habraLinkLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValuesColumn;
        private System.Windows.Forms.Label firstHelpLabel;
    }
}