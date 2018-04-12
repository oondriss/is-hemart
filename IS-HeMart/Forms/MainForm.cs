using IS_HeMart.DataModel;
using IS_HeMart.DataModel.DTO;
using IS_HeMart.Forms;
using IS_HeMart.Forms.Parameters;
using IS_HeMart.ServiceManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_HeMart
{
	public partial class MainForm : BaseForm
	{
		private DataManager _dataManager = new DataManager();
		public MainForm()
		{
			InitializeComponent();
			LoadData();
		}

		public override bool LoginNeeded()
		{
			return true;
		}

		private void LoadData()
		{
			var items = _dataManager.GetPacient();//.GetZamestnanecDTO();
			pacientGrid.DataSource = items;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void FrmMain_Shown(object sender, EventArgs e)
		{
			
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pacientGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedId = pacientGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
			MessageBox.Show(selectedId);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var pacientId = (int)pacientGrid.SelectedRows[0].Cells[0].Value;
			var frm = FormManager.Current.CreateForm<PacientDetailForm>();
			frm.SetParameters(new PacientDetailParameters()
			{
				Operation = PacientDetailOperation.Detail,
				PacientID = pacientId
			});
			frm.Show();
		}

        private void pacientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}