using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio.Tests {
    public class GestorTests {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarCorrectamente() {
            //Arrange 
            var usuario = new Usuario("gael", 20, "Definir");
            var rutina = new Rutina("YOPUEDO", 120);
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarRutinaAUsuario(usuario, rutina);

            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }
        [Fact]
        public void AsignarUsuarioAEntrenador_DebeIncluiUsuario()
        {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var entrenador = new Entrenador("Pepe", "Licuados");
            var asignador = new AsignadorRutinas();

            //act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}