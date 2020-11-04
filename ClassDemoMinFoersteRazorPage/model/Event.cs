using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassDemoMinFoersteRazorPage.model
{
    public class Event
    {

        private int _id;
        private string _name;
        private string _description;
        private string _city;
        private DateTime _DateTimeOfEvent;


        public Event()
        {
        }

        public Event(int id, string name, string description, string city, DateTime dateTimeOfEvent)
        {
            _id = id;
            _name = name;
            _description = description;
            _city = city;
            _DateTimeOfEvent = dateTimeOfEvent;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public DateTime DateTimeOfEvent
        {
            get => _DateTimeOfEvent;
            set => _DateTimeOfEvent = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(City)}: {City}, {nameof(DateTimeOfEvent)}: {DateTimeOfEvent}";
        }
    }
}
