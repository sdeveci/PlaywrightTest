using Microsoft.Playwright;

namespace PlayWrightExample
{
    [TestClass]
    public class PlaywrightTest
    {
       
       
        [TestMethod]
        public async Task GoogleTitleTest()
        {           
            var playwright = await Playwright.CreateAsync();

            // Chromium'u başlatın (Playwright otomatik olarak global olarak yüklenmiş Chromium'u kullanacaktır)
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true // Headless modda çalıştırmak için true yapabilirsiniz. (headless mod browser açmadan arka tarafta çalışacaktır.)
            });
         
            var page = await browser.NewPageAsync();

            // Gideceğimiz adresi belirliyoruz.
            await page.GotoAsync("https://www.google.com");

            // Bu komutla Adresten sayfa başlığı alınır.
            var title = await page.TitleAsync();

            Console.WriteLine($"Page title: {title}");

            // Tarayıcıyı kapatın
            await browser.CloseAsync();
        }

    }
}