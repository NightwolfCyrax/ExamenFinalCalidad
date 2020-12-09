using System;
using System.Collections.Generic;
using System.Linq;
using Examen_FinalCalidad.Models;

namespace Examen_FinalCalidad.Repository
{
    public class CardRepository : ICardRepository
    {
        public int Score(List<Card> mano)
        {
            int v1 = 0,
                v2 = 0,
                v3 = 0,
                v4 = 0,
                v5 = 0,
                v6 = 0,
                v7 = 0,
                v8 = 0,
                v9 = 0,
                v10 = 0,
                v11 = 0,
                v12 = 0,
                v13 = 0,
                Corazon = 0,
                Espada = 0,
                Cocos = 0,
                Flores = 0,
                escalera = 0,
                score = 0;
            foreach (var item in mano)
            {
                if (1 == item.Numero)
                {
                    v1++;
                }

                if (2 == item.Numero)
                {
                    v2++;
                }

                if (3 == item.Numero)
                {
                    v3++;
                }

                if (4 == item.Numero)
                {
                    v4++;
                }

                if (5 == item.Numero)
                {
                    v5++;
                }

                if (6 == item.Numero)
                {
                    v6++;
                }

                if (7 == item.Numero)
                {
                    v7++;
                }

                if (8 == item.Numero)
                {
                    v8++;
                }

                if (9 == item.Numero)
                {
                    v9++;
                }

                if (10 == item.Numero)
                {
                    v10++;
                }

                if (11 == item.Numero)
                {
                    v11++;
                }

                if (12 == item.Numero)
                {
                    v12++;
                }

                if (13 == item.Numero)
                {
                    v13++;
                }

                if ("Corazon" == item.Tipo)
                {
                    Corazon++;
                }

                if ("Cocos" == item.Tipo)
                {
                    Cocos++;
                }

                if ("Espada" == item.Tipo)
                {
                    Espada++;
                }

                if ("Flores" == item.Tipo)
                {
                    Flores++;
                }
            }

            if ((v1 == 1 && v2 == 1 && v3 == 1 && v4 == 1 && v5 == 1) ||
                (v2 == 1 && v3 == 1 && v4 == 1 && v5 == 1 && v6 == 1)
                || (v3 == 1 && v4 == 1 && v5 == 1 && v6 == 1 && v7 == 1) ||
                (v4 == 1 && v5 == 1 && v6 == 1 && v7 == 1 && v8 == 1)
                || (v5 == 1 && v6 == 1 && v7 == 1 && v8 == 1 && v9 == 1) ||
                (v6 == 1 && v7 == 1 && v8 == 1 && v9 == 1 && v10 == 1)
                || (v7 == 1 && v8 == 1 && v9 == 1 && v10 == 1 && v11 == 1) ||
                (v8 == 1 && v9 == 1 && v10 == 1 && v11 == 1 && v12 == 1)
                || (v9 == 1 && v10 == 1 && v11 == 1 && v12 == 1 && v13 == 1) ||
                (v9 == 1 && v10 == 1 && v11 == 1 && v12 == 1 && v13 == 1)
                || (v10 == 1 && v11 == 1 && v12 == 1 && v13 == 1 && v1 == 1))
            {
                escalera++;
            }


            List<ContadorCarta> baraja = new List<ContadorCarta>();
            ContadorCarta carta1 = new ContadorCarta(1, v1);
            ContadorCarta carta2 = new ContadorCarta(2, v2);
            ContadorCarta carta3 = new ContadorCarta(3, v3);
            ContadorCarta carta4 = new ContadorCarta(4, v4);
            ContadorCarta carta5 = new ContadorCarta(5, v5);
            ContadorCarta carta6 = new ContadorCarta(6, v6);
            ContadorCarta carta7 = new ContadorCarta(7, v7);
            ContadorCarta carta8 = new ContadorCarta(8, v8);
            ContadorCarta carta9 = new ContadorCarta(9, v9);
            ContadorCarta carta10 = new ContadorCarta(10, v10);
            ContadorCarta carta11 = new ContadorCarta(11, v11);
            ContadorCarta carta12 = new ContadorCarta(12, v12);
            ContadorCarta carta13 = new ContadorCarta(13, v13);
            baraja.Add(carta1);
            baraja.Add(carta2);
            baraja.Add(carta3);
            baraja.Add(carta4);
            baraja.Add(carta5);
            baraja.Add(carta6);
            baraja.Add(carta7);
            baraja.Add(carta8);
            baraja.Add(carta9);
            baraja.Add(carta10);
            baraja.Add(carta11);
            baraja.Add(carta12);
            baraja.Add(carta13);
            List<ContadorCarta> MiMano = new List<ContadorCarta>();
            foreach (var item in baraja)
            {
                if (item.Cantidad > 0)
                {
                    MiMano.Add(item);
                }
            }

            int par = 0, trio = 0, poker = 0, sola = 0;
            foreach (var item in MiMano)
            {
                // Console.WriteLine("el numero " + item.Id + " repetido " + item.Cantidad);
                if (item.Cantidad == 1)
                {
                    sola++;
                }

                if (item.Cantidad == 2)
                {
                    par++;
                }

                if (item.Cantidad == 3)
                {
                    trio++;
                }

                if (item.Cantidad == 4)
                {
                    poker++;
                }
            }


            if (escalera == 1)
            {
                if (v1 == 1 && v13 == 1)
                {
                    score += 4500 + MiMano.Max(o => o.Id);
                }
                else
                {
                    score += 4000 + MiMano.Max(o => o.Id);
                }
            }

            if (Cocos == 5 || Corazon == 5 || Flores == 5 || Espada == 5)
            {
                score += 5000 + MiMano.Max(o => o.Id);
                ;
            }

            if (escalera == 1 && (Cocos == 5 || Corazon == 5 || Flores == 5 || Espada == 5))
            {
                if (v1 == 1 && v13 == 1)
                {
                    score += 500000 + MiMano.Max(o => o.Id);
                }

                score += 50000 + MiMano.Max(o => o.Id);
                ;
            }

            if (sola == 5)
            {
                score += MiMano.Max(o => o.Id);
            }

            if (par == 1 && trio == 0)
            {
                var carta = MiMano.FirstOrDefault(o => o.Cantidad == 2);
                var cartamayor = MiMano.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (carta.Id == 1)
                {
                    score += 1000 + (14 * 15) + Mayor;
                }
                else
                {
                    score += 1000 + (carta.Id * 15) + Mayor;
                }
            }

            if (par == 2)
            {
                var carta = MiMano.Where(o => o.Cantidad == 2).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = MiMano.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    score += 2000 + (14 * 15) + Mayor;
                }
                else
                {
                    score += 2000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            if (par == 0 && trio == 1)
            {
                var carta = MiMano.Where(o => o.Cantidad == 3).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = MiMano.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    score += 3000 + (14 * 15) + Mayor;
                }
                else
                {
                    score += 3000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            if (par == 1 && trio == 1)
            {
                var carta = MiMano.Where(o => o.Cantidad == 3).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = MiMano.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    score += 6000 + (14 * 15) + Mayor;
                }
                else
                {
                    score += 6000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            if (poker == 1)
            {
                var carta = MiMano.Where(o => o.Cantidad == 4).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = MiMano.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    score += 7000 + (14 * 15) + Mayor;
                }
                else
                {
                    score += 7000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            Console.WriteLine("Puntaje total : " + score);
            return score;
        }
    

    public List<Card> RepartirCartas()
        {
            var baraja = GenerarCartas();
            
            List<int> indices = new List<int>();
            Random aleatorio = new Random();
            int contador1 = 0;


            for (int i = 1; i < 6; i++)
            {
                do
                {
                    var numero = aleatorio.Next(0, 52);
                    if (!indices.Contains(numero))
                    {
                        indices.Add(numero);
                        baraja[numero].IdUsuario = i;
                        contador1++;
                    }
                } while (contador1 < 5);

                contador1 = 0;
            }

            return baraja;

        }

        public List<Card> GenerarCartas()
        {
            
            List<Card> casino = new List<Card>();
            var tipoDeCarta = Tipo();
            int var1 = 1, var2 = 0;
            for (int i = 1; i < 53; i++)
            {
                Card carta = new Card();

                if (var1 > 13)
                {
                    var2++;
                    var1 = 1;
                }

                carta.Id = i;
                carta.Numero = var1;
                carta.Tipo = tipoDeCarta[var2];
                var1++;
                casino.Add(carta);
            }

            return casino;

        }

        public List<string> Tipo()
        {
            List<string> tipo = new List<string>();
            tipo.Add("Corazon");
            tipo.Add("Cocos");
            tipo.Add("Espada");
            tipo.Add("Flores");
            return tipo;
          
        }

        public int MaxScore(List<Usser> jugadores)
        {
            var player = jugadores.Select(o => o.Score).ToList();
            var puntajemasximo = player.Max();
            return puntajemasximo;
        }
    }
}