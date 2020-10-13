using ProfileBook.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using Prism;
using Prism.Ioc;
using ProfileBook.ViewModels;
using Prism.Navigation;

namespace ProfileBook
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("SignInView");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SignInView>();
            containerRegistry.RegisterForNavigation<SignUpView>();
            containerRegistry.RegisterForNavigation<SettingsView>();
            containerRegistry.RegisterForNavigation<MainListView>();
            containerRegistry.RegisterForNavigation<AddEditProfileView>();
        }
    }
}
