using Microsoft.AspNetCore.Mvc;
using RESTMusic.Models;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private IRecordsRepository repo;


        public RecordsController(IRecordsRepository repo)
        {
            this.repo = repo;
        }


        // GET: api/<PlayersController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<Record>> Get()
        {
            IEnumerable<Record> records = repo.GetAll();

            if (!records.Any())
            {
                return NoContent();
            }

            return Ok(records);
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Record> Get(int id)
        {
            Record? record = repo.GetRecordById(id);

            if (record is null)
            {
                return NotFound();
            }

            return Ok(record);
        }

        // POST api/<PlayersController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Record> Post([FromBody] Record value)
        {
            Record addedRecord = repo.AddRecord(value);

            return CreatedAtAction(
                nameof(Get),
                new { id = addedRecord.Id },
                addedRecord);
        }

        // PUT api/<PlayersController>/5

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Record> Put(int id, [FromBody] Record value)
        {
            Record? updatedRecord = repo.UpdateById(id, value);

            if (updatedRecord is null)
            {
                return NotFound();
            }

            return Ok(updatedRecord);
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Record> Delete(int id)
        {
            Record? deletedRecord = repo.DeleteById(id);

            if (deletedRecord is null)
            {
                return NotFound();
            }

            return Ok(deletedRecord);
        }
    }
}
