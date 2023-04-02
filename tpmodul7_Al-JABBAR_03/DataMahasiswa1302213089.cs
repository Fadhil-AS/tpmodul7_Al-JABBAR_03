using System.Text.Json;

namespace coba_coba
{
    public class DataMahasiswa1302213089
    {
        public NamaLengkap nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa1302213089() { }

        public DataMahasiswa1302213089(NamaLengkap nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public void ReadJSON()
        {
            String Des = File.ReadAllText("D:\\Kuliah\\Semester 4\\TP KPL\\tpmodul7_Al-JABBAR_03\\tp_1_1302213089.json");

            DataMahasiswa1302213089 obj = JsonSerializer.Deserialize<DataMahasiswa1302213089>(Des);
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
