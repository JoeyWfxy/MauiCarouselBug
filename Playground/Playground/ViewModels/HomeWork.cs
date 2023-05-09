using System;
namespace Playground.ViewModels
{
	public class HomeWork
	{
		public HomeWork()
		{

		}
		/// <summary>
		/// field
		/// </summary>
		private string _field;


        /// <summary>
        /// Property
        /// </summary>
        public int Scc { get; set; }

        /// <summary>
        /// property full
        /// </summary>
        public string absl
		{
			get
			{
				return _field;
			}
			set
			{
				_field = value; Fun();
			}
		}

		private void Fun()
		{

		}





	}
}

