using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Al_JABBAR_03
{
    internal class KuliahMahasiswa1302213133
    {
        public List<MataKuliah> courses { get; set; }
        public KuliahMahasiswa1302213133() { }
        public KuliahMahasiswa1302213133(List<MataKuliah> courses)
        {
            this.courses = courses;
        }

        public void readJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\Zeraume\\OneDrive\\Documents\\GitHub\\tpmodul7_Al-JABBAR_03\\tpmodul7_Al-JABBAR_03\\tp7_2_1302213133.json");
            KuliahMahasiswa1302213133 obj = JsonSerializer.Deserialize<KuliahMahasiswa1302213133>(Des);
            Console.WriteLine("Daftar mata kuliah yang diambil: ");
            for (int i = 0; i < obj.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i+1) + " " + obj.courses[i].code + " - " + obj.courses[i].name);
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
}
