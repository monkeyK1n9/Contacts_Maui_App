namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}
