namespace TizzaAula
{

    public interface IServPromover
    {
    }
        
    public class ServPromover: IServPromover
    {
        private DataContext _dataContext;
        public ServPromover(DataContext dataContext) {

            _dataContext = dataContext;
        }

        public void Inserir(InserirPromoverDTO inserirDto)
        {
            var promover = new Promover();
            promover.Descricao = inserirDto.Descricao;
            promover.Valor = inserirDto.Valor;
            promover.CodigoPizzaria = inserirDto.CodigoPizzaria;
            promover.DataVigencia = inserirDto.DataVigencia;

            promover.Status = EnumStatusPromover.EmAberto;

            _dataContext.Add(promover);
            _dataContext.SaveChanges();
        }

        public ServPromover()
        {

        }
    }
}
