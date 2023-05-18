using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotniska
{
    public partial class Form2 : Form
    {
        Form1 form1;
        List<string> list_form2 = new List<string>();
        int x;
        public Form2(Form1 form2)
        {
            this.form1 = form2;
            InitializeComponent();
            for(int i = 0; i < form1.list.Count; i++)
            {
                if(form1.list[i].name == form1.WhatInComboBox())
                {
                    x = i;
                }
            }

            ListViewItem item = new ListViewItem();

            item.Text = form1.list[x].name.ToString();

            listView1.Columns.Add(form1.send.name.ToString(), -2);
            //list_form2.Add(form1.list[x].name.ToString());

            if (form1.Checked1())
            {
                listView1.Columns.Add(form1.send.city.ToString(), -2);
                item.SubItems.Add(form1.list[x].city.ToString());
                //list_form2.Add(form1.list[x].city.ToString());
            }
            if (form1.Checked2())
            {
                listView1.Columns.Add(form1.send.district.ToString(), -2);
                item.SubItems.Add(form1.list[x].district.ToString());
                //list_form2.Add(form1.list[x].district.ToString());
            }
            if (form1.Checked3())
            {
                listView1.Columns.Add(form1.send.ICAO.ToString(), -2);
                item.SubItems.Add(form1.list[x].ICAO.ToString());
                //list_form2.Add(form1.list[x].ICAO.ToString());
            }
            if (form1.Checked4())
            {
                listView1.Columns.Add(form1.send.IATA.ToString(), -2);
                item.SubItems.Add(form1.list[x].IATA.ToString());
                //list_form2.Add(form1.list[x].IATA.ToString());
            }
            if (form1.Checked5())
            {
                listView1.Columns.Add(form1.send.number_of_passengers.ToString(), -2);
                item.SubItems.Add(form1.list[x].number_of_passengers.ToString());
                //list_form2.Add(form1.list[x].number_of_passengers.ToString());
            }
            if (form1.Checked6())
            {
                listView1.Columns.Add(form1.send.change.ToString(), -2);
                item.SubItems.Add(form1.list[x].change.ToString());
                //list_form2.Add(form1.list[x].change.ToString());
            }

            listView1.Items.Add(item);
            listView1.View = View.Details;
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
