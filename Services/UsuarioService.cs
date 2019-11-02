using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2Parcial.Models;

namespace Examen2Parcial.Services
{
    public class UsuarioService
    {

        private readonly UsuarioDataService _dataService;

        public UsuarioService(string connectionString)
        {
            _dataService = UsuarioDataService.GetInstance(connectionString);
        }

        public List<Usuario> GetUsuarios()
        {
            return _dataService.GetUsuarios();
        }

        public string AddUsuario(Usuario usuario)
        {
            try
            {
                return _dataService.AddUsuario(usuario) ? "Usuario agregado." : "Error al agregar.";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteUsuario(int id_usuario)
        {
            try
            {
                return _dataService.DeleteUsuario(id_usuario) ? "Usuario eliminado." : "Error al eliminar.";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }



    }
}
