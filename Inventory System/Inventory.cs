using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        int hitCount = 2;
        int maxWeight = 100;
        int currentWeight = 0;
        int damage = 10;
        float gold = 0.00f;
        bool weapon = false;
        string option = "";
        int weaponWeight
        public void Menu()
        {

            string choice = "";


            while (choice != "0")
            {
                //Display menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Add gold");
                Console.WriteLine("4: Subtract gold");
                Console.WriteLine("5: Equip Armor");
                Console.WriteLine("6: Unequip Armor");

                //Get playerinput
                choice = Console.ReadLine();
                Console.WriteLine("");

                //Input checking
                if (choice == "1")
                {
                    Console.Clear();
                    EquipWeapon();
                }

                else if (choice == "2")
                {
                    if (weapon == true)
                    {
                        UnequipWeapon();
                    }
                    else if (weapon == false)
                    {
                        Console.WriteLine("You do not have a weapon equipped my dude...");
                    }
                }

                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("How much gold? ");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }

                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Throw away how much gold? ");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(subtractedGold);
                }
                else if (choice == "5")
                {

                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Wait a minute... type a listed command... retard...");
                }

            }
        }

        public void EquipWeapon()
        {
            if (weapon == false)
            {
                Console.WriteLine("Select a Weapon.");
                Console.WriteLine("\n Weapon Menu: \n1: Magikarp \n2: Slappy2000 \n3: Big Fella " +
                    "\n4: Smol Boi \n5: Exit Menu");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Magikarp has been equipped.");
                    damage = 15;
                    hitCount = 5;
                    currentWeight += 10;
                    Console.WriteLine("Damage " + damage);
                    Console.WriteLine("Hit Count is now " + hitCount);
                    Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                    weapon = true;
                }

                else if (option == "2")
                {
                    Console.WriteLine("Slappy2000 has been equipped.");
                    damage = 35;
                    hitCount = 1;
                    currentWeight += 25;
                    Console.WriteLine("Damage " + damage);
                    Console.WriteLine("Hit Count is now " + hitCount);
                    Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                    weapon = true;
                }

                else if (option == "3")
                {
                    Console.WriteLine("Big Fella has been equipped.");
                    damage = 30;
                    hitCount = 2;
                    currentWeight += 20;
                    Console.WriteLine("Damage " + damage);
                    Console.WriteLine("Hit Count is now " + hitCount);
                    Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                    weapon = true;
                }

                else if (option == "4")
                {
                    Console.WriteLine("Smol Boi has been equipped.");
                    damage = 20;
                    hitCount = 4;
                    currentWeight += 15;
                    Console.WriteLine("Damage " + damage);
                    Console.WriteLine("Hit Count is now " + hitCount);
                    Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                    weapon = true;
                }

                else if (option == "5")
                {
                    return;
                }

                if (currentWeight > maxWeight)
                {
                    Console.ReadKey();
                    Console.Clear();
                    if (option == "1")
                    {
                        Console.WriteLine("you have equi.... wait no that is too heavy.. pick another weapon.");
                        currentWeight = 0;
                        hitCount = 2;
                        damage = 10;
                        Console.WriteLine("Damage " + damage);
                        Console.WriteLine("Hit Count is now " + hitCount);
                        Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                        weapon = false;
                    }

                    if (option == "2")
                    {
                        Console.WriteLine("you have equi.... wait no that is too heavy.. pick another weapon.");
                        currentWeight = 0;
                        hitCount = 2;
                        damage = 10;
                        Console.WriteLine("Damage " + damage);
                        Console.WriteLine("Hit Count is now " + hitCount);
                        Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                        weapon = false;
                    }

                    if (option == "3")
                    {
                        Console.WriteLine("you have equi.... wait no that is too heavy.. pick another weapon.");
                        currentWeight = 0;
                        hitCount = 2;
                        damage = 10;
                        Console.WriteLine("Damage " + damage);
                        Console.WriteLine("Hit Count is now " + hitCount);
                        Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                        weapon = false;
                    }

                    if (option == "4")
                    {
                        Console.WriteLine("you have equi.... wait no that is too heavy.. pick another weapon.");
                        currentWeight = 0;
                        hitCount = 2;
                        damage = 10;
                        Console.WriteLine("Damage " + damage);
                        Console.WriteLine("Hit Count is now " + hitCount);
                        Console.WriteLine("Weight is now " + currentWeight + "/" + maxWeight);
                        weapon = false;
                    }
                    EquipWeapon();

                }
   
            }
           
        }

        public void UnequipWeapon()
        {
            if (weapon == true)
            {
                Console.WriteLine("Unequipped a weapon.");
                damage = 10;
                hitCount = 1;
                currentWeight = 0;
                weapon = false;
                Console.WriteLine("Damage " + damage);
            }
            
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }

        public void SubtractGold(float amount)
        {
            gold -= amount;
            if (gold < 0)
            {
                gold += amount;
                Console.WriteLine("You can't do that...");
            }

            else
            {
                Console.WriteLine("Lost " + amount + " gold");
            }

            Console.WriteLine("Gold: " + gold);
        }

    }
} /*public void EquipWeapon(string weaponName, int weaponDamage, int weaponWeight, int hitCount
        if option == "1" 
        EquipWeapon(Magikarp,15, 10, 5) */


