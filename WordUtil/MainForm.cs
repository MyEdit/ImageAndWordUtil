using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WordUtil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Image util start

        //Событие при дропе файла на панель
        private void PanelDragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string imagepath = files[0];

            if (imagepath.Contains(".png") || imagepath.Contains(".jpg") || imagepath.Contains(".jpeg"))
            {
                PlaceholderDragAndDrop.Visible = false;
                pictureBox2.Image = Image.FromFile(imagepath);
                pictureBox2.Tag = Convert.ToBase64String(File.ReadAllBytes(imagepath));
            }
            else
                MessageBox.Show("Ошибка", "Необходимо выбрать фото с форматом .png / .jpg / .jpeg");
        }

        //Событие при попадании мыши с файлом в зону панели DragAndDrop
        private void PanelDragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                PlaceholderDragAndDrop.Text = "Отпустите мышь";
                e.Effect = DragDropEffects.Copy;
            }
        }

        //Событие при выходе мыши с файлом из зоны панели DragAndDrop
        private void PanelDragAndDrop_DragLeave(object sender, EventArgs e)
        {
            PlaceholderDragAndDrop.Text = PlaceholderDragAndDrop.Tag.ToString();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length == 0)
                return;

            List<string[]> responce = DataBaseWorker.ExecuteQuery($"SELECT * FROM Medicines WHERE ID = {textBoxID.Text}", 5);

            if (responce == null)
                return;

            loadDataMedicinesItem(new Medicines(responce[0]));
            setDefaultValuesForDragAndDrop();
        }

        private void loadDataMedicinesItem(Medicines medicines)
        {
            ID.Text = medicines.ID.ToString();
            Name.Text = medicines.Name;
            Storage.Text = medicines.Storage;
            Count.Text = medicines.Count.ToString();

            Image image = medicines.Photo;
            if (image == null)
                pictureBox1.Image = new Bitmap(1, 1);
            else
                pictureBox1.Image = image;
        }

        private void setDefaultValuesForDragAndDrop()
        {
            pictureBox2.Image = new Bitmap(1, 1);
            PlaceholderDragAndDrop.Visible = true;
            PlaceholderDragAndDrop.Text = PlaceholderDragAndDrop.Tag.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseWorker.ExecuteQueryWithoutResponse($"UPDATE Medicines SET Photo = '{pictureBox2.Tag}' WHERE ID = {ID.Text}");
        }

        //Image util end
        //Word util start

        private void button2_Click(object sender, EventArgs e)
        {
            string inputWordDoc = AppDomain.CurrentDomain.BaseDirectory + "Check.docx";
            string outputWordDoc = AppDomain.CurrentDomain.BaseDirectory + "CheckOut.pdf";

            Dictionary<string, string> replacements = new Dictionary<string, string>
            {
                {"<Num>", textBoxNum.Text},
                {"<Cashier>", textBoxCashier.Text},
                {"<NumCash>", textBoxNumCash.Text},
                {"<Date>", DateTime.Now.Date.ToString()},
                {"<Service1>", textBoxService1.Text},
                {"<Service2>", textBoxService2.Text},
                {"<Service3>", textBoxService3.Text},
                {"<Quality1>", textBoxQuality1.Text},
                {"<Quality2>", textBoxQuality2.Text},
                {"<Quality3>", textBoxQuality3.Text},
                {"<Cost1>", textBoxCost1.Text},
                {"<Cost2>", textBoxCost2.Text},
                {"<Cost3>", textBoxCost3.Text}
            };
            replaceTagsInWordDoc(inputWordDoc, outputWordDoc, replacements);
        }

        private bool replaceTagsInWordDoc(string inputWordDoc, string outputWordDoc, Dictionary<string, string> replacements)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            try
            {
                Document document = wordApp.Documents.Open(inputWordDoc, ReadOnly: true);
                Range range = document.Content;
                Document newDoc = wordApp.Documents.Add();
                range.Copy();
                newDoc.Range().Paste();

                foreach (var replacement in replacements)
                {
                    newDoc.Content.Find.Execute(FindText: replacement.Key, ReplaceWith: replacement.Value, Replace: WdReplace.wdReplaceAll);

                }

                newDoc.SaveAs2(outputWordDoc, WdSaveFormat.wdFormatPDF);
                newDoc.Close(SaveChanges: false);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при формировании чека " + ex.Message);
                return false;
            }
            finally
            {
                wordApp.Quit();
            }
        }
        //Word util end
    }
}
