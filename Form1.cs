using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VanyaCounter
{
    public partial class Form1 : Form
    {
        private string dataFilePath = "players.txt";

        public Form1()
        {
            InitializeComponent();
            LoadPlayerList();
        }

        private void LoadPlayerList()
        {
            listBoxPlayers.Items.Clear();

            if (!File.Exists(dataFilePath))
                File.Create(dataFilePath).Close();

            var lines = File.ReadAllLines(dataFilePath);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    if (int.TryParse(parts[1], out int games))
                    {
                        listBoxPlayers.Items.Add($"Игрок: {name} — Игр: {games}");
                    }
                }
            }
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            string name = textBoxNewPlayer.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите имя игрока.");
                return;
            }

            var lines = File.ReadAllLines(dataFilePath).ToList();
            if (lines.Any(line => line.Split(';')[0].Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Такой игрок уже существует.");
                return;
            }

            lines.Add($"{name};0");
            File.WriteAllLines(dataFilePath, lines);
            LoadPlayerList();
            textBoxNewPlayer.Clear();
        }

        private void buttonIncreaseGame_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите игрока из списка.");
                return;
            }

            var selectedLine = listBoxPlayers.SelectedItem.ToString();
            var name = selectedLine.Split('—')[0].Replace("Игрок:", "").Trim();

            var lines = File.ReadAllLines(dataFilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(';');
                if (parts[0] == name && int.TryParse(parts[1], out int games))
                {
                    games++;
                    lines[i] = $"{name};{games}";
                    break;
                }
            }

            File.WriteAllLines(dataFilePath, lines);
            LoadPlayerList();
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите игрока для удаления.");
                return;
            }

            var selectedLine = listBoxPlayers.SelectedItem.ToString();
            var name = selectedLine.Split('—')[0].Replace("Игрок:", "").Trim();

            var lines = File.ReadAllLines(dataFilePath).ToList();
            lines = lines.Where(line => !line.StartsWith(name + ";")).ToList();

            File.WriteAllLines(dataFilePath, lines);
            LoadPlayerList();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dataFilePath))
                return;

            var lines = File.ReadAllLines(dataFilePath)
                .Where(line => !string.IsNullOrWhiteSpace(line) && line.Contains(';'))
                .Select(line =>
                {
                    var parts = line.Split(';');
                    string name = parts[0].Trim();
                    int games = int.TryParse(parts[1], out int g) ? g : 0;
                    return new { name, games };
                })
                .OrderByDescending(player => player.games)
                .ToList();

            File.WriteAllLines(dataFilePath, lines.Select(p => $"{p.name};{p.games}"));
            LoadPlayerList();
        }

        private void buttonResetGames_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите обнулить игры?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            var lines = File.ReadAllLines(dataFilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(';');
                if (parts.Length == 2)
                {
                    lines[i] = $"{parts[0]};0";
                }
            }

            File.WriteAllLines(dataFilePath, lines);
            LoadPlayerList();
        }

        private void UpdatePlayerDropdown()
        {
            if (!File.Exists(dataFilePath)) return;

            var names = File.ReadAllLines(dataFilePath)
                .Where(l => l.Contains(";"))
                .Select(l => l.Split(';')[0])
                .Distinct()
                .ToList();

            comboBoxSearchPlayers.Items.Clear();
            comboBoxSearchPlayers.Items.AddRange(names.ToArray());
        }

        private void buttonAddToCurrentGame_Click(object sender, EventArgs e)
        {
            string player = comboBoxSearchPlayers.Text.Trim();
            if (string.IsNullOrEmpty(player)) return;

            if (!listBoxCurrentGame.Items.Contains(player))
                listBoxCurrentGame.Items.Add(player);
        }

        private void buttonAcceptGame_Click(object sender, EventArgs e)
        {
            if (listBoxCurrentGame.Items.Count == 0) return;

            var lines = File.ReadAllLines(dataFilePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(';');
                if (parts.Length != 2) continue;

                string name = parts[0];
                if (listBoxCurrentGame.Items.Contains(name) && int.TryParse(parts[1], out int games))
                {
                    lines[i] = $"{name};{games + 1}";
                }
            }

            File.WriteAllLines(dataFilePath, lines);
            listBoxCurrentGame.Items.Clear();
            LoadPlayerList();
            UpdatePlayerDropdown();
        }

        private void buttonRejectGame_Click(object sender, EventArgs e)
        {
            listBoxCurrentGame.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayerList();
            UpdatePlayerDropdown();
        }

        private void comboBoxSearchPlayers_DropDown(object sender, EventArgs e)
        {
            string input = comboBoxSearchPlayers.Text.Trim().ToLower();

            if (!File.Exists(dataFilePath)) return;

            var players = File.ReadAllLines(dataFilePath)
                .Where(l => l.Contains(";"))
                .Select(l => l.Split(';')[0])
                .Distinct()
                .ToList();

            var sorted = players
                .OrderBy(p =>
                {
                    var lower = p.ToLower();
                    if (lower.StartsWith(input)) return 0;
                    if (lower.Contains(input)) return 1;
                    return 2;
                })
                .ThenBy(p => p)
                .ToList();

            comboBoxSearchPlayers.Items.Clear();
            comboBoxSearchPlayers.Items.AddRange(sorted.ToArray());

            comboBoxSearchPlayers.SelectionStart = comboBoxSearchPlayers.Text.Length;
        }

        private void buttonDecreaseGames_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите игрока из списка.");
                return;
            }

            var selectedLine = listBoxPlayers.SelectedItem.ToString();
            var name = selectedLine.Split('—')[0].Replace("Игрок:", "").Trim();

            var lines = File.ReadAllLines(dataFilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(';');
                if (parts[0] == name && int.TryParse(parts[1], out int games))
                {
                    if (games > 0)
                        games--;
                    lines[i] = $"{name};{games}";
                    break;
                }
            }

            File.WriteAllLines(dataFilePath, lines);
            LoadPlayerList();
        }
    }
}
