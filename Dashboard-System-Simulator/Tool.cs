using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    internal class Tool
    {
        public static bool ToExist(List<string> list, string value)
        {
            bool ToExist = false;
            for (int i = 0; i < list.Count; i++)
            {
                if(value == list[i])
                {
                    ToExist = true;
                    break;
                }    
            }
            return ToExist;
        }

        public static void AddToList(List<string> userNames, List<string> passWords, List<string> fullNames, List<string> emails, List<string> phoneNumbers, string currentUser, int index, string user, string pass, string fName, string email, string phone)
        {
            if(user != null)
            {
                userNames[index] = user;
            }
            if (pass != null)
            {
                passWords[index] = pass;
            }
            if (email != null)
            {
                emails[index] = email;
            }
            if (phone != null)
            {
                phoneNumbers[index] = phone;
            }
            if (fName != null)
            {
                fullNames[index] = fName;
            }
        }
    }
}
