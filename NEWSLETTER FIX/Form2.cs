using NEWSLETTER_FIX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWSLETTER_FIX
{
    public partial class Form2 : Form
    {
        // Disable close window button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        public Models.Newsletter GetNewsletter()
        {
            string description = tbNewsDescription.Text;

            if (string.IsNullOrWhiteSpace(description))
                description = null;

            Models.Newsletter newNewsletter = new(
                DateOnly.Parse(datePickerNewsletter.Value.ToShortDateString()),
                tbNewsTitle.Text,
                description,
                tbNewsLink.Text
            );

            return newNewsletter;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetNewsletter(Newsletter newsletter)
        {
            // Codingan set tiap textbox dan komponen lainnya sesuai objek newsletternya
            tbNewsTitle.Text = newsletter.Title;
            tbNewsDescription.Text = newsletter.Description;
            tbNewsLink.Text = newsletter.Link;
            datePickerNewsletter.Value = DateTime.Parse(newsletter.Date.ToString());
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewsTitle.Text))
            {
                MessageBox.Show("Mohon isi judul");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNewsLink.Text))
            {
                MessageBox.Show("Mohon isi link");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNewsDescription.Text))
            {
                MessageBox.Show("Mohon isi deskripsi");
                return;
            }
            if (string.IsNullOrWhiteSpace(datePickerNewsletter.Value.ToShortDateString()))
            {
                MessageBox.Show("Mohon isi tanggal");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
