using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using TKP.Views;
using TKP.Model;
using TKP.ViewModel;
using Excel =Microsoft.Office.Interop.Excel;

using Word = Microsoft.Office.Interop.Word;


using Microsoft.Office.Core;


using System.IO;

namespace TKP
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Window
    {

        public Home()
        {
            InitializeComponent();
        }
        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMenu.Visibility = Visibility.Visible;
            btnOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void btnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCloseMenu.Visibility = Visibility.Collapsed;
            btnOpenMenu.Visibility = Visibility.Visible;
        }

   
        private void btnHelp_Click_1(object sender, RoutedEventArgs e)
        {
            WindowHelp windowHelp = new WindowHelp();
            windowHelp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string link = "https://vk.com/abs_software_studio";
            System.Diagnostics.Process.Start(link);
        }

        private void ExcelForm_Click(object sender, RoutedEventArgs e)
        {

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];
            sheet1.Columns.AutoFit();

            for (int j = 0; j < DataGridView.Columns.Count; j++)
            {
                Excel.Range myRange = (Excel.Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true;
                sheet1.Columns[j + 1].ColumnWidth = 15;
                myRange.Value2 = DataGridView.Columns[j].Header;
            }
            for (int i = 0; i < DataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < DataGridView.Items.Count; j++)
                {
                    TextBlock b = DataGridView.Columns[i].GetCellContent(DataGridView.Items[j]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
        }
    }


}
