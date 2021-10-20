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
using RestAPI.Models;

namespace RestAPI.Controllers
{
    public class DemandesController : ApiController
    {
        private EmailsDBEntities4 db = new EmailsDBEntities4();

        // GET: api/Demandes
        public IQueryable<Demande> GetDemandes()
        {
            return db.Demandes;
        }

        // GET: api/Demandes/5
        // [ResponseType(typeof(Demande))]
        public Demande GetDemande(int id)
        {
            Demande demande = db.Demandes.Find(id);

            demande.Salary = null;

            //if (demande == null)
            //{
            //    return NotFound();
            //}

            //return Ok(demande);

            return demande;
        }

        // PUT: api/Demandes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDemande(int id, Demande demande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != demande.Id)
            {
                return BadRequest();
            }

            db.Entry(demande).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DemandeExists(id))
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

        // POST: api/Demandes
        [ResponseType(typeof(Demande))]
        public IHttpActionResult PostDemande(Demande demande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Demandes.Add(demande);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = demande.Id }, demande);
        }

        // DELETE: api/Demandes/5
        [ResponseType(typeof(Demande))]
        public IHttpActionResult DeleteDemande(int id)
        {
            Demande demande = db.Demandes.Find(id);
            if (demande == null)
            {
                return NotFound();
            }

            db.Demandes.Remove(demande);
            db.SaveChanges();

            return Ok(demande);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DemandeExists(int id)
        {
            return db.Demandes.Count(e => e.Id == id) > 0;
        }
    }
}