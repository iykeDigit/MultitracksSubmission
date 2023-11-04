using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Models.DTO
{
    public class CreateArtistDTO
    {
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
