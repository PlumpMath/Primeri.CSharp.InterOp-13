using System;
using InteropExcel = Microsoft.Office.Interop.Excel;

namespace Excel
{
	public class IOWrite
	{
		private DataStruct _data;
		private InteropExcel.Application excel;

		public IOWrite (DataStruct data)
		{
		}

		public bool exportTable ()
		{
			try
			{
				//Подготовка
				excel = InteropExcel.Application ();

				if (excel == null) return false;

				InteropExcel.Workbook workbook = excel.Workbooks.Add ();
				if (workbook == null) return false;


				//Попълване на таблицата



				//Запаметяване
				workbook.SaveCopyAs ( getPath() );

				excel.DisplayAlerts = false; //Изключваме съобщенията на Ексел
				workbook.Close ();
				Excel.Quit ();

				return true;				
			}catch{
			}

			return false;
		}

		public void addRow ( DataRow _row)
		{
			try{
				
			}catch{
			}
		}
		public void runFile ()
		{
			try {
				System.Diagnostics.Process.Start (getPath() );
			} catch {
			}
		}
		private string getPath ()
		{
			return System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "Table1.xlsx");
		}
	}
}

