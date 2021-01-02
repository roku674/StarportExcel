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

		public string ReadCellString(int i, int j)
		{
			i++;
			j++;
			//if (ws.Cells[i, j].Value2 != null) return ws.Cells[i, j].Value2;

			//else return "ERROR";

			return "";
		}
		public double ReadCellDouble(int i, int j)
		{
			i++;
			j++;
			if (ws.Cells[i, j].Value2 != null) return ws.Cells[i, j].Value2;

			else return -1;
		}

		public void WriteToCell(int i, int j, string s)
        {
			i++;
			j++;
			ws.Cells[i, j].Value2 = s;
        }

		public void Save()
        {
			wb.Save();
        }
		public void SaveAs(string path)
        {
			wb.SaveAs(path);
        }

		public void Close()
        {
			wb.Close();
        }
	}

}


