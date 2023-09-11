﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public List<Item> ItemsList = new List<Item>();
        public List<User> UsersList = new List<User>();
        public List<Rent> RentsList = new List<Rent>();

        public void CreateItem()
        {
            Console.WriteLine("Aggiungi un nuovo Item alla libreria:");
            Console.WriteLine("IdCode:");
            string idCode = Console.ReadLine();
            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Release date:");
            string releaseDate = Console.ReadLine();
            Console.WriteLine("Sector:");
            string sector = Console.ReadLine();
            Console.WriteLine("Placement:");
            string placement = Console.ReadLine();
            Console.WriteLine("Author:");
            string author = Console.ReadLine();

            Item item = new Item(idCode, title, releaseDate, sector, placement, author);    
            ItemsList.Add(item);
        }

        public void CreateRent()
        {
            Console.WriteLine("Prendi in prestito un Item dalla libreria:");
            Console.WriteLine("Inserisci la data in un cui vorresti ritirare il libro e quella in cui vorresti restituirlo nel formato (xx/xx/xxxx), (xx/xx/xxxx)");
            string rentDates = Console.ReadLine();

            Rent rent = new Rent(rentDates);
        }

        public void CreateUser()
        {
            Console.WriteLine("Registrati nel sistema come nuovo utente:");
            Console.WriteLine("Nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Cognome");
            string surname = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Contatto telefonico:");
            int phoneContact = Console.
        }
    }
}
