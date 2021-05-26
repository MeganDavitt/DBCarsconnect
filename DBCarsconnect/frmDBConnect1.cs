using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DBCarsconnect
{
    public partial class frmDBConnect1 : Form
    {
        DBConnection db = null;

        List<CarInfo> carInfoList = null;

        int currentIndex = 0;

        public frmDBConnect1()
        {
            InitializeComponent();
        }

        private void frmDBConnect1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.textBoxVehicleRegNo, "Enter the vehicle's registration number.");
            toolTip.SetToolTip(this.textBoxMake, "Enter the make of the vehicle.");
            toolTip.SetToolTip(this.textBoxEngineSize, "Enter the size of the engine.");

            this.carInfoList = new List<CarInfo>();

            MakeDBConnection();

            //get the recordset of cars from the database
            LoadCars();

            //display the first element in the car list to screen
            DisplayCarInfo(this.currentIndex);
        }

        private void DisplayCarInfo(int index) //changes need to be added
        {
            CarInfo carInfo = this.carInfoList[index];

            this.textBoxVehicleRegNo.Text = carInfo.VehicleRegNo;
            this.textBoxMake.Text = carInfo.Make;
            this.textBoxEngineSize.Text = carInfo.EngineSize;
            this.textBoxDateRegistered.Text = $"{carInfo.DateRegistered:yyyy-MM-dd}";
            this.textBoxRentalPerDay.Text = $"{carInfo.RentalPerDay:n2}";    //add euro symbol
            if(carInfo.Available == 1)
            {
                this.checkBoxAvailable.Checked = true;
            }
            else
            {
                this.checkBoxAvailable.Checked = false;

            }
            this.textBoxStatus.Text = BuildStatusDescription();
        }
        private void MakeDBConnection()
        {
            this.db = new DBConnection("localhost", "hire", "csharp", "password");

            if (this.db.Connect()) // if(this.db.Connect() == false) means it will only show message if it does NOT connect
            {
                MessageBox.Show("Connected to MySql Server."); //if you change to above requirement then write warning message
            }
        } // can change this to retract the if statement and message box and just contain -this.db.Connect();-

        private void LoadCars()
        {
            DBCars dbCars = new DBCars();

            MySqlDataReader reader = dbCars.GetCars(this.db.Connection);

            while (reader.Read())
            {
                string vehicleRegNo = reader.GetString(0);
                string make = reader.GetString(1);
                string engineSize = reader.GetString(2);
                DateTime dateRegistered = reader.GetDateTime(3);
                double rentalCost = reader.GetDouble(4);
                int available = reader.GetInt32(5);

                CarInfo carInfo = new CarInfo(vehicleRegNo, make, engineSize, dateRegistered, rentalCost, available);

                //add the cars to the list of cars 
                this.carInfoList.Add(carInfo);
            }

            reader.Close();
        }


        private void frmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db != null)
            {
                this.db.Close();
            }
        }

        private bool ListContainsVehicleRegNo(string vehicleRegNo)
        {
            foreach(CarInfo carInfo in this.carInfoList)
            {
                if(carInfo.VehicleRegNo == vehicleRegNo)
                {
                    return true;
                }

            }
            return false;   //meaning list does not contain reg number
        }

        private bool ValidateVehicleRegNo(string vehicleRegNo)
        {
            if (vehicleRegNo.Length == 0)
            {
                MessageBox.Show("Vehicle registration No. must be greater than 0 characters", "Infromation", MessageBoxButtons.OK);
                return false;
            }

            
            return true;
        }
       
   
        private CarInfo CreateCarInfoFromForm() //to validate car info
        {

            string vehicleRegNo = this.textBoxVehicleRegNo.Text;
            if(ValidateVehicleRegNo(vehicleRegNo) == false)
            {
                return null;
            }

            string make = this.textBoxMake.Text;
         

            string engineSize = this.textBoxEngineSize.Text;
          

             DateTime dateRegistered;

            if (DateTime.TryParse(this.textBoxDateRegistered.Text, out dateRegistered) == false)
            {
                MessageBox.Show("Please enter valid date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }


            string rentalCostSubstring = "";
              
            if( this.textBoxRentalPerDay.Text.Length > 0)
            {
                this.textBoxRentalPerDay.Text.Substring(1);
            } 
              
            
            double rentalPerDay;
            
            if(double.TryParse(rentalCostSubstring, out rentalPerDay)== false)
            {
                MessageBox.Show("Please enter a valid rental cost.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
           
            int Available = 0;
            if (this.checkBoxAvailable.Enabled)
            {
                Available = 1;
            }

            CarInfo carInfo = new CarInfo(vehicleRegNo, make, engineSize, dateRegistered, rentalPerDay, Available);

            return carInfo;
        }
       
       
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
              DBCars dbCars = new DBCars();

              //string originalVehicleRegNo = this.carInfoList[this.currentIndex].VehicleRegNo

              CarInfo carInfo = CreateCarInfoFromForm();

            if(carInfo == null)
            {
                return;
            }

              //Update record in DB
              if(dbCars.Update(this.db.Connection, carInfo) == true) //add originalVehicleRegNo before carInfo
              {
                this.carInfoList[this.currentIndex] = carInfo;
                MessageBox.Show($"Vehicle Reg:{carInfo.VehicleRegNo} has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

                
        }

        private void buttonAdd_Click(object sender, EventArgs e) 
        {

            DBCars dbCars = new DBCars();

            {
                CarInfo carInfo = CreateCarInfoFromForm();

                if (carInfo == null)
                {
                    return;
                }

                if (dbCars.Insert(this.db.Connection, carInfo)== true)
                {
                    this.carInfoList.Add(carInfo);

                    DisplayCarInfo(this.currentIndex);

                    MessageBox.Show($"Vehicle Reg: {carInfo.VehicleRegNo} has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.carInfoList.Add(carInfo);

                //Insert record in DB
                dbCars.Insert(this.db.Connection, carInfo);

                //Update navigation controls 
                this.currentIndex = this.carInfoList.Count - 1;

                DisplayCarInfo(this.currentIndex);
            }
        }

       
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DBCars dbCars = new DBCars();

            string vehicleRegNo = this.carInfoList[this.currentIndex].VehicleRegNo;

           DialogResult result = MessageBox.Show($"Are you sure you want to delete this Vehicle Reg?: {vehicleRegNo}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.No)
            {
                return;
            }
            this.carInfoList.RemoveAt(this.currentIndex);

            //if wehave removed the last element in the list, we need
            //to move back one place to make sure we are still within bounds
            
            if(this.currentIndex == this.carInfoList.Count)
            {
                this.currentIndex--;
            }
            
            DisplayCarInfo(this.currentIndex);
            
            dbCars.Delete(this.db.Connection, vehicleRegNo); 

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.currentIndex + 1 < this.carInfoList.Count)
            {
                this.currentIndex++;
                DisplayCarInfo(this.currentIndex);
            }
            else
            {
                MessageBox.Show("You have reached the last record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(this.currentIndex > 0)
            {
                this.currentIndex--;
                DisplayCarInfo(this.currentIndex);
            }
            else
            {
                MessageBox.Show("There are no earlier records.");
            }

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.currentIndex = 0;
            DisplayCarInfo(this.currentIndex);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.currentIndex = this.carInfoList.Count - 1;
            DisplayCarInfo(this.currentIndex);
        }

        private string BuildStatusDescription()
        {
            return $"{this.currentIndex + 1} of {this.carInfoList.Count}";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEngineSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateRegistered_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRentalPerDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVehicleRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelRentalPerDay_Click(object sender, EventArgs e)
        {

        }

        private void labelEngineSize_Click(object sender, EventArgs e)
        {

        }

        private void labelMake_Click(object sender, EventArgs e)
        {

        }

        private void labelDateRegistered_Click(object sender, EventArgs e)
        {

        }

        private void labelVehicleRegNo_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DisplayCarInfo(this.currentIndex);
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            string carDescriptions = "";

            foreach(CarInfo carInfo in this.carInfoList)
            {
                carDescriptions += carInfo.ToString();
                carDescriptions += "\n";
            }

            MessageBox.Show(carDescriptions);
        }
    }
}

