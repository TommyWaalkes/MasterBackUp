using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APICreationBreakout.Models;

namespace APICreationBreakout.Controllers
{
    public class NintendoCharactersController : ApiController
    {
        private NintendoContext db = new NintendoContext();

        // GET: api/NintendoCharacters
        public IQueryable<NintendoCharacters> GetNintendoCharacters()
        {
            return db.NintendoCharacters;
        }

        // GET: api/NintendoCharacters/5
        [ResponseType(typeof(NintendoCharacters))]
        public IHttpActionResult GetNintendoCharacters(int id)
        {
            NintendoCharacters nintendoCharacters = db.NintendoCharacters.Find(id);
            if (nintendoCharacters == null)
            {
                return NotFound();
            }

            return Ok(nintendoCharacters);
        }

        // PUT: api/NintendoCharacters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNintendoCharacters(int id, NintendoCharacters nintendoCharacters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nintendoCharacters.ID)
            {
                return BadRequest();
            }

            db.Entry(nintendoCharacters).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NintendoCharactersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/NintendoCharacters
        [ResponseType(typeof(NintendoCharacters))]
        public IHttpActionResult PostNintendoCharacters(NintendoCharacters nintendoCharacters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NintendoCharacters.Add(nintendoCharacters);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = nintendoCharacters.ID }, nintendoCharacters);
        }

        // DELETE: api/NintendoCharacters/5
        [ResponseType(typeof(NintendoCharacters))]
        public IHttpActionResult DeleteNintendoCharacters(int id)
        {
            NintendoCharacters nintendoCharacters = db.NintendoCharacters.Find(id);
            if (nintendoCharacters == null)
            {
                return NotFound();
            }

            db.NintendoCharacters.Remove(nintendoCharacters);
            db.SaveChanges();

            return Ok(nintendoCharacters);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NintendoCharactersExists(int id)
        {
            return db.NintendoCharacters.Count(e => e.ID == id) > 0;
        }
    }
}