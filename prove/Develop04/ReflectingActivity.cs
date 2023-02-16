class ReflectingActivity : Activity
    {
        private readonly string[] prompts = new string[]
        {
            "Think of a time when you did something really difficult.",
            "Who are people that you have helped this week?",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly string[] questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?"
        };
        
        protected DateTime animTime;
        protected override string _name => "Reflecting Activity";
        protected override string _description => "Think about a happy memory.";

        protected override void GetActivity(DateTime futureTime)
        {
            Random random = new Random();
            int promptIndex = random.Next(prompts.Length);
            string prompt = prompts[promptIndex];
            animTime = DateTime.Now.AddSeconds(2);
            PlayAnim(animTime);
            Console.WriteLine($"Prompt: {prompt}");
            
            while (DateTime.Now < futureTime)
            {   
                animTime = DateTime.Now.AddSeconds(5);
                PlayAnim(animTime);
                random = new Random();
                int questionsIndex = random.Next(questions.Length);
                string question = questions[questionsIndex];
                Console.WriteLine($"Question: {question}");
            }
        }
    }