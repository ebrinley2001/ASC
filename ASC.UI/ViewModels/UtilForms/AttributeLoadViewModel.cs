using ASC.BC.Interfaces;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.UI.ViewModels.UtilForms
{
    public class AttributeLoadViewModel : NotifiableViewModel
    {
        private IAttributeBC _attributeBC;

        private Attribute _attribute;

        private string _log;

        public string Name
        {
            get => _attribute.Name;
            set
            {
                if (_attribute.Name != value)
                {
                    _attribute.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Desc
        {
            get => _attribute.Description;
            set
            {
                if (_attribute.Description != value)
                {
                    _attribute.Description = value;
                    OnPropertyChanged(nameof(Desc));
                }
            }
        }

        public string Log
        {
            get => _log;
            set => SetField(ref _log, value);
        }

        public BindingList<Attribute> Attributes;

        public ICommand SaveCommand { get; set; }

        public AttributeLoadViewModel(IAttributeBC attributeBC)
        {
            _attributeBC = attributeBC;
            _attribute = new Attribute();

            SaveCommand = new RelayCommand(Save);

            Attributes = new BindingList<Attribute>(_attributeBC.GetCollection().OrderByDescending(a => a.Id).ToList());
        }

        private void Save()
        {
            int result = _attributeBC.Create(_attribute);
            Log = $"{Name} was created with a result of {result}";
            Attributes.Insert(0, _attribute);

            _attribute = new Attribute();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Desc));
        }

        public void OnRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            Attribute attrbute = e.Row.DataBoundItem as Attribute;
            if (attrbute != null)
            {
                _attributeBC.Delete(attrbute);
            }
        }
    }
}
