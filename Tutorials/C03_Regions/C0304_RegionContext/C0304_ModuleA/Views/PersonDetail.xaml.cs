﻿using C0304_ModuleA.Models;
using C0304_ModuleA.ViewModels;
using Crystal;

namespace C0304_ModuleA.Views
{
	public partial class PersonDetail
	{
		public PersonDetail()
		{
			InitializeComponent();
			RegionContext.GetObservableContext(this).PropertyChanged += PersonDetail_PropertyChanged;
		}

		private void PersonDetail_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			var context = (ObservableObject<object>)sender;
			var selectedPerson = (Person) context.Value;
			(DataContext as PersonDetailViewModel).SelectedPerson = selectedPerson;
		}
	}
}
