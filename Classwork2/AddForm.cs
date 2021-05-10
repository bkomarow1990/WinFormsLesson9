using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classwork2
{
    public partial class AddForm : Form
    {
        Form1 form;
        public AddForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTb.Text;
            decimal price = priceNUP.Value;//priceTb;
            decimal count = countNUP.Value;
            ListViewItem li = new ListViewItem(name);
            li.SubItems.AddRange(new string[] { price.ToString(), count.ToString()});
            li.ImageIndex = 0;
            li.Group = form.listView1.Groups[groupComboBox.SelectedIndex];
            form.listView1.Items.Add(li);
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            Category[] categs = (Category[])Enum.GetValues(typeof(Category));
            groupComboBox.DataSource = categs;
            form.listView1.Groups.Add(new ListViewGroup("Confectioners"));

        }
    }
}
