using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Services;

namespace Library
{
    public partial class AddNewMemberForm : Form
    {
        private MemberService _memberService;

        public AddNewMemberForm(MemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private void AddNewMember_btn_Click(object sender, EventArgs e)
        {
            _memberService.AddNewMember(addNewMemberName_textbox.Text, addNewMemberId_textbox.Text);
            this.Close();
        }
    }
}
