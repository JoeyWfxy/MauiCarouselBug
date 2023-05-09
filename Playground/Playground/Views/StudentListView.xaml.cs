using Playground.ViewModels;
namespace Playground.Views;

public partial class StudentListView : ContentPage
{
	public StudentListView()
	{
		InitializeComponent();
		this.BindingContext = new StudentListViewModel();

        var metrics = DeviceDisplay.Current.MainDisplayInfo;
        var screenWidth = metrics.Width / metrics.Density;

        double fontSize = screenWidth * 0.03; // Adjust the multiplier based on your desired font size relative to the screen width.

        MyLabel.FontSize = fontSize;
    }
}
