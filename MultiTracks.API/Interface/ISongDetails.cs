using MultiTracks.API.Models;
using MultiTracks.API.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Interface
{
    public interface ISongDetails
    {
        Task<PagedResponse<IEnumerable<Song>>> GetAllSongs(PaginationFilter filter);
    }
}
