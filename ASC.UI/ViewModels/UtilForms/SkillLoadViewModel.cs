using ASC.BC;
using ASC.BC.Interfaces;
using ASC.Models.DB;
using ASC.Models.Enums;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.UI.ViewModels.UtilForms
{
    public class SkillLoadViewModel : NotifiableViewModel
    {
        private ISkillBC _skillBC;

        private Skill _skill;
        private string _log;

        public string Name
        {
            get => _skill.Name;
            set
            {
                if (_skill.Name != value)
                {
                    _skill.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Desc
        {
            get => _skill.Description;
            set
            {
                if (_skill.Description != value)
                {
                    _skill.Description = value;
                    OnPropertyChanged(nameof(Desc));
                }
            }
        }

        public int XpCost
        {
            get => _skill.XPCost;
            set
            {
                if (_skill.XPCost != value)
                {
                    _skill.XPCost = value;
                    OnPropertyChanged(nameof(Skill));
                }
            }
        }

        public int StaminaCost
        {
            get => _skill.StaminaCost;
            set
            {
                if (_skill.StaminaCost != value)
                {
                    _skill.StaminaCost = value;
                    OnPropertyChanged(nameof(StaminaCost));
                }
            }
        }

        public bool IsAttributeSkill
        {
            get => _skill.IsAttributeSkill;
            set
            {
                if (_skill.IsAttributeSkill != value)
                {
                    _skill.IsAttributeSkill = value;
                    OnPropertyChanged(nameof(IsAttributeSkill));
                }
            }
        }

        public bool IsRacialSkill
        {
            get => _skill.IsRacialSkill;
            set
            {
                if (_skill.IsRacialSkill != value)
                {
                    _skill.IsRacialSkill = value;
                    OnPropertyChanged(nameof(IsRacialSkill));
                }
            }
        }

        public bool IsCombatSkill
        {
            get => _skill.IsCombatSkill;
            set
            {
                if (_skill.IsCombatSkill != value)
                {
                    _skill.IsCombatSkill = value;
                    OnPropertyChanged(nameof(IsCombatSkill));
                }
            }
        }

        public Class SelectedClass
        {
            get => _skill.Class;
            set
            {
                if (_skill.Class != value)
                {
                    _skill.Class = value;
                    OnPropertyChanged(nameof(SelectedClass));
                }
            }
        }

        public Race SelectedRace
        {
            get => _skill.Race;
            set
            {
                if (_skill.Race != value)
                {
                    _skill.Race = value;
                    OnPropertyChanged(nameof(SelectedRace));
                }
            }
        }

        public Attribute SelectedAttribute
        {
            get => _skill.Attribute;
            set
            {
                if (_skill.Attribute != value)
                {
                    _skill.Attribute = value;
                    OnPropertyChanged(nameof(SelectedAttribute));
                }
            }
        }

        public Limit SelectedLimit
        {
            get => _skill.Limit;
            set
            {
                if (_skill.Limit != value)
                {
                    _skill.Limit = value;
                    OnPropertyChanged(nameof(Limit));
                }
            }
        }

        public Prerequisite SelectedPrerequisite
        {
            get => _skill.Prerequisite;
            set
            {
                if (_skill.Prerequisite != value)
                {
                    _skill.Prerequisite = value;
                    OnPropertyChanged(nameof(Prerequisite));
                }
            }
        }

        public string Log
        {
            get => _log;
            set => SetField(ref _log, value);
        }

        public BindingList<Class> Classes;
        public BindingList<Race> Races;
        public BindingList<Attribute> Attributes;

        public BindingList<Limit> Limits;
        public BindingList<Prerequisite> Prerequisites;

        public BindingList<Skill> Skills;

        public ICommand SaveCommand { get; set; }

        public SkillLoadViewModel(ISkillBC skillBC, IClassBC classBC, IRaceBC raceBc, IAttributeBC attribBC)
        {
            _skillBC = skillBC;
            _skill = new Skill();

            Skills = new BindingList<Skill>(skillBC.GetCollection().OrderByDescending(s => s.Id).ToList());

            SaveCommand = new RelayCommand(Save);

            Classes = new BindingList<Class>(classBC.GetCollection());
            Races = new BindingList<Race>(raceBc.GetCollection());
            Attributes = new BindingList<Attribute>(attribBC.GetCollection());

            Classes.Insert(0, new Class() { Id = -1, Name = "Select a Class" });
            Races.Insert(0, new Race() { Id = -1, Name = "Select a Race" });
            Attributes.Insert(0, new Attribute() { Id = -1, Name = "Select an Atribute" });

            Limits = new BindingList<Limit>((IList<Limit>)Enum.GetValues(typeof(Limit)));
            Prerequisites = new BindingList<Prerequisite>((IList<Prerequisite>)Enum.GetValues(typeof(Prerequisite)));
        }

        private void Save()
        {
            if (_skill.Class?.Id == -1)
            {
                _skill.Class = null;
            }
            if (_skill.Attribute?.Id == -1)
            {
                _skill.Attribute = null;
            }
            if ( _skill.Race?.Id == -1)
            {
                _skill.Race = null;
            }

            int result = _skillBC.Create(_skill);
            Log = $"{Name} was created with a result of {result}";
            Skills.Insert(0, _skill);

            //Retain for mass skill adding
            Class oldClass = _skill.Class;
            _skill = new Skill();
            _skill.Class = oldClass;
            _skill.Attribute = Attributes[0];
            _skill.Race = Races[0];

            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Desc));
            OnPropertyChanged(nameof(XpCost));
            OnPropertyChanged(nameof(StaminaCost));
            OnPropertyChanged(nameof(IsAttributeSkill));
            OnPropertyChanged(nameof(IsCombatSkill));
            OnPropertyChanged(nameof(IsRacialSkill));
            OnPropertyChanged(nameof(SelectedClass));
            OnPropertyChanged(nameof(SelectedAttribute));
            OnPropertyChanged(nameof(SelectedRace));
            OnPropertyChanged(nameof(SelectedLimit));
            OnPropertyChanged(nameof(SelectedPrerequisite));
        }

        public void OnRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            Skill skill = e.Row.DataBoundItem as Skill;
            if (skill != null)
            {
                _skillBC.Delete(skill);
            }
        }
    }
}
