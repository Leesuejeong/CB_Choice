using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        //C#은 기본 접근제어자가 private
        string[] SList = new string[]
        {
            "돈까스김밥", "스팸김치볶음밥", "라볶이", "쫄면", "참치주먹밥", "치즈라면"
        };
        string OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(this.SList[i]);
            }
            this.OrgStr = this.lblResult.Text;
            if (this.SList.Length > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
            
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.cbList.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Checkinput();
        }

        private void btnAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Checkinput();
            }
        }

        private bool Checkinput()
        {

            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
                return false;
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.cbList.SelectedIndex = this.cbList.Items.Count - 1;
                this.txtList.Focus();
                return true;
            }
        }

        
    }
}
