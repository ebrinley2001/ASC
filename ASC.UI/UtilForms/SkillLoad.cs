using ASC.BC.Interfaces;
using ASC.UI.Helpers;
using ASC.UI.ViewModels.UtilForms;
using System.ComponentModel;

namespace ASC.UI.UtilForms
{
    public partial class SkillLoad : Form
    {
        public SkillLoadViewModel ViewModel { get; set; }
        public SkillLoad(ISkillBC skillBC, IClassBC classBC, IRaceBC raceBc, IAttributeBC attribBC)
        {
            ViewModel = new SkillLoadViewModel(skillBC, classBC, raceBc, attribBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            SaveBtn.Bind(ViewModel, v => v.SaveCommand);

            NameTxt.Bind(c => c.Text, ViewModel, v => v.Name);
            DescRtxt.Bind(c => c.Text, ViewModel, v => v.Desc);
            XpCostNud.Bind(c => c.Text, ViewModel, v => v.XpCost);
            StaminaCostNud.Bind(c => c.Text, ViewModel, v => v.StaminaCost);
            LogLbl.Bind(c => c.Text, ViewModel, v => v.Log);

            AttributeSkillCb.Bind(ViewModel, v => v.IsAttributeSkill);
            RacialSkillCb.Bind(ViewModel, v => v.IsRacialSkill);
            CombatSkillCb.Bind(ViewModel, v => v.IsCombatSkill);

            ClassCBox.Bind(ViewModel, v => v.SelectedClass);
            ClassCBox.DataSource = ViewModel.Classes;
            ClassCBox.DisplayMember = "Name";

            RaceLbl.Bind(c => c.Visible, ViewModel, v => v.IsRacialSkill);
            RaceCBox.Bind(c => c.Visible, ViewModel, v => v.IsRacialSkill);
            RaceCBox.Bind(ViewModel, v => v.SelectedRace);
            RaceCBox.DataSource = ViewModel.Races;
            RaceCBox.DisplayMember = "Name";

            AttributeCBox.Bind(ViewModel, v => v.SelectedAttribute);
            AttributeCBox.DataSource = ViewModel.Attributes;
            AttributeCBox.DisplayMember = "Name";

            LimitCBox.Bind(ViewModel, v => v.SelectedLimit);
            LimitCBox.DataSource = ViewModel.Limits;

            PrereqCBox.Bind(ViewModel, v => v.SelectedPrerequisite);
            PrereqCBox.DataSource = ViewModel.Prerequisites;

            SkillDgv.AutoGenerateColumns = false;
            SkillDgv.DataSource = ViewModel.Skills;

            SkillDgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(ViewModel.OnRowDelete);
        }
    }
}
