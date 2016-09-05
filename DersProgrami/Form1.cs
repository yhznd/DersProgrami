using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
namespace DersProgrami
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Cizge.accdb");
        OleDbDataAdapter da;
        DataSet ds;
        int ders_saati;
        int ders_gunu;




        public void griddoldur()
        {

            da = new OleDbDataAdapter("Select * From Ders", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ders");
            tablo.DataSource = ds.Tables["Ders"];
            con.Close();
        }
        public void gridbosalt()
        {
            OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Cizge.accdb");
            OleDbDataAdapter da1 = new OleDbDataAdapter("Delete * From Ders", con);
            DataSet ds1;
            ds1 = new DataSet();
            con1.Open();
            da1.Fill(ds, "Ders");
            tablo.DataSource = ds1.Tables["Ders"];
            con.Close();
        }
        private bool DoluMu(int saat, int gun)
        {
            bool x = tablo.Rows[saat].Cells[gun].Value == null;
            if (x == true)
            {
                return true;
            }

            return tablo.Rows[saat].Cells[gun].Value.ToString().Length == 0;
        }
        public int dersSaatiAta()
        {
           
            Random rnd = new Random(); //ders_saati
            int[] dizim = new int[12]; //Dizimiz

            bool durum = true;

            for (int i = 0; i < dizim.Length; i++)
            {
                while (durum)
                {
                    ders_saati = rnd.Next(1, 13);

                    if (i == 0)
                    {
                        dizim[0] = ders_saati;
                        break; //While döngüsünden çıkılır.
                    }

                    //Dizim içersinde oluşturulan yeni sayıdan varmı diye kontrol ediliyor.
                    //Varsa durum true oluyor ve for döngüsünden çıkıyor. Çünkü yeni bir sayı atamamız gerekiyor.
                    for (int k = 0; k < i; k++)
                    {
                        if (dizim[k] == ders_saati) //Yeni oluşan sayımız dizide daha önceden varsa
                        {
                            durum = true;
                            break; //for döngüsünden çık
                        }
                        else
                            durum = false;
                    }

                    if (durum == false)
                        dizim[i] = ders_saati;
                }
                durum = true;



            }
            return ders_saati;
        }

        public int dersGunuAta()
        {


            Random rnd = new Random(); //ders_saati
            int[] dizim = new int[5]; //Dizimiz

            bool durum = true;

            for (int i = 0; i < dizim.Length; i++)
            {
                while (durum)
                {
                    ders_gunu = rnd.Next(1, 6);

                    if (i == 0)
                    {
                        dizim[0] = ders_gunu;
                        break; //While döngüsünden çıkılır.
                    }

                    //Dizim içersinde oluşturulan yeni sayıdan varmı diye kontrol ediliyor.
                    //Varsa durum true oluyor ve for döngüsünden çıkıyor. Çünkü yeni bir sayı atamamız gerekiyor.
                    for (int k = 0; k < i; k++)
                    {
                        if (dizim[k] == ders_gunu) //Yeni oluşan sayımız dizide daha önceden varsa
                        {
                            durum = true;
                            break; //for döngüsünden çık
                        }
                        else
                            durum = false;
                    }

                    if (durum == false)
                        dizim[i] = ders_gunu;
                }
                durum = true;
            }
            return ders_gunu;
        }

        public void dersAta()
        {

            int saat = dersSaatiAta();
            int gunu = dersGunuAta();

            if (gunu == 1)
            {
                if (DoluMu(saat, 1) && numericUpDown1.Value + saat < 13)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Ders SET Pazartesi=@Pazartesii Where Ders_Saati=@Saat";
                        cmd.Parameters.AddWithValue("@Pazartesii", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        saat++;
                        cmd.ExecuteNonQuery();
                        con.Close();
                     

                    }
                    comboBox1.Items.Remove(comboBox1.SelectedItem);

                    if (comboBox1.Items.Count != 0)
                        comboBox1.SelectedIndex++;
                    else
                    {
                        MessageBox.Show("Derslerin tamamı çizelgeye aktarıldı. Çizelgeyi Oluştur butonuna tıklayınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1.Enabled = false;
                        button3.Enabled = true;
                    }
                    numericUpDown1.Value = 1;
                }
            }


            else if (gunu == 2)
            {
                if (DoluMu(saat, 2) && numericUpDown1.Value + saat < 13)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Ders SET Sali=@Salii Where Ders_Saati=@Saat";
                        cmd.Parameters.AddWithValue("@Salii", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        saat++;
                        cmd.ExecuteNonQuery();
                        con.Close();
                      

                    }
                    comboBox1.Items.Remove(comboBox1.SelectedItem);

                    if (comboBox1.Items.Count != 0)
                        comboBox1.SelectedIndex++;
                    else
                    {
                        MessageBox.Show("Derslerin tamamı çizelgeye aktarıldı. Çizelgeyi Oluştur butonuna tıklayınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1.Enabled = false;
                        button3.Enabled = true;
                    }
                    numericUpDown1.Value = 1;
                }
            }

            else if (gunu == 3)
            {
                if (DoluMu(saat, 3) && numericUpDown1.Value + saat < 13)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Ders SET Carsamba=@Carsambaa Where Ders_Saati=@Saat";
                        cmd.Parameters.AddWithValue("@Carsambaa", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        saat++;
                        cmd.ExecuteNonQuery();
                        con.Close();
                      


                    }
                    comboBox1.Items.Remove(comboBox1.SelectedItem);

                    if (comboBox1.Items.Count != 0)
                        comboBox1.SelectedIndex++;
                    else
                    {
                        MessageBox.Show("Derslerin tamamı çizelgeye aktarıldı. Çizelgeyi Oluştur butonuna tıklayınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1.Enabled = false;
                        button3.Enabled = true;
                    }
                    numericUpDown1.Value = 1;
                }
            }
            else if (gunu == 4)
            {
                if (DoluMu(saat, 4) && numericUpDown1.Value + saat < 13)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE Ders SET Persembe=@Persembee Where Ders_Saati=@Saat";
                        cmd.Parameters.AddWithValue("@Persembee", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        saat++;
                        cmd.ExecuteNonQuery();
                        con.Close();
                     
                    }
                    comboBox1.Items.Remove(comboBox1.SelectedItem);

                    if (comboBox1.Items.Count != 0)
                        comboBox1.SelectedIndex++;
                    else
                    {
                        MessageBox.Show("Derslerin tamamı çizelgeye aktarıldı. Çizelgeyi Oluştur butonuna tıklayınız.", "Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        button1.Enabled = false;
                        button3.Enabled = true;
                    }
                    numericUpDown1.Value = 1;
                }
              
            }
            else if (gunu == 5)
            {
                if (DoluMu(saat, 5) && numericUpDown1.Value + saat < 13)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;

                        cmd.CommandText = "UPDATE Ders SET Cuma=@Cumaa Where Ders_Saati=@Saat";
                        cmd.Parameters.AddWithValue("@Cumaa", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        saat++;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        


                    }
                    comboBox1.Items.Remove(comboBox1.SelectedItem);

                    if (comboBox1.Items.Count != 0)
                        comboBox1.SelectedIndex++;
                    else
                    {
                        MessageBox.Show("Derslerin tamamı çizelgeye başarıyla aktarıldı.", "Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        button1.Enabled = false;
                        button3.Enabled = true;
                    }
                    numericUpDown1.Value = 1;
                }
                
                    
            }
        }

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cizgeDataSet.Ders' table. You can move, or remove it, as needed.
            this.dersTableAdapter.Fill(this.cizgeDataSet.Ders);
            comboBox1.SelectedIndex = 0;
            tablo.Visible = false;
            button3.Enabled = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dersAta();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Program tamamen temizlenecek. Devam edilsin mi?", "Silme", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                gridbosalt();
                griddoldur();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Ayrık İşlemler");
                comboBox1.Items.Add("Algoritma I");
                comboBox1.Items.Add("Algoritma II");
                comboBox1.Items.Add("Organizasyon");
                comboBox1.Items.Add("Mantık Devreleri");
                comboBox1.Items.Add("Sayısal Analiz");
                comboBox1.Items.Add("Web Teknolojileri");
                comboBox1.Items.Add("Web Programlama");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            griddoldur();
            tablo.Visible = true;
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             DialogResult r1 = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
                Application.Exit();
        }
    }
                        
                    
}

