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
    public partial class FrmAlter : MetroFramework.Forms.MetroForm
    {
        private StadiumData data = new StadiumData();
        private int id;

        public FrmAlter()
        {
            InitializeComponent();
        }

        private void FrmAlter_Load(object sender, EventArgs e)
        {
            cmbStadium.DisplayMember = "nomeEstadio";
            cmbStadium.ValueMember = "idEstadio";
            cmbStadium.DataSource = data.ListData().Tables[0];
        }

        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(cmbStadium.SelectedValue.ToString());
            data.IdStadium = id;
            data.ConsultData();
            txtStadium.Text = data.StadiumName;
            txtState.Text = data.StadiumState;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            data.IdStadium = id;
            data.StadiumState = txtState.Text;
            data.StadiumName = txtStadium.Text;
            data.UpdateData();
            MessageBox.Show("Stadium succesfully updated");
            cmbStadium.DataSource = data.ListData().Tables[0];
        }
    }
}
