using Supermarker_mvp.Presenters;
using Supermarker_mvp.Views;
using Supermarket_mvp.Views;

namespace superMarket_mvp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlconnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlconnectionString);
            Application.Run((Form)view);
        }
    }
}