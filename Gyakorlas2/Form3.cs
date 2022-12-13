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
using Day = Gyakorlas2.Models.Day;

namespace Gyakorlas2
{
    public partial class Form3 : Form
    {
        StudiesContext context = new StudiesContext();
        public Form3()
        {
            InitializeComponent();
            lessonBindingSource.DataSource = context.Lessons.ToList();
        }


        void Szures()
        {
            var lekerdezes = from x in context.Instructors
                             select x;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = lekerdezes.ToList();
        }
        void Szures1()
        {
            var lekerdezes = from x in context.Courses
                             select x;
            listBox2.DisplayMember = "Name";
            listBox2.DataSource = lekerdezes.ToList();
        }
        void Szures2()
        {
            var lekerdezes = from x in context.Times
                             select x;
            listBox3.DisplayMember = "Name";
            listBox3.DataSource = lekerdezes.ToList();
        }
        void Szures3()
        {
            var lekerdezes = from x in context.Rooms
                             select x;
            listBox4.DisplayMember = "Name";
            listBox4.DataSource = lekerdezes.ToList();
        }
        void Szures4()
        {
            var lekerdezes = from x in context.Days
                             select x;
            listBox5.DisplayMember = "Name";
            listBox5.DataSource = lekerdezes.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var item = ((Instructor)listBox1.SelectedItem).InstructorSk;
            var item2 = ((Course)listBox2.SelectedItem).CourseSk;

            var item3 = ((Time)listBox3.SelectedItem).TimeId;
            var item4 = ((Room)listBox4.SelectedItem).RoomSk;
            var item5 = ((Day)listBox5.SelectedItem).DayId;

            Lesson l = new Lesson();
            l.InstructorFk = item;
            l.CourseFk = item2;
            l.TimeFk = item3;
            l.RoomFk = item4;
            l.DayFk = item5;

            context.Lessons.Add(l);
            try
            {
                context.SaveChanges();
                lessonBindingSource.DataSource = context.Lessons.ToList();
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Szures();
            Szures1();
            Szures2();
            Szures3();
            Szures4();
        }
    }
}
