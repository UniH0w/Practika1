﻿
namespace WinAsynchMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdIB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Значение А";
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
            this.helpProvider1.SetHelpKeyword(this.txtA, "For input integer B");
            this.helpProvider1.SetHelpString(this.txtA, "For input integer A");
            this.txtA.Location = new System.Drawing.Point(117, 30);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA.Name = "txtA";
            this.helpProvider1.SetShowHelp(this.txtA, true);
            this.txtA.Size = new System.Drawing.Size(132, 22);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "  ";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txbB
            // 
            this.helpProvider1.SetHelpKeyword(this.txbB, "For input integer B");
            this.helpProvider1.SetHelpString(this.txbB, "For input integer B");
            this.txbB.Location = new System.Drawing.Point(395, 30);
            this.txbB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, true);
            this.txbB.Size = new System.Drawing.Size(132, 22);
            this.txbB.TabIndex = 3;
            // 
            // btnWork
            // 
            this.helpProvider1.SetHelpString(this.btnWork, "Start Work");
            this.btnWork.Location = new System.Drawing.Point(228, 147);
            this.btnWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWork.Name = "btnWork";
            this.helpProvider1.SetShowHelp(this.btnWork, true);
            this.btnWork.Size = new System.Drawing.Size(100, 28);
            this.btnWork.TabIndex = 4;
            this.btnWork.Text = "Работа";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, "Summ");
            this.btnRun.Location = new System.Drawing.Point(21, 79);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, true);
            this.btnRun.Size = new System.Drawing.Size(100, 28);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Сумма";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 198);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.IdIB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdIB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

