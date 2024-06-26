using SiteMvc.Models;
using SiteMvc.Data;

namespace SiteMvc.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly BancoContext _bancocontext;

        public ContactRepository(BancoContext bancoContext)
        {
            _bancocontext = bancoContext;
        }

        public List<ContactModel> SearchAll()
        {
            return _bancocontext.Contacts.ToList();
        }

        public ContactModel ToAdd(ContactModel contact)
        {
            //Insert into dataBase, table
            _bancocontext.Contacts.Add(contact);

            //Salving
            _bancocontext.SaveChanges();

            return contact;

        }
    }
}
