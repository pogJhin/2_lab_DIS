
namespace ImgApp_2_WinForms
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
            this.imageviewform = new System.Windows.Forms.PictureBox();
            this.bAdd1 = new System.Windows.Forms.Button();
            this.image1form = new System.Windows.Forms.PictureBox();
            this.image2form = new System.Windows.Forms.PictureBox();
            this.bAdd2 = new System.Windows.Forms.Button();
            this.bReS = new System.Windows.Forms.Button();
            this.bSumm = new System.Windows.Forms.Button();
            this.bAvg = new System.Windows.Forms.Button();
            this.resultform = new System.Windows.Forms.PictureBox();
            this.bTms = new System.Windows.Forms.Button();
            this.vMin = new System.Windows.Forms.Button();
            this.bMax = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bMask = new System.Windows.Forms.Button();
            this.bChn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageviewform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultform)).BeginInit();
            this.SuspendLayout();
            // 
            // imageviewform
            // 
            this.imageviewform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageviewform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageviewform.Location = new System.Drawing.Point(12, 68);
            this.imageviewform.Name = "imageviewform";
            this.imageviewform.Size = new System.Drawing.Size(977, 558);
            this.imageviewform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageviewform.TabIndex = 0;
            this.imageviewform.TabStop = false;
            // 
            // bAdd1
            // 
            this.bAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd1.Location = new System.Drawing.Point(995, 292);
            this.bAdd1.Name = "bAdd1";
            this.bAdd1.Size = new System.Drawing.Size(76, 23);
            this.bAdd1.TabIndex = 1;
            this.bAdd1.Text = "Добавить изображение";
            this.bAdd1.UseVisualStyleBackColor = true;
            this.bAdd1.Click += new System.EventHandler(this.bAdd1_Click);
            // 
            // image1form
            // 
            this.image1form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image1form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image1form.Location = new System.Drawing.Point(995, 68);
            this.image1form.Name = "image1form";
            this.image1form.Size = new System.Drawing.Size(311, 218);
            this.image1form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1form.TabIndex = 3;
            this.image1form.TabStop = false;
            this.image1form.Click += new System.EventHandler(this.image1form_Click);
            // 
            // image2form
            // 
            this.image2form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image2form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image2form.Location = new System.Drawing.Point(995, 325);
            this.image2form.Name = "image2form";
            this.image2form.Size = new System.Drawing.Size(311, 218);
            this.image2form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image2form.TabIndex = 4;
            this.image2form.TabStop = false;
            this.image2form.Click += new System.EventHandler(this.image2form_Click);
            // 
            // bAdd2
            // 
            this.bAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd2.Location = new System.Drawing.Point(995, 549);
            this.bAdd2.Name = "bAdd2";
            this.bAdd2.Size = new System.Drawing.Size(76, 23);
            this.bAdd2.TabIndex = 5;
            this.bAdd2.Text = "Добавить изображение";
            this.bAdd2.UseVisualStyleBackColor = true;
            this.bAdd2.Click += new System.EventHandler(this.bAdd2_Click);
            // 
            // bReS
            // 
            this.bReS.Location = new System.Drawing.Point(878, 632);
            this.bReS.Name = "bReS";
            this.bReS.Size = new System.Drawing.Size(111, 23);
            this.bReS.TabIndex = 7;
            this.bReS.Text = "Изменить размер";
            this.bReS.UseVisualStyleBackColor = true;
            this.bReS.Click += new System.EventHandler(this.bReS_Click);
            // 
            // bSumm
            // 
            this.bSumm.Location = new System.Drawing.Point(0, 1);
            this.bSumm.Name = "bSumm";
            this.bSumm.Size = new System.Drawing.Size(75, 23);
            this.bSumm.TabIndex = 8;
            this.bSumm.Text = "сумма";
            this.bSumm.UseVisualStyleBackColor = true;
            this.bSumm.Click += new System.EventHandler(this.bSumm_Click);
            // 
            // bAvg
            // 
            this.bAvg.Location = new System.Drawing.Point(81, 1);
            this.bAvg.Name = "bAvg";
            this.bAvg.Size = new System.Drawing.Size(75, 23);
            this.bAvg.TabIndex = 9;
            this.bAvg.Text = "среднее";
            this.bAvg.UseVisualStyleBackColor = true;
            this.bAvg.Click += new System.EventHandler(this.bAvg_Click);
            // 
            // resultform
            // 
            this.resultform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultform.Location = new System.Drawing.Point(12, 632);
            this.resultform.Name = "resultform";
            this.resultform.Size = new System.Drawing.Size(249, 141);
            this.resultform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultform.TabIndex = 10;
            this.resultform.TabStop = false;
            this.resultform.Click += new System.EventHandler(this.resultform_Click);
            // 
            // bTms
            // 
            this.bTms.Location = new System.Drawing.Point(162, 1);
            this.bTms.Name = "bTms";
            this.bTms.Size = new System.Drawing.Size(75, 23);
            this.bTms.TabIndex = 11;
            this.bTms.Text = "умножение";
            this.bTms.UseVisualStyleBackColor = true;
            this.bTms.Click += new System.EventHandler(this.bTms_Click);
            // 
            // vMin
            // 
            this.vMin.Location = new System.Drawing.Point(243, 1);
            this.vMin.Name = "vMin";
            this.vMin.Size = new System.Drawing.Size(86, 23);
            this.vMin.TabIndex = 12;
            this.vMin.Text = "минимальное";
            this.vMin.UseVisualStyleBackColor = true;
            this.vMin.Click += new System.EventHandler(this.vMin_Click);
            // 
            // bMax
            // 
            this.bMax.Location = new System.Drawing.Point(335, 1);
            this.bMax.Name = "bMax";
            this.bMax.Size = new System.Drawing.Size(93, 23);
            this.bMax.TabIndex = 13;
            this.bMax.Text = "максимальное";
            this.bMax.UseVisualStyleBackColor = true;
            this.bMax.Click += new System.EventHandler(this.bMax_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 779);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 15;
            this.bSave.Text = "сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "овал",
            "треугольник",
            "прямоугольник"});
            this.comboBox1.Location = new System.Drawing.Point(388, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // bMask
            // 
            this.bMask.Location = new System.Drawing.Point(434, 1);
            this.bMask.Name = "bMask";
            this.bMask.Size = new System.Drawing.Size(75, 23);
            this.bMask.TabIndex = 18;
            this.bMask.Text = "маска";
            this.bMask.UseVisualStyleBackColor = true;
            this.bMask.Click += new System.EventHandler(this.bMask_Click);
            // 
            // bChn
            // 
            this.bChn.Location = new System.Drawing.Point(515, 1);
            this.bChn.Name = "bChn";
            this.bChn.Size = new System.Drawing.Size(75, 23);
            this.bChn.TabIndex = 19;
            this.bChn.Text = "каналы";
            this.bChn.UseVisualStyleBackColor = true;
            this.bChn.Click += new System.EventHandler(this.bChn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "R",
            "G",
            "B",
            "RG",
            "RB",
            "GB"});
            this.comboBox2.Location = new System.Drawing.Point(515, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 818);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.bChn);
            this.Controls.Add(this.bMask);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bMax);
            this.Controls.Add(this.vMin);
            this.Controls.Add(this.bTms);
            this.Controls.Add(this.resultform);
            this.Controls.Add(this.bAvg);
            this.Controls.Add(this.bSumm);
            this.Controls.Add(this.bReS);
            this.Controls.Add(this.bAdd2);
            this.Controls.Add(this.image2form);
            this.Controls.Add(this.image1form);
            this.Controls.Add(this.bAdd1);
            this.Controls.Add(this.imageviewform);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageviewform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageviewform;
        private System.Windows.Forms.Button bAdd1;
        private System.Windows.Forms.PictureBox image1form;
        private System.Windows.Forms.PictureBox image2form;
        private System.Windows.Forms.Button bAdd2;
        private System.Windows.Forms.Button bReS;
        private System.Windows.Forms.Button bSumm;
        private System.Windows.Forms.Button bAvg;
        private System.Windows.Forms.PictureBox resultform;
        private System.Windows.Forms.Button bTms;
        private System.Windows.Forms.Button vMin;
        private System.Windows.Forms.Button bMax;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bMask;
        private System.Windows.Forms.Button bChn;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

