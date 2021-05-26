
namespace DBCarsconnect
{
    partial class frmDBConnect1
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelVehicleRegNo = new System.Windows.Forms.Label();
            this.labelDateRegistered = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelEngineSize = new System.Windows.Forms.Label();
            this.labelRentalPerDay = new System.Windows.Forms.Label();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.textBoxVehicleRegNo = new System.Windows.Forms.TextBox();
            this.textBoxRentalPerDay = new System.Windows.Forms.TextBox();
            this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
            this.textBoxEngineSize = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFormat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(774, 59);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 55);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(774, 139);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(147, 55);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "&Add";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(774, 219);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 55);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelVehicleRegNo
            // 
            this.labelVehicleRegNo.AutoSize = true;
            this.labelVehicleRegNo.Location = new System.Drawing.Point(27, 66);
            this.labelVehicleRegNo.Name = "labelVehicleRegNo";
            this.labelVehicleRegNo.Size = new System.Drawing.Size(134, 25);
            this.labelVehicleRegNo.TabIndex = 5;
            this.labelVehicleRegNo.Text = "Vehicle Reg No.";
            this.labelVehicleRegNo.Click += new System.EventHandler(this.labelVehicleRegNo_Click);
            // 
            // labelDateRegistered
            // 
            this.labelDateRegistered.AutoSize = true;
            this.labelDateRegistered.Location = new System.Drawing.Point(27, 249);
            this.labelDateRegistered.Name = "labelDateRegistered";
            this.labelDateRegistered.Size = new System.Drawing.Size(141, 25);
            this.labelDateRegistered.TabIndex = 6;
            this.labelDateRegistered.Text = "Date Registered:";
            this.labelDateRegistered.Click += new System.EventHandler(this.labelDateRegistered_Click);
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(27, 129);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(59, 25);
            this.labelMake.TabIndex = 7;
            this.labelMake.Text = "Make:";
            this.labelMake.Click += new System.EventHandler(this.labelMake_Click);
            // 
            // labelEngineSize
            // 
            this.labelEngineSize.AutoSize = true;
            this.labelEngineSize.Location = new System.Drawing.Point(27, 189);
            this.labelEngineSize.Name = "labelEngineSize";
            this.labelEngineSize.Size = new System.Drawing.Size(105, 25);
            this.labelEngineSize.TabIndex = 8;
            this.labelEngineSize.Text = "Engine Size:";
            this.labelEngineSize.Click += new System.EventHandler(this.labelEngineSize_Click);
            // 
            // labelRentalPerDay
            // 
            this.labelRentalPerDay.AutoSize = true;
            this.labelRentalPerDay.Location = new System.Drawing.Point(27, 309);
            this.labelRentalPerDay.Name = "labelRentalPerDay";
            this.labelRentalPerDay.Size = new System.Drawing.Size(129, 25);
            this.labelRentalPerDay.TabIndex = 9;
            this.labelRentalPerDay.Text = "Rental Per Day:";
            this.labelRentalPerDay.Click += new System.EventHandler(this.labelRentalPerDay_Click);
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(37, 368);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(109, 29);
            this.checkBoxAvailable.TabIndex = 10;
            this.checkBoxAvailable.Text = "Available";
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            this.checkBoxAvailable.CheckedChanged += new System.EventHandler(this.checkBoxAvailable_CheckedChanged);
            // 
            // textBoxVehicleRegNo
            // 
            this.textBoxVehicleRegNo.Location = new System.Drawing.Point(178, 63);
            this.textBoxVehicleRegNo.Name = "textBoxVehicleRegNo";
            this.textBoxVehicleRegNo.Size = new System.Drawing.Size(176, 31);
            this.textBoxVehicleRegNo.TabIndex = 11;
            this.textBoxVehicleRegNo.TextChanged += new System.EventHandler(this.textBoxVehicleRegNo_TextChanged);
            // 
            // textBoxRentalPerDay
            // 
            this.textBoxRentalPerDay.Location = new System.Drawing.Point(178, 306);
            this.textBoxRentalPerDay.Name = "textBoxRentalPerDay";
            this.textBoxRentalPerDay.Size = new System.Drawing.Size(176, 31);
            this.textBoxRentalPerDay.TabIndex = 12;
            this.textBoxRentalPerDay.TextChanged += new System.EventHandler(this.textBoxRentalPerDay_TextChanged);
            // 
            // textBoxDateRegistered
            // 
            this.textBoxDateRegistered.Location = new System.Drawing.Point(178, 246);
            this.textBoxDateRegistered.Name = "textBoxDateRegistered";
            this.textBoxDateRegistered.Size = new System.Drawing.Size(176, 31);
            this.textBoxDateRegistered.TabIndex = 13;
            this.textBoxDateRegistered.TextChanged += new System.EventHandler(this.textBoxDateRegistered_TextChanged);
            // 
            // textBoxEngineSize
            // 
            this.textBoxEngineSize.Location = new System.Drawing.Point(178, 189);
            this.textBoxEngineSize.Name = "textBoxEngineSize";
            this.textBoxEngineSize.Size = new System.Drawing.Size(176, 31);
            this.textBoxEngineSize.TabIndex = 14;
            this.textBoxEngineSize.TextChanged += new System.EventHandler(this.textBoxEngineSize_TextChanged);
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(178, 129);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(176, 31);
            this.textBoxMake.TabIndex = 15;
            this.textBoxMake.TextChanged += new System.EventHandler(this.textBoxMake_TextChanged);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(67, 473);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(112, 34);
            this.buttonFirst.TabIndex = 16;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(626, 473);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 34);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(242, 473);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(112, 34);
            this.buttonPrevious.TabIndex = 18;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(791, 473);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(112, 34);
            this.buttonLast.TabIndex = 19;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(791, 300);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(791, 364);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(424, 475);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(150, 31);
            this.textBoxStatus.TabIndex = 22;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(424, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(194, 30);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Bowman Car Hire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBCarsconnect.Properties.Resources._2277221_12_articlelarge_LC_20budget_20cars_2004;
            this.pictureBox1.Location = new System.Drawing.Point(424, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 226);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(20, 12);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(112, 34);
            this.buttonFormat.TabIndex = 25;
            this.buttonFormat.Text = "Format";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // frmDBConnect1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 567);
            this.Controls.Add(this.buttonFormat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxEngineSize);
            this.Controls.Add(this.textBoxDateRegistered);
            this.Controls.Add(this.textBoxRentalPerDay);
            this.Controls.Add(this.textBoxVehicleRegNo);
            this.Controls.Add(this.checkBoxAvailable);
            this.Controls.Add(this.labelRentalPerDay);
            this.Controls.Add(this.labelEngineSize);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.labelDateRegistered);
            this.Controls.Add(this.labelVehicleRegNo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "frmDBConnect1";
            this.Text = "Task A Megan Davitt - 28/04/2021";
            this.Load += new System.EventHandler(this.frmDBConnect1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelVehicleRegNo;
        private System.Windows.Forms.Label labelDateRegistered;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelEngineSize;
        private System.Windows.Forms.Label labelRentalPerDay;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.TextBox textBoxVehicleRegNo;
        private System.Windows.Forms.TextBox textBoxRentalPerDay;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.TextBox textBoxEngineSize;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFormat;
    }
}