namespace Contacts.UseCases.Interfaces
{
    public interface IViewContactsUseCase
    {
        Task<List<CoreBusiness.Contact>> ExcecuteAsync(string filterText);
    }
}