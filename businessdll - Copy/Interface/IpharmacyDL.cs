using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessdll.Interface
{
    internal interface IpharmacyDL
    {
        void addMedicineInList(manager m);
        bool checkIfmedAlreadyExists(manager m);
        void addMedicineInFile(string path);
        bool readFromFile(string path);
        int getIndex(string name);
        void removeMedicineFromList(int i);
        void updatePrice(int price, int index);
        bool checkIfMedicinePresentInEnoughAmount(customer c);
        int calculateBillOfSingleMedicine(int index, int quantity);
    }
}
