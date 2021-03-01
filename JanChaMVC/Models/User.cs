using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Models
{
    public partial class User
    {
        
        public int UId { get; set; }
        public string UserName { get; set; }
        public bool   UserSex   { get; set; }
        public int    Age       { get; set; }
        public DateTime Time1 { get; set; }
        public string Phone { get; set; }//手机号
        public int Emile { get; set; }//电子邮件
        public string Note { get; set; }//备注
        public string Number { get; set; }//账号
        public string Password { get; set; }//密码
    }

}
