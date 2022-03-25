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
        public void CreateTable()
        {
            
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ALYAZAHWA;database=ApotekZahwa;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Karyawan (Id_karyawan char(4) not null primary key, Nama_karyawan varchar(30), Jenis_Kelamin char(2),No_hp varchar(12), Alamat varchar(30))"
                    + "create table Pembeli (Id_pembeli char(4) not null primary key, Nama_pembeli varchar(30), Jenis_kelamin char(2), No_hp varchar(12), Alamat varchar(30))"
                    + "create table Obat (No_obat char(4) not null primary key, Nama_obat varchar(30), Jenis_obat varchar(30), Harga money)"+
                    "create table Transaksi (Id_transaksi char(4) not null primary key, Id_karyawan char(4) foreign key references Karyawan(Id_karyawan), Id_pembeli char(4) foreign key references Pembeli(Id_pembeli), Tanggal_transaksi date, No_obat char(4) foreign key references Obat(No_obat), Jumlah_obat char(1), Harga money, Total money)", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sepertinya tabelmu ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ALYAZAHWA;database=ApotekZahwa;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Karyawan (Id_karyawan, Nama_karyawan, Jenis_kelamin, No_hp, Alamat) values ('K001','Amelia Inada','Pr','081345767779','Sleman')"
                    + "insert into Karyawan (Id_karyawan, Nama_karyawan, Jenis_kelamin, No_hp, Alamat) values ('KOO2','Fira Septiana','Pr','081342236678','Bantul')"
                    + "insert into Karyawan (Id_karyawan, Nama_karyawan, Jenis_kelamin, No_hp, Alamat) values ('K003', 'Anggi Akilah','Pr', '082789009800','KotaBaru')"
                    + "insert into Karyawan (Id_karyawan, Nama_karyawan, Jenis_kelamin, No_hp, Alamat) values ('K004','Indah Permata','Pr','081212237789','Kulonprogo')"
                    + "insert into Karyawan (Id_karyawan, Nama_karyawan, Jenis_kelamin, No_hp, Alamat) values ('K005','Yuyun Ailah','Pr','085334122100','Bantul')"
                    + "insert into Pembeli (Id_pembeli, Nama_pembeli, Jenis_Kelamin, No_hp, Alamat) values ('P101','Indra Setiawan','Lk','081234770982','Bantul')"
                    + "insert into Pembeli (Id_pembeli, Nama_pembeli, Jenis_Kelamin, No_hp, Alamat) values ('P102','Fadilah Wirana','Pr','082445781121','Gunung Kidul')"
                    + "insert into Pembeli (Id_pembeli, Nama_pembeli, Jenis_Kelamin, No_hp, Alamat) values ('P103','Dimas Aditya','Lk','081343679000','Sleman')"
                    + "insert into Pembeli (Id_pembeli, Nama_pembeli, Jenis_Kelamin, No_hp, Alamat) values ('P104','Permata Putri','Pr','085322188769','Yogyakarta')"
                    + "insert into Pembeli (Id_pembeli, Nama_pembeli, Jenis_Kelamin, No_hp, Alamat) values ('P105','Andira Ika','Pr','085677123445','Depok')"
                    + "insert into Obat (No_obat, Nama_obat, Jenis_obat, Harga) values ('OB11','Paracetamol','Tablet',16000)"
                    + "insert into Obat (No_obat, Nama_obat, Jenis_obat, Harga) values ('OB12','Bufect','Sirup',30000)"
                    + "insert into Obat (No_obat, Nama_obat, Jenis_obat, Harga) values ('OB13','Ibnuprofen','Tablet',8000)"
                    + "insert into Obat (No_obat, Nama_obat, Jenis_obat, Harga) values ('OB14','Insto','Tetes','12000')"
                    + "insert into Obat (No_obat, Nama_obat, Jenis_obat, Harga) values ('OB15','Paratusin','Kapsul',15000)"+
                    "insert into Transaksi (Id_transaksi, Id_karyawan, Id_pembeli,Tanggal_transaksi, No_obat, Jumlah_obat, Harga, Total) values ('TR00','K001','P101','2020-12-03','OB11','1',16000,16000)"
                    + "insert into Transaksi(Id_transaksi, Id_karyawan, Id_pembeli,Tanggal_transaksi, No_obat, Jumlah_obat, Harga, Total) values('TR12', 'KOO2', 'P102','2020-12-09','OB12', '1', 30000, 30000)"
                    + "insert into Transaksi (Id_transaksi, Id_karyawan, Id_pembeli,Tanggal_transaksi, No_obat, Jumlah_obat, Harga, Total) values ('TR13','K003','P103','2020-12-04','OB13','1',8000,8000)"
                    + "insert into Transaksi (Id_transaksi, Id_karyawan, Id_pembeli,Tanggal_transaksi, No_obat, Jumlah_obat, Harga, Total) values ('TR14','K004','P104','2020-12-05','OB14','1',12000,12000)"
                    + "insert into Transaksi (Id_transaksi, Id_karyawan, Id_pembeli,Tanggal_transaksi, No_obat, Jumlah_obat, Harga, Total) values ('TR15','K005','P105','2020-12-07','OB15','1',15000,15000)",con);
                cm.ExecuteNonQuery();


                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }catch (Exception e)
            {
                Console.WriteLine("Datamu masih ada yang salah :(" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertData();
        }
    }

}