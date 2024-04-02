using Microsoft.Playwright;

namespace PlayWrightExample
{
    [TestClass]
    public class PlaywrightTest
    {
       
       
        [TestMethod]
        public async Task GoogleTitleTest()
        {
            // Playwright'ı yükleyin
            var playwright = await Playwright.CreateAsync();

            // Chromium'u başlatın (Playwright otomatik olarak global olarak yüklenmiş Chromium'u kullanacaktır)
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true // Headless modda çalıştırmak için true yapabilirsiniz
            });

            // Yeni bir sayfa oluşturun
            var page = await browser.NewPageAsync();

            // Google'a gidin
            await page.GotoAsync("https://www.google.com");

            // Sayfa başlığını alın
            var title = await page.TitleAsync();

            Console.WriteLine($"Page title: {title}");

            // Tarayıcıyı kapatın
            await browser.CloseAsync();
        }

    }
}