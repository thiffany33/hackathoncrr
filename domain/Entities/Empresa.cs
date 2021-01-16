namespace Domain.Entities
{
    public class Empresa : BaseEntitie
    {
        public string RazaoSocial { get; set; }

        public Pessoa Pessoa { get; set; }

        public string CNPJ { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
