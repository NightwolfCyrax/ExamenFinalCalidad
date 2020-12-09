namespace Examen_FinalCalidad.Models
{
    public class ContadorCarta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public ContadorCarta(int id, int cantidad)
        {
            Id = id;
            Cantidad = cantidad;
        }
    }
}