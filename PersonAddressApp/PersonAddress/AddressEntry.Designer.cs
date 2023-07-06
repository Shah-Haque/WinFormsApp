namespace PersonAddress
{
    partial class AddressEntry
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
            this.Town_TextBox = new System.Windows.Forms.TextBox();
            this.TownLabel = new System.Windows.Forms.Label();
            this.StreetAddress_TextBox = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.PostCode_TextBox = new System.Windows.Forms.TextBox();
            this.PostCodeLabel = new System.Windows.Forms.Label();
            this.County_TextBox = new System.Windows.Forms.TextBox();
            this.CountyLabel = new System.Windows.Forms.Label();
            this.AddressEntryLabel = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Town_TextBox
            // 
            this.Town_TextBox.Location = new System.Drawing.Point(274, 157);
            this.Town_TextBox.Name = "Town_TextBox";
            this.Town_TextBox.Size = new System.Drawing.Size(333, 41);
            this.Town_TextBox.TabIndex = 6;
            // 
            // TownLabel
            // 
            this.TownLabel.AutoSize = true;
            this.TownLabel.Location = new System.Drawing.Point(177, 162);
            this.TownLabel.Name = "TownLabel";
            this.TownLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TownLabel.Size = new System.Drawing.Size(89, 36);
            this.TownLabel.TabIndex = 7;
            this.TownLabel.Text = "Town";
            // 
            // StreetAddress_TextBox
            // 
            this.StreetAddress_TextBox.Location = new System.Drawing.Point(274, 89);
            this.StreetAddress_TextBox.Name = "StreetAddress_TextBox";
            this.StreetAddress_TextBox.Size = new System.Drawing.Size(333, 41);
            this.StreetAddress_TextBox.TabIndex = 4;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Location = new System.Drawing.Point(54, 94);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StreetAddressLabel.Size = new System.Drawing.Size(212, 36);
            this.StreetAddressLabel.TabIndex = 5;
            this.StreetAddressLabel.Text = "Street Address";
            // 
            // PostCode_TextBox
            // 
            this.PostCode_TextBox.Location = new System.Drawing.Point(274, 287);
            this.PostCode_TextBox.Name = "PostCode_TextBox";
            this.PostCode_TextBox.Size = new System.Drawing.Size(333, 41);
            this.PostCode_TextBox.TabIndex = 10;
            // 
            // PostCodeLabel
            // 
            this.PostCodeLabel.AutoSize = true;
            this.PostCodeLabel.Location = new System.Drawing.Point(126, 292);
            this.PostCodeLabel.Name = "PostCodeLabel";
            this.PostCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostCodeLabel.Size = new System.Drawing.Size(140, 36);
            this.PostCodeLabel.TabIndex = 11;
            this.PostCodeLabel.Text = "Postcode";
            // 
            // County_TextBox
            // 
            this.County_TextBox.Location = new System.Drawing.Point(274, 224);
            this.County_TextBox.Name = "County_TextBox";
            this.County_TextBox.Size = new System.Drawing.Size(333, 41);
            this.County_TextBox.TabIndex = 8;
            // 
            // CountyLabel
            // 
            this.CountyLabel.AutoSize = true;
            this.CountyLabel.Location = new System.Drawing.Point(156, 227);
            this.CountyLabel.Name = "CountyLabel";
            this.CountyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountyLabel.Size = new System.Drawing.Size(110, 36);
            this.CountyLabel.TabIndex = 9;
            this.CountyLabel.Text = "County";
            // 
            // AddressEntryLabel
            // 
            this.AddressEntryLabel.AutoSize = true;
            this.AddressEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressEntryLabel.Location = new System.Drawing.Point(140, 18);
            this.AddressEntryLabel.Name = "AddressEntryLabel";
            this.AddressEntryLabel.Size = new System.Drawing.Size(393, 51);
            this.AddressEntryLabel.TabIndex = 12;
            this.AddressEntryLabel.Text = "AddressEntry Form";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(290, 365);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(154, 55);
            this.Save_Button.TabIndex = 13;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 432);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.AddressEntryLabel);
            this.Controls.Add(this.PostCode_TextBox);
            this.Controls.Add(this.PostCodeLabel);
            this.Controls.Add(this.County_TextBox);
            this.Controls.Add(this.CountyLabel);
            this.Controls.Add(this.Town_TextBox);
            this.Controls.Add(this.TownLabel);
            this.Controls.Add(this.StreetAddress_TextBox);
            this.Controls.Add(this.StreetAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddressEntry";
            this.Text = "AddressEntry by Shah Haque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Town_TextBox;
        private System.Windows.Forms.Label TownLabel;
        private System.Windows.Forms.TextBox StreetAddress_TextBox;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.TextBox PostCode_TextBox;
        private System.Windows.Forms.Label PostCodeLabel;
        private System.Windows.Forms.TextBox County_TextBox;
        private System.Windows.Forms.Label CountyLabel;
        private System.Windows.Forms.Label AddressEntryLabel;
        private System.Windows.Forms.Button Save_Button;
    }
}