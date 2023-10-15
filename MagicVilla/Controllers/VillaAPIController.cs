using MagicVilla.Data;
using MagicVilla.Models;
using MagicVilla.Models.VillaDTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        public VillaAPIController(ApplicationDBContext db)
        {
            _db = db;   
        }

        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>>GetVillas()
        {
            return Ok (_db.VillaList);
        }

        [HttpGet("{ID:int}",Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int ID)
        {
            if(ID == 0)
            {
                return BadRequest();
            }
            var villa = _db.VillaList.FirstOrDefault(u => u.Id == ID);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<VillaDTO> CreateVilla([FromBody]VillaDTO villaDTO)
        {
            if (_db.VillaList.FirstOrDefault(u=>u.Name.ToLower()==villaDTO.Name.ToLower())!=null)
            {
                ModelState.AddModelError("CustomError", "Villa already exists");
                return BadRequest(ModelState);
            }
            //if(!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if (villaDTO == null)
            {
                return BadRequest(villaDTO);
            }
            //if(villaDTO.Id > 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}
            Villa model = new ()
            {
                Name= villaDTO.Name,
               
                Amenity = villaDTO.Amenity,
                details = villaDTO.details,
                ImageURL = villaDTO.ImageURL,
                occupancy = villaDTO.occupancy,
                rate = villaDTO.rate,
                sqft = villaDTO.sqft,
                CreatedOn = villaDTO.CreatedOn
            };
            _db.VillaList.Add(model);
            _db.SaveChanges();
            //villaDTO.Id= VillaStore.VillaList.OrderByDescending(u=>u.Id).FirstOrDefault().Id+1;
            //VillaStore.VillaList.Add(villaDTO);
            return CreatedAtRoute("GetVilla", new {ID = villaDTO.Id},villaDTO);
        }
        [HttpDelete("{ID:int}",Name ="deleteVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int ID)
        {
            if(ID==0)
            {
                return BadRequest();
            }
            var villa=_db.VillaList.FirstOrDefault(u=>u.Id==ID);
            if(villa == null)
            {
                return NotFound();
            }
            _db.VillaList.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPut("{ID:int}", Name ="UpdateVilla")]
        public IActionResult updateVilla(int ID, [FromBody]VillaDTO villaDTO) 
        {
            if(villaDTO==null || ID != villaDTO.Id)
            {
                return BadRequest();    
            }
            //var villa = _db.VillaList.FirstOrDefault(u=>u.Id == ID);
            //villa.Name = villaDTO.Name;
            //villa.occupancy = villaDTO.occupancy;
            //villa.sqft= villaDTO.sqft;
            Villa model = new()
            {
                Name=villaDTO.Name,
                Amenity = villaDTO.Amenity,
                details = villaDTO.details,
                ImageURL = villaDTO.ImageURL,
                occupancy = villaDTO.occupancy,
                rate = villaDTO.rate,
                sqft = villaDTO.sqft,
                CreatedOn = villaDTO.CreatedOn
            };
            //_db.VillaList.Update(model);
            //_db.SaveChanges();
            _db.Attach(model);
            _db.VillaList.Update(model);
            _db.SaveChanges();

            return NoContent();
                    
        }
        [HttpPatch("{ID:int}",Name ="UpdatePartialVilla")]
        public IActionResult updatePartial(int ID, JsonPatchDocument<VillaDTO> patchDTO)
        {
            if(ID == 0 || patchDTO == null)
            {
                return BadRequest();
            }
            var villa= _db.VillaList.FirstOrDefault(u=>u.Id == ID);
            if(villa == null)
            {
                return BadRequest();
            }
            VillaDTO villaDTO = new()
            {
                Name=villa.Name,
                Amenity = villa.Amenity,
                details = villa.details,
                ImageURL = villa.ImageURL,
                occupancy = villa.occupancy,
                rate = villa.rate,
                sqft = villa.sqft,
                CreatedOn = villa.CreatedOn
            };
            patchDTO.ApplyTo(villaDTO, ModelState);
            Villa model = new()
            {
                Name = villaDTO.Name,
                Amenity = villaDTO.Amenity,
                details = villaDTO.details,
                ImageURL = villaDTO.ImageURL,
                occupancy = villaDTO.occupancy,
                rate = villaDTO.rate,
                sqft = villaDTO.sqft,
                CreatedOn = villaDTO.CreatedOn
            };
            _db.VillaList.Update(model);
            _db.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();

        }

    }
}
