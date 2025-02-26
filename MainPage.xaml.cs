using CommunityToolkit.Maui.Views;
using System.Diagnostics;

namespace popup_bug
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var modalPage = new ModalPage();

            Debug.WriteLine("Showing Modal Page!");
            await Navigation.PushModalAsync(modalPage);
            Debug.WriteLine("Showing popup!");
            await modalPage.ShowPopupAsync(new APopup());
            Debug.WriteLine("Popup closed! Popping modal page.");
            await Navigation.PopModalAsync();
            Debug.WriteLine("Showing Main Page again.");
        }
    }

}
