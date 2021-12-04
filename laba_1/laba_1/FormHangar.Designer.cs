
namespace WindowsFormsStormtrooper
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.buttonSetStorm = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.listBoxHangars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameHangar = new System.Windows.Forms.TextBox();
            this.buttonAddHangar = new System.Windows.Forms.Button();
            this.buttonDelHangar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHangar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(1206, 617);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(1237, 224);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(127, 82);
            this.buttonSetPlane.TabIndex = 1;
            this.buttonSetPlane.Text = "Приземлить военный самолёт";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // buttonSetStorm
            // 
            this.buttonSetStorm.Location = new System.Drawing.Point(1237, 312);
            this.buttonSetStorm.Name = "buttonSetStorm";
            this.buttonSetStorm.Size = new System.Drawing.Size(127, 57);
            this.buttonSetStorm.TabIndex = 2;
            this.buttonSetStorm.Text = "Приземлить штурмовик";
            this.buttonSetStorm.UseVisualStyleBackColor = true;
            this.buttonSetStorm.Click += new System.EventHandler(this.buttonSetStorm_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Controls.Add(this.buttonTakePlane);
            this.groupBox.Location = new System.Drawing.Point(1212, 384);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(158, 109);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолёт";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(69, 25);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(52, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label.Location = new System.Drawing.Point(10, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Место:";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(40, 53);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(80, 29);
            this.buttonTakePlane.TabIndex = 2;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // listBoxHangars
            // 
            this.listBoxHangars.FormattingEnabled = true;
            this.listBoxHangars.ItemHeight = 16;
            this.listBoxHangars.Location = new System.Drawing.Point(1231, 91);
            this.listBoxHangars.Name = "listBoxHangars";
            this.listBoxHangars.Size = new System.Drawing.Size(120, 84);
            this.listBoxHangars.TabIndex = 4;
            this.listBoxHangars.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ангары:";
            // 
            // textBoxNameHangar
            // 
            this.textBoxNameHangar.Location = new System.Drawing.Point(1245, 29);
            this.textBoxNameHangar.Name = "textBoxNameHangar";
            this.textBoxNameHangar.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameHangar.TabIndex = 6;
            // 
            // buttonAddHangar
            // 
            this.buttonAddHangar.Location = new System.Drawing.Point(1214, 57);
            this.buttonAddHangar.Name = "buttonAddHangar";
            this.buttonAddHangar.Size = new System.Drawing.Size(156, 28);
            this.buttonAddHangar.TabIndex = 7;
            this.buttonAddHangar.Text = "Добавить ангар";
            this.buttonAddHangar.UseVisualStyleBackColor = true;
            this.buttonAddHangar.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelHangar
            // 
            this.buttonDelHangar.Location = new System.Drawing.Point(1212, 181);
            this.buttonDelHangar.Name = "buttonDelHangar";
            this.buttonDelHangar.Size = new System.Drawing.Size(164, 33);
            this.buttonDelHangar.TabIndex = 8;
            this.buttonDelHangar.Text = "Удалить ангар";
            this.buttonDelHangar.UseVisualStyleBackColor = true;
            this.buttonDelHangar.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 617);
            this.Controls.Add(this.buttonDelHangar);
            this.Controls.Add(this.buttonAddHangar);
            this.Controls.Add(this.textBoxNameHangar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHangars);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonSetStorm);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.Button buttonSetStorm;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.ListBox listBoxHangars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameHangar;
        private System.Windows.Forms.Button buttonAddHangar;
        private System.Windows.Forms.Button buttonDelHangar;
    }
}