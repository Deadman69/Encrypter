using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChiffrement
{
    public partial class form1 : Form
    {
        private string folderPathEncrypt = "";
        private string folderPathDecrypt = "";

        public form1()
        {
            InitializeComponent();
            button_Encrypt.Hide();
            button_Decrypt.Hide();
            label_SliderPassword.Hide();
            slider_PasswordLength.Hide();
            button_GenerateRandomPassword.Hide();
        }

        // Encrypt
        private void button_chooseFileFolderEncrypt_Click(object sender, EventArgs e)
        {
            openFileDialog_Encrypt.ShowDialog();
        }

        private void openFileDialog_Encrypt_FileOk(object sender, CancelEventArgs e)
        {
            label_PathFileFolderEncrypt.Text = openFileDialog_Encrypt.FileName;
            button_Encrypt.Show();
        }

        private void button_chooseFolderEncrypt_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.folderPathEncrypt = fbd.SelectedPath;
                    label_PathFileFolderEncrypt.Text = this.folderPathEncrypt;
                    button_Encrypt.Show();
                }
            }
        }
        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            if (checkIfPasswordIsProvided())
            {
                if (this.folderPathEncrypt != "")
                {
                    string[] files = MiscCustom.getAllFilesFromFolder(this.folderPathEncrypt, textbox_IgnoreExtensions.Text);
                    foreach (string file in files)
                    {
                        // Removing ".encrypted" from file name
                        SecurityCustom.EncryptFile(file, file + ".encrypted", textbox_password.Text, SecurityCustom.salt, SecurityCustom.iterations);
                        if (checkbox_deleteFilesAfterEncryption.Checked == true)
                        {
                            File.Delete(file);
                        }
                    }
                }
                else
                {
                    SecurityCustom.EncryptFile(openFileDialog_Encrypt.FileName, openFileDialog_Encrypt.FileName + ".encrypted", textbox_password.Text, SecurityCustom.salt, SecurityCustom.iterations);
                    if (checkbox_deleteFilesAfterEncryption.Checked == true)
                    {
                        File.Delete(openFileDialog_Encrypt.FileName);
                    }
                }
                MessageBox.Show("Encryption complete !", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Please enter the password for encryption !", "Enter a password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Decrypt
        private void openFileDialog_Decrypt_FileOk(object sender, CancelEventArgs e)
        {
            label_PathFileFolderDecrypt.Text = openFileDialog_Decrypt.FileName;
            button_Decrypt.Show();
        }

        private void button_chooseFileFolderDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialog_Decrypt.ShowDialog();
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            if(checkIfPasswordIsProvided())
            {
                if (this.folderPathDecrypt != "")
                {
                    string[] files = MiscCustom.getAllFilesFromFolder(this.folderPathEncrypt, textbox_IgnoreExtensions.Text);
                    foreach (string file in files)
                    {
                        string newFileName = file.Replace(".encrypted", "");
                        SecurityCustom.DecryptFile(file, newFileName, textbox_password.Text, SecurityCustom.salt, SecurityCustom.iterations);
                        if(checkbox_deleteFilesAfterDecryption.Checked == true)
                        {
                            File.Delete(file);
                        }
                    }
                }
                else
                {
                    string newFileName = openFileDialog_Decrypt.FileName.Replace(".encrypted", "");
                    SecurityCustom.DecryptFile(openFileDialog_Decrypt.FileName, newFileName, textbox_password.Text, SecurityCustom.salt, SecurityCustom.iterations);
                    if (checkbox_deleteFilesAfterEncryption.Checked == true)
                    {
                        File.Delete(openFileDialog_Decrypt.FileName);
                    }
                }
                MessageBox.Show("Decryption complete !", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Please enter the password for decryption !", "Enter a password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_chooseFolderDecrypt_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.folderPathDecrypt = fbd.SelectedPath;
                    label_PathFileFolderDecrypt.Text = this.folderPathDecrypt;
                    button_Decrypt.Show();
                }
            }
        }

        // Password
        private void label_importPassword_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    string passwordInFile = File.ReadAllText(ofd.FileName);
                    textbox_password.Text = passwordInFile;
                }
            }
        }

        private void label_GenerateRandomPassword_Click(object sender, EventArgs e)
        {
            label_SliderPassword.Show();
            slider_PasswordLength.Show();
            button_GenerateRandomPassword.Show();
        }

        private void button_GenerateRandomPassword_Click(object sender, EventArgs e)
        {
            string randomPassword = SecurityCustom.GetRandomAlphanumericString(slider_PasswordLength.Value);
            Clipboard.SetText(randomPassword);
            textbox_password.Text = randomPassword;
            MessageBox.Show("The random password is in your clipboard !\rDon't hesitate to regenerate a password before encryption if you loose it.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void slider_PasswordLength_ValueChanged(object sender, EventArgs e)
        {
            label_SliderPassword.Text = "Choose password length : " + slider_PasswordLength.Value;
        }

        // Checkbox options

        private void checkbox_hidePassword_CheckedChanged(object sender, EventArgs e)
        {
            textbox_password.UseSystemPasswordChar = checkbox_hidePassword.Checked;
        }

        // Real functions
        private bool checkIfPasswordIsProvided()
        {
            if(textbox_password.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}