namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVectors = new System.Windows.Forms.Label();
            this.buttonAddVector = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonAddMenuItem1 = new System.Windows.Forms.Button();
            this.buttonAddMenuItem2 = new System.Windows.Forms.Button();
            this.buttonAddMenuItem3 = new System.Windows.Forms.Button();
            this.buttonAddMenuItem4 = new System.Windows.Forms.Button();
            this.buttonAddMenuItem5 = new System.Windows.Forms.Button();
            this.labelDelegate = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVectors
            // 
            this.labelVectors.BackColor = System.Drawing.SystemColors.Window;
            this.labelVectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVectors.Location = new System.Drawing.Point(12, 9);
            this.labelVectors.Name = "labelVectors";
            this.labelVectors.Size = new System.Drawing.Size(445, 166);
            this.labelVectors.TabIndex = 0;
            this.labelVectors.Text = "Векторы:\n";
            // 
            // buttonAddVector
            // 
            this.buttonAddVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddVector.Location = new System.Drawing.Point(487, 13);
            this.buttonAddVector.Name = "buttonAddVector";
            this.buttonAddVector.Size = new System.Drawing.Size(159, 40);
            this.buttonAddVector.TabIndex = 1;
            this.buttonAddVector.Text = "Добавить вектор";
            this.buttonAddVector.UseVisualStyleBackColor = true;
            this.buttonAddVector.Click += new System.EventHandler(this.buttonAddVector_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(12, 202);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(445, 135);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Меню:\n1. Найти самые маленькие векторы\n2. Найти самые большие векторы\n3. Сортиров" +
    "ать массив по возрастанию модулей\n4. Сортировать массив по кол-ву координат\n5. К" +
    "лонировать произвольный вектор\n";
            // 
            // buttonAddMenuItem1
            // 
            this.buttonAddMenuItem1.Location = new System.Drawing.Point(487, 203);
            this.buttonAddMenuItem1.Name = "buttonAddMenuItem1";
            this.buttonAddMenuItem1.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMenuItem1.TabIndex = 3;
            this.buttonAddMenuItem1.Text = "Добавить 1";
            this.buttonAddMenuItem1.UseVisualStyleBackColor = true;
            this.buttonAddMenuItem1.Click += new System.EventHandler(this.buttonAddMenuItem1_Click);
            // 
            // buttonAddMenuItem2
            // 
            this.buttonAddMenuItem2.Location = new System.Drawing.Point(487, 232);
            this.buttonAddMenuItem2.Name = "buttonAddMenuItem2";
            this.buttonAddMenuItem2.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMenuItem2.TabIndex = 4;
            this.buttonAddMenuItem2.Text = "Добавить 2";
            this.buttonAddMenuItem2.UseVisualStyleBackColor = true;
            this.buttonAddMenuItem2.Click += new System.EventHandler(this.buttonAddMenuItem2_Click);
            // 
            // buttonAddMenuItem3
            // 
            this.buttonAddMenuItem3.Location = new System.Drawing.Point(487, 261);
            this.buttonAddMenuItem3.Name = "buttonAddMenuItem3";
            this.buttonAddMenuItem3.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMenuItem3.TabIndex = 5;
            this.buttonAddMenuItem3.Text = "Добавить 3";
            this.buttonAddMenuItem3.UseVisualStyleBackColor = true;
            this.buttonAddMenuItem3.Click += new System.EventHandler(this.buttonAddMenuItem3_Click);
            // 
            // buttonAddMenuItem4
            // 
            this.buttonAddMenuItem4.Location = new System.Drawing.Point(487, 290);
            this.buttonAddMenuItem4.Name = "buttonAddMenuItem4";
            this.buttonAddMenuItem4.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMenuItem4.TabIndex = 6;
            this.buttonAddMenuItem4.Text = "Добавить 4";
            this.buttonAddMenuItem4.UseVisualStyleBackColor = true;
            this.buttonAddMenuItem4.Click += new System.EventHandler(this.buttonAddMenuItem4_Click);
            // 
            // buttonAddMenuItem5
            // 
            this.buttonAddMenuItem5.Location = new System.Drawing.Point(487, 319);
            this.buttonAddMenuItem5.Name = "buttonAddMenuItem5";
            this.buttonAddMenuItem5.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMenuItem5.TabIndex = 7;
            this.buttonAddMenuItem5.Text = "Добавить 5";
            this.buttonAddMenuItem5.UseVisualStyleBackColor = true;
            this.buttonAddMenuItem5.Click += new System.EventHandler(this.buttonAddMenuItem5_Click);
            // 
            // labelDelegate
            // 
            this.labelDelegate.AutoSize = true;
            this.labelDelegate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDelegate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDelegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelegate.Location = new System.Drawing.Point(12, 356);
            this.labelDelegate.Name = "labelDelegate";
            this.labelDelegate.Size = new System.Drawing.Size(298, 22);
            this.labelDelegate.TabIndex = 8;
            this.labelDelegate.Text = "Последовательность на исполнение:";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(454, 388);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(192, 39);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelDelegate);
            this.Controls.Add(this.buttonAddMenuItem5);
            this.Controls.Add(this.buttonAddMenuItem4);
            this.Controls.Add(this.buttonAddMenuItem3);
            this.Controls.Add(this.buttonAddMenuItem2);
            this.Controls.Add(this.buttonAddMenuItem1);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonAddVector);
            this.Controls.Add(this.labelVectors);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVectors;
        private System.Windows.Forms.Button buttonAddVector;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonAddMenuItem1;
        private System.Windows.Forms.Button buttonAddMenuItem2;
        private System.Windows.Forms.Button buttonAddMenuItem3;
        private System.Windows.Forms.Button buttonAddMenuItem4;
        private System.Windows.Forms.Button buttonAddMenuItem5;
        private System.Windows.Forms.Label labelDelegate;
        private System.Windows.Forms.Button buttonStart;
    }
}

