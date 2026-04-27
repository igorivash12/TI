namespace Lab3
{
    partial class frmMain
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
            this.pSide = new System.Windows.Forms.Panel();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.btnOpenEncryptedFile = new System.Windows.Forms.Button();
            this.lEilerValue = new System.Windows.Forms.Label();
            this.lEilerTitle = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenSourceFile = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.lYValue = new System.Windows.Forms.Label();
            this.lYTitle = new System.Windows.Forms.Label();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.lXTitle = new System.Windows.Forms.Label();
            this.tbKC = new System.Windows.Forms.TextBox();
            this.lGTitle = new System.Windows.Forms.Label();
            this.btnAcceptP = new System.Windows.Forms.Button();
            this.lPTitle = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbOpenedFile = new System.Windows.Forms.TextBox();
            this.lOpenedFile = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSide
            // 
            this.pSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSide.Controls.Add(this.tbQ);
            this.pSide.Controls.Add(this.btnOpenEncryptedFile);
            this.pSide.Controls.Add(this.lEilerValue);
            this.pSide.Controls.Add(this.lEilerTitle);
            this.pSide.Controls.Add(this.btnSaveFile);
            this.pSide.Controls.Add(this.btnOpenSourceFile);
            this.pSide.Controls.Add(this.btnDecryption);
            this.pSide.Controls.Add(this.lYValue);
            this.pSide.Controls.Add(this.lYTitle);
            this.pSide.Controls.Add(this.btnEncryption);
            this.pSide.Controls.Add(this.lXTitle);
            this.pSide.Controls.Add(this.tbKC);
            this.pSide.Controls.Add(this.lGTitle);
            this.pSide.Controls.Add(this.btnAcceptP);
            this.pSide.Controls.Add(this.lPTitle);
            this.pSide.Controls.Add(this.tbP);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSide.Location = new System.Drawing.Point(0, 0);
            this.pSide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(1185, 326);
            this.pSide.TabIndex = 0;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(299, 43);
            this.tbQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(263, 34);
            this.tbQ.TabIndex = 1;
            // 
            // btnOpenEncryptedFile
            // 
            this.btnOpenEncryptedFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenEncryptedFile.Location = new System.Drawing.Point(408, 171);
            this.btnOpenEncryptedFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenEncryptedFile.Name = "btnOpenEncryptedFile";
            this.btnOpenEncryptedFile.Size = new System.Drawing.Size(333, 41);
            this.btnOpenEncryptedFile.TabIndex = 6;
            this.btnOpenEncryptedFile.Text = "Открыть зашифрованный файл";
            this.btnOpenEncryptedFile.UseVisualStyleBackColor = true;
            this.btnOpenEncryptedFile.Click += new System.EventHandler(this.btnOpenEncryptedFile_Click);
            // 
            // lEilerValue
            // 
            this.lEilerValue.AutoSize = true;
            this.lEilerValue.Location = new System.Drawing.Point(563, 101);
            this.lEilerValue.Name = "lEilerValue";
            this.lEilerValue.Size = new System.Drawing.Size(28, 28);
            this.lEilerValue.TabIndex = 16;
            this.lEilerValue.Text = "\"\"";
            // 
            // lEilerTitle
            // 
            this.lEilerTitle.AutoSize = true;
            this.lEilerTitle.Location = new System.Drawing.Point(294, 101);
            this.lEilerTitle.Name = "lEilerTitle";
            this.lEilerTitle.Size = new System.Drawing.Size(263, 28);
            this.lEilerTitle.TabIndex = 15;
            this.lEilerTitle.Text = "Значение функции Эйлера:";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.Location = new System.Drawing.Point(863, 171);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(258, 41);
            this.btnSaveFile.TabIndex = 7;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenSourceFile
            // 
            this.btnOpenSourceFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSourceFile.Location = new System.Drawing.Point(11, 171);
            this.btnOpenSourceFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenSourceFile.Name = "btnOpenSourceFile";
            this.btnOpenSourceFile.Size = new System.Drawing.Size(263, 41);
            this.btnOpenSourceFile.TabIndex = 5;
            this.btnOpenSourceFile.Text = "Открыть исходный файл";
            this.btnOpenSourceFile.UseVisualStyleBackColor = true;
            this.btnOpenSourceFile.Click += new System.EventHandler(this.btnOpenSourceFile_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryption.Enabled = false;
            this.btnDecryption.Location = new System.Drawing.Point(597, 257);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(202, 41);
            this.btnDecryption.TabIndex = 12;
            this.btnDecryption.Text = "Дешифровать";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // lYValue
            // 
            this.lYValue.AutoSize = true;
            this.lYValue.Location = new System.Drawing.Point(146, 101);
            this.lYValue.Name = "lYValue";
            this.lYValue.Size = new System.Drawing.Size(28, 28);
            this.lYValue.TabIndex = 11;
            this.lYValue.Text = "\"\"";
            // 
            // lYTitle
            // 
            this.lYTitle.AutoSize = true;
            this.lYTitle.Location = new System.Drawing.Point(6, 101);
            this.lYTitle.Name = "lYTitle";
            this.lYTitle.Size = new System.Drawing.Size(135, 28);
            this.lYTitle.TabIndex = 10;
            this.lYTitle.Text = "Значение KC:";
            // 
            // btnEncryption
            // 
            this.btnEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryption.Enabled = false;
            this.btnEncryption.Location = new System.Drawing.Point(302, 257);
            this.btnEncryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(202, 41);
            this.btnEncryption.TabIndex = 9;
            this.btnEncryption.Text = "Зашифровать";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // lXTitle
            // 
            this.lXTitle.AutoSize = true;
            this.lXTitle.Location = new System.Drawing.Point(597, 14);
            this.lXTitle.Name = "lXTitle";
            this.lXTitle.Size = new System.Drawing.Size(237, 28);
            this.lXTitle.TabIndex = 5;
            this.lXTitle.Text = "Укажите компоненту KO:";
            // 
            // tbKC
            // 
            this.tbKC.Location = new System.Drawing.Point(597, 44);
            this.tbKC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKC.Name = "tbKC";
            this.tbKC.Size = new System.Drawing.Size(263, 34);
            this.tbKC.TabIndex = 4;
            // 
            // lGTitle
            // 
            this.lGTitle.AutoSize = true;
            this.lGTitle.Location = new System.Drawing.Point(297, 15);
            this.lGTitle.Name = "lGTitle";
            this.lGTitle.Size = new System.Drawing.Size(242, 28);
            this.lGTitle.TabIndex = 2;
            this.lGTitle.Text = "Выберите компоненту Q:";
            // 
            // btnAcceptP
            // 
            this.btnAcceptP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptP.Location = new System.Drawing.Point(919, 41);
            this.btnAcceptP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcceptP.Name = "btnAcceptP";
            this.btnAcceptP.Size = new System.Drawing.Size(202, 41);
            this.btnAcceptP.TabIndex = 4;
            this.btnAcceptP.Text = "Подтвердить";
            this.btnAcceptP.UseVisualStyleBackColor = true;
            this.btnAcceptP.Click += new System.EventHandler(this.btnAcceptP_Click);
            // 
            // lPTitle
            // 
            this.lPTitle.AutoSize = true;
            this.lPTitle.Location = new System.Drawing.Point(11, 15);
            this.lPTitle.Name = "lPTitle";
            this.lPTitle.Size = new System.Drawing.Size(146, 28);
            this.lPTitle.TabIndex = 1;
            this.lPTitle.Text = "Компонента P:";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(11, 43);
            this.tbP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(263, 34);
            this.tbP.TabIndex = 0;
            // 
            // tbOpenedFile
            // 
            this.tbOpenedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOpenedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpenedFile.Location = new System.Drawing.Point(16, 361);
            this.tbOpenedFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOpenedFile.Multiline = true;
            this.tbOpenedFile.Name = "tbOpenedFile";
            this.tbOpenedFile.ReadOnly = true;
            this.tbOpenedFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpenedFile.Size = new System.Drawing.Size(542, 306);
            this.tbOpenedFile.TabIndex = 1;
            // 
            // lOpenedFile
            // 
            this.lOpenedFile.AutoSize = true;
            this.lOpenedFile.BackColor = System.Drawing.Color.White;
            this.lOpenedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOpenedFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lOpenedFile.Location = new System.Drawing.Point(16, 331);
            this.lOpenedFile.Name = "lOpenedFile";
            this.lOpenedFile.Size = new System.Drawing.Size(321, 28);
            this.lOpenedFile.TabIndex = 16;
            this.lOpenedFile.Text = "Содержимое открытого файла:";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(603, 361);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(552, 306);
            this.tbResult.TabIndex = 17;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.BackColor = System.Drawing.Color.White;
            this.lResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lResult.Location = new System.Drawing.Point(672, 329);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(390, 28);
            this.lResult.TabIndex = 18;
            this.lResult.Text = "Содержимое зашифрованного файла:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 682);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lOpenedFile);
            this.Controls.Add(this.tbOpenedFile);
            this.Controls.Add(this.pSide);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование с открытым кючом";
            this.pSide.ResumeLayout(false);
            this.pSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Button btnAcceptP;
        private System.Windows.Forms.Label lPTitle;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label lXTitle;
        private System.Windows.Forms.TextBox tbKC;
        private System.Windows.Forms.Label lGTitle;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Label lYTitle;
        private System.Windows.Forms.Label lYValue;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenSourceFile;
        private System.Windows.Forms.Label lEilerValue;
        private System.Windows.Forms.Label lEilerTitle;
        private System.Windows.Forms.TextBox tbOpenedFile;
        private System.Windows.Forms.Label lOpenedFile;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpenEncryptedFile;
        private System.Windows.Forms.TextBox tbQ;
    }
}


