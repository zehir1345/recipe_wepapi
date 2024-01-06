using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Allergy : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> UserAllergies { get; set; } = new List<User>();
    }
}
