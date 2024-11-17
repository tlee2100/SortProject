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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        //Event nhấn nút của các hàm sắp xếp ở hàng trên
        private void lblBUB_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblBUB.Text = "BUBLE SORT";
            lblBUB.ForeColor = SystemColors.HighlightText;
            lblBUB.Font = new Font(lblBUB.Font, FontStyle.Bold);
        }

        private void lblINT_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblINT.Text = "INTERCHANGE SORT";
            lblINT.ForeColor = SystemColors.HighlightText;
            lblINT.Font = new Font(lblINT.Font, FontStyle.Bold);
        }

        private void lblBIN_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblBIN.Text = "BINARY INSERTION SORT";
            lblBIN.ForeColor = SystemColors.HighlightText;
            lblBIN.Font = new Font(lblBIN.Font, FontStyle.Bold);
        }

        private void lblINS_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblINS.Text = "INSERTION SORT";
            lblINS.ForeColor = SystemColors.HighlightText;
            lblINS.Font = new Font(lblINS.Font, FontStyle.Bold);
        }

        private void lblSEL_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblSEL.Text = "SELECTION SORT";
            lblSEL.ForeColor = SystemColors.HighlightText;
            lblSEL.Font = new Font(lblSEL.Font, FontStyle.Bold);
        }

        private void lblHEA_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblHEA.Text = "HEAP SORT";
            lblHEA.ForeColor = SystemColors.HighlightText;
            lblHEA.Font = new Font(lblHEA.Font, FontStyle.Bold);
        }

        private void lblMER_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblMER.Text = "MERGE SORT";
            lblMER.ForeColor = SystemColors.HighlightText;
            lblMER.Font = new Font(lblMER.Font, FontStyle.Bold);
        }

        private void lblQUI_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblQUI.Text = "QUICK SORT";
            lblQUI.ForeColor = SystemColors.HighlightText;
            lblQUI.Font = new Font(lblQUI.Font, FontStyle.Bold);
        }

        /// Chỉnh các label button về mặc định 
        void lblButtonDefault()
        {
            //Các label button chuyển về text mặc định
            lblBUB.Text = "BUB";
            lblINT.Text = "INT";
            lblBIN.Text = "BIN";
            lblINS.Text = "INS";
            lblSEL.Text = "SEL";
            lblHEA.Text = "HEA";
            lblMER.Text = "MER";
            lblQUI.Text = "QUI";
            
            //Nền đen
            lblBUB.BackColor = SystemColors.ActiveCaptionText;
            lblINT.BackColor = SystemColors.ActiveCaptionText;
            lblBIN.BackColor = SystemColors.ActiveCaptionText;
            lblINS.BackColor = SystemColors.ActiveCaptionText;
            lblSEL.BackColor = SystemColors.ActiveCaptionText;
            lblHEA.BackColor = SystemColors.ActiveCaptionText;
            lblMER.BackColor = SystemColors.ActiveCaptionText;
            lblQUI.BackColor = SystemColors.ActiveCaptionText;
            
            //Chữ xám
            lblBUB.ForeColor = SystemColors.ActiveBorder;
            lblINT.ForeColor = SystemColors.ActiveBorder;
            lblBIN.ForeColor = SystemColors.ActiveBorder;
            lblINS.ForeColor = SystemColors.ActiveBorder;
            lblSEL.ForeColor = SystemColors.ActiveBorder;
            lblHEA.ForeColor = SystemColors.ActiveBorder;
            lblMER.ForeColor = SystemColors.ActiveBorder;
            lblQUI.ForeColor = SystemColors.ActiveBorder;
            
            //Kiểu chữ thông thường
            lblBUB.Font = new Font(lblBUB.Font, FontStyle.Regular);
            lblINT.Font = new Font(lblINT.Font, FontStyle.Regular);
            lblBIN.Font = new Font(lblBIN.Font, FontStyle.Regular);
            lblINS.Font = new Font(lblINS.Font, FontStyle.Regular);
            lblSEL.Font = new Font(lblSEL.Font, FontStyle.Regular);
            lblHEA.Font = new Font(lblHEA.Font, FontStyle.Regular);
            lblMER.Font = new Font(lblMER.Font, FontStyle.Regular);
            lblQUI.Font = new Font(lblQUI.Font, FontStyle.Regular);

            //Vị trí panel mặc định
            pnlINT.Location = new Point(49, 0);
            pnlINT.Location = new Point(49, 0);
            pnlBIN.Location = new Point(35, 0);
            pnlINS.Location = new Point(39, 0);
            pnlSEL.Location = new Point(33, 0);
            pnlHEA.Location = new Point(41, 0);
            pnlMER.Location = new Point(43, 0);
            pnlQUI.Location = new Point(48, 0);
        }

        //Đẩy các label button khác sang phải khi size của 1 label button tăng
        private void lblBUB_SizeChanged(object sender, EventArgs e)
        {
            if (lblBUB.Text == "BUB")
                return;
            pnlINT.Location = new Point(49+70, pnlINT.Location.Y);
        }

        private void lblINT_SizeChanged(object sender, EventArgs e)
        {
            if (lblINT.Text == "INT")
                return;
            pnlBIN.Location = new Point(35 + 145, pnlBIN.Location.Y);
        }

        private void lblBIN_SizeChanged(object sender, EventArgs e)
        {
            if (lblBIN.Text == "BIN")
                return;
            pnlINS.Location = new Point(39 + 174, pnlINS.Location.Y);
        }

        private void lblINS_SizeChanged(object sender, EventArgs e)
        {
            if (lblINS.Text == "INS")
                return;
            pnlSEL.Location = new Point(33 + 114, pnlSEL.Location.Y);
        }

        private void lblSEL_SizeChanged(object sender, EventArgs e)
        {
            if (lblSEL.Text == "SEL")
                return;
            pnlHEA.Location = new Point(41 + 114, pnlHEA.Location.Y);
        }

        private void lblHEA_SizeChanged(object sender, EventArgs e)
        {
            if (lblHEA.Text == "HEA")
                return;
            pnlMER.Location = new Point(43 + 65, pnlMER.Location.Y);
        }

        private void lblMER_SizeChanged(object sender, EventArgs e)
        {
            if (lblMER.Text == "MER")
                return;
            pnlQUI.Location = new Point(48 + 70, pnlQUI.Location.Y);
        }

        private void lblQUI_SizeChanged(object sender, EventArgs e)
        {

        }

        //Thực hiện hành động bấm nút Menu
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnMenu.Text == ">")
            {
                btnMenu.Text = "<";
                fMenu fmenu = new fMenu();
                fmenu.TopLevel = false;
                fmenu.Dock = DockStyle.Fill;
                pnlMenu.Controls.Add(fmenu);
                fmenu.Show();
            }
            else
            {
                btnMenu.Text = ">";
                pnlMenu.Controls.Clear();
            }
            
        }

        //Hành động khi bấm nút Description
        private void btnDescription_Click(object sender, EventArgs e)
        {
            if (btnDescription.Text == "<")
            {
                btnDescription.Text = ">";
                fDescription fdes = new fDescription();
                fdes.TopLevel = false;
                fdes.Dock = DockStyle.Fill;
                pnlDescription.Controls.Add(fdes);
                fdes.Show();
            }
            else
            {
                btnDescription.Text = "<";
                pnlDescription.Controls.Clear();
            }
        }
    }
}
