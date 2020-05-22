namespace Kvn.HabrQnaNetSamples.Forms
{
    partial class PassingParamForm
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
            this.HabraLink = new System.Windows.Forms.LinkLabel();
            this.CreateFormButton = new System.Windows.Forms.Button();
            this.SetWidthButton = new System.Windows.Forms.Button();
            this.SetButtonPublic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HabraLink
            // 
            this.HabraLink.AutoSize = true;
            this.HabraLink.Location = new System.Drawing.Point(13, 13);
            this.HabraLink.Name = "HabraLink";
            this.HabraLink.Size = new System.Drawing.Size(225, 20);
            this.HabraLink.TabIndex = 0;
            this.HabraLink.TabStop = true;
            this.HabraLink.Text = "https://qna.habr.com/q/776631";
            this.HabraLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HabraLinkLinkClicked);
            // 
            // CreateFormButton
            // 
            this.CreateFormButton.Location = new System.Drawing.Point(27, 58);
            this.CreateFormButton.Name = "CreateFormButton";
            this.CreateFormButton.Size = new System.Drawing.Size(357, 44);
            this.CreateFormButton.TabIndex = 1;
            this.CreateFormButton.Text = "Передача в конструкторе";
            this.CreateFormButton.UseVisualStyleBackColor = true;
            this.CreateFormButton.Click += new System.EventHandler(this.CreateFormButtonClick);
            // 
            // SetWidthButton
            // 
            this.SetWidthButton.Location = new System.Drawing.Point(27, 108);
            this.SetWidthButton.Name = "SetWidthButton";
            this.SetWidthButton.Size = new System.Drawing.Size(357, 40);
            this.SetWidthButton.TabIndex = 2;
            this.SetWidthButton.Text = "Установка ширины";
            this.SetWidthButton.UseVisualStyleBackColor = true;
            this.SetWidthButton.Click += new System.EventHandler(this.SetWidthButtonClick);
            // 
            // SetButtonPublic
            // 
            this.SetButtonPublic.Location = new System.Drawing.Point(27, 154);
            this.SetButtonPublic.Name = "SetButtonPublic";
            this.SetButtonPublic.Size = new System.Drawing.Size(357, 40);
            this.SetButtonPublic.TabIndex = 3;
            this.SetButtonPublic.Text = "Установка ширины";
            this.SetButtonPublic.UseVisualStyleBackColor = true;
            this.SetButtonPublic.Click += new System.EventHandler(this.SetButtonPublicClick);
            // 
            // PassingParamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetButtonPublic);
            this.Controls.Add(this.SetWidthButton);
            this.Controls.Add(this.CreateFormButton);
            this.Controls.Add(this.HabraLink);
            this.Name = "PassingParamForm";
            this.Text = "PassingParamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel HabraLink;
        private System.Windows.Forms.Button CreateFormButton;
        private System.Windows.Forms.Button SetWidthButton;
        private System.Windows.Forms.Button SetButtonPublic;
    }
}