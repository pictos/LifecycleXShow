﻿using System;
using Xamarin.Forms;

namespace LifecycleXShow
{
	public partial class LifecyclePage : ContentPage
	{
		public LifecyclePage() => InitializeComponent();

		void LifeCycleEffect_Loaded(object sender, EventArgs e)
		{
			if (sender is Button)
				lbl.Text += "Button loaded \n";
			if (sender is Image)
				lbl.Text += "Image loaded \n";
			if (sender is Label)
				lbl.Text += "Label loaded \n";
			if (sender is StackLayout)
				lbl.Text += "StackLayout loaded \n";
			if (sender is ContentPage)
				lbl.Text += "ContentPage loaded \n";
		}

		void LifeCycleEffect_Unloaded(object sender, EventArgs e)
		{
			if (sender is Button)
				lbl.Text += "Button unloaded \n";
			if (sender is Image)
				lbl.Text += "Image unloaded \n";
			if (sender is Label)
				lbl.Text += "Label unloaded \n";
			if (sender is StackLayout)
				lbl.Text += "StackLayout unloaded \n";
			if (sender is ContentPage)
				lbl.Text += "ContentPage loaded \n";
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			img.IsVisible = !img.IsVisible;
			Device.StartTimer(TimeSpan.FromSeconds(3), () =>
			{
				stack.Children.Remove(img);
				return false;
			});
		}
	}
}