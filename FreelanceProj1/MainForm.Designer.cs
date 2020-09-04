namespace FreelanceProj1
{
    partial class MainForm
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
            this.StartParse = new System.Windows.Forms.Button();
            this.CrtFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.urlTargetInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadFileXlsx = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StartParse
            // 
            this.StartParse.Location = new System.Drawing.Point(199, 282);
            this.StartParse.Name = "StartParse";
            this.StartParse.Size = new System.Drawing.Size(75, 23);
            this.StartParse.TabIndex = 0;
            this.StartParse.Text = "Start parse";
            this.StartParse.UseVisualStyleBackColor = true;
            this.StartParse.Click += new System.EventHandler(this.StartParse_Click);
            // 
            // CrtFile
            // 
            this.CrtFile.Location = new System.Drawing.Point(23, 282);
            this.CrtFile.Name = "CrtFile";
            this.CrtFile.Size = new System.Drawing.Size(89, 23);
            this.CrtFile.TabIndex = 1;
            this.CrtFile.Text = "Create file xlx";
            this.CrtFile.UseVisualStyleBackColor = true;
            this.CrtFile.Click += new System.EventHandler(this.CrtFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 264);
            this.listBox1.TabIndex = 3;
            // 
            // urlTargetInp
            // 
            this.urlTargetInp.Location = new System.Drawing.Point(371, 27);
            this.urlTargetInp.Name = "urlTargetInp";
            this.urlTargetInp.Size = new System.Drawing.Size(184, 20);
            this.urlTargetInp.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Адрес сайта";
            // 
            // LoadFileXlsx
            // 
            this.LoadFileXlsx.Location = new System.Drawing.Point(118, 282);
            this.LoadFileXlsx.Name = "LoadFileXlsx";
            this.LoadFileXlsx.Size = new System.Drawing.Size(75, 23);
            this.LoadFileXlsx.TabIndex = 6;
            this.LoadFileXlsx.Text = "Load file";
            this.LoadFileXlsx.UseVisualStyleBackColor = true;
            this.LoadFileXlsx.Click += new System.EventHandler(this.LoadFileXlsx_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(371, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 348);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 413);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LoadFileXlsx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTargetInp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CrtFile);
            this.Controls.Add(this.StartParse);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartParse;
        private System.Windows.Forms.Button CrtFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox urlTargetInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadFileXlsx;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

