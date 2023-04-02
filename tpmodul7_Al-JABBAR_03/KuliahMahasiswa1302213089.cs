using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace coba_coba
{
    public class KuliahMahasiswa1302213089
    {
        public List<MataKuliah> courses { get; set; }

        public KuliahMahasiswa1302213089() { }

        public KuliahMahasiswa1302213089(List<MataKuliah> courses)
        {
            this.courses = courses;
        }

        public void ReadJSON()
        {
            String Des = File.ReadAllText("D:\\Kuliah\\Semester 4\\TP KPL\\tpmodul7_Al-JABBAR_03\\tp_2_1302213089.json");

            KuliahMahasiswa1302213089 obj = JsonSerializer.Deserialize<KuliahMahasiswa1302213089>(Des);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < obj.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + obj.courses[i].code + " - " + obj.courses[i].name);
            }
        }
    }

    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }

        public MataKuliah() { }

        public MataKuliah(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
