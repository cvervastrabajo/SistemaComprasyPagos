namespace CapaDeDatos.Entidades
{
    public class Usuarios
    {
        public int Usu_rut { get; set; }
        public string Usu_rut_dv { get; set; } = null!;
        public string Usu_nombre { get; set; } = null!;
        public string Usu_email { get; set; } = null!;
        public string Usu_telefono { get; set; } = null!;
        public string Usu_clave { get; set; } = null!;
        public bool Usu_vigente { get; set; }
        public bool Usu_reseteada { get; set; }
        public bool Usu_sa { get; set; }
        public string Usu_sigla { get; set; } = null!;
        public string Usu_cargo { get; set; } = null!; 


    }
}
