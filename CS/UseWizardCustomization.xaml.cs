using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using System.Windows.Controls;

namespace ValidateCustomSql {
    /// <summary>
    /// Interaction logic for UseWizardCustomization.xaml
    /// </summary>
    public partial class UseWizardCustomization : UserControl {
        public UseWizardCustomization() {
            InitializeComponent();
        }
    }

    public class MyWizardCustomizationService : IWizardCustomizationService {
        void IDataSourceWizardCustomizationService.CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, 
            ViewModelSourceIntegrityContainer container) {
            container.RegisterType<ICustomQueryValidator, MyCustomQueryValidator>();
        }

        void IWizardCustomizationService.CustomizeReportWizard(ReportWizardCustomizationModel customization, 
            ViewModelSourceIntegrityContainer container) {
            container.RegisterType<ICustomQueryValidator, MyCustomQueryValidator>();
        }

        bool IDataSourceWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, 
            out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }

        bool IWizardCustomizationService.TryCreateReport(XtraReportModel model, out XtraReport report) {
            report = null;
            return false;
        }
    }
}
