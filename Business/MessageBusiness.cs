using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Domain;

namespace Business
{
    public class MessageBusiness
    {
        MessageRepository messageRepositoty ;

        public bool saveMessage(Message messageToSave) {
            if (messageRepositoty == null) messageRepositoty = new MessageRepository();
            return messageRepositoty.add(messageToSave);
        }

        public IEnumerable<Message> getNewMessages(int consumerID) {
            if (messageRepositoty == null) messageRepositoty = new MessageRepository();
            return messageRepositoty.get(consumerID);
        }


    }
}
