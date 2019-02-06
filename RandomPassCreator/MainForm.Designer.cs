namespace RandomPassCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbGeneratedPassword = new System.Windows.Forms.TextBox();
            this.lblGeneratedPassword = new System.Windows.Forms.Label();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.valPassLen = new System.Windows.Forms.NumericUpDown();
            this.lblPassLength = new System.Windows.Forms.Label();
            this.chkUppercaseAlphabets = new System.Windows.Forms.CheckBox();
            this.chkLowercaseAlphabets = new System.Windows.Forms.CheckBox();
            this.chkSpecialChars = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valPassLen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGeneratedPassword
            // 
            this.tbGeneratedPassword.Location = new System.Drawing.Point(109, 17);
            this.tbGeneratedPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbGeneratedPassword.Name = "tbGeneratedPassword";
            this.tbGeneratedPassword.ReadOnly = true;
            this.tbGeneratedPassword.Size = new System.Drawing.Size(198, 22);
            this.tbGeneratedPassword.TabIndex = 0;
            // 
            // lblGeneratedPassword
            // 
            this.lblGeneratedPassword.AutoSize = true;
            this.lblGeneratedPassword.Location = new System.Drawing.Point(18, 20);
            this.lblGeneratedPassword.Name = "lblGeneratedPassword";
            this.lblGeneratedPassword.Size = new System.Drawing.Size(90, 15);
            this.lblGeneratedPassword.TabIndex = 1;
            this.lblGeneratedPassword.Text = "Generated Pass:";
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(10, 118);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(146, 19);
            this.chkNumbers.TabIndex = 2;
            this.chkNumbers.Text = "Contains numbers (0-9)";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // valPassLen
            // 
            this.valPassLen.Location = new System.Drawing.Point(156, 52);
            this.valPassLen.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.valPassLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valPassLen.Name = "valPassLen";
            this.valPassLen.Size = new System.Drawing.Size(62, 22);
            this.valPassLen.TabIndex = 3;
            this.valPassLen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblPassLength
            // 
            this.lblPassLength.AutoSize = true;
            this.lblPassLength.Location = new System.Drawing.Point(107, 54);
            this.lblPassLength.Name = "lblPassLength";
            this.lblPassLength.Size = new System.Drawing.Size(46, 15);
            this.lblPassLength.TabIndex = 4;
            this.lblPassLength.Text = "Length:";
            // 
            // chkUppercaseAlphabets
            // 
            this.chkUppercaseAlphabets.AutoSize = true;
            this.chkUppercaseAlphabets.Checked = true;
            this.chkUppercaseAlphabets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercaseAlphabets.Location = new System.Drawing.Point(163, 97);
            this.chkUppercaseAlphabets.Name = "chkUppercaseAlphabets";
            this.chkUppercaseAlphabets.Size = new System.Drawing.Size(152, 19);
            this.chkUppercaseAlphabets.TabIndex = 2;
            this.chkUppercaseAlphabets.Text = "Contains alphabets (A-Z)";
            this.chkUppercaseAlphabets.UseVisualStyleBackColor = true;
            // 
            // chkLowercaseAlphabets
            // 
            this.chkLowercaseAlphabets.AutoSize = true;
            this.chkLowercaseAlphabets.Checked = true;
            this.chkLowercaseAlphabets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercaseAlphabets.Enabled = false;
            this.chkLowercaseAlphabets.Location = new System.Drawing.Point(10, 97);
            this.chkLowercaseAlphabets.Name = "chkLowercaseAlphabets";
            this.chkLowercaseAlphabets.Size = new System.Drawing.Size(150, 19);
            this.chkLowercaseAlphabets.TabIndex = 5;
            this.chkLowercaseAlphabets.Text = "Contains alphabets (a-z)";
            this.chkLowercaseAlphabets.UseVisualStyleBackColor = true;
            // 
            // chkSpecialChars
            // 
            this.chkSpecialChars.AutoSize = true;
            this.chkSpecialChars.Checked = true;
            this.chkSpecialChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecialChars.Location = new System.Drawing.Point(163, 118);
            this.chkSpecialChars.Name = "chkSpecialChars";
            this.chkSpecialChars.Size = new System.Drawing.Size(140, 19);
            this.chkSpecialChars.TabIndex = 6;
            this.chkSpecialChars.Text = "Contains special chars";
            this.chkSpecialChars.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(125, 147);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 175);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkSpecialChars);
            this.Controls.Add(this.chkLowercaseAlphabets);
            this.Controls.Add(this.lblPassLength);
            this.Controls.Add(this.valPassLen);
            this.Controls.Add(this.chkUppercaseAlphabets);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.lblGeneratedPassword);
            this.Controls.Add(this.tbGeneratedPassword);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Password Creator";
            ((System.ComponentModel.ISupportInitialize)(this.valPassLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGeneratedPassword;
        private System.Windows.Forms.Label lblGeneratedPassword;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.NumericUpDown valPassLen;
        private System.Windows.Forms.Label lblPassLength;
        private System.Windows.Forms.CheckBox chkUppercaseAlphabets;
        private System.Windows.Forms.CheckBox chkLowercaseAlphabets;
        private System.Windows.Forms.CheckBox chkSpecialChars;
        private System.Windows.Forms.Button btnGenerate;
    }
}

