using System.Linq.Expressions;
using System.Windows.Input;

namespace ASC.UI.Helpers
{
    public static class Databinding
    {
        public static void Bind<TViewModel, TControlProp, TDataProp>(this Control control, Expression<Func<Control, TControlProp>> propertyName, TViewModel dataSource, Expression<Func<TViewModel, TDataProp>> dataMember)
        {
            control.DataBindings.Add(((MemberExpression)propertyName.Body).Member.Name, dataSource, ((MemberExpression)dataMember.Body).Member.Name, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void Bind<TViewModel, TDataProp>(this Button control, TViewModel dataSource, Expression<Func<TViewModel, TDataProp>> command)
            where TDataProp : ICommand
        {
            Func<TViewModel, TDataProp> compiledFunc = command.Compile();
            control.Click += (sender, e) => compiledFunc(dataSource).Execute(e);
        }

        public static void Bind<TViewModel, TDataProp>(this CheckBox control, TViewModel dataSource, Expression<Func<TViewModel, TDataProp>> dataMember)
        {
            control.DataBindings.Add("Checked", dataSource, ((MemberExpression)dataMember.Body).Member.Name, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void Bind<TViewModel, TDataProp>(this ComboBox control, TViewModel dataSource, Expression<Func<TViewModel, TDataProp>> dataMember)
        {
            control.DataBindings.Add("SelectedItem", dataSource, ((MemberExpression)dataMember.Body).Member.Name, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
