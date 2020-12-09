using System.Collections.Generic;
using Examen_FinalCalidad.Models;

namespace Examen_FinalCalidad.Repository
{
    public interface ICardRepository
    {
        public int Score(List<Card> mano);
        public List<Card> RepartirCartas();
        public List<Card> GenerarCartas();
        public List<string> Tipo();
        public int MaxScore(List<Usser> jugadores);
    }
}