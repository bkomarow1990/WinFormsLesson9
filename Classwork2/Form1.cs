using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork2
{
    public partial class Form1 : Form
    {
        bool sortType = false;
        public Form1()
        {
            InitializeComponent();
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
            contextMenuStrip1.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(this);
            ef.Show();
        }
    }
}
