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
            #region TCP connection
            using (EightBallClient ball = new EightBallClient("NetTcpBinding_IEightBall"))
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine($"EightBall says: {answer}");
            }
            #endregion

            #region Http Connection
            using (EightBallClient ball = new EightBallClient("BasicHttpBinding_IEightBall"))
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine($"EightBall says: {answer}");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
