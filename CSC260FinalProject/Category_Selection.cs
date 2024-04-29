using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260FinalProject
{
    
    public partial class Category_Selection : Form
    {
        private int op1, op2,op3,op4,op5,op6,op7,op8,op9,op10,op11,op12,op13,op14,op15,op16;
        public Category_Selection()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            JepordyInterface form = new JepordyInterface();
            form.Show();
            this.Hide();
        }

        private void category1_btn_Click(object sender, EventArgs e)
        {
            Control ct1 = ((Control)sender);
            if (op1 == 1) { ct1.BackColor = Color.Green; }
            if (op1 == 0) { ct1.BackColor = Color.Red; }

            switch (ct1.BackColor.Name)
            {
                case "Green":
                    ct1.BackColor = Color.Red;
                    op1 = 0;
                    break;
                case "Red":
                    ct1.BackColor = Color.Green;
                    op1 = 1;
                    break;
            }
        }

        private void category2_btn_Click(object sender, EventArgs e)
        {
            Control ct2 = ((Control)sender);
            if (op2 == 1) { ct2.BackColor = Color.Green; }
            if (op2 == 0) { ct2.BackColor = Color.Red; }

            switch (ct2.BackColor.Name)
            {
                case "Green":
                    ct2.BackColor = Color.Red;
                    op2 = 0;
                    break;
                case "Red":
                    ct2.BackColor = Color.Green;
                    op2 = 1;
                    break;
            }
        }

        private void category3_btn_Click(object sender, EventArgs e)
        {
            Control ct3 = ((Control)sender);
            if (op3 == 1) { ct3.BackColor = Color.Green; }
            if (op3 == 0) { ct3.BackColor = Color.Red; }

            switch (ct3.BackColor.Name)
            {
                case "Green":
                    ct3.BackColor = Color.Red;
                    op3 = 0;
                    
                    break;
                case "Red":
                    ct3.BackColor = Color.Green;
                    op3 = 1;
                    
                    break;
            }
        }

        private void category4_btn_Click(object sender, EventArgs e)
        {
            Control ct4 = ((Control)sender);
            if (op4 == 1) { ct4.BackColor = Color.Green; }
            if (op4 == 0) { ct4.BackColor = Color.Red; }

            switch (ct4.BackColor.Name)
            {
                case "Green":
                    ct4.BackColor = Color.Red;
                    op4 = 0;
                    
                    break;
                case "Red":
                    ct4.BackColor = Color.Green;
                    op4 = 1;
                    
                    break;
            }
        }

        private void category5_btn_Click(object sender, EventArgs e)
        {
            Control ct5 = ((Control)sender);
            if (op5 == 1) { ct5.BackColor = Color.Green; }
            if (op5 == 0) { ct5.BackColor = Color.Red; }

            switch (ct5.BackColor.Name)
            {
                case "Green":
                    ct5.BackColor = Color.Red;
                    op5 = 0;
                    
                    break;
                case "Red":
                    ct5.BackColor = Color.Green;
                    op5 = 1;
                    
                    break;
            }
        }

        private void category6_btn_Click(object sender, EventArgs e)
        {
            Control ct6 = ((Control)sender);
            if (op6 == 1) { ct6.BackColor = Color.Green; }
            if (op6 == 0) { ct6.BackColor = Color.Red; }

            switch (ct6.BackColor.Name)
            {
                case "Green":
                    ct6.BackColor = Color.Red;
                    op6 = 0;
                    
                    break;
                case "Red":
                    ct6.BackColor = Color.Green;
                    op6 = 1;
                    
                    break;
            }
        }

        private void category7_btn_Click(object sender, EventArgs e)
        {
            Control ct7 = ((Control)sender);
            if (op7 == 1) { ct7.BackColor = Color.Green; }
            if (op7 == 0) { ct7.BackColor = Color.Red; }

            switch (ct7.BackColor.Name)
            {
                case "Green":
                    ct7.BackColor = Color.Red;
                    op7 = 0;     
                    break;
                case "Red":
                    ct7.BackColor = Color.Green;
                    op7 = 1;
                    break;
            }
        }

        private void category8_btn_Click(object sender, EventArgs e)
        {
            Control ct8 = ((Control)sender);
            if (op8 == 1) { ct8.BackColor = Color.Green; }
            if (op8 == 0) { ct8.BackColor = Color.Red; }

            switch (ct8.BackColor.Name)
            {
                case "Green":
                    ct8.BackColor = Color.Red;
                    op8 = 0;
                    break;
                case "Red":
                    ct8.BackColor = Color.Green;
                    op8 = 1;   
                    break;
            }
        }

        private void category9_btn_Click(object sender, EventArgs e)
        {
            Control ct9 = ((Control)sender);
            if (op9 == 1) { ct9.BackColor = Color.Green; }
            if (op9 == 0) { ct9.BackColor = Color.Red; }

            switch (ct9.BackColor.Name)
            {
                case "Green":
                    ct9.BackColor = Color.Red;
                    op9 = 0;                  
                    break;
                case "Red":
                    ct9.BackColor = Color.Green;
                    op9 = 1;                   
                    break;
            }
        }

        private void category10_btn_Click(object sender, EventArgs e)
        {
            Control ct10 = ((Control)sender);
            if (op10 == 1) { ct10.BackColor = Color.Green; }
            if (op10 == 0) { ct10.BackColor = Color.Red; }

            switch (ct10.BackColor.Name)
            {
                case "Green":
                    ct10.BackColor = Color.Red;
                    op10 = 0;                   
                    break;
                case "Red":
                    ct10.BackColor = Color.Green;
                    op10 = 1;                   
                    break;
            }
        }

        private void category11_btn_Click(object sender, EventArgs e)
        {
            Control ct11 = ((Control)sender);
            if (op11 == 1) { ct11.BackColor = Color.Green; }
            if (op11 == 0) { ct11.BackColor = Color.Red; }

            switch (ct11.BackColor.Name)
            {
                case "Green":
                    ct11.BackColor = Color.Red;
                    op11 = 0;                   
                    break;
                case "Red":
                    ct11.BackColor = Color.Green;
                    op11 = 1;                    
                    break;
            }
        }

        private void category12_btn_Click(object sender, EventArgs e)
        {
            Control ct12 = ((Control)sender);
            if (op12 == 1) { ct12.BackColor = Color.Green; }
            if (op12 == 0) { ct12.BackColor = Color.Red; }

            switch (ct12.BackColor.Name)
            {
                case "Green":
                    ct12.BackColor = Color.Red;
                    op12 = 0;      
                    break;
                case "Red":
                    ct12.BackColor = Color.Green;
                    op12 = 1;                   
                    break;
            }
        }

        private void category13_btn_Click(object sender, EventArgs e)
        {
            Control ct13 = ((Control)sender);
            if (op13 == 1) { ct13.BackColor = Color.Green; }
            if (op13 == 0) { ct13.BackColor = Color.Red; }

            switch (ct13.BackColor.Name)
            {
                case "Green":
                    ct13.BackColor = Color.Red;
                    op13 = 0;                
                    break;
                case "Red":
                    ct13.BackColor = Color.Green;
                    op13 = 1;                 
                    break;
            }
        }

        private void category14_btn_Click(object sender, EventArgs e)
        {
            Control ct14 = ((Control)sender);
            if (op14 == 1) { ct14.BackColor = Color.Green; }
            if (op14 == 0) { ct14.BackColor = Color.Red; }

            switch (ct14.BackColor.Name)
            {
                case "Green":
                    ct14.BackColor = Color.Red;
                    op14 = 0;                  
                    break;
                case "Red":
                    ct14.BackColor = Color.Green;
                    op14 = 1;                   
                    break;
            }
        }

        private void category15_btn_Click(object sender, EventArgs e)
        {
            Control ct15 = ((Control)sender);
            if (op15 == 1) { ct15.BackColor = Color.Green; }
            if (op15 == 0) { ct15.BackColor = Color.Red; }

            switch (ct15.BackColor.Name)
            {
                case "Green":
                    ct15.BackColor = Color.Red;
                    op15 = 0;                
                    break;
                case "Red":
                    ct15.BackColor = Color.Green;
                    op15 = 1;                   
                    break;
            }
        }

        void category16_btn_Click(object sender, EventArgs e)
        {
            Control ct16 = ((Control)sender);
            if (op16 == 1) { ct16.BackColor = Color.Green; }
            if (op16 == 0) { ct16.BackColor = Color.Red; }

            switch (ct16.BackColor.Name)
            {
                case "Green":
                    ct16.BackColor = Color.Red;
                    op16 = 0;
                    break;
                case "Red":
                    ct16.BackColor = Color.Green;
                    op16 = 1;        
                    break;
            }
        }
    }
}
