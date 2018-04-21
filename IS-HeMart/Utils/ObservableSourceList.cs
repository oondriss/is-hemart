using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;

namespace IS_HeMart.Utils
{
	public class ObservableListSource<T> : ObservableCollection<T>, IListSource	where T : class
	{
		private IBindingList _bindingList;

		bool IListSource.ContainsListCollection { get { return false; } }

		public IList GetList()
		{
			return _bindingList ?? (_bindingList = this.ToBindingList());
		}

		IList IListSource.GetList()
		{
			return _bindingList ?? (_bindingList = this.ToBindingList());
		}
	}
}
