namespace ASC.UI.UtilForms
{
    partial class BonusItemLoad
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
            InRangeCb = new CheckBox();
            LogLbl = new Label();
            EffectRtxt = new RichTextBox();
            SaveBtn = new Button();
            label1 = new Label();
            label3 = new Label();
            SkillCBox = new ComboBox();
            label2 = new Label();
            BonusCBox = new ComboBox();
            label4 = new Label();
            BonusItemDgv = new DataGridView();
            BonusLoadSourceName = new DataGridViewTextBoxColumn();
            BonusItemLoadEffect = new DataGridViewTextBoxColumn();
            SkillNameBonusItem = new DataGridViewTextBoxColumn();
            BonusItemLoadInRange = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BonusItemDgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InRangeCb);
            groupBox1.Controls.Add(LogLbl);
            groupBox1.Controls.Add(EffectRtxt);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SkillCBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BonusCBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Bonus";
            // 
            // InRangeCb
            // 
            InRangeCb.AutoSize = true;
            InRangeCb.Location = new Point(341, 24);
            InRangeCb.Name = "InRangeCb";
            InRangeCb.Size = new Size(72, 19);
            InRangeCb.TabIndex = 17;
            InRangeCb.Text = "In Range";
            InRangeCb.UseVisualStyleBackColor = true;
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.Location = new Point(13, 149);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(43, 15);
            LogLbl.TabIndex = 16;
            LogLbl.Text = "LogLbl";
            // 
            // EffectRtxt
            // 
            EffectRtxt.Location = new Point(189, 43);
            EffectRtxt.Name = "EffectRtxt";
            EffectRtxt.ScrollBars = RichTextBoxScrollBars.Vertical;
            EffectRtxt.Size = new Size(224, 96);
            EffectRtxt.TabIndex = 15;
            EffectRtxt.Text = "";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(328, 145);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 13;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 22);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 14;
            label1.Text = "Effect :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 54);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Skill :";
            // 
            // SkillCBox
            // 
            SkillCBox.FormattingEnabled = true;
            SkillCBox.Location = new Point(62, 51);
            SkillCBox.Name = "SkillCBox";
            SkillCBox.Size = new Size(121, 23);
            SkillCBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 25);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Bonus :";
            // 
            // BonusCBox
            // 
            BonusCBox.FormattingEnabled = true;
            BonusCBox.Location = new Point(62, 22);
            BonusCBox.Name = "BonusCBox";
            BonusCBox.Size = new Size(121, 23);
            BonusCBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 36;
            label4.Text = "Browser";
            // 
            // BonusItemDgv
            // 
            BonusItemDgv.AllowUserToAddRows = false;
            BonusItemDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BonusItemDgv.Columns.AddRange(new DataGridViewColumn[] { BonusLoadSourceName, BonusItemLoadEffect, SkillNameBonusItem, BonusItemLoadInRange });
            BonusItemDgv.Location = new Point(12, 213);
            BonusItemDgv.Name = "BonusItemDgv";
            BonusItemDgv.ReadOnly = true;
            BonusItemDgv.RowHeadersVisible = false;
            BonusItemDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BonusItemDgv.Size = new Size(419, 231);
            BonusItemDgv.TabIndex = 35;
            BonusItemDgv.TabStop = false;
            // 
            // BonusLoadSourceName
            // 
            BonusLoadSourceName.HeaderText = "Source";
            BonusLoadSourceName.Name = "BonusLoadSourceName";
            BonusLoadSourceName.ReadOnly = true;
            // 
            // BonusItemLoadEffect
            // 
            BonusItemLoadEffect.DataPropertyName = "Effect";
            BonusItemLoadEffect.HeaderText = "Effect";
            BonusItemLoadEffect.Name = "BonusItemLoadEffect";
            BonusItemLoadEffect.ReadOnly = true;
            // 
            // SkillNameBonusItem
            // 
            SkillNameBonusItem.DataPropertyName = "(none)";
            SkillNameBonusItem.HeaderText = "Skill";
            SkillNameBonusItem.Name = "SkillNameBonusItem";
            SkillNameBonusItem.ReadOnly = true;
            // 
            // BonusItemLoadInRange
            // 
            BonusItemLoadInRange.DataPropertyName = "InRange";
            BonusItemLoadInRange.HeaderText = "InRange";
            BonusItemLoadInRange.Name = "BonusItemLoadInRange";
            BonusItemLoadInRange.ReadOnly = true;
            BonusItemLoadInRange.Resizable = DataGridViewTriState.True;
            BonusItemLoadInRange.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BonusItemLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 451);
            Controls.Add(label4);
            Controls.Add(BonusItemDgv);
            Controls.Add(groupBox1);
            Name = "BonusItemLoad";
            Text = "BonusItemLoad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BonusItemDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox BonusCBox;
        private Label label3;
        private ComboBox SkillCBox;
        private Label label2;
        private Button SaveBtn;
        private Label label1;
        private RichTextBox EffectRtxt;
        private Label LogLbl;
        private CheckBox InRangeCb;
        private Label label4;
        private DataGridView BonusItemDgv;
        private DataGridViewTextBoxColumn BonusLoadSourceName;
        private DataGridViewTextBoxColumn BonusItemLoadEffect;
        private DataGridViewTextBoxColumn SkillNameBonusItem;
        private DataGridViewCheckBoxColumn BonusItemLoadInRange;
    }
}