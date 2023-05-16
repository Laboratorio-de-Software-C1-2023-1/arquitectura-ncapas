using _01_Aplicacion;
using _02_Dominio;
using _03_Infraestructura;

Usuario juan = new Usuario(
    Guid.NewGuid(),
    "Juan",
    "juan@test.com",
    19
);

UsuarioRepositorioEnMemoria usuarioRepositorio = new UsuarioRepositorioEnMemoria();

CrearUsuarios creadorDeUsuarios = new CrearUsuarios(
    usuarioRepositorio
);

creadorDeUsuarios.ejecutar(juan);

ObtenerUsuarios obtenedorDeUsuarios = new ObtenerUsuarios(
    usuarioRepositorio
);

List<Usuario> todosLosUsuarios = obtenedorDeUsuarios.ejecutar();
foreach (Usuario usuario in todosLosUsuarios)
{
    Console.WriteLine(usuario.presentacion());
}
