
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
            this.DeserializeData = new System.Windows.Forms.Button();
            this.CopyEncryptedValue = new System.Windows.Forms.Button();
            this.MainJsonData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Json Text";
            // 
            // EncryptData
            // 
            this.EncryptData.Location = new System.Drawing.Point(537, 107);
            this.EncryptData.Name = "EncryptData";
            this.EncryptData.Size = new System.Drawing.Size(173, 93);
            this.EncryptData.TabIndex = 5;
            this.EncryptData.Text = "Encrypt";
            this.EncryptData.UseVisualStyleBackColor = true;
            this.EncryptData.Click += new System.EventHandler(this.EncryptData_Click);
            // 
            // EncryptedJsonValue
            // 
            this.EncryptedJsonValue.Location = new System.Drawing.Point(42, 355);
            this.EncryptedJsonValue.Name = "EncryptedJsonValue";
            this.EncryptedJsonValue.Size = new System.Drawing.Size(448, 116);
            this.EncryptedJsonValue.TabIndex = 6;
            this.EncryptedJsonValue.Text = "";
            // 
            // EncryptedValue
            // 
            this.EncryptedValue.AutoSize = true;
            this.EncryptedValue.Location = new System.Drawing.Point(39, 321);
            this.EncryptedValue.Name = "EncryptedValue";
            this.EncryptedValue.Size = new System.Drawing.Size(126, 20);
            this.EncryptedValue.TabIndex = 7;
            this.EncryptedValue.Text = "Encrypted Value";
            // 
            // DecryptData
            // 
            this.DecryptData.Location = new System.Drawing.Point(694, 401);
            this.DecryptData.Name = "DecryptData";
            this.DecryptData.Size = new System.Drawing.Size(173, 42);
            this.DecryptData.TabIndex = 8;
            this.DecryptData.Text = "Decrypt";
            this.DecryptData.UseVisualStyleBackColor = true;
            this.DecryptData.Click += new System.EventHandler(this.DecryptData_Click);
            // 
            // DecryptedJsonValue
            // 
            this.DecryptedJsonValue.Location = new System.Drawing.Point(39, 524);
            this.DecryptedJsonValue.Name = "DecryptedJsonValue";
            this.DecryptedJsonValue.Size = new System.Drawing.Size(448, 111);
            this.DecryptedJsonValue.TabIndex = 9;
            this.DecryptedJsonValue.Text = "";
            // 
            // DecryptedValue
            // 
            this.DecryptedValue.AutoSize = true;
            this.DecryptedValue.Location = new System.Drawing.Point(35, 489);
            this.DecryptedValue.Name = "DecryptedValue";
            this.DecryptedValue.Size = new System.Drawing.Size(127, 20);
            this.DecryptedValue.TabIndex = 10;
            this.DecryptedValue.Text = "Decrypted Value";
            // 
            // DeserializeData
            // 
            this.DeserializeData.Location = new System.Drawing.Point(537, 551);
            this.DeserializeData.Name = "DeserializeData";
            this.DeserializeData.Size = new System.Drawing.Size(173, 59);
            this.DeserializeData.TabIndex = 11;
            this.DeserializeData.Text = "Deserialize Json";
            this.DeserializeData.UseVisualStyleBackColor = true;
            this.DeserializeData.Click += new System.EventHandler(this.DeserializeData_Click);
            // 
            // CopyEncryptedValue
            // 
            this.CopyEncryptedValue.Location = new System.Drawing.Point(537, 401);
            this.CopyEncryptedValue.Name = "CopyEncryptedValue";
            this.CopyEncryptedValue.Size = new System.Drawing.Size(107, 42);
            this.CopyEncryptedValue.TabIndex = 12;
            this.CopyEncryptedValue.Text = "Copy";
            this.CopyEncryptedValue.UseVisualStyleBackColor = true;
            this.CopyEncryptedValue.Click += new System.EventHandler(this.CopyEncryptedValue_Click);
            // 
            // MainJsonData
            // 
            this.MainJsonData.Location = new System.Drawing.Point(42, 46);
            this.MainJsonData.Multiline = true;
            this.MainJsonData.Name = "MainJsonData";
            this.MainJsonData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainJsonData.Size = new System.Drawing.Size(453, 240);
            this.MainJsonData.TabIndex = 0;
            this.MainJsonData.Text = "Enter Value in Json Format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 671);
            this.Controls.Add(this.MainJsonData);
            this.Controls.Add(this.CopyEncryptedValue);
            this.Controls.Add(this.DeserializeData);
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
        private System.Windows.Forms.Button DeserializeData;
        private System.Windows.Forms.Button CopyEncryptedValue;
        private System.Windows.Forms.TextBox MainJsonData;
    }
}

