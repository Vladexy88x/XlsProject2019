using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelanceProj1.LoadFiles
{
    class LoadFile
    {
        /// <summary>
        /// Загрузка файла .xlsx
        /// </summary>
        /// <param name = "openFileDialog"> Загрузка файла.xlsx</param>
        public LoadFile()
        {
            
        }

        public string CustomLoadFile(OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Load files (*.xls,*.xlsx) | *.xls; *.xlsx;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Loaded!");
            }
            else
            {
                MessageBox.Show("Файл не выбран");
                return null;
            }
            openFileDialog.Dispose();

            return openFileDialog.FileName;
        }
    }
}
