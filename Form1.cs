using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_click7_Click(object sender, EventArgs e)
        {
            //question 7
            Double x = 4;
            Double y = 12;
            Double result = x / y;

            lblQ7.Text = result.ToString();

        }

        private void Btn_ShowMonths_Click(object sender, EventArgs e)
        {
            //question 6
            String[] Season = new String[3];
            

            if (CombSeason.SelectedItem.Equals("Spring"))
            {
                Season[0] = "March";
                Season[1] = "April";
                Season[2] = "May";
                
            }
            else if (CombSeason.SelectedItem.Equals("Summer"))
            {
                Season[0] = "June";
                Season[1] = "July";
                Season[2] = "August";
            }
            else if (CombSeason.SelectedItem.Equals("Fall"))
            {
                Season[0] = "September";
                Season[1] = "October";
                Season[2] = "November";
            }
            else if (CombSeason.SelectedItem.Equals("Winter"))
            {
                Season[0] = "December";
                Season[1] = "January";
                Season[2] = "February";
            }
            for (int i = 0; i <Season.GetLength(0); i++)
            {
                CombMonths.Text=Season[i];
                
            }

        }

        private void Btn_Movies_Click(object sender, EventArgs e)
        {
            //question 5
            String[,] Movies = new String[3, 2];
            Movies[0, 0] = " How the Grich Stole Christmas ";
            Movies[0, 1] = " 1966";
            Movies[1, 0] = "Frosty the Snowman";
            Movies[1, 1] = " 1969 ";
            Movies[2, 0] = "Arthur Christmas";
            Movies[2, 1] = " 2011 "; 
            
            for (var i = 0; i <=3; i++)
            {
                LblMoviesResult.Text=(Movies[0, 0] + " ," + Movies[0, 1]) + "\n" + (Movies[1, 0] + " ," + Movies[1, 1]) +"\n" + (Movies[2, 0] + " ," + Movies[2, 1]); 
               
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //question 4
            String Password = txtPassword.Text;
            if (Password=="frosty")
            {
                LblPassword.Visible = true;
            }
            else
            {
                LblPassword.Visible = true;
                LblPassword.ForeColor= Color.Red;
                LblPassword.Text = "You Entered the Incorrect Password";
            }
        }

        private void BtnQues3_Click(object sender, EventArgs e)
        {
            //question 3
            String[] show = new String[3];
            show[0] = "Merry";
            show[1] = "Christmas";
            show[2] = "C# is Great";

            for (var i = 0; i <3; i++)
            {
                LblString.Text = show[0]+" "+show[1] + " "+show[2];
            }

            }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //question 2
            Int32 First_Number = Convert.ToInt32(TxtFirstInt.Text);
            Int32 Second_Number = Convert.ToInt32(TxtSecondInt.Text);
            //calling method here
            Int32 result = MultiplyNumbers(First_Number, Second_Number);
            LblResultAdd.Text = "Your Total is: " + result.ToString();
        }
        private Int32 MultiplyNumbers(Int32 a, Int32 b)
        {
            Int32 total = a * b;
            return total;
        }

        private void TxtFirstInt_TextChanged(object sender, EventArgs e)
        {
            Int32 validate;
            if (Int32.TryParse(TxtFirstInt.Text, out validate) == false)
            {
                LblError.Visible = true;
            }
            else
            {
                LblError.Visible = false;
            }
        }

        private void TxtSecondInt_TextChanged(object sender, EventArgs e)
        {
            Int32 validate;
            if (Int32.TryParse(TxtSecondInt.Text, out validate) == false)
            {
                LblError.Visible = true;
            }
            else
            {
                LblError.Visible = false;
            }
        }
    }
}
