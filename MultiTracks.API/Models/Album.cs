using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MultiTracks.API.Models
{
    public partial class Album
    {
        [Key]
        [Column("albumID")]
        public int AlbumId { get; set; }
        [Column("dateCreation", TypeName = "smalldatetime")]
        public DateTime DateCreation { get; set; }
        [Column("artistID")]
        public int ArtistId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [Column("imageURL")]
        [StringLength(500)]
        public string ImageUrl { get; set; }
        [Column("year")]
        public int Year { get; set; }
    }
}
