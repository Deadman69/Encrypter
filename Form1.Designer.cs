namespace AppChiffrement
{
    partial class form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ChooseFileFolderEncrypt = new System.Windows.Forms.Label();
            this.button_chooseFileEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog_Encrypt = new System.Windows.Forms.OpenFileDialog();
            this.button_chooseFileDecrypt = new System.Windows.Forms.Button();
            this.label_ChooseFileFolderDecrypt = new System.Windows.Forms.Label();
            this.openFileDialog_Decrypt = new System.Windows.Forms.OpenFileDialog();
            this.label_PathFileFolderEncrypt = new System.Windows.Forms.Label();
            this.label_PathFileFolderDecrypt = new System.Windows.Forms.Label();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.button_chooseFolderEncrypt = new System.Windows.Forms.Button();
            this.button_chooseFolderDecrypt = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_deleteFilesAfterEncryption = new System.Windows.Forms.CheckBox();
            this.checkbox_deleteFilesAfterDecryption = new System.Windows.Forms.CheckBox();
            this.label_importPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_GenerateRandomPassword = new System.Windows.Forms.Label();
            this.checkbox_hidePassword = new System.Windows.Forms.CheckBox();
            this.slider_PasswordLength = new System.Windows.Forms.TrackBar();
            this.label_SliderPassword = new System.Windows.Forms.Label();
            this.button_GenerateRandomPassword = new System.Windows.Forms.Button();
            this.textbox_IgnoreExtensions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slider_PasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ChooseFileFolderEncrypt
            // 
            this.label_ChooseFileFolderEncrypt.AutoSize = true;
            this.label_ChooseFileFolderEncrypt.Location = new System.Drawing.Point(13, 57);
            this.label_ChooseFileFolderEncrypt.Name = "label_ChooseFileFolderEncrypt";
            this.label_ChooseFileFolderEncrypt.Size = new System.Drawing.Size(156, 13);
            this.label_ChooseFileFolderEncrypt.TabIndex = 7;
            this.label_ChooseFileFolderEncrypt.Text = "Choose file or folder to encrypt :";
            // 
            // button_chooseFileEncrypt
            // 
            this.button_chooseFileEncrypt.Location = new System.Drawing.Point(175, 68);
            this.button_chooseFileEncrypt.Name = "button_chooseFileEncrypt";
            this.button_chooseFileEncrypt.Size = new System.Drawing.Size(120, 23);
            this.button_chooseFileEncrypt.TabIndex = 8;
            this.button_chooseFileEncrypt.Text = "Choose a file";
            this.button_chooseFileEncrypt.UseVisualStyleBackColor = true;
            this.button_chooseFileEncrypt.Click += new System.EventHandler(this.button_chooseFileFolderEncrypt_Click);
            // 
            // openFileDialog_Encrypt
            // 
            this.openFileDialog_Encrypt.Title = "Choose a file or folder to encrypt";
            this.openFileDialog_Encrypt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_Encrypt_FileOk);
            // 
            // button_chooseFileDecrypt
            // 
            this.button_chooseFileDecrypt.Location = new System.Drawing.Point(175, 185);
            this.button_chooseFileDecrypt.Name = "button_chooseFileDecrypt";
            this.button_chooseFileDecrypt.Size = new System.Drawing.Size(120, 23);
            this.button_chooseFileDecrypt.TabIndex = 10;
            this.button_chooseFileDecrypt.Text = "Choose a file";
            this.button_chooseFileDecrypt.UseVisualStyleBackColor = true;
            this.button_chooseFileDecrypt.Click += new System.EventHandler(this.button_chooseFileFolderDecrypt_Click);
            // 
            // label_ChooseFileFolderDecrypt
            // 
            this.label_ChooseFileFolderDecrypt.AutoSize = true;
            this.label_ChooseFileFolderDecrypt.Location = new System.Drawing.Point(13, 174);
            this.label_ChooseFileFolderDecrypt.Name = "label_ChooseFileFolderDecrypt";
            this.label_ChooseFileFolderDecrypt.Size = new System.Drawing.Size(156, 13);
            this.label_ChooseFileFolderDecrypt.TabIndex = 9;
            this.label_ChooseFileFolderDecrypt.Text = "Choose file or folder to decrypt :";
            // 
            // openFileDialog_Decrypt
            // 
            this.openFileDialog_Decrypt.Title = "Choose a file or folder to decrypt";
            this.openFileDialog_Decrypt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_Decrypt_FileOk);
            // 
            // label_PathFileFolderEncrypt
            // 
            this.label_PathFileFolderEncrypt.AutoSize = true;
            this.label_PathFileFolderEncrypt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_PathFileFolderEncrypt.Location = new System.Drawing.Point(13, 103);
            this.label_PathFileFolderEncrypt.Name = "label_PathFileFolderEncrypt";
            this.label_PathFileFolderEncrypt.Size = new System.Drawing.Size(0, 13);
            this.label_PathFileFolderEncrypt.TabIndex = 11;
            // 
            // label_PathFileFolderDecrypt
            // 
            this.label_PathFileFolderDecrypt.AutoSize = true;
            this.label_PathFileFolderDecrypt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_PathFileFolderDecrypt.Location = new System.Drawing.Point(13, 224);
            this.label_PathFileFolderDecrypt.Name = "label_PathFileFolderDecrypt";
            this.label_PathFileFolderDecrypt.Size = new System.Drawing.Size(0, 13);
            this.label_PathFileFolderDecrypt.TabIndex = 12;
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(315, 52);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(120, 23);
            this.button_Encrypt.TabIndex = 13;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Location = new System.Drawing.Point(315, 169);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(120, 23);
            this.button_Decrypt.TabIndex = 14;
            this.button_Decrypt.Text = "Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
            // 
            // button_chooseFolderEncrypt
            // 
            this.button_chooseFolderEncrypt.Location = new System.Drawing.Point(175, 39);
            this.button_chooseFolderEncrypt.Name = "button_chooseFolderEncrypt";
            this.button_chooseFolderEncrypt.Size = new System.Drawing.Size(120, 23);
            this.button_chooseFolderEncrypt.TabIndex = 15;
            this.button_chooseFolderEncrypt.Text = "Choose a folder";
            this.button_chooseFolderEncrypt.UseVisualStyleBackColor = true;
            this.button_chooseFolderEncrypt.Click += new System.EventHandler(this.button_chooseFolderEncrypt_Click);
            // 
            // button_chooseFolderDecrypt
            // 
            this.button_chooseFolderDecrypt.Location = new System.Drawing.Point(175, 156);
            this.button_chooseFolderDecrypt.Name = "button_chooseFolderDecrypt";
            this.button_chooseFolderDecrypt.Size = new System.Drawing.Size(120, 23);
            this.button_chooseFolderDecrypt.TabIndex = 16;
            this.button_chooseFolderDecrypt.Text = "Choose a folder";
            this.button_chooseFolderDecrypt.UseVisualStyleBackColor = true;
            this.button_chooseFolderDecrypt.Click += new System.EventHandler(this.button_chooseFolderDecrypt_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(600, 26);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(188, 20);
            this.textbox_password.TabIndex = 17;
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password :";
            // 
            // checkbox_deleteFilesAfterEncryption
            // 
            this.checkbox_deleteFilesAfterEncryption.AutoSize = true;
            this.checkbox_deleteFilesAfterEncryption.Checked = true;
            this.checkbox_deleteFilesAfterEncryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_deleteFilesAfterEncryption.Location = new System.Drawing.Point(16, 307);
            this.checkbox_deleteFilesAfterEncryption.Name = "checkbox_deleteFilesAfterEncryption";
            this.checkbox_deleteFilesAfterEncryption.Size = new System.Drawing.Size(180, 17);
            this.checkbox_deleteFilesAfterEncryption.TabIndex = 20;
            this.checkbox_deleteFilesAfterEncryption.Text = "Delete base files after encryption";
            this.checkbox_deleteFilesAfterEncryption.UseVisualStyleBackColor = true;
            // 
            // checkbox_deleteFilesAfterDecryption
            // 
            this.checkbox_deleteFilesAfterDecryption.AutoSize = true;
            this.checkbox_deleteFilesAfterDecryption.Checked = true;
            this.checkbox_deleteFilesAfterDecryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_deleteFilesAfterDecryption.Location = new System.Drawing.Point(16, 330);
            this.checkbox_deleteFilesAfterDecryption.Name = "checkbox_deleteFilesAfterDecryption";
            this.checkbox_deleteFilesAfterDecryption.Size = new System.Drawing.Size(204, 17);
            this.checkbox_deleteFilesAfterDecryption.TabIndex = 21;
            this.checkbox_deleteFilesAfterDecryption.Text = "Delete encrypted files after decryption";
            this.checkbox_deleteFilesAfterDecryption.UseVisualStyleBackColor = true;
            // 
            // label_importPassword
            // 
            this.label_importPassword.AutoSize = true;
            this.label_importPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_importPassword.Location = new System.Drawing.Point(597, 49);
            this.label_importPassword.Name = "label_importPassword";
            this.label_importPassword.Size = new System.Drawing.Size(191, 13);
            this.label_importPassword.TabIndex = 22;
            this.label_importPassword.Text = "Click to import txt file with the password";
            this.label_importPassword.Click += new System.EventHandler(this.label_importPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(687, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "or";
            // 
            // label_GenerateRandomPassword
            // 
            this.label_GenerateRandomPassword.AutoSize = true;
            this.label_GenerateRandomPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_GenerateRandomPassword.Location = new System.Drawing.Point(605, 90);
            this.label_GenerateRandomPassword.Name = "label_GenerateRandomPassword";
            this.label_GenerateRandomPassword.Size = new System.Drawing.Size(173, 52);
            this.label_GenerateRandomPassword.TabIndex = 24;
            this.label_GenerateRandomPassword.Text = "Click to generate random password\r\n(it will be pasted in your clipboard,\r\nthen yo" +
    "u could paste it in a txt file\r\nor any file you want)";
            this.label_GenerateRandomPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_GenerateRandomPassword.Click += new System.EventHandler(this.label_GenerateRandomPassword_Click);
            // 
            // checkbox_hidePassword
            // 
            this.checkbox_hidePassword.AutoSize = true;
            this.checkbox_hidePassword.Checked = true;
            this.checkbox_hidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_hidePassword.Location = new System.Drawing.Point(260, 307);
            this.checkbox_hidePassword.Name = "checkbox_hidePassword";
            this.checkbox_hidePassword.Size = new System.Drawing.Size(96, 17);
            this.checkbox_hidePassword.TabIndex = 25;
            this.checkbox_hidePassword.Text = "Hide password";
            this.checkbox_hidePassword.UseVisualStyleBackColor = true;
            this.checkbox_hidePassword.CheckedChanged += new System.EventHandler(this.checkbox_hidePassword_CheckedChanged);
            // 
            // slider_PasswordLength
            // 
            this.slider_PasswordLength.Location = new System.Drawing.Point(600, 174);
            this.slider_PasswordLength.Maximum = 256;
            this.slider_PasswordLength.Minimum = 1;
            this.slider_PasswordLength.Name = "slider_PasswordLength";
            this.slider_PasswordLength.Size = new System.Drawing.Size(188, 45);
            this.slider_PasswordLength.TabIndex = 26;
            this.slider_PasswordLength.Value = 1;
            this.slider_PasswordLength.ValueChanged += new System.EventHandler(this.slider_PasswordLength_ValueChanged);
            // 
            // label_SliderPassword
            // 
            this.label_SliderPassword.AutoSize = true;
            this.label_SliderPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_SliderPassword.Location = new System.Drawing.Point(605, 158);
            this.label_SliderPassword.Name = "label_SliderPassword";
            this.label_SliderPassword.Size = new System.Drawing.Size(129, 13);
            this.label_SliderPassword.TabIndex = 27;
            this.label_SliderPassword.Text = "Choose password length :";
            this.label_SliderPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_GenerateRandomPassword
            // 
            this.button_GenerateRandomPassword.Location = new System.Drawing.Point(608, 222);
            this.button_GenerateRandomPassword.Name = "button_GenerateRandomPassword";
            this.button_GenerateRandomPassword.Size = new System.Drawing.Size(180, 23);
            this.button_GenerateRandomPassword.TabIndex = 28;
            this.button_GenerateRandomPassword.Text = "Generate random password";
            this.button_GenerateRandomPassword.UseVisualStyleBackColor = true;
            this.button_GenerateRandomPassword.Click += new System.EventHandler(this.button_GenerateRandomPassword_Click);
            // 
            // textbox_IgnoreExtensions
            // 
            this.textbox_IgnoreExtensions.Location = new System.Drawing.Point(578, 304);
            this.textbox_IgnoreExtensions.Name = "textbox_IgnoreExtensions";
            this.textbox_IgnoreExtensions.Size = new System.Drawing.Size(210, 20);
            this.textbox_IgnoreExtensions.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "File extensions to ignore (comma separated) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(726, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "txt,png,pem";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_IgnoreExtensions);
            this.Controls.Add(this.button_GenerateRandomPassword);
            this.Controls.Add(this.label_SliderPassword);
            this.Controls.Add(this.slider_PasswordLength);
            this.Controls.Add(this.checkbox_hidePassword);
            this.Controls.Add(this.label_GenerateRandomPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_importPassword);
            this.Controls.Add(this.checkbox_deleteFilesAfterDecryption);
            this.Controls.Add(this.checkbox_deleteFilesAfterEncryption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_chooseFolderDecrypt);
            this.Controls.Add(this.button_chooseFolderEncrypt);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.label_PathFileFolderDecrypt);
            this.Controls.Add(this.label_PathFileFolderEncrypt);
            this.Controls.Add(this.button_chooseFileDecrypt);
            this.Controls.Add(this.label_ChooseFileFolderDecrypt);
            this.Controls.Add(this.button_chooseFileEncrypt);
            this.Controls.Add(this.label_ChooseFileFolderEncrypt);
            this.Name = "form1";
            this.Text = "CryptApp";
            ((System.ComponentModel.ISupportInitialize)(this.slider_PasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ChooseFileFolderEncrypt;
        private System.Windows.Forms.Button button_chooseFileEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Encrypt;
        private System.Windows.Forms.Button button_chooseFileDecrypt;
        private System.Windows.Forms.Label label_ChooseFileFolderDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Decrypt;
        private System.Windows.Forms.Label label_PathFileFolderEncrypt;
        private System.Windows.Forms.Label label_PathFileFolderDecrypt;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Button button_chooseFolderEncrypt;
        private System.Windows.Forms.Button button_chooseFolderDecrypt;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_deleteFilesAfterEncryption;
        private System.Windows.Forms.CheckBox checkbox_deleteFilesAfterDecryption;
        private System.Windows.Forms.Label label_importPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_GenerateRandomPassword;
        private System.Windows.Forms.CheckBox checkbox_hidePassword;
        private System.Windows.Forms.TrackBar slider_PasswordLength;
        private System.Windows.Forms.Label label_SliderPassword;
        private System.Windows.Forms.Button button_GenerateRandomPassword;
        private System.Windows.Forms.TextBox textbox_IgnoreExtensions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

