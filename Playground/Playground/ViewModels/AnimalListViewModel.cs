using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Playground.Services;
using Playground.Views;
using Playground.Models;
using System.Collections.ObjectModel;

namespace Playground.ViewModels
{
    public partial class AnimalListViewModel : ObservableObject
    {
        private List<EntryDetails> _allAnimalList;
        private int _pageSize = 20;
        public ObservableCollection<EntryDetails> AnimalList { get; set; } = new ObservableCollection<EntryDetails>();
        private readonly AnimalService _animalService;
        public AnimalListViewModel(AnimalService animalService)
        {
            _animalService = animalService;

            GetAnimalList();
        }

        private void GetAnimalList()
        {
            Task.Run(async () =>
            {
                var entryList = await _animalService.GetAnimalList();

                App.Current.Dispatcher.Dispatch(() =>
                {
                    var recordsToBeAdded = _allAnimalList.Take(_pageSize).ToList();
                    foreach(var record in recordsToBeAdded)
                    {
                        AnimalList.Add(record);
                    }
                });
            });
        }
    }
}

