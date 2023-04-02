using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tpmodul7_Al_JABBAR_03
{
   
    internal class DataMahasiswa1302210006
    {
       
        public NamaLengkap_1302210006 nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa1302210006() { }
        public DataMahasiswa1302210006(NamaLengkap_1302210006 nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public void ReadJSON() {
            String fl = File.ReadAllText("D:\\Document\\telkom\\Semester4\\konstruksi-perangkat-lunak\\praktikum\\tpmodul7_Al-JABBAR_03\\tpmodul7_Al-JABBAR_03\\tp7_1_1302210006.json");
            DataMahasiswa1302210006 obj = JsonSerializer.Deserialize<DataMahasiswa1302210006>(fl);
            Console.WriteLine("Nama : " + obj.nama.depan + " " + obj.nama.belakang + " dengan nim " + obj.nim + " dari fakultas " + obj.fakultas);

        }
    }
    public class NamaLengkap_1302210006
    {
        public string depan { get; set; }
        public string belakang { get; set; }

        public NamaLengkap_1302210006() { }
        public NamaLengkap_1302210006(String depan, String belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}
