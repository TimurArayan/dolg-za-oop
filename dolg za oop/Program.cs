using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TooMuch
{
    public enum AccountType
    {
        Накопительный, 
        Кредитный
    }
    class BankAccount
    {
        static Random random = new Random();
        static int number = random.Next();
        decimal balance;
        AccountType type;
        public BankAccount(decimal balance, AccountType type)
        {
            this.balance = balance;
            this.type = type;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public AccountType Type
        {
            get { return type; }
            set { type = value;  }
        }
        public void Increase(decimal a)
        {
            balance += a;
        }
        public void Decrease(decimal a)
        {
            if (a <= balance)
            {
                balance -= a;
            }
            else
            {
                Console.WriteLine("Невозможно");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Номер счета: {number}, баланс: {balance} рублей, тип счета: {type}");
        }
    }

    public class Buiding
    {
        static Random random = new Random();
        static public int id = random.Next();
        public int height;
        public int floors;
        public int flat_count;
        public int entrance_count;

        private static HashSet<uint> Last_Random_ID = new HashSet<uint>(0);
        public Buiding(int height, int floors, int flat_count, int entrance_count)
        {
            this.height = height;
            this.floors = floors;
            this.flat_count = flat_count;
            this.entrance_count = entrance_count;
        }

        public void HeightOfFloor()
        {
            Console.WriteLine($"Height of floor is: {(double)height / (double)floors}");
        }
        public void FlatCountPerEntrance()
        {
            Console.WriteLine($"Flats per entrance: {flat_count / entrance_count}");
        }
        public void FlatCountPerFloor()
        {
            Console.WriteLine($"Flats per floor : {flat_count / entrance_count / floors}");
        }
        public void Print()
        {
            Console.WriteLine($"ID: {id}\nВысота: {height}\nЭтажей: {floors}\nКоличество квартир {flat_count}\nКоличество подъездов: {entrance_count}");
        }
    }


    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Задания 1 - 3");
            BankAccount b1 = new BankAccount(1500, AccountType.Накопительный);
            b1.Print();
            Console.WriteLine("Заданиt 4");
            Buiding b2 = new Buiding(1700, 5, 70, 3);
            b2.HeightOfFloor();
            b2.FlatCountPerEntrance();
            b2.FlatCountPerFloor();

        }

    }
}