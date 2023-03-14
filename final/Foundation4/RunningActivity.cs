class RunningActivity : Activity
    {
        private double distance;
        private int duration;

        public RunningActivity(string date, int actDuration, double runDistance)
            : base(date, actDuration)
        {
            distance = runDistance;
            duration = actDuration;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / duration * 60;
        }

        public override double GetPace()
        {
            return duration / distance;
        }
    }