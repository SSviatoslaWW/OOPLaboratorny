using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace laboratorna__14
{
    [Serializable]
    internal class GuestRecord:IComparable<GuestRecord>, ISerializable
    {
        string fullName;
        DateTime checkOut;
        int roomNumber;

        public GuestRecord() { }

        public GuestRecord(string fullName, DateTime checkIn, DateTime checkOut, int roomNumber)
        {
            FullName = fullName;
            CheckIn = checkIn;
            CheckOut = checkOut;
            RoomNumber = roomNumber;
        }

        void correctFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) throw new ArgumentNullException("ПІБ не може бути порожнім!!!");
        }

        void correctCheckOut(DateTime checkOut)
        {
            if (checkOut < CheckIn) throw new ArgumentOutOfRangeException("Час виїзду повинен бути пізніше часу заселення!!!");
        }

        void correctRoomNumber(int roomNumber)
        {
            if (roomNumber <= 0) throw new ArgumentOutOfRangeException("Номер кімнати повинен бути позитивним числом!!!");
        }
        
        public string FullName
        {
            get { return fullName; }
            set
            {
                correctFullName(value);
                fullName = value;
            }
        }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut
        {
            get { return checkOut; }
            set
            {
                correctCheckOut(value);
                checkOut = value;
            }
        }
        public int RoomNumber
        {
            get { return roomNumber; }
            set
            {
                correctRoomNumber(value);
                roomNumber = value;
            }
        }

        public int CompareTo(GuestRecord other)
        {
            return RoomNumber.CompareTo(other.RoomNumber);
        }

        public bool stayMoreThanOneHours()
        {
            return (CheckOut - CheckIn).TotalHours > 1;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FullName", FullName);
            info.AddValue("CheckIn", CheckIn);
            info.AddValue("CheckOut", CheckOut);
            info.AddValue("RoomNumber", RoomNumber);
        }
        protected GuestRecord(SerializationInfo info, StreamingContext context)
        {
            FullName = info.GetString("FullName");
            CheckIn = info.GetDateTime("CheckIn");
            CheckOut = info.GetDateTime("CheckOut");
            RoomNumber = info.GetInt32("RoomNumber");
        }

        public override string ToString() => $"{FullName} | Кімната: {RoomNumber} | {CheckIn} - {CheckOut}";
    }
}
