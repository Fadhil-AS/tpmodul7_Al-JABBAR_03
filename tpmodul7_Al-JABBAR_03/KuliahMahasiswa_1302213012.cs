using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Al_JABBAR_03
{
    internal class KuliahMahasiswa_1302213012
    {
        public List<MataKuliah> courses { get; set; }

        public KuliahMahasiswa_1302213012() { }

        public KuliahMahasiswa_1302213012(List<MataKuliah> courses)
        {
            this.courses = courses;
        }

        public void ReadJSON()
        {
            String json = File.ReadAllText("C:\\Users\\bimoz\\Downloads\\Matkul SMT 4\\Konstruksi Perangkat Lunak\\tpmodul7_Al-JABBAR_03\\tp7_2_1302213012.json");

            KuliahMahasiswa_1302213012 matkul = JsonSerializer.Deserialize<KuliahMahasiswa_1302213012>(json);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < matkul.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + matkul.courses[i].code + " - " + matkul.courses[i].name);
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
