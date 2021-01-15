namespace Domain.Entities
{
    public class Usuario : BaseEntitie
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public Renda Renda { get; set; }
    }
}
