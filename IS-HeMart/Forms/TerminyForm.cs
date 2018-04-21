using IS_HeMart.ServiceManagers;

namespace IS_HeMart.Forms
{
	public partial class TerminyForm : BaseForm
    {
		private DataManager _dataManager;
        public TerminyForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			terminVysetreniaBindingSource.DataSource = _dataManager.GetTerminyBindingSource();
        }
    }
}
