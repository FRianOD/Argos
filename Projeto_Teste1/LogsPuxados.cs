using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Teste1
{
    public partial class LogsPuxados : Form
    {

        private List<(EventLogEntry Inicio, EventLogEntry Fim)> eventLogs = new List<(EventLogEntry, EventLogEntry)>();
            
        public LogsPuxados()
        {
            InitializeComponent();
        }

        public LogsPuxados(List<(EventLogEntry Inicio,EventLogEntry Fim)> eventosCombinados)
        {
            if(eventosCombinados != null)
            {
                InitializeComponent();
                this.eventLogs = eventosCombinados;
                PopulateListaDeLogs();
            }
        }

        private void PopulateListaDeLogs()
        {
            if (eventLogs.Count > 0)
            {
                foreach (var log in eventLogs)
                {
                    ListaDeLogs.Items.Add($"Inicio: {log.Inicio.TimeGenerated} - Fim: {log.Fim.TimeGenerated}");
                }
            }
            else
            {
                ListaDeLogs.Items.Add("Nenhum log disponível");
            }
        }

        private void ListaDeLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaDeLogs.SelectedIndex >= 0)
            {
                ListaDeLogsImportantes.Items.Clear();
                string[] parts = ListaDeLogs.SelectedItem.ToString().Split(new[] {"-", "Inicio: ", "Fim: " }, StringSplitOptions.RemoveEmptyEntries);

                string[] dataEHoraI = parts[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] dataEHoraF = parts[2].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int[] dataI = dataEHoraI[0].Split('/').Select(int.Parse).ToArray();
                int[] horaI = dataEHoraI[1].Split(':').Select(int.Parse).ToArray();
                int[] dataF = dataEHoraF[0].Split('/').Select(int.Parse).ToArray();               
                int[] horaF = dataEHoraF[1].Split(':').Select(int.Parse).ToArray();

                DateTime dataInicio = new DateTime(dataI[2], dataI[1], dataI[0], horaI[0], horaI[1], horaI[2]);
                DateTime dataFim = new DateTime(dataF[2], dataF[1], dataF[0], horaF[0], horaF[1], horaF[2]);

                PopulateListaDeLogsImportantes(dataInicio, dataFim);
            }
            
        }

        private void PopulateListaDeLogsImportantes(DateTime dataInicio, DateTime dataFim)
        {
            string logAplicacao = "Application";
            string logSistema = "System";
            string logSeguranca = "Security";


            EventLog applicationLog = new EventLog(logAplicacao);
            EventLog systemLog = new EventLog(logSistema);
            EventLog securityLog = new EventLog(logSeguranca);

            var logTesteApp = applicationLog.Entries.Cast<EventLogEntry>().Where(i => i.TimeGenerated >= dataInicio && i.TimeGenerated <= dataFim).OrderByDescending(i => i.TimeGenerated);
            var logTesteSys = systemLog.Entries.Cast<EventLogEntry>().Where(i => i.TimeGenerated >= dataInicio && i.TimeGenerated <= dataFim).OrderByDescending(i => i.TimeGenerated);
            var logTesteSec = securityLog.Entries.Cast<EventLogEntry>().Where(i => i.TimeGenerated >= dataInicio && i.TimeGenerated <= dataFim).OrderByDescending(i => i.TimeGenerated);

            var logsPrincipais = logTesteApp.Where(i => i.EventID == 900||
            (i.EventID == 1000) ||
            (i.EventID == 41) ||
            (i.EventID == 1000) ||
            (i.EventID == 1000));
            if (logsPrincipais.Count() == 0)
            {
                ListaDeLogsImportantes.Items.Add("Sem logs importantes encontrados, caso precise faça uma busca");
            }
            else
            {
                foreach (var log in logsPrincipais)
                {
                    ListaDeLogsImportantes.Items.Add($"{log.Category} {log.EntryType}, {log.TimeGenerated}");
                }
            }
            
        }

        private void ListaDeLogsImportantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender != "Sem logs importantes encontrados, mas caso precise faça uma busca" );
            {
                Console.WriteLine(sender.ToString());
            }
        }
    }
}