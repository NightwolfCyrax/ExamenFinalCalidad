using System.Collections.Generic;
using System.Linq;
using Examen_FinalCalidad.Models;

namespace Examen_FinalCalidad.Repository
{
    public class UserRepository : IUserRepository
    {
        ICardRepository cards = new CardRepository();
        
        public List<Usser> Apostadores(List<string> nueva)
        {
            List<Usser> jugadores = new List<Usser>();
            int contador = 0;
            for (int i = 1; i < 6; i++)
            {
                Usser Nuevojugardor = new Usser();
                Nuevojugardor.Id = i;
                Nuevojugardor.Nombre = nueva[contador];
                
                jugadores.Add(Nuevojugardor);
                
                contador++;
            }
            
            return jugadores;
        }

        public List<Usser> Ganador(int puntaje, List<Usser> jugadores)
        {
           
            var ganadores = jugadores.Where(o => o.Score == puntaje).ToList();
            return ganadores;
        }

        public List<Usser> Puntajes(List<Card> baraja, List<Usser> jugadores)
        {
            var players1 = baraja.Where(o => o.IdUsuario == 1).ToList();
            var players2 = baraja.Where(o => o.IdUsuario == 2).ToList();
            var players3 = baraja.Where(o => o.IdUsuario == 3).ToList();
            var players4 = baraja.Where(o => o.IdUsuario == 4).ToList();
            var players5 = baraja.Where(o => o.IdUsuario == 5).ToList();

           
           
            jugadores[0].Score = cards.Score(players1);
            jugadores[1].Score = cards.Score(players2);
            jugadores[2].Score = cards.Score(players3);
            jugadores[3].Score = cards.Score(players4);
            jugadores[4].Score = cards.Score(players5);
            return jugadores;
        }
    }
}