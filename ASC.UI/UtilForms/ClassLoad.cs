using ASC.BC.Interfaces;
using ASC.UI.Helpers;
using ASC.UI.ViewModels.UtilForms;

namespace ASC.UI.UtilForms
{
    public partial class ClassLoad : Form
    {
        public ClassLoadViewModel ViewModel { get; set; }
        public ClassLoad(IClassBC classBC)
        {
            ViewModel = new ClassLoadViewModel(classBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            SaveBtn.Bind(ViewModel, v => v.SaveCommand);

            NameTxt.Bind(c => c.Text, ViewModel, v => v.Name);
            DescRtxt.Bind(c => c.Text, ViewModel, v => v.Desc);
            BaseHealthNud.Bind(c => c.Text, ViewModel, v => v.BaseHealth);
            BaseStaminaNud.Bind(c => c.Text, ViewModel, v => v.BaseStamina);
            ArmorNud.Bind(c => c.Text, ViewModel, v => v.Armor);
            NatArmorNud.Bind(c => c.Text, ViewModel, v => v.NatArmor);
            IsProfessionCb.Bind(ViewModel, v => v.IsProfession);
            LogLbl.Bind(c => c.Text, ViewModel, v => v.Log);

            ClassDgv.AutoGenerateColumns = false;
            ClassDgv.DataSource = ViewModel.Classes;
            ClassDgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(ViewModel.OnRowDelete);
        }
    }
}
