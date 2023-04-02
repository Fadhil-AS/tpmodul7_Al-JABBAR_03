using coba_coba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Al_JABBAR_03
{
    internal class KuliahMahasiswa1302210009
    {
        public List<MataKuliah> courses { get; set; }

        public KuliahMahasiswa1302210009() { }

        public KuliahMahasiswa1302210009(List<MataKuliah> courses)
        {
            this.courses = courses;
        }

        public void ReadJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\herui\\OneDrive\\Documents\\Semester 4\\Pemrograman Berbasis Objek (PBO OOP)\\Praktikum\\tpmodul7_Al-JABBAR_03\\tp7_2_1302210009.json");

            KuliahMahasiswa1302210009 obj = JsonSerializer.Deserialize<KuliahMahasiswa1302210009>(Des);
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

