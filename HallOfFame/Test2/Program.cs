using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial;
using game;
using MySql.Data.MySqlClient;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());



            try
            {

                //Console.WriteLine(QueryData.getRandomStringFromDb("normal"));
                //QueryData.insertInfoPlayer("Naruto kunn", 1200);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }    
    }
}