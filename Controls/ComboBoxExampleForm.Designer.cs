namespace Kvn.HabrQnaNetSamples.Controls
{
    partial class ComboBoxExampleForm
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
            this.startCompound1 = new System.Windows.Forms.ComboBox();
            this.startCompound2 = new System.Windows.Forms.ComboBox();
            this.startCompound3 = new System.Windows.Forms.ComboBox();
            this.startCompound4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startCompound1
            // 
            this.startCompound1.FormattingEnabled = true;
            this.startCompound1.Location = new System.Drawing.Point(55, 41);
            this.startCompound1.Name = "startCompound1";
            this.startCompound1.Size = new System.Drawing.Size(121, 28);
            this.startCompound1.TabIndex = 0;
            // 
            // startCompound2
            // 
            this.startCompound2.FormattingEnabled = true;
            this.startCompound2.Location = new System.Drawing.Point(55, 75);
            this.startCompound2.Name = "startCompound2";
            this.startCompound2.Size = new System.Drawing.Size(121, 28);
            this.startCompound2.TabIndex = 1;
            // 
            // startCompound3
            // 
            this.startCompound3.FormattingEnabled = true;
            this.startCompound3.Location = new System.Drawing.Point(55, 109);
            this.startCompound3.Name = "startCompound3";
            this.startCompound3.Size = new System.Drawing.Size(121, 28);
            this.startCompound3.TabIndex = 2;
            // 
            // startCompound4
            // 
            this.startCompound4.FormattingEnabled = true;
            this.startCompound4.Location = new System.Drawing.Point(55, 143);
            this.startCompound4.Name = "startCompound4";
            this.startCompound4.Size = new System.Drawing.Size(121, 28);
            this.startCompound4.TabIndex = 3;
            // 
            // ComboBoxExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 217);
            this.Controls.Add(this.startCompound4);
            this.Controls.Add(this.startCompound3);
            this.Controls.Add(this.startCompound2);
            this.Controls.Add(this.startCompound1);
            this.Name = "ComboBoxExampleForm";
            this.Text = "ComboBoxExampleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox startCompound1;
        private System.Windows.Forms.ComboBox startCompound2;
        private System.Windows.Forms.ComboBox startCompound3;
        private System.Windows.Forms.ComboBox startCompound4;
    }
}