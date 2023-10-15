using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDbSharp.Abstractions.BLL;
using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;
using MongoDbSharp.Model.Entity_DTO.MongoDbSharp.DTOs;

namespace MongoDbSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IEntity _entity;
        private readonly IMapper _mapper;
        public EntityController(IEntity entity, IMapper mapper)
        {
            _entity = entity;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IList<EntityModelDTO>> Get()
        {
            var entityModels = _entity.GetAll();
            var result = _mapper.Map<List<EntityModel>>(entityModels);
            return Ok(result);

        }
        [HttpPost]
        public IActionResult Post([FromBody] EntityModelDTO entityDTO)
        {
            var mapper = _mapper.Map<EntityModel>(entityDTO);
            _entity.Insert(mapper);
            return CreatedAtAction(nameof(Get), new { id = mapper.Id }, mapper);
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] FilterDto searchTerm)
        {
            var searchResults = _entity.SearchFor(searchTerm);

            return Ok(searchResults);
        }


    }
}
