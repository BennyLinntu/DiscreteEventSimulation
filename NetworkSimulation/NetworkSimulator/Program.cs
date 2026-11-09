using System;
using System.IO;
using System.Windows.Forms;

namespace NetworkSimulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, e) => ReportCrash(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) => ReportCrash(e.ExceptionObject as Exception);

            var form = new Main();
            if (Array.IndexOf(args, "--demo") >= 0)
            {
                int events = 0;
                int idx = Array.IndexOf(args, "--events");
                if (idx >= 0 && idx + 1 < args.Length) int.TryParse(args[idx + 1], out events);
                form.Shown += (sender, e) => form.RunDemo(events, Array.IndexOf(args, "--results") >= 0);
            }
            Application.Run(form);
        }

        private static void ReportCrash(Exception ex)
        {
            try
            {
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "crash.log"),
                    DateTime.Now + Environment.NewLine + ex);
            }
            catch { }
            MessageBox.Show(ex == null ? "Unknown error." : ex.Message,
                "Application error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


