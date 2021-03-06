﻿using System;
using System.Windows.Forms;
using Infrastructure;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.SettingForms
{
    public partial class TerminalAdd : Form
    {
        private readonly TerminalService _service = new TerminalService();

        private readonly Terminal editTerminal;

        public TerminalAdd()
        {
            InitializeComponent();
            txtPhoneNo.KeyPress += Handler.PhoneNumber;
            Terminal allPhone = _service.GetModel(1);
            if (allPhone != null)
            {
                txtAllPhone.Text = allPhone.AllPhone;
                txtAllPhone.Enabled = false;
            }
        }

        public TerminalAdd(Terminal edit)
        {
            InitializeComponent();
            editTerminal = edit;
            Text = "编辑";
            txtPhoneNo.Text = edit.PhoneNo;
            txtAddress.Text = edit.Address;
            txtGroup.Text = edit.Grouping;
            txtGroupPhone.Text = edit.GroupPhone;

            txtAllPhone.Text = edit.AllPhone;
            txtAllPhone.Enabled = false;
            txtName.Text = edit.Name;
        }

        private void tbWhiteListAdd_Click(object sender, EventArgs e)
        {
            if (editTerminal == null)
            {
                AddTerminal();
            }
            else
            {
                EditTerminal();
            }
            Close();
        }

        private void AddTerminal()
        {
            var model = new Terminal
                {
                    Address = txtAddress.Text,
                    Grouping = txtGroup.Text,
                    PhoneNo = txtPhoneNo.Text,
                    AllPhone = txtAllPhone.Text,
                    GroupPhone = txtGroupPhone.Text,
                    Name = txtName.Text
                };
            try
            {
                _service.Add(model);
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败！原因：" + ex.Message + "。");
            }
        }

        private void EditTerminal()
        {
            var model = new Terminal
                {
                    Id = editTerminal.Id,
                    Address = txtAddress.Text,
                    Grouping = txtGroup.Text,
                    PhoneNo = txtPhoneNo.Text,
                    AllPhone = txtAllPhone.Text,
                    GroupPhone = txtGroupPhone.Text,
                    Name = txtName.Text
                };
            try
            {
                _service.Update(model);
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！原因：" + ex.Message + "。");
            }
        }

        private void TerminalAdd_Load(object sender, EventArgs e)
        {
            txtName.SelectAll();
            txtName.Focus();
        }

        private void txtGroup_TextChanged(object sender, EventArgs e)
        {
            Terminal terminal = _service.GroupNoExists(txtGroup.Text);
            if (terminal != null)
            {
                txtGroupPhone.Text = terminal.GroupPhone;
                txtGroupPhone.Enabled = false;
            }
            else
            {
                txtGroupPhone.Text = string.Empty;
                txtGroupPhone.Enabled = true;
            }
        }
    }
}