using First_Application.DataEncryption;
using Newtonsoft.Json;
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


        private void EncryptData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainJsonData.Text))
            {

                MessageBox.Show("Please Enter Value in Json Format !");
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


        private void DeserializeData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DecryptedJsonValue.Text))
            {

                MessageBox.Show("Please Complete the above steps to Proceed! ");

            }

            else
            {

                Template deserializesJson = JsonConvert.DeserializeObject<Template>(DecryptedJsonValue.Text);

                var tempObj = new
                {
                    Title = deserializesJson.Title,
                    Genre = deserializesJson.Genre,
                    Price = deserializesJson.Price,
                    Description = deserializesJson.Description,
                    AuthorId = deserializesJson.AuthorId
                };


                MessageBox.Show(Convert.ToString(tempObj));
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


    }



    public class Template
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
    }
}
