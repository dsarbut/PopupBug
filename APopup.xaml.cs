namespace popup_bug;

public partial class APopup : CommunityToolkit.Maui.Views.Popup
{
	public APopup()
	{
		InitializeComponent();
        btnClose.Clicked += BtnClose_Clicked;
	}

    private void BtnClose_Clicked(object? sender, EventArgs e)
    {
        Close();
    }
}