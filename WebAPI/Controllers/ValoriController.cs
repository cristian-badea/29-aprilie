using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ValoriController : ApiController
    {
        static List<string> valori = new List<string>() { "valoare 1", "valoare 2" };




        // GET: api/Valori
        public IEnumerable<string> Get()
        {
            return valori;
        }

        // GET: api/Valori/5
        public string Get(int id)
        {
            if (id > valori.Count - 1)
            {
                var raspuns = new HttpResponseMessage();
                raspuns.StatusCode = HttpStatusCode.NotFound;
                raspuns.Content = new StringContent("Elementul nu exista in lista");
                throw new HttpResponseException(raspuns);
            }
            
                return valori[id];
            
        }

        // POST: api/Valori
        public void Post([FromBody]string value)
        {
        
            valori.Add(value);
        }

        // PUT: api/Valori/5
        public void Put(int id, [FromBody]string value)
        {
            valori[id] = value;
        }

        // DELETE: api/Valori/5
        public void Delete(int id)
        {
            valori.RemoveAt(id);
        }
    }
}
