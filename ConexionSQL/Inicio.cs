using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionSQL
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();      
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cbTabla.DisplayMember = "TABLE_NAME";
            cbTabla.DataSource = ConexionSQL.FillData("SELECT * FROM information_schema.tables");
        }

        private void cbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTabla.DataSource = ConexionSQL.FillData("SELECT * FROM " + cbTabla.Text);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if(txtComando.Text != null)
            {
                dgvTabla.DataSource = ConexionSQL.FillData(txtComando.Text);
            }          
        }
    }
}
