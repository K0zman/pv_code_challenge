using pv_BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using pv_BI.Interfaces;
using pv_BI.Services;

namespace pv_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IPatientRegistrationService _patientRegistrationService;
        private readonly IPatientDiagnoseService _patientDiagnoseService;
        private readonly IDecorateStringService _decorateStringService;
        public MainWindow(
            IPatientRegistrationService patientRegistrationService,
            IPatientDiagnoseService patientDiagnoseService,
            IDecorateStringService decorateStringService)
        {
            InitializeComponent();
            _patientRegistrationService = patientRegistrationService;
            _patientDiagnoseService = patientDiagnoseService;
            _decorateStringService = decorateStringService;
        }
        private void Button_Register(object sender, RoutedEventArgs e)
        {
            var intList = Enumerable.Range(1, 100);
            var convertedValues = _patientRegistrationService.Replace(intList);
            tBlockRegister.Text = _decorateStringService.Formater(convertedValues); 
        }

        private void Button_Diagnose(object sender, RoutedEventArgs e)
        {
            var intList = Enumerable.Range(1, 100);
            var convertedValues = _patientDiagnoseService.Replace(intList);
            tBlockDiagnose.Text = _decorateStringService.Formater(convertedValues);
        }
        private void Button_Clear_Diagnose(object sender, RoutedEventArgs e)
        {
            tBlockDiagnose.Text = string.Empty;
        }

        private void Button_Clear_Register(object sender, RoutedEventArgs e)
        {
            tBlockRegister.Text = string.Empty;
        }
    }
}
