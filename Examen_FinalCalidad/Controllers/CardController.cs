using System;
using System.Collections.Generic;
using System.Linq;
using Examen_FinalCalidad.Models;
using Examen_FinalCalidad.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Examen_FinalCalidad.Controllers
{
    public class CardController : Controller
    {
            private ICardRepository cartaMetodos;
        private IUserRepository usuarioMetodos;

        public CardController(ICardRepository cartaMetodos,IUserRepository usuarioMetodos)
        {
            this.cartaMetodos = cartaMetodos;
            this.usuarioMetodos = usuarioMetodos;
        }

        public IActionResult Index()
        {
            
      
         
            return View();
        }

        public IActionResult Solucion(string player1,string player2,string player3,string player4,string player5)
        {
            List<string> ListaDeJugadores = new List<string>();
            ListaDeJugadores.Add(player1);
            ListaDeJugadores.Add(player2);
            ListaDeJugadores.Add(player3);
            ListaDeJugadores.Add(player4);
            ListaDeJugadores.Add(player5);
            var jugadores = players(ListaDeJugadores);
            
            
            var baraja = RepartirCasino();
            var jugador1 = baraja.Where(o => o.IdUsuario == 1).ToList();
            var jugador2 = baraja.Where(o => o.IdUsuario == 2).ToList();
            var jugador3 = baraja.Where(o => o.IdUsuario == 3).ToList();
            var jugador4 = baraja.Where(o => o.IdUsuario == 4).ToList();
            var jugador5 = baraja.Where(o => o.IdUsuario == 5).ToList();

            ViewBag.Jugador1 = jugador1;
            ViewBag.Jugador2 = jugador2;
            ViewBag.Jugador3 = jugador3;
            ViewBag.Jugador4 = jugador4;
            ViewBag.Jugador5 = jugador5;
            Ganadores(player1, player2, player3, player4, player5);
            jugadores[0].Score = Score(jugador1);
            jugadores[1].Score = Score(jugador2);
            jugadores[2].Score = Score(jugador3);
            jugadores[3].Score = Score(jugador4);
            jugadores[4].Score = Score(jugador5);
            Console.WriteLine("Jugador ganador");
            int contador = 0;
            var ValorMaximoPuntaje = jugadores.Max(o => o.Score);
            var JugadoresGanadores = usuarioMetodos.Ganador(ValorMaximoPuntaje,jugadores);
            @ViewBag.JugadoresGanadores = JugadoresGanadores;
            if (JugadoresGanadores.Count>1)
            {
                ViewBag.Mensaje = "Felicitaciones a los ganadores: ";
            }
            else
            {
                ViewBag.Mensaje = "Felicitaciones al unico ganador: ";
            }
            
            @ViewBag.Jugadores = jugadores;
            return View();
        }

        public List<Card> CrearBaraja()
        {
            var baraja = cartaMetodos.GenerarCartas();
            return baraja;
        }

        public List<string> CategoriaDeLaCarta()
        {
            
            return cartaMetodos.Tipo();
        }

        public List<Card> RepartirCasino()
        {
           
            return cartaMetodos.RepartirCartas();
        }

        public List<Usser> players(List<string> nombres)
        {

            var jugadores = usuarioMetodos.Apostadores(nombres);
            return jugadores;
        }

        public int Score(List<Card> mano)
        {
            
            return  cartaMetodos.Score(mano);
           
        }

        public List<Usser> Ganadores(string Nombre1,string Nombre2,string Nombre3,string Nombre4,string Nombre5)
        {
            List<string> nueva = new List<string>();
            nueva.Add(Nombre1); nueva.Add(Nombre2); nueva.Add(Nombre3); nueva.Add(Nombre4); nueva.Add(Nombre5);
            var jugadores = players(nueva);
            
            
            var baraja = RepartirCasino();

            var JugadoresConPuntaje = usuarioMetodos.Puntajes(baraja,jugadores);
            
            
            int contador = 0;
            var ValorMaximoPuntaje = cartaMetodos.MaxScore(jugadores);
            var JugadoresGanadores = usuarioMetodos.Ganador(ValorMaximoPuntaje,jugadores);
            
            return JugadoresGanadores;
        }
    }
}