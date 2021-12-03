using System;
using System.Collections.Generic;
using System.Linq;
using OOP_step_130_WCF_MagicEightBallServiceClient.ServiceReference1;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_130_WCF_MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ask the Magic 8 ball ---");

            using (EightBallClient ball = new EightBallClient())
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine($"EightBall says: {answer}");
            }
            Console.ReadLine();
        }
    }
}
