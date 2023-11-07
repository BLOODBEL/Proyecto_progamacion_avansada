namespace WebProyecto.Entities
{
    public class UsuarioEnt
    {
        public long IdUsuario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos1 { get; set; }
        public string Apellidos2 { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasenna { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string DescripcionRol { get; set; }

    }
}