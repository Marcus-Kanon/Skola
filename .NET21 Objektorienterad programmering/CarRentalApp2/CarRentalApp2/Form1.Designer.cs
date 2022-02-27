
namespace CarRentalApp2
{
    partial class Form1
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
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbDateRented = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.lbTypeOfCar = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(148, 123);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(147, 24);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(152, 150);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(143, 22);
            this.tbCustomerName.TabIndex = 1;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(485, 150);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(143, 22);
            this.tbCost.TabIndex = 3;
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(481, 123);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(47, 24);
            this.lbCost.TabIndex = 2;
            this.lbCost.Text = "Cost";
            // 
            // lbDateRented
            // 
            this.lbDateRented.AutoSize = true;
            this.lbDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRented.Location = new System.Drawing.Point(148, 222);
            this.lbDateRented.Name = "lbDateRented";
            this.lbDateRented.Size = new System.Drawing.Size(114, 24);
            this.lbDateRented.TabIndex = 0;
            this.lbDateRented.Text = "Date Rented";
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Location = new System.Drawing.Point(152, 249);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(200, 22);
            this.dtpDateRented.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Returned";
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Location = new System.Drawing.Point(485, 258);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(200, 22);
            this.dtpDateReturned.TabIndex = 4;
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(152, 334);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(121, 24);
            this.cbTypeOfCar.TabIndex = 5;
            // 
            // lbTypeOfCar
            // 
            this.lbTypeOfCar.AutoSize = true;
            this.lbTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfCar.Location = new System.Drawing.Point(148, 307);
            this.lbTypeOfCar.Name = "lbTypeOfCar";
            this.lbTypeOfCar.Size = new System.Drawing.Size(114, 24);
            this.lbTypeOfCar.TabIndex = 0;
            this.lbTypeOfCar.Text = "Date Rented";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(484, 327);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 58);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car Rental App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbTypeOfCar);
            this.Controls.Add(this.lbDateRented);
            this.Controls.Add(this.lbCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label lbTypeOfCar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
    }
}

