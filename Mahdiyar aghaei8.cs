using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digikala1.Model;

internal class Digikala
{
    public int ID_Order { get; set; }
    public int ID_Customer{ get; set; }
    public int ID_Item{ get; set; }
    public string DateTime_CartFinalize{ get; set; }
    public int Amount_Gross_Order{ get; set; }
    public string city_name_fa { get; set; }

    class DigikalaContext
    {

        private Digikala Digikala;
        private string line;

        public List<Digikala> Digikalas { get; set; }

        public DigikalaContext (string address)
        {
        }
    }
}
