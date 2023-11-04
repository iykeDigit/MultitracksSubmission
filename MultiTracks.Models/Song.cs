using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTracks.Models
{
    public class Song
    {
        public int songID { get; set; }
        public System.DateTime dateCreation { get; set; }
        public int albumID { get; set; }
        public int artistID { get; set; }
        public string title { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal bpm { get; set; }
        public string timeSignature { get; set; }
        public bool multitracks { get; set; }
        public bool customMix { get; set; }
        public bool chart { get; set; }
        public bool rehearsalMix { get; set; }
        public bool patches { get; set; }
        public bool songSpecificPatches { get; set; }
        public bool proPresenter { get; set; }
    }
}
