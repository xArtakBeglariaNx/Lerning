using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using OOP_step_87_SystemReflection_CommonSnapableTypes;

namespace OOP_step_90_SystemReflection_MyExtendableApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("==== Welcom in My TypeViewer ====\n");

            do
            {
                Console.WriteLine("Whould you like load a snap-in? [Y,N]");
                string answer = Console.ReadLine();
                if (!answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                try
                {
                    LoadSnapIn();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} Sorry can find snapin");
                }
            } while (true);
        }

        static void LoadSnapIn()
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Filter = "assemblies (*.dll)|*.dll|All files(*.*)|(*.*)",
                FilterIndex = 1
            };
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                Console.WriteLine("User canceled out of the open file dialog");
                return;
            }
            if (dlg.FileName.Contains("OOP_step_87_SystemReflection_CommonSnapableTypes"))
            {
                Console.WriteLine("OOP_step_87_SystemReflection_CommonSnapableTypes has no snap-ins!");
            }
            else if (!LoadExternalModule(dlg.FileName))
            {
                Console.WriteLine("Nothing implements IAppFunctionality");
            }
        }

        private static bool LoadExternalModule(string path)
        {
            bool findSnapIn = false;
            Assembly theSnapInAsm = null;

            try
            {
                theSnapInAsm = Assembly.Load(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred loading  the snapin: {ex.Message}");
                return findSnapIn;
            }

            var theClassTypes = from t in theSnapInAsm.GetTypes()
                                where t.IsClass && (t.GetInterface("IAppFunctionality")) != null
                                select t;
            foreach (Type t in theClassTypes)
            {
                findSnapIn = true;
                IAppFunctionality itfApp = (IAppFunctionality)theSnapInAsm.CreateInstance(t.FullName, true);
                itfApp?.DoIt();
                DisplayCompanyData(t);
            }
            return findSnapIn;
        }

        private static void DisplayCompanyData(Type t)
        {
            var companyInfoData = from ci in t.GetCustomAttributes(false)
                                  where (ci is CompanyinfoAttribute)
                                  select ci;
            foreach (CompanyinfoAttribute c in companyInfoData)
            {
                Console.WriteLine($"More info about {c.CompanyName} can be found at {c.CompanyUrl}");
            }
        }
    }
}
