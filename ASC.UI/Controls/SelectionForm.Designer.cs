namespace ASC.UI.Controls
{
    partial class SelectionForm<T>
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
            SelectBtn = new Button();
            SelectionListView = new ListView();
            SuspendLayout();
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(210, 213);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(75, 23);
            SelectBtn.TabIndex = 1;
            SelectBtn.Text = "Select";
            SelectBtn.UseVisualStyleBackColor = true;
            // 
            // SelectionListView
            // 
            SelectionListView.Location = new Point(12, 12);
            SelectionListView.Name = "SelectionListView";
            SelectionListView.Size = new Size(273, 195);
            SelectionListView.TabIndex = 2;
            SelectionListView.View = View.Details;
            SelectionListView.UseCompatibleStateImageBehavior = false;
            // 
            // SelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 248);
            Controls.Add(SelectionListView);
            Controls.Add(SelectBtn);
            Name = "SelectionForm";
            Text = "SelectionForm";
            ResumeLayout(false);
        }

        #endregion
        private Button SelectBtn;
        private ListView SelectionListView;
    }
}