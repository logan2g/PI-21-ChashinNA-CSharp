
namespace MyLab
{
	partial class FormZenit
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
            this.btnCreateZenit = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pictureBoxZenit = new System.Windows.Forms.PictureBox();
            this.btnCreateBrone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZenit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateZenit
            // 
            this.btnCreateZenit.Location = new System.Drawing.Point(12, 556);
            this.btnCreateZenit.Name = "btnCreateZenit";
            this.btnCreateZenit.Size = new System.Drawing.Size(112, 23);
            this.btnCreateZenit.TabIndex = 1;
            this.btnCreateZenit.Text = "Создать Зенитку";
            this.btnCreateZenit.UseVisualStyleBackColor = true;
            this.btnCreateZenit.Click += new System.EventHandler(this.btnCreateZenit_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.BackgroundImage = global::MyLab.Properties.Resources.right_arr;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(876, 553);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 30);
            this.btnRight.TabIndex = 5;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.BackgroundImage = global::MyLab.Properties.Resources.left_arr;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(804, 554);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 30);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.BackgroundImage = global::MyLab.Properties.Resources.down_arr;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(840, 554);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 30);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackgroundImage = global::MyLab.Properties.Resources.up_arr;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(840, 518);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 30);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxZenit
            // 
            this.pictureBoxZenit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxZenit.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxZenit.Name = "pictureBoxZenit";
            this.pictureBoxZenit.Size = new System.Drawing.Size(915, 591);
            this.pictureBoxZenit.TabIndex = 0;
            this.pictureBoxZenit.TabStop = false;
            // 
            // btnCreateBrone
            // 
            this.btnCreateBrone.Location = new System.Drawing.Point(131, 555);
            this.btnCreateBrone.Name = "btnCreateBrone";
            this.btnCreateBrone.Size = new System.Drawing.Size(123, 23);
            this.btnCreateBrone.TabIndex = 6;
            this.btnCreateBrone.Text = "Создать броневик";
            this.btnCreateBrone.UseVisualStyleBackColor = true;
            this.btnCreateBrone.Click += new System.EventHandler(this.btnCreateBrone_Click);
            // 
            // FormZenit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 591);
            this.Controls.Add(this.btnCreateBrone);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCreateZenit);
            this.Controls.Add(this.pictureBoxZenit);
            this.Name = "FormZenit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зенитка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZenit)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxZenit;
		private System.Windows.Forms.Button btnCreateZenit;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnCreateBrone;
	}
}

