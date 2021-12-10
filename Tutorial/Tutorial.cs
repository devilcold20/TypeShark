using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class tuto : Form
    {
        public tuto()
        {
            InitializeComponent();

        }

        int i = 0, dai = 0, point = 0;

        private void tuto_KeyUp(object sender, KeyEventArgs e)
        {
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
            label8.BackColor = Color.White;
            label9.BackColor = Color.White;
            label10.BackColor = Color.White;
            label11.BackColor = Color.White;
            label12.BackColor = Color.White;
            label13.BackColor = Color.White;
            label14.BackColor = Color.White;
            label15.BackColor = Color.White;
            label16.BackColor = Color.White;
            label17.BackColor = Color.White;
            label18.BackColor = Color.White;
            label21.BackColor = Color.White;
            label24.BackColor = Color.White;
            label27.BackColor = Color.White;
            label19.BackColor = Color.White;
            label22.BackColor = Color.White;
            label25.BackColor = Color.White;
            label28.BackColor = Color.White;
            label20.BackColor = Color.White;
            label23.BackColor = Color.White;
            label26.BackColor = Color.White;
            label29.BackColor = Color.White;
            label30.BackColor = Color.White;
            //////////////
            label31.BackColor = Color.White;
            label34.BackColor = Color.White;
            label37.BackColor = Color.White;
            label40.BackColor = Color.White;
            label32.BackColor = Color.White;
            label35.BackColor = Color.White;
            label38.BackColor = Color.White;
            label41.BackColor = Color.White;
            label33.BackColor = Color.White;
            label36.BackColor = Color.White;
            label39.BackColor = Color.White;
            label42.BackColor = Color.White;
            //
            label44.BackColor = Color.White;
            label55.BackColor = Color.White;
            label47.BackColor = Color.White;
            label50.BackColor = Color.White;
            label53.BackColor = Color.White;
            label45.BackColor = Color.White;
            label48.BackColor = Color.White;
            label51.BackColor = Color.White;
            label54.BackColor = Color.White;
            label46.BackColor = Color.White;
            label49.BackColor = Color.White;
            label52.BackColor = Color.White;
            label57.BackColor = Color.White;
        }
        void data (int so)
        {
            if (so == 1)
            {
                labelString.Text = "The mother gave her baby a red apple. The baby tried to eat the apple. His mouth was too small. And he did not have any teeth. His brother took the apple. His brother ate the apple. The baby cried. His brother gave the baby a blue ball to play with. The baby smiled.";
            }
            if (so == 2)
            {
                labelString.Text = "January 7 is Benny birthday. He will be eight years old. He is in the third grade. He goes to Park Elementary School. An elementary school is for kids. It is only one mile away. He walks to school. It only takes 20 minutes. When it rains, he wears a raincoat. He used to take an umbrella. But he lost the umbrella. His mother gave him another umbrella.";
            }
            if (so == 3)
            {
                labelString.Text = "NEWS COVID 2019 The country has recorded 691 community acquired infections, including 551 cases detected since July 25 when the virus resurged in Da Nang city. No imported cases have been announced over the past 36 hours. As many as 755 out of 1,046 patients have been discharged from hospital after making a full recovery.";
            }
            if (so == 4)
            {
                labelString.Text = "The English alphabet consists of 26 characters, begin from AAA and BBB and CCC and DDD and EEE and FFF and JJJ and GGG and HHH and III and KKK and LLL and MMM and NNN and OOO and PPP and QQQ and RRR and SSS and TTT and UUU and VVV and WWW and YYY and ends at ZZZ ";
            }
            if (so == 5)
            {
                labelString.Text = "Ho Chi Minh City is a pretty famous spot for tourist when they come to Vietnam. Ho Chi Minh City has another name as Sai Gon.It is the biggest city in Vietnam with about 9 million citizens and people who live here usually call it by that name. People mostly know about this place as a busy and crowded city, but Sai Gon actually has another lovely side";
            }
        }
        
        public int rand()
        {
            int numb;
            Random dr = new Random();
            numb = dr.Next(1, 5);
            return numb;
        }
            
        
        private void tuto_Load(object sender, EventArgs e)
        {
            
            data(rand());
           
        }

        private void tuto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.D1)
            {
                label5.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D2)
            {
                label6.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D3)
            {
                label7.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D4)
            {
                label8.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D5)
            {
                label9.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D6)
            {
                label10.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D7)
            {
                label11.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D8)
            {
                label12.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D9)
            {
                label13.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D0)
            {
                label14.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                label15.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Oemplus)
            {
                label16.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Back)
            {
                label17.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Q)
            {
                label18.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.W)
            {
                label21.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.E)
            {
                label24.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.R)
            {
                label27.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.T)
            {
                label19.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Y)
            {
                label22.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.U)
            {
                label25.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.I)
            {
                label28.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.O)
            {
                label20.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.P)
            {
                label23.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.OemOpenBrackets)
            {
                label26.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Oem6)
            {
                label29.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Oem5)
            {
                label30.BackColor = Color.Blue;
            }
            //////////////
            if (e.KeyCode == Keys.A)
            {
                label31.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.S)
            {
                label34.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D)
            {
                label37.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.F)
            {
                label40.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.G)
            {
                label32.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.H)
            {
                label35.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.J)
            {
                label38.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.K)
            {
                label41.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.L)
            {
                label33.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Oem1)
            {
                label36.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Oem7)
            {
                label39.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Return)
            {
                label42.BackColor = Color.Blue;
            }
            //
            if (e.KeyCode == Keys.ShiftKey)
            {
                label44.BackColor = Color.Blue;
                label55.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Z)
            {
                label47.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.X)
            {
                label50.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.C)
            {
                label53.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.V)
            {
                label45.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.B)
            {
                label48.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.N)
            {
                label51.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.M)
            {
                label54.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                label46.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                label49.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.OemQuestion)
            {
                label52.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Space)
            {
                label57.BackColor = Color.Blue;
            }
        } 

       

        protected override void OnKeyDown(KeyEventArgs e)
        {
            
            string str = labelString.Text.ToUpper();   //Chuỗi cần gõ
            dai = str.Length;   //Độ dài của chuỗi theo thời gian thực

            /* 
             * Chuyển str[0] sang kiểu char -> dùng mã ascii của str[0] so sánh với hashCode của e.KeyCode
             * PHẢI kiểm tra chuỗi rỗng trước, vì khi chuỗi rỗng mà còn lấy ascii của str[0] thì sẽ bị lỗi
             */ 
            if (!String.IsNullOrEmpty(str) && (int)(str.ToCharArray()[0]) == e.KeyCode.GetHashCode() || (int)(str.ToCharArray()[0]) == 44 && e.KeyCode == Keys.Oemcomma || (int)(str.ToCharArray()[0]) == 46 && e.KeyCode == Keys.OemPeriod)
            {
                labelString.Text = labelString.Text.Remove(0, 1);
                i++;

                //Xuất ra cho dễ nhìn
                dai--;
                point++; 
                labelWarning.Text = "Gõ đúng!";
                labelWarning.ForeColor = Color.Green;
            }
            else
            {
                labelWarning.Text = "Gõ sai!";
                labelWarning.ForeColor = Color.Red;
            }

            labelPoint.Text = point.ToString();
            labelLength.Text = dai.ToString();
            labelPress.Text = e.KeyCode.ToString();


            base.OnKeyDown(e);
            if (labelLength.Text == "0")
                data(rand());
            
        }

    }
}
