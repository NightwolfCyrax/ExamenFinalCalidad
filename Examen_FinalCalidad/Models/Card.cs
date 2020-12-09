namespace Examen_FinalCalidad.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        
        public int IdUsuario { get; set; }

        public Card(int id, int numero, string tipo, int idUsuario)
        {
            Id = id;
            Numero = numero;
            this.Tipo = tipo;
            IdUsuario = idUsuario;
        }

        public Card()
        {
        }
    }
}