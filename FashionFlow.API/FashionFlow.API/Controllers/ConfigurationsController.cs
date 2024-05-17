using FashionFlow.API.Contexts;
using FashionFlow.API.Models.Hierarchies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FashionFlow.API.Controllers
{
    public class ConfigurationsController(DataContext context) : Controller
    {
        private DataContext DataContext { get; set; } = context;
        [HttpGet("Audiences")]
        public async Task<ActionResult<List<Audience>>> GetAudiences()
        {
            return Ok(await DataContext.Audiences.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("HierarchyProductTypes")]
        public async Task<ActionResult<List<HierarchyProductType>>> GetHierarchyProductTypes()
        {
            return Ok(await DataContext.HierarchyProductTypes.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("HierarchyProgammas")]
        public async Task<ActionResult<List<Audience>>> GetHierarchyProgrammas()
        {
            return Ok(await DataContext.HierarchyProgramma.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("HierarchyCategories")]
        public async Task<ActionResult<List<Audience>>> GetHierarchyCategories()
        {
            return Ok(await DataContext.HierarchyCategories.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("Colors")]
        public async Task<ActionResult<List<Audience>>> GetColors()
        {
            return Ok(await DataContext.Colors.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("CustomTagTypes")]
        public async Task<ActionResult<List<Audience>>> GetCustomTagTypes()
        {
            return Ok(await DataContext.CustomTagTypes.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("CustomTags")]
        public async Task<ActionResult<List<Audience>>> GetCustomTags()
        {
            return Ok(await DataContext.CustomTags.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("Fits1")]
        public async Task<ActionResult<List<Audience>>> GetFits1()
        {
            return Ok(await DataContext.Fits1.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("Fits2")]
        public async Task<ActionResult<List<Audience>>> GetFits2()
        {
            return Ok(await DataContext.Fits2.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("PlpTags")]
        public async Task<ActionResult<List<Audience>>> GetPlpTags()
        {
            return Ok(await DataContext.PlpTags.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("SiteRulers")]
        public async Task<ActionResult<List<Audience>>> GetSiteRulers()
        {
            return Ok(await DataContext.SiteRulers.OrderBy(x => x.Id).ToListAsync());
        }
        [HttpGet("UnitsOfMeasurement")]
        public async Task<ActionResult<List<Audience>>> GetUnitsOfMeasurement()
        {
            return Ok(await DataContext.UnitsOfMeasurement.OrderBy(x => x.Id).ToListAsync());
        }
    }
}
