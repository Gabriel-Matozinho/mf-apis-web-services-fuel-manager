using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Consumos")]

    public class Consumo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]

        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName ="Decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]

        public TipoCombistivel Tipo { get; set; }

        [Required]
        public int VeiculoId { get; set; }// FK

        public Veiculo Veiculo { get; set; } // 1:N
    }

    public enum TipoCombistivel
    {
        Diesel,
        Etanol,
        Gasolina

    }
}
