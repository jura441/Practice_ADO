using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_ADO.NET
{
    public partial class EditGoods : Form
    {
        int _id;
        string _name;
        int _category_id;
        int _price;
        int _count;
        public EditGoods(int id, string _name, int category_id, int price, int count)
        {
            InitializeComponent();
            _id = id;
            _name = _name;
            _category_id = category_id;
            _price = price;
            _count = count;
        }

        private void EditGoods_Load(object sender, EventArgs e)
        {
            tb_id.Text = _id.ToString();
            tb_name.Text = _name.ToString();
            tb_cat_id.Text = _category_id.ToString();
            tb_price.Text = _price.ToString();
            tb_count.Text = _count.ToString();
        }
    }
}
