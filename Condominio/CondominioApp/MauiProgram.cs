﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using CondominioApp.Data;
using CondominioApp.Pages;

namespace CondominioApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<UserRepository>();
		return builder.Build();
	}
}
