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
using buildacomputer.Models;

namespace buildacomputer.Controllers
{
    public class BuildController : ApiController
    {
        private PartsAndUsersContext db = new PartsAndUsersContext();

        // GET: api/Build
        public IQueryable<Build> GetBuild()
        {
            return db.Build;
        }

        // GET: api/Build/5
        [ResponseType(typeof(Build))]
        public IHttpActionResult GetBuild(long id)
        {
            Build build = db.Build.Find(id);
            if (build == null)
            {
                return NotFound();
            }

            return Ok(build);
        }

        // PUT: api/Build/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBuild(long id, Build build)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != build.buildID)
            {
                return BadRequest();
            }

            db.Entry(build).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildExists(id))
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

        // POST: api/Build
        [ResponseType(typeof(Build))]
        public IHttpActionResult PostBuild(Build build)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Build.Add(build);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = build.buildID }, build);
        }

        // DELETE: api/Build/5
        [ResponseType(typeof(Build))]
        public IHttpActionResult DeleteBuild(long id)
        {
            Build build = db.Build.Find(id);
            if (build == null)
            {
                return NotFound();
            }

            db.Build.Remove(build);
            db.SaveChanges();

            return Ok(build);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BuildExists(long id)
        {
            return db.Build.Count(e => e.buildID == id) > 0;
        }
    }
}