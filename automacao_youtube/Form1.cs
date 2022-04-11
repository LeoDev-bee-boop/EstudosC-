using AutomacaoYouTube.Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automacao_youtube
{
    public partial class formYouTube : Form
    {
        public formYouTube()
        {
            InitializeComponent();
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                /*
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl("https://www.google.com/ncr");
                //driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);
                wait.Until(webDriver => webDriver.FindElement(By.CssSelector("h3")).Displayed);
                IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));
                Console.WriteLine(firstResult.GetAttribute("textContent"));
                */
                WebDriverWait _wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                List<Video> listaVideos = new List<Video>();
                Video video = new Video();
                //espera em até 10 segunc
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                //=================================================================================
                //navega até a página do youtube
                driver.Navigate().GoToUrl("https://www.youtube.com/");

                //clica no primeiro vídeo
                _wait.Until(d => d.FindElement(By.Id("meta")));

                driver.FindElement(By.XPath("//*[@id='video-title']")).Click();

                //captura o título e URL do vídeo
                IWebElement element = driver.FindElement(By.XPath("//*[@id='container']/h1/yt-formatted-string"));

                video.Titulo = element.Text;
                video.URL = driver.Url;

                driver.Navigate().Back();

                listaVideos.Add(video);

                //Salva título do vídeo
                adicionarVideoGrid(listaVideos);
                
            }
        }

        private void adicionarVideoGrid(List<Video> videos)
        {
            dgvVideo.DataSource = videos;
        }

        private List<Video> navegation(IWebDriver driver, List<Video> listaVideos)
        {
            for (int i = 0; i < 4; i++)
            {
                
            }

            return listaVideos;
        }

        private void formYouTube_Load(object sender, EventArgs e)
        {

        }
    }
}
