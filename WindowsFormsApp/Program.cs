using System;
using System.Windows.Forms;
using WindowsFormsApp.Data;
using WindowsFormsApp.Repositories;

namespace WindowsFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper db = new DatabaseHelper();
            db.EnsureTables();

            IConcernRepository repo = new ConcernRepository(db.GetConnector());

            Application.Run(new Form1(repo));
        }
    }
}
