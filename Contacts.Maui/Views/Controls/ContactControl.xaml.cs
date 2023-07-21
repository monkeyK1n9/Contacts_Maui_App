﻿namespace Contacts.Maui.Views.Controls;

public partial class ContactControl : ContentView
{
    public ContactControl()
    {
        InitializeComponent();
    }

    public event EventHandler<string> OnError;

    public event EventHandler<EventArgs> OnSave;

    public event EventHandler<EventArgs> OnCancel;

    public string Name
    {
        get
        {
            return entryName.Text;
        }
        set
        {
            entryName.Text = value;
        }
    }

    public string Email
    {
        get
        {
            return entryEmail.Text;
        }
        set
        {
            entryEmail.Text = value;
        }
    }

    public string Phone
    {
        get
        {
            return entryPhone.Text;
        }
        set
        {
            entryPhone.Text = value;
        }
    }

    public string Address
    {
        get
        {
            return entryAddress.Text;
        }
        set
        {
            entryAddress.Text = value;
        }
    }

    void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            OnError?.Invoke(sender, "Name is required");
            return;
        }

        if (emailValidator.IsNotValid)
        {
            foreach (var error in emailValidator.Errors)
            {
                OnError?.Invoke(sender, error.ToString());
            }
            return;
        }

        OnSave?.Invoke(sender, e);
    }

    void btnCancel_Clicked(object sender, EventArgs e)
    {
        OnCancel?.Invoke(sender, e);
    }
}

