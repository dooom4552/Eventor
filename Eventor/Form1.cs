using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Eventor
{
    public partial class Form1 : Form
    {
        Excel.Application ObjExcel = new Excel.Application();
        string name;
        string directoryName;
        string fileInfofull;





        private void WriteCell(string str, string name)
        {
            try
            {
                Excel.Application ObjExcel = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                Excel.Workbooks ObjWorkbooks = ObjExcel.Workbooks; // Получаем список открытых книг

                //MessageBox.Show("Сколько открыто книг"+ ObjWorkbooks.Count.ToString());

                List<string> listnames = new List<string>();
                foreach (Excel.Workbook wb in ObjWorkbooks) //разбор книг на коллекцию
                {
                    listnames.Add(wb.Name);
                }
                listnames.Distinct();

                if (name == null)
                {
                    MessageBox.Show("The target Log Book is not selected. Select one");
                }
                //MessageBox.Show(listnames.Contains(name).ToString());

                if (!listnames.Contains(name) & name != null)


                {
                    Form f2 = new Form();
                    f2.StartPosition = FormStartPosition.CenterScreen;
                    f2.TopMost = true;
                    f2.ControlBox = false;
                    f2.Size = new Size(500, 140);
                    f2.Text = "The target Log Book " + name + " closed. Unable to record event";
                    Button button_Openfolder = new Button();
                    button_Openfolder.Text = "Open containing folder";
                    button_Openfolder.Size = new Size(400, 25);
                    button_Openfolder.Location = new Point(10, 10);
                    button_Openfolder.Click += button_Openfolder_Click;
                    button_Openfolder.Click += button_dismisstheevent_Click;

                    Button button_OpentargetLogBook = new Button();
                    button_OpentargetLogBook.Text = "Open target Log Book and log the event";
                    button_OpentargetLogBook.Size = new Size(400, 25);
                    button_OpentargetLogBook.Location = new Point(10, 40);
                    button_OpentargetLogBook.Click += button_OpentargetLogBook_Click;
                    button_OpentargetLogBook.Click += button_dismisstheevent_Click;

                    Button button_dismisstheevent = new Button();
                    button_dismisstheevent.Text = "OK, dismiss the event";
                    button_dismisstheevent.Size = new Size(400, 25);
                    button_dismisstheevent.Location = new Point(10, 70);
                    button_dismisstheevent.Click += button_dismisstheevent_Click;



                    f2.Controls.Add(button_Openfolder);
                    f2.Controls.Add(button_OpentargetLogBook);
                    f2.Controls.Add(button_dismisstheevent);
                    f2.ShowDialog();
                    // события

                    void button_Openfolder_Click(object sender, EventArgs e)// 
                    {
                        System.Diagnostics.Process.Start("explorer", directoryName);
                    }


                    void button_dismisstheevent_Click(object sender, EventArgs e)// 
                    {
                        f2.Close();
                    }
                    void button_OpentargetLogBook_Click(object sender, EventArgs e)/// Открытие файла
                    {
                        try
                        {

                            Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(fileInfofull, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                 Type.Missing, Type.Missing);
                            //label_Message.Text = ObjExcel.Workbooks.Count.ToString();
                            ObjExcel.Visible = true;
                            f2.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                foreach (Excel.Workbook wb in ObjWorkbooks)//разбор книг на коллекцию
                {

                    if (wb.Name == name)// имя книги должно совпасть с именем выбранной
                    {



                        int lastRow = wb.ActiveSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                        int lastRow2 = 0;
                        for (int i = lastRow; i >= 1; i--)
                        {
                            if (wb.ActiveSheet.Cells[i, 1].Value != null)
                            {
                                lastRow2 = i;
                                break;
                            }
                        }

                        lastRow2 = lastRow2 + 1;
                        wb.ActiveSheet.Cells[lastRow2, 3] = str;
                        wb.ActiveSheet.Cells[lastRow2, 1] = DateTime.Now.ToShortDateString();
                        wb.ActiveSheet.Cells[lastRow2, 2] = DateTime.Now.ToLongTimeString();
                        wb.Save();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Events.Evt"))
            {
                button_1.Visible = true;

                using (StreamReader sr = new StreamReader("Events.Evt", System.Text.Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        int lineLength = line.Length;
                        line = line.Substring(line.IndexOf(" ") + 1, lineLength - line.IndexOf(" ") - 1);

                        ComboBox_Message.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Log Book  отсутствует");
                Environment.Exit(0);
            }
            try
            {
                ComboBox_Message.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Log Book пустой Eventоr будет закрыт");
                Environment.Exit(0);
            }

            {
                ToolTip t = new ToolTip();
                t.SetToolTip(button_Exit, "Minimize to tray");
            }
        }

        private void button_1_Click(object sender, EventArgs e)/// Открытие файла
        {
            try
            {

                Excel.Application ObjExcell = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                Excel.Workbooks ObjWorkbooks = ObjExcell.Workbooks; // Получаем список открытых книг

                //MessageBox.Show("Сколько открыто книг"+ ObjWorkbooks.Count.ToString());

                List<string> listnames = new List<string>();
                foreach (Excel.Workbook wb in ObjWorkbooks) //разбор книг на коллекцию
                {
                    listnames.Add(wb.Name);
                }
                listnames.Distinct();// убирает повторные имена
                //var s = string.Join(" ", listnames);
                //MessageBox.Show(s.ToString());


                OpenFileDialog dial = new OpenFileDialog();
                dial.InitialDirectory = directoryName;
                //dial.Filter = "Excel files (*.xls, *.xlsx, *.xlsm)|*.xls;*.xlsx;*.xlsm";
                dial.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (dial.ShowDialog() == DialogResult)
                { }
                else
                {
                    if (!listnames.Contains(name)) //проверка открыт ли файл с таким именем если открыт то больше его открывать не надо                
                    {
                        Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(dial.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                             Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                             Type.Missing, Type.Missing);
                        ObjWorkBook.Close();
                    }
                    FileInfo fileInfo = new FileInfo(dial.FileName);
                    name = fileInfo.Name;
                    directoryName = fileInfo.DirectoryName;
                    fileInfofull = fileInfo.FullName;
                    Label_FileName.Text = name;
                    notifyIcon1.Text = name;
                }

            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)// добавление сообщения
        {
            WriteCell(ComboBox_Message.SelectedItem.ToString(), name);

        }



        private void выходToolStripMenuItem_Click(object sender, EventArgs e)//выход из контекстного меню в систем трее
        {
            ObjExcel.Quit();
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)// кнопка свернуть на форме
        {
            this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)// двойной клик в систем трее
        {
            this.Visible = true;
            this.BringToFront();
        }

        private void showEventorToolStripMenuItem_Click(object sender, EventArgs e)// нажатие showEventor показывает форму
        {
            this.Visible = true;
            this.BringToFront();
        }

        private void checkBox_alwaysontop_CheckedChanged(object sender, EventArgs e)// Always on Top основной формы чек бокс
        {
            if (checkBox_alwaysontop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }




    }
}
