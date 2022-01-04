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
    public partial class GoodsGroupForm : Form
    {
        public GoodsGroupForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
             GoodsGroupTbl goodsGroupTbl = new GoodsGroupTbl
            {
                Code = int.Parse(CodeTBox.Text),
                Name = NameTbox.Text
            };

            using (var context = new supermarketContext())
            {
                var prevId = context.GoodsGroupTbls.OrderBy(i => i.Id).LastOrDefault()?.Id ?? 0;
                goodsGroupTbl.Id = prevId + 1;
                context.GoodsGroupTbls.Add(goodsGroupTbl);
                context.SaveChanges();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
