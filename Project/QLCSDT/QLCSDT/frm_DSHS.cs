using QLCSDT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCSDT
{
    public partial class frm_DSHS : Form
    {
        public frm_DSHS(int id)
        {
            InitializeComponent();
            loatdshs(id);
        }
        public void loatdshs(int id)
        {
            dgv_DSHS.DataSource = InfoPhongDAO.Instance.LoadDSHS(id);
        }
    }
}
