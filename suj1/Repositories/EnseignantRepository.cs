using suj1.Models;


namespace suj1.Repositories
{
    public class EnseignantRepository : IEnseignantRepository
    {
        private List<Enseignant> enseignants;

        public EnseignantRepository()
        {
            enseignants = new List<Enseignant>();
        }

        public IList<Enseignant> GetAll()
        {
            return enseignants;
        }

        public Enseignant GetById(int id)
        {
            return enseignants.FirstOrDefault(e => e.EnseignantId == id);
        }

        public void Add(Enseignant e)
        {
            enseignants.Add(e);
        }

        public void Edit(Enseignant e)
        {
            var existingEnseignant = enseignants.FirstOrDefault(en => en.EnseignantId == e.EnseignantId);
            if (existingEnseignant != null)
            {
                existingEnseignant.Nom = e.Nom;
                existingEnseignant.Prenom = e.Prenom;
                existingEnseignant.Quantite = e.Quantite;
                existingEnseignant.DateNaissance = e.DateNaissance;
                existingEnseignant.Grade = e.Grade;
                existingEnseignant.DepartementId = e.DepartementId;
            }
        }

        public void Delete(Enseignant e)
        {
            enseignants.Remove(e);
        }

        public IList<Enseignant> GetEnseignantsByDepartementID(int? Id)
        {
            return enseignants.Where(e => e.DepartementId == Id).ToList();
        }

        public IList<Enseignant> FindByName(string name)
        {
            return enseignants.Where(e => e.Nom.Contains(name)).ToList();
        }
    }
}
