﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace DAO
{
    public class ABSDAO
    {
        private static string chuoiKetNoi = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=QLKS.mdb";
        public static OleDbConnection KetNoi()
        {
            OleDbConnection ketNoi = new OleDbConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
