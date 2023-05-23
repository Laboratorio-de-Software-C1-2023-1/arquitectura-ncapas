using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio;
using _03_Infraestructura;

UsuarioDTO juan = new UsuarioDTO(
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

List<UsuarioDTO> todosLosUsuarios = obtenedorDeUsuarios.ejecutar();
foreach (UsuarioDTO usuario in todosLosUsuarios)
{
    Console.WriteLine(usuario.presentacion());
}
