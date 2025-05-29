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
            buttonIncreaseGame = new Button();
            buttonDeletePlayer = new Button();
            buttonResetGames = new Button();
            tabControl1 = new TabControl();
            tabPageMain = new TabPage();
            buttonDecreaseGames = new Button();
            tabPageCurrentGame = new TabPage();
            buttonRejectGame = new Button();
            buttonAcceptGame = new Button();
            listBoxCurrentGame = new ListBox();
            buttonAddToCurrentGame = new Button();
            comboBoxSearchPlayers = new ComboBox();
            tabControl1.SuspendLayout();
            tabPageMain.SuspendLayout();
            tabPageCurrentGame.SuspendLayout();
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
            textBoxNewPlayer.Size = new Size(205, 23);
            textBoxNewPlayer.TabIndex = 2;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(3, 316);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(270, 23);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Отсортировать список";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonIncreaseGame
            // 
            buttonIncreaseGame.Location = new Point(281, 81);
            buttonIncreaseGame.Name = "buttonIncreaseGame";
            buttonIncreaseGame.Size = new Size(205, 39);
            buttonIncreaseGame.TabIndex = 4;
            buttonIncreaseGame.Text = "+1 счётчик игр";
            buttonIncreaseGame.UseVisualStyleBackColor = true;
            buttonIncreaseGame.Click += buttonIncreaseGame_Click;
            // 
            // buttonDeletePlayer
            // 
            buttonDeletePlayer.Location = new Point(281, 171);
            buttonDeletePlayer.Name = "buttonDeletePlayer";
            buttonDeletePlayer.Size = new Size(205, 39);
            buttonDeletePlayer.TabIndex = 5;
            buttonDeletePlayer.Text = "Удалить выбранного игрока";
            buttonDeletePlayer.UseVisualStyleBackColor = true;
            buttonDeletePlayer.Click += buttonDeletePlayer_Click;
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
            tabControl1.Location = new Point(8, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(500, 408);
            tabControl1.TabIndex = 7;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(buttonDecreaseGames);
            tabPageMain.Controls.Add(buttonAddPlayer);
            tabPageMain.Controls.Add(buttonResetGames);
            tabPageMain.Controls.Add(listBoxPlayers);
            tabPageMain.Controls.Add(buttonDeletePlayer);
            tabPageMain.Controls.Add(textBoxNewPlayer);
            tabPageMain.Controls.Add(buttonIncreaseGame);
            tabPageMain.Controls.Add(buttonReset);
            tabPageMain.Location = new Point(4, 24);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(492, 380);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Основа";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // buttonDecreaseGames
            // 
            buttonDecreaseGames.Location = new Point(281, 126);
            buttonDecreaseGames.Name = "buttonDecreaseGames";
            buttonDecreaseGames.Size = new Size(205, 39);
            buttonDecreaseGames.TabIndex = 7;
            buttonDecreaseGames.Text = "-1 счётчик игр";
            buttonDecreaseGames.UseVisualStyleBackColor = true;
            buttonDecreaseGames.Click += buttonDecreaseGames_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPlayers;
        private Button buttonAddPlayer;
        private TextBox textBoxNewPlayer;
        private Button buttonReset;
        private Button buttonIncreaseGame;
        private Button buttonDeletePlayer;
        private Button buttonResetGames;
        private TabControl tabControl1;
        private TabPage tabPageMain;
        private TabPage tabPageCurrentGame;
        private ComboBox comboBoxSearchPlayers;
        private Button buttonRejectGame;
        private Button buttonAcceptGame;
        private ListBox listBoxCurrentGame;
        private Button buttonAddToCurrentGame;
        private Button buttonDecreaseGames;
    }
}
