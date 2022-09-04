using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using SystemEventsClient;

using WorkerEventsHub.SystemEventsClient;

namespace MessageService
{
    public class EventsGroupsController: Controller
    {
        private IEventsGroupsManager manager;

        public EventsGroupsController(IEventsGroupsManager manager)
        {
            this.manager = manager;
        }

        public void AddPublisher(int TopicID)
        {
            throw new NotImplementedException();
        }

        public IActionResult CreateTopic() => View(new AboutEventsTopic());
        public IActionResult CreateTopic(AboutEventsTopic Model)
        {
            if(ModelState.IsValid)
            {
                this.manager.CreateTopic(Model);
                return Redirect("/topics/"+Model.ID);
            }
            else
            {
                return View(Model);
            }
            
        }
    }
    public interface IEventsGroupsManager
    {
        /// <summary>
        /// Добавление подписчика
        /// </summary>
        public void AddPublisher(AboutEventsTopic Info, IEventPublisher Publisher);
        /// <summary>
        /// Добавление нового топика
        /// </summary>
        /// <param name="Info"></param>
        public void CreateTopic(AboutEventsTopic Info);
    }
    public class EventsGroupsManager: IEventsGroupsManager
    {


        /// <summary>
        /// Привязка подписчиков к топикам
        /// </summary>
        public IDictionary<AboutEventsTopic, IEventSubscriber> Subscribers =
            new ConcurrentDictionary<AboutEventsTopic, IEventSubscriber>();

        /// <summary>
        /// Привязка подписчиков к топикам
        /// </summary>
        public IDictionary<AboutEventsTopic, IEventPublisher> Publishers =
            new ConcurrentDictionary<AboutEventsTopic, IEventPublisher>();


        /// <summary>
        /// Добавление подписчика
        /// </summary>
        public void AddPublisher(AboutEventsTopic Info, IEventPublisher Publisher) =>
            Publishers[Info] = Publisher;
        /// <summary>
        /// Добавление нового топика
        /// </summary>
        /// <param name="Info"></param>
        public void CreateTopic(AboutEventsTopic Info)
            => throw new NotImplementedException();


    }
}

 