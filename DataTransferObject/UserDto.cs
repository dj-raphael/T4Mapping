using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.Attributes;

namespace DataTransferObject
{
    [Map]
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
    }
}
