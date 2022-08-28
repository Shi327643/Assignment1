using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfoLib
{
    public class Persons
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; } 
            
        }

        private string emailID;
        public string EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Persons(string _firstname, string _lastname, string _emailid, DateTime _dateofbirth)
        {

            FirstName = _firstname;
            LastName = _lastname;
            DateOfBirth = _dateofbirth;
            EmailID = _emailid;
            DateOfBirth = _dateofbirth;

        }

        public Boolean iSAdult()
        {
            int age =  (DateTime.Now.Year)- (dateOfBirth.Year);
            if (age>=18)
            {
                return true;
            }
            else
            {
                return false;
            }

          

        }

        public Boolean isTodayBirthDay()
        {
            int day;
            int day1;
            int month;
            int month1;

            day = dateOfBirth.Day;
            day1 = DateTime .Now.Day;

            month = dateOfBirth.Month;
            month1 = DateTime .Now.Month;

            if(day==day1 && month == month1)
            {
                return true;

            }

            else
            {
                return false;
            }


        }
        public string isSunSign(int month)
        {
            int day = dateOfBirth.Day;
            switch (month)
            {
                case 1:
                    if (day< 20)
                    {
                        return "Capricon";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                    break;
                case 2:
                    if (day < 19)
                    {
                        return "Aquarius";

                    }
                    else
                    {
                        return "Pisces";
                    }
                    break;

                case 3:
                    if (day < 21)
                    {
                        return "Pisces";
                    }
                    else
                    {
                        return "Aries";
                    }
                    break;
                case 4:
                    if (day < 20)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Taurus";
                    }
                    break;
                case 5:
                    if (day < 21)
                    {
                        return "Taurus";
                    }
                    else
                    {
                        return "Gemini";
                    }
                    break ;

                case 6:
                    if (day < 21)
                    {
                        return "Gemini";
                    }
                    else
                    {
                        return "Cancer";
                    }
                    break;
                case 7:
                    if (day < 23)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Leo";
                    }
                    break;
                case 8:
                    if(day < 23)
                    {
                        return "Leo";
                    }
                    else
                    {
                        return "Virgo";
                    }
                    break;
                case 9:
                    if( day < 23)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Libra";
                    }break;

                case 10:
                    if(day < 23)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                    break;
                case 11:
                    if (day < 22)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Sagittarius";
                    }
                    break;
                case 12:
                    if (day < 22)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Capricon";
                    }
                    break;
                default: 
                    return "Invalid Month";



     
                    
                   

            }
        }        
        

        public override string ToString()
        {
            return String.Format($"FirstName : {FirstName} LastName : {LastName}  EmailID : {EmailID} DateOfBirth : {DateOfBirth}");
        }
    }
}
