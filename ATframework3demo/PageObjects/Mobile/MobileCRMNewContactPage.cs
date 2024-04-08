using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileCRMNewContactPage
    {
        public MobileContactProfilePage CreateMobileContact(Bitrix24Contact testContact) //Заполняет пустую форму контакта и подтверждает создание
        {
            var fieldForTextView = new MobileItem("//android.view.ViewGroup[@content-desc='contact_0_details_editor_NAME_FIELD']", "TextView поля ввода Имя");
            fieldForTextView.Click();
            var fieldForName = new MobileItem("//android.widget.EditText[@text='Complete the field']", "Поле для ввода Имени");
            fieldForName.SendKeys(testContact.Name);
            var createButton = new MobileItem("//android.widget.TextView[@text='Create']", "Конопка Создать");
            createButton.Click();

            return new MobileContactProfilePage();
        }

    }
}
