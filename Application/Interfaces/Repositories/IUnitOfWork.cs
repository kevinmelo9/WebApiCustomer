namespace webapiTercero.Application.Interfaces.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository Customers {get;}
         
        int Complete();
    }
}