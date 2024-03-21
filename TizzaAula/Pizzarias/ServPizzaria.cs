namespace TizzaAula
{
    public interface IServPizzaria 
    {
        void Inserir(Pizzaria pizzaria);
        void Update(int id, UpdatePizzariaDto updatePizzariaDto);
        void RegistrarPatrocinio(int codigoPizzaria, decimal valorPromover, DateTime dataVigencia);
    }

    public class ServPizzaria: IServPizzaria
    {

        private DataContext _dataContext;

        public ServPizzaria(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Pizzaria pizzaria)
        {
            _dataContext.Add(pizzaria);

            _dataContext.SaveChanges();
        }

        public void Update(int id, UpdatePizzariaDto updatePizzariaDto)
        {
            var pizzaria = _dataContext.Pizzaria.Where(p => p.Id == id).FirstOrDefault();
            pizzaria.Nome = updatePizzariaDto.Nome;
            pizzaria.Endereco = updatePizzariaDto.Endereco; 
            pizzaria.Telefone = updatePizzariaDto.Telefone;
            pizzaria.Responsavel = updatePizzariaDto.Responsavel;

            _dataContext.SaveChanges();
        }

        public void RegistrarPatrocinio(int codigoPizzaria, decimal valorPromover, DateTime dataVigencia)
        {
            var pizzaria = _dataContext.Pizzaria.Where(p => p.Id == codigoPizzaria).FirstOrDefault();

            pizzaria.ValorPromover = valorPromover;
            pizzaria.DataVigenciaPromover = dataVigencia;

            _dataContext.SaveChanges();


        }

    }

    
}