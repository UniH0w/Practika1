
namespace WinAsynchMethod11
{
    partial class Form1
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
            this.IdIA = new System.Windows.Forms.Label();
            this.IdIB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdIA
            // 
            this.IdIA.AutoSize = true;
            this.IdIA.Location = new System.Drawing.Point(11, 30);
            this.IdIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdIA.Name = "IdIA";
            this.IdIA.Size = new System.Drawing.Size(84, 16);
            this.IdIA.TabIndex = 0;
            this.IdIA.Text = "Значение A";
            // 
            // IdIB
            // 
            this.IdIB.AutoSize = true;
            this.IdIB.Location = new System.Drawing.Point(288, 30);
            this.IdIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdIB.Name = "IdIB";
            this.IdIB.Size = new System.Drawing.Size(84, 16);
            this.IdIB.TabIndex = 1;
            this.IdIB.Text = "Значение B";
            // 
            // txtA
            // 
            this.helpProvider1.SetHelpString(this.txtA, "A");
            this.txtA.Location = new System.Drawing.Point(117, 30);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA.Name = "txtA";
            this.helpProvider1.SetShowHelp(this.txtA, true);
            this.txtA.Size = new System.Drawing.Size(132, 22);
            this.txtA.TabIndex = 2;
            // 
            // txbB
            // 
            this.helpProvider1.SetHelpString(this.txbB, "B");
            this.txbB.Location = new System.Drawing.Point(395, 30);
            this.txbB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, true);
            this.txbB.Size = new System.Drawing.Size(132, 22);
            this.txbB.TabIndex = 3;
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, "Summ");
            this.btnRun.Location = new System.Drawing.Point(21, 79);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, true);
            this.btnRun.Size = new System.Drawing.Size(100, 28);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Сумма";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(166, 118);
            this.btnWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(100, 28);
            this.btnWork.TabIndex = 5;
            this.btnWork.Text = "Работа";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Студент\\Desktop\\Репозиторий Матвеев\\WinAsynchMethod11\\WinAsynchMethod11\\" +
    "text.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.IdIB);
            this.Controls.Add(this.IdIA);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdIA;
        private System.Windows.Forms.Label IdIB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button1;
    }
}

