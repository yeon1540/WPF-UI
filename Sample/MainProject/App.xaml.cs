﻿using Comm.sqlite.CMD;
using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;
using Comm.sqlite.Services;
using CompanyProject.Config;
using CompanyProject.ViewModels.Pages;
using CompanyProject.Views.Pages;
using MainProject.Services;
using MainProject.ViewModels;
using MainProject.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Wpf.Ui;

namespace MainProject
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App
    {
        // The.NET Generic Host provides dependency injection, configuration, logging, and other services.
        // https://docs.microsoft.com/dotnet/core/extensions/generic-host
        // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
        // https://docs.microsoft.com/dotnet/core/extensions/configuration
        // https://docs.microsoft.com/dotnet/core/extensions/logging
        private static readonly IHost _host = Host
            .CreateDefaultBuilder()
            .ConfigureAppConfiguration(c => { c.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)); })
            .ConfigureServices((context, services) =>
            {
                #region 서비스 등록

                services.AddHostedService<ApplicationHostService>();

                // Page resolver service
                services.AddSingleton<IPageService, PageService>();

                // Theme manipulation
                services.AddSingleton<IThemeService, ThemeService>();

                // TaskBar manipulation
                services.AddSingleton<ITaskBarService, TaskBarService>();

                // Service containing navigation, same as INavigationWindow... but without window
                services.AddSingleton<INavigationService, NavigationService>();

                #endregion

                #region 창 / 페이지 등록

                // Main window with navigation
                services.AddSingleton<INavigationWindow, MainWindow>();
                services.AddSingleton<MainWindowViewModel>();

                services.AddSingleton<AutoScreen>();
                services.AddSingleton<AutoScreenViewModel>();
                //services.AddSingleton<AutoScreenViewModel>(provider =>
                //{
                //    var viewModel = new AutoScreenViewModel();
                //    viewModel.Eqpinfo = provider.GetRequiredService<IDataBase<Eqpinfo>>();
                //    return viewModel;
                //});

                #endregion

                #region 인터페이스에 대한 구현 등록

                //services.AddSingleton<IDataBase<Info>, InfoDao>();
                services.AddScoped(typeof(IDataBase<>), typeof(CRUD<>));

                #endregion

                #region DB 관련

                InitSetting dBContext = new InitSetting();
                services = dBContext.AddContext(services);

                #endregion

                #region SqlManager 등록 및 프로퍼티 주입

                services.AddSingleton<SqlManager>(provider =>
                {
                    var sqlManager = new SqlManager();
                    sqlManager.Eqpinfo = provider.GetRequiredService<IDataBase<Eqpinfo>>();
                    return sqlManager;
                });

                #endregion

            }).Build();

        public static T GetService<T>()
            where T : class
        {
            return _host.Services.GetService(typeof(T)) as T;
        }

        /// <summary>
        /// Occurs when the application is loading.
        /// </summary>
        private void OnStartup(object sender, StartupEventArgs e)
        {
            _host.Start();
        }

        /// <summary>
        /// Occurs when the application is closing.
        /// </summary>
        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();

            _host.Dispose();
        }

        /// <summary>
        /// Occurs when an exception is thrown by an application but not handled.
        /// </summary>
        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
        }
    }
}
