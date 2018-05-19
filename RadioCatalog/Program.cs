using System;
using System.Windows.Forms;
using RadioCatalog.LIB;

namespace RadioCatalog
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();

            MessageService service = new MessageService();
            DatabaseManager manager = new DatabaseManager();
            MainPresenter presenter = new MainPresenter(mainForm, service, manager);

            presenter.Run();
        }
    }
}
