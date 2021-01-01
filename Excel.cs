using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Starport
{

	class Excel
	{
		string path = "";
		_Application excel = new Microsoft.Office.Interop.Excel.Application();

		Workbook wb;
		Worksheet ws;

		public Excel(string path, int Sheet)
		{
			this.path = path;
			wb = excel.Workbooks.Open(path);
			ws = wb.Worksheets[Sheet];
		}

		public string ReadCell(int i, int j)
		{
			i++;
			j++;
			if (ws.Cells[i, j].Value2 != null) return ws.Cells[i, j].Value2;

			else return "";
		}
	}

}


