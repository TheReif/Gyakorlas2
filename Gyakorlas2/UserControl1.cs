using Gyakorlas2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlas2
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            timeBindingSource.DataSource = context.Times.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szures();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Szures2();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dgv();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dgv();
        }

        void Szures()
        {
            var index = from x in context.Rooms
                        where x.Name.StartsWith(textBox1.Text)
                        select x;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = index.ToList();
        }
        void Szures2()
        {
            var lekerdezes = from x in context.Courses
                             where x.Name.StartsWith(textBox2.Text)
                             select new ListB
                             {
                                 CourseSk = x.CourseSk,
                                 Name = x.Name
                             };
            listBox2.DisplayMember = "Name";
            listBBindingSource.DataSource = lekerdezes.ToList();
        }

        void Dgv()
        {
            if (listBox2.SelectedItem == null) return;
            
            var index = ((Room)listBox1.SelectedItem).RoomSk;
            var index2 = ((ListB)listBox2.SelectedItem).CourseSk;

            var datagridview = from x in context.Lessons
                               where x.CourseFk == index2 && x.RoomFk == index
                               select new Dgw
                               {
                                   TimeFk = x.TimeFkNavigation.TimeId,
                                   CourseName = x.CourseFkNavigation.Name,
                                   RoomName = x.RoomFkNavigation.Name
                               };

            dgwBindingSource.DataSource = datagridview.ToList();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Szures();
            Szures2();
            Dgv();
        }
    }
    public class Dgw
    {
        public byte TimeFk { get; set; }
        public string CourseName { get; set; }
        public string RoomName { get; set; }
    }
    public class ListB
    {
        public string Name{ get; set; }
        public int CourseSk { get; set; }
    }


}
