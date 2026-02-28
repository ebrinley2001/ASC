using ASC.BC.Interfaces;
using ASC.UI.Helpers;
using ASC.UI.ViewModels.UtilForms;

namespace ASC.UI.UtilForms
{
    public partial class AttributeLoad : Form
    {
        public AttributeLoadViewModel ViewModel { get; set; }
        public AttributeLoad(IAttributeBC attributeBC)
        {
            ViewModel = new AttributeLoadViewModel(attributeBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            SaveBtn.Bind(ViewModel, v => v.SaveCommand);

            NameTxt.Bind(c => c.Text, ViewModel, v => v.Name);
            DescRtxt.Bind(c => c.Text, ViewModel, v => v.Desc);
            LogLbl.Bind(c => c.Text, ViewModel, v => v.Log);

            AttributeDgv.AutoGenerateColumns = false;
            AttributeDgv.DataSource = ViewModel.Attributes;
            AttributeDgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(ViewModel.OnRowDelete);
        }
    }
}
