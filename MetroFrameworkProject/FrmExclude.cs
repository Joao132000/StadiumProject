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
    public partial class FrmExclude : MetroFramework.Forms.MetroForm
    {
        private StadiumData data = new StadiumData();
        private int id;

        public FrmExclude()
        {
            InitializeComponent();
        }

        private void FrmExclude_Load(object sender, EventArgs e)
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            data.IdStadium = id;
            data.DeleteData();
            MessageBox.Show("Stadium succesfully deleted");
            txtState.Clear();
            txtStadium.Clear();
            cmbStadium.DataSource = data.ListData().Tables[0];

        }
    }
}
