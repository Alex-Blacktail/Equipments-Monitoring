using MediatR;
using Microsoft.AspNetCore.Mvc;
using Equipments.WebApi.Models;
using Equipments.Application.ViewModels;
using Equipments.Application.Contracts.Queries;
using Equipments.Application.Contracts.Commands;
using AutoMapper;

namespace Equipments.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EquipmentTypeController : BaseController
    {
        private readonly IMapper _mapper;

        public EquipmentTypeController(IMediator mediator, IMapper mapper) : base(mediator)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<EquipmentTypesListViewModel>> GetAll()
        {
            var query = new EquipmentTypeGetListQuery();
            var model = await _mediator.Send(query);
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EquipmentTypeCreateViewModel type)
        {
            var command = _mapper.Map<EquipmentTypeCreateCommand>(type);
            var typeId = await _mediator.Send(command);
            return Ok(typeId);
        }
    }
}
