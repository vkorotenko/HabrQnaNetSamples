using Kvn.HabrQnaNetSamples.Controls;

namespace Kvn.HabrQnaNetSamples.Controls

{
    partial class TreeViewBindingForm
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.titleTextBox = new PlaceholderTextBox();
            this.descriptionTexBox = new PlaceholderTextBox();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.descriptionTexBox, 0, 2);
            this.mainTableLayout.Controls.Add(this.treeView, 0, 0);
            this.mainTableLayout.Controls.Add(this.titleTextBox, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 839);
            this.mainTableLayout.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(794, 394);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(3, 403);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Placeholder = "Имя ветки";
            this.titleTextBox.Size = new System.Drawing.Size(794, 26);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // descriptionTexBox
            // 
            this.descriptionTexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTexBox.Location = new System.Drawing.Point(3, 443);
            this.descriptionTexBox.Multiline = true;
            this.descriptionTexBox.Name = "descriptionTexBox";
            this.descriptionTexBox.Placeholder = "Описание";
            this.descriptionTexBox.Size = new System.Drawing.Size(794, 393);
            this.descriptionTexBox.TabIndex = 2;
            this.descriptionTexBox.TextChanged += new System.EventHandler(this.descriptionTexBox_TextChanged);
            // 
            // TreeViewBindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 839);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "TreeViewBindingForm";
            this.Text = "Tree view binding example";
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TreeView treeView;
        private PlaceholderTextBox titleTextBox;
        private PlaceholderTextBox descriptionTexBox;
    }
}

