namespace BlazorApp_Panificio.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string? nome { get; set; }
        public string? cognome { get; set; }
        public double quantitaPaneGiornaliero { get; set; }
        public string? paese { get; set; }
        public string? telefono { get; set; }
    }
}
