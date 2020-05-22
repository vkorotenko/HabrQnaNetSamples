namespace Kvn.HabrQnaNetSamples.Controls
{
    partial class PictureBoxCtrlForm
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
            this.pictureBoxCtrl1 = new Kvn.HabrQnaNetSamples.Controls.PictureBoxCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCtrl1
            // 
            this.pictureBoxCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCtrl1.Image = global::Kvn.HabrQnaNetSamples.Properties.Resources._5ec63044d7f03756143167;
            this.pictureBoxCtrl1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCtrl1.Name = "pictureBoxCtrl1";
            this.pictureBoxCtrl1.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxCtrl1.TabIndex = 0;
            this.pictureBoxCtrl1.TabStop = false;
            // 
            // PictureBoxCtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxCtrl1);
            this.Name = "PictureBoxCtrlForm";
            this.Text = "PictureBoxCtrlForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxCtrl pictureBoxCtrl1;
    }
}