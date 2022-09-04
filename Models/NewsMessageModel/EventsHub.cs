using MessageService;

using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WorkerEventsHub.SystemEventsClient;
 

/// <summary>
/// Тематическая рассылка сообщений
/// </summary>
public class EventsHub : Hub
{



    private readonly ILogger<EventsHub> _logger;

    /// <summary>
    /// 
    /// </summary>        
    public EventsHub(ILogger<EventsHub> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 
    /// </summary>        
    public async Task Publish(string evt)
    {
        _logger.LogInformation($"Public(message)");
        Dictionary<string, object> message = null;
        try
        {
                     message =
            JsonConvert.DeserializeObject<Dictionary<string, object>>(evt?.ToString());
        }
        finally
        {
            _logger.LogInformation($"Broadcast({JsonConvert.SerializeObject(message)})");
            await Clients.All.SendAsync("OnMessage", message);
        }
            

    }

    public override async Task OnConnectedAsync()
    {
        _logger.LogInformation($"OnConnectedAsync({Context.ConnectionId})");
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        _logger.LogInformation($"OnDisconnectedAsync({(exception != null ? exception.Message : "")})");
        await base.OnDisconnectedAsync(exception);
    }
}
 