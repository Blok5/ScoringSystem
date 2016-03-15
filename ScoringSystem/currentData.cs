using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace ScoringSystem {
    public class RealEstateData {
        public string type;
        public int location;
        public string dateBuy;
        public int square;
        public decimal price;
    }

    public class RelationsData {
        public int id_man;
        public int id_relation;
    }
    public class VehicleData {
        public int id_mark;
        public decimal price;
        public string number;
        public int age;       
    }

    public class WorkData {
        public string name;
        public string position;
        public string workDuration;
    }

    public class ContactData {
        public string phone;
        public string mail;

    }

    public static class CurrentData {
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
        public static decimal familyIncome;
        public static decimal income;
        public static decimal outcome;

        public static VehicleData[] vehicles;
        public static ContactData[] contacts;
        public static RealEstateData[] realEstates;
        public static WorkData work;
        public static RelationsData[] relations;

        public static void addVehicle (VehicleData[] vd, int j) {
           vehicles = new VehicleData[j];
           for (int i = 0; i < j; i++ ) {
                vehicles[i] = new VehicleData();
                vehicles[i] = vd[i];
            }            
        }

        public static void addRealEstate (RealEstateData[] red, int j) {
            realEstates = new RealEstateData[j];
            for (int i = 0; i < j; i++) {
                realEstates[i] = new RealEstateData();
                realEstates[i] = red[i];
            }
        }

        public static void addWork(string name, string position, string workDuration) {
            work = new WorkData();
            work.name = name;
            work.position = position;
            work.workDuration = workDuration;

        }
        public static void showValues() {
            MessageBox.Show("Имя=" + name + " Фамилия= " +
                surname + " Дата рождения= " + birthDate +
                "\nid_Место рождения= " + id_birthPlace +
                " Пол= " + sex + " Образование= " + education + "\nid_город= " + id_city +
                " id_улица= " + id_street + " дом= " + home + " строение= " + housing +
                "\nДоходы= " + income + " Семейные доходы= " + familyIncome + " Расходы= " + outcome);

            if (vehicles != null) {
                foreach (var v in vehicles) {
                    MessageBox.Show("Возраст= " + v.age + " Марка= " + v.id_mark +
                        "\nНомер= " + v.number + " Цена= " + v.price);
                }
            }

            if (realEstates != null) {
                foreach (var v in realEstates) {
                    MessageBox.Show("Дата покупки= " + v.dateBuy  + "\nМесто расположения= " + 
                        v.location + " Цена= " + v.price + " Площадь= " + v.square +
                        " Тип= " + v.type);
                }
            }
            
            if (work!= null) {
                MessageBox.Show("Название организации: " + work.name + "\nКатегория должности" + work.position +
                    " Продолжительность работы" + work.workDuration);
            }
        }
    }
}
