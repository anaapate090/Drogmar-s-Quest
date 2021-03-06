﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogmar_s_Quest
{
    public partial class LevelScreen : UserControl
    {
        public LevelScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            EasyScreen es = new EasyScreen();
            Form f = this.FindForm();

            f.Controls.Remove(this);
            f.Controls.Add(es);

            es.Location = new Point((f.Width - es.Width) / 2, (f.Height - es.Height) / 2);

            es.Focus();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            MediumScreen ms = new MediumScreen();
            Form f = this.FindForm();

            f.Controls.Remove(this);
            f.Controls.Add(ms);

            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            ms.Focus();
        }

        private void bossButton_Click(object sender, EventArgs e)
        {
            BossScreen bs = new BossScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(bs);

            bs.Focus();
        }

        private void bossButton_Enter(object sender, EventArgs e)
        {
            easyUnderline.Visible = false;
            normalUnderline.Visible = false;
            bossUnderline.Visible = true;
        }

        private void normalButton_Enter(object sender, EventArgs e)
        {
            easyUnderline.Visible = false;
            normalUnderline.Visible = true;
            bossUnderline.Visible = false;
        }

        private void easyButton_Enter(object sender, EventArgs e)
        {
            easyUnderline.Visible = true;
            normalUnderline.Visible = false;
            bossUnderline.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(ms);

            ms.Focus();
        }

        private void backButton_Enter(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Cyan;
            backButton.ForeColor = Color.Transparent;
        }
    }
}
