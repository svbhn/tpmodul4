using tpmodul4_103022300081;
using System.Collections.Generic;

namespace tpmodul4_103022300081
{
    public class KodePos
    {
        private Dictionary<string, string> kodePosList;

        public KodePos()
        {
            kodePosList = new Dictionary<string, string>
            {
                { "Batununggal", "40266" },
                { "Kujangsari", "40287" },
                { "Mengger", "40267" },
                { "Wates", "40256" },
                { "Cijaura", "40287" },
                { "Jatisari", "40286" },
                { "Margasari", "40286" },
                { "Sekejati", "40286" },
                { "Kebonwaru", "40272" },
                { "Maleer", "40274" },
                { "Samoja", "40273" }
            };
        }

        public string getKodePos(string kelurahan)
        {
            if (kodePosList.ContainsKey(kelurahan))
            {
                return kodePosList[kelurahan];
            }
            else
            {
                return "Kelurahan tidak ditemukan";
            }
        }
    }
}