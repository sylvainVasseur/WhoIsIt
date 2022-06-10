using BackWhoIsIt.Models;
using BackWhoIsIt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackWhoIsIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnageController : ControllerBase
    {
        private readonly IPersonnageService personnageService;

        public PersonnageController(IPersonnageService personnageService) => this.personnageService = personnageService;

        [HttpGet]
        public async Task<List<Personnage>> Get() => await personnageService.GetAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Personnage>> Get(string id)
        {
            var personnage = await personnageService.GetAsync(id);
            if(personnage == null)
            {
                return NotFound();
            }
            return Ok(personnage);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Personnage newPersonnage)
        {
            await personnageService.CreateAsync(newPersonnage);

            return CreatedAtAction(nameof(Get), new { id = newPersonnage.Id }, newPersonnage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Personnage updatedPersonnage)
        {
            var personnage = await personnageService.GetAsync(id);

            if (personnage is null)
            {
                return NotFound();
            }

            updatedPersonnage.Id = personnage.Id;

            await personnageService.UpdateAsync(id, updatedPersonnage);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var personnage = await personnageService.GetAsync(id);

            if (personnage is null)
            {
                return NotFound();
            }

            await personnageService.RemoveAsync(id);

            return NoContent();
        }
    }
}
