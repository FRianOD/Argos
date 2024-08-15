namespace Projeto_Teste1
{
    partial class DescriçãoDosLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescriçãoDosLogs));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.NomeDoLog = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DadosDoLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomeDoLog
            // 
            this.NomeDoLog.AutoSize = true;
            this.NomeDoLog.Location = new System.Drawing.Point(13, 13);
            this.NomeDoLog.Name = "NomeDoLog";
            this.NomeDoLog.Size = new System.Drawing.Size(67, 13);
            this.NomeDoLog.TabIndex = 0;
            this.NomeDoLog.Text = "NomeDoLog";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // DadosDoLog
            // 
            this.DadosDoLog.AutoSize = true;
            this.DadosDoLog.Location = new System.Drawing.Point(13, 79);
            this.DadosDoLog.Name = "DadosDoLog";
            this.DadosDoLog.Size = new System.Drawing.Size(38, 13);
            this.DadosDoLog.TabIndex = 2;
            this.DadosDoLog.Text = "Dados";
            // 
            // DescriçãoDosLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 374);
            this.Controls.Add(this.DadosDoLog);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NomeDoLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DescriçãoDosLogs";
            this.Text = "DescriçãoDosLogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label NomeDoLog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label DadosDoLog;
    }
}