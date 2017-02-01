using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ArmenianTranslitTranslator
{
    public partial class Form1 : Form
    {

    Stream myStream = null;
    OpenFileDialog openFileDialog1 = new OpenFileDialog();

    public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    private void Select_Click(object sender, EventArgs e)
    {
 

      openFileDialog1.InitialDirectory = "c:\\";
      openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      openFileDialog1.RestoreDirectory = true;
      openFileDialog1.FilterIndex = 1;


      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if (openFileDialog1.OpenFile() != null)
          {
            if (openFileDialog1.SafeFileName.Contains(".txt"))
            {
              myStream = openFileDialog1.OpenFile();
              textBox1.Text = "True file format (.txt)";             
            }
            else
            {
              textBox1.Text = "Wrong file format (file must has .txt extension), check it!";
            }

            
          }
        }
        catch (Exception ex)
        {
          textBox1.Text = "This is a TextBox Error.";
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
    }

    private void label3_Click_1(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

      if (myStream  != null)
      {

        var sr = new StreamReader(myStream);

        string text = sr.ReadToEnd();

        textBox2.Text = text;



      }

      else 
      {
        textBox2.Text = "You dont select the file";
      }

     }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
