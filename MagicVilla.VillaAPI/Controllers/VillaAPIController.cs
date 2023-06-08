using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.VillaAPI.Controllers
{
    [ApiController]
    [Route("api/VillaAPI")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("[action]/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            VillaDTO villa = VillaStore.villaList.FirstOrDefault(temp => temp.Id == id);

            if(villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }
    }
}
