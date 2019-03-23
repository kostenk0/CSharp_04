using CSharp_04.Exceptions;
using CSharp_04.Properties;
using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace CSharp_04.Models
{
    [Serializable]
    public class Person
    {
        private DateTime dateOfBirth = DateTime.Today;
        private string _name;
        private string _surname;
        private string _email;
        private readonly bool isAdult;
        private readonly string sunSign;
        private readonly string chineseSign;
        private readonly bool isBirthday;

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public string SunSign
        {
            get
            {
                return sunSign;
            }
        }

        public string ChineseSign
        {
            get
            {
                return chineseSign;
            }

        }

        public bool IsAdult
        {
            get
            {
                return isAdult;
            }
        }

        public bool IsBirthday
        {
            get
            {
                return isBirthday;
            }
        }

        public Person()
        {

        }

        public Person(string name, string surname, string email) : this(name, surname, email, DateTime.Today)
        {

        }

        public Person(string name, string surname, DateTime dateOfBirth) : this(name, surname, "", DateTime.Today)
        {

        }

        public Person(string name, string surname, string email, DateTime dateOfBirth)
        {
            IsDateCorrect(dateOfBirth);
            IsEmailCorrect(email);
            Name = name;
            Surname = surname;
            Email = email;
            DateOfBirth = dateOfBirth;
            isAdult = CheckAdult(dateOfBirth);
            sunSign = FindSunSign();
            chineseSign = FindChineseSign();
            isBirthday = CheckBirthday();
        }

        private bool CheckAdult(DateTime date)
        {
            int age = 0;
            if (DateTime.Today.Month <= date.Month)
            {
                if (DateTime.Today.Day <= date.Day)
                    age = DateTime.Today.Year - date.Year;
            }
            else
                age = DateTime.Today.Year - date.Year - 1;
            if (age >= 18)
                return true;
            return false;
        }

        private bool CheckBirthday()
        {
            if (DateTime.Today.Month == DateOfBirth.Month
                && DateTime.Today.Day == DateOfBirth.Day)
                return true;
            return false;
        }

        private string FindSunSign()
        {
            int day = DateOfBirth.Day;
            switch (DateOfBirth.Month)
            {
                case 1:
                    if (day < 21)
                        return "Козоріг";
                    return "Водолій";
                case 2:
                    if (day < 21)
                        return "Водолій";
                    return "Риби";
                case 3:
                    if (day < 21)
                        return "Риби";
                    return "Овен";
                case 4:
                    if (day < 21)
                        return "Овен";
                    return "Телець";
                case 5:
                    if (day < 21)
                        return "Телець";
                    return "Близнюки";
                case 6:
                    if (day < 22)
                        return "Близнюки";
                    return "Рак";
                case 7:
                    if (day < 23)
                        return "Рак";
                    return "Лев";
                case 8:
                    if (day < 24)
                        return "Лев";
                    return "Діва";
                case 9:
                    if (day < 23)
                        return "Діва";
                    return "Терези";
                case 10:
                    if (day < 24)
                        return "Терези";
                    return "Скорпіон";
                case 11:
                    if (day < 23)
                        return "Скорпіон";
                    return "Стрілець";
                case 12:
                    if (day < 21)
                        return "Стрілець";
                    return "Риби";
            }
            return "Error";
        }

        private string FindChineseSign()
        {
            int year = DateOfBirth.Year % 12 + 1;
            switch (year)
            {
                case 1:
                    return "Мавпа";
                case 2:
                    return "Півень";
                case 3:
                    return "Собака";
                case 4:
                    return "Свиня";
                case 5:
                    return "Щур";
                case 6:
                    return "Бик";
                case 7:
                    return "Тигр";
                case 8:
                    return "Кролик";
                case 9:
                    return "Дракон";
                case 10:
                    return "Змія";
                case 11:
                    return "Кінь";
                case 12:
                    return "Коза";
            }
            return "Error";
        }

        private void IsEmailCorrect(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch (FormatException)
            {
                throw new EmailException();
            }
        }

        private void IsDateCorrect(DateTime date)
        {
            int age = 0;
            if (DateTime.Today.Month <= date.Month)
            {
                if (DateTime.Today.Day <= date.Day)
                    age = DateTime.Today.Year - date.Year;
            }
            else
                age = DateTime.Today.Year - date.Year - 1;

            if (date > DateTime.Today)
                throw new BornException();
            else if (age > 135)
                throw new AgeException();
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
