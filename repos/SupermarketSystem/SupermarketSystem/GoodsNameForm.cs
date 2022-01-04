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
    public partial class GoodsNameForm : Form
    {
        public GoodsNameForm()
        {
            InitializeComponent();

            using (var context = new supermarketContext())
            {
                List<string> groupNames = new List<string>();
                groupNames = context.GoodsGroupTbls.Select(g  => g.Name).ToList();
                foreach (var name in groupNames)
                {
                    groupCbox.Items.Add(name);
                }
                context.SaveChanges();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            GoodsNameTbl goodsNameTbl = new GoodsNameTbl
            {
                Code = int.Parse(CodeTBox.Text),
                Name = NameTbox.Text,
                
            };

            using (var context = new supermarketContext())
            {
                var prevId = context.GoodsNameTbls.OrderBy(i => i.Id).LastOrDefault()?.Id ?? 0;
                goodsNameTbl.Id = prevId + 1;
                goodsNameTbl.GoodsGroupTblId = context.GoodsGroupTbls.FirstOrDefault(i => i.Name == groupCbox.SelectedItem).Id;
                context.GoodsNameTbls.Add(goodsNameTbl);
                context.SaveChanges();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
