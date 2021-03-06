﻿using System;
using DLToolkit.PageFactory;

namespace PageFactory.Examples.ViewModels
{
    public class SimpleFirstViewModel : BasePageModel
	{
		public SimpleFirstViewModel()
		{
			PageTitle = "HomePage";
			LabelText = "This is first Page";

			OpenPageCommand = new PageFactoryCommand(() => {

				PageFactory.GetPageFromCache<SimpleSecondViewModel>()
					.ResetPageModel()
					.SendMessageToPageModel("ViewModelTestMessage", sender: this, arg: Guid.NewGuid())
					.PushPage();
			}); 
		}

		public IPageFactoryCommand OpenPageCommand { get; private set; }

		public string LabelText
		{
			get { return GetField<string>(); }
			set { SetField(value); }
		}

		public string PageTitle
		{
			get { return GetField<string>(); }
			set { SetField(value); }
		}
	}
}

