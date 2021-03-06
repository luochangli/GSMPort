﻿using System;
using System.Windows.Forms;
using FormUI.OperationLayer;
using Infrastructure;

namespace FormUI.ManagerForms
{
    public partial class OpenCTerminal : Form
    {
        private readonly ListViewItem Terminal;
        private readonly OrderDefinition _order;

        public OpenCTerminal(ListViewItem terminals)
        {
            InitializeComponent();
            _order = new OrderDefinition();
            Terminal = terminals;
        }

        private void OpenCTerminal_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += Handler.PhoneNumber;
            textBox2.KeyPress += Handler.PhoneNumber;
            textBox3.KeyPress += Handler.PhoneNumber;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            _order.OpenCTerminal(Terminal.Text, Terminal.ToolTipText, textBox1.Text.Trim(), textBox2.Text.Trim(),
                                 textBox3.Text.Trim());

            Close();
        }
    }
}