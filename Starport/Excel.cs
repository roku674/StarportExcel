using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace StarportExcel
{
	class Excel
	{
		readonly string path = "";
        _Application excel = new Microsoft.Office.Interop.Excel.Application();
		static Dictionary<string, Worksheet> dict = new Dictionary<string, Worksheet>();
		Workbook wb;
		Worksheet ws;

		public Excel(string path, int Sheet)
		{
			this.path = path;
			excel.DisplayAlerts = false;
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
			if (ws.Cells[i, j].Value != null) return ws.Cells[i, j].Value;

			else return "";
		}
		/// <summary>
		/// Read cell if double will return 0 if nothing is in the cell
		/// </summary>
		/// <param name="i">row</param>
		/// <param name="j">column</param>
		/// <returns></returns>
		public double ReadCellDouble(int i, int j)
		{
			i++;
			j++;
			if (ws.Cells[i, j].Value != null) return ws.Cells[i, j].Value;

			else return 0;
		}
		public int ReadCellInt(int i, int j)
        {
			i++;
			j++;
			if (ws.Cells[i, j].Value != null) return (int) ws.Cells[i, j].Value;

			else return 0;
		}
		public bool ReadCellBool(int i, int j)
        {
			i++;
			j++;
			if (ws.Cells[i, j].Value == null)
			{
				return false;
			}

			if (ws.Cells[i, j].Value == true)
			{
				return true;
			}
			else
			{ 
				return false; 
			}
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
			ws.Cells[i, j].Value = s;
		}
		public static Dictionary<string, Worksheet> GetDictionairy()
        {
			return dict;
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
			Save();
			GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
			GC.WaitForPendingFinalizers();
			excel.Quit();
			Marshal.FinalReleaseComObject(ws);
			Marshal.FinalReleaseComObject(wb);
			Marshal.FinalReleaseComObject(excel);
			GC.Collect();
			GC.WaitForPendingFinalizers();

		}
		public static void Kill()
        {
			Process[] processes = Process.GetProcessesByName("EXCEL");
			foreach (Process p in processes)
			{
				p.Kill();
			}
		}
		//public static int ReleaseComObject(object o);       
	}

}


