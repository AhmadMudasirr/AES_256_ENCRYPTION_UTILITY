
namespace First_Application
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptData = new System.Windows.Forms.Button();
            this.EncryptedJsonValue = new System.Windows.Forms.RichTextBox();
            this.EncryptedValue = new System.Windows.Forms.Label();
            this.DecryptData = new System.Windows.Forms.Button();
            this.DecryptedJsonValue = new System.Windows.Forms.RichTextBox();
            this.DecryptedValue = new System.Windows.Forms.Label();
            this.CopyEncryptedValue = new System.Windows.Forms.Button();
            this.MainJsonData = new System.Windows.Forms.TextBox();
            this.encryptionKeyValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Json Text";
            // 
            // EncryptData
            // 
            this.EncryptData.Location = new System.Drawing.Point(537, 301);
            this.EncryptData.Name = "EncryptData";
            this.EncryptData.Size = new System.Drawing.Size(107, 54);
            this.EncryptData.TabIndex = 5;
            this.EncryptData.Text = "Encrypt ";
            this.EncryptData.UseVisualStyleBackColor = true;
            this.EncryptData.Click += new System.EventHandler(this.EncryptData_Click);
            // 
            // EncryptedJsonValue
            // 
            this.EncryptedJsonValue.Location = new System.Drawing.Point(49, 493);
            this.EncryptedJsonValue.Name = "EncryptedJsonValue";
            this.EncryptedJsonValue.Size = new System.Drawing.Size(448, 125);
            this.EncryptedJsonValue.TabIndex = 6;
            this.EncryptedJsonValue.Text = "";
            // 
            // EncryptedValue
            // 
            this.EncryptedValue.AutoSize = true;
            this.EncryptedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedValue.Location = new System.Drawing.Point(51, 470);
            this.EncryptedValue.Name = "EncryptedValue";
            this.EncryptedValue.Size = new System.Drawing.Size(141, 20);
            this.EncryptedValue.TabIndex = 7;
            this.EncryptedValue.Text = "Encrypted Value";
            // 
            // DecryptData
            // 
            this.DecryptData.Location = new System.Drawing.Point(537, 576);
            this.DecryptData.Name = "DecryptData";
            this.DecryptData.Size = new System.Drawing.Size(107, 42);
            this.DecryptData.TabIndex = 8;
            this.DecryptData.Text = "Decrypt";
            this.DecryptData.UseVisualStyleBackColor = true;
            this.DecryptData.Click += new System.EventHandler(this.DecryptData_Click);
            // 
            // DecryptedJsonValue
            // 
            this.DecryptedJsonValue.Location = new System.Drawing.Point(49, 664);
            this.DecryptedJsonValue.Name = "DecryptedJsonValue";
            this.DecryptedJsonValue.Size = new System.Drawing.Size(595, 145);
            this.DecryptedJsonValue.TabIndex = 9;
            this.DecryptedJsonValue.Text = "";
            // 
            // DecryptedValue
            // 
            this.DecryptedValue.AutoSize = true;
            this.DecryptedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedValue.Location = new System.Drawing.Point(50, 641);
            this.DecryptedValue.Name = "DecryptedValue";
            this.DecryptedValue.Size = new System.Drawing.Size(142, 20);
            this.DecryptedValue.TabIndex = 10;
            this.DecryptedValue.Text = "Decrypted Value";
            // 
            // CopyEncryptedValue
            // 
            this.CopyEncryptedValue.Location = new System.Drawing.Point(537, 493);
            this.CopyEncryptedValue.Name = "CopyEncryptedValue";
            this.CopyEncryptedValue.Size = new System.Drawing.Size(107, 42);
            this.CopyEncryptedValue.TabIndex = 12;
            this.CopyEncryptedValue.Text = "Copy";
            this.CopyEncryptedValue.UseVisualStyleBackColor = true;
            this.CopyEncryptedValue.Click += new System.EventHandler(this.CopyEncryptedValue_Click);
            // 
            // MainJsonData
            // 
            this.MainJsonData.Location = new System.Drawing.Point(49, 210);
            this.MainJsonData.Multiline = true;
            this.MainJsonData.Name = "MainJsonData";
            this.MainJsonData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainJsonData.Size = new System.Drawing.Size(453, 240);
            this.MainJsonData.TabIndex = 17;
            this.MainJsonData.Text = "Enter Value in Json Format";
            // 
            // encryptionKeyValue
            // 
            this.encryptionKeyValue.Location = new System.Drawing.Point(49, 124);
            this.encryptionKeyValue.Name = "encryptionKeyValue";
            this.encryptionKeyValue.Size = new System.Drawing.Size(453, 26);
            this.encryptionKeyValue.TabIndex = 0;
            this.encryptionKeyValue.Text = "Enter Valid base64_Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Your Encryption Key";
            // 
            // SubmitKey
            // 
            this.SubmitKey.Location = new System.Drawing.Point(537, 118);
            this.SubmitKey.Name = "SubmitKey";
            this.SubmitKey.Size = new System.Drawing.Size(107, 32);
            this.SubmitKey.TabIndex = 15;
            this.SubmitKey.Text = "Submit";
            this.SubmitKey.UseVisualStyleBackColor = true;
            this.SubmitKey.Click += new System.EventHandler(this.SubmitKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "AES 256 ENCRYPTION UTILITY (SYMETRIC)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 843);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubmitKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptionKeyValue);
            this.Controls.Add(this.MainJsonData);
            this.Controls.Add(this.CopyEncryptedValue);
            this.Controls.Add(this.DecryptedValue);
            this.Controls.Add(this.DecryptedJsonValue);
            this.Controls.Add(this.DecryptData);
            this.Controls.Add(this.EncryptedValue);
            this.Controls.Add(this.EncryptedJsonValue);
            this.Controls.Add(this.EncryptData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptData;
        private System.Windows.Forms.RichTextBox EncryptedJsonValue;
        private System.Windows.Forms.Label EncryptedValue;
        private System.Windows.Forms.Button DecryptData;
        private System.Windows.Forms.RichTextBox DecryptedJsonValue;
        private System.Windows.Forms.Label DecryptedValue;
        private System.Windows.Forms.Button CopyEncryptedValue;
        private System.Windows.Forms.TextBox MainJsonData;
        private System.Windows.Forms.TextBox encryptionKeyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitKey;
        private System.Windows.Forms.Label label3;
    }
}

