﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();

            DgvAlert.Rows.Add("", "Text");
            DgvAlert.Rows.Add("", "Text2");
        }
    }
}
