using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace buisnessApplicationOOP.DL
{
    public class pharmacyDLDB
    {
        public static List<manager> medicineList = new List<manager>();

        public static void addMedicineInList(manager m)
        {
            medicineList.Add(m);
        }
        public static bool checkIfmedAlreadyExists(manager m)
        {
            bool flag = true;
            foreach (var med in medicineList)
            {
                if (m.getName() == med.getName())
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static void addMedicineInFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < medicineList.Count; i++)
            {
                f.WriteLine(medicineList[i].getName() + "," + medicineList[i].getPrice() + "," + medicineList[i].getQuantity());

            }
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRec = record.Split(',');
                    string name = splittedRec[0];
                    int price = int.Parse(splittedRec[1]);
                    int quantity = int.Parse(splittedRec[2]);
                    manager n = new manager(name, price, quantity);
                    addMedicineInList(n);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int getIndex(string name)
        {
            int index = -1;
            for (int i = 0; i < medicineList.Count; i++)
            {
                if (name == medicineList[i].getName())
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static void removeMedicineFromList(int i)
        {
            medicineList.RemoveAt(i);
        }
        public static void updatePrice(int price, int index)
        {
            medicineList[index].setPrice(price);
        }
        public static bool checkIfMedicinePresentInEnoughAmount(customer c)
        {
            bool flag = false;
            foreach (var cc in medicineList)
            {
                if (c.getName() == cc.getName() && c.getQuantity() <= cc.getQuantity())
                {
                    flag = true;
                    //break;
                }
            }
            return flag;
        }
        public static int calculateBillOfSingleMedicine(int index, int quantity)
        {
            int price = 0;
            price = price + medicineList[index].getPrice() * quantity;
            int i = medicineList[index].getQuantity() - quantity;
            medicineList[index].setQuantity(i);
            return price;
        }

    }
}
