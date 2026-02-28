using ASC.BC.Interfaces;
using ASC.UI.Helpers;
using ASC.UI.ViewModels.UtilForms;

namespace ASC.UI.UtilForms
{
    public partial class RaceLoad : Form
    {
        public RaceLoadViewModel ViewModel { get; set; }
        public RaceLoad(IRaceBC raceBC)
        {
            ViewModel = new RaceLoadViewModel(raceBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            SaveBtn.Bind(ViewModel, v => v.SaveCommand);

            NameTxt.Bind(c => c.Text, ViewModel, v => v.Name);
            DescRtxt.Bind(c => c.Text, ViewModel, v => v.Desc);
            LogLbl.Bind(c => c.Text, ViewModel, v => v.Log);

            RaceDgv.AutoGenerateColumns = false;
            RaceDgv.DataSource = ViewModel.Races;
            RaceDgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(ViewModel.OnRowDelete);
        }
    }
}
