using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Windows;

namespace EMR_MAIN
{
    public class Xaml_Design
    {
        public static DataTable Load(MDB.MDBConnection oracleConnection)
        {
            try
            {
                string sql = @"select * from XAML_DESIGN order by id_xaml_design";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                DataTable DataTable = new DataTable();
                DataTable.Load(oracleDataReader as IDataReader);
                return DataTable;
            }
            catch (Exception exception)
            {
                XuLyLoi.Handle(exception);
                return null;
            }
        }
        public static bool Upload(MDB.MDBConnection oracleConnection)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Design files|*.xaml|All files (*.*)|*.*";
                if (!openFileDialog.ShowDialog() == true) return false;
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string str = streamReader.ReadToEnd();
                string line1st = str.Split(new[] { '\r', '\n' }).FirstOrDefault();
                string ten_form = XuLyChuoi.RemoveUnicode(line1st).Replace("<!--", "").Replace("-->", "").Replace(" ", "");

                var commandText = "insert into xaml_design(ten_form, xaml) values (:ten_form, :xaml)";
                using (MDB.MDBCommand command = new MDB.MDBCommand(commandText, oracleConnection))
                {
                    command.Parameters.Add(new MDB.MDBParameter("ten_form", ten_form));
                    command.Parameters.Add(new MDB.MDBParameter("xaml", str));
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception exception)
            {
                XuLyLoi.Handle(exception);
                return false;
            }
        }


        public static bool Download(MDB.MDBConnection oracleConnection, int iD)
        {
            try
            {
                string layoutFolder = Directory.GetCurrentDirectory() + "\\MedilinkLayout";
                if (!Directory.Exists(layoutFolder))
                {
                    Directory.CreateDirectory(layoutFolder);
                }
                var commandText = "select ten_form, xaml from XAML_DESIGN where id_xaml_design = :id_xaml_design";
                using (MDB.MDBCommand command = new MDB.MDBCommand(commandText, oracleConnection))
                {
                    command.Parameters.Add(new MDB.MDBParameter("id_xaml_design", iD));
                    MDB.MDBDataReader oracleDataReader = command.ExecuteReader();
                    while (oracleDataReader.Read())
                        using (StreamWriter writer = new StreamWriter(layoutFolder + "\\" + oracleDataReader["ten_form"].ToString() + ".xaml"))
                        {
                            writer.Write(oracleDataReader["xaml"].ToString());
                        }
                }
                return true;
            }
            catch (Exception exception)
            {
                XuLyLoi.Handle(exception);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection oracleConnection, int ID)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Design files|*.xaml|All files (*.*)|*.*";
                if (!openFileDialog.ShowDialog() == true) return false;
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string str = streamReader.ReadToEnd();
                string line1 = str.Split(new[] { '\r', '\n' }).FirstOrDefault();
                string ten_form = XuLyChuoi.RemoveUnicode(line1).Replace("<!--", "").Replace("-->", "").Replace(" ", "");

                var commandText = "update xaml_design set ten_form = :ten_form, xaml = :xaml where id_xaml_design = :id_xaml_design";
                using (MDB.MDBCommand command = new MDB.MDBCommand(commandText, oracleConnection))
                {
                    command.Parameters.Add(new MDB.MDBParameter("ten_form", ten_form));
                    command.Parameters.Add(new MDB.MDBParameter("xaml", str));
                    command.Parameters.Add(new MDB.MDBParameter("id_xaml_design", ID));
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception exception)
            {
                XuLyLoi.Handle(exception);
                return false;
            }
        }
    }
}
