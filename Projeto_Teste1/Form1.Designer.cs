namespace Projeto_Teste1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.seteUltimosLogs = new System.Windows.Forms.Button();
            this.LogsDosUltimos7Dias = new System.Windows.Forms.Button();
            this.LogsDosUltimos30Dias = new System.Windows.Forms.Button();
            this.TodosOsLogsDoSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capturar logs baseados na inicialização do sistema";
            this.label1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seteUltimosLogs
            // 
            this.seteUltimosLogs.Location = new System.Drawing.Point(16, 38);
            this.seteUltimosLogs.Name = "seteUltimosLogs";
            this.seteUltimosLogs.Size = new System.Drawing.Size(75, 23);
            this.seteUltimosLogs.TabIndex = 2;
            this.seteUltimosLogs.Text = "7 ultimos";
            this.seteUltimosLogs.UseVisualStyleBackColor = true;
            this.seteUltimosLogs.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogsDosUltimos7Dias
            // 
            this.LogsDosUltimos7Dias.Location = new System.Drawing.Point(184, 38);
            this.LogsDosUltimos7Dias.Name = "LogsDosUltimos7Dias";
            this.LogsDosUltimos7Dias.Size = new System.Drawing.Size(75, 23);
            this.LogsDosUltimos7Dias.TabIndex = 3;
            this.LogsDosUltimos7Dias.Text = "7 dias";
            this.LogsDosUltimos7Dias.UseVisualStyleBackColor = true;
            // 
            // LogsDosUltimos30Dias
            // 
            this.LogsDosUltimos30Dias.Location = new System.Drawing.Point(16, 87);
            this.LogsDosUltimos30Dias.Name = "LogsDosUltimos30Dias";
            this.LogsDosUltimos30Dias.Size = new System.Drawing.Size(75, 23);
            this.LogsDosUltimos30Dias.TabIndex = 4;
            this.LogsDosUltimos30Dias.Text = "30 dias";
            this.LogsDosUltimos30Dias.UseVisualStyleBackColor = true;
            // 
            // TodosOsLogsDoSistema
            // 
            this.TodosOsLogsDoSistema.Location = new System.Drawing.Point(184, 87);
            this.TodosOsLogsDoSistema.Name = "TodosOsLogsDoSistema";
            this.TodosOsLogsDoSistema.Size = new System.Drawing.Size(75, 23);
            this.TodosOsLogsDoSistema.TabIndex = 5;
            this.TodosOsLogsDoSistema.Text = "Todos";
            this.TodosOsLogsDoSistema.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 137);
            this.Controls.Add(this.TodosOsLogsDoSistema);
            this.Controls.Add(this.LogsDosUltimos30Dias);
            this.Controls.Add(this.LogsDosUltimos7Dias);
            this.Controls.Add(this.seteUltimosLogs);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Argos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seteUltimosLogs;
        private System.Windows.Forms.Button LogsDosUltimos7Dias;
        private System.Windows.Forms.Button LogsDosUltimos30Dias;
        private System.Windows.Forms.Button TodosOsLogsDoSistema;
    }
}

