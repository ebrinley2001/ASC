using ASC.BC.Interfaces;
using ASC.Models.DB;
using ASC.UI.Helpers;
using ASC.UI.ViewModels.UtilForms;

namespace ASC.UI.UtilForms
{
    public partial class BonusItemLoad : Form
    {
        public BonusItemLoadViewModel ViewModel { get; set; }
        public BonusItemLoad(IBonusItemBC bonusItemBC, IBonusBC bonusBC, ISkillBC skillBC)
        {
            ViewModel = new BonusItemLoadViewModel(bonusItemBC, bonusBC, skillBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            SaveBtn.Bind(ViewModel, v => v.SaveCommand);

            EffectRtxt.Bind(c => c.Text, ViewModel, v => v.Effect);
            LogLbl.Bind(c => c.Text, ViewModel, v => v.Log);

            InRangeCb.Bind(ViewModel, v => v.InRange);

            BonusCBox.Bind(ViewModel, v => v.SelectedBonus);
            BonusCBox.DataSource = ViewModel.Bonuses;
            BonusCBox.DisplayMember = "Id";

            SkillCBox.Bind(ViewModel, v => v.SelectedSkill);
            SkillCBox.DataSource = ViewModel.Skills;
            SkillCBox.DisplayMember = "Name";

            BonusItemDgv.AutoGenerateColumns = false;
            BonusItemDgv.DataSource = ViewModel.BonusItems;
            BonusItemDgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(ViewModel.OnRowDelete);
            BonusItemDgv.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BonusItem bonus = BonusItemDgv.Rows[e.RowIndex].DataBoundItem as BonusItem;
            if (bonus != null)
            {
                if (BonusItemDgv.Columns[e.ColumnIndex].Name == "SkillNameBonusItem")
                {
                    if (bonus.Skill != null)
                    {
                        e.Value = bonus.Skill.Name;
                        e.FormattingApplied = true;
                    }
                }
                else if (BonusItemDgv.Columns[e.ColumnIndex].Name == "BonusLoadSourceName")
                {
                    if (bonus.Bonus != null)
                    {
                        if (bonus.Bonus.Class != null)
                        {
                            e.Value = bonus.Bonus.Class.Name;
                            e.FormattingApplied = true;
                        }
                        else if (bonus.Bonus.Race != null)
                        {
                            e.Value = bonus.Bonus.Race.Name;
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }
    }
}
