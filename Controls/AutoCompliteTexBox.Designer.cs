namespace Kvn.HabrQnaNetSamples.Controls
{
    partial class AutoCompliteTexBox
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
            this.habrLabel = new System.Windows.Forms.LinkLabel();
            this.autoCompleteTextBox1 = new Kvn.HabrQnaNetSamples.Controls.AutoCompleteTextBox();
            this.SuspendLayout();
            // 
            // habrLabel
            // 
            this.habrLabel.AutoSize = true;
            this.habrLabel.Location = new System.Drawing.Point(12, 9);
            this.habrLabel.Name = "habrLabel";
            this.habrLabel.Size = new System.Drawing.Size(225, 20);
            this.habrLabel.TabIndex = 0;
            this.habrLabel.TabStop = true;
            this.habrLabel.Text = "https://qna.habr.com/q/775639";
            // 
            // autoCompleteTextBox1
            // 
            this.autoCompleteTextBox1.BackColor = System.Drawing.Color.White;
            this.autoCompleteTextBox1.BorderColor = System.Drawing.Color.Blue;
            this.autoCompleteTextBox1.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.autoCompleteTextBox1.Font = new System.Drawing.Font("Arial", 33.75F);
            this.autoCompleteTextBox1.FontTextPreview = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.autoCompleteTextBox1.ForeColor = System.Drawing.Color.Black;
            this.autoCompleteTextBox1.Location = new System.Drawing.Point(39, 73);
            this.autoCompleteTextBox1.Name = "autoCompleteTextBox1";
            this.autoCompleteTextBox1.Size = new System.Drawing.Size(379, 70);
            this.autoCompleteTextBox1.TabIndex = 1;
            this.autoCompleteTextBox1.TextInput = "";
            this.autoCompleteTextBox1.TextPreview = "Input text";
            // 
            // AutoCompliteTexBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoCompleteTextBox1);
            this.Controls.Add(this.habrLabel);
            this.Name = "AutoCompliteTexBox";
            this.Text = "AutoCompliteTexBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel habrLabel;
        private AutoCompleteTextBox autoCompleteTextBox1;
    }
}