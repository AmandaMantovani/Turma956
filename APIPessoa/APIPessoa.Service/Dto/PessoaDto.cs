using System.ComponentModel.DataAnnotations;

namespace APIPessoa.Service.Dto
{
    public class PessoaDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome � obrigat�rio!")]
        [MaxLength(255)]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        [Range(0, 20)]
        public int QuantidadeFilhos { get; set; }
        public int Idade => DateTime.Now.AddYears(-DataNascimento.Year).Year;
        public string Permissao { get; set; }

    }
}