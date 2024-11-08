using CapaDeDatos.Configuracion;
using CapaDeDatos.Entidades;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ConfiguracionConexion _conexion;
        public UsuarioRepositorio(IOptions<ConfiguracionConexion> conexion)
        {
            _conexion=conexion.Value;
        }
        public async Task<List<Usuarios>> ObtenerUsuarios()
        {
            List<Usuarios> lcd = new List<Usuarios>();
            using (var conexion = new SqlConnection(_conexion.CadenaSql)) 
            { 
                conexion.Open();
                SqlCommand cmd = new SqlCommand("pa_lis_usuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lcd.Add(new Usuarios()
                        {
                            Usu_rut = Convert.ToInt32(dr["usu_rut"]),
                            Usu_rut_dv= dr["usu_rut_dv"].ToString()!,
                            Usu_nombre  = dr["usu_rut_dv"].ToString()!,
                            Usu_email  = dr["usu_rut_dv"].ToString()!,
                            Usu_telefono  = dr["usu_rut_dv"].ToString()!,
                            Usu_clave = dr["usu_rut_dv"].ToString()!,
                            Usu_vigente = Convert.ToBoolean (dr["usu_rut"]),
                            Usu_reseteada = Convert.ToBoolean(dr["usu_rut"]),
                            Usu_sa = Convert.ToBoolean(dr["usu_rut"]),
                            Usu_sigla = dr["usu_rut_dv"].ToString()!,
                            Usu_cargo = dr["usu_rut_dv"].ToString()!,
                        });
                    }
                }


            }
            return lcd;

        }
    }
}
