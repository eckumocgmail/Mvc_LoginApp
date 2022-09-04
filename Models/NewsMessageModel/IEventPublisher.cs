using System.Collections.Generic;
using System.Threading.Tasks;

namespace SystemEventsClient
{
    
    public interface IEventPublisher
    {
        public Task Publish(Dictionary<string, string> message);
    }
     
}
