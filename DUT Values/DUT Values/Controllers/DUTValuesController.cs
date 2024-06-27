using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DUT_Values.Models;
using DUT_Values.Data;
using Microsoft.EntityFrameworkCore;

//namespace DUT_Values.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class DUTValuesController : Controller
//    {
//        private readonly DataContext _context;

//        public DUTValuesController(DataContext context)
//        {
//            _context = context;
//        }


//        [HttpGet]
//        public IActionResult GetDUTValues()
//        { 
//            var dutValues = _context.DUTValues.ToList();
//            if (dutValues.Count > 0)
//            {
//                return Ok(dutValues);
//            }

//            return NoContent();
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetDUTValue(int id)
//        {
//            var dutValue = _context.DUTValues.Find(id);
//            if (dutValue != null)
//            {
//                return Ok(dutValue);
//            }
//            return NotFound();
//        }

//        [HttpPost]
//        public IActionResult CreateDUTValue([FromBody] DUTValue dutValue)
//        {
//            if (dutValue == null)
//            {
//                return BadRequest();
//            }

//            _context.DUTValues.Add(dutValue);
//            _context.SaveChanges();

//            return CreatedAtAction(nameof(GetDUTValue), new { id = dutValue.DUTValueId }, dutValue);
//        }

//        // PUT: api/DUTValues/UpdateDUTValue/5
//        [HttpPut("{id}")]
//        public IActionResult UpdateDUTValue(int id, [FromBody] DUTValue dutValue)
//        {
//            if (id != dutValue.DUTValueId || dutValue == null)
//            {
//                return BadRequest();
//            }

//            var existingDUTValue = _context.DUTValues.Find(id);
//            if (existingDUTValue == null)
//            {
//                return NotFound();
//            }

//            existingDUTValue.DUTValueName = dutValue.DUTValueName;

//            _context.DUTValues.Update(existingDUTValue);
//            _context.SaveChanges();

//            return NoContent();
//        }

//        // DELETE: api/DUTValues/DeleteDUTValue/5
//        [HttpDelete("{id}")]
//        public IActionResult DeleteDUTValue(int id)
//        {
//            var dutValue = _context.DUTValues.Find(id);
//            if (dutValue == null)
//            {
//                return NotFound();
//            }

//            _context.DUTValues.Remove(dutValue);
//            _context.SaveChanges();

//            return NoContent();
//        }


//    }
//}

namespace DUT_Values.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DUTValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public DUTValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDUTValues()
        {
            var dutValues = _context.DUTValues.ToList();
            if (dutValues.Count > 0)
            {
                return Ok(dutValues);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetDUTValue(int id)
        {
            var dutValue = _context.DUTValues.Find(id);
            if (dutValue != null)
            {
                return Ok(dutValue);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddDUTValue(DUTValue dUTValue)
        {
            dUTValue.DUTValueId = 0;

            _context.DUTValues.Add(dUTValue);
            _context.SaveChanges();
            return Ok(dUTValue);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDUTValue(int id, DUTValue dUTValue)
        {
            var existingDUTValue = _context.DUTValues.Find(id);
            if (existingDUTValue != null)
            {
                existingDUTValue.DUTValueName = dUTValue.DUTValueName;
                _context.SaveChanges();
                return Ok(existingDUTValue);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDUTValue(int id)
        {
            var dutValue = _context.DUTValues.Find(id);
            if (dutValue != null)
            {
                _context.DUTValues.Remove(dutValue);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
    }
}
