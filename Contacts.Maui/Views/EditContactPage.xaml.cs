namespace Contacts.Maui.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}
