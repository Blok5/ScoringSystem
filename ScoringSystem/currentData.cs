using System;
using System.Collections.Generic;
namespace ScoringSystem {

    public class vehicleData {
        public int id_mark;
        public decimal price;
        public string number;
        public int age;       
    }

    public static class currentData {
        public static string name;
        public static string surname;
        public static string birthDate;
        public static int id_birthPlace;
        public static string sex;
        public static string education;
        public static int id_city;
        public static int id_street;
        public static int home;
        public static int housing;

        public static vehicleData[] vehicles = new vehicleData[2];

        public static void addVehicle (vehicleData[] vd, int j) {
           for (int i = 0; i < j; i++ ) {
                vehicles[i] = new vehicleData();
                vehicles[i] = vd[i];
            }
            

        }
    }
}
