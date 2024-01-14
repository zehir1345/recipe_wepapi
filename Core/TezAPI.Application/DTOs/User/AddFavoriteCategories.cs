using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.DTOs.User
{
    public class AddFavoriteCategories
    {
        //public Guid UserId { get; set; }
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
