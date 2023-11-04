using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MultiTracks.API.Context;
using MultiTracks.API.Interface;
using MultiTracks.API.Models;
using MultiTracks.API.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Services
{
    public class SongDetails : ISongDetails
    {
        private readonly CoreDbContext _context;
        

        public SongDetails(CoreDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResponse<IEnumerable<Song>>> GetAllSongs(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var totalRecords = await _context.Song.CountAsync();
            var data = await _context.Song
                                     .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                                     .Take(validFilter.PageSize)
                                     .ToListAsync();
            return PaginationHelper.CreatePagedReponse<Song>(data, validFilter, totalRecords);
        }
    }
}
