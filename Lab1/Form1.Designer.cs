namespace Lab1
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.btnCipher = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.tbCipherText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTypesOfCipher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(619, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(351, 385);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(170, 42);
            this.btnDecipher.TabIndex = 1;
            this.btnDecipher.Text = "Дешифровать";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(83, 385);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(170, 42);
            this.btnCipher.TabIndex = 2;
            this.btnCipher.Text = "Шифровать";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(83, 323);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(170, 22);
            this.tbKey.TabIndex = 3;
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(83, 112);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(267, 142);
            this.tbPlainText.TabIndex = 4;
            // 
            // tbCipherText
            // 
            this.tbCipherText.Location = new System.Drawing.Point(522, 112);
            this.tbCipherText.Multiline = true;
            this.tbCipherText.Name = "tbCipherText";
            this.tbCipherText.Size = new System.Drawing.Size(267, 142);
            this.tbCipherText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Зашифрованный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исходный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ключ";
            // 
            // cmbTypesOfCipher
            // 
            this.cmbTypesOfCipher.FormattingEnabled = true;
            this.cmbTypesOfCipher.Items.AddRange(new object[] {
            "Шифр Виженера (Рус.)",
            "Столбцовый метод (Англ.)"});
            this.cmbTypesOfCipher.Location = new System.Drawing.Point(536, 321);
            this.cmbTypesOfCipher.Name = "cmbTypesOfCipher";
            this.cmbTypesOfCipher.Size = new System.Drawing.Size(253, 24);
            this.cmbTypesOfCipher.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип шифрования";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTypesOfCipher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCipherText);
            this.Controls.Add(this.tbPlainText);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.btnDecipher);
            this.Controls.Add(this.btnClear);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecipher;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbPlainText;
        private System.Windows.Forms.TextBox tbCipherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTypesOfCipher;
        private System.Windows.Forms.Label label4;
    }
}

