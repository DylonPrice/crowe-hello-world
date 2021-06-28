using CroweHelloWorld.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CroweHelloWorld.Domain.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        public void SaveMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
