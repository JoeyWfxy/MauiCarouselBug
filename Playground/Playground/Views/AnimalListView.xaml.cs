using Playground.ViewModels;
namespace Playground.Views;

public partial class AnimalListView : ContentPage
{
	public AnimalListView(AnimalListViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}
