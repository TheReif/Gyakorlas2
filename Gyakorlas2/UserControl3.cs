using Gyakorlas2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlas2
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            lessonBindingSource.DataSource = context.Lessons.ToList();
        }

        void Szures()
        {
            var lekerdezes = from x in context.Lessons
                             select x;
            listBox1.DisplayMember = "LessonSk";
            listBox1.DataSource = lekerdezes.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var megkattintott = ((Lesson)listBox1.SelectedItem).LessonSk;
            var lekerd = from x in context.Lessons
                         where x.LessonSk == megkattintott
                         select x;


            context.Lessons.Remove(lekerd.FirstOrDefault());
            try
            {
                context.SaveChanges();
                lessonBindingSource.DataSource = context.Lessons.ToList();
                Szures();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            Szures();
        }
    }
}
