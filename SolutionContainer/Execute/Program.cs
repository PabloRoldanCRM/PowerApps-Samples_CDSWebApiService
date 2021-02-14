using PowerApps.Samples;
using System;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly string Url = "https://contoso.crm.dynamics.com";
        private static readonly string ClientId = "00000000-0000-0000-0000-000000000001";
        private static readonly string UserName = "USER@contoso.onmicrosoft.com";
        private static readonly string Password = "YOUR_PASSWORD";
        static void Main(string[] args)
        {

            Console.WriteLine("CDS Connection tool Test");
            ServiceConfig serviceConfig = new ServiceConfig(GetConnectionString());
            CDSWebApiService webApiService = new CDSWebApiService(serviceConfig);
            webApiService.PostCreate("accounts", new AccountDTO() { name = "Create from C# console" });
            Console.WriteLine("!All Done press any key...");
            Console.ReadKey();
        }

        private static string GetConnectionString() {
            return $"Url={Url};ClientId={ClientId};RedirectUrl=localhost;Authority=null;UserPrincipalName={UserName};Password={Password};Version=9.0;";
        }
    }
}
