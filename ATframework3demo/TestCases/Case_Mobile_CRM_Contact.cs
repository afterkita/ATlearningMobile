using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects.Mobile;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Mobile_CRM_Contact : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(
                new TestCase("Создание CRM контакта", mobileHomePage => CreateContact(mobileHomePage)));
            return caseCollection;
        }

        void CreateContact(MobileHomePage homePage)
        {
            string contactName = "test";
            var contactForTest = new Bitrix24Contact(contactName);
            // Выбрать меню - открыть CRM - Создать контакт - Проверить создан ли контакт
            homePage.TabsPanel
                .SelectMenu()
                .OpenCRM()
                .OpenNewContactForm()
                .CreateContact(contactForTest)
                .IsMobileContactCreated(contactForTest);
        }
    }
}
