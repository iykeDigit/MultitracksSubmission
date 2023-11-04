using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTracks.Models
{
    public class Album
    {
        public int albumID { get; set; }
        public System.DateTime dateCreation { get; set; } = DateTime.Now;
        public int artistID { get; set; }
        public string title { get; set; }
        public string imageURL { get; set; }
        public int year { get; set; }
    }
}
