
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        oleDbDataAdapter1.Fill(dataSet11, "kisib");
        

        
        
        }
     
        private void button1_Click(object sender, EventArgs e)
        {          
            
            this.BindingContext[dataSet11, "kisib"].AddNew();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Compare(textBox5.Text, "evet", true) == 0)
                {
                    this.BindingContext[dataSet11, "kisib"].EndCurrentEdit(); 
                    oleDbDataAdapter1.Update(dataSet11); 
                    
                    MessageBox.Show("İstenen Özelliklere Uyuyorsunuz");
                }
                else
                {
                    MessageBox.Show("Askerlik yapmadığınızdan iş başvurunuz değerlendirilmeye alınmayacak");
                    
                }
            }
            catch
            {
                ;
            }



        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                this.BindingContext[dataSet11, "kisib"].EndCurrentEdit(); 
                oleDbDataAdapter1.Update(dataSet11); 

            }
            catch
            {
                ;
                 
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[dataSet11, "kisib"].EndCurrentEdit(); 
                this.BindingContext[dataSet11, "kisib"].RemoveAt(this.BindingContext[dataSet11, "kisib"].Position); 
                oleDbDataAdapter1.Update(dataSet11); 

            }
            catch
            {
                ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "kisib"].Position = 0;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "kisib"].Position -= 1;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "kisib"].Position += 1;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "kisib"].Position = this.BindingContext[dataSet11, "kisib"].Count;
            
        }
    }
}
