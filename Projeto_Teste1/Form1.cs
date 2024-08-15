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

            var inicioLog = systemLog.Entries.Cast<EventLogEntry>().Where(i => (i.EventID == 6005)).OrderByDescending(i => i.TimeGenerated);
            var fimLog = systemLog.Entries.Cast<EventLogEntry>().Where(i => i.EventID == 6006).OrderByDescending(i => i.TimeGenerated);

            if (inicioLog != null && fimLog != null)
            {
                inicioEventLogs.AddRange(inicioLog);
                fimEventLogs.AddRange(fimLog);

                List<(EventLogEntry Inicio, EventLogEntry Fim)> eventosCombinados = new List<(EventLogEntry, EventLogEntry)>(7);
                var i = 0;
                var j = 0;
                while(eventosCombinados.Count<7)
                {
                    if (inicioEventLogs[i].TimeGenerated > fimEventLogs[j].TimeGenerated)
                    {
                        i++;
                    }
                    else
                    {
                        eventosCombinados.Add((inicioEventLogs[i], fimEventLogs[j]));
                        i++;
                        j++;
                    }
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

