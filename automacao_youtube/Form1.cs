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
                WebDriverWait _wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                List<Video> listaVideos = new List<Video>();
                Video video = new Video();
                IWebElement element;
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                
                //navega até a página do youtube
                driver.Navigate().GoToUrl("https://www.youtube.com/");

                

                //Capturando o título do vídeo dinâmicamente
                for (int i = 1; i <= 4; i++)
                {
                    string xpathColuna = @"/html/body/ytd-app/div[1]/ytd-page-manager/ytd-browse/
                                            ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/
                                            div[6]/ytd-rich-grid-row[1]/div/ytd-rich-item-renderer[" + i + "]/div/" +
                                            "ytd-rich-grid-media/div[1]/div[2]/div[1]/h3/a/yt-formatted-string";
                    //Clica no vídeo
                    driver.FindElement(By.XPath(xpathColuna)).Click();

                    //_wait.Until(d => d.FindElement(By.XPath(xpathColuna)));
                    string tituliVideo = "//*[@id='container']/h1/yt-formatted-string";


                    element = driver.FindElement(By.XPath(tituliVideo));

                    
                    video.Titulo = element.Text;
                    video.URL = driver.Url;

                    driver.Navigate().Back();

                    listaVideos.Add(video);
                }



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
