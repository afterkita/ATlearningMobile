using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileCRMPage
    {
        public MobileCRMNewContactPage OpenNewContactForm()
        {
            var addButton = new MobileItem("//android.view.ViewGroup[@content-desc='KANBAN_STAGE_ADD_BTN']", "Кнопка Добавить");
            addButton.Click();

            var contactButton = new MobileItem("//android.widget.TextView[@content-desc='CRM_ENTITY_TAB_DEAL_CONTEXT_MENU_3_title']", "Кнопка Добавить контакт");
            contactButton.Click();

            return new MobileCRMNewContactPage();
        }
    }
}
