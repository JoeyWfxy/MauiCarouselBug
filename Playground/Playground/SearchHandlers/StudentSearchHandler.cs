using System;
using System.Linq;
using Playground.Models;
namespace Playground.SearchHandlers
{
    public class StudentSearchHandler : SearchHandler
    {
        public IList<StudentModel> Students { get; set; } = new List<StudentModel>();
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Students.Where(student => student.Name.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            // Let the animation complete
            await Task.Delay(1000);

            //ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            //// The following route works because route names are unique in this app.
            //await Shell.Current.GoToAsync($"{GetNavigationTarget()}?name={((Animal)item).Name}");
        }
    }
}

