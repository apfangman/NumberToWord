namespace NumberToWord
{
    partial class NumberToWord
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
            this.uxInputBox = new System.Windows.Forms.TextBox();
            this.uxOutputBox = new System.Windows.Forms.TextBox();
            this.uxConvertButton = new System.Windows.Forms.Button();
            this.uxChainLabel = new System.Windows.Forms.Label();
            this.uxChainButton = new System.Windows.Forms.Button();
            this.uxActualChainLabel = new System.Windows.Forms.Label();
            this.uxLongestChainButton = new System.Windows.Forms.Button();
            this.uxChainLengthLabel = new System.Windows.Forms.Label();
            this.uxActualChainLengthLabel = new System.Windows.Forms.Label();
            this.uxCurrentLabel = new System.Windows.Forms.Label();
            this.uxActualCurrentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxInputBox
            // 
            this.uxInputBox.Location = new System.Drawing.Point(12, 12);
            this.uxInputBox.Name = "uxInputBox";
            this.uxInputBox.Size = new System.Drawing.Size(408, 20);
            this.uxInputBox.TabIndex = 0;
            // 
            // uxOutputBox
            // 
            this.uxOutputBox.Location = new System.Drawing.Point(12, 67);
            this.uxOutputBox.Multiline = true;
            this.uxOutputBox.Name = "uxOutputBox";
            this.uxOutputBox.ReadOnly = true;
            this.uxOutputBox.Size = new System.Drawing.Size(578, 119);
            this.uxOutputBox.TabIndex = 1;
            // 
            // uxConvertButton
            // 
            this.uxConvertButton.Location = new System.Drawing.Point(12, 38);
            this.uxConvertButton.Name = "uxConvertButton";
            this.uxConvertButton.Size = new System.Drawing.Size(75, 23);
            this.uxConvertButton.TabIndex = 2;
            this.uxConvertButton.Text = "Convert";
            this.uxConvertButton.UseVisualStyleBackColor = true;
            this.uxConvertButton.Click += new System.EventHandler(this.uxConvertButton_Click);
            // 
            // uxChainLabel
            // 
            this.uxChainLabel.AutoSize = true;
            this.uxChainLabel.Location = new System.Drawing.Point(12, 200);
            this.uxChainLabel.Name = "uxChainLabel";
            this.uxChainLabel.Size = new System.Drawing.Size(37, 13);
            this.uxChainLabel.TabIndex = 3;
            this.uxChainLabel.Text = "Chain:";
            // 
            // uxChainButton
            // 
            this.uxChainButton.Location = new System.Drawing.Point(93, 38);
            this.uxChainButton.Name = "uxChainButton";
            this.uxChainButton.Size = new System.Drawing.Size(75, 23);
            this.uxChainButton.TabIndex = 4;
            this.uxChainButton.Text = "Get Chain";
            this.uxChainButton.UseVisualStyleBackColor = true;
            this.uxChainButton.Click += new System.EventHandler(this.uxChainButton_Click);
            // 
            // uxActualChainLabel
            // 
            this.uxActualChainLabel.AutoSize = true;
            this.uxActualChainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uxActualChainLabel.Location = new System.Drawing.Point(12, 213);
            this.uxActualChainLabel.Name = "uxActualChainLabel";
            this.uxActualChainLabel.Size = new System.Drawing.Size(0, 13);
            this.uxActualChainLabel.TabIndex = 5;
            // 
            // uxLongestChainButton
            // 
            this.uxLongestChainButton.Location = new System.Drawing.Point(174, 38);
            this.uxLongestChainButton.Name = "uxLongestChainButton";
            this.uxLongestChainButton.Size = new System.Drawing.Size(93, 23);
            this.uxLongestChainButton.TabIndex = 6;
            this.uxLongestChainButton.Text = "Longest Chain";
            this.uxLongestChainButton.UseVisualStyleBackColor = true;
            this.uxLongestChainButton.Click += new System.EventHandler(this.uxLongestChainButton_Click);
            // 
            // uxChainLengthLabel
            // 
            this.uxChainLengthLabel.AutoSize = true;
            this.uxChainLengthLabel.Location = new System.Drawing.Point(14, 239);
            this.uxChainLengthLabel.Name = "uxChainLengthLabel";
            this.uxChainLengthLabel.Size = new System.Drawing.Size(43, 13);
            this.uxChainLengthLabel.TabIndex = 7;
            this.uxChainLengthLabel.Text = "Length:";
            // 
            // uxActualChainLengthLabel
            // 
            this.uxActualChainLengthLabel.AutoSize = true;
            this.uxActualChainLengthLabel.Location = new System.Drawing.Point(52, 239);
            this.uxActualChainLengthLabel.Name = "uxActualChainLengthLabel";
            this.uxActualChainLengthLabel.Size = new System.Drawing.Size(13, 13);
            this.uxActualChainLengthLabel.TabIndex = 8;
            this.uxActualChainLengthLabel.Text = "0";
            // 
            // uxCurrentLabel
            // 
            this.uxCurrentLabel.AutoSize = true;
            this.uxCurrentLabel.Location = new System.Drawing.Point(14, 268);
            this.uxCurrentLabel.Name = "uxCurrentLabel";
            this.uxCurrentLabel.Size = new System.Drawing.Size(47, 13);
            this.uxCurrentLabel.TabIndex = 9;
            this.uxCurrentLabel.Text = "Current: ";
            // 
            // uxActualCurrentLabel
            // 
            this.uxActualCurrentLabel.AutoSize = true;
            this.uxActualCurrentLabel.Location = new System.Drawing.Point(52, 268);
            this.uxActualCurrentLabel.Name = "uxActualCurrentLabel";
            this.uxActualCurrentLabel.Size = new System.Drawing.Size(0, 13);
            this.uxActualCurrentLabel.TabIndex = 10;
            // 
            // NumberToWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 290);
            this.Controls.Add(this.uxActualCurrentLabel);
            this.Controls.Add(this.uxCurrentLabel);
            this.Controls.Add(this.uxActualChainLengthLabel);
            this.Controls.Add(this.uxChainLengthLabel);
            this.Controls.Add(this.uxLongestChainButton);
            this.Controls.Add(this.uxActualChainLabel);
            this.Controls.Add(this.uxChainButton);
            this.Controls.Add(this.uxChainLabel);
            this.Controls.Add(this.uxConvertButton);
            this.Controls.Add(this.uxOutputBox);
            this.Controls.Add(this.uxInputBox);
            this.Name = "NumberToWord";
            this.Text = "NumberToWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxConvertButton;
        private System.Windows.Forms.TextBox uxOutputBox;
        private System.Windows.Forms.TextBox uxInputBox;
        private System.Windows.Forms.Label uxChainLabel;
        private System.Windows.Forms.Button uxChainButton;
        private System.Windows.Forms.Label uxActualChainLabel;
        private System.Windows.Forms.Button uxLongestChainButton;
        private System.Windows.Forms.Label uxChainLengthLabel;
        private System.Windows.Forms.Label uxActualChainLengthLabel;
        private System.Windows.Forms.Label uxCurrentLabel;
        private System.Windows.Forms.Label uxActualCurrentLabel;
    }
}

