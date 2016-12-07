using System.Linq;
using System.Windows.Forms;
using Business;
using DataAccess;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace Final
{
	public partial class FormReportAbsence : Form
	{
		public FormReportAbsence()
		{
			InitializeComponent();
			
			gridControl1.DataSource = Utilities.rp();
			InitLookUpEditClub();
		}

		private void InitLookUpEditClub()
		{
			var clubList = ClubBusiness.GetAll();
			var riLookUpClub = new RepositoryItemLookUpEdit
			{
				DataSource = clubList,
				ValueMember = "ClubId",
				DisplayMember = "Name",
				DropDownRows = clubList.Count,
				BestFitMode = BestFitMode.BestFit,
				SearchMode = SearchMode.AutoComplete,
				AutoSearchColumnIndex = 1
			};
			gridView2.Columns["ClubId"].ColumnEdit = riLookUpClub;
		}
	}
}