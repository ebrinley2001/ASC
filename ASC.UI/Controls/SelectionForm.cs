namespace ASC.UI.Controls
{
    public partial class SelectionForm<T> : Form
    {
        public T SelectedItem { get; private set; }

        public SelectionForm(List<T> candidates, Func<T, string[]> displayMemberSelector, Dictionary<string, int> columnHeaders)
        {
            InitializeComponent();

            SelectBtn.Click += new EventHandler(OnSelect);

            foreach (var col in columnHeaders)
            {
                SelectionListView.Columns.Add(col.Key, col.Value);
            }

            foreach (T item in candidates)
            {
                string[] columns = displayMemberSelector(item);
                var listViewItem = new ListViewItem(columns[0]);
                for (int i = 1; i < columns.Length; i++)
                {
                    listViewItem.SubItems.Add(columns[i]);
                }
                listViewItem.Tag = item;
                SelectionListView.Items.Add(listViewItem);
            }
        }

        private void OnSelect(object sender, EventArgs e)
        {
            if (SelectionListView.SelectedItems.Count > 0)
            {
                SelectedItem = (T)SelectionListView.SelectedItems[0].Tag;
                this.Close();
            }
        }
    }
}
