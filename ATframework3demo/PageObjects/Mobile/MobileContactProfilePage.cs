using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileContactProfilePage
    {
        public void IsMobileContactCreated(Bitrix24Contact testContact)
        {
            string xpath = "//android.widget.TextView[@resource-id='com.bitrix24.android:id/pageTitle' and @text='" + testContact.Name + "']";

            try {
                var contactName = new MobileItem(xpath, "Заголовок страницы контакта");
                contactName.Click();
            }
            catch  {
                Log.Error($"Контакт {testContact.Name} Ошибка оттображения");
                return;
            }
            Log.Info($"Контакт {testContact.Name} Верное отображение");
            return;
        }
    }
}
