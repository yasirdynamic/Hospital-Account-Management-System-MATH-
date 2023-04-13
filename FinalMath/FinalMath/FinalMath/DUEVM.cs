using FinalMath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMath
{
    public class DUEVM
    {
        public DateTime datefrom { get; set; }
        public DateTime dateto { get; set; }
        public string VoucherNO { get; set; }
        public List<DUE> LstDue { get; set; }
        public DUEVM()
        {
            LstDue=new List<DUE>();
        }
    }
}