using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects.Attributes;

namespace DataObjects
{
    [Map]
    public class User
    {
        public Guid UserId { get; set; }
        [Map(Name = "Username")]
        public string Login { get; set; }
        public string Hash { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
    }
}
