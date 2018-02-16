using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using pv_BI.Interfaces;
using pv_BI.Services;
using Unity;

namespace pv_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();

            container.RegisterType<IPatientRegistrationService, PatientRegistrationService>();
            container.RegisterType<IPatientDiagnoseService, PatientDiagnoseService>();
            container.RegisterType<IDecorateStringService, DecorateStringService>();

            var mainWindow = container.Resolve<MainWindow>(); 

            mainWindow.Show();

        }
    }
}
