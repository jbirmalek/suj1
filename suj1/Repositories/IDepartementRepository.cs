using suj1.Models;
namespace suj1.Repositories
{
    public interface IDepartementRepository
    {
        IList<Departement> GetAll();
        Departement GetById(int id);
        void Add(Departement d);
        void Edit(Departement d);
        void Delete(Departement d);
       
        int EnseignantCount(int DepartementId);
    }
}
