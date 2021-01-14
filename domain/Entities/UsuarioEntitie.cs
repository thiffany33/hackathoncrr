namespace Domain.Entities
{
    public class UsuarioEntitie : BaseEntitie
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public Renda Renda { get; set; }
    }
}
