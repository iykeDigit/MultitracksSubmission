using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MultiTracks.API.Models
{
    public partial class Artists
    {
        [Key]
        [Column("artistID")]
        public int ArtistId { get; set; }
        [Column("dateCreation")]
        public DateTime DateCreation { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("biography")]
        public string Biography { get; set; }
        [Column("imageURL")]
        public string ImageUrl { get; set; }
        [Column("heroURL")]
        public string HeroUrl { get; set; }
    }
}
