using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerEventsHub.SystemEventsClient
{
    public interface IEventSubscriber
    {

        public void OnMessage(Dictionary<string, string> message);
    }
}
