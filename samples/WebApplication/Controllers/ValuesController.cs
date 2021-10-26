namespace WebApplication.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;

        private IList<DataModel> _mockData;

        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
            _mockData = DataModel.GetData().ToList();
        }


        [HttpGet]
        public IActionResult Get()
        {
            var viewModelData = _mockData.Select(n => _mapper.Map<DataViewModel>(n));
            return Ok(viewModelData);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var data = _mockData.FirstOrDefault(w => w.Id == id);

            if (data == null) return NotFound();
            
            var vm = _mapper.Map<DataViewModelDetails>(data);
            
            return Ok(vm);
            
        }
    }
}
