using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTracks.Models
{
    public class Artist
    {
        public int artistID { get; set; }
        public System.DateTime dateCreation { get; set; } = DateTime.Now;
        public string title { get; set; }
        public string biography { get; set; }
        public string imageURL { get; set; }
        public string heroURL { get; set; }
    }
}
