using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna__14
{
    internal class GuestBook : IEnumerable<GuestRecord>

    {
        List<GuestRecord> guestsBook;

        public GuestBook()
        {
            guestsBook = new List<GuestRecord>();
        }

        public void addGuest(GuestRecord guest)
        {
            guestsBook.Add(guest);
        }

        public void removeGuest(GuestRecord guest)
        {
            guestsBook.Remove(guest);
        }

        

        public string dispalyGuestsBook()
        {
            string result = "";
            foreach (GuestRecord guest in guestsBook)
            {
                result += guest.ToString() + "\n";
            }
            return result;
        }

        public void clearGuest()
        {
            guestsBook.Clear();
        }

        public int sizeGuestBook()
        {
            return guestsBook.Count;
        }

        public void sortedByRoomNumber()
        {
            guestsBook.Sort();
        }
        public IEnumerator<GuestRecord> GetEnumerator() { return guestsBook.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }


        // Збереження у файл
        public void SaveToFile(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, guestsBook);
            }
        }

        // Завантаження з файлу
        public void LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException("Файл не знайдено!");

            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                guestsBook = (List<GuestRecord>)formatter.Deserialize(stream);
            }
        }



        //public void saveToTextFile(string fileName)
        //{
        //    using (StreamWriter writer = new StreamWriter(fileName))
        //    {
        //        foreach (GuestRecord guest in guestsBook)
        //        {
        //            writer.WriteLine($"ПІБ гостя: {guest.FullName}");
        //            writer.WriteLine($"Дата реєстрації: {guest.CheckIn}");
        //            writer.WriteLine($"Дата виселення: {guest.CheckOut}");
        //            writer.WriteLine($"Номер кімнати: {guest.RoomNumber}");
        //            writer.WriteLine(); 
        //        }
        //    }
        //}

        //public void LoadFromTextFile(string filePath)
        //{
        //    if (!File.Exists(filePath)) throw new FileNotFoundException("Файл не знайдено!");

        //    guestsBook.Clear();
        //    using (StreamReader reader = new StreamReader(filePath))
        //    {
        //        string fullName = null;
        //        DateTime checkIn = DateTime.MinValue;
        //        DateTime checkOut = DateTime.MinValue;
        //        int roomNumber = 0;


        //        string line;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            if (string.IsNullOrWhiteSpace(line)) 
        //            {
        //                if (fullName != null)
        //                {
        //                    guestsBook.Add(new GuestRecord(fullName, checkIn, checkOut, roomNumber));
        //                    fullName = null; 
        //                }
        //            }
        //            else
        //            {
        //                int indexFirstTwoPoint = line.IndexOf(":");
        //                string key = line.Substring(0, indexFirstTwoPoint).Trim();
        //                string value = line.Substring(indexFirstTwoPoint + 1).Trim(); 
        //                switch (key)
        //                {
        //                    case "ПІБ гостя": fullName = value; break;
        //                    case "Дата реєстрації":
        //                        checkIn = DateTime.ParseExact(value, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        //                        break;
        //                    case "Дата виселення":
        //                        checkOut = DateTime.ParseExact(value, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        //                        break;
        //                    case "Номер кімнати": roomNumber = int.Parse(value); break;
        //                }
        //            }
        //        }

        //        if (fullName != null) guestsBook.Add(new GuestRecord(fullName, checkIn, checkOut, roomNumber));
        //    }
        //}
    }
}
