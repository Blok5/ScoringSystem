using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace ScoringSystem {

    public class vehicleData {
        public int id_mark;
        public decimal price;
        public string number;
        public int age;       
    }

    public class contactData {
        public string phone;
        public string mail;

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

        public static vehicleData[] vehicles;
        public static vehicleData[] contacts;

        public static void addVehicle (vehicleData[] vd, int j) {
           vehicles = new vehicleData[j];
           for (int i = 0; i < j; i++ ) {
                vehicles[i] = new vehicleData();
                vehicles[i] = vd[i];
            }            
        }

        public static void showValues() {
            MessageBox.Show("Имя=" + name + " Фамилия= "+
                surname + " Дата рождения= " + birthDate + 
                "\nid_Место рождения= "+ id_birthPlace +
                " Пол= "+ sex + " Образование= "+ education + "\nid_город= " + id_city +
                " id_улица= "+ id_street + " дом= "+ home + " строение= "+housing);

                foreach (var v in vehicles) {
                MessageBox.Show("Возраст= " + v.age + " Марка= " + v.id_mark +
                    "\nНомер= " + v.number + " Цена= " + v.price);
                }
            
        }
    }
}
