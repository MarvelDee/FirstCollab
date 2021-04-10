using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace MyFirstProj
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
           // CultureInfo.CurrentCulture = new CultureInfo("ja-JP", false);
            InitializeComponent();
            ShowRecord_Click(null, null);
        }


        // Event Method
        private void showBtn_Click(object sender, EventArgs e)
        {

            //char midolnem = '1';
            //string ngalan = "234";

            //MessageBox.Show(ngalan+midolnem);
            // Mu compute sa edad

            //int by = 3;
            //int cy = 2021;
            //// add +
            //// sub -
            //// mul *
            //// div /
            //// mod %
            //int answer = cy / by;
            //int mod = (cy % by);
            //string ans = answer.ToString() + " remainder " + mod.ToString();
            double tubil = 100; // 200kb
            double perLiter = 50;
            float discount = 2;
            // RAM 4G
            // prescedence
            // ()
            // *
            // +
            // -
            // /
            double ans = (tubil / perLiter) * discount;
            double another = ans * 3;
            MessageBox.Show(ans.ToString());
            decimal total = ((decimal)tubil + (decimal)perLiter + (decimal)discount);
            MessageBox.Show(total.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double realTubil = double.Parse(tubil.Text);
            double realPrice = double.Parse(price.Text);
            float discount = 2;

            double totalDisc = (realTubil / realPrice) * discount;

            // streawriter

            StreamWriter writer = new StreamWriter("database.csv",true);
            writer.WriteLine(realTubil.ToString() + "," + realPrice+","+totalDisc);
            writer.Close();


            MessageBox.Show("DATA SAVED");

            ShowRecord_Click(null, null);
        }

        private void ShowRecord_Click(object sender, EventArgs e)
        {

            // streamreader

            StreamReader reader = new StreamReader("database.csv");
            List<Trans> trans = new List<Trans>();
            string line = "";
            while((line  = reader.ReadLine())!=null)
            {
                trans.Add(new Trans
                {
                    Tubil = line.Split(',')[0],
                    Price = line.Split(',')[1],
                    Discount = String.Format("{0:N}",double.Parse(line.Split(',')[2]))
                }) ;
            }
            reader.Close();

            transactions.DataSource = null;
            transactions.DataSource = trans;
           

            // List

        }
    }

    

}

// method or function -> worker
// [NAMESPACE] - Box -> Objects
// Classes - Papel
// command,mehods
