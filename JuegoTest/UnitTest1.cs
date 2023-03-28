using PiedraPapelTijera;

namespace JuegoTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmpate()
        {
            int opcionJugador = 5;
            int opcionCPU = 1;

            Juego juego = new Juego();

            Assert.Equal("ERROR", juego.obtenerJugada(opcionJugador));

        }
    }
}