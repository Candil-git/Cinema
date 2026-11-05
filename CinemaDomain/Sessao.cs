using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Sessao : BaseEntity
    {
        public Filme Filme { get; set; }
        public DateTime Data { get; set; }
        public Sala Sala { get; set; }
        public decimal Preco { get; set; }
    }
}