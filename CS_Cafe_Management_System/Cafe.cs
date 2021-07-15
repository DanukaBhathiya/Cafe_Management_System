using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Cafe_Management_System
{
    class Cafe
    {
        //Default Constructor
        public Cafe()
        {
            newLatte_Coff = 0.0;
            newEsp_Coff = 0.0;
            newiLat_Coff = 0.0;
            newvale_Coff = 0.0;
            newcappu_Coff = 0.0;
            newAf_Coff = 0.0;
            newAme_Coff = 0.0;
            newiCap_Coff = 0.0;

            newCoffee_C = 0.0;
            newRed_C = 0.0;
            newBlack_C = 0.0;
            newBoston_C = 0.0;
            newLagos_C = 0.0;
            newKilburn_C = 0.0;
            newCarlton_C = 0.0;
            newQueen_C = 0.0;
        }

        //Overload Constructor

        public Cafe(double Latte_Coff, double Esp_Coff, double iLat_Coff, double vale_Coff, double cappu_Coff,
            double Af_Coff, double Ame_Coff, double iCap_Coff, double Coffee_C, double Red_C, double Black_C,
            double Boston_C, double Lagos_C, double Kilburn_C, double Carlton_C, double Queen_C)
        {
            //Drinks
            newLatte_Coff = Latte_Coff;
            newEsp_Coff = Esp_Coff;
            newiLat_Coff = iLat_Coff;
            newvale_Coff = vale_Coff;
            newcappu_Coff = cappu_Coff;
            newAf_Coff = Af_Coff;
            newAme_Coff = Ame_Coff;
            newiCap_Coff = iCap_Coff;

            //Cakes
            newCoffee_C = Coffee_C;
            newRed_C = Red_C;
            newBlack_C = Black_C;
            newBoston_C = Boston_C;
            newLagos_C = Lagos_C;
            newKilburn_C = Kilburn_C;
            newCarlton_C = Carlton_C;
            newQueen_C = Queen_C;

        }

        //Accessor function
        public double getLatte_Coff()
        {
            return newLatte_Coff;
        }

        public double getEsp_Coff()
        {
            return newEsp_Coff;
        }

        public double getiLat_Coff()
        {
            return newiLat_Coff;
        }

        public double getvale_Coff()
        {
            return newvale_Coff;
        }

        public double getcappu_Coff()
        {
            return newcappu_Coff;
        }

        public double getAf_Coff()
        {
            return newAf_Coff;
        }

        public double getAme_Coff()
        {
            return newAme_Coff;
        }

        public double getiCap_Coff()
        {
            return newiCap_Coff;
        }


        public double getCoffee_C()
        {
            return newCoffee_C;
        }

        public double getRed_C()
        {
            return newRed_C;
        }

        public double getBlack_C()
        {
            return newBlack_C;
        }

        public double getBoston_C()
        {
            return newBoston_C;
        }

        public double getLagos_C()
        {
            return newLagos_C;
        }

        public double getKilburn_C()
        {
            return newKilburn_C;
        }

        public double getCarlton_C()
        {
            return newCarlton_C;
        }

        public double getQueen_C()
        {
            return newQueen_C;
        }


        //Member variables declared for drinks
        private double newLatte_Coff;
        private double newEsp_Coff;
        private double newiLat_Coff;
        private double newvale_Coff;
        private double newcappu_Coff;
        private double newAf_Coff;
        private double newAme_Coff;
        private double newiCap_Coff;

        //Member variables declared for cakes
        private double newCoffee_C;
        private double newRed_C;
        private double newBlack_C;
        private double newBoston_C;
        private double newLagos_C;
        private double newKilburn_C;
        private double newCarlton_C;
        private double newQueen_C;

    }
}
