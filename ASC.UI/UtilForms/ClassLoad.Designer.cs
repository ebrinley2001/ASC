namespace ASC.UI.UtilForms
{
    partial class ClassLoad
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
            SaveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            NameTxt = new TextBox();
            LogLbl = new Label();
            label5 = new Label();
            IsProfessionCb = new CheckBox();
            BaseStaminaNud = new NumericUpDown();
            BaseHealthNud = new NumericUpDown();
            label4 = new Label();
            DescRtxt = new RichTextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            ArmorNud = new NumericUpDown();
            NatArmorNud = new NumericUpDown();
            label7 = new Label();
            label3 = new Label();
            ClassDgv = new DataGridView();
            SkillLoadName = new DataGridViewTextBoxColumn();
            ClassLoadBaseHeatlh = new DataGridViewTextBoxColumn();
            ClassLoadBaseStamina = new DataGridViewTextBoxColumn();
            ClassLoadIsProfession = new DataGridViewCheckBoxColumn();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            ((System.ComponentModel.ISupportInitialize)BaseStaminaNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BaseHealthNud).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ArmorNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NatArmorNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassDgv).BeginInit();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(343, 163);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 16);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Desc :";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(95, 19);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(100, 23);
            NameTxt.TabIndex = 0;
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.Location = new Point(9, 171);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(43, 15);
            LogLbl.TabIndex = 6;
            LogLbl.Text = "LogLbl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 50);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 8;
            label5.Text = "BaseHealth :";
            // 
            // IsProfessionCb
            // 
            IsProfessionCb.AutoSize = true;
            IsProfessionCb.Location = new Point(230, 140);
            IsProfessionCb.Name = "IsProfessionCb";
            IsProfessionCb.Size = new Size(92, 19);
            IsProfessionCb.TabIndex = 6;
            IsProfessionCb.Text = "Is Profession";
            IsProfessionCb.UseVisualStyleBackColor = true;
            // 
            // BaseStaminaNud
            // 
            BaseStaminaNud.Location = new Point(95, 76);
            BaseStaminaNud.Name = "BaseStaminaNud";
            BaseStaminaNud.Size = new Size(120, 23);
            BaseStaminaNud.TabIndex = 3;
            // 
            // BaseHealthNud
            // 
            BaseHealthNud.Location = new Point(95, 48);
            BaseHealthNud.Name = "BaseHealthNud";
            BaseHealthNud.Size = new Size(120, 23);
            BaseHealthNud.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 79);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 14;
            label4.Text = "BaseStamina :";
            // 
            // DescRtxt
            // 
            DescRtxt.Location = new Point(230, 34);
            DescRtxt.Name = "DescRtxt";
            DescRtxt.ScrollBars = RichTextBoxScrollBars.Vertical;
            DescRtxt.Size = new Size(188, 96);
            DescRtxt.TabIndex = 1;
            DescRtxt.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(ArmorNud);
            groupBox1.Controls.Add(NatArmorNud);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(NameTxt);
            groupBox1.Controls.Add(DescRtxt);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BaseHealthNud);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BaseStaminaNud);
            groupBox1.Controls.Add(LogLbl);
            groupBox1.Controls.Add(IsProfessionCb);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 199);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 140);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 19;
            label6.Text = "NatArmor :";
            // 
            // ArmorNud
            // 
            ArmorNud.Location = new Point(95, 107);
            ArmorNud.Name = "ArmorNud";
            ArmorNud.Size = new Size(120, 23);
            ArmorNud.TabIndex = 4;
            // 
            // NatArmorNud
            // 
            NatArmorNud.Location = new Point(95, 135);
            NatArmorNud.Name = "NatArmorNud";
            NatArmorNud.Size = new Size(120, 23);
            NatArmorNud.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 109);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 16;
            label7.Text = "Armor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 34;
            label3.Text = "Browser";
            // 
            // ClassDgv
            // 
            ClassDgv.AllowUserToAddRows = false;
            ClassDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassDgv.Columns.AddRange(new DataGridViewColumn[] { SkillLoadName, ClassLoadBaseHeatlh, ClassLoadBaseStamina, ClassLoadIsProfession });
            ClassDgv.Location = new Point(12, 234);
            ClassDgv.Name = "ClassDgv";
            ClassDgv.ReadOnly = true;
            ClassDgv.RowHeadersVisible = false;
            ClassDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClassDgv.Size = new Size(426, 231);
            ClassDgv.TabIndex = 33;
            ClassDgv.TabStop = false;
            // 
            // SkillLoadName
            // 
            SkillLoadName.DataPropertyName = "Name";
            SkillLoadName.HeaderText = "Name";
            SkillLoadName.Name = "SkillLoadName";
            SkillLoadName.ReadOnly = true;
            // 
            // ClassLoadBaseHeatlh
            // 
            ClassLoadBaseHeatlh.DataPropertyName = "BaseHealth";
            ClassLoadBaseHeatlh.HeaderText = "BaseHealth";
            ClassLoadBaseHeatlh.Name = "ClassLoadBaseHeatlh";
            ClassLoadBaseHeatlh.ReadOnly = true;
            // 
            // ClassLoadBaseStamina
            // 
            ClassLoadBaseStamina.DataPropertyName = "BaseStamina";
            ClassLoadBaseStamina.HeaderText = "BaseStamina";
            ClassLoadBaseStamina.Name = "ClassLoadBaseStamina";
            ClassLoadBaseStamina.ReadOnly = true;
            // 
            // ClassLoadIsProfession
            // 
            ClassLoadIsProfession.DataPropertyName = "IsProfession";
            ClassLoadIsProfession.HeaderText = "IsProfession";
            ClassLoadIsProfession.Name = "ClassLoadIsProfession";
            ClassLoadIsProfession.ReadOnly = true;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ClassLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 479);
            Controls.Add(label3);
            Controls.Add(ClassDgv);
            Controls.Add(groupBox1);
            Name = "ClassLoad";
            Text = "ClassLoad";
            ((System.ComponentModel.ISupportInitialize)BaseStaminaNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)BaseHealthNud).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ArmorNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)NatArmorNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private Label label1;
        private Label label2;
        private TextBox NameTxt;
        private Label LogLbl;
        private TextBox textBox1;
        private Label label5;
        private CheckBox IsProfessionCb;
        private NumericUpDown BaseStaminaNud;
        private NumericUpDown BaseHealthNud;
        private Label label4;
        private RichTextBox DescRtxt;
        private GroupBox groupBox1;
        private Label label3;
        private DataGridView ClassDgv;
        private DataGridViewTextBoxColumn SkillLoadName;
        private DataGridViewTextBoxColumn ClassLoadBaseHeatlh;
        private DataGridViewTextBoxColumn ClassLoadBaseStamina;
        private DataGridViewCheckBoxColumn ClassLoadIsProfession;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label6;
        private NumericUpDown ArmorNud;
        private NumericUpDown NatArmorNud;
        private Label label7;
    }
}