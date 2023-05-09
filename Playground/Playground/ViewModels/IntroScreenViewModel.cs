using System;
using System.Collections.ObjectModel;
using Playground.Models;

namespace Playground.ViewModels
{
	public partial class IntroScreenViewModel : BaseViewModel
	{
        #region Properties
        public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();
        #endregion

        public IntroScreenViewModel()
        {
            IntroScreens.Add(new IntroScreenModel
            {
                Images = "announcement_banner.jpeg"
            });
            IntroScreens.Add(new IntroScreenModel
            {
                Images = "article_banner.png"
            });
            IntroScreens.Add(new IntroScreenModel
            {
                Images = "news_banner.jpeg"
            });
        }
    }
}

