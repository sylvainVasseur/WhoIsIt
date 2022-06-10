using BackWhoIsIt.Models;
using BackWhoIsIt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackWhoIsIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionReponseController : ControllerBase
    {
        private readonly IQuestionReponseService questionReponseService;

        public QuestionReponseController(IQuestionReponseService questionReponseService) => 
            this.questionReponseService = questionReponseService;

        [HttpGet]
        public async Task<List<QuestionReponse>> Get() => await questionReponseService.GetAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionReponse>> Get(string id)
        {
            var qR = await questionReponseService.GetAsync(id);
            if(qR == null)
            {
                return NotFound();
            }
            return Ok(qR);
        }

        [HttpPost]
        public async Task<ActionResult> Post(QuestionReponse questionReponse)
        {
            await questionReponseService.CreateAsync(questionReponse);

            return CreatedAtAction(nameof(Get), new { id = questionReponse.Id }, questionReponse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, QuestionReponse questionReponse)
        {
            var qR = await questionReponseService.GetAsync(id);
            if(qR is null)
            {
                return NotFound();
            }

            questionReponse.Id = qR.Id;

            await questionReponseService.UpdateAsync(id, questionReponse);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var qR = await questionReponseService.GetAsync(id);
            if(qR is null)
            {
                return NotFound();
            }

            await questionReponseService.RemoveAsync(id);

            return NoContent();
        }

    }
}
