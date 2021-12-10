using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game

{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Easy("Hi"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi game!");
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}
