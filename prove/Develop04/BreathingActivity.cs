class BreathingActivity : Activity
    {
        protected DateTime _animTime;
        protected override string _name => "Breathing Activity";
        protected override string _description => "Take a few deep breaths and relax.";

        protected override void GetActivity(DateTime futureTime)
        {
            
            while (DateTime.Now < futureTime)
            {
                
                Console.WriteLine("Breathe in...");
                _animTime = DateTime.Now.AddSeconds(6);
                PlayAnim(_animTime);
                
                Console.WriteLine("Breathe out...");
                _animTime = DateTime.Now.AddSeconds(8);
                PlayAnim(_animTime);  
                  
            }
        }
    }