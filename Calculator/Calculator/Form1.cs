using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string value1 = "0", value2 = "0";
        public int flag = 0;
        public int eval = 0;
       
        public Form1()
        {
            InitializeComponent();
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(button1);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(button8);





        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(button5);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(button7);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_Click(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_Click(button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_Click(button14);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_Click(button12);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click(button11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click(button10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(button2);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(button3);
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(button9);


        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_Click(button13);


        }
        private void button21_Click(object sender, EventArgs e)
        {
            button_Click(button21);


        }
        private void button_Click(Button btn)
        {
            if (richTextBox1.Text == "0") richTextBox1.Text = ""; 
            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/" )
            {
                flag = 0;
                if (richTextBox2.Text != "" && richTextBox2.Text != "")
                {
                    if (richTextBox2.Text[0] == '+' || richTextBox2.Text[0] == '-' ||  richTextBox2.Text[0] == '*' || richTextBox2.Text[0] == '/')
                    {
                        
                        calculate(btn,value1,value2);
                       
                    }
                    else if (richTextBox2.Text[0] == '=')
                    {
                      value2 = richTextBox1.Text;
                      richTextBox2.Text = btn.Text + richTextBox1.Text;
                    }
                }
                else
                {
                    value2 = richTextBox1.Text;
                    richTextBox2.Text = btn.Text + richTextBox1.Text;
                    
                }

            }
            else if(btn.Text == "=")
            {
                calculate(btn, value1, value2);
                flag = 0;

            }
            else 
             {
                eval = 0;
                if (richTextBox2.Text != "")
                {
                    if (richTextBox2.Text[0] == '+' || richTextBox2.Text[0] == '-' || richTextBox2.Text[0] == '*' || richTextBox2.Text[0] == '/')
                    {
                        //  calculate(btn);
                        if (flag == 0)
                        {
                            richTextBox1.Text = btn.Text; flag = 1;
                            
                        }
                        else richTextBox1.Text += btn.Text;

                    }
                    else
                    {
                        if (flag == 0)
                        {
                            richTextBox1.Text = btn.Text; flag = 1;

                        }else
                        richTextBox1.Text += btn.Text;
                    }
                }
                else
                {
                   
                    richTextBox1.Text += btn.Text;
                }
               
               

            }
            
           
        }
        public void calculate(Button btn,string str1,string str)
        {
            //  if (btn.Text != "=") eval = 1;
            if (eval == 0)
            {
                if (btn.Text != "=") eval = 1;
                string str2 = richTextBox1.Text;
                Char c = richTextBox2.Text[0];
                if (c == '+')
                {
                    var r = Convert.ToDouble(str) + Convert.ToDouble(str2);
                
                    if (r < 0)
                    {
                        var r2 = Math.Abs(r);
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "+" + str2;
                            richTextBox1.Text = r2.ToString() + "-";
                        }
                        else
                        {
                            string s = btn.Text + r2.ToString() + "-";
                            richTextBox2.Text = s;
                        }


                    }
                    else
                    {
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "+" + str2;
                            richTextBox1.Text = r.ToString();
                        }
                        else
                        {
                            string s = btn.Text + r.ToString();
                            richTextBox2.Text = s;
                        }
                    }

                    value2 = r.ToString();
                }
                else if (c == '-')
                {
                    var r = Convert.ToDouble(str) - Convert.ToDouble(str2); ;

                    if (r < 0)
                    {
                        var r2 = Math.Abs(r);
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "-" + str2;
                            richTextBox1.Text = r2.ToString() + "-";
                        }
                        else
                        {
                            string s = btn.Text + r2.ToString() + "-";
                            richTextBox2.Text = s;
                        }


                    }
                    else
                    {
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "-" + str2;
                            richTextBox1.Text = r.ToString();
                        }
                        else
                        {
                            string s = btn.Text + r.ToString();
                            richTextBox2.Text = s;
                        }
                    }


                    value2 = r.ToString();
                }
                else if (c == '/')
                {
                    var r = Convert.ToDouble(str) / Convert.ToDouble(str2);
                    
                    if (r < 0)
                    {
                        var r2 = Math.Abs(r);
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "/" + str2;
                            richTextBox1.Text = r2.ToString() + "-";
                        }
                        else
                        {
                            string s = btn.Text + r2.ToString() + "-";
                            richTextBox2.Text = s;
                        }


                    }
                    else
                    {
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "-" + str2;
                            richTextBox1.Text = r.ToString();
                        }
                        else
                        {
                            string s = btn.Text + r.ToString();
                            richTextBox2.Text = s;
                        }
                    }





                    value2 = r.ToString();
                }
                else if (c == '*')
                {
                    var r = Convert.ToDouble(str) * Convert.ToDouble(str2);

                    if (r < 0)
                    {
                        var r2 = Math.Abs(r);
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "*" + str2;
                            richTextBox1.Text = r2.ToString() + "-";
                        }
                        else
                        {
                            string s = btn.Text + r2.ToString() + "-";
                            richTextBox2.Text = s;
                        }


                    }
                    else
                    {
                        if (btn.Text == "=")
                        {
                            richTextBox2.Text = "=" + str + "*" + str2;
                            richTextBox1.Text = r.ToString();
                        }
                        else
                        {
                            string s = btn.Text + r.ToString();
                            richTextBox2.Text = s;
                        }
                    }

                    value2 = r.ToString();
                }
            }
            else {
               
                var v = Convert.ToDouble(value2);
                if(v>0)
                richTextBox2.Text = btn.Text + value2 ;
                else
                {
                    v = Math.Abs(v);
                    richTextBox2.Text = btn.Text+ v +"-" ;
                }
              
            } 



        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            richTextBox2.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "0";
            richTextBox2.Text = "";
        }

    

       

        public string reverseStr(string s)
        {
            string sr="";
            for (int i=s.Length-1 ; i>=0 ; i--)
            {
               sr+=s[i];
                
            }
            return sr;
        }
    }
}
