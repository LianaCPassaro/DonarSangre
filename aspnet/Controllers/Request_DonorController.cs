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
using aspnet.Models;

namespace aspnet.Controllers
{
    public class Request_DonorController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Request_Donor
        public IQueryable<Request_Donor> GetRequest_Donor()
        {
            return db.Request_Donor;
        }

        // GET: api/Request_Donor/5
        [ResponseType(typeof(Request_Donor))]
        public IHttpActionResult GetRequest_Donor(int id)
        {
            Request_Donor request_Donor = db.Request_Donor.Find(id);
            if (request_Donor == null)
            {
                return NotFound();
            }

            return Ok(request_Donor);
        }

        // PUT: api/Request_Donor/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRequest_Donor(int id, Request_Donor request_Donor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != request_Donor.RequestDonorId)
            {
                return BadRequest();
            }

            db.Entry(request_Donor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Request_DonorExists(id))
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

        // POST: api/Request_Donor
        [ResponseType(typeof(Request_Donor))]
        public IHttpActionResult PostRequest_Donor(Request_Donor request_Donor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Request_Donor.Add(request_Donor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = request_Donor.RequestDonorId }, request_Donor);
        }

        // DELETE: api/Request_Donor/5
        [ResponseType(typeof(Request_Donor))]
        public IHttpActionResult DeleteRequest_Donor(int id)
        {
            Request_Donor request_Donor = db.Request_Donor.Find(id);
            if (request_Donor == null)
            {
                return NotFound();
            }

            db.Request_Donor.Remove(request_Donor);
            db.SaveChanges();

            return Ok(request_Donor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Request_DonorExists(int id)
        {
            return db.Request_Donor.Count(e => e.RequestDonorId == id) > 0;
        }
    }
}