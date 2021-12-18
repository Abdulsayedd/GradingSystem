namespace GradingSystem
{

    public partial class Form1 : Form
    {
        public double h1=0,h2=0,h3=0,h4=0,h5=0,h6=0,m=0;

        LinkedList L = new LinkedList();
        public Form1()
        {
            InitializeComponent();
        }
        public string degree(double h)
        {
            if(h>=98)
            return "A+";
            else if(h>=92)
             return "A"; 
            else if(h>=90)
             return "A-"; 
            else if(h>=88)
            return "B+";
            else if (h >= 82)
                return "B";
            else if (h >= 80)
                return "B-";
            else if (h >= 78)
                return "C+";
            else if (h >= 72)
                return "C";
            else if (h >= 70)
                return "C-";
            else if (h >= 68)
                return "D+";
            else if (h >= 62)
                return "D";
            else if (h >= 60)
                return "D-";
            else
                return "F";
        }



        private void Savebtn_Click(object sender, EventArgs e)
        {
            L.insert(NameLabel_View.Text, idLabel_View.Text, Deg.Text);
            Nametxtbox.Text = "";
            idtxtbox.Text = "";
            midtxtbox.Text = "";
            finaltxtbox.Text = "";
            quizzestxtbox.Text = "";
            attendancetxtbox.Text = "";
            projectstxtbox.Text = "";
            homeworktxtbox.Text = "";
            idLabel_View.Text = "";
            NameLabel_View.Text = "";
            QuizzesLabel_View.Text = "";
            HomeworkLabel_View.Text = "";
            midLabel_View.Text = "";
            finalLabel_View.Text = "";
            AttendanceLabel_View.Text = "";
            ProjectsLabel_View.Text = "";
            attendance_grade.Text = "";
            mid_grade.Text = "";
            final_grade.Text = "";
            quizzes_grade.Text = "";
            projects_grade.Text = "";
            homework_grade.Text = "";
            homework_grade.Text = "";
            saved.Text = "saved!";
            timer1.Start();
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            searchtxtbox.ForeColor = Color.FromArgb(35, 41, 70);
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            L.search(searchtxtbox.Text);
        }

        private void searchtxtbox_Enter(object sender, EventArgs e)
        {
            searchtxtbox.Text = "";
        }
//Abdulsayed
        private void timer1_Tick(object sender, EventArgs e)
        {
            saved.Text = string.Empty;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Nametxtbox.Text = "";
            idtxtbox.Text = "";
            midtxtbox.Text = "";
            finaltxtbox.Text = "";
            quizzestxtbox.Text = "";
            attendancetxtbox.Text = "";
            projectstxtbox.Text = "";
            homeworktxtbox.Text = "";
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            NameLabel_View.Text = Nametxtbox.Text;
            idLabel_View.Text = idtxtbox.Text;
            ////////////////////
            QuizzesLabel_View.Text = quizzestxtbox.Text;
            if (quizzestxtbox.Text != "")
            {
                h2 = double.Parse(quizzestxtbox.Text);
                h2 = (h2 * 100) / 10;
                if (h2 > 100)
                {
                    quizzes_grade.Text = "NaN";
                }
                else
                    quizzes_grade.Text = h2.ToString("0.0") + "%";

            }
            Done_Grade.Text = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4) + "%";
            m = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4); Deg.Text = degree(m);
            ///////////////
            
            AttendanceLabel_View.Text = attendancetxtbox.Text;
            if (attendancetxtbox.Text != "")
            {
                h1 = double.Parse(attendancetxtbox.Text);
                h1 = (h1 * 100) / 50;
                if (h1 > 100)
                {
                    attendance_grade.Text = "NaN";
                }
                else
                    attendance_grade.Text = h1.ToString("0.0") + "%";

            }
            Done_Grade.Text = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4) + "%";
            m = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4); Deg.Text = degree(m);
            /////////
            
            ProjectsLabel_View.Text = projectstxtbox.Text;
            if (projectstxtbox.Text != "")
            {
                h3 = double.Parse(projectstxtbox.Text);
                h3 = (h3 * 100) / 3;
                if (h3 > 100)
                {
                    projects_grade.Text = "NaN";
                }
                else
                    projects_grade.Text = h3.ToString("0.0") + "%";

            }
            Done_Grade.Text = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4) + "%";
            m = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4); Deg.Text = degree(m);
            ///////////
            HomeworkLabel_View.Text = homeworktxtbox.Text;
            if (homeworktxtbox.Text != "")
            {
                h4 = double.Parse(homeworktxtbox.Text);
                h4 = (h4 * 100) / 20;
                if (h4 > 100)
                {
                    homework_grade.Text = "NaN";
                }
                else
                    homework_grade.Text = h4.ToString("0.0") + "%";

            }
            Done_Grade.Text = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4) + "%";
            m = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4);
            ///////////
            midLabel_View.Text = midtxtbox.Text;
            if (midtxtbox.Text != "")
            {
                h5 = double.Parse(midtxtbox.Text);
                h5 = (h5 * 100) / 50;
                if (h5 > 100)
                {
                    mid_grade.Text = "NaN";
                }
                else
                    mid_grade.Text = h5.ToString("0.0") + "%";
            }
            Done_Grade.Text = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4) + "%";
            m = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4); Deg.Text = degree(m);
            ///////////////
            finalLabel_View.Text = finaltxtbox.Text;
            if (finaltxtbox.Text != "")
            {
                h6 = double.Parse(finaltxtbox.Text);
                h6 = (h6 * 100) / 500;
                if (h6 > 100)
                {
                    final_grade.Text = "NaN";
                }
                else
                    final_grade.Text = h6.ToString("0.0") + "%";
            }
            Done_Grade.Text = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4) + "%";
            m = (h1 + h2 + h3 + h4 + h5) / 20 + h6 - (h6 / 4); Deg.Text = degree(m);
        }

        private void Show_Click(object sender, EventArgs e)
        {
        }


        private void finaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void attendance_grade_Click(object sender, EventArgs e)
        {

        }
        //Abdulsayed
        public class Node
        {
            public string name = "", id = "", degree = "";
            public Node? next;
        }
        internal class LinkedList
        {
            public int coun=0;
            public Node? head;
            public void insert(string name, string id, string degree)
            {
                Node temp = new Node();
                temp.name = name;
                temp.id = id;
                temp.degree = degree;
                if (head == null)
                {
                    head = temp;
                }
                Node? p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = temp;
                temp.next = null;
                coun++;
            }
            public void search(string id)
            {
                Node? p = head;
                bool found = false;
                while (p != null)
                {
                    if (id == p.id)
                    {
                        found = true;
                        break;
                    }
                    p = p.next;
                }
                if (found)
                {
                    MessageBox.Show( "Name : " + p.name + "\n" + "id : " + p.id +"\nYour degree is : " + p.degree, "Found!");
                }
                else
                {
                    MessageBox.Show("Not Found!");
                }
            }
            public void size()
            {
                Console.WriteLine("LinkedList size = {0}", coun);
            }

        }
    }
}
