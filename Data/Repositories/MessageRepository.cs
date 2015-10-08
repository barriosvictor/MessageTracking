using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data.Repositories
{
    public class MessageRepository
    {
        public bool add(Message message) {
            using (MessageTrackingDBEntities db = new MessageTrackingDBEntities())
            {
                db.Message.Add(message);
                db.SaveChanges();
                return true;
            } 
        }

        public IEnumerable<Message> get(int consumerID) {
            using (MessageTrackingDBEntities db = new MessageTrackingDBEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                IEnumerable<Message> query = (from n in db.Message where n.ConsumerId == consumerID select n).ToList();
                return query;
            }
        }

    }
}
