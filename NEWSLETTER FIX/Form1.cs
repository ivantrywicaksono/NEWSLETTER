using NEWSLETTER_FIX.Models;

namespace NEWSLETTER_FIX
{
    public partial class Form1 : Form
    {
        NewsletterContext newsletterContext = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form2 addNewForm = new())
            {
                DialogResult dr = addNewForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Newsletter newsletter = addNewForm.GetNewsletter();
                    if (newsletterContext.Insert(newsletter))
                    {
                        newsletterContext.ReadAll();
                        MessageBox.Show(
                            "Berhasil!\n" +
                            "Date: " + newsletterContext.Newsletters.Last().Date +
                            "\nTitle: " + newsletterContext.Newsletters.Last().Title +
                            "\nDescription: " + newsletterContext.Newsletters.Last().Description +
                            "\nLink: " + newsletterContext.Newsletters.Last().Link +
                            "\nID: " + newsletterContext.Newsletters.Last().Id
                        );
                    }
                    else
                        MessageBox.Show("Gagal");
                }
            }
            this.Show();
            ShowItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            newsletterContext.ReadAll();
            List<Newsletter> newsletters;
            newsletters = newsletterContext.Newsletters;

            flpNewsletter.Controls.Clear();

            foreach (var newsletter in newsletters.TakeLast(3))
            {
                PictureBox newsItem = new NewsletterItem(newsletter).CreateItem();
                newsItem.Click += NewsItem_Click;
                flpNewsletter.Controls.Add(newsItem);
            }

            flpNewsletter.Controls.Add(btnAddNews);
        }

        public void NewsItem_Click(object sender, EventArgs e)
        {
            using (Form2 updateForm = new Form2())
            {
                PictureBox pbNewsletter = sender as PictureBox;
                Newsletter newsletter = pbNewsletter.Tag as Newsletter;
                NewsletterContext newsletterContext = new NewsletterContext();
                updateForm.SetNewsletter(newsletter);

                DialogResult dr = updateForm.ShowDialog();

                if (dr == DialogResult.Ignore)
                {

                }

                if (dr == DialogResult.OK)
                {

                }
            }
        }
    }
}