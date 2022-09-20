using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ComGraph_Lab_3
{  


    public partial class Form1 : Form
    { //Объявляем переменные доступные в каждом обработчике события
        private Point PreviousPoint, point; //Точка до перемещения курсора мыши
                                            //и текущая точка
        private Bitmap bmp;
        private Pen blackPen;
        private Graphics g;
        private Image originalImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4); //подготавливаем перо
        }

        private void repleceObject(Control controller, int x)
        {
            controller.Location = new Point(controller.Location.X + x, controller.Location.Y);
        }
        private void replaceObjects(int x)
        {
            repleceObject(btnToOriginal, x);
            repleceObject(btnOpen, x);
            repleceObject(btnSave, x);
            repleceObject(btnPrewittX, x);
            repleceObject(btnPrewittY, x);
            repleceObject(btnSobelX, x);
            repleceObject(btnSobelY, x);
            repleceObject(btnRGBToGray, x);
            repleceObject(btnLaplacce, x);

            repleceObject(trackBarThreshold, x);

            repleceObject(label1, x);
            repleceObject(tbThreshold, x);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        { //открытие файла
            OpenFileDialog dialog = new OpenFileDialog();
            //задаем расширения файлов
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)| *.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно
            {
                int currentPictureBoxWidth = pictureBox1.Width;


                originalImage = Image.FromFile(dialog.FileName); //Загружаем в image
                                                               //изображение из выбранного файла
                int width = originalImage.Width;
                int height = originalImage.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                
                bmp = new Bitmap(originalImage, width, height); //создаем и загружаем из
                                                        //image изображение в формате bmp
                pictureBox1.Image = bmp; //записываем изображение в формате bmp
                                         //в pictureBox1
                g = Graphics.FromImage(pictureBox1.Image); //подготавливаем объект
                                                           //Graphics для рисования в pictureBox1
                replaceObjects(width - currentPictureBoxWidth);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { // обработчик события нажатия кнопки на мыши
          // записываем в предыдущую точку (PreviousPoint) текущие координаты
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {//Обработчик события перемещения мыши по pictuteBox1
            if (e.Button == MouseButtons.Left) //Проверяем нажатие левой кнопка
            { //запоминаем в point текущее положение курсора мыши
                point.X = e.X;
                point.Y = e.Y;
                //соединяем линией предыдущую точку с текущей
                g.DrawLine(blackPen, PreviousPoint, point);
                //текущее положение курсора мыши сохраняем в PreviousPoint
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();//Принудительно вызываем перерисовку
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        { //сохранение файла
            SaveFileDialog savedialog = new SaveFileDialog();
            //задаем свойства для savedialog
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "GIF File(*.gif)|*.gif|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                // в fileName записываем полный путь к файлу
                string fileName = savedialog.FileName;
                // Убираем из имени три последних символа (расширение файла)
                string strFilExtn =
                fileName.Remove(0, fileName.Length - 3);
                // Сохраняем файл в нужном формате и с нужным расширением
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void RGBToGray()
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int R = bmp.GetPixel(i, j).R; //извлекаем долю красного цвета
                    int G = bmp.GetPixel(i, j).G; //извлекаем долю зеленого цвета
                    int B = bmp.GetPixel(i, j).B; //извлекаем долю синего цвета
                    int Gray = (R + G + B) / 3; // высчитываем среднее
                    Color p = Color.FromArgb(255, Gray, Gray, Gray);

                    bmp.SetPixel(i, j, p); //записываем полученный цвет в точку
                }
        }

        private void btnRGBToGray_Click(object sender, EventArgs e)
        { //циклы для перебора всех пикселей на изображении
            RGBToGray();
            Refresh(); //вызываем функцию перерисовки окна
        }

        private void applyFilter(float[,] ker)
        {
            Bitmap newBmp = new Bitmap(bmp);
            Color p;
            int threshold = trackBarThreshold.Value;

            { //циклы для перебора всех пикселей на изображении
                for (int row = 0; row < bmp.Width; row++)
                    for (int col = 0; col < bmp.Height; col++)
                    {
                        //применяем ядро, если оно не выходит за границы изображения
                        if (row > 0 && row < bmp.Width - 1 && col > 0 && col < bmp.Height - 1)
                        {
                            int newValue = 0;

                            //циклы для перебора значений ядра со значениями в пикселях вокруг текущего
                            for (int kerRow = 0; kerRow < 3; ++kerRow)
                                for (int kerCol = 0; kerCol < 3; ++kerCol)
                                {
                                    int grey = bmp.GetPixel(row - 1 + kerRow, col - 1 + kerCol).R; //извлекаем долю серого
                                    
                                    int grad = (int)(ker[kerRow, kerCol] * (grey));

                                    newValue += grad;
                                }

                            newValue = (int)Math.Abs(newValue) > threshold ? 250 : 0;

                            p = Color.FromArgb(255, newValue, newValue, newValue);

                            newBmp.SetPixel(row, col, p); //записываем полученный цвет в точку

                        }
                        else
                        {
                            int R = bmp.GetPixel(row, col).R; //извлекаем долю красного цвета
                            int Gray = (R) / 3; // высчитываем среднее
                            p = Color.FromArgb(255, Gray, Gray, Gray);

                            newBmp.SetPixel(row, col, p); //записываем полученный цвет в точку
                        }

                    }

                //циклы для перебора всех пикселей на изображении
                for (int row = 0; row < bmp.Width; row++)
                    for (int col = 0; col < bmp.Height; col++)
                    {
                        int newValue = newBmp.GetPixel(row, col).R;
                        p = Color.FromArgb(255, newValue, newValue, newValue);

                        bmp.SetPixel(row, col, p);
                    }
                Refresh(); //вызываем функцию перерисовки окна
            }
        }

        private void refreshThreshold(object sender, EventArgs e)
        {
            tbThreshold.Text = string.Format("{0}", trackBarThreshold.Value);
        }

        private void btnPrewittX_Click(object sender, EventArgs e)
        {
            RGBToGray();
            float[,] ker = {
                { -1f, 0f, 1f },
                { -1f, 0f, 1f },
                { -1f, 0f, 1f } };
            applyFilter(ker);
        }

        private void btnPrewittY_Click(object sender, EventArgs e)
        {
            RGBToGray();
            float[,] ker = {
                { -1f, -1f, -1f },
                { 0f, 0f, 0f },
                { 1f, 1f, 1f } };
            applyFilter(ker);
        }

        private void btnSobelX_Click(object sender, EventArgs e)
        {
            RGBToGray();
            float[,] ker = {
                { -1f, 0f, 1f },
                { -2f, 0f, 2f },
                { -1f, 0f, 1f } };
            applyFilter(ker);
        }


        private void btnSobelY_Click(object sender, EventArgs e)
        {
            RGBToGray();

            float[,] ker = {
                { -1f, -1f, -1f },
                { 0f, 0f, 0f },
                { 1f, 2f, 1f } };
            applyFilter(ker);

        }

        private void btnLaplacce_Click(object sender, EventArgs e)
        {
            RGBToGray();

            float[,] ker = {
                { -1f, -1f, -1f },
                { -1f, 8f, -1f },
                { -1f, -1f, -1f } };
            applyFilter(ker);
        }

        private void toOriginal(object sender, EventArgs e)
        {
            pictureBox1.Image = originalImage;
            bmp = new Bitmap(originalImage, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = bmp;

            g = Graphics.FromImage(pictureBox1.Image);

        }
    }
}
