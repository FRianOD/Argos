using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace Projeto_Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string logName = "System";

            EventLog systemLog = new EventLog(logName);

            List<EventLogEntry> inicioEventLogs = new List<EventLogEntry>();
            List<EventLogEntry> fimEventLogs = new List<EventLogEntry>();

            var inicioLog = systemLog.Entries.Cast<EventLogEntry>().Where(i => i.EventID == 6005).OrderByDescending(i => i.TimeGenerated);
            var fimLog = systemLog.Entries.Cast<EventLogEntry>().Where(i => i.EventID == 6006).OrderByDescending(i => i.TimeGenerated);

            var ultimoInicio = inicioLog.FirstOrDefault();
            var ultimoFim = fimLog.FirstOrDefault();

            if (ultimoInicio != null && ultimoFim != null)
            {
                inicioEventLogs.AddRange(inicioLog);
                fimEventLogs.AddRange(fimLog);

                List<(EventLogEntry Inicio, EventLogEntry Fim)> eventosCombinados = new List<(EventLogEntry, EventLogEntry)>(7);

                for (int i = 1; i < 8 && i - 1 < fimEventLogs.Count; i++)
                {
                    eventosCombinados.Add((inicioEventLogs[i], fimEventLogs[i - 1]));
                }

                LogsPuxados telaDeLogs = new LogsPuxados(eventosCombinados);

                telaDeLogs.Show();
            }
            else
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

