using ASC.BC.Interfaces;
using ASC.BC.SkillHelpers;
using ASC.Models;
using ASC.Models.DB;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.UI.ViewModels
{
    public class CharacterCreationViewModel : NotifiableViewModel
    {
        private ISkillBC _skillBC;
        private IClassBC _classBC;
        private ILevelBC _levelBC;
        private IAttributeBC _attributeBC;

        private Character _character;

        private int _availibleAttributes;
        private int _availibleClasses;

        private bool _canAddClasses;
        private bool _canAddAttributes;

        public Character Character
        {
            get => _character;
            set => SetField(ref _character, value);
        }

        public string Name
        {
            get => _character.Name;
            set
            {
                if (_character.Name != value)
                {
                    _character.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public Race Race
        {
            get => _character.Race;
            set
            {
                if (_character.Race != value)
                {
                    _character.Race = value;
                    OnPropertyChanged(nameof(Race));
                }
            }
        }

        public int Xp
        {
            get => _character.XpAmount;
            set
            {
                if (_character.XpAmount != value)
                {
                    _character.XpAmount = value;
                    SetLevel();
                }
            }
        }

        public string Hp
        {
            get => _character.Hp.ToString();
        }

        public string Stamina
        {
            get => _character.Stamina.ToString();
        }

        public string MaxArmor
        {
            get => _character.MaxArmor.ToString();
        }

        public string NatArmor
        {
            get => _character.NaturalArmor.ToString();
        }

        public int Level
        {
            get => _character.Level != null ? _character.Level.Id : 0;
        }

        public string AvailibleXp
        {
            get => _character.Level != null ? $"{XpToSpend} Availible" : string.Empty;
        }

        public int XpToSpend
        {
            get => _character.XpToSpend;
            set
            {
                if (_character.XpToSpend != value)
                {
                    _character.XpToSpend = value;
                    OnPropertyChanged(nameof(XpToSpend));
                }
            }
        }

        public string AvailibleAttributes
        {
            get => _character.Level != null ? $"{_availibleAttributes - SelectedAttributes.Count} Availible" : string.Empty;
        }

        public string AvailibleClasses
        {
            get => _character.Level != null ? $"{_availibleClasses - SelectedClasses.Count} Availible" : string.Empty;
        }

        public bool CanAddClasses
        {
            get => _canAddClasses;
            set => SetField(ref _canAddClasses, value);
        }

        public bool CanAddAttributes
        {
            get => _canAddAttributes;
            set => SetField(ref _canAddAttributes, value);
        }

        public BindingList<Race> Races;
        public BindingList<Attribute> Attributes;
        public BindingList<Class> Classes;
        public BindingList<Skill> Skills;

        public BindingList<Attribute> SelectedAttributes = new BindingList<Attribute>();
        public BindingList<Class> SelectedClasses = new BindingList<Class>();
        public BindingList<OEKVP<int, Skill>> SelectedSkills = new BindingList<OEKVP<int, Skill>>();

        public ICommand AddClassCommand { get; set; }
        public ICommand AddAttributeCommand { get; set; }
        public ICommand AddSkillCommand { get; set; }
        public ICommand ExportCommand { get; set; }
        public ICommand CompleteCommand { get; set; }


        public CharacterCreationViewModel(ISkillBC skillBc, IRaceBC raceBc, IClassBC classBc, ILevelBC levelBc, IAttributeBC attributeBC)
        {
            _skillBC = skillBc;
            _classBC = classBc;
            _levelBC = levelBc;
            _attributeBC = attributeBC;

            Character = new Character();

            Races = new BindingList<Race>(raceBc.GetCollection());
            Race = Races[0] != null ? Races[0] : null;
        }

        private void SetLevel()
        {
            Level? level = _levelBC.GetCurrentLevel(_character.XpAmount);

            _character.Level = level;
            _availibleAttributes = _character.Level != null ? level.Attributes : 0;
            _availibleClasses = _character.Level != null ? level.Roles : 0;

            OnPropertyChanged(nameof(Level));

            CheckCanAddClasses();
            CheckCanAddAttributes(null, null);

            SetAvailibleXp();
            CalculateStats();

            if (level == null)
            {
                SelectedAttributes.Clear();
                SelectedClasses.Clear();
            }
        }

        public void CalculateStats()
        {
            _character.Hp = _character.Level != null ? _character.Level.BaseHp : 0;
            _character.Stamina = _character.Level != null ? _character.Level.BaseStamina : 0;
            _character.MaxArmor = 15;
            _character.NaturalArmor = 0;

            foreach (Class selectedClass in SelectedClasses)
            {
                _character.Hp += selectedClass.BaseHealth;
                _character.Stamina += selectedClass.BaseStamina;
                _character.MaxArmor += selectedClass.ArmorWear;
                _character.NaturalArmor += selectedClass.NaturalArmor;
            }

            foreach (var healthDelegate in StatCalculator.HealthDelegates)
            {
                var skill = SelectedSkills.FirstOrDefault(x => x.Value.Name == healthDelegate.Key);
                if (skill != null)
                {
                    _character.Hp += healthDelegate.Value.Invoke(skill.Key);
                }
            }

            foreach (var staminaDelegate in StatCalculator.StaminaDelegates)
            {
                var skill = SelectedSkills.FirstOrDefault(x => x.Value.Name == staminaDelegate.Key);
                if (skill != null)
                {
                    _character.Stamina += staminaDelegate.Value.Invoke(skill.Key);
                }
            }

            foreach (var armorDelegate in StatCalculator.ArmorDelegates)
            {
                var skill = SelectedSkills.FirstOrDefault(x => x.Value.Name == armorDelegate.Key);
                if (skill != null)
                {
                    _character.MaxArmor += armorDelegate.Value.Invoke(skill.Key);
                }
            }

            foreach (var natArmorDelegate in StatCalculator.NatArmorDelegates)
            {
                var skill = SelectedSkills.FirstOrDefault(x => x.Value.Name == natArmorDelegate.Key);
                if (skill != null)
                {
                    _character.NaturalArmor += natArmorDelegate.Value.Invoke(skill.Key);
                }
            }

            OnPropertyChanged(nameof(Hp));
            OnPropertyChanged(nameof(Stamina));
            OnPropertyChanged(nameof(MaxArmor));
            OnPropertyChanged(nameof(NatArmor));
        }
        public void SetAvailibleSkills()
        {
            //Add all skills that align with class race and atrributes
            List<Skill> skills = _skillBC.GetGeneralSkills();

            if (Race != null)
            {
                skills.AddRange(_skillBC.GetRaceSkills(Race));
            }
            if (SelectedClasses.Count > 0)
            {
                foreach (Class selectedClass in SelectedClasses)
                {
                    skills.AddRange(_skillBC.GetClassSkills(selectedClass));
                }
            }
            if (SelectedAttributes.Count > 0)
            {
                foreach (Attribute atrribute in SelectedAttributes)
                {
                    skills.AddRange(_skillBC.GetAttributeSkills(atrribute));
                }
            }

            //Remove skills that are too expensive
            skills = skills.Where(s => s.XPCost < XpToSpend).ToList();

            //Remove already selected skills
            skills = skills.Where(s => !(SelectedSkills.Count(sp => sp.Value == s) > 0)).ToList();

            //Need to check prereqs and limits
            skills = skills.Where(s => s.CheckLimit(1, _character) && s.CheckPrereq(_character)).ToList();

            Skills = new BindingList<Skill>(skills);
        }

        public void SetAvailibleClasses()
        {
            List<Class> classes = _classBC.GetCollection();

            //Strip already selected classes
            classes = classes.Where(s => !SelectedClasses.Contains(s)).ToList();

            //Only professions are availible if you are 1 away from meeting the role limit
            if (SelectedClasses.Count(c => !c.IsProfession) == _availibleClasses - 1)
            {
                classes = classes.Where(c => c.IsProfession).ToList();
            }

            Classes = new BindingList<Class>(classes);
        }

        public void SetAvailibleAttributes()
        {
            List<Attribute> attributes = _attributeBC.GetCollection();

            //Strip already selected attributes
            attributes = attributes.Where(s => !SelectedAttributes.Contains(s)).ToList();

            Attributes = new BindingList<Attribute>(attributes);
        }

        public void CheckCanAddClasses()
        {
            if (_character.Level != null)
            {
                if (SelectedClasses.Count < _availibleClasses)
                {
                    CanAddClasses = true;
                }
                else
                {
                    CanAddClasses = false;
                }
                OnPropertyChanged(nameof(AvailibleClasses));
                OnPropertyChanged(nameof(CanAddClasses));
            }
        }

        public void CheckCanAddAttributes(object sender, ListChangedEventArgs e)
        {
            if (_character.Level != null)
            {
                if (SelectedAttributes.Count < _availibleAttributes)
                {
                    CanAddAttributes = true;
                }
                else
                {
                    CanAddAttributes = false;
                }
                OnPropertyChanged(nameof(AvailibleAttributes));
                OnPropertyChanged(nameof(CanAddAttributes));
            }
        }

        public void SetAvailibleXp()
        {
            XpToSpend = _character.XpAmount;
            List<int> costs = SelectedSkills.Select(s => s.Key * s.Value.XPCost).ToList();
            XpToSpend -= costs.Sum();
            OnPropertyChanged(nameof(AvailibleXp));
        }
    }
}
