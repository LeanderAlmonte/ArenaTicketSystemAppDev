using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaTicketSystem
{
    public partial class SearchPage : Form
    {

        String[] Sections = { "SectionA", "SectionB", "SectionC"};
        String[] row = { "1", "2", "3","4","5"};
        public SearchPage()
        {
            InitializeComponent();
        }
        
        private void rowLabel_Click(object sender, EventArgs e)
        {

        }
        private void bookButton_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {
            sectionComboBox.Text = "A";
            searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("SectionA");
        }


        private void imageSelector(object sender, EventArgs e)
        {
            if(sectionComboBox.Text.Equals("A"))
            {
                if (rowComboBox.Text.Equals("1"))
                {
                                        searchPicturebox.Image =
                     (Image)Properties.Resources.ResourceManager.GetObject("rowA1");
                }
                else if (rowComboBox.Text.Equals("2"))
                {
                    searchPicturebox.Image =
(Image)Properties.Resources.ResourceManager.GetObject("rowA2");
                }
                else if (rowComboBox.Text.Equals("3"))
                {

                    searchPicturebox.Image =
(Image)Properties.Resources.ResourceManager.GetObject("rowA3");
                }
                else if (rowComboBox.Text.Equals("4"))
                {
                    searchPicturebox.Image =
(Image)Properties.Resources.ResourceManager.GetObject("rowA4");

                }
                else if (rowComboBox.Text.Equals("5"))
                {
                    searchPicturebox.Image =
(Image)Properties.Resources.ResourceManager.GetObject("rowA5");
                }
                else {
                    searchPicturebox.Image =
                     (Image)Properties.Resources.ResourceManager.GetObject("SectionA");

                }



            }else if(sectionComboBox.Text.Equals("B"))
            {

                if (rowComboBox.Text.Equals("1"))
                {
                    searchPicturebox.Image =
                     (Image)Properties.Resources.ResourceManager.GetObject("rowB1");
                }
                else if (rowComboBox.Text.Equals("2"))
                {
                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowB2");
                }
                else if (rowComboBox.Text.Equals("3"))
                {
                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowB3");

                }
                else if (rowComboBox.Text.Equals("4"))
                {
                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowB4");
                }
                else if (rowComboBox.Text.Equals("5"))
                {
                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowB5");
                }
                else
                {
                    searchPicturebox.Image =
                     (Image)Properties.Resources.ResourceManager.GetObject("SectionB");

                }

            }
            else if (sectionComboBox.Text.Equals("C"))
            {

                if (rowComboBox.Text.Equals("1"))
                {
                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowC1");
                }
                else if (rowComboBox.Text.Equals("2"))
                {
                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowC2");

                }
                else if (rowComboBox.Text.Equals("3"))
                {

                    searchPicturebox.Image =
 (Image)Properties.Resources.ResourceManager.GetObject("rowC3");

                }
                else if (rowComboBox.Text.Equals("4"))
                {
                    searchPicturebox.Image =
(Image)Properties.Resources.ResourceManager.GetObject("rowC4");
                }
                else if (rowComboBox.Text.Equals("5"))
                {
                    searchPicturebox.Image =
(Image)Properties.Resources.ResourceManager.GetObject("rowC5");
                }
                else
                {
                    searchPicturebox.Image =
                        (Image)Properties.Resources.ResourceManager.GetObject("SectionC");
                }


            }



        }

        private void bookButton_Click_1(object sender, EventArgs e)
        { 
            Checkout checkout = new Checkout();
            checkout.Show();
           
        }
    }
}
