namespace PiedraPapelTijera
{
    public class Juego
    {
        private bool continuar = true;
        private string nombre;
        private int opcionJugador;

        public void Inicio()
        {
            Console.WriteLine("************Inicio del juego*********");
            Console.WriteLine("Digite su nombre: ");
            nombre = Console.ReadLine();

            Controlador();
        }

        public void Controlador()
        {
            while (continuar == true)
            {  
                Console.WriteLine(pedirYCompararJugadas());

                Console.WriteLine("**********************");

                Console.WriteLine("quiere seguir? s/n");
                String rta = Console.ReadLine();

                if (rta == "n")
                {
                    continuar = false;
                    Console.WriteLine("CHAO");
                }
            }

        }

        public string pedirYCompararJugadas()
        {
            bool entradaValida = false; 

            Console.WriteLine("Elija una opcion:");
            Console.WriteLine("1-->PIEDRA:");
            Console.WriteLine("2-->PAPEL:");
            Console.WriteLine("3-->TIJERA:");

            while (entradaValida == false) {
                opcionJugador = int.Parse(Console.ReadLine());

                if (opcionJugador >= 1 && opcionJugador <= 3)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese una opcion correcta.");
                    
                }
            }

            obtenerJugada(opcionJugador);

            int opcionCPU = generarNumeroRandom();

            Console.WriteLine("La computadora eligio: " +  obtenerJugada(opcionCPU));

            if (opcionJugador == opcionCPU)
            {
                return "EMPATE";
            }

            //piedra
            if (opcionJugador == 1)
            {
                if (opcionCPU == 2)
                {
                    return $"Jugador {nombre} PIERDE";
                }
                else
                {
                    return $"Jugador {nombre} GANA";
                }
            }

            //papel
            if (opcionJugador == 2)
            {
                if (opcionCPU == 1)
                {
                    return $"Jugador {nombre} GANA";
                }
                else
                {
                    return $"Jugador {nombre} PIERDE";
                }
            }

            //tijera
            if (opcionJugador == 3)
            {
                if (opcionCPU == 1)
                {
                    return $"Jugador {nombre} PIERDE";
                }
                else
                {
                    return $"Jugador {nombre} GANA";
                }
            }
            return "error";

        }

        public string obtenerJugada(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return "PIEDRA";
                case 2:
                    return "PAPEL";
                case 3:
                    return "TIJERA";
                default:
                    return "ERROR";
            }
        }
        public int generarNumeroRandom()
        {
            return new Random().Next(1, 4);
        }
    }
}
