using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroFrameworkProject
{
    public partial class FrmInclude : MetroFramework.Forms.MetroForm
    {
        private StadiumData data = new StadiumData();

        public FrmInclude()
        {
            InitializeComponent();
        }

        private void cmdInclude_Click(object sender, EventArgs e)
        {
            data.StadiumName = txtStadium.Text;
            data.StadiumState = txtState.Text;
            data.IncludeData();
            txtStadium.Clear();
            txtState.Clear();
            MessageBox.Show("Stadium succesfully added");
        }
    }
}
