namespace MyLab
{
    partial class Baza
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.btnParkBronCar = new System.Windows.Forms.Button();
            this.btnParkZenit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.mTBLot = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lParking = new System.Windows.Forms.Label();
            this.lBParking = new System.Windows.Forms.ListBox();
            this.tBParkName = new System.Windows.Forms.TextBox();
            this.btnParkAdd = new System.Windows.Forms.Button();
            this.btnRemovePark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(904, 605);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // btnParkBronCar
            // 
            this.btnParkBronCar.Location = new System.Drawing.Point(911, 212);
            this.btnParkBronCar.Name = "btnParkBronCar";
            this.btnParkBronCar.Size = new System.Drawing.Size(134, 48);
            this.btnParkBronCar.TabIndex = 1;
            this.btnParkBronCar.Text = "Поставить бронемашину";
            this.btnParkBronCar.UseVisualStyleBackColor = true;
            this.btnParkBronCar.Click += new System.EventHandler(this.btnParkBronCar_Click);
            // 
            // btnParkZenit
            // 
            this.btnParkZenit.Location = new System.Drawing.Point(911, 267);
            this.btnParkZenit.Name = "btnParkZenit";
            this.btnParkZenit.Size = new System.Drawing.Size(134, 48);
            this.btnParkZenit.TabIndex = 2;
            this.btnParkZenit.Text = "Поставить зенитку";
            this.btnParkZenit.UseVisualStyleBackColor = true;
            this.btnParkZenit.Click += new System.EventHandler(this.btnParkZenit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTake);
            this.groupBox1.Controls.Add(this.mTBLot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(911, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать транспорт";
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(29, 71);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 3;
            this.btnTake.Text = "Забрать";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // mTBLot
            // 
            this.mTBLot.Location = new System.Drawing.Point(52, 45);
            this.mTBLot.Mask = "09";
            this.mTBLot.Name = "mTBLot";
            this.mTBLot.Size = new System.Drawing.Size(52, 20);
            this.mTBLot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // lParking
            // 
            this.lParking.AutoSize = true;
            this.lParking.Location = new System.Drawing.Point(949, 9);
            this.lParking.Name = "lParking";
            this.lParking.Size = new System.Drawing.Size(57, 13);
            this.lParking.TabIndex = 4;
            this.lParking.Text = "Парковки";
            // 
            // lBParking
            // 
            this.lBParking.FormattingEnabled = true;
            this.lBParking.Location = new System.Drawing.Point(911, 81);
            this.lBParking.Name = "lBParking";
            this.lBParking.Size = new System.Drawing.Size(134, 95);
            this.lBParking.TabIndex = 5;
            this.lBParking.SelectedIndexChanged += new System.EventHandler(this.lBParking_SelectedIndexChanged);
            // 
            // tBParkName
            // 
            this.tBParkName.Location = new System.Drawing.Point(911, 25);
            this.tBParkName.Name = "tBParkName";
            this.tBParkName.Size = new System.Drawing.Size(134, 20);
            this.tBParkName.TabIndex = 6;
            // 
            // btnParkAdd
            // 
            this.btnParkAdd.Location = new System.Drawing.Point(911, 52);
            this.btnParkAdd.Name = "btnParkAdd";
            this.btnParkAdd.Size = new System.Drawing.Size(134, 23);
            this.btnParkAdd.TabIndex = 7;
            this.btnParkAdd.Text = "Добавить парковку";
            this.btnParkAdd.UseVisualStyleBackColor = true;
            this.btnParkAdd.Click += new System.EventHandler(this.btnParkAdd_Click);
            // 
            // btnRemovePark
            // 
            this.btnRemovePark.Location = new System.Drawing.Point(911, 183);
            this.btnRemovePark.Name = "btnRemovePark";
            this.btnRemovePark.Size = new System.Drawing.Size(134, 23);
            this.btnRemovePark.TabIndex = 8;
            this.btnRemovePark.Text = "Удалить парковку";
            this.btnRemovePark.UseVisualStyleBackColor = true;
            this.btnRemovePark.Click += new System.EventHandler(this.btnRemovePark_Click);
            // 
            // Baza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 606);
            this.Controls.Add(this.btnRemovePark);
            this.Controls.Add(this.btnParkAdd);
            this.Controls.Add(this.tBParkName);
            this.Controls.Add(this.lBParking);
            this.Controls.Add(this.lParking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnParkZenit);
            this.Controls.Add(this.btnParkBronCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "Baza";
            this.Text = "Baza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button btnParkBronCar;
        private System.Windows.Forms.Button btnParkZenit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.MaskedTextBox mTBLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lParking;
        private System.Windows.Forms.ListBox lBParking;
        private System.Windows.Forms.TextBox tBParkName;
        private System.Windows.Forms.Button btnParkAdd;
        private System.Windows.Forms.Button btnRemovePark;
    }
}