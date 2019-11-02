using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Parcial.Models
{
    public class Usuario
    {
        public int id_usuario { set; get; }
        public string nombre { set; get; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string ciudad { get; set; }


        public Usuario Clone()
        {
            return new Usuario { nombre = nombre, correo = correo, contraseña = contraseña, ciudad = ciudad };
        }
    }
}
