using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models
{
    public class Customer:User
    {
        //attributes
        public string MembershipLevel;
        public string PreferedPaymentMethod;
        // i will pass and create a exception [SafeDateOnyConvertor] to avoid non existing dates
        public Customer(string name,string lastName,string typeDocument,string identificationNumber,string membershipLevel,string email,string preferedPaymentMethod,string phoneNumber,string Adreess,DateOnly bday ):
        base(name,lastName,typeDocument,identificationNumber,email,phoneNumber,Adreess,bday){

            MembershipLevel=membershipLevel;
            PreferedPaymentMethod=preferedPaymentMethod;

        }
        public void UpdateMembershipLevel(){}//ask how to implement


    }
}