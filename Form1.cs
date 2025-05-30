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
        private string donatorFilePath = "donations.txt";
        private int donatorDragIndex = -1;

        public Form1()
        {
            InitializeComponent();
            LoadPlayerList();
            LoadDonatorList();
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption, string defaultText = "")
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterParent
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultText };
                Button confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };

                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text.Trim() : defaultText;
            }
        }

        private void LoadPlayerList()
        {
            if (!File.Exists(dataFilePath))
                File.WriteAllText(dataFilePath, "");

            if (!File.Exists(donatorFilePath))
                File.WriteAllText(donatorFilePath, "");

            var donators = File.ReadAllLines(donatorFilePath)
                               .Select(name => name.Trim())
                               .Where(name => !string.IsNullOrEmpty(name))
                               .ToList();

            var players = File.ReadAllLines(dataFilePath)
                              .Select(line =>
                              {
                                  var parts = line.Split(';');
                                  return new
                                  {
                                      Name = parts[0],
                                      Games = int.TryParse(parts[1], out int g) ? g : 0,
                                      DonatorIndex = donators.IndexOf(parts[0])  // -1 если не донатер
                                  };
                              })
                              .ToList();

            var sorted = players
                .OrderByDescending(p => p.Games)
                .ThenBy(p => p.DonatorIndex == -1 ? int.MaxValue : p.DonatorIndex)  // донатеры идут раньше
                .ThenBy(p => p.Name)  // остальные по алфавиту
                .Select(p => $"{p.Name} — Игр: {p.Games}")
                .ToArray();

            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(sorted);
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
            {
                listBoxCurrentGame.Items.Add(player);
            }

            // Добавление в список игроков, если его там нет
            var lines = File.ReadAllLines(dataFilePath).ToList();
            bool playerExists = lines.Any(line => line.Split(';')[0] == player);
            if (!playerExists)
            {
                lines.Add($"{player};0");
                File.WriteAllLines(dataFilePath, lines);
                LoadPlayerList();
            }

            comboBoxSearchPlayers.Text = "";
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

        private void listBoxPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && listBoxPlayers.SelectedItem != null)
            {
                Clipboard.SetText(listBoxPlayers.SelectedItem.ToString());
                return;
            }

            if (listBoxPlayers.SelectedItem == null) return;

            var selectedLine = listBoxPlayers.SelectedItem.ToString();
            var name = selectedLine.Split('—')[0].Replace("Игрок:", "").Trim();

            var lines = File.ReadAllLines(dataFilePath).ToList();

            if (e.KeyCode == Keys.Enter)
            {
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
                return;
            }

            if (e.KeyCode == Keys.Back)
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(';');
                    if (parts[0] == name && int.TryParse(parts[1], out int games))
                    {
                        if (games > 0)
                        {
                            games--;
                            lines[i] = $"{name};{games}";
                            File.WriteAllLines(dataFilePath, lines);
                            LoadPlayerList();
                        }
                        break;
                    }
                }
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                var confirm = MessageBox.Show($"Вы действительно хотите удалить игрока '{name}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                lines.RemoveAll(line => line.StartsWith(name + ";"));
                File.WriteAllLines(dataFilePath, lines);
                LoadPlayerList();
            }
        }

        private void listBoxCurrentGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (listBoxPlayers.SelectedItem != null)
                {
                    Clipboard.SetText(listBoxCurrentGame.SelectedItem.ToString());
                }
            }
            if (e.KeyCode == Keys.Delete && listBoxCurrentGame.SelectedItem != null)
            {
                var result = MessageBox.Show("Убрать игрока из текущей игры?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBoxCurrentGame.Items.Remove(listBoxCurrentGame.SelectedItem);
                }
            }
        }

        private void LoadDonatorList()
        {
            listBoxDonators.Items.Clear();
            if (File.Exists(donatorFilePath))
            {
                var donators = File.ReadAllLines(donatorFilePath)
                                   .Where(name => !string.IsNullOrWhiteSpace(name))
                                   .ToArray();
                listBoxDonators.Items.AddRange(donators);
            }
        }
        private void buttonAddDonator_Click(object sender, EventArgs e)
        {
            string donator = textBoxAddDonator.Text.Trim();
            if (string.IsNullOrEmpty(donator)) return;

            if (!listBoxDonators.Items.Contains(donator))
            {
                listBoxDonators.Items.Add(donator);
            }

            // Добавление в список донатеров
            var donators = File.ReadAllLines(donatorFilePath).ToList();
            if (!donators.Contains(donator))
            {
                donators.Add(donator);
                File.WriteAllLines(donatorFilePath, donators);
                LoadDonatorList();
            }

            // Также добавляем в список игроков, если отсутствует
            var lines = File.ReadAllLines(dataFilePath).ToList();
            if (!lines.Any(line => line.Split(';')[0] == donator))
            {
                lines.Add($"{donator};0");
                File.WriteAllLines(dataFilePath, lines);
                LoadPlayerList();
            }

            textBoxAddDonator.Text = "";
        }

        private void listBoxDonators_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBoxDonators.SelectedIndex != -1)
            {
                var selectedDonator = listBoxDonators.SelectedItem.ToString();
                var result = MessageBox.Show($"Удалить донатера \"{selectedDonator}\"?",
                                             "Подтверждение",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var donators = File.ReadAllLines(donatorFilePath).ToList();
                    donators.Remove(selectedDonator);
                    File.WriteAllLines(donatorFilePath, donators);
                    LoadDonatorList();
                    LoadPlayerList(); // Пересортировка
                }
            }
            if (e.KeyCode == Keys.Enter && listBoxDonators.SelectedIndex != -1)
            {
                var oldName = listBoxDonators.SelectedItem.ToString();
                string newName = Prompt.ShowDialog("Новое имя донатера:", "Переименование", oldName);

                if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                {
                    var donators = File.ReadAllLines(donatorFilePath).ToList();
                    int i = donators.IndexOf(oldName);
                    if (i >= 0)
                    {
                        donators[i] = newName;
                        File.WriteAllLines(donatorFilePath, donators);
                        LoadDonatorList();
                        LoadPlayerList(); // обновить, если имя есть в обоих
                    }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void listBoxDonators_MouseDown(object sender, MouseEventArgs e)
        {
            donatorDragIndex = listBoxDonators.IndexFromPoint(e.Location);
            if (donatorDragIndex != -1)
            {
                listBoxDonators.DoDragDrop(listBoxDonators.Items[donatorDragIndex], DragDropEffects.Move);
            }
        }

        private void listBoxDonators_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBoxDonators_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxDonators.PointToClient(new Point(e.X, e.Y));
            int index = listBoxDonators.IndexFromPoint(point);

            if (index < 0 || donatorDragIndex == -1 || donatorDragIndex == index)
                return;

            var donators = File.ReadAllLines(donatorFilePath).ToList();
            var item = donators[donatorDragIndex];
            donators.RemoveAt(donatorDragIndex);
            donators.Insert(index, item);

            File.WriteAllLines(donatorFilePath, donators);
            LoadDonatorList();
            LoadPlayerList();
        }

        private void listBoxPlayers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxPlayers.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var selectedLine = listBoxPlayers.Items[index].ToString();
                var oldName = selectedLine.Split('—')[0].Replace("Игрок:", "").Trim();

                string newName = Prompt.ShowDialog("Новое имя игрока:", "Переименование", oldName);
                if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                {
                    var lines = File.ReadAllLines(dataFilePath).ToList();
                    for (int i = 0; i < lines.Count; i++)
                    {
                        var parts = lines[i].Split(';');
                        if (parts[0] == oldName)
                        {
                            lines[i] = $"{newName};{parts[1]}";
                            break;
                        }
                    }
                    File.WriteAllLines(dataFilePath, lines);
                    LoadPlayerList();
                }
            }
        }
    }
}
