using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Forms;

namespace Tcp_İp_haberleşmesi
{
    public class ExcelDosya
    {
        public int t_row { get; set;} = 5;
        public int t_column { get; set; } = 5;
        public string dosyaYolu { get; set; }
        public string VERİ { get; set; }
      
        
        public void VeriKaydetme()
        {
            Excel.Application ExcelUygulama;
            Excel.Workbook ExcelProje;
            Excel.Worksheet ExcelSayfa;
            object Missing = System.Reflection.Missing.Value;
            Excel.Range ExcelRange;

            ExcelUygulama = new Excel.Application();
            ExcelProje = ExcelUygulama.Workbooks.Add(Missing);
            ExcelSayfa = (Excel.Worksheet)ExcelProje.Worksheets.get_Item(1);
            ExcelRange = ExcelSayfa.UsedRange;
            ExcelSayfa = (Excel.Worksheet)ExcelUygulama.ActiveSheet;

            ExcelUygulama.Visible = false;
            ExcelUygulama.AlertBeforeOverwriting = false;

            
           
            if (VERİ != "" && t_row != 0 && t_column != 0)
            {
                Excel.Range bolge = (Excel.Range)ExcelSayfa.Cells[t_row, t_column];
                bolge.Value2 = VERİ;

               MessageBox.Show("İlgili bloğa başarıyla yazıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen bir veri giriniz. (Satır veya Sütun sıfır olamaz.)");
            }

            
            if (dosyaYolu != "")
            {
                ExcelProje.SaveAs(dosyaYolu, Excel.XlFileFormat.xlWorkbookDefault, Missing, Missing, false, Missing, Excel.XlSaveAsAccessMode.xlNoChange);
                ExcelProje.Close(true, Missing, Missing);
                ExcelUygulama.Quit();
                MessageBox.Show("Dosya Başarıyla Kaydedildi.");
            }
            else
            {
                MessageBox.Show("Lütfen Bir Dosya Adı Giriniz.");
            }

            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ExcelUygulama);
            ExcelUygulama = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            t_column++;
        }

      
    }
    
}

