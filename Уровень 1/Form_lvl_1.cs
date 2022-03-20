using gamePDD._1_уровень;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamePDD
{
    public partial class Form_lvl_1 : System.Windows.Forms.Form
    {
        int level = 0;
        int button = 0;
        public Form_lvl_1()
        {
            InitializeComponent();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button++;
            switch (button)
            {
                case 1:
                    pictureBox5.Hide();
                    SqlConnection cn1 = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
                    cn1.Open();
                    SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn1);
                    command1.Parameters.AddWithValue("@Answer_questions", "Наземный");
                    command1.Parameters.AddWithValue("@Correct_question", "True");
                    command1.Parameters.AddWithValue("@id_test", label1.Text);
                    command1.ExecuteNonQuery();
                    cn1.Close();
                    pictureBox4.Show();
                    break;
                case 2:
                    pictureBox5.Hide();
                    SqlConnection cn2 = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
                    cn2.Open();
                    SqlCommand command2 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn2);
                    command2.Parameters.AddWithValue("@Answer_questions", "По дороге");
                    command2.Parameters.AddWithValue("@Correct_question", "True");
                    command2.Parameters.AddWithValue("@id_test", label1.Text);
                    command2.ExecuteNonQuery();
                    cn2.Close();
                    pictureBox4.Show();
                    break;
                case 3:
                    pictureBox5.Hide();
                    SqlConnection cn3 = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
                    cn3.Open();
                    SqlCommand command3 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn3);
                    command3.Parameters.AddWithValue("@Answer_questions", "Отвлекать водителя");
                    command3.Parameters.AddWithValue("@Correct_question", "True");
                    command3.Parameters.AddWithValue("@id_test", label1.Text);
                    command3.ExecuteNonQuery();
                    cn3.Close();
                    pictureBox4.Show();
                    break;
                case 4:
                    pictureBox5.Hide();
                    SqlConnection cn4 = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
                    cn4.Open();
                    SqlCommand command4 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn4);
                    command4.Parameters.AddWithValue("@Answer_questions", "На специальных площадках");
                    command4.Parameters.AddWithValue("@Correct_question", "True");
                    command4.Parameters.AddWithValue("@id_test", label1.Text);
                    command4.ExecuteNonQuery();
                    cn4.Close();
                    pictureBox4.Show();
                    break;
                case 5:
                    pictureBox5.Hide();
                    SqlConnection cn5 = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
                    cn5.Open();
                    SqlCommand command5 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn5);
                    command5.Parameters.AddWithValue("@Answer_questions", "Общественный");
                    command5.Parameters.AddWithValue("@Correct_question", "True");
                    command5.Parameters.AddWithValue("@id_test", label1.Text);
                    command5.ExecuteNonQuery();
                    cn5.Close();
                    pictureBox4.Show();
                    break;
            }
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Водный");
            command1.Parameters.AddWithValue("@Correct_question", "False");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Подземный");
            command1.Parameters.AddWithValue("@Correct_question", "False");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox5.Show();
        }

        private void Form_lvl1_Load(object sender, EventArgs e)
        {
            String insertCmd1 = "SELECT MAX(id_test) FROM Tests WHERE Name_test = 'Транспорт'";
            SqlConnection myConnection1 = new SqlConnection("Data Source=GTVDS-PC\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand1 = new SqlCommand(insertCmd1.ToString(), myConnection1);
            myConnection1.Open();
            SqlDataReader rd1;
            rd1 = myCommand1.ExecuteReader();
            while (rd1.Read())
            {
                label1.Text = rd1[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level++;
            switch (level)
            {

                case 1://уровень 2
                    // уровень
                    pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_34;
                    pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox1.Location = new System.Drawing.Point(384, 12);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new System.Drawing.Size(657, 162);
                    pictureBox1.TabIndex = 12;
                    pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_241;
                    pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox2.Location = new System.Drawing.Point(268, 82);
                    pictureBox2.Name = "pictureBox2";
                    pictureBox2.Size = new System.Drawing.Size(690, 147);
                    pictureBox2.TabIndex = 1;
                    pictureBox2.TabStop = false;
                    // девочка или парень
                    pictureBox3.BackColor = System.Drawing.Color.Transparent;
                    pictureBox3.BackgroundImage = global::gamePDD.Properties.Resources.верный_ответ_девочка;
                    pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox3.Location = new System.Drawing.Point(147, 235);
                    pictureBox3.Name = "pictureBox3";
                    pictureBox3.Size = new System.Drawing.Size(174, 333);
                    pictureBox3.TabIndex = 2;
                    pictureBox3.TabStop = false;
                    // далее
                    button1.BackgroundImage = global::gamePDD.Properties.Resources.кнопка__далее_;
                    button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button1.FlatAppearance.BorderSize = 0;
                    button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button1.Location = new System.Drawing.Point(953, 574);
                    button1.Name = "button1";
                    button1.Size = new System.Drawing.Size(202, 66);
                    button1.TabIndex = 3;
                    button1.UseVisualStyleBackColor = true;
                    button1.Click += new System.EventHandler(button1_Click);
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_41;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    button3.Click += new System.EventHandler(button3_Click);
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_42;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    button4.Click += new System.EventHandler(button4_Click);
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_43;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
                    button5.Click += new System.EventHandler(button5_Click_1);
                    // правильно label
                    pictureBox4.BackColor = System.Drawing.Color.Transparent;
                    pictureBox4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_381;
                    pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox4.Location = new System.Drawing.Point(875, 254);
                    pictureBox4.Name = "pictureBox4";
                    pictureBox4.Size = new System.Drawing.Size(262, 169);
                    pictureBox4.TabIndex = 15;
                    pictureBox4.TabStop = false;
                    pictureBox4.Visible = false;
                    pictureBox4.Click += new System.EventHandler(pictureBox4_Click); 
                    //  неправильно label
                    pictureBox5.BackColor = System.Drawing.Color.Transparent;
                    pictureBox5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_40;
                    pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox5.Location = new System.Drawing.Point(860, 388);
                    pictureBox5.Name = "pictureBox5";
                    pictureBox5.Size = new System.Drawing.Size(321, 87);
                    pictureBox5.TabIndex = 16;
                    pictureBox5.TabStop = false;
                    pictureBox5.Visible = false;
                    // получение id
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(1129, 478);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(38, 15);
                    label1.TabIndex = 17;
                    label1.Visible = true;
                    break;

                case 2://уровень 3
                    // уровень
                    pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_34;
                    pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox1.Location = new System.Drawing.Point(384, 12);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new System.Drawing.Size(657, 162);
                    pictureBox1.TabIndex = 12;
                    pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_471;
                    pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox2.Location = new System.Drawing.Point(268, 82);
                    pictureBox2.Name = "pictureBox2";
                    pictureBox2.Size = new System.Drawing.Size(690, 147);
                    pictureBox2.TabIndex = 1;
                    pictureBox2.TabStop = false;
                    // девочка или парень
                    pictureBox3.BackColor = System.Drawing.Color.Transparent;
                    pictureBox3.BackgroundImage = global::gamePDD.Properties.Resources.верный_ответ_девочка;
                    pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox3.Location = new System.Drawing.Point(147, 235);
                    pictureBox3.Name = "pictureBox3";
                    pictureBox3.Size = new System.Drawing.Size(174, 333);
                    pictureBox3.TabIndex = 2;
                    pictureBox3.TabStop = false;
                    // далее
                    button1.BackgroundImage = global::gamePDD.Properties.Resources.кнопка__далее_;
                    button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button1.FlatAppearance.BorderSize = 0;
                    button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button1.Location = new System.Drawing.Point(953, 574);
                    button1.Name = "button1";
                    button1.Size = new System.Drawing.Size(202, 66);
                    button1.TabIndex = 3;
                    button1.UseVisualStyleBackColor = true;
                    button1.Click += new System.EventHandler(button1_Click);
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_44;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    button3.Click += new System.EventHandler(button3_Click);
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_45;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    button4.Click += new System.EventHandler(button4_Click);
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_46;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
                    button5.Click += new System.EventHandler(button5_Click_1);
                    //правильно label
                    pictureBox4.BackColor = System.Drawing.Color.Transparent;
                    pictureBox4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_381;
                    pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox4.Location = new System.Drawing.Point(875, 254);
                    pictureBox4.Name = "pictureBox4";
                    pictureBox4.Size = new System.Drawing.Size(262, 169);
                    pictureBox4.TabIndex = 15;
                    pictureBox4.TabStop = false;
                    pictureBox4.Visible = false;
                    pictureBox4.Click += new System.EventHandler(pictureBox4_Click);
                    //неправильно label
                    pictureBox5.BackColor = System.Drawing.Color.Transparent;
                    pictureBox5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_40;
                    pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox5.Location = new System.Drawing.Point(860, 388);
                    pictureBox5.Name = "pictureBox5";
                    pictureBox5.Size = new System.Drawing.Size(321, 87);
                    pictureBox5.TabIndex = 16;
                    pictureBox5.TabStop = false;
                    pictureBox5.Visible = false;
                    //получение id
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(1129, 478);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(38, 15);
                    label1.TabIndex = 17;
                    label1.Visible = true;
                    break;

                case 3://уровень 4
                    // уровень
                    pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_34;
                    pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox1.Location = new System.Drawing.Point(384, 12);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new System.Drawing.Size(657, 162);
                    pictureBox1.TabIndex = 12;
                    pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_53;
                    pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox2.Location = new System.Drawing.Point(268, 82);
                    pictureBox2.Name = "pictureBox2";
                    pictureBox2.Size = new System.Drawing.Size(690, 147);
                    pictureBox2.TabIndex = 1;
                    pictureBox2.TabStop = false;
                    // девочка или парень
                    pictureBox3.BackColor = System.Drawing.Color.Transparent;
                    pictureBox3.BackgroundImage = global::gamePDD.Properties.Resources.Начало_теста__парниша;
                    pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox3.Location = new System.Drawing.Point(162, 235);
                    pictureBox3.Name = "pictureBox3";
                    pictureBox3.Size = new System.Drawing.Size(302, 333);
                    pictureBox3.TabIndex = 19;
                    pictureBox3.TabStop = false;
                    // далее
                    button1.BackgroundImage = global::gamePDD.Properties.Resources.кнопка__далее_;
                    button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button1.FlatAppearance.BorderSize = 0;
                    button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button1.Location = new System.Drawing.Point(953, 574);
                    button1.Name = "button1";
                    button1.Size = new System.Drawing.Size(202, 66);
                    button1.TabIndex = 3;
                    button1.UseVisualStyleBackColor = true;
                    button1.Click += new System.EventHandler(button1_Click);
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_54;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    button3.Click += new System.EventHandler(button3_Click);
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_55;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    button4.Click += new System.EventHandler(button4_Click);
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_56;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
                    button5.Click += new System.EventHandler(button5_Click_1);
                    //правильно label
                    pictureBox4.BackColor = System.Drawing.Color.Transparent;
                    pictureBox4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_381;
                    pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox4.Location = new System.Drawing.Point(875, 254);
                    pictureBox4.Name = "pictureBox4";
                    pictureBox4.Size = new System.Drawing.Size(262, 169);
                    pictureBox4.TabIndex = 15;
                    pictureBox4.TabStop = false;
                    pictureBox4.Visible = false;
                    pictureBox4.Click += new System.EventHandler(pictureBox4_Click);
                    //неправильно label
                    pictureBox5.BackColor = System.Drawing.Color.Transparent;
                    pictureBox5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_40;
                    pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox5.Location = new System.Drawing.Point(860, 388);
                    pictureBox5.Name = "pictureBox5";
                    pictureBox5.Size = new System.Drawing.Size(321, 87);
                    pictureBox5.TabIndex = 16;
                    pictureBox5.TabStop = false;
                    pictureBox5.Visible = false;
                    //получение id
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(1129, 478);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(38, 15);
                    label1.TabIndex = 17;
                    label1.Visible = false;
                    break;

                case 4://уровень 5
                    // уровень
                    pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_34;
                    pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox1.Location = new System.Drawing.Point(384, 12);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new System.Drawing.Size(657, 162);
                    pictureBox1.TabIndex = 12;
                    pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_57;
                    pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox2.Location = new System.Drawing.Point(268, 82);
                    pictureBox2.Name = "pictureBox2";
                    pictureBox2.Size = new System.Drawing.Size(690, 147);
                    pictureBox2.TabIndex = 1;
                    pictureBox2.TabStop = false;
                    // девочка или парень
                    pictureBox3.BackColor = System.Drawing.Color.Transparent;
                    pictureBox3.BackgroundImage = global::gamePDD.Properties.Resources.Начало_теста__парниша;
                    pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox3.Location = new System.Drawing.Point(162, 235);
                    pictureBox3.Name = "pictureBox3";
                    pictureBox3.Size = new System.Drawing.Size(302, 333);
                    pictureBox3.TabIndex = 19;
                    pictureBox3.TabStop = false;
                    // далее
                    button1.BackgroundImage = global::gamePDD.Properties.Resources.кнопка__далее_;
                    button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button1.FlatAppearance.BorderSize = 0;
                    button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button1.Location = new System.Drawing.Point(953, 574);
                    button1.Name = "button1";
                    button1.Size = new System.Drawing.Size(202, 66);
                    button1.TabIndex = 3;
                    button1.UseVisualStyleBackColor = true;
                    button1.Click += new System.EventHandler(button1_Click);
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_58;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    button3.Click += new System.EventHandler(button3_Click);
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_60;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    button4.Click += new System.EventHandler(button4_Click);
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_62;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
                    button5.Click += new System.EventHandler(button5_Click_1);
                    //правильно label
                    pictureBox4.BackColor = System.Drawing.Color.Transparent;
                    pictureBox4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_381;
                    pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox4.Location = new System.Drawing.Point(875, 254);
                    pictureBox4.Name = "pictureBox4";
                    pictureBox4.Size = new System.Drawing.Size(262, 169);
                    pictureBox4.TabIndex = 15;
                    pictureBox4.TabStop = false;
                    pictureBox4.Visible = false;
                    pictureBox4.Click += new System.EventHandler(pictureBox4_Click);
                    //неправильно label
                    pictureBox5.BackColor = System.Drawing.Color.Transparent;
                    pictureBox5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_40;
                    pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox5.Location = new System.Drawing.Point(860, 388);
                    pictureBox5.Name = "pictureBox5";
                    pictureBox5.Size = new System.Drawing.Size(321, 87);
                    pictureBox5.TabIndex = 16;
                    pictureBox5.TabStop = false;
                    pictureBox5.Visible = false;
                    //получение id
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(1129, 478);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(38, 15);
                    label1.TabIndex = 17;
                    label1.Visible = true;
                    break;
                default:
                    this.Hide();
                    Form_ThemePDD ft = new Form_ThemePDD();
                    ft.Show();
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
    }
