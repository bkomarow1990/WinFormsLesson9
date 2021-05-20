using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Classwork2
{
    public partial class Form1 : Form
    {
        bool sortType = false;
        string dbPath = "db.json";
        List<Product> products;
       
        public Form1()
        {
            InitializeComponent();
            Export();

        }
        private void Import()
        {
            products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(dbPath));
        }
        public void Export()
        {
            products = new List<Product>();
            int i = 0;
            string[] urls = new string[5];
            foreach (var item  in this.listView1.Items)
            {
                var item2 = item as ListViewItem;
                Category type;
                Enum.TryParse(item2.Group.Name, true, out type);
                int index = 0;
                if (item2.ImageIndex != -1)
                {
                    index = item2.ImageIndex;
                }
                products.Add(new Product(item2.Text, Decimal.Parse(item2.SubItems[1].Text), UInt32.Parse(item2.SubItems[2].Text), type, listView1.LargeImageList.Images[index]);
                ++ i;
            }
            File.WriteAllText(dbPath, JsonConvert.SerializeObject(products));
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(this);
            af.Show();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (!sortType)
            {
                listView1.ListViewItemSorter = new CmpProdListView(e.Column, SortOrder.Ascending);
                sortType = true;
            }
            else
            {
                listView1.ListViewItemSorter = new CmpProdListView(e.Column, SortOrder.Descending);
                sortType = false;
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView1.SelectedItems == null)
            {
                return;
            }
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Show();
            //listView1.View = View.Details;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(this);
            ef.Show();
        }
        private void MozaicClicked(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }
        
        private void TableClicked(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
    }
}
