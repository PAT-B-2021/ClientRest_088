using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using ServiceRest_088;

namespace ClientRest_025_MuhammadHerlambang
{
    class ClassData
    {
        public void getData()
        {
            //var type data yang tidak peduli pada bentukk, tapi isinya
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            /* for (int i = 0; i<data.Count; i++)
             * {
             * Console.Writeline(data[i].nama);
             * Console.Writeline(data[i].nim);
             * Console.Writeline(data[i].prodi);
             * Console.Writeline(data[i].angatan);
             * }*/

            foreach (var mhs in data)
            {
                Console.WriteLine("Nama : " + mhs.nama);
                Console.WriteLine("NIM : " + mhs.nim);
                Console.WriteLine("Prodi : " + mhs.prodi);
                Console.WriteLine("Angkatan : " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}