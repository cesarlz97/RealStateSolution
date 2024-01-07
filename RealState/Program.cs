using log4net;
using log4net.Config;
using RealState.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    internal static class Program
    {
        // Define a static logger variable so that it references the
        // Logger instance named "Program".
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();

            log.Debug("Application Started");

            SQLiteManager sqliteManager = new SQLiteManager(ConfigurationManager.ConnectionStrings["SQLiteConnectionString"]?.ConnectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(sqliteManager));
        }
    }
}
