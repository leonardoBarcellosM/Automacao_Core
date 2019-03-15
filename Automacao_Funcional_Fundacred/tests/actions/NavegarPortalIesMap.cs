using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class NavegarPortalIesMap
    {
        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[1]/*[text()][2]")]
        [CacheLookup]
        public IWebElement OptSolicitacoesIniciadas { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[2]/*[text()][3]")]
        [CacheLookup]
        public IWebElement OptReprovadosFundacred { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[4]/*[text()][3]")]
        [CacheLookup]
        public IWebElement OptPendenteAnalisefundacred { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[5]/*[text()][2]")]
        [CacheLookup]
        public IWebElement OptPendenteAnaliseIes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[6]/*[text()][3]")]
        [CacheLookup]
        public IWebElement OptReprovadosIEs { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[8]/*[text()][2]")]
        [CacheLookup]
        public IWebElement OptAprovados { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/ul/li[1]/a")]
        [CacheLookup]
        public IWebElement OptDashboard { get; set; }
        
    }
}
