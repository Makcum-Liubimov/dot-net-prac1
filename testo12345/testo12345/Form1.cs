using System;
using System.Windows.Forms;
using MonthCheckBoxLibrary;

namespace testo12345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCheckBoxGroup();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCheckBoxGroup();
        }
        private void InitializeCheckBoxGroup()
        {
            MonthCheckBoxGroup checkBoxGroup = new MonthCheckBoxGroup();
            checkBoxGroup.Location = new System.Drawing.Point(10, 10);
            checkBoxGroup.Size = new System.Drawing.Size(200, 300);
            this.Controls.Add(checkBoxGroup);
        }
    }
}
