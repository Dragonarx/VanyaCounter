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
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageCurrentGame = new TabPage();
            buttonRejectGame = new Button();
            buttonAcceptGame = new Button();
            listBoxCurrentGame = new ListBox();
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
            tabPageCurrentGame.SuspendLayout();
            tabDonations.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(5, 6);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(270, 304);
            listBoxPlayers.TabIndex = 0;
            listBoxPlayers.KeyDown += listBoxPlayers_KeyDown;
            listBoxPlayers.MouseDoubleClick += listBoxPlayers_MouseDoubleClick;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Location = new Point(281, 6);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(205, 40);
            buttonAddPlayer.TabIndex = 1;
            buttonAddPlayer.Text = "Добавить игрока";
            buttonAddPlayer.UseVisualStyleBackColor = true;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // textBoxNewPlayer
            // 
            textBoxNewPlayer.Location = new Point(281, 52);
            textBoxNewPlayer.Name = "textBoxNewPlayer";
            textBoxNewPlayer.PlaceholderText = "Введите имя игрока для добавления";
            textBoxNewPlayer.Size = new Size(205, 23);
            textBoxNewPlayer.TabIndex = 2;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(3, 316);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(270, 23);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Отсортировать по количеству игр";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonResetGames
            // 
            buttonResetGames.Location = new Point(3, 345);
            buttonResetGames.Name = "buttonResetGames";
            buttonResetGames.Size = new Size(270, 23);
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
            tabControl1.Location = new Point(8, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(500, 408);
            tabControl1.TabIndex = 7;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(label7);
            tabPageMain.Controls.Add(label3);
            tabPageMain.Controls.Add(label2);
            tabPageMain.Controls.Add(label1);
            tabPageMain.Controls.Add(buttonAddPlayer);
            tabPageMain.Controls.Add(buttonResetGames);
            tabPageMain.Controls.Add(listBoxPlayers);
            tabPageMain.Controls.Add(textBoxNewPlayer);
            tabPageMain.Controls.Add(buttonReset);
            tabPageMain.Location = new Point(4, 24);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(492, 380);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Основа";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 123);
            label7.Name = "label7";
            label7.Size = new Size(188, 15);
            label7.TabIndex = 11;
            label7.Text = "Двойной клик — переименовать";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 108);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 10;
            label3.Text = "Backspace — -1 игра";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 93);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 9;
            label2.Text = "Enter — +1 игра";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 78);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 8;
            label1.Text = "Del — удалить выделенного";
            // 
            // tabPageCurrentGame
            // 
            tabPageCurrentGame.Controls.Add(buttonRejectGame);
            tabPageCurrentGame.Controls.Add(buttonAcceptGame);
            tabPageCurrentGame.Controls.Add(listBoxCurrentGame);
            tabPageCurrentGame.Controls.Add(buttonAddToCurrentGame);
            tabPageCurrentGame.Controls.Add(comboBoxSearchPlayers);
            tabPageCurrentGame.Location = new Point(4, 24);
            tabPageCurrentGame.Name = "tabPageCurrentGame";
            tabPageCurrentGame.Padding = new Padding(3);
            tabPageCurrentGame.Size = new Size(492, 380);
            tabPageCurrentGame.TabIndex = 1;
            tabPageCurrentGame.Text = "Текущая игра";
            tabPageCurrentGame.UseVisualStyleBackColor = true;
            // 
            // buttonRejectGame
            // 
            buttonRejectGame.Location = new Point(6, 344);
            buttonRejectGame.Name = "buttonRejectGame";
            buttonRejectGame.Size = new Size(480, 23);
            buttonRejectGame.TabIndex = 4;
            buttonRejectGame.Text = "Отклонить игру";
            buttonRejectGame.UseVisualStyleBackColor = true;
            buttonRejectGame.Click += buttonRejectGame_Click;
            // 
            // buttonAcceptGame
            // 
            buttonAcceptGame.Location = new Point(6, 315);
            buttonAcceptGame.Name = "buttonAcceptGame";
            buttonAcceptGame.Size = new Size(480, 23);
            buttonAcceptGame.TabIndex = 3;
            buttonAcceptGame.Text = "Принять игру";
            buttonAcceptGame.UseVisualStyleBackColor = true;
            buttonAcceptGame.Click += buttonAcceptGame_Click;
            // 
            // listBoxCurrentGame
            // 
            listBoxCurrentGame.FormattingEnabled = true;
            listBoxCurrentGame.ItemHeight = 15;
            listBoxCurrentGame.Location = new Point(6, 35);
            listBoxCurrentGame.Name = "listBoxCurrentGame";
            listBoxCurrentGame.Size = new Size(480, 274);
            listBoxCurrentGame.TabIndex = 2;
            listBoxCurrentGame.KeyDown += listBoxCurrentGame_KeyDown;
            // 
            // buttonAddToCurrentGame
            // 
            buttonAddToCurrentGame.Location = new Point(311, 7);
            buttonAddToCurrentGame.Name = "buttonAddToCurrentGame";
            buttonAddToCurrentGame.Size = new Size(175, 23);
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
            comboBoxSearchPlayers.Location = new Point(6, 7);
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
            tabDonations.Size = new Size(492, 380);
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
            listBoxDonators.FormattingEnabled = true;
            listBoxDonators.ItemHeight = 15;
            listBoxDonators.Location = new Point(3, 3);
            listBoxDonators.Name = "listBoxDonators";
            listBoxDonators.Size = new Size(270, 364);
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
            MaximumSize = new Size(528, 459);
            MinimumSize = new Size(528, 459);
            Name = "Form1";
            Text = "VanyaCounter";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageMain.PerformLayout();
            tabPageCurrentGame.ResumeLayout(false);
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
        private Button buttonAcceptGame;
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
    }
}
