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
    public class ProvincesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Provinces
        public IQueryable<Province> GetProvince()
        {
            return db.Province;
        }

        // GET: api/Provinces/5
        [ResponseType(typeof(Province))]
        public IHttpActionResult GetProvince(int id)
        {
            Province province = db.Province.Find(id);
            if (province == null)
            {
                return NotFound();
            }

            return Ok(province);
        }

        // PUT: api/Provinces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProvince(int id, Province province)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != province.ProvinceId)
            {
                return BadRequest();
            }

            db.Entry(province).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinceExists(id))
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

        // POST: api/Provinces
        [ResponseType(typeof(Province))]
        public IHttpActionResult PostProvince(Province province)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Province.Add(province);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = province.ProvinceId }, province);
        }

        // DELETE: api/Provinces/5
        [ResponseType(typeof(Province))]
        public IHttpActionResult DeleteProvince(int id)
        {
            Province province = db.Province.Find(id);
            if (province == null)
            {
                return NotFound();
            }

            db.Province.Remove(province);
            db.SaveChanges();

            return Ok(province);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProvinceExists(int id)
        {
            return db.Province.Count(e => e.ProvinceId == id) > 0;
        }
    }
}