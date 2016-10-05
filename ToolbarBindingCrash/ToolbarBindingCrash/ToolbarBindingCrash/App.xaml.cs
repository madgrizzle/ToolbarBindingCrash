using Prism.Unity;
using ToolbarBindingCrash.Views;

namespace ToolbarBindingCrash
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("TabPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<TabPage>();

        }
    }
}
