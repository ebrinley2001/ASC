namespace ASC.UI
{
    partial class CharacterCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NameTxt = new TextBox();
            label2 = new Label();
            HpTxt = new TextBox();
            label3 = new Label();
            StaminaTxt = new TextBox();
            label5 = new Label();
            LevelTxt = new TextBox();
            label4 = new Label();
            label6 = new Label();
            RaceCb = new ComboBox();
            label7 = new Label();
            AddAttributeBtn = new Button();
            AddClassBtn = new Button();
            ClassesDgv = new DataGridView();
            ClassName = new DataGridViewTextBoxColumn();
            label8 = new Label();
            AddSkillBtn = new Button();
            SkillsDgv = new DataGridView();
            SkillAmount = new DataGridViewTextBoxColumn();
            SkillName = new DataGridViewTextBoxColumn();
            SkillCost = new DataGridViewTextBoxColumn();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            ArmorTxt = new TextBox();
            label11 = new Label();
            NatArmorTxt = new TextBox();
            XpNud = new NumericUpDown();
            SpentXpLbl = new Label();
            AvailableClassesLbl = new Label();
            AvailableAttributesLbl = new Label();
            AttributeDgv = new DataGridView();
            AttributeName = new DataGridViewTextBoxColumn();
            ExportBtn = new Button();
            ImportBtn = new Button();
            CompleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ClassesDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SkillsDgv).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)XpNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttributeDgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(62, 22);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(100, 23);
            NameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 54);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Xp :";
            // 
            // HpTxt
            // 
            HpTxt.Enabled = false;
            HpTxt.Location = new Point(62, 80);
            HpTxt.Name = "HpTxt";
            HpTxt.Size = new Size(100, 23);
            HpTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 83);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Hp :";
            // 
            // StaminaTxt
            // 
            StaminaTxt.Enabled = false;
            StaminaTxt.Location = new Point(245, 80);
            StaminaTxt.Name = "StaminaTxt";
            StaminaTxt.Size = new Size(100, 23);
            StaminaTxt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 83);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "Stamina :";
            // 
            // LevelTxt
            // 
            LevelTxt.Enabled = false;
            LevelTxt.Location = new Point(245, 51);
            LevelTxt.Name = "LevelTxt";
            LevelTxt.Size = new Size(100, 23);
            LevelTxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 54);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 10;
            label4.Text = "Level :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 25);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "Race :";
            // 
            // RaceCb
            // 
            RaceCb.FormattingEnabled = true;
            RaceCb.Location = new Point(245, 22);
            RaceCb.Name = "RaceCb";
            RaceCb.Size = new Size(100, 23);
            RaceCb.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 144);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 14;
            label7.Text = "Attributes :";
            // 
            // AddAttributeBtn
            // 
            AddAttributeBtn.Location = new Point(11, 247);
            AddAttributeBtn.Name = "AddAttributeBtn";
            AddAttributeBtn.Size = new Size(75, 23);
            AddAttributeBtn.TabIndex = 16;
            AddAttributeBtn.Text = "Add";
            AddAttributeBtn.UseVisualStyleBackColor = true;
            // 
            // AddClassBtn
            // 
            AddClassBtn.Location = new Point(194, 247);
            AddClassBtn.Name = "AddClassBtn";
            AddClassBtn.Size = new Size(75, 23);
            AddClassBtn.TabIndex = 19;
            AddClassBtn.Text = "Add";
            AddClassBtn.UseVisualStyleBackColor = true;
            // 
            // ClassesDgv
            // 
            ClassesDgv.AllowUserToAddRows = false;
            ClassesDgv.AllowUserToResizeColumns = false;
            ClassesDgv.AllowUserToResizeRows = false;
            ClassesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassesDgv.ColumnHeadersVisible = false;
            ClassesDgv.Columns.AddRange(new DataGridViewColumn[] { ClassName });
            ClassesDgv.Location = new Point(194, 162);
            ClassesDgv.Name = "ClassesDgv";
            ClassesDgv.ReadOnly = true;
            ClassesDgv.RowHeadersVisible = false;
            ClassesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClassesDgv.Size = new Size(151, 79);
            ClassesDgv.TabIndex = 18;
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "Name";
            ClassName.HeaderText = "Name";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 144);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 17;
            label8.Text = "Classes :";
            // 
            // AddSkillBtn
            // 
            AddSkillBtn.Location = new Point(11, 415);
            AddSkillBtn.Name = "AddSkillBtn";
            AddSkillBtn.Size = new Size(75, 23);
            AddSkillBtn.TabIndex = 22;
            AddSkillBtn.Text = "Add";
            AddSkillBtn.UseVisualStyleBackColor = true;
            // 
            // SkillsDgv
            // 
            SkillsDgv.AllowUserToAddRows = false;
            SkillsDgv.AllowUserToResizeColumns = false;
            SkillsDgv.AllowUserToResizeRows = false;
            SkillsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SkillsDgv.Columns.AddRange(new DataGridViewColumn[] { SkillAmount, SkillName, SkillCost });
            SkillsDgv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            SkillsDgv.Location = new Point(11, 301);
            SkillsDgv.Name = "SkillsDgv";
            SkillsDgv.RowHeadersVisible = false;
            SkillsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SkillsDgv.Size = new Size(334, 108);
            SkillsDgv.TabIndex = 21;
            // 
            // SkillAmount
            // 
            SkillAmount.DataPropertyName = "Key";
            SkillAmount.HeaderText = "Amount";
            SkillAmount.Name = "SkillAmount";
            // 
            // SkillName
            // 
            SkillName.DataPropertyName = "(none)";
            SkillName.HeaderText = "Name";
            SkillName.Name = "SkillName";
            SkillName.ReadOnly = true;
            // 
            // SkillCost
            // 
            SkillCost.DataPropertyName = "(none)";
            SkillCost.HeaderText = "Cost";
            SkillCost.Name = "SkillCost";
            SkillCost.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 283);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 20;
            label9.Text = "Skills :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(ArmorTxt);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(NatArmorTxt);
            groupBox1.Controls.Add(XpNud);
            groupBox1.Controls.Add(SpentXpLbl);
            groupBox1.Controls.Add(AvailableClassesLbl);
            groupBox1.Controls.Add(AvailableAttributesLbl);
            groupBox1.Controls.Add(NameTxt);
            groupBox1.Controls.Add(AddSkillBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SkillsDgv);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(AddClassBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ClassesDgv);
            groupBox1.Controls.Add(HpTxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(AddAttributeBtn);
            groupBox1.Controls.Add(StaminaTxt);
            groupBox1.Controls.Add(AttributeDgv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(LevelTxt);
            groupBox1.Controls.Add(RaceCb);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 448);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Character";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 112);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 27;
            label10.Text = "Armor :";
            // 
            // ArmorTxt
            // 
            ArmorTxt.Enabled = false;
            ArmorTxt.Location = new Point(62, 109);
            ArmorTxt.Name = "ArmorTxt";
            ArmorTxt.Size = new Size(100, 23);
            ArmorTxt.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(171, 112);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 29;
            label11.Text = "Nat Armor :";
            // 
            // NatArmorTxt
            // 
            NatArmorTxt.Enabled = false;
            NatArmorTxt.Location = new Point(245, 109);
            NatArmorTxt.Name = "NatArmorTxt";
            NatArmorTxt.Size = new Size(100, 23);
            NatArmorTxt.TabIndex = 30;
            // 
            // XpNud
            // 
            XpNud.Location = new Point(61, 52);
            XpNud.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            XpNud.Name = "XpNud";
            XpNud.Size = new Size(101, 23);
            XpNud.TabIndex = 26;
            // 
            // SpentXpLbl
            // 
            SpentXpLbl.AutoSize = true;
            SpentXpLbl.Location = new Point(270, 283);
            SpentXpLbl.Name = "SpentXpLbl";
            SpentXpLbl.Size = new Size(44, 15);
            SpentXpLbl.TabIndex = 25;
            SpentXpLbl.Text = "label10";
            // 
            // AvailableClassesLbl
            // 
            AvailableClassesLbl.AutoSize = true;
            AvailableClassesLbl.Location = new Point(251, 144);
            AvailableClassesLbl.Name = "AvailableClassesLbl";
            AvailableClassesLbl.Size = new Size(44, 15);
            AvailableClassesLbl.TabIndex = 24;
            AvailableClassesLbl.Text = "label10";
            // 
            // AvailableAttributesLbl
            // 
            AvailableAttributesLbl.AutoSize = true;
            AvailableAttributesLbl.Location = new Point(82, 144);
            AvailableAttributesLbl.Name = "AvailableAttributesLbl";
            AvailableAttributesLbl.Size = new Size(44, 15);
            AvailableAttributesLbl.TabIndex = 23;
            AvailableAttributesLbl.Text = "label10";
            // 
            // AttributeDgv
            // 
            AttributeDgv.AllowUserToAddRows = false;
            AttributeDgv.AllowUserToResizeColumns = false;
            AttributeDgv.AllowUserToResizeRows = false;
            AttributeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttributeDgv.ColumnHeadersVisible = false;
            AttributeDgv.Columns.AddRange(new DataGridViewColumn[] { AttributeName });
            AttributeDgv.Location = new Point(11, 162);
            AttributeDgv.Name = "AttributeDgv";
            AttributeDgv.ReadOnly = true;
            AttributeDgv.RowHeadersVisible = false;
            AttributeDgv.ScrollBars = ScrollBars.None;
            AttributeDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AttributeDgv.Size = new Size(151, 79);
            AttributeDgv.TabIndex = 15;
            // 
            // AttributeName
            // 
            AttributeName.DataPropertyName = "Name";
            AttributeName.HeaderText = "Name";
            AttributeName.Name = "AttributeName";
            AttributeName.ReadOnly = true;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(12, 497);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(75, 23);
            ExportBtn.TabIndex = 23;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = true;
            // 
            // ImportBtn
            // 
            ImportBtn.Enabled = false;
            ImportBtn.Location = new Point(12, 468);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(75, 23);
            ImportBtn.TabIndex = 24;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = true;
            // 
            // CompleteBtn
            // 
            CompleteBtn.Location = new Point(276, 497);
            CompleteBtn.Name = "CompleteBtn";
            CompleteBtn.Size = new Size(100, 23);
            CompleteBtn.TabIndex = 25;
            CompleteBtn.Text = "Generate Sheet";
            CompleteBtn.UseVisualStyleBackColor = true;
            // 
            // CharacterCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 531);
            Controls.Add(CompleteBtn);
            Controls.Add(ImportBtn);
            Controls.Add(ExportBtn);
            Controls.Add(groupBox1);
            Name = "CharacterCreationForm";
            Text = "Aelimor Sheet Creator";
            ((System.ComponentModel.ISupportInitialize)ClassesDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)SkillsDgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)XpNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttributeDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox NameTxt;
        private Label label2;
        private TextBox HpTxt;
        private Label label3;
        private TextBox StaminaTxt;
        private Label label5;
        private TextBox LevelTxt;
        private Label label4;
        private Label label6;
        private ComboBox RaceCb;
        private Label label7;
        private Button AddAttributeBtn;
        private Button AddClassBtn;
        private DataGridView ClassesDgv;
        private Label label8;
        private Button AddSkillBtn;
        private DataGridView SkillsDgv;
        private Label label9;
        private GroupBox groupBox1;
        private Button ExportBtn;
        private Button ImportBtn;
        private Button CompleteBtn;
        private Label AvailableClassesLbl;
        private Label AvailableAttributesLbl;
        private Label SpentXpLbl;
        private DataGridView AttributeDgv;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn AttributeName;
        private DataGridViewTextBoxColumn SkillAmount;
        private DataGridViewTextBoxColumn SkillName;
        private DataGridViewTextBoxColumn SkillCost;
        private NumericUpDown XpNud;
        private Label label10;
        private TextBox ArmorTxt;
        private Label label11;
        private TextBox NatArmorTxt;
    }
}