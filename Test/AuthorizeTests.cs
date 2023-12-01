using ShopifySharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyAutoPoster.Test
{
    public class AuthorizeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Authorize website with Shopify API
        /// </summary>
        [Test]
        public async Task AuthorizeWebsiteWithShopify()
        {
            string url = "vapestraight.com";
            //https://quickstart-ea1491b6.myshopify.com/

            if (await AuthorizationService.IsValidShopDomainAsync(url))
            {

            }

            Assert.Pass();
        }
    }
}
