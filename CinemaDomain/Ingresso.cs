using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Ingresso : BaseEntity
    {
        public string Documento { get; set; }
        
        public DateTime DataCompra { get; set; }
        
        public List<IngressoItem> IngressoItens { get; set; }
        
        public Sessao Sessao { get; set; }
        
        public decimal ValorTotal { get; set; }
        
        public string FormaPagamento { get; set; }
        
    }
}