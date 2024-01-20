using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contact : BaseModel
    {
        public string Location { get; set; }
        public string Email { get; set; }
        public int Call { get; set; }
        public string Icon { get; set; }
    }
}
