using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_130_WCF_MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question...");
        }

        public string ObuainAnswerToQuestion(string userQuestion)
        {
            string[] answers = { "Yes", "No", "Future Certain", "Hazy", "Ask again later", "Definitely"};

            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
