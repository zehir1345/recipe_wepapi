using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Domain.Entities
{
    public class UserImageFile : File 
    {
        public User User { get; set; }
    }
}
