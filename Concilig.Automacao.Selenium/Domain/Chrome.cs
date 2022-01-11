using Concilig.Automacao.Selenium.Infra;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concilig.Automacao.Selenium.Domain
{
    public class Chrome : WebBrowserBase
    {
        public Chrome(Interface @interface, bool isAdministrator = true, string downloadPath = "", bool configurePrinter = false)
        {
            if (isAdministrator)
                foreach (var process in Process.GetProcessesByName("Chrome").Union(Process.GetProcessesByName("geckodriver")).ToList())
                    if (process.HasExited == false)
                        process.Kill();

            var optionsFF = new ChromeOptions();
            var driverService = ChromeDriverService.CreateDefaultService();

            if (configurePrinter)
            {
                optionsFF.AddArgument("--kiosk --kiosk-printing");
                optionsFF.AddUserProfilePreference("printing.default_destination_selection_rules", "{\"kind\": \"local\", \"namePattern\": \"Save as PDF\"}");
                optionsFF.AddUserProfilePreference("printing.print_preview_sticky_settings.appState", "{\"recentDestinations\": [{\"id\": \"Save as PDF\", \"origin\": \"local\", \"account\": \"\"}],\"version\":2,\"isGcpPromoDismissed\":false,\"selectedDestinationId\":\"Save as PDF\"}");
                optionsFF.AddUserProfilePreference("print.always_print_silent", true);
            }

            if (@interface == Interface.NoUserInterface)
            {
                optionsFF.AddArgument("--headless");
                driverService.HideCommandPromptWindow = true;
            }

            if (@interface == Interface.OnlyBrowser)
                driverService.HideCommandPromptWindow = true;

            if (!string.IsNullOrEmpty(downloadPath))
            {
                DownloadPath = downloadPath;                                                
                optionsFF.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);
                optionsFF.AddUserProfilePreference("savefile.default_directory", downloadPath);
                optionsFF.AddUserProfilePreference("download.default_directory", downloadPath);
                optionsFF.AddUserProfilePreference("download.prompt_for_download", false);
            }

            Driver = new ChromeDriver(driverService, optionsFF);
        }
    }
}