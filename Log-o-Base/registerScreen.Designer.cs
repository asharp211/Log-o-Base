namespace Log_o_Base
{
    partial class registerScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAccount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.charPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.charZipCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.createBttn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CloseBttn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAccount.HintForeColor = System.Drawing.Color.Empty;
            this.txtAccount.HintText = "";
            this.txtAccount.isPassword = false;
            this.txtAccount.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAccount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAccount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAccount.LineThickness = 3;
            this.txtAccount.Location = new System.Drawing.Point(822, 253);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(234, 44);
            this.txtAccount.TabIndex = 7;
            this.txtAccount.Text = "Account ID / Email";
            this.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAccount.OnValueChanged += new System.EventHandler(this.txtAccount_OnValueChanged);
            this.txtAccount.Enter += new System.EventHandler(this.txtAccIDEnter);
            this.txtAccount.Leave += new System.EventHandler(this.txtAccIDLeave);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(91, 289);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 44);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Address";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.OnValueChanged += new System.EventHandler(this.txtStreet_OnValueChanged);
            this.txtAddress.Enter += new System.EventHandler(this.txtAddressEnter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddressLeave);
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.HintForeColor = System.Drawing.Color.Empty;
            this.txtLastName.HintText = "";
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLastName.LineThickness = 3;
            this.txtLastName.Location = new System.Drawing.Point(91, 237);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(234, 44);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.OnValueChanged += new System.EventHandler(this.txtLastName_OnValueChanged);
            this.txtLastName.Enter += new System.EventHandler(this.txtLstNameEnter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLstNameLeave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.HintText = "";
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFirstName.LineThickness = 3;
            this.txtFirstName.Location = new System.Drawing.Point(92, 185);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(234, 44);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.OnValueChanged += new System.EventHandler(this.txtFirstName_OnValueChanged);
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstNameEnter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstNameLeave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.HintText = "";
            this.txtNewPassword.isPassword = false;
            this.txtNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNewPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNewPassword.LineThickness = 3;
            this.txtNewPassword.Location = new System.Drawing.Point(822, 305);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(234, 44);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.Text = "Password";
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword.OnValueChanged += new System.EventHandler(this.txtNewPassword_OnValueChanged);
            this.txtNewPassword.Enter += new System.EventHandler(this.txtPassword1Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtPassword1Leave);
            // 
            // txtCity
            // 
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCity.HintForeColor = System.Drawing.Color.Empty;
            this.txtCity.HintText = "";
            this.txtCity.isPassword = false;
            this.txtCity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCity.LineThickness = 3;
            this.txtCity.Location = new System.Drawing.Point(91, 341);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(234, 44);
            this.txtCity.TabIndex = 4;
            this.txtCity.Text = "City";
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCity.OnValueChanged += new System.EventHandler(this.txtCity_OnValueChanged);
            this.txtCity.Enter += new System.EventHandler(this.txtCityEnter);
            this.txtCity.Leave += new System.EventHandler(this.txtCityLeave);
            // 
            // charPhoneNumber
            // 
            this.charPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.charPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.charPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.charPhoneNumber.HintForeColor = System.Drawing.Color.Empty;
            this.charPhoneNumber.HintText = "";
            this.charPhoneNumber.isPassword = false;
            this.charPhoneNumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.charPhoneNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.charPhoneNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.charPhoneNumber.LineThickness = 3;
            this.charPhoneNumber.Location = new System.Drawing.Point(91, 445);
            this.charPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.charPhoneNumber.Name = "charPhoneNumber";
            this.charPhoneNumber.Size = new System.Drawing.Size(234, 44);
            this.charPhoneNumber.TabIndex = 6;
            this.charPhoneNumber.Text = "Phone #";
            this.charPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.charPhoneNumber.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox8_OnValueChanged);
            this.charPhoneNumber.Enter += new System.EventHandler(this.txtPhoneEnter);
            this.charPhoneNumber.Leave += new System.EventHandler(this.txtPhoneLeave);
            // 
            // charZipCode
            // 
            this.charZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.charZipCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.charZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.charZipCode.HintForeColor = System.Drawing.Color.Empty;
            this.charZipCode.HintText = "";
            this.charZipCode.isPassword = false;
            this.charZipCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.charZipCode.LineIdleColor = System.Drawing.Color.Gray;
            this.charZipCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.charZipCode.LineThickness = 3;
            this.charZipCode.Location = new System.Drawing.Point(92, 393);
            this.charZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.charZipCode.Name = "charZipCode";
            this.charZipCode.Size = new System.Drawing.Size(234, 44);
            this.charZipCode.TabIndex = 5;
            this.charZipCode.Text = "Zip Code";
            this.charZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.charZipCode.OnValueChanged += new System.EventHandler(this.charZipCode_OnValueChanged);
            this.charZipCode.Enter += new System.EventHandler(this.txtZipEnter);
            this.charZipCode.Leave += new System.EventHandler(this.txtZipLeave);
            // 
            // createBttn
            // 
            this.createBttn.BackColor = System.Drawing.Color.Green;
            this.createBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBttn.ForeColor = System.Drawing.Color.White;
            this.createBttn.Location = new System.Drawing.Point(822, 374);
            this.createBttn.Name = "createBttn";
            this.createBttn.Size = new System.Drawing.Size(106, 33);
            this.createBttn.TabIndex = 9;
            this.createBttn.Text = "Create";
            this.createBttn.UseVisualStyleBackColor = false;
            this.createBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(52, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(323, 19);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Let\'s log in your data!";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(52, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(429, 19);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Enter in the basic information to register.";
            // 
            // CloseBttn
            // 
            this.CloseBttn.BackColor = System.Drawing.Color.Green;
            this.CloseBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBttn.ForeColor = System.Drawing.Color.White;
            this.CloseBttn.Location = new System.Drawing.Point(960, 374);
            this.CloseBttn.Name = "CloseBttn";
            this.CloseBttn.Size = new System.Drawing.Size(96, 33);
            this.CloseBttn.TabIndex = 10;
            this.CloseBttn.Text = "Close";
            this.CloseBttn.UseVisualStyleBackColor = false;
            this.CloseBttn.Click += new System.EventHandler(this.CloseBttn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(797, 278);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(18, 19);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "*";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.Red;
            this.richTextBox3.Location = new System.Drawing.Point(797, 314);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(18, 19);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "*";
            // 
            // registerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CloseBttn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createBttn);
            this.Controls.Add(this.charZipCode);
            this.Controls.Add(this.charPhoneNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAccount);
            this.Name = "registerScreen";
            this.Size = new System.Drawing.Size(1125, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAccount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox charPhoneNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox charZipCode;
        private System.Windows.Forms.Button createBttn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CloseBttn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}
