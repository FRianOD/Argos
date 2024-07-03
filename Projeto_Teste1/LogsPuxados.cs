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
            if (ListaDeLogs.SelectedIndex != -1)
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
            string logName = "Security";

            EventLog securityLog = new EventLog(logName);
            Console.WriteLine("Oi, estou aqui!!");
            Console.WriteLine($"Esta é a data de inicio {dataInicio.ToString()}");
            Console.WriteLine($"Esta é a data de fim {dataFim.ToString()}");

            var logTeste = securityLog.Entries.Cast<EventLogEntry>().Where(i => i.TimeGenerated >= dataInicio && i.TimeGenerated <= dataFim).OrderByDescending(i => i.TimeGenerated).Take(10);
            foreach (var log in logTeste)
            {
                Console.WriteLine(log.TimeGenerated);
                ListaDeLogsImportantes.Items.Add($"{log.TimeGenerated}");
            }
        }
    }
}