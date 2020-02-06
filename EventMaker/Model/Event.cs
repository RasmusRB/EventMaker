using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {
        // instance fields
        private int _id;
        private string _name;
        private string _description;
        private string _place;
        private DateTime _dateTime;

        // constructor
        public Event(int ID, string Name, string Description, string Place, DateTime DateTime)
        {
            _id = ID;
            _name = Name;
            _description = Description;
            _place = Place;
            _dateTime = DateTime;
        }

        // properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }
        public DateTime DateTime
        {
            get { return _dateTime; }
        }

        // tostring() method
        public override string ToString()
        {
            return $"";
        }
    }
}
