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
            this.SuspendLayout();
            // 
            // inputFile_textBox
            // 
            this.inputFile_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFile_textBox.Location = new System.Drawing.Point(7, 26);
            this.inputFile_textBox.Name = "inputFile_textBox";
            this.inputFile_textBox.Size = new System.Drawing.Size(379, 20);
            this.inputFile_textBox.TabIndex = 0;
            this.inputFile_textBox.TextChanged += new System.EventHandler(this.InputFile_textBox_TextChanged);
            // 
            // outputDir_textBox
            // 
            this.outputDir_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDir_textBox.Location = new System.Drawing.Point(7, 80);
            this.outputDir_textBox.Name = "outputDir_textBox";
            this.outputDir_textBox.Size = new System.Drawing.Size(379, 20);
            this.outputDir_textBox.TabIndex = 1;
            // 
            // browseInputFile_button
            // 
            this.browseInputFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInputFile_button.Location = new System.Drawing.Point(392, 24);
            this.browseInputFile_button.Name = "browseInputFile_button";
            this.browseInputFile_button.Size = new System.Drawing.Size(75, 23);
            this.browseInputFile_button.TabIndex = 2;
            this.browseInputFile_button.Text = "Browse";
            this.browseInputFile_button.UseVisualStyleBackColor = true;
            this.browseInputFile_button.Click += new System.EventHandler(this.BrowseInputFile_button_Click);
            // 
            // browseOutputDir_button
            // 
            this.browseOutputDir_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputDir_button.Location = new System.Drawing.Point(392, 78);
            this.browseOutputDir_button.Name = "browseOutputDir_button";
            this.browseOutputDir_button.Size = new System.Drawing.Size(75, 23);
            this.browseOutputDir_button.TabIndex = 3;
            this.browseOutputDir_button.Text = "Browse";
            this.browseOutputDir_button.UseVisualStyleBackColor = true;
            this.browseOutputDir_button.Click += new System.EventHandler(this.BrowseOutputDir_button_Click);
            // 
            // inputFile_label
            // 
            this.inputFile_label.AutoSize = true;
            this.inputFile_label.Location = new System.Drawing.Point(8, 4);
            this.inputFile_label.Name = "inputFile_label";
            this.inputFile_label.Size = new System.Drawing.Size(50, 13);
            this.inputFile_label.TabIndex = 4;
            this.inputFile_label.Text = "Input file:";
            // 
            // outputDir_label
            // 
            this.outputDir_label.AutoSize = true;
            this.outputDir_label.Location = new System.Drawing.Point(4, 55);
            this.outputDir_label.Name = "outputDir_label";
            this.outputDir_label.Size = new System.Drawing.Size(85, 13);
            this.outputDir_label.TabIndex = 5;
            this.outputDir_label.Text = "Output directory:";
            // 
            // unpack_button
            // 
            this.unpack_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unpack_button.Location = new System.Drawing.Point(392, 126);
            this.unpack_button.Name = "unpack_button";
            this.unpack_button.Size = new System.Drawing.Size(75, 23);
            this.unpack_button.TabIndex = 6;
            this.unpack_button.Text = "Unpack";
            this.unpack_button.UseVisualStyleBackColor = true;
            this.unpack_button.Click += new System.EventHandler(this.Unpack_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"TBP Files\"|*tbp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 161);
            this.Controls.Add(this.unpack_button);
            this.Controls.Add(this.outputDir_label);
            this.Controls.Add(this.inputFile_label);
            this.Controls.Add(this.browseOutputDir_button);
            this.Controls.Add(this.browseInputFile_button);
            this.Controls.Add(this.outputDir_textBox);
            this.Controls.Add(this.inputFile_textBox);
            this.MinimumSize = new System.Drawing.Size(300, 200);
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
    }
}

