
namespace WindowsFormsStormtrooper
{
    partial class FormPlaneConfig
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
            this.groupBoxParamsPlane = new System.Windows.Forms.GroupBox();
            this.checkBoxTurbo = new System.Windows.Forms.CheckBox();
            this.labelMaxSpeedPlane = new System.Windows.Forms.Label();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGuns = new System.Windows.Forms.CheckBox();
            this.labelWeightPlane = new System.Windows.Forms.Label();
            this.checkBoxWings = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBoxTypePlane = new System.Windows.Forms.GroupBox();
            this.labelWarplane = new System.Windows.Forms.Label();
            this.labelStormtrooper = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorGreen = new System.Windows.Forms.Panel();
            this.panelColorGold = new System.Windows.Forms.Panel();
            this.panelColorPink = new System.Windows.Forms.Panel();
            this.panelColorOrange = new System.Windows.Forms.Panel();
            this.panelColorTomato = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxParamsPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBoxTypePlane.SuspendLayout();
            this.panelPlane.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParamsPlane
            // 
            this.groupBoxParamsPlane.Controls.Add(this.checkBoxTurbo);
            this.groupBoxParamsPlane.Controls.Add(this.labelMaxSpeedPlane);
            this.groupBoxParamsPlane.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParamsPlane.Controls.Add(this.checkBoxGuns);
            this.groupBoxParamsPlane.Controls.Add(this.labelWeightPlane);
            this.groupBoxParamsPlane.Controls.Add(this.checkBoxWings);
            this.groupBoxParamsPlane.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParamsPlane.Location = new System.Drawing.Point(12, 198);
            this.groupBoxParamsPlane.Name = "groupBoxParamsPlane";
            this.groupBoxParamsPlane.Size = new System.Drawing.Size(362, 166);
            this.groupBoxParamsPlane.TabIndex = 0;
            this.groupBoxParamsPlane.TabStop = false;
            this.groupBoxParamsPlane.Text = "Параметры";
            // 
            // checkBoxTurbo
            // 
            this.checkBoxTurbo.AutoSize = true;
            this.checkBoxTurbo.Location = new System.Drawing.Point(165, 116);
            this.checkBoxTurbo.Name = "checkBoxTurbo";
            this.checkBoxTurbo.Size = new System.Drawing.Size(161, 21);
            this.checkBoxTurbo.TabIndex = 2;
            this.checkBoxTurbo.Text = "Наличие ускорения";
            this.checkBoxTurbo.UseVisualStyleBackColor = true;
            // 
            // labelMaxSpeedPlane
            // 
            this.labelMaxSpeedPlane.AutoSize = true;
            this.labelMaxSpeedPlane.Location = new System.Drawing.Point(6, 24);
            this.labelMaxSpeedPlane.Name = "labelMaxSpeedPlane";
            this.labelMaxSpeedPlane.Size = new System.Drawing.Size(112, 17);
            this.labelMaxSpeedPlane.TabIndex = 1;
            this.labelMaxSpeedPlane.Text = "Макс. скорость:";
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 50);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaxSpeed.TabIndex = 3;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxGuns
            // 
            this.checkBoxGuns.AutoSize = true;
            this.checkBoxGuns.Location = new System.Drawing.Point(165, 83);
            this.checkBoxGuns.Name = "checkBoxGuns";
            this.checkBoxGuns.Size = new System.Drawing.Size(133, 21);
            this.checkBoxGuns.TabIndex = 6;
            this.checkBoxGuns.Text = "Наличие пушек";
            this.checkBoxGuns.UseVisualStyleBackColor = true;
            // 
            // labelWeightPlane
            // 
            this.labelWeightPlane.AutoSize = true;
            this.labelWeightPlane.Location = new System.Drawing.Point(6, 83);
            this.labelWeightPlane.Name = "labelWeightPlane";
            this.labelWeightPlane.Size = new System.Drawing.Size(120, 17);
            this.labelWeightPlane.TabIndex = 2;
            this.labelWeightPlane.Text = "Вес штурмовика:";
            // 
            // checkBoxWings
            // 
            this.checkBoxWings.AutoSize = true;
            this.checkBoxWings.Location = new System.Drawing.Point(165, 50);
            this.checkBoxWings.Name = "checkBoxWings";
            this.checkBoxWings.Size = new System.Drawing.Size(147, 21);
            this.checkBoxWings.TabIndex = 5;
            this.checkBoxWings.Text = "Наличие крыльев";
            this.checkBoxWings.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 115);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWeight.TabIndex = 4;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(58, 14);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(373, 289);
            this.pictureBoxPlane.TabIndex = 7;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBoxTypePlane
            // 
            this.groupBoxTypePlane.Controls.Add(this.labelWarplane);
            this.groupBoxTypePlane.Controls.Add(this.labelStormtrooper);
            this.groupBoxTypePlane.Location = new System.Drawing.Point(125, 27);
            this.groupBoxTypePlane.Name = "groupBoxTypePlane";
            this.groupBoxTypePlane.Size = new System.Drawing.Size(142, 165);
            this.groupBoxTypePlane.TabIndex = 8;
            this.groupBoxTypePlane.TabStop = false;
            this.groupBoxTypePlane.Text = "Тип самолёта";
            // 
            // labelWarplane
            // 
            this.labelWarplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarplane.Location = new System.Drawing.Point(9, 38);
            this.labelWarplane.Name = "labelWarplane";
            this.labelWarplane.Size = new System.Drawing.Size(109, 46);
            this.labelWarplane.TabIndex = 0;
            this.labelWarplane.Text = "Военный самолёт";
            this.labelWarplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarplane_MouseDown);
            // 
            // labelStormtrooper
            // 
            this.labelStormtrooper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStormtrooper.Location = new System.Drawing.Point(9, 102);
            this.labelStormtrooper.Name = "labelStormtrooper";
            this.labelStormtrooper.Size = new System.Drawing.Size(108, 37);
            this.labelStormtrooper.TabIndex = 1;
            this.labelStormtrooper.Text = "Штурмовик";
            this.labelStormtrooper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStormtrooper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelStormtrooper_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(385, 39);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(483, 325);
            this.panelPlane.TabIndex = 2;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(17, 43);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(132, 47);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(167, 42);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(136, 48);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColorWhite.Location = new System.Drawing.Point(166, 178);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(50, 50);
            this.panelColorWhite.TabIndex = 8;
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelColorBlue.Location = new System.Drawing.Point(238, 115);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(50, 50);
            this.panelColorBlue.TabIndex = 0;
            // 
            // panelColorGreen
            // 
            this.panelColorGreen.BackColor = System.Drawing.Color.LightGreen;
            this.panelColorGreen.Location = new System.Drawing.Point(33, 178);
            this.panelColorGreen.Name = "panelColorGreen";
            this.panelColorGreen.Size = new System.Drawing.Size(50, 50);
            this.panelColorGreen.TabIndex = 0;
            // 
            // panelColorGold
            // 
            this.panelColorGold.BackColor = System.Drawing.Color.Gold;
            this.panelColorGold.Location = new System.Drawing.Point(99, 178);
            this.panelColorGold.Name = "panelColorGold";
            this.panelColorGold.Size = new System.Drawing.Size(50, 50);
            this.panelColorGold.TabIndex = 0;
            // 
            // panelColorPink
            // 
            this.panelColorPink.BackColor = System.Drawing.Color.Pink;
            this.panelColorPink.Location = new System.Drawing.Point(238, 178);
            this.panelColorPink.Name = "panelColorPink";
            this.panelColorPink.Size = new System.Drawing.Size(50, 50);
            this.panelColorPink.TabIndex = 0;
            // 
            // panelColorOrange
            // 
            this.panelColorOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.panelColorOrange.Location = new System.Drawing.Point(166, 115);
            this.panelColorOrange.Name = "panelColorOrange";
            this.panelColorOrange.Size = new System.Drawing.Size(50, 50);
            this.panelColorOrange.TabIndex = 0;
            // 
            // panelColorTomato
            // 
            this.panelColorTomato.BackColor = System.Drawing.Color.Tomato;
            this.panelColorTomato.Location = new System.Drawing.Point(99, 115);
            this.panelColorTomato.Name = "panelColorTomato";
            this.panelColorTomato.Size = new System.Drawing.Size(50, 50);
            this.panelColorTomato.TabIndex = 0;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColorBlack.Location = new System.Drawing.Point(33, 115);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(50, 50);
            this.panelColorBlack.TabIndex = 0;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.buttonCancel);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.buttonOk);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Controls.Add(this.panelColorPink);
            this.groupBoxColor.Controls.Add(this.panelColorGold);
            this.groupBoxColor.Controls.Add(this.panelColorBlack);
            this.groupBoxColor.Controls.Add(this.panelColorWhite);
            this.groupBoxColor.Controls.Add(this.panelColorTomato);
            this.groupBoxColor.Controls.Add(this.panelColorBlue);
            this.groupBoxColor.Controls.Add(this.panelColorOrange);
            this.groupBoxColor.Controls.Add(this.panelColorGreen);
            this.groupBoxColor.Location = new System.Drawing.Point(882, 39);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(316, 319);
            this.groupBoxColor.TabIndex = 9;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(167, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 40);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(55, 249);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 40);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 409);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBoxTypePlane);
            this.Controls.Add(this.groupBoxParamsPlane);
            this.Name = "FormPlaneConfig";
            this.Text = "Выбор самолёта";
            this.groupBoxParamsPlane.ResumeLayout(false);
            this.groupBoxParamsPlane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBoxTypePlane.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParamsPlane;
        private System.Windows.Forms.Label labelMaxSpeedPlane;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxGuns;
        private System.Windows.Forms.Label labelWeightPlane;
        private System.Windows.Forms.CheckBox checkBoxWings;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.CheckBox checkBoxTurbo;
        private System.Windows.Forms.GroupBox groupBoxTypePlane;
        private System.Windows.Forms.Label labelWarplane;
        private System.Windows.Forms.Label labelStormtrooper;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.Panel panelColorPink;
        private System.Windows.Forms.Panel panelColorGold;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorOrange;
        private System.Windows.Forms.Panel panelColorTomato;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}