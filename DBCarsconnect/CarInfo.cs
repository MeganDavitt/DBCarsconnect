using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCarsconnect
{
    class CarInfo
    {
        string vehicleRegNo;
        string make;
        string engineSize;
        DateTime dateRegistered;
        double rentalPerDay;
        int available;

        public CarInfo(string vehicleRegNo, string make, string engineSize, DateTime dateRegistered, double rentalPerDay, int available)
        {
            this.vehicleRegNo = vehicleRegNo;
            this.make = make;
            this.engineSize = engineSize;
            this.dateRegistered = dateRegistered;
            this.rentalPerDay = rentalPerDay;
            this.available = available;
        }

        public string VehicleRegNo { get => vehicleRegNo; set => vehicleRegNo = value; }
        public string Make { get => make; set => make = value; }
        public string EngineSize { get => engineSize; set => engineSize = value; }
        public DateTime DateRegistered { get => dateRegistered; set => dateRegistered = value; }
        public double RentalPerDay { get => rentalPerDay; set => rentalPerDay = value; }
        public int Available { get => available; set => available = value; }

        public override string ToString()
        {
            string desc = this.vehicleRegNo.PadRight(12);
            desc += this.make.PadRight(25);
            desc += this.engineSize.PadRight(12);
            desc += $"{this.dateRegistered:yyyy-MM-dd}".PadRight(12);
            desc += $"{this.rentalPerDay:n2}".PadLeft(10);
            if(this.available == 1)
            {
                desc += "  Yes"; //add spaces so it appears seperated from the other text
            }
            else
            {
                desc += "  No";
            }
                return desc;
        }
    }
}
