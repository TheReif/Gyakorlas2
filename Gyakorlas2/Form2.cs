using Gyakorlas2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlas2
{
    public partial class Form2 : Form
    {
        StudiesContext context = new StudiesContext();
        public Form2()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructors.ToList();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(textBox1, string.Empty);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Érvénytelen");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, string.Empty);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("Dr\\.");
            if (!r.IsMatch(textBox2.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Érvénytelen");
            }
        }

        void Szures()
        {
            var lekerdezes = from x in context.Employements
                             where x.Name.Contains(textBox1.Text)
                             select x;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = lekerdezes.ToList();
        }

        void Szures2()
        {
            var lekerdezes = from x in context.Statuses
                             where x.Name.Contains(textBox2.Text)
                             select x;
            listBox2.DisplayMember = "Name";
            listBox2.DataSource = lekerdezes.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Szures();
            Szures2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

            
            var item = ((Status)listBox2.SelectedItem).StatusId;
            var item2 = ((Employement)listBox1.SelectedItem).EmployementId;

            Instructor i = new Instructor();
            i.Name = textBox1.Text;
            i.Salutation = textBox2.Text;
            i.StatusFk = item;
            i.EmployementFk = item2;

            context.Instructors.Add(i);
            try
            {
                context.SaveChanges();
                instructorBindingSource.DataSource = context.Instructors.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
