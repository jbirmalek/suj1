using suj1.Models;
namespace suj1.Repositories
{
    public interface IEnseignantRepository
    {
        IList<Enseignant> GetAll();
        Enseignant GetById(int id);
        void Add(Enseignant e);
        void Edit(Enseignant e);
        void Delete(Enseignant e);
        IList<Enseignant> GetEnseignantsByDepartementID(int? Id);
        IList<Enseignant> FindByName(string name);
    }
}
