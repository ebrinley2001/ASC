namespace ASC.UI.UtilForms
{
    partial class BonusLoad
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
            groupBox1 = new GroupBox();
            LogLbl = new Label();
            SaveBtn = new Button();
            label4 = new Label();
            LevelCBox = new ComboBox();
            label3 = new Label();
            RaceCBox = new ComboBox();
            label2 = new Label();
            ClassCBox = new ComboBox();
            label1 = new Label();
            AmountNUD = new NumericUpDown();
            label5 = new Label();
            BonusDgv = new DataGridView();
            BonusLoadId = new DataGridViewTextBoxColumn();
            BonusLoadAmount = new DataGridViewTextBoxColumn();
            RaceNameBonus = new DataGridViewTextBoxColumn();
            ClassNameBonus = new DataGridViewTextBoxColumn();
            BonusLoadLevel = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BonusDgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LogLbl);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(LevelCBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(RaceCBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ClassCBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AmountNUD);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Bonus";
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.Location = new Point(16, 141);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(43, 15);
            LogLbl.TabIndex = 14;
            LogLbl.Text = "LogLbl";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(338, 137);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 13;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 110);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Level :";
            // 
            // LevelCBox
            // 
            LevelCBox.FormattingEnabled = true;
            LevelCBox.Location = new Point(76, 107);
            LevelCBox.Name = "LevelCBox";
            LevelCBox.Size = new Size(121, 23);
            LevelCBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 81);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Race :";
            // 
            // RaceCBox
            // 
            RaceCBox.FormattingEnabled = true;
            RaceCBox.Location = new Point(76, 78);
            RaceCBox.Name = "RaceCBox";
            RaceCBox.Size = new Size(121, 23);
            RaceCBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 52);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Class :";
            // 
            // ClassCBox
            // 
            ClassCBox.FormattingEnabled = true;
            ClassCBox.Location = new Point(76, 49);
            ClassCBox.Name = "ClassCBox";
            ClassCBox.Size = new Size(121, 23);
            ClassCBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Amount :";
            // 
            // AmountNUD
            // 
            AmountNUD.Location = new Point(76, 22);
            AmountNUD.Name = "AmountNUD";
            AmountNUD.Size = new Size(37, 23);
            AmountNUD.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 38;
            label5.Text = "Browser";
            // 
            // BonusDgv
            // 
            BonusDgv.AllowUserToAddRows = false;
            BonusDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BonusDgv.Columns.AddRange(new DataGridViewColumn[] { BonusLoadId, BonusLoadAmount, RaceNameBonus, ClassNameBonus, BonusLoadLevel });
            BonusDgv.Location = new Point(12, 200);
            BonusDgv.Name = "BonusDgv";
            BonusDgv.ReadOnly = true;
            BonusDgv.RowHeadersVisible = false;
            BonusDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BonusDgv.Size = new Size(419, 231);
            BonusDgv.TabIndex = 37;
            BonusDgv.TabStop = false;
            // 
            // BonusLoadId
            // 
            BonusLoadId.DataPropertyName = "Id";
            BonusLoadId.HeaderText = "Id";
            BonusLoadId.Name = "BonusLoadId";
            BonusLoadId.ReadOnly = true;
            BonusLoadId.Width = 50;
            // 
            // BonusLoadAmount
            // 
            BonusLoadAmount.DataPropertyName = "Amount";
            BonusLoadAmount.HeaderText = "Amount";
            BonusLoadAmount.Name = "BonusLoadAmount";
            BonusLoadAmount.ReadOnly = true;
            // 
            // RaceNameBonus
            // 
            RaceNameBonus.DataPropertyName = "(none)";
            RaceNameBonus.HeaderText = "Race";
            RaceNameBonus.Name = "RaceNameBonus";
            RaceNameBonus.ReadOnly = true;
            // 
            // ClassNameBonus
            // 
            ClassNameBonus.DataPropertyName = "(none)";
            ClassNameBonus.HeaderText = "Class";
            ClassNameBonus.Name = "ClassNameBonus";
            ClassNameBonus.ReadOnly = true;
            // 
            // BonusLoadLevel
            // 
            BonusLoadLevel.DataPropertyName = "(none)";
            BonusLoadLevel.HeaderText = "Level";
            BonusLoadLevel.Name = "BonusLoadLevel";
            BonusLoadLevel.ReadOnly = true;
            // 
            // BonusLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 440);
            Controls.Add(label5);
            Controls.Add(BonusDgv);
            Controls.Add(groupBox1);
            Name = "BonusLoad";
            Text = "BonusLoad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)BonusDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown AmountNUD;
        private Label label1;
        private ComboBox ClassCBox;
        private Label label3;
        private ComboBox RaceCBox;
        private Label label2;
        private Label label4;
        private ComboBox LevelCBox;
        private Button SaveBtn;
        private Label LogLbl;
        private Label label5;
        private DataGridView BonusDgv;
        private DataGridViewTextBoxColumn BonusLoadId;
        private DataGridViewTextBoxColumn BonusLoadAmount;
        private DataGridViewTextBoxColumn RaceNameBonus;
        private DataGridViewTextBoxColumn ClassNameBonus;
        private DataGridViewTextBoxColumn BonusLoadLevel;
    }
}