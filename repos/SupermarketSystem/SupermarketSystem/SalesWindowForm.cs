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
    public partial class SalesWindowForm : Form
    {
        public SalesWindowForm()
        {
            InitializeComponent();
            goodsAmmountTbox.Text = "0";
            using (var context = new supermarketContext())
            {
                List<string> groupNames = new List<string>();
                groupNames = context.GoodsGroupTbls.Select(g => g.Name).ToList();
                foreach (var name in groupNames)
                {
                    goodsGroupCbox.Items.Add(name);
                }
                context.SaveChanges();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            using (var context = new supermarketContext())
            {
                int SelectedGoodId = context.GoodsNameTbls.FirstOrDefault(i => i.Name == goodsNameCbox.SelectedItem).Id;
                var SelectedGoodInfoItem = context.GoodsInfoTbls.FirstOrDefault(i => i.Id == SelectedGoodId);
                if (SelectedGoodInfoItem.Ammount - int.Parse(goodsAmmountTbox.Text) <= 0)
                {
                    SelectedGoodInfoItem.Ammount = 0;
                }
                else
                {
                    SelectedGoodInfoItem.Ammount -= int.Parse(goodsAmmountTbox.Text);
                }
                context.GoodsInfoTbls.Update(SelectedGoodInfoItem);
                context.SaveChanges();
            }

        }

        private void goodsGroupCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new supermarketContext())
            {
                List<string> goodsNames = new List<string>();
                int searchId = context.GoodsGroupTbls.FirstOrDefault(i => i.Name == goodsGroupCbox.SelectedItem).Id;
                goodsNames = context.GoodsNameTbls.Where(g => g.GoodsGroupTblId == searchId).Select(g=>g.Name).ToList();
                foreach (var name in goodsNames)
                {
                    goodsNameCbox.Items.Add(name);
                }
                context.SaveChanges();
            }

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            goodsAmmountTbox.Text = (int.Parse(goodsAmmountTbox.Text) + 1).ToString();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (goodsAmmountTbox.Text != "0")
            {
                goodsAmmountTbox.Text = (int.Parse(goodsAmmountTbox.Text) - 1).ToString();
            }
        }
    }
}
