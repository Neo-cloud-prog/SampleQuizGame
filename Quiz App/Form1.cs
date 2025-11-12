using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class clsQuestions
        {
            public string Question { get; set; }
            public List<string> Answers { get; set; }
            public string CorrectAnswers { get; set; }
        }
        struct stGameInfo
        {
            public string DateTimeOfGame;
            public int CorrectAnswers;
            public int WrongAnswers;
            public int Time;
            public int BestTime;
        }
        private stGameInfo GameInfo;
        private List<clsQuestions> QuestionsList = new List<clsQuestions>();
        private int QuestionTracker = 0;
        private int Counter = 10;
        public List<int> Times = new List<int>();
        private void MakeQuestion(string Question, List<string> Answers, string CorrectAnswers)
        {
            clsQuestions Questions = new clsQuestions();
            Questions.Question = Question;
            Questions.Answers = Answers;
            Questions.CorrectAnswers = CorrectAnswers;
            QuestionsList.Add(Questions);
        }
        private void MakeQuestions()
        {
            List<string> Question1Answers = new List<string> { "Rigth Answer", "Answer 2", "Answer 3", "Answer 4" };
            MakeQuestion("Quetion 1", Question1Answers, "Rigth Answer");

            List<string> Question2Answers = new List<string> { "Answer 1", "Rigth Answer", "Answer 3", "Answer 4" };
            MakeQuestion("Quetion 2", Question2Answers, "Rigth Answer");

            List<string> Question3Answers = new List<string> { "Answer 1", "Answer 2", "Rigth Answer", "Answer 4" };
            MakeQuestion("Quetion 3", Question3Answers, "Rigth Answer");

            List<string> Question4Answers = new List<string> { "Answer 1", "Answer 2", "Answer 3", "Rigth Answer" };
            MakeQuestion("Quetion 4", Question4Answers, "Rigth Answer");
        }
        private void AddQuestionToUI()
        {
            lbQuestion.Text = QuestionsList[QuestionTracker].Question;
        }
        private void AddAnswersToUI()
        {
            rbAnswer1.Text = QuestionsList[QuestionTracker].Answers[0];
            rbAnswer2.Text = QuestionsList[QuestionTracker].Answers[1];
            rbAnswer3.Text = QuestionsList[QuestionTracker].Answers[2];
            rbAnswer4.Text = QuestionsList[QuestionTracker].Answers[3];
        }
        private void ChangeAnswerBackColor(RadioButton Target, Color BackColor)
        {
            Target.BackColor = BackColor;
        }
        private bool IsRightAnswer()
        {
            if (rbAnswer1.Checked)
            {
                if (rbAnswer1.Text == QuestionsList[QuestionTracker].CorrectAnswers)
                {
                    ChangeAnswerBackColor(rbAnswer1, Color.Green);
                    return true;
                }
                else
                {
                    ChangeAnswerBackColor(rbAnswer1, Color.Red);
                    return false;
                }
            } 
            else if (rbAnswer2.Checked)
            {
                if (rbAnswer2.Text == QuestionsList[QuestionTracker].CorrectAnswers)
                {
                    ChangeAnswerBackColor(rbAnswer2, Color.Green);
                    return true;
                }
                else
                {
                    ChangeAnswerBackColor(rbAnswer2, Color.Red);
                    return false;
                }
            } 
            else if (rbAnswer3.Checked)
            {
                if (rbAnswer3.Text == QuestionsList[QuestionTracker].CorrectAnswers)
                {
                    ChangeAnswerBackColor(rbAnswer3, Color.Green);
                    return true;
                }
                else
                {
                    ChangeAnswerBackColor(rbAnswer3, Color.Red);
                    return false;
                }
            }
            else
            {
                if (rbAnswer4.Text == QuestionsList[QuestionTracker].CorrectAnswers)
                {
                    ChangeAnswerBackColor(rbAnswer4, Color.Green);
                    return true;
                }
                else
                {
                    ChangeAnswerBackColor(rbAnswer4, Color.Red);
                    return false;
                }
            }
        }
        private void AddToCorrectAnswersCount(int CorrectAnswersCount)
        {
            lbCorrectAnswersCount.Text = CorrectAnswersCount.ToString();
        }
        private void AddToWrongAnswersCount(int WrongAnswersCoun)
        {
            lbWrongAnswersCount.Text = WrongAnswersCoun.ToString();
        }
        private void ReseteAnswersBackColor()
        {
            rbAnswer1.BackColor = Color.Transparent;
            rbAnswer2.BackColor = Color.Transparent;
            rbAnswer3.BackColor = Color.Transparent;
            rbAnswer4.BackColor = Color.Transparent;
        }
        private void ShowGameResult()
        {
            panel2.Visible = true;
            lbResult.Text = QuestionsList.Count + @" \ " + GameInfo.CorrectAnswers;
        }
        private void ClearHistoryGame()
        {
            lvHistoryGame.Items.Clear();
        }
        private void EndGame()
        {
            ShowGameResult();
            AddDataLineToFile();
            ClearHistoryGame();
            ShowAllHistoryGameList();
            timer1.Enabled = false;
            lbBestTime.Text = GetBestTime().ToString();
            progressBar1.Maximum = QuestionsList.Count;
        }
        private void RestartGame()
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = QuestionsList.Count;
            QuestionTracker = 0;
            panel2.Visible = false;
            AddAnswersToUI();
            AddQuestionToUI();
            GameInfo.CorrectAnswers = 0;
            GameInfo.WrongAnswers = 0;
            lbCorrectAnswersCount.Text = "0";
            lbWrongAnswersCount.Text = "0";
            rbAnswer1.Checked = true;
            Counter = 10;
            lbCounter.Text = "10";
            timer1.Enabled = true;
            rbAnswer1.BackColor = Color.Transparent;
            rbAnswer2.BackColor = Color.Transparent;
            rbAnswer3.BackColor = Color.Transparent;
            rbAnswer4.BackColor = Color.Transparent;
        }
        private string GetSystemDateTime()
        {
            DateTime CurrentDateTime = DateTime.Now;
            string CurrentDate = CurrentDateTime.ToString("dd/MM/yyyy");
            string CurrentTime = CurrentDateTime.ToString("HH:mm:ss");
            return CurrentDate + " " + CurrentTime;
        }
        private string ConvertRecordToLine(stGameInfo gameInfo, string Separator = "/##/")
        {
            string Line = "";
            Line += GameInfo.CorrectAnswers + Separator;
            Line += GameInfo.WrongAnswers + Separator;
            Line += GetSystemDateTime() + Separator;
            Line += Times.Count == 0 ? 0 : Times.Max();
            return Line;
        }
        private void AddDataLineToFile()
        {
            string FolderPath = "C:\\Users\\user\\Downloads";
            string FileName = "HistoryGame.txt";
            string FilePath = Path.Combine(FolderPath, FileName);
            using (FileStream fileStream = new FileStream(FilePath, FileMode.Append, FileAccess.Write))
            {
                string DataLine = ConvertRecordToLine(GameInfo);
                byte[] ByteData = Encoding.UTF8.GetBytes(DataLine + Environment.NewLine);
                fileStream.Write(ByteData, 0, ByteData.Length);
            }
        }
        private stGameInfo ConvertLineToRecord(string Line, string Separator = "/##/")
        {
            string[] SplitArray = Line.Split(new string[] { Separator }, StringSplitOptions.None);
            stGameInfo GameInfo = new stGameInfo();
            GameInfo.CorrectAnswers = Convert.ToInt32(SplitArray[0]);
            GameInfo.WrongAnswers = Convert.ToInt32(SplitArray[1]);
            GameInfo.DateTimeOfGame = SplitArray[2];
            GameInfo.Time = Convert.ToInt32(SplitArray[3]);
            return GameInfo;
        }
        private List<stGameInfo> LoadDataFromFile()
        {
            string FolderPath = "C:\\Users\\user\\Downloads";
            string FileName = "HistoryGame.txt";
            string FilePath = Path.Combine(FolderPath, FileName);
            List<stGameInfo> HistoryGameList = new List<stGameInfo>();
            using (StreamReader Reader = new StreamReader(FilePath))
            {
                string Line;
                while ((Line = Reader.ReadLine()) != null)
                {
                    HistoryGameList.Add(ConvertLineToRecord(Line));
                }
            }
            return HistoryGameList;
        }
        private void ShowAllHistoryGameList()
        {
            List<stGameInfo> HistoryGameList = LoadDataFromFile();
            if (HistoryGameList.Count == 0)
            {
                return;
            }
            int RoundCount = 0;
            foreach (stGameInfo HistoryGame in HistoryGameList)
            {
                RoundCount++;
                ListViewItem Item = new ListViewItem();
                Item.Text = "Round " + RoundCount.ToString();
                Item.SubItems.Add(HistoryGame.CorrectAnswers.ToString());
                Item.SubItems.Add(HistoryGame.WrongAnswers.ToString());
                Item.SubItems.Add(HistoryGame.DateTimeOfGame);
                Item.SubItems.Add(HistoryGame.Time.ToString());
                lvHistoryGame.Items.Add(Item);
            }
        }
        private int GetBestTime()
        {
            List<stGameInfo> GameInfoList = LoadDataFromFile();
            List <int> TimesList = new List<int>();
            int BestTime = 0;
            foreach(stGameInfo GameInfo in GameInfoList)
            {
                TimesList.Add(GameInfo.Time);
            }
            BestTime = TimesList.Max();
            return BestTime;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MakeQuestions();
            AddAnswersToUI();
            AddQuestionToUI();
            ShowAllHistoryGameList();
            timer1.Enabled = true;
            lbBestTime.Text = GetBestTime().ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Counter = 10;
            lbCounter.Text = "10";
            timer1.Enabled = true;
            btnNext.Enabled = false;
            rbAnswer1.Enabled = true;
            rbAnswer2.Enabled = true;
            rbAnswer3.Enabled = true;
            rbAnswer4.Enabled = true;
            progressBar1.Maximum = QuestionsList.Count;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                progressBar1.Refresh();
            }
            if (QuestionTracker != QuestionsList.Count - 1)
            {
                QuestionTracker++;
                AddAnswersToUI();
                AddQuestionToUI();
            } else
            {
                EndGame();
            }
            Times.Add(Convert.ToInt32(lbCounter.Tag));
            AddToCorrectAnswersCount(GameInfo.CorrectAnswers);
            AddToWrongAnswersCount(GameInfo.WrongAnswers);
            ReseteAnswersBackColor();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            rbAnswer1.Enabled = false;
            rbAnswer2.Enabled = false;
            rbAnswer3.Enabled = false;
            rbAnswer4.Enabled = false;
            if (IsRightAnswer())
            {
                GameInfo.CorrectAnswers++;
            }
            else
            {
                GameInfo.WrongAnswers++;
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            lbCounter.Text = Counter.ToString();
            lbCounter.Tag = Counter.ToString();
            progressBar1.Maximum = QuestionsList.Count;
            if (Counter == 0)
            {
                if (QuestionTracker != QuestionsList.Count - 1)
                {
                    QuestionTracker++;
                    AddAnswersToUI();
                    AddQuestionToUI();
                }
                else
                {
                    EndGame();
                }
                GameInfo.WrongAnswers++;
                AddToWrongAnswersCount(GameInfo.WrongAnswers);
                Counter = 10;
                lbCounter.Text = "10";
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value += 1;
                    progressBar1.Refresh();
                }
            }
        }
    }
}
