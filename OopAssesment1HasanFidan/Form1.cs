using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopAssesment1HasanFidan
{
    public partial class Pizzacım : Form
    {
        public string[] MalzemeArray = new string[]
            {
                "Dana Jambon","Sosis","Mısır","Ançuez","Zeytin","Salam","Sucuk","Mantar","Tonbalığı","Peynir"
            };
        public string[] EbatlarArray = new string[] { "Küçük", "Orta", "Büyük", "Maxi" };
        string[] PizzalarArray = new string[] { "Klasik", "Karışık", "Extra Vaganza", "Italiano", "Turkish", "Tuna", "SeaFeed", "Kastamonu", "Calypso", "Akdeniz", "Karadeniz" };
        public double[] PizzaFiyatlariArray = new double[] { 14, 17, 21, 20, 23, 18, 19, 20, 24, 21, 21 };
        public double[] EbatCarpanlariArray = new double[] { 1, 1.25, 1.75, 2 };
        public string[] SiparislerArray = new string[] { };
        public List<CheckBox> Checkboxlist = new List<CheckBox>();
        public List<Siparis> SiparislerList = new List<Siparis>();
        public List<Pizza> PizzalarList = new List<Pizza>();
        public int a = 1;
        public double Kalinkenar;
        public double Toplamfiyat;
        public string KalinkenarS;
        public string Temp;
        public string Temp2;
        public Pizzacım()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            combobox_Ebatlar.DropDownStyle = ComboBoxStyle.DropDownList;
            int X = 65;
            int Y = 195;
            for (int i=0;i<MalzemeArray.Length;i++)
            {
                CheckBox cb1 = new CheckBox();
                cb1.Name = Convert.ToString(i);                
                cb1.Text = MalzemeArray[i];
                Y += 20;
                if (i < 5)
                {                    
                    cb1.Location = new Point(X, Y);                    
                    Checkboxlist.Add(cb1);
                    Controls.Add(cb1);
                    if(Y == 295)
                    {
                        Y = 195;
                    }
                }
                else
                {
                    X = 170;                                       
                    cb1.Location = new Point(X, Y);                     
                    Checkboxlist.Add(cb1);
                    Controls.Add(cb1);

                }
            }
            for (int i =0;i<EbatlarArray.Length; i++)
            {
                combobox_Ebatlar.Items.Add(EbatlarArray[i]);
            }
            for(int i=0;i<PizzalarArray.Length;i++)
            {
                listbox_Pizzalar.Items.Add(PizzalarArray[i]);
            }
            
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (rdb_KalinKenar.Checked)
            {
                Kalinkenar = 2;
                KalinkenarS = "kalın kenar";
            }
            else if(rdb_InceKenar.Checked)
            {
                Kalinkenar = 0;
                KalinkenarS = "ince kenar";
            }
           
            if (combobox_Ebatlar.SelectedItem ==null || listbox_Pizzalar.SelectedItem==null || int.TryParse(txbx_adet.Text, out a) == false )
            {
                MessageBox.Show("Hatali yada eksik giris yapildi lutfen kontrol ediniz.");
            }
            else
            {
                txbx_tutar.Text = Convert.ToString(Convert.ToDouble(txbx_adet.Text)*(Convert.ToDouble(ebatCarpanlariArray[combobox_Ebatlar.SelectedIndex])*(Convert.ToDouble(pizzaFiyatlariArray[listbox_Pizzalar.SelectedIndex] + kalinkenar))));
                btn_SepeteEkle.Enabled = true;
            }
        }

        private void btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            //creating the string for siparis list
            Temp2 = null;
            Temp = null;
            for(int i = 0; i < Checkboxlist.Count; i++)
            {
                if (Checkboxlist[i].Checked==true)
                {
                    Temp2 += Checkboxlist[i].Text + " ";
                }
            }
            Temp = Convert.ToString(listbox_Pizzalar.SelectedItem + " " + KalinkenarS + " " + Temp2 + " " + txbx_adet.Text + " "+ "adet = " +txbx_tutar.Text );
            listbox_Siparisler.Items.Add(Temp);
            Toplamfiyat += Convert.ToDouble(txbx_tutar.Text);
            txbx_ToplamTutar.Text = Convert.ToString(Toplamfiyat);
            //creating and setting the new pizza's properties 
            Pizza pizza = new Pizza
            {
                
                Tutar = Convert.ToDouble(txbx_tutar.Text),
                Cesit = Convert.ToString(listbox_Pizzalar.SelectedItem),
                Ebat = Convert.ToString(combobox_Ebatlar.SelectedItem),
                Kenar = KalinkenarS
            };
            Siparis siparis = new Siparis {


            };
            siparis.SiparisOzellik = Temp;
            SiparislerList.Add(siparis);
            //adding created pizza to the list
            PizzalarList.Add(pizza);
           
            btn_SiparisOnayla.Enabled = true;
        }
       
        private void btn_SiparisOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(SiparislerList.Count) + " adet siparisiniz var." + "toplam tutar : " + Convert.ToString(txbx_ToplamTutar.Text) + " tl'dir.");
        }
    }
}