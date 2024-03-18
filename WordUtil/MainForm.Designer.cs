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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelDragAndDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
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
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Word";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Text = "ImageAndWordUtil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelDragAndDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

