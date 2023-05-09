using Playground.ViewModels;
namespace Playground.Views
{
    public partial class IntroScreenView : ContentPage
    {
        public IntroScreenView(IntroScreenViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }


    }
}
