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
    public partial class GoodsRegistration : Form
    {
        public GoodsRegistration()
        {
            InitializeComponent();

            using (var context = new supermarketContext())
            {
                List<string> suplierNames = new List<string>();
                suplierNames = context.SuplierTbls.Select(g => g.Name).ToList();
                foreach (var name in suplierNames)
                {
                    suplierCbox.Items.Add(name);
                }

                List<string> goodsNames = new List<string>();
                goodsNames = context.GoodsNameTbls.Select(g => g.Name).ToList();
                foreach (var name in goodsNames)
                {
                    goodsCbox.Items.Add(name);
                }

                context.SaveChanges();
            }

        }

        private void GoodsRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Final_Register_Click(object sender, EventArgs e)
        {
            GoodsRegistrationTbl goodsRegistrationTbl = new GoodsRegistrationTbl
            {
               DocumentNumber = int.Parse(documentNumberTbox.Text),
               Date = DateTime.Parse(dateTbox.Text),
               RegistrationDate = DateTime.Now,
            };

            GoodsInfoTbl goodsInfoTbl = new GoodsInfoTbl
            {
                ExpirationDate = DateTime.Parse(expirationDateTbox.Text),
                Ammount = int.Parse(AmmountTbox.Text),
                PurchcasePrise = int.Parse(purchcasePriseTbox.Text),
                SalePrice = int.Parse(salePriceTbox.Text)
            };

 
            using (var context = new supermarketContext())
            {
                var prevId = context.GoodsRegistrationTbls.OrderBy(l => l.Id).LastOrDefault()?.Id ?? 0;
                goodsRegistrationTbl.Id = prevId + 1;
                goodsRegistrationTbl.SuplierTblId = context.SuplierTbls.FirstOrDefault(i => i.Name == suplierCbox.SelectedItem).Id;
                context.GoodsRegistrationTbls.Add(goodsRegistrationTbl);

                prevId = context.GoodsInfoTbls.OrderBy(l => l.Id).LastOrDefault()?.Id ?? 0;
                goodsInfoTbl.Id = prevId + 1;
                goodsInfoTbl.GoodsNameTblId = context.GoodsNameTbls.FirstOrDefault(i => i.Name == goodsCbox.SelectedItem).Id;
                context.GoodsInfoTbls.Add(goodsInfoTbl);
                context.SaveChanges();
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerGoodsBtn_Click(object sender, EventArgs e)
        {
 /*           SupermarketSystem.Models.GoodsInfo goodsInfo = new SupermarketSystem.Models.GoodsInfo
            {
                ExpirationDate = DateTime.Parse(dateTbox.Text),
                GoodsName = goodsTbox.Text,
                Ammount = AmmountTbox.Te
                PurchcasePrise
                SalePrice
                GoodsRegistrationId
            };
 */
        }

        private void suplierCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
