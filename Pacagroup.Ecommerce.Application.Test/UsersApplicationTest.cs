using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacagroup.Ecommerce.Application.Interface;
using Pacagroup.Ecommerce.Services.WebApi;
using System.IO;

namespace Pacagroup.Ecommerce.Application.Test
{
    [TestClass]
    public class UsersApplicationTest
    {
        /// <summary>
        /// Nos permite almacenar la configuracion del entorno de ejecucion de pruebas basicamente
        /// Toda la configuracion contenida en el archivo appsettings.json
        /// </summary>
        private static IConfiguration _configuration;

        /// <summary>
        /// Esta interfaz nos permite crear diferentes servicios dentro de un alcance local
        /// </summary>
        private static IServiceScopeFactory _scopeFactory;

        /// <summary>
        /// Este atributo o decorador "[ClassInitialize]" nos permite identificar un metodo que contiene 
        /// codigo que se debe ejecutar antes de que se ejecuten las pruebas unitarias
        /// </summary>
        /// <param name="_">El partametro TestContext es obligatorio de inicializacion de la clase
        /// Permite acceder a la configuracion del entorno de ejecucion de la prueba unitaria entre 
        /// otras funcionalidades </param>
        [ClassInitialize]
        public static void Initialize(TestContext _)
        {
            /// Cargamos toda la configuracion del archivo appsettings.json
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", true, true)
                              .AddEnvironmentVariables();
            // Se asigna la configuracion en la variable _configuration
            _configuration = builder.Build();

            /// Instanciamos la calse Startup de la clase Services.API y le pasamos la configuracion
            var startup = new Startup(_configuration);

            var services = new ServiceCollection();
            startup.ConfigureServices(services);
            _scopeFactory = services.BuildServiceProvider().GetService<IServiceScopeFactory>();
        }

        [TestMethod]
        public void Authenticate_CuandoNoSeEnvianParametros_RetornarMensajeErrorValidacion()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUsersApplication>();

            // Arrange

            var username = string.Empty;
            var password = string.Empty;
            var expected = "validation errors";

            // Act

            var result = context.Authenticate(username, password);
            var actual = result.Message;

            // Asserts

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Authenticate_CuandoSeEnvianParametrosCorrectos_RetornarMensajeExitoso()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUsersApplication>();

            // Arrange

            var username = "aferreira";
            var password = "123456";
            var expected = "Authentication successful!!!";

            // Act

            var result = context.Authenticate(username, password);
            var actual = result.Message;

            // Asserts

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Authenticate_CuandoSeEnvianParametrosIncorrectos_RetornarMensajeUsuarioNoExiste()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUsersApplication>();

            // Arrange

            var username = "ccopete";
            var password = "5685844";
            var expected = "User not found";

            // Act

            var result = context.Authenticate(username, password);
            var actual = result.Message;

            // Asserts

            Assert.AreEqual(expected, actual);
        }
    }
}
