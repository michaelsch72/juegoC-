using System;

namespace Tateti
{
    class Program
    {
      

        static void Main(string[] args)
        {
            int jugador = 2; //jugador 1
            int entrada = 0;
            bool ingresoCorrecto = true;
           

            do
            {
                if (jugador == 2)
                {
                    jugador = 1;
                  colocarXO(jugador, entrada); 
                }
                else if (jugador == 1)
                {
                    jugador = 2;
                    colocarXO(jugador, entrada);
                   
                }

                crearTablero();

                // verificar ganador
                char[] jugadorSimbolo = { 'X', 'O' };

                foreach (char jugadorEnJuego in jugadorSimbolo)
                {
                    if (((tableroJuego[0, 0] == jugadorEnJuego) && (tableroJuego[0, 1] == jugadorEnJuego) && (tableroJuego[0, 2] == jugadorEnJuego))
                                               || ((tableroJuego[1, 0] == jugadorEnJuego) && (tableroJuego[1, 1] == jugadorEnJuego) && (tableroJuego[1, 2] == jugadorEnJuego))
                                               || ((tableroJuego[2, 0] == jugadorEnJuego) && (tableroJuego[2, 1] == jugadorEnJuego) && (tableroJuego[2, 2] == jugadorEnJuego))
                                               || ((tableroJuego[0, 0] == jugadorEnJuego) && (tableroJuego[1, 0] == jugadorEnJuego) && (tableroJuego[2, 0] == jugadorEnJuego))
                                               || ((tableroJuego[0, 1] == jugadorEnJuego) && (tableroJuego[1, 1] == jugadorEnJuego) && (tableroJuego[2, 1] == jugadorEnJuego))
                                               || ((tableroJuego[0, 2] == jugadorEnJuego) && (tableroJuego[1, 2] == jugadorEnJuego) && (tableroJuego[2, 2] == jugadorEnJuego))
                                               || ((tableroJuego[0, 0] == jugadorEnJuego) && (tableroJuego[1, 1] == jugadorEnJuego) && (tableroJuego[2, 2] == jugadorEnJuego))
                                               || ((tableroJuego[0, 2] == jugadorEnJuego) && (tableroJuego[1, 1] == jugadorEnJuego) && (tableroJuego[2, 0] == jugadorEnJuego)))
                    {
                        if (jugadorEnJuego == 'X')
                        {
                            Console.WriteLine("\n Felicitaciones Jugador 2 ha ganado");
                            
                        }
                        else
                        {
                            Console.WriteLine("\nFelicitaciones Jugador 1 a ganado");
                          
                        }
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.ReadKey();
                        entrada = 0;

                        resetearTablero();
                        break;
                    }
                }


                do
                {
                    Console.WriteLine("\nJugador {0}: elija un espacio", jugador);
                    try
                    {
                        entrada = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor ingrese un numero");
                    }
                    if ((entrada == 1) && (tableroJuego[0, 0] == '1'))
                        ingresoCorrecto = true;
                    else if ((entrada == 2) && (tableroJuego[0, 1] == '2'))
                        ingresoCorrecto = true;
                    else if ((entrada == 3) && (tableroJuego[0, 2] == '3'))
                        ingresoCorrecto = true;
                    else if ((entrada == 4) && (tableroJuego[1, 0] == '4'))
                        ingresoCorrecto = true;
                    else if ((entrada == 5) && (tableroJuego[1, 1] == '5'))
                        ingresoCorrecto = true;
                    else if ((entrada == 6) && (tableroJuego[1, 2] == '6'))
                        ingresoCorrecto = true;
                    else if ((entrada == 7) && (tableroJuego[2, 0] == '7'))
                        ingresoCorrecto = true;
                    else if ((entrada == 8) && (tableroJuego[2, 1] == '8'))
                        ingresoCorrecto = true;
                    else if ((entrada == 9) && (tableroJuego[2, 2] == '9'))
                        ingresoCorrecto = true;
                    else
                    {
                        Console.WriteLine("\n Por favor ingrese otro numero");
                        ingresoCorrecto = false;
                    }       
                } while (!ingresoCorrecto);


            } while (true);
           
        }

        public static void colocarXO(int jugador,int entrada)
        {
            char jugadorSimbolo = ' ';
            if (jugador == 1)
            {
                jugadorSimbolo = 'X';
             
            }else if(jugador == 2)
            {
                jugadorSimbolo = 'O';
            }
           
                    switch (entrada)
                    {
                        case 1:
                            tableroJuego[0, 0] = jugadorSimbolo; break;
                        case 2:                 
                            tableroJuego[0, 1] = jugadorSimbolo; break;
                        case 3:                 
                            tableroJuego[0, 2] = jugadorSimbolo; break;
                        case 4:                 
                            tableroJuego[1, 0] = jugadorSimbolo; break;
                        case 5:                 
                            tableroJuego[1, 1] = jugadorSimbolo; break;
                        case 6:                  
                            tableroJuego[1, 2] = jugadorSimbolo; break;
                        case 7:                
                            tableroJuego[2, 0] = jugadorSimbolo; break;
                        case 8:                  
                            tableroJuego[2, 1] = jugadorSimbolo; break;
                        case 9:
                            tableroJuego[2, 2] = 'X'; break;
                    }
                
            
        }

        static char[,] tableroJuego =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        static char[,] tableroJuegoInicial =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        public static void crearTablero()
        {
            Console.Clear();

            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  | {2}  ", tableroJuego[0, 0], tableroJuego[0, 1], tableroJuego[0,2]);
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  | {2}  ", tableroJuego[1,0], tableroJuego[1,1], tableroJuego[1,2]);
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  | {2}  ", tableroJuego[2,0], tableroJuego[2,1], tableroJuego[2,2]);
            Console.WriteLine("     |     |");
        } 

        public static void resetearTablero()
        {
            tableroJuego = tableroJuegoInicial;
            crearTablero();
        }   
    }

   
}   
