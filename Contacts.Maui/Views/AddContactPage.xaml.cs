using Contacts.Maui.Models;
using static Java.Util.Jar.Attributes;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    void contactCtrl_OnSave(System.Object sender, System.EventArgs e)
    {
        var newContact = new Contact()
        {
            Name= contactCtrl.Name,
            Email= contactCtrl.Email,
            Phone= contactCtrl.Phone,
            Address= contactCtrl.Address
        };

        ContactRepository.AddContact(newContact);

        Shell.Current.GoToAsync("..");
    }

    void contactCtrl_OnCancel(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    void contactCtrl_OnError(System.Object sender, System.String e)
    {
        DisplayAlert("Erro", e, "Ok");
    }
}
