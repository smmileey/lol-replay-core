using Lol_AutoRecorder.IoC;
using Ninject;
using System;
using System.Windows.Forms;

namespace Lol_AutoRecorder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (IKernel kernel = new StandardKernel(new DependenciesModule()))
            {
                Application.Run(kernel.Get<LolAutoRecorder>());
            }
        }
    }
}
