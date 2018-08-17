using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RezervasyonProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Rezervasyon> list1 = new List<Rezervasyon>();
        List<Rezervasyon> list2 = new List<Rezervasyon>();
        List<Rezervasyon> list3 = new List<Rezervasyon>();
        int liste1Kayıt = 0;
        int liste2Kayıt = 0;
        int liste1ksd = 0;
        int liste2ksd = 0;
        int liste3ks = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

           
            List<Dictionary> saatAralik = new List<Dictionary>();

            saatAralik.Add(new Dictionary { Text = "08:00 - 09:00", Value = 1 });
            saatAralik.Add(new Dictionary { Text = "09:00 - 10:00", Value = 2 });
            saatAralik.Add(new Dictionary { Text = "10:00 - 11:00", Value = 3 });
            saatAralik.Add(new Dictionary { Text = "11:00 - 12:00", Value = 4 });
            saatAralik.Add(new Dictionary { Text = "12:00 - 13:00", Value = 5 });
            saatAralik.Add(new Dictionary { Text = "13:00 - 14:00", Value = 6 });
            saatAralik.Add(new Dictionary { Text = "14:00 - 15:00", Value = 7 });
            saatAralik.Add(new Dictionary { Text = "15:00 - 16:00", Value = 8 });
            saatAralik.Add(new Dictionary { Text = "16:00 - 17:00", Value = 9 });
            saatAralik.Add(new Dictionary { Text = "17:00 - 18:00", Value = 10 });
            saatAralik.Add(new Dictionary { Text = "18:00 - 19:00", Value = 11 });
            saatAralik.Add(new Dictionary { Text = "19:00 - 20:00", Value = 12 });

            cmbSaat.DataSource = new BindingSource(saatAralik, null);
            cmbSaat.DisplayMember = "Text";
            cmbSaat.ValueMember = "Value";

            Control.CheckForIllegalCrossThreadCalls = false;//ipliklerin aynı işlemi yapmasını engeller
            timer1.Interval = 1000;
            timer1.Start();
            veriCek();


        }
        public void veriCek()
        {
            string uzantı1 = @"rezervasyon1.txt";
            string uzantı2 = @"rezervasyon2.txt";
            string uzantı3 = @"rezervasyon.txt";
            FileStream dosyalar = null;
            string satir;
            int say = 0;
            int sayac = 1;


            if (File.Exists(uzantı1))
            {
                dosyalar = new FileStream(uzantı1, FileMode.Open, FileAccess.Read);
                StreamReader Tarama = new StreamReader(uzantı1);


                while ((satir = Tarama.ReadLine()) != null)
                {
                    String[] ss = satir.Split(',');
                    list1.Add(new Rezervasyon { gun = ss[0], saat = Convert.ToInt16(ss[1]), zaman = Convert.ToDateTime(ss[2]) });
                    say++;
                }

                Tarama.Close();
                dosyalar.Flush();
                dosyalar.Close();

                liste1ksd = say;
                liste1Kayıt = list1.Count();

            }
            if (File.Exists(uzantı2))
            {
                dosyalar = new FileStream(uzantı2, FileMode.Open, FileAccess.Read);
                StreamReader Tarama = new StreamReader(uzantı2);

                while ((satir = Tarama.ReadLine()) != null)
                {
                    String[] ss = satir.Split(',');
                    list2.Add(new Rezervasyon { gun = ss[0], saat = Convert.ToInt16(ss[1]), zaman = Convert.ToDateTime(ss[2]) });
                    say++;
                }

                Tarama.Close();
                dosyalar.Flush();
                dosyalar.Close();

            }

            if (File.Exists(uzantı3))
            {
                dosyalar = new FileStream(uzantı3, FileMode.Open, FileAccess.Read);
                StreamReader Tarama = new StreamReader(uzantı3);

                listBox.Items.Add("                          REZERVASYON LİSTESİ");
                listBox.Items.Add("");

                while ((satir = Tarama.ReadLine()) != null)
                {
                    String[] ss = satir.Split(',');
                    list3.Add(new Rezervasyon { gun = ss[0], saat = Convert.ToInt16(ss[1]), zaman = Convert.ToDateTime(ss[2]) });
                    string eleman = (sayac) + ". kayıt =  " + ss[1] + " nolu saat dilimi " + ss[0].ToUpper() + " gününe " + ss[2] + " kayıt";
                    listBox.Items.Add(eleman);
                    sayac++;
                }

                Tarama.Close();
                dosyalar.Flush();
                dosyalar.Close();

            }
        }
        public Rezervasyon sirala(int dosya, string gun, int saatDilimi)
        {
            if (dosya == 1)
            {
                foreach (var item in list1)
                {
                    if ((item.gun == gun) && (item.saat == saatDilimi))
                    {
                        return item;
                    }
                }
            }
            if (dosya == 2)
            {
                foreach (var item in list2)
                {
                    if ((item.gun == gun) && (item.saat == saatDilimi))
                    {
                        return item;
                    }
                }
            }

            return null;
        }
        public void veriGonder(int rezerveKullanici, string gun, int saatDilimi, DateTime rzrve)
        {

            FileStream dosyalar = null;
            Rezervasyon rez = new Rezervasyon();
            string dosya_yolu = "";
            if (rezerveKullanici == 1)
            {
                dosya_yolu = @"rezervasyon1.txt";
            }
            else if (rezerveKullanici == 2)
            {
                dosya_yolu = @"rezervasyon2.txt";
            }
            else if (rezerveKullanici == 3) 
            {
                dosya_yolu = @"rezervasyon.txt";
               
              FileStream fs2 = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
                StreamWriter sw2 = new StreamWriter(fs2);

                foreach (var item in list3)
                {
                    String yazi2 = item.gun + "," + item.saat + "," + item.zaman.ToString();
                    sw2.WriteLine(yazi2);
                }

                sw2.Flush();
                sw2.Close();
                fs2.Close();
                //}

                return;
            }



            if (File.Exists(dosya_yolu))
            {
                dosyalar = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                if (rezerveKullanici == 1)
                    liste1ksd++; 
                else if (rezerveKullanici == 2)
                    liste2ksd++;
            }
            else
            {
                dosyalar = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                if (rezerveKullanici == 1)
                    liste1ksd++;
                else if (rezerveKullanici == 2)
                    liste2ksd++;
            }

           
            StreamWriter yazici = new StreamWriter(dosyalar);
     
            rez.gun = gun;
            rez.saat = saatDilimi;
            rez.zaman = rzrve;

            if (rezerveKullanici == 1)
            {
                list1.Add(rez);
                list3.Add(rez);
                string mesaj = "1 numaralı listeden" + (int)cmbSaat.SelectedValue + " . saat dilimine " + gun.ToUpper() + " günü " + rzrve + "  tarihine kayıt yapmıştır.";
                listBox.Items.Add(mesaj);
            }
            else if (rezerveKullanici == 2)
            {
                list2.Add(rez);
                list3.Add(rez);
                string mesaj = "2 numaralı rezervasyon" + (int)cmbSaat.SelectedValue + " numaralı saat dilimine " + gun.ToUpper() + " günü " + rzrve + "  tarihine kayıt yapmıştır.";
                listBox.Items.Add(mesaj);
            }
            //else if (rezerveKullanici == 3)
            //{
            //    rezervasyon.Add(rez);
            //    string mesaj = "Ortak rezervasyon dosyasına da kayıt atılmıştır.";
            //    listBox.Items.Add(mesaj);
            //}

            String yazi = gun + "," + saatDilimi + "," + rzrve.ToString();
            yazici.WriteLine(yazi);
            //Dosyaya ekleyeceğimiz  yazıyı WriteLine() metodu ile yazacağız.
            yazici.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            yazici.Close();
            dosyalar.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.

        }


       


        private void btnRezervasyon_Click(object sender, EventArgs e)
        {

            if (cmbGun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen gün seçiniz");
                return;
            }
            if (!rdRez1.Checked && !rdRez2.Checked)
            {
                MessageBox.Show("Lütfen liste seçiniz");
                return;
            }

            if (ayniMi(1, cmbGun.Text, (int)cmbSaat.SelectedValue) && ayniMi(2, cmbGun.Text, (int)cmbSaat.SelectedValue))
                return;



            if (rdRez1.Checked)
            {
                if (ayniMi(1, cmbGun.Text, (int)cmbSaat.SelectedValue))
                    return;
                DateTime tarih = DateTime.Now;
                if (!ayniMi(1, cmbGun.Text, (int)cmbSaat.SelectedValue) && ayniMi(2, cmbGun.Text, (int)cmbSaat.SelectedValue)) // 1 de yok 2 de varsa
                {
                    Rezervasyon r2 = sirala(2, cmbGun.Text, (int)cmbSaat.SelectedValue);
                    if (r2.zaman <= tarih)
                    {
                        veriGonder(1, r2.gun, r2.saat, r2.zaman);
                      
                        listBox.Items.Add("kayıt " + tarih + " tarihinde" + r2.zaman + " tarihine çekildi");
                    }
                    else
                    {
                        veriGonder(1, cmbGun.Text, (int)cmbSaat.SelectedValue, tarih);
                        
                    }

                }
                else
                {
                    veriGonder(1, cmbGun.Text, (int)cmbSaat.SelectedValue, tarih);
                    
                }


            }
            else if (rdRez2.Checked)
            {
                if (ayniMi(2, cmbGun.Text, (int)cmbSaat.SelectedValue))
                    return;
                DateTime tarih = DateTime.Now;
                if (!ayniMi(2, cmbGun.Text, (int)cmbSaat.SelectedValue) && ayniMi(1, cmbGun.Text, (int)cmbSaat.SelectedValue)) // 2 de yok 1 de varsa
                {
                    Rezervasyon r1 = sirala(1, cmbGun.Text, (int)cmbSaat.SelectedValue);
                    if (r1.zaman <= tarih)
                    {

                        veriGonder(2, r1.gun, r1.saat, r1.zaman);
                       
                        listBox.Items.Add("Bu saat dilimine daha önceden kayıt girildiği için" + tarih + " tarihi yerine" + r1.zaman + " tarihi olarak güncellenmiştir.");
                    }
                    else
                    {
                        veriGonder(2, cmbGun.Text, (int)cmbSaat.SelectedValue, tarih);
                        
                    }
                }
                else
                {
                    veriGonder(2, cmbGun.Text, (int)cmbSaat.SelectedValue, tarih);
                    
                }
            }

        }

        public void rezervasyon1Kontrol()
        {
            if (liste1ksd != liste1Kayıt)
            {
                rezervasyonKontrol();
            }
        }

        public void rezervasyon2Kontrol()
        {
            if (liste2ksd != liste2Kayıt)
            {
                rezervasyonKontrol();

            }
        }

        public void rezervasyonKontrol()
        {


            if (list3.Count() != liste3ks)
            {

                list3.Clear();
                list3.AddRange(list1);
                list3.AddRange(list2);
                list3 = new Rezervasyon().TekrarlilariSil(list3, list1, list2);
                liste3ks = list3.Count();
                veriGonder(3, "", 0, DateTime.Now);
            }

        }

        public void iplikler()
        {
            Thread iplik1 = new Thread(new ThreadStart(rezervasyon1Kontrol));
            Thread iplik2 = new Thread(new ThreadStart(rezervasyon2Kontrol));

            iplik1.Start();
            iplik2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iplikler();
        }

        public bool ayniMi(int dosya, string gun, int saatDilimi)
        {
            if (dosya == 1)
            {
                foreach (var item in list1)
                {
                    if ((item.gun == gun) && (item.saat == saatDilimi))
                    {
                        MessageBox.Show("listede bu bilgilerde kayıt bulunmaktadır.");

                        return true;
                    }
                }
            }
            if (dosya == 2)
            {
                foreach (var item in list2)
                {
                    if ((item.gun == gun) && (item.saat == saatDilimi))
                    {
                        MessageBox.Show("listede bu bilgilerde kayıt bulunmaktadır.");
                        return true;
                    }
                }
            }


            return false;

        }


        
        public int tekrarKayıtSay(string gun, int saatDilimi, DateTime rze)
        {
            int say = 0;
            foreach (var item in list3)
            {
                if ((item.gun == gun) && (item.saat == saatDilimi) && (item.zaman == rze))
                {
                    say++;

                }
            }
            return say;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

