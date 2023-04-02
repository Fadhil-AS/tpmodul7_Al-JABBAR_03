using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Al_JABBAR_03
{
    public class DataMahasiswa_1302213012
    {
        public NamaLengkap nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa_1302213012() { }

        public DataMahasiswa_1302213012(NamaLengkap nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public void ReadJSON()
        {
            String json = File.ReadAllText("C:\\Users\\bimoz\\Downloads\\Matkul SMT 4\\Konstruksi Perangkat Lunak\\tpmodul7_Al-JABBAR_03\\tp7_1_1302213012.json");

            DataMahasiswa_1302213012 mhs = JsonSerializer.Deserialize<DataMahasiswa_1302213012>(json);
            Console.WriteLine("Nama : " + mhs.nama.depan + " " + mhs.nama.belakang + " dengan nim " + mhs.nim + " dari fakultas " + mhs.fakultas);
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
