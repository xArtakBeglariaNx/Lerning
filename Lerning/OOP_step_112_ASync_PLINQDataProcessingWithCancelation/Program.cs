using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_112_ASync_PLINQDataProcessingWithCancelation
{
    class Program
    {
        static CancellationTokenSource cancelToken = new CancellationTokenSource();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Statr any key to start processing");
                Console.ReadKey();
                Console.WriteLine("Processing");
                Task.Factory.StartNew(() => ProcessIntData());
                Console.Write("Enter Q to quit: ");
                string answer = Console.ReadLine();

                // Does user want to quit?
                if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    cancelToken.Cancel();
                    break;
                }
            } while (true);

            Console.ReadLine();
        }

        static void ProcessIntData()
        {
            //Get very big array of integers
            int[] source = Enumerable.Range(1, 10_000_000).ToArray();

            // Find the numbers where num % 3 == 0 is true, returned
            // in descending order.
            int[] modThreeIsZero = null;

            #region linq Not a parrallel maner

            //modThreeIsZero = (from num in source 
            //                        where num % 3 == 0 
            //                        orderby num descending select num).ToArray();

            #endregion

            #region linq is Parallel maner

            //modThreeIsZero = (from num in source.AsParallel()
            //                        where num % 3 == 0
            //                        orderby num descending
            //                        select num).ToArray();
            #endregion

            #region linq is Parallel maner with WithCanceletion
            try
            {
                modThreeIsZero = (from num in source.AsParallel().WithCancellation(cancelToken.Token)
                                  where num % 3 == 0
                                  orderby num descending
                                  select num).ToArray();
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            #endregion

            Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query");
        }
    }
}
