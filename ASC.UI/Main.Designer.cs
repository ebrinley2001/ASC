namespace ASC.UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CharacterBtn = new Button();
            groupBox1 = new GroupBox();
            SkillBtn = new Button();
            RaceBtn = new Button();
            ClassBtn = new Button();
            AttributeBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CharacterBtn
            // 
            CharacterBtn.Location = new Point(199, 93);
            CharacterBtn.Name = "CharacterBtn";
            CharacterBtn.Size = new Size(107, 52);
            CharacterBtn.TabIndex = 1;
            CharacterBtn.Text = "Create Character";
            CharacterBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SkillBtn);
            groupBox1.Controls.Add(RaceBtn);
            groupBox1.Controls.Add(ClassBtn);
            groupBox1.Controls.Add(AttributeBtn);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(83, 135);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Data";
            // 
            // SkillBtn
            // 
            SkillBtn.Location = new Point(3, 106);
            SkillBtn.Name = "SkillBtn";
            SkillBtn.Size = new Size(75, 23);
            SkillBtn.TabIndex = 3;
            SkillBtn.Text = "Skill";
            SkillBtn.UseVisualStyleBackColor = true;
            // 
            // RaceBtn
            // 
            RaceBtn.Location = new Point(3, 77);
            RaceBtn.Name = "RaceBtn";
            RaceBtn.Size = new Size(75, 23);
            RaceBtn.TabIndex = 2;
            RaceBtn.Text = "Race";
            RaceBtn.UseVisualStyleBackColor = true;
            // 
            // ClassBtn
            // 
            ClassBtn.Location = new Point(3, 48);
            ClassBtn.Name = "ClassBtn";
            ClassBtn.Size = new Size(75, 23);
            ClassBtn.TabIndex = 1;
            ClassBtn.Text = "Class";
            ClassBtn.UseVisualStyleBackColor = true;
            // 
            // AttributeBtn
            // 
            AttributeBtn.Location = new Point(3, 19);
            AttributeBtn.Name = "AttributeBtn";
            AttributeBtn.Size = new Size(75, 23);
            AttributeBtn.TabIndex = 0;
            AttributeBtn.Text = "Attribute";
            AttributeBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 157);
            Controls.Add(groupBox1);
            Controls.Add(CharacterBtn);
            Name = "Main";
            Text = "Aelimor Sheet Creator";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button CharacterBtn;
        private GroupBox groupBox1;
        private Button SkillBtn;
        private Button RaceBtn;
        private Button ClassBtn;
        private Button AttributeBtn;
    }
}
