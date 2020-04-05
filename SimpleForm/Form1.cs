using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleForm.Model;

namespace SimpleForm
{
    public partial class Form1 : Form
    {
        List<Person> personList;
        public Form1()
        {
            InitializeComponent();
            personList = new List<Person>();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Person savePerson = new Person();
            savePerson.Title = tbTitle.Text;
            savePerson.Forename = tbForename.Text;
            savePerson.Surname = tbSurname.Text;

            //MessageBox.Show(savePerson.ToString());

            personList.Add(savePerson);

            ClearData();
            Populate();
        }

        private void ClearData()
        {
            tbTitle.Text = "";
            tbForename.Text = "";
            tbSurname.Text = "";
        }

        private void Populate()
        {
            lvPeople.Items.Clear();
            foreach (Person pep in personList)
            {
                ListViewItem item = new ListViewItem(pep.Title);
                item.SubItems.Add(pep.Forename);
                item.SubItems.Add(pep.Surname);

                lvPeople.Items.Add(item);
            }
        }
    }
}
