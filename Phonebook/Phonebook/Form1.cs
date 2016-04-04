using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        TelephoneDirectory telephoneDirect = new TelephoneDirectory();

        public Form1()
        {
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(Types));
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
        }

        private void SaveButton(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                int age = Int32.Parse(ageTextBox.Text);
                int mobile = Int32.Parse(mobileTextBox.Text);

                telephoneDirect.accounts.Add(new Person(name, address, age, mobile, (Types)Enum.Parse(typeof(Types), typeComboBox.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Please fille the form in the correct way!!!");
            }         
        }
        private void ListButton(object sender, EventArgs e)
        {
            accountList.Items.Clear();
            foreach (var item in telephoneDirect)
            {
                accountList.Items.Add(item);
            }
        }
    }
}
