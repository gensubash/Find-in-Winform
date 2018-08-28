using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        Empl em = new Empl();
        List<Empl> Employees;
        public Form1()
        {
            InitializeComponent();
            em.AddEmployees();
            Employees = em.AddEmployees();
            dataGridView1.DataSource = Employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            List<Empl> records = Employees;
            if (!string.IsNullOrEmpty(searchText))
            {
                records = Employees.Where(x => string.Equals(x.FirstName, searchText, StringComparison.OrdinalIgnoreCase)).ToList();
                //records = (from emp in Employees
                //           where string.Equals(emp.FirstName, searchText, StringComparison.OrdinalIgnoreCase)
                //           select emp
                //          ).ToList();
                //Ienumerable, iqueriable, icollection, ilist, list, array(int, string,..., class, structure), datatable

                //DataTable dt = new DataTable();
                //dt.Columns.Add("FirstName");
                //dt.Columns.Add("LastName");

                //var a = dt.AsEnumerable().Where(x => x.Field<string>("FirstName") == "subash").ToList();

                //var b = (from DataRow row in dt.Rows
                //         where row("FirstName") == "subash").ToList();
            }

            dataGridView1.DataSource = records;
        }
    }

    public class Empl
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public List<Empl> AddEmployees()
        {
            List<Empl> Employes = new List<Empl>();
            Empl e = new Empl();
            e.FirstName = "Subash";
            e.LastName = "Shrestha";
            Employes.Add(e);

            e = new Empl();
            e.FirstName = "Kumar";
            e.LastName = "Chapagain";
            Employes.Add(e);


            e = new Empl();
            e.FirstName = "Arjun";
            e.LastName = "Shrestha";
            Employes.Add(e);


            e = new Empl();
            e.FirstName = "Gangnam";
            e.LastName = "Shrestha";
            Employes.Add(e);
            e = new Empl();
            e.FirstName = "jumnar";
            e.LastName = "Ckkaki";
            Employes.Add(e);

            return Employes;
        }
    }
}
