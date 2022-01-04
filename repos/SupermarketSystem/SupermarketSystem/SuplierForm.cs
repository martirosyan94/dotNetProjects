using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketSystem.Models;

namespace SupermarketSystem
{
    public partial class SuplierForm : Form
    {
        public SuplierForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            SuplierTbl suplierTbl = new SuplierTbl
            {
                Code = int.Parse(CodeTBox.Text),
                Name = NameTbox.Text
            };

            using (var context = new supermarketContext())
            {
                var prevId = context.SuplierTbls.OrderBy(i => i.Id).LastOrDefault()?.Id ?? 0;
                suplierTbl.Id = prevId + 1;
                context.SuplierTbls.Add(suplierTbl);
                context.SaveChanges();
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodeTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
