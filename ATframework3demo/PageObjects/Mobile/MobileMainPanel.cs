using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// Главная панель приложения
    /// </summary>
    public class MobileMainPanel
    {
        public MobileTasksListPage SelectTasks()
        {
            var tasksTab = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/bb_bottom_bar_title\" and @text=\"Tasks\"]",
                "Таб 'Задачи'");
            tasksTab.Click();

            return new MobileTasksListPage();
        }

        public MobileMenuPage SelectMenu() //Ищет в нижнем меню кнопку с надписью Menu и выбирает её
        {
            var menuTab = new MobileItem("//android.widget.TextView[@resource-id='com.bitrix24.android:id/bb_bottom_bar_title' and @text='Menu']",
                "Таб 'Меню'");
            menuTab.Click();

            return new MobileMenuPage();
        }
    }
}