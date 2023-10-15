using Microsoft.AspNetCore.Mvc;
using MongoDbSharp.Abstractions.BLL;
using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;

namespace MongoDbSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IEntity _entity;
        public EntityController(IEntity entity)
        {
            _entity = entity;
        }

        [HttpGet]
        public ActionResult<IList<EntityModel>> Get()
        {
            var result = _entity.GetAll();
            return Ok(result);

        }
        [HttpPost]
        public IActionResult Post([FromBody] EntityModel entity)
        {
            _entity.Insert(entity);
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] FilterDto searchTerm)
        {
            //if (searchTerm == null )
            //{
            //    return Ok(new List<EntityModel>());
            //}
            //Expression<Func<EntityModel, bool>> predicate = entity => entity.Name.Contains(searchTerm);
            //var searchResults = _entity.SearchFor(predicate);


            //return Ok(searchResults);
            var searchResults = _entity.SearchFor(searchTerm);

            return Ok(searchResults);
        }


    }
}
