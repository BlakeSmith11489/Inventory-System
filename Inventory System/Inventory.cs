using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        public void Menu()
        {
            string choice = "";

            while (choice != "0")
            {
                //Display menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0, Exit");

                //Get playerinput
                choice = Console.ReadLine();
            }
        }

        public void EquipWeapon()
        {

        }

        public void UnequipWeapon()
        {

        }

    }
}
