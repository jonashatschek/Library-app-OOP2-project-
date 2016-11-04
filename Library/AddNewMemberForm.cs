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
    /// <summary>
    /// class made for adding new members
    /// </summary>
    public partial class AddNewMemberForm : Form
    {
        private MemberService _memberService;

        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="memberService">memberservice object</param>
        public AddNewMemberForm(MemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        /// <summary>
        /// when button is clicked, a new member gets added with values from the textboxes in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewMember_btn_Click(object sender, EventArgs e)
        {
            _memberService.AddNewMember(addNewMemberName_textbox.Text, addNewMemberId_textbox.Text);
            this.Close();
        }

        /// <summary>
        /// closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewMemberCancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
