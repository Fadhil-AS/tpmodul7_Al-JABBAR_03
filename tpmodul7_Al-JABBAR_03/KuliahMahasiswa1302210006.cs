using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Al_JABBAR_03
{
    public class MataKuliah_1302210006 { 
        public string code { get; set; }
        public string name { get; set; }

        public MataKuliah_1302210006() { }
        public MataKuliah_1302210006(String code, String name) { 
            this.code = code;
            this.name = name;
        }
    }
    internal class KuliahMahasiswa1302210006
    {
        public List<MataKuliah_1302210006> courses { get; set; }
        public KuliahMahasiswa1302210006() { }

        public KuliahMahasiswa1302210006(List<MataKuliah_1302210006> courses)
        {
            this.courses = courses;
        }

        public void ReadJSON() {
            String fl = File.ReadAllText("D:\\Document\\telkom\\Semester4\\konstruksi-perangkat-lunak\\praktikum\\tpmodul7_Al-JABBAR_03\\tpmodul7_Al-JABBAR_03\\tp7_2_1302210006.json");
            KuliahMahasiswa1302210006 obj = JsonSerializer.Deserialize<KuliahMahasiswa1302210006>(fl);

            Console.WriteLine("Daftar mata kuliah yang diambil: ");
            for (int i = 0; i < obj.courses.Count; i++) {
                Console.WriteLine("MK " + (i+1) + obj.courses[i].code + " - " + obj.courses[i].name);
            }
        }
    }
}
