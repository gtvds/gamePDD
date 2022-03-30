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

namespace gamePDD.Уровень_2
{
    public partial class Form_lvl2 : System.Windows.Forms.Form
    {
        int level = 1;
        int lvl = 0;
        static List<lvlqst> lvlqsts;
        public Form_lvl2()
        {
            InitializeComponent();
            lvlqsts = new List<lvlqst>();
            //1 уровень
            lvlqsts.Add(new lvlqst("Спокойным шагом", true, 0, 1, 1));
            lvlqsts.Add(new lvlqst("Медленно идти при этом петь песни", false, 0, 1, 1));
            lvlqsts.Add(new lvlqst("Нужно быстро бежать", false, 0, 1, 1));
            //2 уровень
            lvlqsts.Add(new lvlqst("По полоскам на дороге", true, 0, 2, 1));
            lvlqsts.Add(new lvlqst("Никак не определить", false, 0, 2, 1));
            lvlqsts.Add(new lvlqst("Там, где много людей", false, 0, 2, 1));
            //3 уровень
            lvlqsts.Add(new lvlqst("Обочина", false, 0, 3, 1));
            lvlqsts.Add(new lvlqst("Тротуар", true, 0, 3, 1));
            lvlqsts.Add(new lvlqst("Полоса движения", false, 0, 3, 1));
            //4 уровень
            lvlqsts.Add(new lvlqst("Продолжить идти дальше", false, 0, 4, 1));
            lvlqsts.Add(new lvlqst("Вернуться назад", false, 0, 4, 1));
            lvlqsts.Add(new lvlqst("Остановиться на остановке", true, 0, 4, 1));
            //5 уровень
            lvlqsts.Add(new lvlqst("На крутых поворотах", false, 0, 5, 1));
            lvlqsts.Add(new lvlqst("В местах, где дорога идет на подъем", false, 0, 5, 1));
            lvlqsts.Add(new lvlqst("Во всех перечисленных местах", true, 0, 5, 1));
        }
        private void InsertDB(lvlqst lvlqsts)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn2.Open();
            SqlCommand command2 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn2);
            command2.Parameters.AddWithValue("@Answer_questions", lvlqsts.Answer_quest);
            command2.Parameters.AddWithValue("@Correct_question", lvlqsts.Correct_question.ToString());
            command2.Parameters.AddWithValue("@id_test", label1.Text);
            command2.ExecuteNonQuery();
            cn2.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            InsertDB(lvlqsts.FirstOrDefault(lvl => lvl.Correct_question && lvl.Level.Equals(level)));
            pictureBox4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvl++;
            level++;
            switch (lvl)
            {
                case 1://уровень 2
                       // уровень
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_67;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    this.pictureBox1.Location = new System.Drawing.Point(377, 11);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(574, 62);
                    this.pictureBox1.TabIndex = 23;
                    this.pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ур2_вопр2;
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
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_75;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_76;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_77;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
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
                    label1.Visible = false;
                    break;

                case 2://уровень 3
                       // уровень
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_67;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    this.pictureBox1.Location = new System.Drawing.Point(377, 11);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(574, 62);
                    this.pictureBox1.TabIndex = 23;
                    this.pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ур2_вопр3;
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
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_79;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_78;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_80;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
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

                case 3://уровень 4
                       // уровень
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_67;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    this.pictureBox1.Location = new System.Drawing.Point(377, 11);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(574, 62);
                    this.pictureBox1.TabIndex = 23;
                    this.pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ур2_вопр4;
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
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_90;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_91;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_89;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
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
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_67;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    this.pictureBox1.Location = new System.Drawing.Point(377, 11);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(574, 62);
                    this.pictureBox1.TabIndex = 23;
                    this.pictureBox1.TabStop = false;
                    // вопрос
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ур2_вопр5;
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
                    // баллы
                    button2.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_посмотреть_баллы;
                    button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button2.Location = new System.Drawing.Point(12, 574);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(338, 66);
                    button2.TabIndex = 4;
                    button2.UseVisualStyleBackColor = true;
                    // ответ 1
                    button3.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_86;
                    button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button3.Location = new System.Drawing.Point(400, 254);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(437, 75);
                    button3.TabIndex = 5;
                    button3.UseVisualStyleBackColor = true;
                    // ответ 2
                    button4.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_85;
                    button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button4.Location = new System.Drawing.Point(400, 358);
                    button4.Name = "button4";
                    button4.Size = new System.Drawing.Size(437, 75);
                    button4.TabIndex = 13;
                    button4.UseVisualStyleBackColor = true;
                    // ответ 3
                    button5.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_88;
                    button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    button5.Location = new System.Drawing.Point(400, 465);
                    button5.Name = "button5";
                    button5.Size = new System.Drawing.Size(437, 75);
                    button5.TabIndex = 14;
                    button5.UseVisualStyleBackColor = true;
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
                default:
                    this.Hide();
                    Form_ThemePDD ft = new Form_ThemePDD();
                    ft.Show();
                    break;
            }
        }
        private void Form_lvl_1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertDB(lvlqsts.FirstOrDefault(lvl => !lvl.Correct_question && lvl.Level.Equals(level)));
            pictureBox5.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            InsertDB(lvlqsts.LastOrDefault(lvl => !lvl.Correct_question && lvl.Level.Equals(level)));
            pictureBox5.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form_lvl2_Load(object sender, EventArgs e)
        {
            String insertCmd = "SELECT MAX(id_test) FROM Tests WHERE Name_test = 'Транспорт'";
            SqlConnection myConnection = new SqlConnection("Data Source=GTVDS-PC\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand = new SqlCommand(insertCmd.ToString(), myConnection);
            myConnection.Open();
            SqlDataReader rd;
            rd = myCommand.ExecuteReader();
            while (rd.Read())
            {
                label1.Text = rd[0].ToString();
            }
        }
    }
}
