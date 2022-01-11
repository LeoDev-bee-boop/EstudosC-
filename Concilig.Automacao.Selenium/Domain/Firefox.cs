using Concilig.Automacao.Selenium.Infra;
using OpenQA.Selenium.Firefox;
using System;
using System.Diagnostics;
using System.Linq;

namespace Concilig.Automacao.Selenium.Domain
{
    public class Firefox : WebBrowserBase
    {
        public Firefox(Interface @interface, bool isAdministrator = true, string downloadPath = "")
        {
            if (isAdministrator)
                foreach (var process in Process.GetProcessesByName("Firefox").Union(Process.GetProcessesByName("geckodriver")).ToList())
                    if (process.HasExited == false)
                        process.Kill();

            var optionsFF = new FirefoxOptions();
            optionsFF.Profile = new FirefoxProfile();
            var driverService = FirefoxDriverService.CreateDefaultService();

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

                // Permitir download sem pop-up de confirmação
                optionsFF.Profile.SetPreference("browser.helperApps.alwaysAsk.force", false);
                optionsFF.Profile.SetPreference("browser.helperApps.neverAsk.openFile", "application/download");
                optionsFF.Profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/download");

                // Configurar caminho de destino de download
                optionsFF.Profile.SetPreference("browser.download.folderList", 2);
                optionsFF.Profile.SetPreference("browser.download.dir", downloadPath);
            }

            Driver = new FirefoxDriver(driverService, optionsFF, TimeSpan.FromSeconds(180));
        }
    }
}