using System.Windows.Forms;

namespace ScoringSystem {
    /// <summary>
    /// Класс RealEstateData хранит данные о недвижимости
    /// <para name="type">sds</para>
    /// </summary>
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
        public int age;       
    }

    /// <summary>
    /// Класс WorkData хранит данные о работе
    /// </summary>
    public class WorkData {
        public string name;
        public string position;
        public string workDuration;
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
        public static void addWork(string name, string position, string workDuration) {
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
        /// Метод showValues выводит все значения о текущем клиенте
        /// </summary>
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

            if (relations != null) {
                foreach (var r in relations) {
                    MessageBox.Show("id человека: " + r.id_man.ToString() +
                        "id связи: " + r.id_relation.ToString());
                }
            }
        }
    }
}
