using System.Text.Json.Serialization;

namespace crud_teste_csh.Models
{
    public class EmpresaModel
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj {  get; set; }
        public string NomeDono { get; set; }

        [JsonIgnore]
        public ICollection<EmpregadoModel> Empregados { get; set; }
    }
}
