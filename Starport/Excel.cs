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

		/// <summary>
		/// Read cell if string
		/// </summary>
		/// <param name="i">row</param>
		/// <param name="j">column</param>
		/// <returns></returns>
		public string ReadCellString(int i, int j)
		{
			i++;
			j++;
			if (ws.Cells[i, j].Value2 != null) return ws.Cells[i, j].Value2;

			else return "";
		}
		/// <summary>
		/// Read cell if double
		/// </summary>
		/// <param name="i">row</param>
		/// <param name="j">column</param>
		/// <returns></returns>
		public double ReadCellDouble(int i, int j)
		{
			i++;
			j++;
			if (ws.Cells[i, j].Value2 != null) return ws.Cells[i, j].Value2;

			else return 0;
		}
		/// <summary>
		/// Write to cell
		/// </summary>
		/// <param name="i">row</param>
		/// <param name="j">column</param>
		/// <param name="s">what you want to write</param>
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


