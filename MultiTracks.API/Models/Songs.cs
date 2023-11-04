using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MultiTracks.API.Models
{
    public partial class Songs
    {
        [Key]
        [Column("songID")]
        public int SongId { get; set; }
        [Column("dateCreation")]
        public DateTime DateCreation { get; set; }
        [Column("albumID")]
        public int AlbumId { get; set; }
        [Column("artistID")]
        public int ArtistId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("bpm", TypeName = "decimal(18, 2)")]
        public decimal Bpm { get; set; }
        [Column("timeSignature")]
        public string TimeSignature { get; set; }
        [Column("multitracks")]
        public bool Multitracks { get; set; }
        [Column("customMix")]
        public bool CustomMix { get; set; }
        [Column("chart")]
        public bool Chart { get; set; }
        [Column("rehearsalMix")]
        public bool RehearsalMix { get; set; }
        [Column("patches")]
        public bool Patches { get; set; }
        [Column("songSpecificPatches")]
        public bool SongSpecificPatches { get; set; }
        [Column("proPresenter")]
        public bool ProPresenter { get; set; }
    }
}
