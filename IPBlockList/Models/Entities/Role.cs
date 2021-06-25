using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPBlockList.Models.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
