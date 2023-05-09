using Playground.Views;
namespace Playground;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(IntroScreenView), typeof(IntroScreenView));
		Routing.RegisterRoute(nameof(StudentListView), typeof(StudentListView));
		Routing.RegisterRoute(nameof(AnimalListView), typeof(AnimalListView));
	}
}

