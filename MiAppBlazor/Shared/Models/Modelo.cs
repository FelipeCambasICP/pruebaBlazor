using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAppBlazor.Shared.Models
{
    public class Modelo
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
    
        public List<Contact> data { get; set; }


        public Modelo()
        {
            data = new List<Contact>();
        }
    }
}
