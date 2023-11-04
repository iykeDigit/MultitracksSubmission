using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MultiTracks.API.Models
{
    public partial class Artist
    {
        [Key]
        [Column("artistID")]
        public int ArtistId { get; set; }
        [Column("dateCreation", TypeName = "smalldatetime")]
        public DateTime DateCreation { get; set; }
        [Required]
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Column("biography")]
        public string Biography { get; set; }
        [Required]
        [Column("imageURL")]
        [StringLength(500)]
        public string ImageUrl { get; set; }
        [Required]
        [Column("heroURL")]
        [StringLength(500)]
        public string HeroUrl { get; set; }
    }
}
