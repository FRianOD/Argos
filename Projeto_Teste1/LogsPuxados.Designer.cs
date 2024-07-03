namespace Projeto_Teste1
{
    partial class LogsPuxados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsPuxados));
            this.ListaDeLogs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaDeLogsImportantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListaDeLogs
            // 
            this.ListaDeLogs.FormattingEnabled = true;
            this.ListaDeLogs.Location = new System.Drawing.Point(12, 35);
            this.ListaDeLogs.Name = "ListaDeLogs";
            this.ListaDeLogs.Size = new System.Drawing.Size(320, 95);
            this.ListaDeLogs.TabIndex = 0;
            this.ListaDeLogs.SelectedIndexChanged += new System.EventHandler(this.ListaDeLogs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logs de Inicialização e Finalização do sistema";
            // 
            // ListaDeLogsImportantes
            // 
            this.ListaDeLogsImportantes.FormattingEnabled = true;
            this.ListaDeLogsImportantes.Location = new System.Drawing.Point(13, 137);
            this.ListaDeLogsImportantes.Name = "ListaDeLogsImportantes";
            this.ListaDeLogsImportantes.Size = new System.Drawing.Size(775, 303);
            this.ListaDeLogsImportantes.TabIndex = 2;
            // 
            // LogsPuxados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaDeLogsImportantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaDeLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogsPuxados";
            this.Text = "Logs Puxados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaDeLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaDeLogsImportantes;
    }
}