namespace Colored_Dota_2_Text
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBox = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.clipboard = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.LinkLabel();
            this.clearClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "Default",
            "Beige",
            "Blue",
            "Brown",
            "Dark Green",
            "Green",
            "Grey",
            "Light Green",
            "Light Purple",
            "Magenta",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Reddish Orange",
            "Sky Blue",
            "Yellow"});
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 225);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clear.Location = new System.Drawing.Point(138, 127);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(175, 45);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clipboard
            // 
            this.clipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clipboard.Location = new System.Drawing.Point(319, 127);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(175, 45);
            this.clipboard.TabIndex = 2;
            this.clipboard.Text = "Copy to Clipboard";
            this.clipboard.UseVisualStyleBackColor = true;
            this.clipboard.Click += new System.EventHandler(this.clipboard_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(138, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(356, 109);
            this.textBox.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(140, 226);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(342, 13);
            this.label.TabIndex = 4;
            this.label.TabStop = true;
            this.label.Text = "Created by Takeru of zSource using MonoDevelop - http://zsource.org";
            this.label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // clearClipboard
            // 
            this.clearClipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearClipboard.Location = new System.Drawing.Point(138, 178);
            this.clearClipboard.Name = "clearClipboard";
            this.clearClipboard.Size = new System.Drawing.Size(356, 45);
            this.clearClipboard.TabIndex = 5;
            this.clearClipboard.Text = "Clear Clipboard";
            this.clearClipboard.UseVisualStyleBackColor = true;
            this.clearClipboard.Click += new System.EventHandler(this.clearClipboard_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 248);
            this.Controls.Add(this.clearClipboard);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.clipboard);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 287);
            this.MinimumSize = new System.Drawing.Size(524, 287);
            this.Name = "Main";
            this.Text = "Dota 2 Colored Text";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clipboard;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.LinkLabel label;
        private System.Windows.Forms.Button clearClipboard;
    }
}

