
namespace ComGraph_Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRGBToGray = new System.Windows.Forms.Button();
            this.btnPrewittX = new System.Windows.Forms.Button();
            this.btnSobelX = new System.Windows.Forms.Button();
            this.tbThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.btnPrewittY = new System.Windows.Forms.Button();
            this.btnSobelY = new System.Windows.Forms.Button();
            this.btnToOriginal = new System.Windows.Forms.Button();
            this.btnLaplacce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 497);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(28, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRGBToGray
            // 
            this.btnRGBToGray.Location = new System.Drawing.Point(28, 347);
            this.btnRGBToGray.Name = "btnRGBToGray";
            this.btnRGBToGray.Size = new System.Drawing.Size(75, 37);
            this.btnRGBToGray.TabIndex = 3;
            this.btnRGBToGray.Text = "Градация серого";
            this.btnRGBToGray.UseVisualStyleBackColor = true;
            this.btnRGBToGray.Click += new System.EventHandler(this.btnRGBToGray_Click);
            // 
            // btnPrewittX
            // 
            this.btnPrewittX.Location = new System.Drawing.Point(109, 301);
            this.btnPrewittX.Name = "btnPrewittX";
            this.btnPrewittX.Size = new System.Drawing.Size(75, 48);
            this.btnPrewittX.TabIndex = 4;
            this.btnPrewittX.Text = "Фильтр Превитта по x";
            this.btnPrewittX.UseVisualStyleBackColor = true;
            this.btnPrewittX.Click += new System.EventHandler(this.btnPrewittX_Click);
            // 
            // btnSobelX
            // 
            this.btnSobelX.Location = new System.Drawing.Point(109, 355);
            this.btnSobelX.Name = "btnSobelX";
            this.btnSobelX.Size = new System.Drawing.Size(75, 37);
            this.btnSobelX.TabIndex = 5;
            this.btnSobelX.Text = "Фильтр Собеля по x";
            this.btnSobelX.UseVisualStyleBackColor = true;
            this.btnSobelX.Click += new System.EventHandler(this.btnSobelX_Click);
            // 
            // tbThreshold
            // 
            this.tbThreshold.Enabled = false;
            this.tbThreshold.Location = new System.Drawing.Point(82, 244);
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(47, 20);
            this.tbThreshold.TabIndex = 6;
            this.tbThreshold.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Порог:";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(135, 235);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(175, 45);
            this.trackBarThreshold.TabIndex = 8;
            this.trackBarThreshold.Value = 100;
            this.trackBarThreshold.Scroll += new System.EventHandler(this.refreshThreshold);
            // 
            // btnPrewittY
            // 
            this.btnPrewittY.Location = new System.Drawing.Point(190, 301);
            this.btnPrewittY.Name = "btnPrewittY";
            this.btnPrewittY.Size = new System.Drawing.Size(75, 48);
            this.btnPrewittY.TabIndex = 9;
            this.btnPrewittY.Text = "Фильтр Превитта по y";
            this.btnPrewittY.UseVisualStyleBackColor = true;
            this.btnPrewittY.Click += new System.EventHandler(this.btnPrewittY_Click);
            // 
            // btnSobelY
            // 
            this.btnSobelY.Location = new System.Drawing.Point(190, 355);
            this.btnSobelY.Name = "btnSobelY";
            this.btnSobelY.Size = new System.Drawing.Size(75, 37);
            this.btnSobelY.TabIndex = 10;
            this.btnSobelY.Text = "Фильтр Собеля по y";
            this.btnSobelY.UseVisualStyleBackColor = true;
            this.btnSobelY.Click += new System.EventHandler(this.btnSobelY_Click);
            // 
            // btnToOriginal
            // 
            this.btnToOriginal.Location = new System.Drawing.Point(150, 44);
            this.btnToOriginal.Name = "btnToOriginal";
            this.btnToOriginal.Size = new System.Drawing.Size(101, 23);
            this.btnToOriginal.TabIndex = 11;
            this.btnToOriginal.Text = "К оригиналу";
            this.btnToOriginal.UseVisualStyleBackColor = true;
            this.btnToOriginal.Click += new System.EventHandler(this.toOriginal);
            // 
            // btnLaplacce
            // 
            this.btnLaplacce.Location = new System.Drawing.Point(154, 398);
            this.btnLaplacce.Name = "btnLaplacce";
            this.btnLaplacce.Size = new System.Drawing.Size(75, 42);
            this.btnLaplacce.TabIndex = 12;
            this.btnLaplacce.Text = "Оператор Лапласса";
            this.btnLaplacce.UseVisualStyleBackColor = true;
            this.btnLaplacce.Click += new System.EventHandler(this.btnLaplacce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 605);
            this.Controls.Add(this.btnLaplacce);
            this.Controls.Add(this.btnToOriginal);
            this.Controls.Add(this.btnSobelY);
            this.Controls.Add(this.btnPrewittY);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbThreshold);
            this.Controls.Add(this.btnSobelX);
            this.Controls.Add(this.btnPrewittX);
            this.Controls.Add(this.btnRGBToGray);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRGBToGray;
        private System.Windows.Forms.Button btnPrewittX;
        private System.Windows.Forms.Button btnSobelX;
        private System.Windows.Forms.TextBox tbThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Button btnPrewittY;
        private System.Windows.Forms.Button btnSobelY;
        private System.Windows.Forms.Button btnToOriginal;
        private System.Windows.Forms.Button btnLaplacce;
    }
}

