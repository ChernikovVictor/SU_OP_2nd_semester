namespace WindowsFormsApplication1
{
    partial class FormAddVector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonVector = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.labelInputElements = new System.Windows.Forms.Label();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonVector
            // 
            this.radioButtonVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVector.Location = new System.Drawing.Point(87, 50);
            this.radioButtonVector.Name = "radioButtonVector";
            this.radioButtonVector.Size = new System.Drawing.Size(135, 49);
            this.radioButtonVector.TabIndex = 0;
            this.radioButtonVector.TabStop = true;
            this.radioButtonVector.Text = "ArrayVector";
            this.radioButtonVector.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            this.radioButtonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonList.Location = new System.Drawing.Point(270, 50);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(135, 49);
            this.radioButtonList.TabIndex = 1;
            this.radioButtonList.TabStop = true;
            this.radioButtonList.Text = "ArrayList";
            this.radioButtonList.UseVisualStyleBackColor = true;
            // 
            // labelInputElements
            // 
            this.labelInputElements.AutoSize = true;
            this.labelInputElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputElements.Location = new System.Drawing.Point(84, 122);
            this.labelInputElements.Name = "labelInputElements";
            this.labelInputElements.Size = new System.Drawing.Size(267, 24);
            this.labelInputElements.TabIndex = 2;
            this.labelInputElements.Text = "Введите элементы массива:";
            // 
            // textBoxArray
            // 
            this.textBoxArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArray.Location = new System.Drawing.Point(88, 168);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(425, 29);
            this.textBoxArray.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(210, 223);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 306);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.labelInputElements);
            this.Controls.Add(this.radioButtonList);
            this.Controls.Add(this.radioButtonVector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddVector";
            this.Text = "Добавление вектора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonVector;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.Label labelInputElements;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.Button buttonAdd;
    }
}