using CurlEz.ViewModels;

namespace CurlEz.Views;

public partial class TestView : ContentPage
{
	public TestView(TestViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}