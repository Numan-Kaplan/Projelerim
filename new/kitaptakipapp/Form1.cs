using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitaptakipapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kitapTakipEntities k = new kitapTakipEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapTakipDataSet.kitaplarim' table. You can move, or remove it, as needed.
            this.kitaplarimTableAdapter.Fill(this.kitapTakipDataSet.kitaplarim);
            cbkind.Items.Add("Roman");
            cbkind.Items.Add("Tarih");
            cbkind.Items.Add("Hikaye");
            cbkind.Items.Add("Felsefe");
            cbkind.Items.Add("Kişisel Gelişim");
            cbkind.Items.Add("Çizgi Roman");
            
            using (var data = new kitapTakipEntities())
            {
            var get = data.kitaplarims.ToList();
            
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = get;
                datashow.DataSource = bindingSource;

                var show = k.kitaplarims.Count();
                BOOKNUM.Text = show.ToString();

                using (var context = new kitapTakipEntities())
                {
                    var sum = context.kitaplarims
                        .Sum(x =>(int?) x.Page) ?? 0;
                    PAGENUM.Text = sum.ToString();
                        
                }
              

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var kitap = new kitaplarim()
                {
                    Name = txtbook.Text,
                    Kind = cbkind.Text,
                    Writer = txtwriter.Text,
                    Page = int.Parse(txtnum.Text)

                };
                k.kitaplarims.Add(kitap);
                k.SaveChanges();
                using (var data = new kitapTakipEntities())
                {
                    var get = data.kitaplarims.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = get;
                    datashow.DataSource = bindingSource;
                }

                var showbook = k.kitaplarims.Count();
                BOOKNUM.Text = showbook.ToString();

                var showpage = k.kitaplarims.Sum(p=> p.Page);
                PAGENUM.Text = showpage.ToString();

                txtbook.Text = null;
                txtnum.Text = null;
                txtwriter.Text = null;
                cbkind.Text = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string button = txtbook.Text;
                var sil = k.kitaplarims.FirstOrDefault(x => x.Name == button);

                k.kitaplarims.Remove(sil);
                k.SaveChanges();
                using (var data = new kitapTakipEntities())
                {
                    var get = data.kitaplarims.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = get;
                    datashow.DataSource = bindingSource;
                }
                var showbook = k.kitaplarims.Count();
                BOOKNUM.Text = showbook.ToString();

                using (var context = new kitapTakipEntities())
                {
                    var sum = context.kitaplarims
                        .Sum(x => (int?)x.Page) ?? 0;
                    PAGENUM.Text = sum.ToString();

                    txtbook.Text = null;
                    txtnum.Text = null;
                    txtwriter.Text = null;
                    cbkind.Text = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = txtsearch.Text; 

                if (filter != "")
                {
                    using (var data = new kitapTakipEntities())
                    {

                        var searchresult = data.kitaplarims
                            .Where(x => x.Name.Contains(filter) || x.Writer.Contains(filter) || x.Kind.Contains(filter))
                            .ToList();

                     
                        BindingSource source = new BindingSource();
                        source.DataSource = searchresult;
                        datashow.DataSource = source;
                    }
                }
                else
                {
                   
                    using (var data = new kitapTakipEntities())
                    {
                        var all  = data.kitaplarims.ToList();

                        BindingSource source = new BindingSource();
                        source.DataSource = all;
                        datashow.DataSource = source;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }
    }
}
