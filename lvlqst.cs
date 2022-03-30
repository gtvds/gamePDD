using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamePDD
{
    class lvlqst
    {
       
        private string answ_quest;

        public string Answer_quest
        {
            get { return answ_quest; }
            set { answ_quest = value; }
        }

        private bool Correct_quest;

        public bool Correct_question
        {
            get { return Correct_quest; }
            set { Correct_quest = value; }
        }

        private int id;

        public int Id_test
        {
            get { return id; }
            set { id = value; }
        }

        private int lvls;

        public int Level
        {
            get { return lvls; }
            set { lvls = value; }
        }

        private byte Number_button;

        public byte num_but
        {
            get { return Number_button; }
            set { Number_button = value; }
        }



        public lvlqst(string Ans, bool correct, int id_test, int lvl, byte num) 
        {
            this.answ_quest = Ans;
            this.Correct_quest = correct;
            this.id = id_test;
            this.lvls = lvl;
            this.Number_button = num;
        }

    }

}
