using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bunkong.WorkLogs.Database.MySql;
using Bunkong.WorkLogs.Database.Schema;

namespace Bunkong.WorkLogs.API.MYSQL.Controllers
{
    [Produces("application/json")]
    [Route("api/WorkLogs")]
    public class WorkLogsController : Controller
    {
        private readonly IDMySqlDbContext db;

        public WorkLogsController(IDMySqlDbContext db)
        {
            this.db = db;
        }

        //// GET: api/WorkLogs
        //[HttpGet]
        //public IEnumerable<WorkLog> GetWorkLogs()
        //{
        //    return db.WorkLogs;
        //}

        // GET: api/WorkLogs
        [HttpGet]
        public async Task<IActionResult> GetWorkLogs()
        {
            var logs = await db.WorkLogs.OrderBy(o => o.WorkDate).ToListAsync();
            return Ok(logs);
        }

        // GET: api/WorkLogs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkLog([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var workLog = await db.WorkLogs.SingleOrDefaultAsync(m => m.Id == id);

            if (workLog == null)
            {
                return NotFound();
            }

            return Ok(workLog);
        }

        // PUT: api/WorkLogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkLog([FromRoute] string id, [FromBody] WorkLog workLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != workLog.Id)
            {
                return BadRequest();
            }

            db.Entry(workLog).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkLogExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WorkLogs
        [HttpPost]
        public async Task<IActionResult> PostWorkLog([FromBody] WorkLog workLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WorkLogs.Add(workLog);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetWorkLog", new { id = workLog.Id }, workLog);
        }

        // DELETE: api/WorkLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkLog([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var workLog = await db.WorkLogs.SingleOrDefaultAsync(m => m.Id == id);
            if (workLog == null)
            {
                return NotFound();
            }

            db.WorkLogs.Remove(workLog);
            await db.SaveChangesAsync();

            return Ok(workLog);
        }

        private bool WorkLogExists(string id)
        {
            return db.WorkLogs.Any(e => e.Id == id);
        }
    }
}