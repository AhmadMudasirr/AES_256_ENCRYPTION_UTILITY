using First_Application.DataEncryption;
using System;
using System.Windows.Forms;

namespace First_Application
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(encryptionKeyValue.Text))
            {

                MessageBox.Show("Please Enter Your Key To Proceed Further");
            }
            else if (IsBase64String(encryptionKeyValue.Text))
            {

                string key = encryptionKeyValue.Text.Trim();
                byte[] keybyte = Convert.FromBase64String(key);
                DataEncrypt.ProcessKey = keybyte;
                MessageBox.Show("Key Sumbitted Successfully. Please Proceed with Encryption OR Decryption");
                encryptionKeyValue.Clear();
            }
            else
            {

                MessageBox.Show("Enter Valid Base64 key");

            }

        }

        private void EncryptData_Click(object sender, EventArgs e)
        {
            if (DataEncrypt.ProcessKey == null || string.IsNullOrEmpty(MainJsonData.Text))
            {

                MessageBox.Show("Please Enter Valid Encryption Key and Json Data in Format!");
            }

            else
            {
                string encryptedJson = DataEncrypt.Encrypt(MainJsonData.Text);

                EncryptedJsonValue.Text = encryptedJson;

                MessageBox.Show("Data Encryption Done.");
            }

        }

        private void DecryptData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EncryptedJsonValue.Text))
            {
                MessageBox.Show("Please Enter value to Proceed !");

            }

            else
            {
                string decryptedJsonValue = DataEncrypt.Decrypt(Convert.FromBase64String(EncryptedJsonValue.Text));

                DecryptedJsonValue.Text = decryptedJsonValue;

                MessageBox.Show("Data Decryption Done.");

            }

        }

        private void CopyEncryptedValue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EncryptedJsonValue.Text))
            {

                MessageBox.Show("Uh Oh Unable to Copy Empty Value!");
            }
            else
            {
                Clipboard.SetText(EncryptedJsonValue.Text);

                MessageBox.Show("Data Copied Successfully!");
            }

        }


        private bool IsBase64String(string base64String)
        {
            try
            {
                byte[] data = Convert.FromBase64String(base64String);
                return (base64String.Replace(" ", "").Length % 4 == 0);
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}
