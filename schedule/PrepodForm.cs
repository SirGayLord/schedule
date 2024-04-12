using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule
{
    public partial class PrepodForm : Form
    {
        public PrepodForm()
        {
            InitializeComponent();

            // Заполняем список файлов Excel при инициализации формы
            FillExcelFilesList();
        }

        private void FillExcelFilesList()
        {
            string directoryPath = @"C:\Users\Pops\Desktop\Препод";
            string[] excelFiles = Directory.GetFiles(directoryPath, "*.xlsx"); // Получаем список файлов Excel в указанной директории

            foreach (string file in excelFiles)
            {
                // Добавляем каждый файл Excel в ListBox
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim().ToLower();

            listBox1.Items.Clear(); // Очищаем список перед поиском

            string directoryPath = @"C:\Users\Pops\Desktop\Препод";
            string[] excelFiles = Directory.GetFiles(directoryPath, "*.xlsx"); // Получаем список файлов Excel в указанной директории

            foreach (string file in excelFiles)
            {
                string fileName = Path.GetFileName(file).ToLower();
                if (fileName.Contains(searchText)) // Проверяем, содержит ли имя файла искомый текст
                {
                    // Добавляем файл в ListBox, если соответствует критериям поиска
                    listBox1.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string filePath = listBox1.SelectedItem.ToString();
            string directoryPath = @"C:\Users\Pops\Desktop\Препод";
            string fullFilePath = Path.Combine(directoryPath, filePath);

            Process.Start(fullFilePath);
        }
    }
}
