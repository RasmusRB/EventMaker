using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance = new EventCatalogSingleton();
        private ObservableCollection<Event> _events;

        private EventCatalogSingleton()
        {
            _events = new ObservableCollection<Event>();
        }
        public static EventCatalogSingleton Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Event> Events
        {
            get { return _events; }
        }
        public void Add()
        {
            _events.Add(new Event());
        }
    }
}
