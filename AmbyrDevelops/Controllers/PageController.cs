using System.Collections.Generic;
using System.Threading.Tasks;
using AmbyrDevelops.DataTransferObjects;
using AmbyrDevelops.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbyrDevelops.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PageController : Controller
    {
        private readonly IPageRepository _pageRepository;
        public PageController(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<PageDTO>>> GetSections()
        {
            return Ok(await _pageRepository.GetPageSectionsAsync());
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<string>> AddSection([FromBody] PageDTO pageSection)
        {
            return Ok(await _pageRepository.AddPageSection(pageSection));
        }

        public IActionResult Index()
        {
            return View();
            //return View(_pageRepository.GetPageSectionsAsync());
        }
    }
}
