namespace MonthCheckBoxApp
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.monthCheckBoxGroup = new MonthCheckBoxLibrary.MonthCheckBoxGroup();
            this.SuspendLayout();
            // 
            // monthCheckBoxGroup
            // 
            this.monthCheckBoxGroup.Location = new System.Drawing.Point(12, 12);
            this.monthCheckBoxGroup.Name = "monthCheckBoxGroup";
            this.monthCheckBoxGroup.Size = new System.Drawing.Size(200, 400);
            this.monthCheckBoxGroup.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCheckBoxGroup);
            this.Name = "Form1";
            this.Text = "Month CheckBox App";
            this.ResumeLayout(false);
        }

        private MonthCheckBoxLibrary.MonthCheckBoxGroup monthCheckBoxGroup;
    }
}
