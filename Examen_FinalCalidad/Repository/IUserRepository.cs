using System.Collections.Generic;
using Examen_FinalCalidad.Models;

namespace Examen_FinalCalidad.Repository
{
    public interface IUserRepository
    {
        public List<Usser> Apostadores(List<string> nueva);
        public List<Usser> Ganador(int puntaje,List<Usser> jugadores);
        public List<Usser> Puntajes(List<Card> baraja,List<Usser> jugadores);
    }
}