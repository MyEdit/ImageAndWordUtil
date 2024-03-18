namespace WordUtil
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Storage = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDragAndDrop = new System.Windows.Forms.Panel();
            this.PlaceholderDragAndDrop = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCashier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxService1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxService2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxService3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQuality3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxQuality2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxQuality1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCost3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCost2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCost1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelDragAndDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ID);
            this.tabPage1.Controls.Add(this.Count);
            this.tabPage1.Controls.Add(this.Storage);
            this.tabPage1.Controls.Add(this.Name);
            this.tabPage1.Controls.Add(this.buttonGetData);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.PanelDragAndDrop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрепить фото к препарату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(324, 111);
            this.ID.Margin = new System.Windows.Forms.Padding(5);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(121, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(324, 180);
            this.Count.Margin = new System.Windows.Forms.Padding(5);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(121, 13);
            this.Count.TabIndex = 8;
            this.Count.Text = "Count";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Storage
            // 
            this.Storage.Location = new System.Drawing.Point(324, 157);
            this.Storage.Margin = new System.Windows.Forms.Padding(5);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(121, 13);
            this.Storage.TabIndex = 7;
            this.Storage.Text = "Storage";
            this.Storage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(324, 134);
            this.Name.Margin = new System.Windows.Forms.Padding(5);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(121, 13);
            this.Name.TabIndex = 6;
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(324, 80);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(121, 23);
            this.buttonGetData.TabIndex = 5;
            this.buttonGetData.Text = "Получить данные";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(345, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelDragAndDrop
            // 
            this.PanelDragAndDrop.AllowDrop = true;
            this.PanelDragAndDrop.Controls.Add(this.PlaceholderDragAndDrop);
            this.PanelDragAndDrop.Controls.Add(this.pictureBox2);
            this.PanelDragAndDrop.Location = new System.Drawing.Point(508, 51);
            this.PanelDragAndDrop.Name = "PanelDragAndDrop";
            this.PanelDragAndDrop.Size = new System.Drawing.Size(249, 278);
            this.PanelDragAndDrop.TabIndex = 2;
            this.PanelDragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelDragAndDrop_DragDrop);
            this.PanelDragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelDragAndDrop_DragEnter);
            this.PanelDragAndDrop.DragLeave += new System.EventHandler(this.PanelDragAndDrop_DragLeave);
            // 
            // PlaceholderDragAndDrop
            // 
            this.PlaceholderDragAndDrop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PlaceholderDragAndDrop.ForeColor = System.Drawing.Color.DimGray;
            this.PlaceholderDragAndDrop.Location = new System.Drawing.Point(10, 9);
            this.PlaceholderDragAndDrop.Name = "PlaceholderDragAndDrop";
            this.PlaceholderDragAndDrop.Size = new System.Drawing.Size(230, 260);
            this.PlaceholderDragAndDrop.TabIndex = 3;
            this.PlaceholderDragAndDrop.Tag = "Перетащите фото сюда";
            this.PlaceholderDragAndDrop.Text = "Перетащите фото сюда";
            this.PlaceholderDragAndDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxCost3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBoxCost2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxCost1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxQuality3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxQuality2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBoxQuality1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxService3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxService2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxService1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxNumCash);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxCashier);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxNum);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Word";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 89);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(80, 9);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер чека";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кассир";
            // 
            // textBoxCashier
            // 
            this.textBoxCashier.Location = new System.Drawing.Point(80, 35);
            this.textBoxCashier.Name = "textBoxCashier";
            this.textBoxCashier.Size = new System.Drawing.Size(100, 20);
            this.textBoxCashier.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Касса";
            // 
            // textBoxNumCash
            // 
            this.textBoxNumCash.Location = new System.Drawing.Point(80, 61);
            this.textBoxNumCash.Name = "textBoxNumCash";
            this.textBoxNumCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumCash.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Товар 1";
            // 
            // textBoxService1
            // 
            this.textBoxService1.Location = new System.Drawing.Point(263, 9);
            this.textBoxService1.Name = "textBoxService1";
            this.textBoxService1.Size = new System.Drawing.Size(100, 20);
            this.textBoxService1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Товар 2";
            // 
            // textBoxService2
            // 
            this.textBoxService2.Location = new System.Drawing.Point(263, 38);
            this.textBoxService2.Name = "textBoxService2";
            this.textBoxService2.Size = new System.Drawing.Size(100, 20);
            this.textBoxService2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Товар 3";
            // 
            // textBoxService3
            // 
            this.textBoxService3.Location = new System.Drawing.Point(263, 64);
            this.textBoxService3.Name = "textBoxService3";
            this.textBoxService3.Size = new System.Drawing.Size(100, 20);
            this.textBoxService3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Качество 3";
            // 
            // textBoxQuality3
            // 
            this.textBoxQuality3.Location = new System.Drawing.Point(448, 67);
            this.textBoxQuality3.Name = "textBoxQuality3";
            this.textBoxQuality3.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuality3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Качество 2";
            // 
            // textBoxQuality2
            // 
            this.textBoxQuality2.Location = new System.Drawing.Point(448, 41);
            this.textBoxQuality2.Name = "textBoxQuality2";
            this.textBoxQuality2.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuality2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Качество 1";
            // 
            // textBoxQuality1
            // 
            this.textBoxQuality1.Location = new System.Drawing.Point(448, 12);
            this.textBoxQuality1.Name = "textBoxQuality1";
            this.textBoxQuality1.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuality1.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Цена 3";
            // 
            // textBoxCost3
            // 
            this.textBoxCost3.Location = new System.Drawing.Point(643, 67);
            this.textBoxCost3.Name = "textBoxCost3";
            this.textBoxCost3.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Цена 2";
            // 
            // textBoxCost2
            // 
            this.textBoxCost2.Location = new System.Drawing.Point(643, 41);
            this.textBoxCost2.Name = "textBoxCost2";
            this.textBoxCost2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost2.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(571, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Цена 1";
            // 
            // textBoxCost1
            // 
            this.textBoxCost1.Location = new System.Drawing.Point(643, 12);
            this.textBoxCost1.Name = "textBoxCost1";
            this.textBoxCost1.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost1.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.tabControl1);
            this.Text = "ImageAndWordUtil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelDragAndDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelDragAndDrop;
        private System.Windows.Forms.Label PlaceholderDragAndDrop;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Storage;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCost3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCost2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCost1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxQuality3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxQuality2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxQuality1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxService3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxService2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxService1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button button2;
    }
}

