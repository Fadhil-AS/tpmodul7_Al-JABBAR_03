using coba_coba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Al_JABBAR_03
{
    internal class DataMahasiswa1302210009
    {
        public NamaLengkap nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa1302210009() { }

        public DataMahasiswa1302210009(NamaLengkap nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public void ReadJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\herui\\OneDrive\\Documents\\Semester 4\\Pemrograman Berbasis Objek (PBO OOP)\\Praktikum\\tpmodul7_Al-JABBAR_03\\tp7_1_1302210009.json");

            DataMahasiswa1302210009 obj = JsonSerializer.Deserialize<DataMahasiswa1302210009>(Des);
            Console.WriteLine("Nama : " + obj.nama.depan + " " + obj.nama.belakang + " dengan nim " + obj.nim + " dari fakultas " + obj.fakultas);
        }
    }

    public class NamaLengkap
    {
        public string depan { get; set; }
        public string belakang { get; set; }

        public NamaLengkap() { }

        public NamaLengkap(string depan, string belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}

