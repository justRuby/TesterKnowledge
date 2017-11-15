namespace Tester
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameProgrammLabel = new System.Windows.Forms.Label();
            this.programImageButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.turnButton = new System.Windows.Forms.Button();
            this.testerTabControl = new System.Windows.Forms.TabControl();
            this.registrationTabPage = new System.Windows.Forms.TabPage();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.testerPictureBox = new System.Windows.Forms.PictureBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.errorRegistrationLabel = new System.Windows.Forms.Label();
            this.startTestButton = new System.Windows.Forms.Button();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.testingTabPage = new System.Windows.Forms.TabPage();
            this.testingPanel = new System.Windows.Forms.Panel();
            this.questionsListBox = new System.Windows.Forms.RichTextBox();
            this.answerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.answer4RadioButton = new System.Windows.Forms.RadioButton();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.answer1RadioButton = new System.Windows.Forms.RadioButton();
            this.answer3RadioButton = new System.Windows.Forms.RadioButton();
            this.answer2RadioButton = new System.Windows.Forms.RadioButton();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.finalTabPage = new System.Windows.Forms.TabPage();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.newButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.resultTestLabel = new System.Windows.Forms.Label();
            this.countTruAnswersLabel = new System.Windows.Forms.Label();
            this.fullNameFinalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programImageButton)).BeginInit();
            this.testerTabControl.SuspendLayout();
            this.registrationTabPage.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerPictureBox)).BeginInit();
            this.testingTabPage.SuspendLayout();
            this.testingPanel.SuspendLayout();
            this.answerTableLayoutPanel.SuspendLayout();
            this.finalTabPage.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.nameProgrammLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.programImageButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.exitButton, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.fullScreenButton, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.turnButton, 3, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 40);
            this.tableLayoutPanel.TabIndex = 4;
            this.tableLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.tableLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.tableLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // nameProgrammLabel
            // 
            this.nameProgrammLabel.AutoSize = true;
            this.nameProgrammLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProgrammLabel.ForeColor = System.Drawing.Color.Black;
            this.nameProgrammLabel.Location = new System.Drawing.Point(43, 0);
            this.nameProgrammLabel.Name = "nameProgrammLabel";
            this.nameProgrammLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.nameProgrammLabel.Size = new System.Drawing.Size(52, 30);
            this.nameProgrammLabel.TabIndex = 101;
            this.nameProgrammLabel.Text = "Tester";
            // 
            // programImageButton
            // 
            this.programImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.programImageButton.BackColor = System.Drawing.Color.Transparent;
            this.programImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("programImageButton.BackgroundImage")));
            this.programImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.programImageButton.Location = new System.Drawing.Point(7, 7);
            this.programImageButton.Name = "programImageButton";
            this.programImageButton.Size = new System.Drawing.Size(25, 25);
            this.programImageButton.TabIndex = 1;
            this.programImageButton.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(746, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 100;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullScreenButton.BackColor = System.Drawing.Color.Transparent;
            this.fullScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullScreenButton.BackgroundImage")));
            this.fullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullScreenButton.FlatAppearance.BorderSize = 0;
            this.fullScreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenButton.Location = new System.Drawing.Point(656, 5);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(30, 30);
            this.fullScreenButton.TabIndex = 99;
            this.fullScreenButton.UseVisualStyleBackColor = false;
            this.fullScreenButton.Visible = false;
            this.fullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // turnButton
            // 
            this.turnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.turnButton.BackColor = System.Drawing.Color.Transparent;
            this.turnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("turnButton.BackgroundImage")));
            this.turnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turnButton.FlatAppearance.BorderSize = 0;
            this.turnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.turnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnButton.Location = new System.Drawing.Point(701, 5);
            this.turnButton.Name = "turnButton";
            this.turnButton.Size = new System.Drawing.Size(30, 30);
            this.turnButton.TabIndex = 98;
            this.turnButton.UseVisualStyleBackColor = false;
            this.turnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // testerTabControl
            // 
            this.testerTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testerTabControl.Controls.Add(this.registrationTabPage);
            this.testerTabControl.Controls.Add(this.testingTabPage);
            this.testerTabControl.Controls.Add(this.finalTabPage);
            this.testerTabControl.Location = new System.Drawing.Point(7, 46);
            this.testerTabControl.Name = "testerTabControl";
            this.testerTabControl.SelectedIndex = 0;
            this.testerTabControl.Size = new System.Drawing.Size(769, 383);
            this.testerTabControl.TabIndex = 5;
            // 
            // registrationTabPage
            // 
            this.registrationTabPage.Controls.Add(this.registrationPanel);
            this.registrationTabPage.Location = new System.Drawing.Point(4, 22);
            this.registrationTabPage.Name = "registrationTabPage";
            this.registrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registrationTabPage.Size = new System.Drawing.Size(761, 337);
            this.registrationTabPage.TabIndex = 0;
            this.registrationTabPage.Text = "Регистрация";
            this.registrationTabPage.UseVisualStyleBackColor = true;
            // 
            // registrationPanel
            // 
            this.registrationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationPanel.Controls.Add(this.testerPictureBox);
            this.registrationPanel.Controls.Add(this.fullNameLabel);
            this.registrationPanel.Controls.Add(this.errorRegistrationLabel);
            this.registrationPanel.Controls.Add(this.startTestButton);
            this.registrationPanel.Controls.Add(this.registrationTextBox);
            this.registrationPanel.Location = new System.Drawing.Point(80, 20);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(600, 300);
            this.registrationPanel.TabIndex = 0;
            // 
            // testerPictureBox
            // 
            this.testerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("testerPictureBox.BackgroundImage")));
            this.testerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.testerPictureBox.Location = new System.Drawing.Point(181, 3);
            this.testerPictureBox.Name = "testerPictureBox";
            this.testerPictureBox.Size = new System.Drawing.Size(244, 109);
            this.testerPictureBox.TabIndex = 4;
            this.testerPictureBox.TabStop = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Enabled = false;
            this.fullNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.fullNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.fullNameLabel.Location = new System.Drawing.Point(190, 140);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(152, 17);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "Введите свою Фамилию";
            // 
            // errorRegistrationLabel
            // 
            this.errorRegistrationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorRegistrationLabel.AutoSize = true;
            this.errorRegistrationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorRegistrationLabel.ForeColor = System.Drawing.Color.Red;
            this.errorRegistrationLabel.Location = new System.Drawing.Point(276, 165);
            this.errorRegistrationLabel.Name = "errorRegistrationLabel";
            this.errorRegistrationLabel.Size = new System.Drawing.Size(149, 17);
            this.errorRegistrationLabel.TabIndex = 2;
            this.errorRegistrationLabel.Text = "Не введена Фамилия!";
            this.errorRegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorRegistrationLabel.Visible = false;
            // 
            // startTestButton
            // 
            this.startTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTestButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startTestButton.FlatAppearance.BorderSize = 0;
            this.startTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.startTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTestButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTestButton.Location = new System.Drawing.Point(181, 221);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(244, 48);
            this.startTestButton.TabIndex = 1;
            this.startTestButton.Text = "Поехали!";
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationTextBox.Location = new System.Drawing.Point(181, 137);
            this.registrationTextBox.MaxLength = 50;
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(244, 25);
            this.registrationTextBox.TabIndex = 0;
            this.registrationTextBox.TextChanged += new System.EventHandler(this.registrationTextBox_TextChanged);
            // 
            // testingTabPage
            // 
            this.testingTabPage.Controls.Add(this.testingPanel);
            this.testingTabPage.Location = new System.Drawing.Point(4, 22);
            this.testingTabPage.Name = "testingTabPage";
            this.testingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.testingTabPage.Size = new System.Drawing.Size(761, 357);
            this.testingTabPage.TabIndex = 1;
            this.testingTabPage.Text = "Тестирование";
            this.testingTabPage.UseVisualStyleBackColor = true;
            // 
            // testingPanel
            // 
            this.testingPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testingPanel.Controls.Add(this.timeLabel);
            this.testingPanel.Controls.Add(this.questionsListBox);
            this.testingPanel.Controls.Add(this.answerTableLayoutPanel);
            this.testingPanel.Controls.Add(this.questionNumberLabel);
            this.testingPanel.Location = new System.Drawing.Point(30, 6);
            this.testingPanel.Name = "testingPanel";
            this.testingPanel.Size = new System.Drawing.Size(700, 351);
            this.testingPanel.TabIndex = 1;
            // 
            // questionsListBox
            // 
            this.questionsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionsListBox.BackColor = System.Drawing.Color.White;
            this.questionsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.questionsListBox.Location = new System.Drawing.Point(30, 20);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.ReadOnly = true;
            this.questionsListBox.Size = new System.Drawing.Size(573, 99);
            this.questionsListBox.TabIndex = 4;
            this.questionsListBox.Text = "";
            // 
            // answerTableLayoutPanel
            // 
            this.answerTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerTableLayoutPanel.ColumnCount = 2;
            this.answerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.answerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.answerTableLayoutPanel.Controls.Add(this.answer4RadioButton, 0, 3);
            this.answerTableLayoutPanel.Controls.Add(this.nextQuestionButton, 1, 3);
            this.answerTableLayoutPanel.Controls.Add(this.answer1RadioButton, 0, 0);
            this.answerTableLayoutPanel.Controls.Add(this.answer3RadioButton, 0, 2);
            this.answerTableLayoutPanel.Controls.Add(this.answer2RadioButton, 0, 1);
            this.answerTableLayoutPanel.Location = new System.Drawing.Point(27, 125);
            this.answerTableLayoutPanel.Name = "answerTableLayoutPanel";
            this.answerTableLayoutPanel.RowCount = 4;
            this.answerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerTableLayoutPanel.Size = new System.Drawing.Size(654, 197);
            this.answerTableLayoutPanel.TabIndex = 3;
            // 
            // answer4RadioButton
            // 
            this.answer4RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answer4RadioButton.AutoSize = true;
            this.answer4RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer4RadioButton.FlatAppearance.BorderSize = 0;
            this.answer4RadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.answer4RadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.answer4RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer4RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.answer4RadioButton.Location = new System.Drawing.Point(3, 150);
            this.answer4RadioButton.Name = "answer4RadioButton";
            this.answer4RadioButton.Size = new System.Drawing.Size(573, 44);
            this.answer4RadioButton.TabIndex = 7;
            this.answer4RadioButton.Tag = "4";
            this.answer4RadioButton.Text = "Answer 4";
            this.answer4RadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.answer4RadioButton.UseVisualStyleBackColor = true;
            this.answer4RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nextQuestionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextQuestionButton.FlatAppearance.BorderSize = 0;
            this.nextQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.nextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextQuestionButton.Location = new System.Drawing.Point(582, 160);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(69, 34);
            this.nextQuestionButton.TabIndex = 2;
            this.nextQuestionButton.Text = "--->";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // answer1RadioButton
            // 
            this.answer1RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answer1RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.answer1RadioButton.Checked = true;
            this.answer1RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer1RadioButton.FlatAppearance.BorderSize = 0;
            this.answer1RadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.answer1RadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.answer1RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer1RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.answer1RadioButton.Location = new System.Drawing.Point(3, 3);
            this.answer1RadioButton.Name = "answer1RadioButton";
            this.answer1RadioButton.Size = new System.Drawing.Size(573, 43);
            this.answer1RadioButton.TabIndex = 4;
            this.answer1RadioButton.TabStop = true;
            this.answer1RadioButton.Tag = "1";
            this.answer1RadioButton.Text = "Answer 1";
            this.answer1RadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.answer1RadioButton.UseVisualStyleBackColor = true;
            this.answer1RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // answer3RadioButton
            // 
            this.answer3RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answer3RadioButton.AutoSize = true;
            this.answer3RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer3RadioButton.FlatAppearance.BorderSize = 0;
            this.answer3RadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.answer3RadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.answer3RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer3RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.answer3RadioButton.Location = new System.Drawing.Point(3, 101);
            this.answer3RadioButton.Name = "answer3RadioButton";
            this.answer3RadioButton.Size = new System.Drawing.Size(573, 43);
            this.answer3RadioButton.TabIndex = 6;
            this.answer3RadioButton.Tag = "3";
            this.answer3RadioButton.Text = "Answer 3";
            this.answer3RadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.answer3RadioButton.UseVisualStyleBackColor = true;
            this.answer3RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // answer2RadioButton
            // 
            this.answer2RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.answer2RadioButton.AutoSize = true;
            this.answer2RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer2RadioButton.FlatAppearance.BorderSize = 0;
            this.answer2RadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.answer2RadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.answer2RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer2RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.answer2RadioButton.Location = new System.Drawing.Point(3, 52);
            this.answer2RadioButton.Name = "answer2RadioButton";
            this.answer2RadioButton.Size = new System.Drawing.Size(573, 43);
            this.answer2RadioButton.TabIndex = 5;
            this.answer2RadioButton.Tag = "2";
            this.answer2RadioButton.Text = "Answer 2";
            this.answer2RadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.answer2RadioButton.UseVisualStyleBackColor = true;
            this.answer2RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.questionNumberLabel.Location = new System.Drawing.Point(27, 0);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(104, 17);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Question # {null}";
            // 
            // finalTabPage
            // 
            this.finalTabPage.Controls.Add(this.resultPanel);
            this.finalTabPage.Location = new System.Drawing.Point(4, 22);
            this.finalTabPage.Name = "finalTabPage";
            this.finalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.finalTabPage.Size = new System.Drawing.Size(761, 337);
            this.finalTabPage.TabIndex = 2;
            this.finalTabPage.Text = "Результат";
            this.finalTabPage.UseVisualStyleBackColor = true;
            // 
            // resultPanel
            // 
            this.resultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultPanel.Controls.Add(this.newButton);
            this.resultPanel.Controls.Add(this.repeatButton);
            this.resultPanel.Controls.Add(this.resultTestLabel);
            this.resultPanel.Controls.Add(this.countTruAnswersLabel);
            this.resultPanel.Controls.Add(this.fullNameFinalLabel);
            this.resultPanel.Location = new System.Drawing.Point(80, 20);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(600, 300);
            this.resultPanel.TabIndex = 1;
            // 
            // newButton
            // 
            this.newButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(418, 242);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 40);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "Сначала";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repeatButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.repeatButton.FlatAppearance.BorderSize = 0;
            this.repeatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.repeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.repeatButton.Location = new System.Drawing.Point(116, 242);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(100, 40);
            this.repeatButton.TabIndex = 3;
            this.repeatButton.Text = "Повтор";
            this.repeatButton.UseVisualStyleBackColor = false;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // resultTestLabel
            // 
            this.resultTestLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultTestLabel.AutoEllipsis = true;
            this.resultTestLabel.AutoSize = true;
            this.resultTestLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.resultTestLabel.Location = new System.Drawing.Point(113, 170);
            this.resultTestLabel.Name = "resultTestLabel";
            this.resultTestLabel.Size = new System.Drawing.Size(99, 17);
            this.resultTestLabel.TabIndex = 2;
            this.resultTestLabel.Text = "Результат {%%}";
            // 
            // countTruAnswersLabel
            // 
            this.countTruAnswersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countTruAnswersLabel.AutoEllipsis = true;
            this.countTruAnswersLabel.AutoSize = true;
            this.countTruAnswersLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.countTruAnswersLabel.Location = new System.Drawing.Point(113, 140);
            this.countTruAnswersLabel.Name = "countTruAnswersLabel";
            this.countTruAnswersLabel.Size = new System.Drawing.Size(233, 17);
            this.countTruAnswersLabel.TabIndex = 1;
            this.countTruAnswersLabel.Text = "Кол-во правильных ответов {0} из {1}";
            // 
            // fullNameFinalLabel
            // 
            this.fullNameFinalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameFinalLabel.AutoEllipsis = true;
            this.fullNameFinalLabel.AutoSize = true;
            this.fullNameFinalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameFinalLabel.Location = new System.Drawing.Point(111, 51);
            this.fullNameFinalLabel.Name = "fullNameFinalLabel";
            this.fullNameFinalLabel.Size = new System.Drawing.Size(407, 25);
            this.fullNameFinalLabel.TabIndex = 0;
            this.fullNameFinalLabel.Text = "Поздравляю {FullName} с пройденым тестом!";
            this.fullNameFinalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 30);
            this.panel1.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(27, 325);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(31, 17);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "__:__";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.testerTabControl);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programImageButton)).EndInit();
            this.testerTabControl.ResumeLayout(false);
            this.registrationTabPage.ResumeLayout(false);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerPictureBox)).EndInit();
            this.testingTabPage.ResumeLayout(false);
            this.testingPanel.ResumeLayout(false);
            this.testingPanel.PerformLayout();
            this.answerTableLayoutPanel.ResumeLayout(false);
            this.answerTableLayoutPanel.PerformLayout();
            this.finalTabPage.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.Label nameProgrammLabel;
        private System.Windows.Forms.PictureBox programImageButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button turnButton;
        private System.Windows.Forms.TabControl testerTabControl;
        private System.Windows.Forms.TabPage registrationTabPage;
        private System.Windows.Forms.TabPage testingTabPage;
        private System.Windows.Forms.TabPage finalTabPage;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Panel testingPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.Label errorRegistrationLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label fullNameFinalLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label countTruAnswersLabel;
        private System.Windows.Forms.Label resultTestLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.PictureBox testerPictureBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.TableLayoutPanel answerTableLayoutPanel;
        private System.Windows.Forms.RadioButton answer4RadioButton;
        private System.Windows.Forms.RadioButton answer1RadioButton;
        private System.Windows.Forms.RadioButton answer3RadioButton;
        private System.Windows.Forms.RadioButton answer2RadioButton;
        private System.Windows.Forms.RichTextBox questionsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
    }
}

