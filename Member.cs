using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataGRidText
{
    public class Member
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public GenderOpt Gender { get; set; }
        public bool Pass { get; set; }
        public Uri Email { get; set; }
    }
}
