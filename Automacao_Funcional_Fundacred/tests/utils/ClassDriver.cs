using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Automacao_Funcional.tests.steps
{
    class ClassDriver
    {
        private static ClassDriver classDriver;
        private IWebDriver driver;


        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        private ClassDriver()
        {

        }

        public static ClassDriver GetInstance()
        {
            if (classDriver == null)
            {
                classDriver = new ClassDriver();
            }
            return classDriver;
        }

        public void StartDriver(string typeBrowser)
        {
            //string path = @"C:\Users\leonardo.barcellos\source\repos\Automacao_Funcional_Fundacred\Automacao_Funcional\Driver\chromedriver_win32";
            string path = @"C:\Driver\chromedriver_win32";

            switch (typeBrowser)
            {
                case "C":
                    Driver = new ChromeDriver(path);
                    break;

                case "I":
                    Driver = new InternetExplorerDriver();
                    break;

                case "F":                                     
                    Driver = new FirefoxDriver();
                    break;

                case "E":
                    Driver = new EdgeDriver();
                    break;

                case "H":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments(path, "--whitelist - ip %", "--window-size=1800,2000", "--headless", "--disable-gpu", "--no-sandbox");
                    driver = new ChromeDriver(path, options);
                    break;

                default:
                    Driver = new ChromeDriver(path);
                    break;
            }

            Driver.Manage().Window.Maximize();
        }

        public void QuitDriver()
        {
            Driver.Quit();
        }
    }
}
