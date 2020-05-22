namespace Kvn.HabrQnaNetSamples.Forms
{
    partial class PassingParamChildForm
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
            this.SamplePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SamplePictureBox
            // 
            this.SamplePictureBox.Image = global::Kvn.HabrQnaNetSamples.Properties.Resources._5ec63044d7f03756143167;
            this.SamplePictureBox.Location = new System.Drawing.Point(12, 12);
            this.SamplePictureBox.Name = "SamplePictureBox";
            this.SamplePictureBox.Size = new System.Drawing.Size(349, 426);
            this.SamplePictureBox.TabIndex = 0;
            this.SamplePictureBox.TabStop = false;
            // 
            // PassingParamChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SamplePictureBox);
            this.Name = "PassingParamChildForm";
            this.Text = "PassingParamChildForm";
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox SamplePictureBox;
    }
}