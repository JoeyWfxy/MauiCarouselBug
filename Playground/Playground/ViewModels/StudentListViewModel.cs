using System;
using System.Timers;
using Microsoft.Toolkit.Mvvm.Input;
using Playground.Models;
using Playground.Views;
using System;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Linq;

namespace Playground.ViewModels
{
    public partial class StudentListViewModel : BaseViewModel
    {
        public static List<StudentModel> Students { get; private set; } = new List<StudentModel>();

        private ObservableCollection<CarouselItem> _carouselItems { get; set; } = new ObservableCollection<CarouselItem>();

        public ObservableCollection<CarouselItem> carouselItems
        {
            get { return _carouselItems; }
            set { _carouselItems = value; OnPropertyChanged(); }
        }
        public StudentListViewModel()
        {
            Students.Add(new StudentModel
            {
                Name = "asd",
                Email = "asd@123.com",
            });
            Students.Add(new StudentModel
            {
                Name = "qwe",
                Email = "qwe@123.com",
            });
            Students.Add(new StudentModel
            {
                Name = "ert",
                Email = "rty@123.com",
            });


            carouselItems.Clear();
            carouselItems.Add(new CarouselItem
            {
                Id = "1",
                Images = "article_banner.png"
            });
            carouselItems.Add(new CarouselItem
            {
                Id = "2",
                Images = "banner_4.png"
            });
            carouselItems.Add(new CarouselItem
            {
                Id = "3",
                Images = "banner_5.png"
            });
        }

        [ICommand]
        async void GotoNextPage()
        {
            var action = await App.Current.MainPage.DisplayAlert("Question?", "Would you like to play a game", "Go to AnimalListView", "Go to IntroScreen");
            if (action == true)
            {
                await Shell.Current.GoToAsync($"{nameof(AnimalListView)}", true);
            }
            else if (action == false)
            {
                await Shell.Current.GoToAsync($"{nameof(IntroScreenView)}", true);
            }
        }
    }
}

