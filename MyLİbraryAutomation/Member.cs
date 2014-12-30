using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class Member
    {
        int IdNo;
        string MemberName;
        string Adress;


        public int getIdNo()
        {
            return IdNo;
        }

        public void setIdNo(int IdNo)
        {
            this.IdNo = IdNo;
        }




        public string getMemberName()
        {
            return MemberName;
        }

        public void setMemberName(string MemberName)
        {
            this.MemberName = MemberName;
        }




        public string getAdress()
        {
            return Adress;
        }

        public void setAdresse(string Adress)
        {
            this.Adress = Adress;
        }


    }
}
