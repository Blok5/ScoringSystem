﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
//TODO: Добавить транзакцию добавления всего класса в базу данных

namespace ScoringSystem {


    /// <summary>
    /// Класс currenCreditData хранит ткущие данные о кредите
    /// </summary>
    public static class CurrentCreditData {
        public static int period;
        public static decimal sum;
        public static string target;
        public static string savingAcc;
        public static string otherDebtors;
        public static string otherInstallment;
        public static string housing;
        public static int numberOfExistingCredits;
        public static int installmentRate;
        public static int presentResidenceSince;
        public static int numberOfMaintenance;
    }

    /// <summary>
    /// Класс RealEstateData хранит данные о недвижимости
    /// </summary>
    /// 
    public class RealEstateData {
        public string type;
        public int location;
        public string dateBuy;
        public int square;
        public decimal price;
    }
    
    /// <summary>
    /// Класс RelationData хранит данные о родственных связях
    /// </summary>
    public class RelationsData {
        public int id_man;
        public int id_relation;
    }

    /// <summary>
    /// Класс VehicleData хранит данные о транспортном средстве
    /// </summary>
    public class VehicleData {
        public int id_mark;
        public decimal price;
        public string number;
        public string productionDate;       
    }

    /// <summary>
    /// Класс WorkData хранит данные о работе
    /// </summary>
    public class WorkData {
        public string name;
        public string position;
        public int workDuration;
    }

    /// <summary>
    /// Класс ContactData хранит данные о контактах
    /// </summary>
    public class ContactData {
        public string phone;
        public string mail;

    }

    /// <summary>
    /// Класс CurrentData хранит все текущие данные,
    /// которые заносятся об очередном клиенте
    /// </summary>
    public static class CurrentClientData {
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
        public static string personalStatus;
        public static string creditHistory;
        public static decimal checkingAccount;
        public static bool foreignWorker;
        

        public static VehicleData[] vehicles;
        public static ContactData[] contacts;
        public static RealEstateData[] realEstates;
        public static WorkData work;
        public static RelationsData[] relations;

        /// <summary>
        /// Метод addVehicle добавляет странспортные средства к клиенту
        /// </summary>
        /// <param name="vd">Массив с транспортными средствами</param>
        /// <param name="j">Их количество</param>
        public static void addVehicle (VehicleData[] vd, int j) {
           vehicles = new VehicleData[j];
           for (int i = 0; i < j; i++ ) {
                vehicles[i] = new VehicleData();
                vehicles[i] = vd[i];
            }            
        }

        /// <summary>
        /// Метод addRealEstate добавляет недвижимость к клиенту
        /// </summary>
        /// <param name="red">Массив с недвижимостью</param>
        /// <param name="j">Параметр типа int - кол-во недвижимости</param>
        public static void addRealEstate (RealEstateData[] red, int j) {
            realEstates = new RealEstateData[j];
            for (int i = 0; i < j; i++) {
                realEstates[i] = new RealEstateData();
                realEstates[i] = red[i];
            }
        }

        /// <summary>
        /// Метод addWork добавляет информацию о работе, на которой
        /// работает клиент
        /// </summary>
        /// <param name="name">Параметр типа string - название организации</param>
        /// <param name="position">Параметр типа string - должность</param>
        /// <param name="workDuration">Параметр типа string - Продолжительность работы на одном месте</param>
        public static void addWork(string name, string position, int workDuration) {
            work = new WorkData();
            work.name = name;
            work.position = position;
            work.workDuration = workDuration;

        }

        /// <summary>
        /// Метод addRelation добавляет родственные связи к клиенту
        /// </summary>
        /// <param name="rd">Массив родственных связей</param>
        public static void addRelation(RelationsData[] rd) {
            relations = new RelationsData[rd.Length];

            for (int i = 0; i < rd.Length; i++ ) {
                relations[i] = new RelationsData();
                relations[i] = rd[i]; 
            }
        }

        /// <summary>
        /// Метод addContacts добавляет контакты к клиенту
        /// </summary>
        /// <param name="cd">Массив контактов</param>
        public static void addContact(ContactData[] cd) {
            contacts = new ContactData[cd.Length];

            for (int i = 0; i < cd.Length; i++) {
                contacts[i] = new ContactData();
                contacts[i] = cd[i];
            }
        }
        /// <summary>
        /// Метод addValuesToDB добавляет все текущие значения в базу данных
        /// </summary>
        public static void addValuesToDB() {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;
            try {
                connection.Open();


                string sqlCommand = "";

                SqlCommand cmd = new SqlCommand(sqlCommand, connection);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ' ' + ex.Source + ' ' + ex.InnerException);
            } finally {
                connection.Close();
            }
        }

        /// <summary>
        /// Метод cleanData очищает данный класс от текущих данных
        /// </summary> 
        public static void cleanData() {
            name = null;
            surname = null;
            birthDate = null;
            id_birthPlace = 0; ;
            sex = null;
            education = null;
            id_city = 0;
            id_street = 0;
            home = 0;
            housing = 0;
            familyIncome = 0;
            income = 0;
            outcome = 0;
            personalStatus = null;
            creditHistory = null;
            checkingAccount = 0;

    }

        /// <summary>
        /// Метод showValues выводит все значения о текущем клиенте
        /// </summary>
        public static void showValues() {
            MessageBox.Show("Имя=" + name + " Фамилия= " +
                surname + " Дата рождения= " + birthDate +
                "\nid_Место рождения= " + id_birthPlace +
                " Пол= " + sex + " Образование= " + education + "\nid_город= " + id_city +
                " id_улица= " + id_street + " дом= " + home + " строение= " + housing +
                "\nДоходы= " + income + " Семейные доходы= " + familyIncome + " Расходы= " + outcome +
                "\nСемейное положение= " + personalStatus);

            if (realEstates != null) {
                foreach (var v in realEstates) {
                    MessageBox.Show("Дата покупки= " + v.dateBuy + "\nМесто расположения= " +
                        v.location + " Цена= " + v.price + " Площадь= " + v.square +
                        " Тип= " + v.type);
                }
            }

            if (vehicles != null) {
                foreach (var v in vehicles) {
                    MessageBox.Show("Возраст= " + v.productionDate + " Марка= " + v.id_mark +
                        "\nНомер= " + v.number + " Цена= " + v.price);
                }
            }
           
            if (work!= null) {
                MessageBox.Show("Название организации: " + work.name + "\nКатегория должности: " + work.position +
                    " Продолжительность работы: " + work.workDuration + "мес.");
            }

            if (relations != null) {
                foreach (var r in relations) {
                    MessageBox.Show("id человека: " + r.id_man.ToString() +
                        " id связи: " + r.id_relation.ToString());
                }
            }

            if (contacts != null) {
                foreach (var c in contacts) {
                    MessageBox.Show("Контакт: " + c.phone.ToString() +
                        " Электронная почта: " + c.mail.ToString());
                }
            }
        }
    }
}
