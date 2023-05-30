using suj1.Models;


namespace suj1.Repositories
{
    public class DepartementRepository : IDepartementRepository
    {
        private List<Departement> departements;

        public DepartementRepository()
        {
            departements = new List<Departement>();
        }

        public IList<Departement> GetAll()
        {
            return departements;
        }

        public Departement GetById(int id)
        {
            return departements.FirstOrDefault(d => d.DepartementId == id);
        }

        public void Add(Departement d)
        {
            departements.Add(d);
        }

        public void Edit(Departement d)
        {
            var existingDepartement = departements.FirstOrDefault(de => de.DepartementId == d.DepartementId);
            if (existingDepartement != null)
            {
                existingDepartement.Nom = d.Nom;
                existingDepartement.Responsable = d.Responsable;
            }
        }

        public void Delete(Departement d)
        {
            departements.Remove(d);
        }

        public int EnseignantCount(int DepartementId)
        {
            return departements.FirstOrDefault(d => d.DepartementId == DepartementId)?.Enseignants.Count ?? 0;
        }
    }
}
