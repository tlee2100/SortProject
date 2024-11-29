﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualiser_v1
{
    public partial class fManually : Form
    {
        public fManually()
        {
            InitializeComponent();
        }

        public List<int> DayInput;
        public bool isNhap;

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // xoa day cũ nếu đã tạo ở phiên trước
            DayInput.Clear();
            foreach (string item in tbxdayso.Text.Split(' '))
            {
                if (item == " ")
                {
                }
                else
                {
                    int temp = 10;
                    bool result = int.TryParse(item, out temp);
                    if (result == true && (temp < 0 || temp > 99))
                    {
                        MessageBox.Show("Phần tử có giá trị nhỏ hơn 0 hoặc lớn hơn 99");
                        return;
                    }
                    if (result == true)
                    {
                        DayInput.Add(temp);
                    }
                }

            }

            if (DayInput.Count > ThamSo.SoluongNodeLonNhat)
            {
                MessageBox.Show("Dãy vừa nhập vượt quá " + ThamSo.SoluongNodeLonNhat);
                return;
            }
            if (DayInput == null)
            {
                MessageBox.Show("Dãy nhập rỗng");
                return;
            }
            isNhap = true;
            this.Close();
        }

        private void fManually_Load(object sender, EventArgs e)
        {
            DayInput = new List<int>();
            isNhap = false;
        }

        private void tbxdayso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxdayso_KeyPress(object sender, KeyPressEventArgs e)
        {


            // chặn người dùng nhập chữ nhưng cho phép nhập backspace để xóa
            if (e.KeyChar != '\b' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
            //if (char.IsWhiteSpace(e.KeyChar))
            //{

            //    if (countspace > 1)
            //    {
            //        e.Handled = true;
            //        countspace = 0;
            //    }
            //    countspace++;
            //}


        }
    }
}
