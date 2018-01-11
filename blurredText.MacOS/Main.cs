using AppKit;

namespace blurredText.MacOS
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.SharedApplication.MainMenu = CreateMenu();
            NSApplication.Main(args);
        }

        private static NSMenu CreateMenu()
        {
            var appMenu = new NSMenu();
            appMenu.AddItem(new NSMenuItem("Quit", new ObjCRuntime.Selector("terminate:"), "q"));

            var appMenuItem = new NSMenuItem();
            appMenuItem.Submenu = appMenu;

            var menu = new NSMenu();
            menu.AddItem(appMenuItem);
            return menu;
        }
    }
}
