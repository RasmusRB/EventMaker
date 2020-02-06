using EventMaker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        private EventCatalogSingleton _shared;
    
        public EventViewModel()
        {
            // _shared = new EventCatalogSingleton.Instance;
        }

        public EventCatalogSingleton Shared
        {
            get { return _shared; }
        }
    }
}
