namespace PersonAddress
{
    partial class CreatePerson
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
            this.AddNewAddress_Button = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.PersonEntryLabel = new System.Windows.Forms.Label();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressListBox = new System.Windows.Forms.ListBox();
            this.IsActiveLabel = new System.Windows.Forms.Label();
            this.AddressListLabel = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewAddress_Button
            // 
            this.AddNewAddress_Button.Location = new System.Drawing.Point(364, 287);
            this.AddNewAddress_Button.Name = "AddNewAddress_Button";
            this.AddNewAddress_Button.Size = new System.Drawing.Size(75, 39);
            this.AddNewAddress_Button.TabIndex = 4;
            this.AddNewAddress_Button.Text = "Add";
            this.AddNewAddress_Button.UseVisualStyleBackColor = true;
            this.AddNewAddress_Button.Click += new System.EventHandler(this.AddNewAddress_Button_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(37, 90);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 32);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(187, 87);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(262, 38);
            this.FirstName_TextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(37, 153);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(143, 32);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "LastName";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(187, 153);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(262, 38);
            this.LastName_TextBox.TabIndex = 2;
            // 
            // PersonEntryLabel
            // 
            this.PersonEntryLabel.AutoSize = true;
            this.PersonEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonEntryLabel.Location = new System.Drawing.Point(46, 8);
            this.PersonEntryLabel.Name = "PersonEntryLabel";
            this.PersonEntryLabel.Size = new System.Drawing.Size(371, 51);
            this.PersonEntryLabel.TabIndex = 5;
            this.PersonEntryLabel.Text = "PersonEntry Form";
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.Location = new System.Drawing.Point(187, 226);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IsActiveCheckBox.Size = new System.Drawing.Size(18, 17);
            this.IsActiveCheckBox.TabIndex = 3;
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressListBox
            // 
            this.AddressListBox.FormattingEnabled = true;
            this.AddressListBox.ItemHeight = 31;
            this.AddressListBox.Location = new System.Drawing.Point(12, 343);
            this.AddressListBox.Name = "AddressListBox";
            this.AddressListBox.Size = new System.Drawing.Size(589, 283);
            this.AddressListBox.TabIndex = 5;
            // 
            // IsActiveLabel
            // 
            this.IsActiveLabel.AutoSize = true;
            this.IsActiveLabel.Location = new System.Drawing.Point(37, 211);
            this.IsActiveLabel.Name = "IsActiveLabel";
            this.IsActiveLabel.Size = new System.Drawing.Size(92, 32);
            this.IsActiveLabel.TabIndex = 8;
            this.IsActiveLabel.Text = "Active";
            // 
            // AddressListLabel
            // 
            this.AddressListLabel.AutoSize = true;
            this.AddressListLabel.Location = new System.Drawing.Point(27, 297);
            this.AddressListLabel.Name = "AddressListLabel";
            this.AddressListLabel.Size = new System.Drawing.Size(148, 32);
            this.AddressListLabel.TabIndex = 9;
            this.AddressListLabel.Text = "Addresses";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(203, 646);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(93, 39);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // CreatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 713);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.AddressListLabel);
            this.Controls.Add(this.IsActiveLabel);
            this.Controls.Add(this.AddressListBox);
            this.Controls.Add(this.IsActiveCheckBox);
            this.Controls.Add(this.PersonEntryLabel);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstName_TextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AddNewAddress_Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreatePerson";
            this.Text = "Person Entry Form by shah Haque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewAddress_Button;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label PersonEntryLabel;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.ListBox AddressListBox;
        private System.Windows.Forms.Label IsActiveLabel;
        private System.Windows.Forms.Label AddressListLabel;
        private System.Windows.Forms.Button Save_Button;
    }
}

