using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classwork2
{
    public partial class EditForm : Form
    {
        Form1 form;
        public EditForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (form.listView1.SelectedItems.Count == 0)
            {
                return;
            }
            Category[] categs = (Category[])Enum.GetValues(typeof(Category));
            groupComboBox.DataSource = categs;
            form.listView1.Groups.Add(new ListViewGroup("Confectioners"));
            this.nameTb.Text = form.listView1.SelectedItems[0].Text;
            this.priceNUP.Text = form.listView1.SelectedItems[0].SubItems[0].Text;
            this.countNUP.Text = form.listView1.SelectedItems[0].SubItems[1].Text;
            this.groupComboBox.SelectedItem = form.listView1.SelectedItems[0].Group;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            form.listView1.SelectedItems[0].Text = nameTb.Text;
            //form.listView1.SelectedItems[0].SubItems[0] = new ListViewSubItem(priceNUP.Value.ToString());
        }
    }
}
