using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Classwork2
{
    class CmpProdListView : IComparer
    {
        int column;
        SortOrder sortOrder;
        public CmpProdListView(int column = 0, SortOrder sortOrder = SortOrder.Ascending)
        {
            this.column = column;
            this.sortOrder = sortOrder;
        }
        public int Compare(object x, object y)
        {
            ListViewItem li1= x as ListViewItem;
            ListViewItem li2= y as ListViewItem;
            int result = 1;
           
            if (column == 0)
            {
                string prod1 = li1.Text;
                string prod2 = li2.Text;
                if (this.sortOrder == SortOrder.Ascending)
                {
                    result = prod1.CompareTo(prod2);
                }
                else
                {
                    result = -prod1.CompareTo(prod2);
                }
                
            }
            else
            {
                decimal value1 = Decimal.Parse(li1.SubItems[column].Text);
                decimal value2 = Decimal.Parse(li2.SubItems[column].Text);
                if (this.sortOrder == SortOrder.Ascending)
                {
                    result = value1.CompareTo(value2);
                }
                else
                {
                    result = -value1.CompareTo(value2);
                }
                
            }
            return result;
        }
    }
}
