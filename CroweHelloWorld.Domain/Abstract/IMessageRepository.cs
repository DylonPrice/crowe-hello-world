using System;
using System.Collections.Generic;
using System.Text;

namespace CroweHelloWorld.Domain.Abstract
{
    public interface IMessageRepository
    {
        void SaveMessage(string message);
    }
}
