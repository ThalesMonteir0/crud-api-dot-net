namespace crud_teste_csh.Models
{
    public class EmpregadoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public EmpresaModel Empresa { get; set; }
    }
}
