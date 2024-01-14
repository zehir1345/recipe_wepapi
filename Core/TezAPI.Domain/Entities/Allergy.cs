using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Allergy : BaseEntity
    {
        public string Name { get; set; }
<<<<<<< HEAD
        public ICollection<User> Users { get; set; } = new List<User>();
=======
        public ICollection<User> UserAllergies { get; set; } = new List<User>();
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
    }
}
