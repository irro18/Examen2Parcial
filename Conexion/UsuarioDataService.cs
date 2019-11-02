using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Examen2Parcial.Models;
using Examen2Parcial.Sql;
using System.Data;

namespace Examen2Parcial
{
    public class UsuarioDataService
    {
        public static UsuarioDataService _instance;
        private static readonly object _lock = new object();
        private readonly SqlClient _clientazo;

        public static UsuarioDataService GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new UsuarioDataService(connectionString);
                    }
                }
            }
            return _instance;
        }

        private UsuarioDataService (string connectionString)
        {
            _clientazo = new SqlClient(connectionString);
        }

        public List<Usuario> GetUsuarios()
        {
            var result = new List<Usuario>();
            try
            {
                if (_clientazo.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _clientazo.Connection,
                        CommandText = "getUsuarios",
                        CommandType = CommandType.StoredProcedure
                    };
                    var datareader = command.ExecuteReader();
                    while (datareader.Read())
                    {
                        var usuario = new Usuario
                        {
                            id_usuario = Convert.ToInt32(datareader["id_usuario"].ToString()),
                            nombre = datareader["nombre"].ToString(),
                            correo = datareader["correo"].ToString(),
                            ciudad = datareader["ciudad"].ToString(),
                            contraseña = datareader["contraseña"].ToString()
                        };
                        result.Add(usuario);
                    }
                }
            }
            catch
            {
                //ignor
            }
            finally
            {
                _clientazo.Close();
            }

            return result;
        }

        public bool AddUsuario(Usuario usuario)
        {
            var result = false;
            try
            {
                if (_clientazo.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _clientazo.Connection,
                        CommandText = "addUsuario",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@nombre", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.nombre
                    };
                    var par2 = new SqlParameter("@correo", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.correo
                    };
                    var par4 = new SqlParameter("@contraseña", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.contraseña
                    };
                    var par3 = new SqlParameter("@ciudad", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.ciudad
                    };
                    var par5 = new SqlParameter("@hasError", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par5);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@hasError"].Value.ToString());

                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _clientazo.Close();
            }
            return result;
        }

        public bool DeleteUsuario(int id_usuario)
        {
            var result = false;
            try
            {
                if (_clientazo.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _clientazo.Connection,
                        CommandText = "deleteUsuario",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@id_usuario", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = id_usuario
                    };

                    var par4 = new SqlParameter("@hasError", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par4);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@hasError"].Value.ToString());
                }
            }
            catch(Exception)
            {
                result = false;
            }
            finally
            {
                _clientazo.Close();
            }
            return result;

            
        }
        
        



        



    }
}
