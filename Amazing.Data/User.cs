using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazing.Data
{
    public class User
    {
        public uint Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public byte[] Avatar { get; set; }
        public List<Post> Posts { get; set; }
    }
}
