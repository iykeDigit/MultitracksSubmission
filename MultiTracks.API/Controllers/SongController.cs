using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiTracks.API.Interface;
using MultiTracks.API.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Controllers
{
    [Route("api.multitracks.com/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongDetails _songDetails;
        private readonly ILogger<SongController> _logger;

        public SongController(ISongDetails songDetails, ILogger<SongController> logger)
        {
            _songDetails = songDetails;
            _logger = logger;
        }

        [HttpGet("list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllSongs([FromQuery] PaginationFilter filter)
        {
            try
            {
                _logger.LogInformation("Retrieving Songs from the database");
                return Ok(await _songDetails.GetAllSongs(filter));
            }
            
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
