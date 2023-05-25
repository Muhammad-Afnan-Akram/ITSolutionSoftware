using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using ITSolutionSoftware.General;

namespace ITSolutionSoftware.Screens
{
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm
    {
        public DefineProductScreen()
        {
            InitializeComponent();
        }
        public bool IsUpdate { get; set; }


        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            if (!this.IsUpdate)
            {

            }
            LoadAllSizesinDataGridView();

        }
        private void LoadAllSizesinDataGridView()
        {
            ProductSize_Gridbox.DataSource = GetSizesData();
        }
        private DataTable GetSizesData()
        {
            DataTable dtsizes = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Sizes_LoadAllSizes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", 1);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtsizes.Load(sdr);
                    sdr.Close(); // Close the SqlDataReader after loading data into the DataTable
                }
            }
            return dtsizes;
        }

        private void ProductSize_Gridbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}