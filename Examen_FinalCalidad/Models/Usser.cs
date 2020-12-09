namespace Examen_FinalCalidad.Models
{
    public class Usser
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Score { get; set; }

        public Usser(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Usser()
        {
        }

        public Usser(int id, string nombre, int score)
        {
            Id = id;
            Nombre = nombre;
            Score = score;
        }
    }
}