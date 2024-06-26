using SiteMvc.Models;

namespace SiteMvc.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> SearchAll();
        ContactModel ToAdd(ContactModel contact);
    }
}
