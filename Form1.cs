using System;
using System.Data;

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title",typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["messages"].Visible = false;
            dataGridView1.Columns["title"].Width = 195;
        }

        private void newBttn_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text, textMessage.Text);
            textTitle.Clear();
            textMessage.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index > -1)
            {
                textTitle.Text = table.Rows[index].ItemArray[0].ToString();
                textMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            
            if(index > -1)
            {
                   dataGridView1.Rows.RemoveAt(index);
            }
        }
    }
}