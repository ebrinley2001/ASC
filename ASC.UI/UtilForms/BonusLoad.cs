using ASC.BC.Interfaces;
using ASC.Models.DB;
using ASC.UI.Helpers;
using ASC.UI.ViewModels.UtilForms;

namespace ASC.UI.UtilForms
{
    public partial class BonusLoad : Form
    {
        public BonusLoadViewModel ViewModel { get; set; }
        public BonusLoad(IBonusBC bonusBC, IClassBC classBC, IRaceBC raceBC, ILevelBC levelBC)
        {
            ViewModel = new BonusLoadViewModel(bonusBC, raceBC, levelBC, classBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            SaveBtn.Bind(ViewModel, v => v.SaveCommand);

            AmountNUD.Bind(c => c.Text, ViewModel, v => v.Amount);

            ClassCBox.Bind(ViewModel, v => v.SelectedClass);
            ClassCBox.DataSource = ViewModel.Classes;
            ClassCBox.DisplayMember = "Name";

            RaceCBox.Bind(ViewModel, v => v.SelectedRace);
            RaceCBox.DataSource = ViewModel.Races;
            RaceCBox.DisplayMember = "Name";

            LevelCBox.Bind(ViewModel, v => v.SelectedLevel);
            LevelCBox.DataSource = ViewModel.Levels;
            LevelCBox.DisplayMember = "Id";

            BonusDgv.AutoGenerateColumns = false;
            BonusDgv.DataSource = ViewModel.Bonuses;
            BonusDgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(ViewModel.OnRowDelete);
            BonusDgv.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Bonus bonus = BonusDgv.Rows[e.RowIndex].DataBoundItem as Bonus;
            if (bonus != null)
            {
                if (BonusDgv.Columns[e.ColumnIndex].Name == "RaceNameBonus")
                {
                    if (bonus.Race != null)
                    {
                        e.Value = bonus.Race.Name;
                        e.FormattingApplied = true;
                    }
                }
                else if (BonusDgv.Columns[e.ColumnIndex].Name == "ClassNameBonus")
                {
                    if (bonus.Class != null)
                    {
                        e.Value = bonus.Class.Name;
                        e.FormattingApplied = true;
                    }
                }
                else if (BonusDgv.Columns[e.ColumnIndex].Name == "BonusLoadLevel")
                {
                    if (bonus.Level != null)
                    {
                        e.Value = bonus.Level.Id;
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}
