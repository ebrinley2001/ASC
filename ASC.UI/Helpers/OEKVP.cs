using ASC.UI.ViewModels;

namespace ASC.UI.Helpers
{
    //Observable Editable KeyValuePair
    public class OEKVP<TKey, TValue> : NotifiableViewModel
    {
        private TKey key;
        private TValue value;

        public TKey Key 
        {
            get => key;
            set => SetField(ref key, value);
        }
        public TValue Value
        {
            get => value;
            set => SetField(ref value, value);
        }

        public OEKVP(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
