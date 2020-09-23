using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace Config
{
    public partial class ConfigManager : Form
    {
        public ConfigManager()
        {
            InitializeComponent();
        }
        string defaultPath = string.Empty;

        private void CreatTemplate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(pathLable.Text))
            {
                MessageBox.Show("请先选择项目路径");
            }
            else
            {

            }

            CreatExcelTemolate();
        }

        //private string projectPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private bool CreatExcelTemolate()
        {
            bool result = false;
            try
            {
                System.Reflection.Missing missing = System.Reflection.Missing.Value;
                Excel.Application app = new Excel.ApplicationClass();
                Excel.Workbooks workbooks = app.Workbooks;
                Excel.Workbook workbook = workbooks.Add(missing);
                Excel.Worksheet worksheet = workbook.Sheets[1] as Excel.Worksheet;
                worksheet.Name = "Only This";

                worksheet.Cells[1, 1] = "类型";
                worksheet.Cells[1, 2] = "int";

                worksheet.Cells[2, 1] = "描述";
                worksheet.Cells[2, 2] = "对象的id";

                worksheet.Cells[3, 1] = "字段名";
                worksheet.Cells[3, 2] = "id";

                string excelPathRoot = pathLable.Text + "/GameTable";
                if (Directory.Exists(excelPathRoot) == false)
                {
                    Directory.CreateDirectory(excelPathRoot);
                }

                worksheet.SaveAs(excelPathRoot + "/默认模板.xlsx");
                workbook.Close();
                app.Quit();

                //打开文件夹
                System.Diagnostics.Process.Start("explorer.exe", excelPathRoot + @"\");

            }
            catch (Exception e)
            {
                MessageBox.Show($"创建错误：{e.Message}");
            }



            return result;
        }

        private void SelectProject_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择项目目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathLable.Text = dialog.SelectedPath;
                Config.Properties.Settings.Default.PATH = pathLable.Text;
            }
        }

        private void ConfigManager_Load(object sender, EventArgs e)
        {
            Config.Properties.Settings.Default.Save();
        }

        private void CreatBinaryBtn_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 生成c#结构类
        /// </summary>
        private void CreatCFile()
        { 
        
        }

        /// <summary>
        /// 生成二进制文件
        /// </summary>
        private void CreatBinaryFile()
        {
        
        }


    }

}
