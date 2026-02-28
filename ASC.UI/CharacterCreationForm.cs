using ASC.BC.Interfaces;
using ASC.BC.SkillHelpers;
using ASC.Models.DB;
using ASC.UI.Controls;
using ASC.UI.Helpers;
using ASC.UI.ViewModels;
using PuppeteerSharp;
using Razor.Templating.Core;
using System.ComponentModel;
using System.Text.Json;
using Attribute = ASC.Models.DB.Attribute;

namespace ASC.UI
{
    public partial class CharacterCreationForm : Form
    {
        public CharacterCreationViewModel ViewModel { get; set; }
        public CharacterCreationForm(ISkillBC skillBc, IRaceBC raceBc, IClassBC classBc, ILevelBC levelBc, IAttributeBC attributeBC)
        {
            ViewModel = new CharacterCreationViewModel(skillBc, raceBc, classBc, levelBc, attributeBC);

            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            ViewModel.ExportCommand = new RelayCommand(Export);
            ExportBtn.Bind(ViewModel, v => v.ExportCommand);

            ViewModel.CompleteCommand = new RelayCommand(GenerateSheet);
            CompleteBtn.Bind(ViewModel, v => v.CompleteCommand);

            ViewModel.AddAttributeCommand = new RelayCommand(AddAttribute);
            AddAttributeBtn.Bind(ViewModel, v => v.AddAttributeCommand);
            AddAttributeBtn.Bind(c => c.Enabled, ViewModel, v => v.CanAddAttributes);

            ViewModel.AddClassCommand = new RelayCommand(AddClass);
            AddClassBtn.Bind(ViewModel, v => v.AddClassCommand);
            AddClassBtn.Bind(c => c.Enabled, ViewModel, v => v.CanAddClasses);

            ViewModel.AddSkillCommand = new RelayCommand(AddSkill);
            AddSkillBtn.Bind(ViewModel, v => v.AddSkillCommand);

            NameTxt.Bind(c => c.Text, ViewModel, v => v.Name);
            HpTxt.Bind(c => c.Text, ViewModel, v => v.Hp);
            XpNud.Bind(c => c.Text, ViewModel, v => v.Xp);
            StaminaTxt.Bind(c => c.Text, ViewModel, v => v.Stamina);
            LevelTxt.Bind(c => c.Text, ViewModel, v => v.Level);
            ArmorTxt.Bind(c => c.Text, ViewModel, v => v.MaxArmor);
            NatArmorTxt.Bind(c => c.Text, ViewModel, v => v.NatArmor);

            AvailableAttributesLbl.Bind(c => c.Text, ViewModel, v => v.AvailibleAttributes);
            AvailableClassesLbl.Bind(c => c.Text, ViewModel, v => v.AvailibleClasses);
            SpentXpLbl.Bind(c => c.Text, ViewModel, v => v.AvailibleXp);

            RaceCb.Bind(ViewModel, v => v.Race);
            RaceCb.DisplayMember = "Name";
            RaceCb.DataSource = ViewModel.Races;

            AttributeDgv.AutoGenerateColumns = false;
            AttributeDgv.DataSource = ViewModel.SelectedAttributes;

            ClassesDgv.AutoGenerateColumns = false;
            ClassesDgv.DataSource = ViewModel.SelectedClasses;

            SkillsDgv.AutoGenerateColumns = false;
            SkillsDgv.DataSource = ViewModel.SelectedSkills;
            SkillsDgv.CellFormatting += new DataGridViewCellFormattingEventHandler(FormatSkillCells);

            ViewModel.SelectedSkills.ListChanged += new ListChangedEventHandler(BindNewSkill);
            ViewModel.SelectedClasses.ListChanged += new ListChangedEventHandler(OnClassChange);
            ViewModel.SelectedAttributes.ListChanged += new ListChangedEventHandler(ViewModel.CheckCanAddAttributes);
        }

        private void AddAttribute()
        {
            ViewModel.SetAvailibleAttributes();
            SelectionForm<Attribute> form = new SelectionForm<Attribute>(
                ViewModel.Attributes.ToList(),
                a => new string[] { a.Name },
                new Dictionary<string, int>()
                {
                    { "Name", -1 }
                }
                );

            form.ShowDialog();

            if (form.SelectedItem != null)
            {
                ViewModel.SelectedAttributes.Add(form.SelectedItem);
            }
        }

        private void AddClass()
        {
            ViewModel.SetAvailibleClasses();
            SelectionForm<Class> form = new SelectionForm<Class>(
                ViewModel.Classes.ToList(),
                a => new string[] { a.Name },
                new Dictionary<string, int>()
                {
                    { "Name", -1 }
                }
                );

            form.ShowDialog();

            if (form.SelectedItem != null)
            {
                ViewModel.SelectedClasses.Add(form.SelectedItem);
            }
        }

