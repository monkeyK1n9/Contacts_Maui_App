namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts = new List<Contact>()
			{
				new Contact { Name = "John Doe", Email = "JohnDoe@gmail.com" },
				new Contact { Name = "Guillaume djio", Email = "Guillaume@gmail.com" },
				new Contact { Name = "Eric Paul", Email = "Eric@g.com" },
				new Contact { Name = "Stephen Jack", Email = "Stephen@hotlook.com" }
			};

		listContacts.ItemsSource = contacts;
	}

	public class Contact
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}

    async void listContacts_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
		if (listContacts.SelectedItem != null)
		{
			// logic
			await Shell.Current.GoToAsync(nameof(EditContactPage));
		}
	}

    void listContacts_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
	}
}
