namespace ASC.UI.UtilForms
{
    partial class AttributeLoad
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
            DescRtxt = new RichTextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            AttributeDgv = new DataGridView();
            AttributeLoadName = new DataGridViewTextBoxColumn();
            AttributeLoadDescription = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttributeDgv).BeginInit();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(350, 99);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 25);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Desc :";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(59, 22);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(100, 23);
            NameTxt.TabIndex = 3;
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.Location = new Point(10, 103);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(43, 15);
            LogLbl.TabIndex = 6;
            LogLbl.Text = "LogLbl";
            // 
            // DescRtxt
            // 
            DescRtxt.Location = new Point(219, 22);
            DescRtxt.Name = "DescRtxt";
            DescRtxt.Size = new Size(206, 71);
            DescRtxt.TabIndex = 8;
            DescRtxt.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NameTxt);
            groupBox1.Controls.Add(DescRtxt);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(LogLbl);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 134);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Attribute";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 36;
            label3.Text = "Browser";
            // 
            // AttributeDgv
            // 
            AttributeDgv.AllowUserToAddRows = false;
            AttributeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttributeDgv.Columns.AddRange(new DataGridViewColumn[] { AttributeLoadName, AttributeLoadDescription });
            AttributeDgv.Location = new Point(12, 172);
            AttributeDgv.Name = "AttributeDgv";
            AttributeDgv.ReadOnly = true;
            AttributeDgv.RowHeadersVisible = false;
            AttributeDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AttributeDgv.Size = new Size(427, 231);
            AttributeDgv.TabIndex = 35;
            // 
            // AttributeLoadName
            // 
            AttributeLoadName.DataPropertyName = "Name";
            AttributeLoadName.HeaderText = "Name";
            AttributeLoadName.Name = "AttributeLoadName";
            AttributeLoadName.ReadOnly = true;
            // 
            // AttributeLoadDescription
            // 
            AttributeLoadDescription.DataPropertyName = "Description";
            AttributeLoadDescription.HeaderText = "Description";
            AttributeLoadDescription.Name = "AttributeLoadDescription";
            AttributeLoadDescription.ReadOnly = true;
            // 
            // AttributeLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 417);
            Controls.Add(label3);
            Controls.Add(AttributeDgv);
            Controls.Add(groupBox1);
            Name = "AttributeLoad";
            Text = "AttributeLoad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttributeDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private Label label1;
        private Label label2;
        private TextBox NameTxt;
        private Label LogLbl;
        private RichTextBox DescRtxt;
        private GroupBox groupBox1;
        private Label label3;
        private DataGridView AttributeDgv;
        private DataGridViewTextBoxColumn AttributeLoadName;
        private DataGridViewTextBoxColumn AttributeLoadDescription;
    }
}