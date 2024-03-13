namespace TizzaAula
{
    public interface IServPizza
    {
        void Inserir(Pizza pizza);
    }

    public class ServPizza: IServPizza
    {

        private DataContext _dataContext;

        public ServPizza(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Pizza pizza)
        {
            _dataContext.Add(pizza);

            _dataContext.SaveChanges();
        }

    }
}