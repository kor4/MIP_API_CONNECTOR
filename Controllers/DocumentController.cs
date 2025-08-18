using Microsoft.AspNetCore.Mvc;
using MIP_API_CONNECTOR.Services;

namespace MIP_API_CONNECTOR.Controllers
{
    [ApiController]
    [Route("api/documents")]
    public class DocumentController : Controller
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        public IActionResult GetByUser([FromQuery] string? username)
        {
            if (string.IsNullOrWhiteSpace(username)) {
                return BadRequest("Требуется параметр username");
            }
            try
            {
                var docs = _documentService.GetByUser(username);
                return Ok(docs);

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            try
            {
                var doc = _documentService.GetById(id);
                if (doc is null) return NotFound();
                return Ok(doc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }



    }
}
