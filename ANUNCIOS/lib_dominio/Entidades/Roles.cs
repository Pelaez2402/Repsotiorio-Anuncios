namespace lib_dominio.Entidades 
{
    public class Roles
    {
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime FechaCreacion { get; set; }

    public List<UsuariosRoles>? _UsuarioRol { get; set; } = new List<UsuariosRoles>();
    } 
}