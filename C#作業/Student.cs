using System;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Student : Form
    {
        private string studentName;
        private int chineseScore;
        private int englishScore;
        private int mathScore;

        public Student()
        {
            InitializeComponent();
        }


        private void btnIN_Click(object sender, EventArgs e)
        {
            studentName = txtName.Text;
            chineseScore = int.Parse(txtChinese.Text);
            englishScore = int.Parse(txtEnglish.Text);
            mathScore = int.Parse(txtMath.Text);


            // 清空輸入框
            txtName.Text = "";
            txtChinese.Text = "";
            txtEnglish.Text = "";
            txtMath.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentData = "姓名: " + studentName + "\n" +
                                 "國文成績: " + chineseScore + "\n" +
                                 "英文成績: " + englishScore + "\n" +
                                 "數學成績: " + mathScore;

            labAll.Text = (studentData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string highestSubject = "";
            string lowestSubject = "";

            int highestScore = Math.Max(chineseScore, Math.Max(englishScore, mathScore));
            int lowestScore = Math.Min(chineseScore, Math.Min(englishScore, mathScore));

            if (chineseScore == highestScore)
                highestSubject = "國文";
            else if (englishScore == highestScore)
                highestSubject = "英文";
            else if (mathScore == highestScore)
                highestSubject = "數學";

            if (chineseScore == lowestScore)
                lowestSubject = "國文";
            else if (englishScore == lowestScore)
                lowestSubject = "英文";
            else if (mathScore == lowestScore)
                lowestSubject = "數學";
            string student = "最高分科目: " + highestSubject  +
                                 ",最高分數: " + highestScore + "\n" +
                                 "最低分科目: " + lowestSubject  +
                                 ",最低分數: " + lowestScore;
            labMM.Text = student;
        }
    }
}
