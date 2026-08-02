using ASC.Models;
using ASC.Models.DB;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;

namespace ASC.UI.ViewModels
{
    public class ClassBonusViewModel : NotfiableObject
    {
        private Bonus _bonus;

        public int Total
        {
            get => _bonus.Amount;
        }

        public BindingList<OEKVP<int, Skill>> BonusItems;

        public ICommand SaveCommand { get; set; }

        public ClassBonusViewModel(Bonus bonus)
        {
            _bonus = bonus;

            BonusItems = new BindingList<OEKVP<int, Skill>>(bonus.BonusItems.Select(b => new OEKVP<int, Skill>(0, b.Skill)).ToList());
        }
    }
}
