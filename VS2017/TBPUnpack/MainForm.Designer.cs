//Copyright © Dawid Dyrcz 2019 see LICENSE file
namespace TBPUnpack
{
    partial class MainForm
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
            this.inputFile_textBox = new System.Windows.Forms.TextBox();
            this.outputDir_textBox = new System.Windows.Forms.TextBox();
            this.browseInputFile_button = new System.Windows.Forms.Button();
            this.browseOutputDir_button = new System.Windows.Forms.Button();
            this.inputFile_label = new System.Windows.Forms.Label();
            this.outputDir_label = new System.Windows.Forms.Label();
            this.unpack_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.github_linkLabel = new System.Windows.Forms.LinkLabel();
            this.warehouse_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // inputFile_textBox
            // 
            this.inputFile_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFile_textBox.Location = new System.Drawing.Point(7, 40);
            this.inputFile_textBox.Name = "inputFile_textBox";
            this.inputFile_textBox.Size = new System.Drawing.Size(345, 20);
            this.inputFile_textBox.TabIndex = 0;
            this.inputFile_textBox.TextChanged += new System.EventHandler(this.InputFile_textBox_TextChanged);
            // 
            // outputDir_textBox
            // 
            this.outputDir_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDir_textBox.Location = new System.Drawing.Point(7, 79);
            this.outputDir_textBox.Name = "outputDir_textBox";
            this.outputDir_textBox.Size = new System.Drawing.Size(345, 20);
            this.outputDir_textBox.TabIndex = 1;
            // 
            // browseInputFile_button
            // 
            this.browseInputFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInputFile_button.Location = new System.Drawing.Point(358, 37);
            this.browseInputFile_button.Name = "browseInputFile_button";
            this.browseInputFile_button.Size = new System.Drawing.Size(99, 23);
            this.browseInputFile_button.TabIndex = 2;
            this.browseInputFile_button.Text = "Browse";
            this.browseInputFile_button.UseVisualStyleBackColor = true;
            this.browseInputFile_button.Click += new System.EventHandler(this.BrowseInputFile_button_Click);
            // 
            // browseOutputDir_button
            // 
            this.browseOutputDir_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputDir_button.Location = new System.Drawing.Point(358, 76);
            this.browseOutputDir_button.Name = "browseOutputDir_button";
            this.browseOutputDir_button.Size = new System.Drawing.Size(99, 23);
            this.browseOutputDir_button.TabIndex = 3;
            this.browseOutputDir_button.Text = "Browse";
            this.browseOutputDir_button.UseVisualStyleBackColor = true;
            this.browseOutputDir_button.Click += new System.EventHandler(this.BrowseOutputDir_button_Click);
            // 
            // inputFile_label
            // 
            this.inputFile_label.AutoSize = true;
            this.inputFile_label.Location = new System.Drawing.Point(4, 24);
            this.inputFile_label.Name = "inputFile_label";
            this.inputFile_label.Size = new System.Drawing.Size(75, 13);
            this.inputFile_label.TabIndex = 4;
            this.inputFile_label.Text = "Input *.tbp file:";
            // 
            // outputDir_label
            // 
            this.outputDir_label.AutoSize = true;
            this.outputDir_label.Location = new System.Drawing.Point(4, 63);
            this.outputDir_label.Name = "outputDir_label";
            this.outputDir_label.Size = new System.Drawing.Size(85, 13);
            this.outputDir_label.TabIndex = 5;
            this.outputDir_label.Text = "Output directory:";
            // 
            // unpack_button
            // 
            this.unpack_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unpack_button.Location = new System.Drawing.Point(358, 153);
            this.unpack_button.Name = "unpack_button";
            this.unpack_button.Size = new System.Drawing.Size(99, 23);
            this.unpack_button.TabIndex = 6;
            this.unpack_button.Text = "Extract models";
            this.unpack_button.UseVisualStyleBackColor = true;
            this.unpack_button.Click += new System.EventHandler(this.Unpack_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"TBP Files\"|*tbp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "This program extracts models from the Tekla BimSight *.tbp file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "License and source codes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Other Tekla tools:";
            // 
            // linkLabel1
            // 
            this.github_linkLabel.AutoSize = true;
            this.github_linkLabel.Location = new System.Drawing.Point(37, 123);
            this.github_linkLabel.Name = "linkLabel1";
            this.github_linkLabel.Size = new System.Drawing.Size(242, 13);
            this.github_linkLabel.TabIndex = 10;
            this.github_linkLabel.TabStop = true;
            this.github_linkLabel.Text = "https://github.com/dawiddyrcz/Tekla-tbp-unpack";
            this.github_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_linkLabel_LinkClicked);
            // 
            // linkLabel2
            // 
            this.warehouse_linkLabel.AutoSize = true;
            this.warehouse_linkLabel.Location = new System.Drawing.Point(37, 162);
            this.warehouse_linkLabel.Name = "linkLabel2";
            this.warehouse_linkLabel.Size = new System.Drawing.Size(203, 13);
            this.warehouse_linkLabel.TabIndex = 11;
            this.warehouse_linkLabel.TabStop = true;
            this.warehouse_linkLabel.Text = "http://bit.ly/DawidDyrczTeklaWarehouse";
            this.warehouse_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Warehouse_linkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 181);
            this.Controls.Add(this.warehouse_linkLabel);
            this.Controls.Add(this.github_linkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unpack_button);
            this.Controls.Add(this.outputDir_label);
            this.Controls.Add(this.inputFile_label);
            this.Controls.Add(this.browseOutputDir_button);
            this.Controls.Add(this.browseInputFile_button);
            this.Controls.Add(this.outputDir_textBox);
            this.Controls.Add(this.inputFile_textBox);
            this.MinimumSize = new System.Drawing.Size(450, 220);
            this.Name = "MainForm";
            this.Text = "TBP Unpack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFile_textBox;
        private System.Windows.Forms.TextBox outputDir_textBox;
        private System.Windows.Forms.Button browseInputFile_button;
        private System.Windows.Forms.Button browseOutputDir_button;
        private System.Windows.Forms.Label inputFile_label;
        private System.Windows.Forms.Label outputDir_label;
        private System.Windows.Forms.Button unpack_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel github_linkLabel;
        private System.Windows.Forms.LinkLabel warehouse_linkLabel;
    }
}

