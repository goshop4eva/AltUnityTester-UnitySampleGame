using AltTester.AltTesterUnitySDK.Driver;

namespace PageObjectTest.pages
{
    public class BasePage
    {
        AltDriver driver;

        public AltDriver Driver { get => driver; set => driver = value; }
        public BasePage(AltDriver driver)
        {
            Driver = driver;
        }
    }
}