using System.Security.Cryptography.X509Certificates;

namespace BigMammaPizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                MainSettings settings = new MainSettings();
                while (!settings.CloseMenu)
                {
                    settings.SettingsMainMenu();
                }
            //}

        }
    }
}
