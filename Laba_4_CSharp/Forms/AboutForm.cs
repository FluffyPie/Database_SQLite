using System;
using System.Windows.Forms;

namespace Laba_4_CSharp.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void CloseAboutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
