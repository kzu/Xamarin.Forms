﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace Xamarin.Forms.Core.UITests
{
	internal static class RunningApp
	{
		public static iOSApp App;
	
		public static void Restart () 
		{
			App = ConfigureApp
				.iOS
				.Debug ()
				// Keeping the old BundleId for now, Test Cloud doesn't 
				// like it when we update the BundleId for an existing app
				.InstalledApp ("com.xamarin.quickui.controlgallery")
				.StartApp (Xamarin.UITest.Configuration.AppDataMode.Clear);
		}
	}
}