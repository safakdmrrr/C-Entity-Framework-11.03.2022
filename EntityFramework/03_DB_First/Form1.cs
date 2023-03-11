using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_DB_First
{
    public partial class Form1 : Form
    {
        NorthwindEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.ToList();
        }

        private void btn_EmpToOrd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_empId.Text);

            //dataGridView1.DataSource = db.Orders.Where(i => i.EmployeeID == id).ToList();


            var list = db.Orders.Where(i => i.EmployeeID == id && i.OrderDate >= dateTimePicker1.Value && i.OrderDate <= dateTimePicker3.Value).ToList();

            dataGridView1.DataSource = list;

            //List<Orders> OrderList = db.Orders.Include("Employees").ToList();
            
            //foreach (var item in OrderList)
            //{
            //    listBox1.Items.Add(item.Employees.FirstName + " " + item.OrderID.ToString());
            //}
        }

        private void btn_DateOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(i => i.OrderDate >= dateTimePicker1.Value && i.OrderDate <= dateTimePicker3.Value).ToList();
        }
    }
}
