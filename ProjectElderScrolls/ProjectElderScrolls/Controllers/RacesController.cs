using ProjectElderScrolls.Models;
using ProjectElderScrolls.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectElderScrolls.Controllers
{
    public class RacesController : ApiController
    {
        ProjectDbContext context = new ProjectDbContext();


        public IEnumerable<CharacterRace> GetCharacterRaces()
        {
            return context.CharacterRaces.ToList();
        }

        public HttpResponseMessage DeleteRace(int id)
        {
            try
            {
                var characterRace = context.CharacterRaces.Find(id);
                context.CharacterRaces.Remove(characterRace);
                context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, GetCharacterRaces());
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }

        }

        public HttpResponseMessage PostRace([FromBody] CharacterRace characterRace)
        {
            //checks to see if the attributes we have set on the class side are being met, like requirements that the property not be empty
            if (ModelState.IsValid)
            {
                context.CharacterRaces.Add(characterRace);
                context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, characterRace);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "doldurulması zorunlu alanlar mevcut");
            }
        }



        public IHttpActionResult PutCharacterRace(CharacterRace characterRace)
        {
            try
            {
                CharacterRace updated = context.CharacterRaces.Find(characterRace.RaceId);
                context.Entry(updated).CurrentValues.SetValues(characterRace);
                context.SaveChanges();
                return Json(GetCharacterRaces());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
