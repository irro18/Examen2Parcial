using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen2Parcial.Models;
using Examen2Parcial.Services;

namespace Examen2Parcial
{
    static class Program
    {

        //private static UsuarioDataService _service;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// [STAThread]
        //private static void Main()
        //{
        //    Form1 interfaz = new Form1();
        //    interfaz.ShowDialog();

        //    //Application.EnableVisualStyles();
        //    //Application.SetCompatibleTextRenderingDefault(false);
        //    //Application.Run(new Form1());
        //}

        //private static void AddUsuario()
        //{
        //    var usuario = new Usuario();
        //    Console.Clear();
        //    Console.WriteLine("New Usuarios");
        //}

        //static void Main(string[] args)
        //{
        //    IProxy proxy = new Proxy();
        //    var response = proxy.Weather("rome");
        //    Console.WriteLine($"Ciudad:{response.name}");
        //    Console.WriteLine($"Temperatura:{response.main.temp}");
        //    Console.WriteLine($"Min:{response.main.temp_min}");
        //    Console.WriteLine($"Max:{response.main.temp_max}");

        //    var response2 = proxy.Forecast("rome");
        //    int i = 0;
        //    foreach (var item in response2.list.Take(5))
        //    {
        //        i++;
        //        Console.WriteLine($"Ciudad:{item.name}");
        //        Console.WriteLine($"Temperatura:{item.main.temp}");
        //        Console.WriteLine($"Min:{item.main.temp_min}");
        //        Console.WriteLine($"Max:{item.main.temp_max}");
        //    }
        //    Console.ReadKey();
        //}

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }


    }
}
