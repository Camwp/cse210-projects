class CyclingActivity : Activity
    {
        private double speed;
        private int duration;
        public CyclingActivity(string date, int actDuration, double cycSpeed)
            : base(date, actDuration)
        {
            speed = cycSpeed;
            duration = actDuration;
        }

        public override double GetDistance()
        {
            return speed * duration / 60;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / speed;
        }
    }