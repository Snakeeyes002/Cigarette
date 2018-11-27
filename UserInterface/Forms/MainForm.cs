using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using UserInterface.Models;

namespace UserInterface.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Loaded");
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/posts");

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Post post = (Post)listBox1.SelectedItem;
            DetailsForm detailsForm = new DetailsForm(post);
            detailsForm.Show();
        }
    }
}
