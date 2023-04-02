using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace tpmodul7_Al_JABBAR_03
{
    internal class DataMahasiswa1302213133
    {
        public NamaLengkap nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa1302213133 () { }

        public DataMahasiswa1302213133(NamaLengkap nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public void readJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\Zeraume\\OneDrive\\Documents\\GitHub\\tpmodul7_Al-JABBAR_03\\tpmodul7_Al-JABBAR_03\\tp7_1_1302213133.json");
            DataMahasiswa1302213133 obj = JsonSerializer.Deserialize<DataMahasiswa1302213133>(Des);
            Console.WriteLine("Nama: " + obj.nama.depan + " " + obj.nama.belakang + " dengan nim " + obj.nim + " dari fakultas " + obj.fakultas);
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
