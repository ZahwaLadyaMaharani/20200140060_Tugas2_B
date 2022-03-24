using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Table_Apotek
{
    class Program
    {
        public SqlDataReader dataread;

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ALYAZAHWA;database=ApotekZahwa;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Karyawan (Id_karyawan char(4) not null primary key, Nama_karyawan varchar(30), Jenis_Kelamin char(2),No_hp varchar(12), Alamat varchar(30))"
                    + "create table Pembeli (Id_pembeli char(4) not null primary key, Nama_pembeli varchar(30), Jenis_kelamin char(2), No_hp varchar(12), Alamat varchar(30))"
                    + "create table Obat (No_obat char(4) not null primary key, Nama_obat varchar(30), Jenis_obat varchar(30), Harga money)"
                    + "create table Transaksi (Id_transaksi char(4) not null primary key, Id_karyawan char(4) foreign key references, Id_pembeli char(4) foreign key references, Tanggal_transaksi varchar(15), No_obat char(4) foreign key references, Jumlah_obat char(1), Harga money, Total money)", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

       