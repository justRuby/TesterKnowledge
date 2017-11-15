using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tester.Model;

namespace Tester
{
    public partial class Main : Form
    {
        private const int MAX_STEP = 25;
        private const int MAX_COUNT_ANSWERS = 4;

        Dictionary<int, Questions> questions = new Dictionary<int, Questions>();
        Dictionary<int, Answers> answers = new Dictionary<int, Answers>();

        private int step = 0;
        private int countTrue = 0;
        private int selectAnswer = 0;
        private int countTime = 1200; // 20 min

        public Main()
        {
            InitializeComponent();
            SetQuestionsAndAnswers();
            ViewQuestionsAndAnswers();
        }

        #region Перетаскивание формы

        Point prevMousePosition;
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                prevMousePosition = Control.MousePosition;
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point p = Control.MousePosition;
                this.Left += p.X - prevMousePosition.X;
                this.Top += p.Y - prevMousePosition.Y;
                prevMousePosition = p;
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Tool события (свернуть, развернуть, закрыть)
        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized))
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized) || WindowState.Equals(FormWindowState.Normal))
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти? Данные могут быть потеряны.", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        #endregion

        private void registrationTextBox_TextChanged(object sender, EventArgs e)
        {
           if((sender as TextBox).Text == "")
            {
                fullNameLabel.Visible = true;
            }
            else
            {
                fullNameLabel.Visible = false;
            }
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if(registrationTextBox.Text != "")
            {
                errorRegistrationLabel.Visible = false;
                testerTabControl.SelectedIndex = 1;
                SetTimeLeft();
                timer.Start();
            }
            else
            {
                errorRegistrationLabel.Visible = true;
            }
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (selectAnswer == answers[step].TrueAnswer)
            {
                countTrue++;
            }

            step++;

            if (step <= MAX_STEP)
            {
                ViewQuestionsAndAnswers();
            }

            if (step == MAX_STEP + 1)
            {
                Finally();
            }
        }

        private void SetQuestionsAndAnswers()
        {
            ///////Вопрос 1
            questions.Add(0, new Questions() { Question = "Инкапсуляция - это...." });
            answers.Add(0, new Answers()
            {
                Answer1 = "это система программирования, объединяющий вместе код и данные, " +
                "которыми он манипулирует, исключая как вмешательство извне, так и неправильное использование данных.",
                Answer2 = "это механизм программирования, объединяющий вместе код и облоко данных, " +
                "которыми он манипулирует.",
                Answer3 = "это механизм программирования, объединяющий вместе код и данные, " +
                "которыми он манипулирует, исключая как вмешательство извне, так и неправильное использование данных.",
                Answer4 = "это что-то другое....",
                TrueAnswer = 3
            });
            ///////Вопрос 2
            questions.Add(1, new Questions() { Question = "Наследование - это...." });
            answers.Add(1, new Answers()
            {
                Answer1 = "это процесс, в ходе которого один объект приобретает свойства другого объекта.",
                Answer2 = "это механизм, в ходе которого один объект получает свойства всех объектов.",
                Answer3 = "это процесс, в ходе которого один объект приобретает свойства другого объекта.",
                Answer4 = "это что-то другое... того чего тут нету!",
                TrueAnswer = 1
            });
            ///////Вопрос 3
            questions.Add(2, new Questions() { Question = "абстрактный метод — это ......, который не предусматривает реализации по умолчанию, а предлагает только сигнатуру." });
            answers.Add(2, new Answers()
            {
                Answer1 = "символ динамичного класса",
                Answer2 = "член базового класса",
                Answer3 = "аспект классов",
                Answer4 = "это что-то другое....",
                TrueAnswer = 2
            });
            ///////Вопрос 4
            questions.Add(3, new Questions() { Question = "Наследование обозначает способность языка ........... в сходной манере. "});
            answers.Add(3, new Answers()
            {
                Answer1 = "соединять воединно объекты",
                Answer2 = "трактовать связанные объекты",
                Answer3 = "конвертировать несвязанные объекты в другие объекты",
                Answer4 = "конвертировать связанные объекты в другие объекты",
                TrueAnswer = 2
            });
            ///////Вопрос 4
            questions.Add(4, new Questions()
            {
                Question = "Что такое переменная?"
            });
            answers.Add(4, new Answers()
            {
                Answer1 = "поименованная область памяти",
                Answer2 = "неадресуемая область памяти",
                Answer3 = "объединенная область памяти",
                Answer4 = "сокращаемая область памяти",
                TrueAnswer = 1
            });
            ///////Вопрос 5
            questions.Add(5, new Questions()
            {
                Question = "Сколько типо данных существует в языке программирования C#?"
            });
            answers.Add(5, new Answers()
            {
                Answer1 = "5",
                Answer2 = "3",
                Answer3 = "6",
                Answer4 = "0",
                TrueAnswer = 3
            });
            ///////Вопрос 6
            questions.Add(6, new Questions()
            {
                Question = "Переменная представляет собой ...... или ..... значение или ..... класса."
            });
            answers.Add(6, new Answers()
            {
                Answer1 = "числовое, строковое, объекта",
                Answer2 = "числовое, константное, объекта",
                Answer3 = "числовое, константное, сериализированного",
                Answer4 = "другое",
                TrueAnswer = 1
            });
            ///////Вопрос 7
            questions.Add(7, new Questions()
            {
                Question = "bool? b1 = true;\nbool b2 = false;\nb2 = b1;"
            });
            answers.Add(7, new Answers()
            {
                Answer1 = "true",
                Answer2 = "false",
                Answer3 = "возникнет ошибка на этапе компиляции",
                Answer4 = "другое",
                TrueAnswer = 3
            });
            ///////Вопрос 8
            questions.Add(8, new Questions()
            {
                Question = "Когда и почему использовать StringBuilder предпочтительнее чем string?"
            });
            answers.Add(8, new Answers()
            {
                Answer1 = "если строка редко изменяется",
                Answer2 = "если строка часто изменяется",
                Answer3 = "если строка содержит спецсимволы",
                Answer4 = "если строка содержит исключительно цифры",
                TrueAnswer = 2
            });
            ///////Вопрос 9
            questions.Add(9, new Questions()
            {
                Question = "Как происходит запись инкремента и декремента?"
            });
            answers.Add(9, new Answers()
            {
                Answer1 = "+/ -/",
                Answer2 = "++ --",
                Answer3 = "-+ +-",
                Answer4 = "(^_^)",
                TrueAnswer = 2
            });

            ///////Вопрос 10
            questions.Add(10, new Questions()
            {
                Question = "В чем разницы между постфиксными и префиксными операциями инкремента и декремента?"
            });
            answers.Add(10, new Answers()
            {
                Answer1 = "постфиксные выполняются сразу в отличие от префиксных",
                Answer2 = "разницы нету, они несут одинаковый смысл",
                Answer3 = "префиксные выполняются раньше префиксных",
                Answer4 = "незнаю",
                TrueAnswer = 2
            });
            ///////Вопрос 11
            questions.Add(11, new Questions()
            {
                Question = "Что такое тернарная операция?"
            });
            answers.Add(11, new Answers()
            {
                Answer1 = "логический оператор",
                Answer2 = "это тоже самое что if else",
                Answer3 = "что-то сложное, чего мы не проходили",
                Answer4 = "он представляет собой условный оператор",
                TrueAnswer = 4
            });
            ///////Вопрос 12
            questions.Add(12, new Questions()
            {
                Question = "Какие операторы вы знаете?"
            });
            answers.Add(12, new Answers()
            {
                Answer1 = "тернарный, логический, циклический, операторный и т.п.",
                Answer2 = "логический, тернарный, цикл с постусловием, оперативный и т.п.",
                Answer3 = "логический, тернарный, цикл с поступсловием, цикл c предусловием и т.п.",
                Answer4 = "i don't know",
                TrueAnswer = 3
            });
            ///////Вопрос 13
            questions.Add(13, new Questions()
            {
                Question = "Какие операторы цикла вы знаете?"
            });
            answers.Add(13, new Answers()
            {
                Answer1 = "for, foreach, if, else",
                Answer2 = "for, foreach, while, do while",
                Answer3 = "for и большего не дано",
                Answer4 = "for, foreach, if while, do else",
                TrueAnswer = 2
            });
            ///////Вопрос 14
            questions.Add(14, new Questions()
            {
                Question = "Что такое массив?"
            });
            answers.Add(14, new Answers()
            {
                Answer1 = "совокупность переменных одного типа",
                Answer2 = "совокупность переменных разного типа",
                Answer3 = "совокупность переменных статичного типа",
                Answer4 = "совокупность переменных динамичного типа",
                TrueAnswer = 1
            });
            ///////Вопрос 15
            questions.Add(15, new Questions()
            {
                Question = "Какими массивы бывают?"
            });
            answers.Add(15, new Answers()
            {
                Answer1 = "одномерными и бесконечными",
                Answer2 = "только одномерными",
                Answer3 = "одномерными и многомерными",
                Answer4 = "только двумерными",
                TrueAnswer = 3
            });
            ///////Вопрос 16
            questions.Add(16, new Questions()
            {
                Question = "Перечислите классы библиотеки .NET для обработки строк в языке C#."
            });
            answers.Add(16, new Answers()
            {
                Answer1 = "String, Char, Int, StringBuilder",
                Answer2 = "String, Decimal, StringBuilder",
                Answer3 = "String, Char, StringBuilder",
                Answer4 = "String , Char",
                TrueAnswer = 3
            });
            ///////Вопрос 17
            questions.Add(17, new Questions()
            {
                Question = "ООП это...."
            });
            answers.Add(17, new Answers()
            {
                Answer1 = "методология программирования, основанная на представлении программы в виде совокупности объектов",
                Answer2 = "инфология программирования, основанная на представлении системы в виде совокупности методов",
                Answer3 = "ксеология Объектно ориентированного программирования системы в виде совокупности методов",
                Answer4 = "Объектно ориентированное программирование",
                TrueAnswer = 1
            });
            ///////Вопрос 18
            questions.Add(18, new Questions()
            {
                Question = "Класс представляет собой шаблон, по которому определяется форма......"
            });
            answers.Add(18, new Answers()
            {
                Answer1 = "кирпича",
                Answer2 = "ссылки",
                Answer3 = "технологии",
                Answer4 = "объекта",
                TrueAnswer = 4
            });
            ///////Вопрос 19
            questions.Add(19, new Questions()
            {
                Question = "Класс Object....."
            });
            answers.Add(19, new Answers()
            {
                Answer1 = "который явно считается базовым классом для всех остальных методов и типов",
                Answer2 = "который неявно считается базовым классом для всех остальных классов и типов",
                Answer3 = "который явно считается статичным классом для всех остальных классов и типов",
                Answer4 = "который неявно считается динамичным классом для всех остальных классов и типов",
                TrueAnswer = 2
            });
            ///////Вопрос 20
            questions.Add(20, new Questions()
            {
                Question = "Какие режимы доступа существуют?"
            });
            answers.Add(20, new Answers()
            {
                Answer1 = "private, public, static, internal",
                Answer2 = "private, public, internal, static",
                Answer3 = "private, public, internal",
                Answer4 = "нету верных ответов",
                TrueAnswer = 4
            });
            ///////Вопрос 21
            questions.Add(21, new Questions()
            {
                Question = "Что такое интерфейс?"
            });
            answers.Add(21, new Answers()
            {
                Answer1 = "набор абстрактных методов",
                Answer2 = "набор статичных классов",
                Answer3 = "набор не статичных переменных",
                Answer4 = "набор слов",
                TrueAnswer = 1
            });
            ///////Вопрос 22
            questions.Add(22, new Questions()
            {
                Question = "Делегат это...."
            });
            answers.Add(22, new Answers()
            {
                Answer1 = "объект ссылающийся на метод",
                Answer2 = "метод ссылающийся на метод",
                Answer3 = "статичный метод ссылающийся на метод",
                Answer4 = "статичный объект ссылающийся на не статичный метод",
                TrueAnswer = 1
            });
            ///////Вопрос 23
            questions.Add(23, new Questions()
            {
                Question = "Событие это...."
            });
            answers.Add(23, new Answers()
            {
                Answer1 = "ручное уведомление о том, что произошло закрытие формы",
                Answer2 = "автоматическое уведомление о том, что произошло несколько действий в делегате",
                Answer3 = "уведомление о том, что произошло некоторое действие",
                Answer4 = "статичное уведомление о том, что произошла ошибка",
                TrueAnswer = 3
            });
            ///////Вопрос 24
            questions.Add(24, new Questions()
            {
                Question = "ArrayList это что?"
            });
            answers.Add(24, new Answers()
            {
                Answer1 = "Как не странно это класс",
                Answer2 = "Класс поддераживающий статичный массив",
                Answer3 = "Класс поддерживающий динамические массивы",
                Answer4 = "Объект ссылающийся на метод",
                TrueAnswer = 3
            });
            ///////Вопрос 25
            questions.Add(25, new Questions()
            {
                Question = "ICompare это интерфейс ......."
            });
            answers.Add(25, new Answers()
            {
                Answer1 = "сортировки объектов",
                Answer2 = "сортировки методов",
                Answer3 = "сложение объектов",
                Answer4 = "сравнивание методов",
                TrueAnswer = 1
            });
        }

        private void ViewQuestionsAndAnswers()
        {
            questionNumberLabel.Text = string.Format("Вопрос {0} из {1}", step, MAX_STEP);
            questionsListBox.Clear();
            questionsListBox.Text = questions[step].Question;
            answer1RadioButton.Text = answers[step].Answer1;
            answer2RadioButton.Text = answers[step].Answer2;
            answer3RadioButton.Text = answers[step].Answer3;
            answer4RadioButton.Text = answers[step].Answer4;
        }

        private void Finally()
        {
            fullNameFinalLabel.Text = string.Format("Поздравляю {0} с пройденым тестом!", registrationTextBox.Text);
            countTruAnswersLabel.Text = string.Format("Кол-во правильных ответов {0} из {1}", countTrue, MAX_STEP);
            double temp = Math.Round((float)countTrue / (float)MAX_STEP * 100f);
            resultTestLabel.Text = "Ваш результат: " + temp.ToString() + "%";
            testerTabControl.SelectedIndex = 2;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string temp = (sender as RadioButton).Tag.ToString();
            selectAnswer = int.Parse(temp);
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            ClearTest();
            testerTabControl.SelectedIndex = 1;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            registrationTextBox.Clear();
            ClearTest();
            testerTabControl.SelectedIndex = 0;
        }

        private void ClearTest()
        {
            step = 0;
            countTrue = 0;
            ViewQuestionsAndAnswers();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SetTimeLeft();
            if (countTime <= 0)
            {
                Finally();
            }
        }
        
        private void SetTimeLeft()
        {
            countTime--;
            var time = TimeSpan.FromSeconds(countTime);
            timeLabel.Text = string.Format("{0}:{1}", time.Minutes, time.Seconds);
        }
    }
}
