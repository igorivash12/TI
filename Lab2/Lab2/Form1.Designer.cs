namespace Lab2
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
            this.tbInitFile = new System.Windows.Forms.RichTextBox();
            this.tbCypherText = new System.Windows.Forms.RichTextBox();
            this.tbGenKey = new System.Windows.Forms.RichTextBox();
            this.tbInitKey = new System.Windows.Forms.RichTextBox();

            this.lblName = new System.Windows.Forms.Label();
            this.lblInitFile = new System.Windows.Forms.Label();
            this.lblGenKey = new System.Windows.Forms.Label();
            this.lblCypherFile = new System.Windows.Forms.Label();
            this.lblInitKey = new System.Windows.Forms.Label();

            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnCypher = new System.Windows.Forms.Button();
            this.btnEncypher = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowAllBytes = new System.Windows.Forms.Button();

            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.SuspendLayout();

            // === Заголовок ===
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 15);
            this.lblName.Text = "Потоковое шифрование";

            // === Ключ ===
            this.lblInitKey.AutoSize = true;
            this.lblInitKey.Location = new System.Drawing.Point(20, 60);
            this.lblInitKey.Text = "Ключ (29 бит):";

            this.tbInitKey.Location = new System.Drawing.Point(150, 55);
            this.tbInitKey.Size = new System.Drawing.Size(200, 30);
            this.tbInitKey.MaxLength = 29;

            // === Кнопки сверху ===
            this.btnLoadFile.Location = new System.Drawing.Point(370, 50);
            this.btnLoadFile.Size = new System.Drawing.Size(120, 30);
            this.btnLoadFile.Text = "Загрузить";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);

            this.btnCypher.Location = new System.Drawing.Point(500, 50);
            this.btnCypher.Size = new System.Drawing.Size(100, 30);
            this.btnCypher.Text = "Шифровать";
            this.btnCypher.Click += new System.EventHandler(this.btnCypher_Click);

            this.btnEncypher.Location = new System.Drawing.Point(610, 50);
            this.btnEncypher.Size = new System.Drawing.Size(110, 30);
            this.btnEncypher.Text = "Дешифровать";
            this.btnEncypher.Click += new System.EventHandler(this.btnEncypher_Click);

            this.btnSaveToFile.Location = new System.Drawing.Point(730, 50);
            this.btnSaveToFile.Size = new System.Drawing.Size(130, 30);
            this.btnSaveToFile.Text = "Сохранить";
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);

            // === Доп кнопки ===
            this.btnShowAllBytes.Location = new System.Drawing.Point(20, 90);
            this.btnShowAllBytes.Size = new System.Drawing.Size(180, 30);
            this.btnShowAllBytes.Text = "Показать все биты";
            this.btnShowAllBytes.Click += new System.EventHandler(this.btnShowAllBytes_Click);

            this.btnClear.Location = new System.Drawing.Point(210, 90);
            this.btnClear.Size = new System.Drawing.Size(140, 30);
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // === Исходный файл ===
            this.lblInitFile.AutoSize = true;
            this.lblInitFile.Location = new System.Drawing.Point(20, 130);
            this.lblInitFile.Text = "Исходный файл:";

            this.tbInitFile.Location = new System.Drawing.Point(20, 150);
            this.tbInitFile.Size = new System.Drawing.Size(840, 120);
            this.tbInitFile.ReadOnly = true;

            // === Ключ ===
            this.lblGenKey.AutoSize = true;
            this.lblGenKey.Location = new System.Drawing.Point(20, 280);
            this.lblGenKey.Text = "Сгенерированный ключ:";

            this.tbGenKey.Location = new System.Drawing.Point(20, 300);
            this.tbGenKey.Size = new System.Drawing.Size(840, 80);
            this.tbGenKey.ReadOnly = true;

            // === Результат ===
            this.lblCypherFile.AutoSize = true;
            this.lblCypherFile.Location = new System.Drawing.Point(20, 390);
            this.lblCypherFile.Text = "Результат:";

            this.tbCypherText.Location = new System.Drawing.Point(20, 410);
            this.tbCypherText.Size = new System.Drawing.Size(840, 150);
            this.tbCypherText.ReadOnly = true;

            // === Форма ===
            this.BackColor = System.Drawing.SystemColors.Control; // стандартный серый
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Text = "StreamCipher";

            // === Добавление элементов ===
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInitKey);
            this.Controls.Add(this.tbInitKey);

            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnCypher);
            this.Controls.Add(this.btnEncypher);
            this.Controls.Add(this.btnSaveToFile);

            this.Controls.Add(this.btnShowAllBytes);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.lblInitFile);
            this.Controls.Add(this.tbInitFile);

            this.Controls.Add(this.lblGenKey);
            this.Controls.Add(this.tbGenKey);

            this.Controls.Add(this.lblCypherFile);
            this.Controls.Add(this.tbCypherText);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInitFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox tbCypherText;
        private System.Windows.Forms.RichTextBox tbGenKey;
        private System.Windows.Forms.Label lblInitFile;
        private System.Windows.Forms.Label lblGenKey;
        private System.Windows.Forms.Label lblCypherFile;
        private System.Windows.Forms.RichTextBox tbInitKey;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEncypher;
        private System.Windows.Forms.Button btnCypher;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label lblInitKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowAllBytes;
    }
}
