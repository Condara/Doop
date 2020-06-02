using System;
using DOOP_LV5_Čondić.Most;
using DOOP_LV5_Čondić.Proxy;

namespace DOOP_LV5_Čondić
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "proxy.csv";

            Dataset dataset = new Dataset(filepath);

            ProtectionProxyDataset protProxy = new ProtectionProxyDataset(User.GenerateUser("User123"));
            VirtualProxyDataset virtProxy = new VirtualProxyDataset(filepath);

            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(dataset);
            printer.Print(protProxy);
            printer.Print(virtProxy);
            printer.Print(protProxy);
            printer.Print(protProxy);
            ReminderNote note1 = new ReminderNote("1. poruka, LighTheme", new LightTheme());
            ReminderNote note2 = new ReminderNote("2. poruka, PersonalTheme", new PersonalTheme());
            note1.Show();
            note2.Show();
        }
    }
}
