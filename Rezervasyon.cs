using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RezervasyonProjesi
{
    public class Rezervasyon
    {
        public string gun { get; set; }
        public int saat{ get; set; }
        public DateTime zaman { get; set; }

        public List<Rezervasyon> TekrarlilariSil(List<Rezervasyon> r, List<Rezervasyon> r1, List<Rezervasyon> r2)
        {
            List<Rezervasyon> tmp = new List<Rezervasyon>();
            
            foreach (var item in r1)
            {
                foreach (var item2 in r2)
                {
                    if ((item.gun == item2.gun) && (item.zaman == item2.zaman) && (item.saat == item2.saat))
                    {
                        tmp.Add(item);
                    }
                }
            }

            foreach (var item in tmp)
            {
                r.Remove(item);
            }

            

            return r;
        }
    }
}
