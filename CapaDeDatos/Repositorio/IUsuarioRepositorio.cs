using CapaDeDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuarios>> ObtenerUsuarios();
    }
}