        private void AddSkill()
        {
            ViewModel.SetAvailibleSkills();
            SelectionForm<Skill> form = new SelectionForm<Skill>(
                ViewModel.Skills.ToList(),
                a => new string[] { a.Name, a.XPCost.ToString() },
                new Dictionary<string, int>()
                {
                    { "Name", -1 },
                    { "XpCost", -1 }
                }
                );

            form.ShowDialog();

            if (form.SelectedItem != null)
            {
                ViewModel.SelectedSkills.Add(new OEKVP<int, Skill>(1, form.SelectedItem));
            }
        }

        private void FormatSkillCells(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var rowData = SkillsDgv.Rows[e.RowIndex].DataBoundItem as OEKVP<int, Skill>;
            if (rowData != null)
            {
                if (e.ColumnIndex == this.SkillsDgv.Columns["SkillName"].Index)
                {
                    e.Value = rowData.Value.Name;
                }
                else if (e.ColumnIndex == this.SkillsDgv.Columns["SkillCost"].Index)
                {
                    e.Value = rowData.Value.XPCost.ToString();
                }
            }
        }

        private void BindNewSkill(object sender, ListChangedEventArgs e)
        {
            if (sender != null)
            {
                ViewModel.SetAvailibleXp();
                ViewModel.CalculateStats();
                if (e.ListChangedType == ListChangedType.ItemAdded)
                {
                    ViewModel.SelectedSkills[e.NewIndex].PropertyChanged += new PropertyChangedEventHandler(OnSkillChange);
                }
            }
        }

        private void OnSkillChange(object sender, EventArgs e)
        {
            var data = sender as OEKVP<int, Skill>;
            if (data != null)
            {
                if (!data.Value.CheckLimit(data.Key, ViewModel.Character))
                {
                    string message = $"The limit for {data.Value.Name} is {data.Value.Limit}";
                    MessageBox.Show(
                        message,
                        "Skill Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                        );
                    data.Key = 1;
                }
                else
                {
                    ViewModel.CalculateStats();
                }
            }
        }

        private void OnClassChange(object sender, ListChangedEventArgs e)
        {
            ViewModel.CheckCanAddClasses();
            ViewModel.CalculateStats();
        }

        private void Export()
        {
            var exportDialog = new SaveFileDialog();
            exportDialog.Title = "Export Character";
            exportDialog.FilterIndex = 1;
            exportDialog.RestoreDirectory = true;
            exportDialog.Filter = "Json Files (*.json)|*.json";
            exportDialog.DefaultExt = ".json";

            exportDialog.FileName = $"{ViewModel.Name}-{DateTime.Now.ToString("MMddyyyy-hh_mm_ss")}";

            ViewModel.Character.Classes = ViewModel.SelectedClasses.ToList();
            ViewModel.Character.Attributes = ViewModel.SelectedAttributes.ToList();
            ViewModel.Character.Skills = ViewModel.SelectedSkills.Select(s => new KeyValuePair<int, Skill>(s.Key, s.Value)).ToList();

            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = exportDialog.FileName;

                try
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string indentedJson = JsonSerializer.Serialize(ViewModel.Character, options);

                    File.WriteAllText(fileName, indentedJson);
                    MessageBox.Show("Character Exported Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void GenerateSheet()
        {
            ViewModel.Character.Classes = ViewModel.SelectedClasses.ToList();
            ViewModel.Character.Attributes = ViewModel.SelectedAttributes.ToList();
            ViewModel.Character.Skills = ViewModel.SelectedSkills.Select(s => new KeyValuePair<int, Skill>(s.Key, s.Value)).ToList();

            var exportDialog = new SaveFileDialog();
            exportDialog.Title = "Generate Character Sheet";
            exportDialog.FilterIndex = 1;
            exportDialog.RestoreDirectory = true;
            exportDialog.Filter = "Pdf Files (*.pdf)|*.pdf";
            exportDialog.DefaultExt = ".pdf";

            exportDialog.FileName = $"{ViewModel.Name}-{DateTime.Now.ToString("MMddyyyy-hh_mm_ss")}";

            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = exportDialog.FileName;

                try
                {
                    string html = await RazorTemplateEngine.RenderAsync("~/CharacterSheet.cshtml", ViewModel.Character);

                    var browserFetcher = new BrowserFetcher();
                    await browserFetcher.DownloadAsync();
                    using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true }))
                    {
                        using (var page = await browser.NewPageAsync())
                        {
                            await page.SetContentAsync(html);
                            await page.PdfAsync(fileName);
                        }
                    }

                    MessageBox.Show("Character Exported Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //Error Catching here
                }
            }


        }
    }
}
