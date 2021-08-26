using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_step_94_ProcessAppDomain_ProcessManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fun with Processes ===\n");
            ListAllRunningProcess();
            GetSpecificProcess();

            Console.WriteLine("=== Enter PID of process to investigate ===");
            Console.Write("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);
            EnumThreadsForPid(theProcID);
            EnumTheModulName(theProcID);
            //StartAndKillProcces();

            Console.ReadLine();
        }

        static void ListAllRunningProcess()
        {
            var runningProcs = from proc in Process.GetProcesses() where proc.Responding == true orderby proc.ProcessName select proc;

            foreach (var p in runningProcs)
            {
                string infoProcs = $"-> PID: {p.Id}\t Name: {p.ProcessName}\t";
                Console.WriteLine(infoProcs);
            }

            Console.WriteLine("=========================================================\n");
        }

        static void GetSpecificProcess()
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(987);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("=========================================================\n");

        }

        static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"Here are the threads used by: {theProc.ProcessName}");

            ProcessThreadCollection theThreads = theProc.Threads;

            foreach (ProcessThread t in theThreads)
            {
                try
                {
                    string info = $"-> Thread ID: {t.Id}\tPriorityLevel: {t.PriorityLevel}\tStartTime: {t.StartTime.ToShortDateString()}";
                    Console.WriteLine(info);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            Console.WriteLine("=========================================================\n");
        }

        static void EnumTheModulName(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.InnerException);
                return;
            }

            Console.WriteLine($"Here are the moduls used by: {theProc.ProcessName}");

            ProcessModuleCollection theMods = theProc.Modules;
            foreach (ProcessModule pm in theMods)
            {
                string info = $"-> Modules Name: {pm.ModuleName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("=========================================================\n");
        }

        static void StartAndKillProcces()
        {
            Process oProc = null;
            try
            {
                oProc = Process.Start("opera.exe", "google.com");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Hit enter to kill process: {oProc.ProcessName}");
            Console.ReadLine();
            try
            {
                oProc.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
