using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileMenuPage
    {
        public MobileCRMPage OpenCRM() //Ищет кнопку с надписью CRM и нажимает
        {
            var CRMBtn = new MobileItem("//android.widget.TextView[@resource-id='com.bitrix24.android:id/title' and @text='CRM']", "Кнопка CRM");
            CRMBtn.Click();
            return new MobileCRMPage();
        }
    }
}
