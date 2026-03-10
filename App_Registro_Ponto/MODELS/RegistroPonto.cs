namespace App_Registro_Ponto.Models
{
    public class RegistroPonto
    {
        public int Id { get; set; }

        public string? Usuario { get; set; }

        public DateTime DataHora { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}