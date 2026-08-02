namespace ASC.UI.Controls
{
    partial class ClassBonusForm
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
            BonusDgv = new DataGridView();
            saveBtn = new Button();
            label1 = new Label();
            skillTotalLbl = new Label();
            Amount = new DataGridViewTextBoxColumn();
            Skill = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)BonusDgv).BeginInit();
            SuspendLayout();
            // 
            // BonusDgv
            // 
            BonusDgv.AllowUserToAddRows = false;
            BonusDgv.AllowUserToDeleteRows = false;
            BonusDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BonusDgv.Columns.AddRange(new DataGridViewColumn[] { Amount, Skill });
            BonusDgv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            BonusDgv.Location = new Point(12, 36);
            BonusDgv.Name = "BonusDgv";
            BonusDgv.RowHeadersVisible = false;
            BonusDgv.Size = new Size(306, 187);
            BonusDgv.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(243, 229);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Amount to Distribute:";
            // 
            // skillTotalLbl
            // 
            skillTotalLbl.AutoSize = true;
            skillTotalLbl.Location = new Point(140, 9);
            skillTotalLbl.Name = "skillTotalLbl";
            skillTotalLbl.Size = new Size(75, 15);
            skillTotalLbl.TabIndex = 3;
            skillTotalLbl.Text = "totalAmount";
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Key";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Skill
            // 
            Skill.HeaderText = "Skill";
            Skill.Name = "Skill";
            Skill.ReadOnly = true;
            // 
            // ClassBonusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 257);
            Controls.Add(skillTotalLbl);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Controls.Add(BonusDgv);
            Name = "ClassBonusForm";
            Text = "ClassBonusForm";
            ((System.ComponentModel.ISupportInitialize)BonusDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BonusDgv;
        private Button saveBtn;
        private Label label1;
        private Label skillTotalLbl;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Skill;
    }
}