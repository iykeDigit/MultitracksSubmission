using Microsoft.EntityFrameworkCore;
using MultiTracks.API.Interface;
using MultiTracks.API.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultiTracks.API.Models;
using MultiTracks.API.Models.DTO;
using AutoMapper;

namespace MultiTracks.API.Services
{
    public class ArtistDetails : IArtistsDetails
    {
        private readonly CoreDbContext _context;
        private readonly IMapper _mapper;

        public ArtistDetails(CoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddNewArtist(CreateArtistDTO artist)
        {
            try
            {
                await _context.Artist.AddAsync(_mapper.Map<Artist>(artist));
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new ArgumentException("An error occurred");
            }

        }

        public async Task<Response<Artist>> GetArtistbyName(string artistName)
        {
            var artist = await _context.Artist.Where(x => x.Title == artistName).FirstOrDefaultAsync();
            if (artist != null)
            {
                return new Response<Artist>(artist);
            }
            else
            {
                throw new ArgumentNullException("Artist Not Found");
            }
        }
    }
}
