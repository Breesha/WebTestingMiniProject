using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WebTestProject
{
    public class SD_SingleItemDescriptionPage
    {
        private IWebDriver _seleniumDriver;
        private string HomePageURL = AppConfigReader.BaseUrl;
        private List <IWebElement> _inventoryItems => _seleniumDriver.FindElements(By.ClassName("inventory_item")).ToList();
        private IWebElement _inventoryDetailsBackButton => _seleniumDriver.FindElement(By.ClassName("inventory_details_back_button"));
        private IWebElement _inventoryCartButton => _seleniumDriver.FindElement(By.ClassName("btn_inventory"));
        private IWebElement _inventoryCartItemBudge => _seleniumDriver.FindElement(By.Id("shopping_cart_container"))
                                                                        .FindElement(By.TagName("a"))
                                                                        .FindElement(By.TagName("span"));

        public int GetCartCounter()
        {
             try
            {
                return int.Parse(_inventoryCartItemBudge.Text);
            }
            catch
            {
                return 0;
            }
            
        }
        public SD_SingleItemDescriptionPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(HomePageURL);
        }

        public void ClickCartButton()
        {
            _inventoryCartButton.Click();
        }

        public string GetInventoryCartButtnText()
        {
            return _inventoryCartButton.Text;
        }
        public void VisitSingleItemDetailsPage(string id)
        {

            var inventoryItem =_inventoryItems.Where(item => item.FindElement(By.ClassName("inventory_item_label"))
            .FindElement(By.TagName("a"))
            .GetAttribute("id") == id)
            .FirstOrDefault();

            inventoryItem.FindElement(By.ClassName("inventory_item_label")).FindElement(By.TagName("a")).Click();
        }
        public void GoToProductsList()
        {
            _inventoryDetailsBackButton.Click();
        }
        public string GetCurrentPagesURL()
        {
            return _seleniumDriver.Url;
        }
    }
}
