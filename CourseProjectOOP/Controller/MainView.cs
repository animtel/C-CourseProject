﻿using CourseProjectOOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectOOP
{
    //**********************************************************************************************************************************
    public partial class MainView : Form
    {
        ListOfBooks list = new ListOfBooks();
        public Graphics g;
        public Bitmap map;
        public Pen p;
        public double angle = Math.PI / 2;
        public double ang1 = Math.PI / 4;
        public double ang2 = Math.PI / 6;

        public int index { get; set; }
        public int IdOfBook { get; set; }
        public string GenreOfBook { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(map);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Green);

            DrawTree(150, 300, 100, angle);

            pictureBox1.BackgroundImage = map;
        }
        public int DrawTree(double x, double y, double a, double angle)
        {

            if (a > 2)
            {
                a *= 0.7;

                double xnew = Math.Round(x + a * Math.Cos(angle)),
                       ynew = Math.Round(y - a * Math.Sin(angle));

                g.DrawLine(p, (float)x, (float)y, (float)xnew, (float)ynew);

                x = xnew;
                y = ynew;

                DrawTree(x, y, a, angle + ang1);
                DrawTree(x, y, a, angle - ang2);
            }
            return 0;
        }
        //*******************************************************************************************************************************
        

        public bool flag = true;
        

        public MainView()
        {
            InitializeComponent();
            Table.DataSource = list.ShowAllBooks();
        }

        private void textBoxID(object sender, EventArgs e)
        {

        }

        
        //public void FindBookAsId()
        //{
        //    string searchId = textBox1.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
            
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
        //    }

        //    List<Books> p = new List<Books>();
        //    foreach (Books data in book)
        //    {
        //        if (data.id == Convert.ToInt32(searchId) && data.Available == Convert.ToBoolean(available.Text.ToLower()))
        //        {
        //            p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
        //        }
        //    }
        //    dataGridView1.DataSource = p;
        //}

        //public void FindBookAsAutor()
        //{
        //    string searchAutor = textBox1.Text;
            
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //    }


        //    List<Books> p = new List<Books>();
        //    foreach (Books data in book)
        //    {
        //        if (data.autor == searchAutor && data.Available == Convert.ToBoolean(available.Text.ToLower()))
        //        {
        //            p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
        //        }
        //    }
        //    dataGridView1.DataSource = p;
        //}

        //public void FindBookAsName()
        //{
        //    string searchName = SearchBox.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
        //    }


        //    List<Books> p = new List<Books>();
        //    foreach (Books data in book)
        //    {
        //        if (data.nameOfBook == searchName && data.Available == Convert.ToBoolean(available.Text.ToLower()))
        //        {
        //            p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
        //        }
        //    }
        //    dataGridView1.DataSource = p;
        //}

        //public void FindBookAsYear()
        //{
        //    string searchYear = SearchBox.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
        //    }


        //    List<Books> p = new List<Books>();
        //    foreach (Books data in book)
        //    {
        //        if (data.year == Convert.ToInt32(searchYear) && data.Available == Convert.ToBoolean(available.Text.ToLower()))
        //        {
        //            p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
        //        }
        //    }
        //    dataGridView1.DataSource = p;
        //}

                    
        //public void FindBookAsGenre()
        //{
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
        //    }


        //    List<Books> p = new List<Books>();
        //    foreach (Books data in book)
        //    {
        //        if (data.genre == comboBox2.Text)
        //        {
        //            p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
        //        }
        //    }
        //    dataGridView1.DataSource = p;
        //}

        //public void FindBookAsValuetion()
        //{
        //    string searchValuetion = SearchBox.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
        //    }
            

        //    List<Books> p = new List<Books>();
        //    foreach (Books data in book)
        //    {
        //        if (data.valuetion == Convert.ToInt32(searchValuetion))
        //        {
        //            p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
        //        }
        //    }
        //    dataGridView1.DataSource = p;
        //}

        //public void ShowAllBooks()
        //{
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newLib = str.Split(',');

        //        book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
        //    }
        //    dataGridView1.DataSource = book;
        //}

        private void buttonShowAllBooks(object sender, EventArgs e)
        {
            Table.DataSource = list.ShowAllBooks();
        }

        private void labelAllBooks(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        



        public string ChooseYourAvailableOfBook()
        {
            string result = "";
            
            return result;
        }

        public string ChooseYourGenre()
        {
            string result = "";

            switch (Genre.Text)
            {
                case "Fantasy":
                    result = "Fantasy";
                    break;
                case "Romans":
                    result = "Romans";
                    break;
                case "Childrens lit":
                    result = "Childrens lit";
                    break;
                case "Detectiv":
                    result = "Detectiv";
                    break;
                case "Mistic":
                    result = "Mistic";
                    break;
                default:
                    result = "Genre";
                    break;
            }
            return result;
        } // Жанры!

        public string ChooseYourAvailable()
        {
            string Available = available.Text;
            string result = "";
            switch (Available)
            {
                case "Are available":
                    return result = "Are available";
                    break;
                case "Aren`t available":
                    return result = "Aren`t available";
                    break;
                default:
                    return result = "Available";
                    break;
            }
        } //Есть или нет в наличии!

        private void button3_Click(object sender, EventArgs e)
        {
            string WhatAreYouWantToSearch = comboBox1.Text;
            switch (WhatAreYouWantToSearch)
            {
                case "Search as id":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsId(SearchBox.Text, available.Text.ToLower());
                    break;
                case "Search as Autor":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsAutor(SearchBox.Text, available.Text.ToLower());
                    break;
                case "Search as Name":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsName(SearchBox.Text, available.Text.ToLower());
                    break;
                case "Search as Year":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsYear(SearchBox.Text, available.Text.ToLower());
                    break;
                case "Search as Genre":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsGenre(ChooseYourGenre());
                    break;
                case "Search as Valuetion":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsValuetion(SearchBox.Text);
                    break;
                default:
                    
                    break;
            }
        } // Главная кнопка поиска!

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }

       

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table.DataSource = list.ShowAllBooks();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (SearchBox.Focus() && flag)
            {
                SearchBox.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete form = new Delete();
            form.Show();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ChangeBook change = new ChangeBook(index);

            change.Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = index;
            int Id = IdOfBook;
            string Genre = GenreOfBook;
            if (ind != null)
            {
                PDFBookReader reader = new PDFBookReader(ind, Id, Genre);
                reader.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали книгу!");
            }
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            IdOfBook = Convert.ToInt32(Table.Rows[index].Cells[0].Value);
            GenreOfBook = Convert.ToString(Table.Rows[index].Cells[4].Value);
        }
    }
}