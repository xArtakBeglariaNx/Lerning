using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_113_ASync_FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fun With Async");
            //List<int> l = default;
            //Console.WriteLine(DoWork());            
            string message = await DoWorkAsync();
            Console.WriteLine(message);
            Console.WriteLine(DoWorkAsync().Result);
            await MethodReturningVoidAsync();
            await MultiAsync();
            //await MethodWithTryCatch();
            await MethodWithProblems(7, -5);
            Console.WriteLine("==============");
            await MethodWithProblemsFixed(-7, -5);
            Console.WriteLine("Completed");
            Console.ReadLine();

        }

        static string DoWork()
        {
            Thread.Sleep(2_000);
            return "Done with work!";
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2_000);
                return "Done with work in Async";
            });
        }

        static async Task MethodReturningVoidAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1_000);
            });

            Console.WriteLine("Void method completed");
        }

        static async Task MultiAsync()
        {
            await Task.Run(() => { Thread.Sleep(1_100); });
            Console.WriteLine("Done With 1st Task");

            await Task.Run(() => { Thread.Sleep(1_100); });
            Console.WriteLine("Done With 2nd Task");

            await Task.Run(() => { Thread.Sleep(1_000); });
            Console.WriteLine("Done with 3nd Task");
        }

        static async Task<string> MethodWithTryCatch()
        {
            try
            {
                return $"Hello {DateTime.Now}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await LogTheErrors();
                throw;
            }
            finally
            {
                await DoMagicCleanUp();
            }
        }

        private static Task DoMagicCleanUp()
        {
            throw new NotImplementedException();
        }

        private static Task LogTheErrors()
        {
            throw new NotImplementedException();
        }

        static async Task MethodWithProblems(int firstParam, int secondParam)
        {
            Console.WriteLine("enter");
            await Task.Run(() =>
            {
                Thread.Sleep(4_000);
                Console.WriteLine("1st Complete");

                Console.WriteLine("Somthing bad happend");
            });
        }

        static async Task MethodWithProblemsFixed(int firstParam, int secondParam)
        {
            if (firstParam < 0)
            {
                Console.WriteLine("Bad data");
                return;
            }
            await actualImplementation();
            async Task actualImplementation()
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(4_000);
                    Console.WriteLine("1st Complete");

                    Console.WriteLine("Somthing bad happend");
                });
            }
        }

        static async ValueTask<int> ReturnAnInt()
        {
            await Task.Delay(1_000);
            return 5;
        }
    }
}
