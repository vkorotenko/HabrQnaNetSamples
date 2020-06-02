namespace Kvn.HabrQnaNetSamples.Controls
{
    partial class BindingForm
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
            this.sourceGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabelResult = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SourceTwoComboBox = new System.Windows.Forms.ComboBox();
            this.FactorTwoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SourceOneComboBox = new System.Windows.Forms.ComboBox();
            this.FactorOneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FiledComboBox = new System.Windows.Forms.ComboBox();
            this.sourceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceGroupBox
            // 
            this.sourceGroupBox.Controls.Add(this.FiledComboBox);
            this.sourceGroupBox.Controls.Add(this.ResultLabelResult);
            this.sourceGroupBox.Controls.Add(this.ResultLabel);
            this.sourceGroupBox.Controls.Add(this.SourceTwoComboBox);
            this.sourceGroupBox.Controls.Add(this.FactorTwoTextBox);
            this.sourceGroupBox.Controls.Add(this.SourceOneComboBox);
            this.sourceGroupBox.Controls.Add(this.FactorOneTextBox);
            this.sourceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sourceGroupBox.Name = "sourceGroupBox";
            this.sourceGroupBox.Size = new System.Drawing.Size(363, 426);
            this.sourceGroupBox.TabIndex = 0;
            this.sourceGroupBox.TabStop = false;
            this.sourceGroupBox.Text = "Исходные данные";
            // 
            // ResultLabelResult
            // 
            this.ResultLabelResult.AutoSize = true;
            this.ResultLabelResult.Location = new System.Drawing.Point(81, 159);
            this.ResultLabelResult.Name = "ResultLabelResult";
            this.ResultLabelResult.Size = new System.Drawing.Size(51, 20);
            this.ResultLabelResult.TabIndex = 5;
            this.ResultLabelResult.Text = "label2";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(6, 159);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 20);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result:";
            // 
            // SourceTwoComboBox
            // 
            this.SourceTwoComboBox.Enabled = false;
            this.SourceTwoComboBox.FormattingEnabled = true;
            this.SourceTwoComboBox.Location = new System.Drawing.Point(85, 67);
            this.SourceTwoComboBox.Name = "SourceTwoComboBox";
            this.SourceTwoComboBox.Size = new System.Drawing.Size(272, 28);
            this.SourceTwoComboBox.TabIndex = 3;
            // 
            // FactorTwoTextBox
            // 
            this.FactorTwoTextBox.Location = new System.Drawing.Point(6, 67);
            this.FactorTwoTextBox.Mask = "00";
            this.FactorTwoTextBox.Name = "FactorTwoTextBox";
            this.FactorTwoTextBox.Size = new System.Drawing.Size(37, 26);
            this.FactorTwoTextBox.TabIndex = 2;
            this.FactorTwoTextBox.ValidatingType = typeof(int);
            // 
            // SourceOneComboBox
            // 
            this.SourceOneComboBox.Enabled = false;
            this.SourceOneComboBox.FormattingEnabled = true;
            this.SourceOneComboBox.Location = new System.Drawing.Point(85, 33);
            this.SourceOneComboBox.Name = "SourceOneComboBox";
            this.SourceOneComboBox.Size = new System.Drawing.Size(272, 28);
            this.SourceOneComboBox.TabIndex = 1;
            // 
            // FactorOneTextBox
            // 
            this.FactorOneTextBox.Location = new System.Drawing.Point(6, 35);
            this.FactorOneTextBox.Mask = "00";
            this.FactorOneTextBox.Name = "FactorOneTextBox";
            this.FactorOneTextBox.Size = new System.Drawing.Size(37, 26);
            this.FactorOneTextBox.TabIndex = 0;
            this.FactorOneTextBox.ValidatingType = typeof(int);
            // 
            // FiledComboBox
            // 
            this.FiledComboBox.Enabled = true;
            this.FiledComboBox.FormattingEnabled = true;
            this.FiledComboBox.Items.AddRange(new object[] {
            "Первая строка",
            "Вторая строка ",
            "Третья строка"});
            this.FiledComboBox.Location = new System.Drawing.Point(85, 101);
            this.FiledComboBox.Name = "FiledComboBox";
            this.FiledComboBox.Size = new System.Drawing.Size(272, 28);
            this.FiledComboBox.TabIndex = 6;
            // 
            // BindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.sourceGroupBox);
            this.Name = "BindingForm";
            this.Text = "BindingForm";
            this.sourceGroupBox.ResumeLayout(false);
            this.sourceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sourceGroupBox;
        private System.Windows.Forms.ComboBox SourceOneComboBox;
        private System.Windows.Forms.MaskedTextBox FactorOneTextBox;
        private System.Windows.Forms.MaskedTextBox FactorTwoTextBox;
        private System.Windows.Forms.ComboBox SourceTwoComboBox;
        private System.Windows.Forms.Label ResultLabelResult;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ComboBox FiledComboBox;
    }
}