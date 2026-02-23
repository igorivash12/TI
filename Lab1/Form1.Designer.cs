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
            this.lblCipherText = new System.Windows.Forms.Label();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.cmbTypesOfCipher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblKey2 = new System.Windows.Forms.Label();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.cbAdvanced = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 42);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(499, 456);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(170, 42);
            this.btnDecipher.TabIndex = 3;
            this.btnDecipher.Text = "Дешифровать";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(281, 456);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(170, 42);
            this.btnCipher.TabIndex = 2;
            this.btnCipher.Text = "Шифровать";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(38, 394);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(170, 22);
            this.tbKey.TabIndex = 1;
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(38, 112);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlainText.Size = new System.Drawing.Size(490, 213);
            this.tbPlainText.TabIndex = 0;
            // 
            // tbCipherText
            // 
            this.tbCipherText.Location = new System.Drawing.Point(704, 112);
            this.tbCipherText.Multiline = true;
            this.tbCipherText.Name = "tbCipherText";
            this.tbCipherText.ReadOnly = true;
            this.tbCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCipherText.Size = new System.Drawing.Size(490, 213);
            this.tbCipherText.TabIndex = 5;
            // 
            // lblCipherText
            // 
            this.lblCipherText.AutoSize = true;
            this.lblCipherText.Location = new System.Drawing.Point(701, 70);
            this.lblCipherText.Name = "lblCipherText";
            this.lblCipherText.Size = new System.Drawing.Size(156, 16);
            this.lblCipherText.TabIndex = 6;
            this.lblCipherText.Text = "Зашифрованный текст";
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Location = new System.Drawing.Point(35, 70);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(110, 16);
            this.lblPlainText.TabIndex = 7;
            this.lblPlainText.Text = "Исходный текст";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(35, 375);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 16);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "Ключ";
            // 
            // cmbTypesOfCipher
            // 
            this.cmbTypesOfCipher.FormattingEnabled = true;
            this.cmbTypesOfCipher.Items.AddRange(new object[] {
            "Шифр Виженера (Рус.)",
            "Столбцовый метод (Англ.)"});
            this.cmbTypesOfCipher.Location = new System.Drawing.Point(706, 394);
            this.cmbTypesOfCipher.Name = "cmbTypesOfCipher";
            this.cmbTypesOfCipher.Size = new System.Drawing.Size(253, 24);
            this.cmbTypesOfCipher.TabIndex = 9;
            this.cmbTypesOfCipher.SelectedIndexChanged += new System.EventHandler(this.cmbTypesOfCipher_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип шифрования";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(832, 456);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(170, 42);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(1033, 456);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(170, 42);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblKey2
            // 
            this.lblKey2.AutoSize = true;
            this.lblKey2.Location = new System.Drawing.Point(278, 375);
            this.lblKey2.Name = "lblKey2";
            this.lblKey2.Size = new System.Drawing.Size(51, 16);
            this.lblKey2.TabIndex = 14;
            this.lblKey2.Text = "Ключ 2";
            this.lblKey2.Visible = false;
            // 
            // tbKey2
            // 
            this.tbKey2.Location = new System.Drawing.Point(281, 394);
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(170, 22);
            this.tbKey2.TabIndex = 5;
            this.tbKey2.Visible = false;
            // 
            // cbAdvanced
            // 
            this.cbAdvanced.AutoSize = true;
            this.cbAdvanced.Location = new System.Drawing.Point(999, 398);
            this.cbAdvanced.Name = "cbAdvanced";
            this.cbAdvanced.Size = new System.Drawing.Size(112, 20);
            this.cbAdvanced.TabIndex = 15;
            this.cbAdvanced.Text = "Улучшенный";
            this.cbAdvanced.UseVisualStyleBackColor = true;
            this.cbAdvanced.Visible = false;
            this.cbAdvanced.CheckStateChanged += new System.EventHandler(this.cbAdvanced_CheckStateChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(574, 213);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "<-->";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 545);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cbAdvanced);
            this.Controls.Add(this.lblKey2);
            this.Controls.Add(this.tbKey2);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTypesOfCipher);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.lblCipherText);
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
        private System.Windows.Forms.Label lblCipherText;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cmbTypesOfCipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label lblKey2;
        private System.Windows.Forms.TextBox tbKey2;
        private System.Windows.Forms.CheckBox cbAdvanced;
        private System.Windows.Forms.Button btnChange;
    }
}

