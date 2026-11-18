using System.ComponentModel.DataAnnotations;

namespace A5_Components_LPV2.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = "";

        [Range(0.01, 100000, ErrorMessage = "Preço maior que zero.")]
        public decimal Preco { get; set; }

        [Range(1, 100000, ErrorMessage = "Quantidade maior que zero.")]
        public int Quantidade { get; set; }
    }
}
