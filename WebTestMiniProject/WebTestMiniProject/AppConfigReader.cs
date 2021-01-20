using System.Configuration;

namespace WebTestProject
{
    public class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];

        public static readonly string CartUrl = ConfigurationManager.AppSettings["cart_url"];
        public static readonly string CheckoutUrl1 = ConfigurationManager.AppSettings["checkout_url_1"];
        public static readonly string CheckoutUrl2 = ConfigurationManager.AppSettings["checkout_url_2"];

        public static readonly string YourInfoUrl = ConfigurationManager.AppSettings["yourinfo_url"];

    }
}
