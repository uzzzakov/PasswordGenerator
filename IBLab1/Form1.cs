using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string user = userName.Text;
            int n = user.Length;
            userNameSize.Text = n.ToString();
            char[] symbs = { '!', '”', '#', '$', '%', '&', '’', '(', ')', '*' };
            char[] numbs = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] letters = { 
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z' 
            };            
            int q = n % 5;
            string pass = "";
            Random rand = new Random();
            for (int i = 1; i < 1 + q; i++)
            {
                
                int randomI = rand.Next(symbs.Length);
                pass += symbs[randomI];
            }
            for (int i = q  + 1; i <= 8; i++)
            {
                int randomI = rand.Next(letters.Length);
                pass += letters[randomI];
            }
            int randomII = rand.Next(numbs.Length);
            pass += numbs[randomII];
            password.Text = pass;
        }
    }
}
