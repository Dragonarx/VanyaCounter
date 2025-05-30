namespace VanyaCounter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPlayers = new ListBox();
            buttonAddPlayer = new Button();
            textBoxNewPlayer = new TextBox();
            buttonReset = new Button();
            buttonResetGames = new Button();
            tabControl1 = new TabControl();
            tabPageMain = new TabPage();
            panel5 = new Panel();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageCurrentGame = new TabPage();
            panel4 = new Panel();
            listBoxCurrentGame = new ListBox();
            panel3 = new Panel();
            buttonAcceptGame = new Button();
            panel2 = new Panel();
            buttonRejectGame = new Button();
            panel1 = new Panel();
            buttonAddToCurrentGame = new Button();
            comboBoxSearchPlayers = new ComboBox();
            tabDonations = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxAddDonator = new TextBox();
            buttonAddDonator = new Button();
            listBoxDonators = new ListBox();
            tabControl1.SuspendLayout();
            tabPageMain.SuspendLayout();
            panel5.SuspendLayout();
            tabPageCurrentGame.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabDonations.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.Dock = DockStyle.Left;
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(3, 3);
            listBoxPlayers.MaximumSize = new Size(270, 600);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(270, 386);
            listBoxPlayers.TabIndex = 0;
            listBoxPlayers.KeyDown += listBoxPlayers_KeyDown;
            listBoxPlayers.MouseDoubleClick += listBoxPlayers_MouseDoubleClick;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Location = new Point(276, 6);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(225, 40);
            buttonAddPlayer.TabIndex = 1;
            buttonAddPlayer.Text = "Добавить игрока";
            buttonAddPlayer.UseVisualStyleBackColor = true;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // textBoxNewPlayer
            // 
            textBoxNewPlayer.Location = new Point(276, 52);
            textBoxNewPlayer.Name = "textBoxNewPlayer";
            textBoxNewPlayer.PlaceholderText = "Введите имя игрока для добавления";
            textBoxNewPlayer.Size = new Size(225, 23);
            textBoxNewPlayer.TabIndex = 2;
            // 
            // buttonReset
            // 
            buttonReset.Dock = DockStyle.Bottom;
            buttonReset.Location = new Point(3, 13);
            buttonReset.MaximumSize = new Size(225, 23);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(222, 23);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Отсортировать по количеству игр";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonResetGames
            // 
            buttonResetGames.Dock = DockStyle.Bottom;
            buttonResetGames.Location = new Point(3, 36);
            buttonResetGames.MaximumSize = new Size(225, 23);
            buttonResetGames.Name = "buttonResetGames";
            buttonResetGames.Size = new Size(222, 23);
            buttonResetGames.TabIndex = 6;
            buttonResetGames.Text = "Обнулить игры";
            buttonResetGames.UseVisualStyleBackColor = true;
            buttonResetGames.Click += buttonResetGames_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMain);
            tabControl1.Controls.Add(tabPageCurrentGame);
            tabControl1.Controls.Add(tabDonations);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(512, 420);
            tabControl1.TabIndex = 7;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(panel5);
            tabPageMain.Controls.Add(label7);
            tabPageMain.Controls.Add(label3);
            tabPageMain.Controls.Add(label2);
            tabPageMain.Controls.Add(label1);
            tabPageMain.Controls.Add(buttonAddPlayer);
            tabPageMain.Controls.Add(listBoxPlayers);
            tabPageMain.Controls.Add(textBoxNewPlayer);
            tabPageMain.Location = new Point(4, 24);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(504, 392);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Основа";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonReset);
            panel5.Controls.Add(buttonResetGames);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(273, 325);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(3, 0, 3, 5);
            panel5.Size = new Size(228, 64);
            panel5.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 123);
            label7.Name = "label7";
            label7.Size = new Size(188, 15);
            label7.TabIndex = 11;
            label7.Text = "Двойной клик — переименовать";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 108);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 10;
            label3.Text = "Backspace — -1 игра";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 93);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 9;
            label2.Text = "Enter — +1 игра";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 78);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 8;
            label1.Text = "Del — удалить выделенного";
            // 
            // tabPageCurrentGame
            // 
            tabPageCurrentGame.Controls.Add(panel4);
            tabPageCurrentGame.Controls.Add(panel3);
            tabPageCurrentGame.Controls.Add(panel2);
            tabPageCurrentGame.Controls.Add(panel1);
            tabPageCurrentGame.Location = new Point(4, 24);
            tabPageCurrentGame.Name = "tabPageCurrentGame";
            tabPageCurrentGame.Padding = new Padding(3);
            tabPageCurrentGame.Size = new Size(504, 392);
            tabPageCurrentGame.TabIndex = 1;
            tabPageCurrentGame.Text = "Текущая игра";
            tabPageCurrentGame.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBoxCurrentGame);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 31);
            panel4.MaximumSize = new Size(498, 600);
            panel4.Name = "panel4";
            panel4.Size = new Size(498, 294);
            panel4.TabIndex = 10;
            // 
            // listBoxCurrentGame
            // 
            listBoxCurrentGame.Dock = DockStyle.Fill;
            listBoxCurrentGame.FormattingEnabled = true;
            listBoxCurrentGame.ItemHeight = 15;
            listBoxCurrentGame.Location = new Point(0, 0);
            listBoxCurrentGame.MaximumSize = new Size(498, 600);
            listBoxCurrentGame.Name = "listBoxCurrentGame";
            listBoxCurrentGame.Size = new Size(498, 294);
            listBoxCurrentGame.TabIndex = 2;
            listBoxCurrentGame.KeyDown += listBoxCurrentGame_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonAcceptGame);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 325);
            panel3.MaximumSize = new Size(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 35);
            panel3.TabIndex = 9;
            // 
            // buttonAcceptGame
            // 
            buttonAcceptGame.Dock = DockStyle.Bottom;
            buttonAcceptGame.Location = new Point(0, 12);
            buttonAcceptGame.MaximumSize = new Size(498, 23);
            buttonAcceptGame.Name = "buttonAcceptGame";
            buttonAcceptGame.Size = new Size(498, 23);
            buttonAcceptGame.TabIndex = 4;
            buttonAcceptGame.Text = "Принять игру";
            buttonAcceptGame.UseVisualStyleBackColor = true;
            buttonAcceptGame.Click += buttonAcceptGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonRejectGame);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 360);
            panel2.MaximumSize = new Size(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 29);
            panel2.TabIndex = 8;
            // 
            // buttonRejectGame
            // 
            buttonRejectGame.Dock = DockStyle.Bottom;
            buttonRejectGame.Location = new Point(0, 6);
            buttonRejectGame.MaximumSize = new Size(498, 23);
            buttonRejectGame.Name = "buttonRejectGame";
            buttonRejectGame.Size = new Size(498, 23);
            buttonRejectGame.TabIndex = 3;
            buttonRejectGame.Text = "Отклонить игру";
            buttonRejectGame.UseVisualStyleBackColor = true;
            buttonRejectGame.Click += buttonRejectGame_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAddToCurrentGame);
            panel1.Controls.Add(comboBoxSearchPlayers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 28);
            panel1.TabIndex = 7;
            // 
            // buttonAddToCurrentGame
            // 
            buttonAddToCurrentGame.Location = new Point(300, 3);
            buttonAddToCurrentGame.MaximumSize = new Size(200, 23);
            buttonAddToCurrentGame.Name = "buttonAddToCurrentGame";
            buttonAddToCurrentGame.Size = new Size(193, 23);
            buttonAddToCurrentGame.TabIndex = 1;
            buttonAddToCurrentGame.Text = "Добавить игрока";
            buttonAddToCurrentGame.UseVisualStyleBackColor = true;
            buttonAddToCurrentGame.Click += buttonAddToCurrentGame_Click;
            // 
            // comboBoxSearchPlayers
            // 
            comboBoxSearchPlayers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSearchPlayers.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            comboBoxSearchPlayers.FormattingEnabled = true;
            comboBoxSearchPlayers.Location = new Point(0, 3);
            comboBoxSearchPlayers.MaximumSize = new Size(299, 0);
            comboBoxSearchPlayers.Name = "comboBoxSearchPlayers";
            comboBoxSearchPlayers.Size = new Size(299, 23);
            comboBoxSearchPlayers.TabIndex = 0;
            comboBoxSearchPlayers.DropDown += comboBoxSearchPlayers_DropDown;
            // 
            // tabDonations
            // 
            tabDonations.Controls.Add(label6);
            tabDonations.Controls.Add(label5);
            tabDonations.Controls.Add(label4);
            tabDonations.Controls.Add(textBoxAddDonator);
            tabDonations.Controls.Add(buttonAddDonator);
            tabDonations.Controls.Add(listBoxDonators);
            tabDonations.Location = new Point(4, 24);
            tabDonations.Name = "tabDonations";
            tabDonations.Size = new Size(504, 392);
            tabDonations.TabIndex = 2;
            tabDonations.Text = "Топ донатеры";
            tabDonations.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 132);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 10;
            label6.Text = "Enter — Переименовать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 117);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 9;
            label5.Text = "Del — Удалить выделенного";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 75);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 4;
            label4.Text = "Список донатеров можно \r\nперетаскивать через лкм";
            // 
            // textBoxAddDonator
            // 
            textBoxAddDonator.Location = new Point(279, 49);
            textBoxAddDonator.Name = "textBoxAddDonator";
            textBoxAddDonator.PlaceholderText = "Введите имя игрока для добавления";
            textBoxAddDonator.Size = new Size(205, 23);
            textBoxAddDonator.TabIndex = 3;
            // 
            // buttonAddDonator
            // 
            buttonAddDonator.Location = new Point(279, 3);
            buttonAddDonator.Name = "buttonAddDonator";
            buttonAddDonator.Size = new Size(205, 40);
            buttonAddDonator.TabIndex = 2;
            buttonAddDonator.Text = "Добавить игрока";
            buttonAddDonator.UseVisualStyleBackColor = true;
            buttonAddDonator.Click += buttonAddDonator_Click;
            // 
            // listBoxDonators
            // 
            listBoxDonators.AllowDrop = true;
            listBoxDonators.Dock = DockStyle.Left;
            listBoxDonators.FormattingEnabled = true;
            listBoxDonators.ItemHeight = 15;
            listBoxDonators.Location = new Point(0, 0);
            listBoxDonators.MaximumSize = new Size(270, 600);
            listBoxDonators.Name = "listBoxDonators";
            listBoxDonators.Size = new Size(270, 392);
            listBoxDonators.TabIndex = 0;
            listBoxDonators.DragDrop += listBoxDonators_DragDrop;
            listBoxDonators.DragOver += listBoxDonators_DragOver;
            listBoxDonators.KeyDown += listBoxDonators_KeyDown;
            listBoxDonators.MouseDown += listBoxDonators_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 420);
            Controls.Add(tabControl1);
            MaximumSize = new Size(528, 600);
            MinimumSize = new Size(528, 459);
            Name = "Form1";
            Text = "VanyaCounter";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageMain.PerformLayout();
            panel5.ResumeLayout(false);
            tabPageCurrentGame.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabDonations.ResumeLayout(false);
            tabDonations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPlayers;
        private Button buttonAddPlayer;
        private TextBox textBoxNewPlayer;
        private Button buttonReset;
        private Button buttonResetGames;
        private TabControl tabControl1;
        private TabPage tabPageMain;
        private TabPage tabPageCurrentGame;
        private ComboBox comboBoxSearchPlayers;
        private Button buttonRejectGame;
        private ListBox listBoxCurrentGame;
        private Button buttonAddToCurrentGame;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabDonations;
        private ListBox listBoxDonators;
        private Label label4;
        private TextBox textBoxAddDonator;
        private Button buttonAddDonator;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button buttonAcceptGame;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
    }
}
