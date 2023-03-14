class SwimmingActivity : Activity
    {
        private int laps;
        private int duration;

        public SwimmingActivity(string date, int actDuration, int totLaps)
            : base(date, actDuration)
        {
            laps = totLaps;
            duration = actDuration;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000;
        }

        public override double GetSpeed()
        {
            return GetDistance() / duration * 60;
        }

        public override double GetPace()
        {
            return duration / GetDistance();
        }

        public string GetSummaryInMiles()
        {
            double distanceInMiles = GetDistance() * 0.62;
            double speedInMilesPerHour = GetSpeed() * 0.62;
            double paceInMinutesPerMile = GetPace() * 0.62;
            return $"{GetSummary()} - Distance: {distanceInMiles:F1} miles, Speed: {speedInMilesPerHour:F1} mph, Pace: {paceInMinutesPerMile:F1} min/mile";
        }
    }