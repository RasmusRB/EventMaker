using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance;
        private ObservableCollection<Event> _events;

        public static EventCatalogSingleton Instance
        {
            get { return _instance; }
        }
        public EventCatalogSingleton()
        {
            _events = new ObservableCollection<Event>();
        }
        public ObservableCollection<Event> Events
        {
            get { return _events; }
        }
        public void Add()
        {
            _events.Add(Event);
        }
    }
}
