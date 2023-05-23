using _00_Presentacion.IoC_Container;
using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.Repositorio;
using _03_Infraestructura;
using Autofac;

IContainer container = IoCContainer.getContainer();

UsuarioDTO juan = new UsuarioDTO(
    Guid.NewGuid(),
    "Juan",
    "juan@test.com",
    19
);

CrearUsuarios creadorDeUsuarios = container.Resolve<CrearUsuarios>();

creadorDeUsuarios.ejecutar(juan);

ObtenerUsuarios obtenedorDeUsuarios = container.Resolve<ObtenerUsuarios>();

List<UsuarioDTO> todosLosUsuarios = obtenedorDeUsuarios.ejecutar();
foreach (UsuarioDTO usuario in todosLosUsuarios)
{
    Console.WriteLine(usuario.presentacion());
}
