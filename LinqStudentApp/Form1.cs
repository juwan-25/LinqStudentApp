using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqStudentApp
{
    public partial class Form1 : Form
    {
        static private List<Student> students = new List<Student>()
        {
            new Student(){ Grade=3101, Name="김미연", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3102, Name="나미림", Dept="소프트웨어과", Employment=false },
            new Student(){ Grade=3103, Name="나나", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3104, Name="박연아", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3105, Name="신채영", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3401, Name="강하민", Dept="웹솔루션과", Employment=false },
            new Student(){ Grade=3402, Name="김시차", Dept="웹솔루션과", Employment=false },
            new Student(){ Grade=3403, Name="박소영", Dept="웹솔루션과", Employment=true },
            new Student(){ Grade=3404, Name="신지인", Dept="웹솔루션과", Employment=true },
            new Student(){ Grade=3405, Name="이주민", Dept="웹솔루션과", Employment=true },
            new Student(){ Grade=3406, Name="이하진", Dept="웹솔루션과", Employment=false },
            new Student(){ Grade=3206, Name="이리라", Dept="소프트웨어과", Employment=false },
            new Student(){ Grade=3207, Name="이지민", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3208, Name="임솔", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3209, Name="주하영", Dept="소프트웨어과", Employment=false },
            new Student(){ Grade=3210, Name="최예진", Dept="소프트웨어과", Employment=true },
            new Student(){ Grade=3306, Name="인수진", Dept="웹솔루션과", Employment=false },
            new Student(){ Grade=3307, Name="임채신", Dept="웹솔루션과", Employment=false },
            new Student(){ Grade=3308, Name="최나리", Dept="웹솔루션과", Employment=true },
            new Student(){ Grade=3309, Name="하인성", Dept="웹솔루션과", Employment=true },
            new Student(){ Grade=3310, Name="황인준", Dept="웹솔루션과", Employment=false },

        };

        public Form1()
        {
            InitializeComponent();
        }

        //학생 목록 전체 보기
        private void button1_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = students;
        }

        //소프트웨어과 학생 보기
        private void button2_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              where item.Dept == "소프트웨어과"
                                              select item;
        }

        //학번순 정렬 보기
        private void button3_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              orderby item.Grade 
                                              select item;
        }


    }
}
