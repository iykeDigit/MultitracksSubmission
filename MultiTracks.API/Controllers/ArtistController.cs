using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiTracks.API.Interface;
using MultiTracks.API.Models;
using MultiTracks.API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Controllers
{
    [Route("api.multitracks.com/artist")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistsDetails _artistsDetails;
        private readonly ILogger<ArtistController> _logger;

        public ArtistController(IArtistsDetails artistDetails, ILogger<ArtistController> logger)
        {
            _artistsDetails = artistDetails;
            _logger = logger;
        }

        [HttpGet("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateNewArtist(string artistName)
        {
            try
            {
                _logger.LogInformation("Attempting to create new artist");
                return Ok(await _artistsDetails.GetArtistbyName(artistName));
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Add(CreateArtistDTO artist) 
        {
            try
            {
                _logger.LogInformation("Retrieving artist details");
                await _artistsDetails.AddNewArtist(artist);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
