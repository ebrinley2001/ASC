using ASC.BC.Interfaces;
using ASC.Models.DB;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;

namespace ASC.UI.ViewModels.UtilForms
{
    public class ClassLoadViewModel : NotifiableViewModel
    {
        private IClassBC _classBC;
        private Class _class;
        private string _log;

        public string Name
        {
            get => _class.Name;
            set
            {
                if (_class.Name != value)
                {
                    _class.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Desc
        {
            get => _class.Description;
            set
            {
                if (_class.Description != value)
                {
                    _class.Description = value;
                    OnPropertyChanged(nameof(Desc));
                }
            }
        }

        public int BaseHealth
        {
            get => _class.BaseHealth;
            set
            {
                if (_class.BaseHealth != value)
                {
                    _class.BaseHealth = value;
                    OnPropertyChanged(nameof(BaseHealth));
                }
            }
        }

        public int BaseStamina
        {
            get => _class.BaseStamina;
            set
            {
                if (_class.BaseStamina != value)
                {
                    _class.BaseStamina = value;
                    OnPropertyChanged(nameof(BaseStamina));
                }
            }
        }

        public int Armor
        {
            get => _class.ArmorWear;
            set
            {
                if (_class.ArmorWear != value)
                {
                    _class.ArmorWear = value;
                    OnPropertyChanged(nameof(Armor));
                }
            }
        }

        public int NatArmor
        {
            get => _class.NaturalArmor;
            set
            {
                if (_class.NaturalArmor != value)
                {
                    _class.NaturalArmor = value;
                    OnPropertyChanged(nameof(NatArmor));
                }
            }
        }

        public bool IsProfession
        {
            get => _class.IsProfession;
            set
            {
                if (_class.IsProfession != value)
                {
                    _class.IsProfession = value;
                    OnPropertyChanged(nameof(IsProfession));
                }
            }
        }

        public string Log
        {
            get => _log;
            set => SetField(ref _log, value);
        }

        public BindingList<Class> Classes;

        public ICommand SaveCommand { get; set; }

        public ClassLoadViewModel(IClassBC classBC)
        {
            _classBC = classBC;
            _class = new Class();

            SaveCommand = new RelayCommand(Save);

            Classes = new BindingList<Class>(_classBC.GetCollection().OrderByDescending(c => c.Id).ToList());
        }

        private void Save()
        {
            int result = _classBC.Create(_class);
            Log = $"{Name} was created with a result of {result}";
            Classes.Insert(0, _class);

            _class = new Class();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Desc));
            OnPropertyChanged(nameof(BaseHealth));
            OnPropertyChanged(nameof(BaseStamina));
            OnPropertyChanged(nameof(NatArmor));
            OnPropertyChanged(nameof(Armor));
            OnPropertyChanged(nameof(IsProfession));

        }

        public void OnRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            Class classToDelete = e.Row.DataBoundItem as Class;
            if (classToDelete != null)
            {
                _classBC.Delete(classToDelete);
            }
        }
    }
}
