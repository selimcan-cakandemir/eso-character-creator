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
    public class ClassesController : ApiController
    {
        ProjectDbContext context = new ProjectDbContext();


        public IEnumerable<CharacterClass> GetCharacterClasses()
        {
            return context.CharacterClasses.ToList();
        }

        public HttpResponseMessage DeleteEmployee(int id)
        {
            try
            {
                var characterClass = context.CharacterClasses.Find(id);
                context.CharacterClasses.Remove(characterClass);
                context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, GetCharacterClasses());
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }

        }

        public HttpResponseMessage PostEmployee([FromBody] CharacterClass characterClass)
        {
            //checks to see if the attributes we have set on the class side are being met, like requirements that the property not be empty
            if (ModelState.IsValid)
            {
                context.CharacterClasses.Add(characterClass);
                context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, characterClass);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "doldurulması zorunlu alanlar mevcut");
            }
        }



        public IHttpActionResult PutCharacterClass(CharacterClass characterClass)
        {
            try
            {
                CharacterClass updated = context.CharacterClasses.Find(characterClass.ClassId);
                context.Entry(updated).CurrentValues.SetValues(characterClass);
                context.SaveChanges();
                return Json(GetCharacterClasses());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
