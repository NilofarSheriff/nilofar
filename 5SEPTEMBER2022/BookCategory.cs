using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class BookCategory
    {
		private int _catid;

		public int CatId
		{
			get { return _catid; }
			set { _catid = value; }
		}

		private string _catname;

		public string CatName
		{
			get { return _catname; }
			set { _catname = value; }
		}

		private string _catdesc;

		public string Catdesc
		{
			get { return _catdesc; }
			set { _catdesc = value; }
		}

		public BookCategory()
		{

		}

		public BookCategory(int Bookcatid, string CattName)
		{
			this.CatId = Bookcatid;
			this.CatName = CattName;

		}


	}
}
