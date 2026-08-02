using ASC.BC.Interfaces;
using ASC.Models.DB;
using ASC.UI.Helpers;
using ASC.UI.ViewModels;
using System.ComponentModel;

namespace ASC.UI.Controls
{
    public partial class ClassBonusForm : Form
    {
        public ClassBonusViewModel ViewModel { get; private set; }

        public ClassBonusForm(Bonus bonus)
        {
            ViewModel = new ClassBonusViewModel(bonus);

            ViewModel.SaveCommand = new RelayCommand(Save);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            saveBtn.Bind(ViewModel, v => v.SaveCommand);

            skillTotalLbl.Bind(c => c.Text, ViewModel, v => v.Total);

            BonusDgv.AutoGenerateColumns = false;
            BonusDgv.DataSource = ViewModel.BonusItems;
            BonusDgv.CellFormatting += dataGridView1_CellFormatting;

            ViewModel.BonusItems.ListChanged += new ListChangedEventHandler(BindNewSkill);
        }

        private void BindNewSkill(object sender, ListChangedEventArgs e)
        {
            if (sender != null)
            {
                if (e.ListChangedType == ListChangedType.ItemAdded)
                {
                    ViewModel.BonusItems[e.NewIndex].PropertyChanged += new PropertyChangedEventHandler(OnSkillChange);
                }
            }
        }

        private void OnSkillChange(object sender, EventArgs e)
        {
            var data = sender as OEKVP<int, Skill>;
            if (data != null)
            {
                if (ViewModel.BonusItems.Sum(b => b.Key) > ViewModel.Total)
                {
                    string message = $"You have exceeded the total amount you can distribute.";
                    MessageBox.Show(
                        message,
                        "Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                        );
                    data.Key = 0;
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OEKVP<int, Skill> bonus = BonusDgv.Rows[e.RowIndex].DataBoundItem as OEKVP<int, Skill>;
            if (bonus != null)
            {
                if (BonusDgv.Columns["Skill"].Index == e.ColumnIndex)
                {
                    if (bonus.Value != null)
                    {
                        e.Value = bonus.Value.Name;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void Save()
        {
            if (ViewModel.BonusItems.Sum(b => b.Key) != ViewModel.Total)
            {
                string message = $"You have not distributed the full amount of skills.";
                MessageBox.Show(
                    message,
                    "Limit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                    );
            }
            else
            {
                this.Close();
            }
        }
    }
}
