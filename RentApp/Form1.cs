using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string customerName = customerNameBox.Text;
            string dateRented = datePickerRNT.Value.ToString();
            string dateReturbed = datePickerRTN.Value.ToString();

            double cost = Convert.ToDouble(tbcost.Text);

            var carType = sltcarBox.SelectedItem.ToString();

            
            MessageBox.Show($"Customer Name: {customerName}\n\r" +
                $"Date of Renting{dateRented}\n\r" + $"Date of returning{dateReturbed}\n\r" + $"You choosed {carType}\n\r"

                + $"Thanks For selecting our services");
        }

       
    }
}
