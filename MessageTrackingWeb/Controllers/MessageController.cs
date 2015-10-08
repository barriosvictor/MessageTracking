using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessageTrackingWeb.Controllers
{
    public class MessageController : ApiController
    {
        MessageBusiness messageBusiness;
        // GET: api/Message
        public IEnumerable<Message> Get()
        {
            if (messageBusiness == null) { messageBusiness = new MessageBusiness(); }
            return messageBusiness.getNewMessages(1);
        }

        //// GET: api/Message/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Message
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Message/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Message/5
        //public void Delete(int id)
        //{
        //}
    }
}
