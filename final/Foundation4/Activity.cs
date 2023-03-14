abstract class Activity
    {
        private string date;
        private int duration;

        public Activity(string curDate, int actDuration)
        {
            date = curDate;
            duration = actDuration;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{date:d} {GetType().Name} ({duration} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} km/h, Pace: {GetPace():F1} min/km";
        }
    }