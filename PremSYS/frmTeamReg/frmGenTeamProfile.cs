using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTeamReg
{

    public partial class frmGenTeamProfile : Form
    {
        frmMainMenu parent;
        public frmGenTeamProfile(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previous (parent) form
            parent.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmGenTeamProfile_Load(object sender, EventArgs e)
        {
                //load combo with TeamID and Team_Name for all Teams
                DataSet ds = new DataSet();
                ds = Team.getAllTeams(ds);

                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                    cboTeams.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get unplayed fixtures for team
            DataSet ds = new DataSet();
            ds = Team.getAllTeams(ds);

            /* for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                grdTeamInfo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString().PadRight(20) 
                    + " " + ds.Tables[0].Rows[i][2].ToString().PadRight(20) + " " + ds.Tables[0].Rows[i][3].ToString().PadRight(20) + " " 
                    + ds.Tables[0].Rows[i][4].ToString().PadRight(20) + " " + ds.Tables[0].Rows[i][5].ToString().PadRight(20) + " "); */

            //display fixtures
            grdTeamInfo.Visible = true;
        }

        private void grdTeamInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
