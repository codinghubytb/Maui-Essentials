using MauiEssentialsApp.ViewModel;

namespace MauiEssentialsApp.Views;

public partial class PhoneDialerPage : ContentPage
{
	public PhoneDialerPage()
	{
		InitializeComponent();
		BindingContext = new PhoneDialerViewModel();
	}
}