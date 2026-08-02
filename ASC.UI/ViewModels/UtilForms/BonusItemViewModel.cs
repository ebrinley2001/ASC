using ASC.BC.Interfaces;
using ASC.Models;
using ASC.Models.DB;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;

namespace ASC.UI.ViewModels.UtilForms
{
    public class BonusItemLoadViewModel : NotfiableObject
    {
        private IBonusItemBC _bonusItemBC;
        private BonusItem _bonusItem;
        private string _log;

        public Bonus SelectedBonus
        {
            get => _bonusItem.Bonus;
            set
            {
                if (_bonusItem.Bonus != value)
                {
                    _bonusItem.Bonus = value;
                    OnPropertyChanged(nameof(SelectedBonus));
                }
            }
        }

        public Skill SelectedSkill
        {
            get => _bonusItem.Skill;
            set
            {
                if (_bonusItem.Skill != value)
                {
                    _bonusItem.Skill = value;
                    OnPropertyChanged(nameof(SelectedSkill));
                }
            }
        }

        public bool InRange
        {
            get => _bonusItem.InRange;
            set
            {
                if (_bonusItem.InRange != value)
                {
                    _bonusItem.InRange = value;
                    OnPropertyChanged(nameof(InRange));
                }
            }
        }
        public string Effect
        {
            get => _bonusItem.Effect;
            set
            {
                if (_bonusItem.Effect != value)
                {
                    _bonusItem.Effect = value;
                    OnPropertyChanged(nameof(Effect));
                }
            }
        }

        public string Log
        {
            get => _log;
            set => SetField(ref _log, value);
        }

        public BindingList<Bonus> Bonuses;
        public BindingList<Skill> Skills;

        public BindingList<BonusItem> BonusItems;

        public ICommand SaveCommand { get; set; }

        public BonusItemLoadViewModel(IBonusItemBC bonusItemBC, IBonusBC bonusBC, ISkillBC skillBC)
        {
            _bonusItemBC = bonusItemBC;
            _bonusItem = new BonusItem();

            SaveCommand = new RelayCommand(Save);

            BonusItems = new BindingList<BonusItem>(bonusItemBC.GetCollection().OrderByDescending(s => s.Id).ToList());

            Bonuses = new BindingList<Bonus>(bonusBC.GetCollection());
            Skills = new BindingList<Skill>(skillBC.GetCollection());

            Bonuses.Insert(0, new Bonus() { Id = -1 });
            Skills.Insert(0, new Skill() { Id = -1, Name = "Select a Skill if Applicable" });
        }

        private void Save()
        {   
            if (_bonusItem.Skill != null && _bonusItem.Skill.Id == -1)
            {
                _bonusItem.Skill = null;
            }
            int result = _bonusItemBC.Create(_bonusItem);
            Log = $"BonusItem was created with a result of {result}";
            BonusItems.Insert(0, _bonusItem);

            Bonus oldBonus = _bonusItem.Bonus;
            _bonusItem = new BonusItem();
            _bonusItem.Bonus = oldBonus;

            _bonusItem.Skill = Skills[0];

            OnPropertyChanged(nameof(SelectedBonus));
            OnPropertyChanged(nameof(SelectedSkill));
            OnPropertyChanged(nameof(InRange));
            OnPropertyChanged(nameof(Effect));
        }

        public void OnRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            BonusItem bonusItem = e.Row.DataBoundItem as BonusItem;
            if (bonusItem != null)
            {
                _bonusItemBC.Delete(bonusItem);
            }
        }
    }
}
