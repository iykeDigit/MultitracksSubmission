using MultiTracks.API.Models;
using MultiTracks.API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Interface
{
    public interface IArtistsDetails
    {
        Task<Response<Artist>> GetArtistbyName(string artistName);
        Task AddNewArtist(CreateArtistDTO artist);
    }
}
