namespace Emmy.self_ui
{
    public class Event
    {
        private string _eventType;

        public string EventType
        {
            get { return this._eventType; }
        }
        
        public Event(string eventType)
        {
            this._eventType = eventType;
        }
    }
}