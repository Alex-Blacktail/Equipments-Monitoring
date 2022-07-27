using Microsoft.AspNetCore.Mvc;
using Equipments.WebApi.Models;
using Equipments.Application.Queries;
using Equipments.Application.ViewModels;
using Equipments.Application.Commands;
using MediatR;
using AutoMapper;

namespace Equipments.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EquipmentController : BaseController
    {
        private readonly IMapper _mapper;

        public EquipmentController(IMediator mediator, IMapper mapper) : base(mediator)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<EquipmentsListViewModel>> GetAll()
        {
            var query = new EquipmentGetListQuery();
            var model = await _mediator.Send(query);
            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EquipmentDetailsViewModel>> GetDetails(int id)
        {
            var query = new EquipmentGetDetailsQuery { Id = id };
            var model = await _mediator.Send(query);
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EquipmentCreateViewModel equipment)
        {
            var command = _mapper.Map<EquipmentCreateCommand>(equipment);
            var equipmentId = await _mediator.Send(command);
            return Ok(equipmentId);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EquipmentUpdateViewModel equipment)
        {
            var command = _mapper.Map<EquipmentUpdateCommand>(equipment);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new EquipmentDeleteCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
