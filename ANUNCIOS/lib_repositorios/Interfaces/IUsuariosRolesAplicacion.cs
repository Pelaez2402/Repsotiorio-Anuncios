using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    void Configurar(string StringConexion);
    UsuarioRol? Borrar(UsuarioRol? entidad);
    UsuarioRol? Guardar(UsuarioRol? entidad);
    List<UsuarioRol> Listar();
    UsuarioRol? Modificar(UsuarioRol? entidad);