using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolgaIT_Kochetkov
{
    public partial class MainWindow : Form
    {
        public string pathDataSource = string.Empty;
        public string dataSourceType = string.Empty;
        public string htmlCode = string.Empty;
        public string sortType = "по уникальности";
        public string sortOrder = " ↓ ";
        Word wrd = new Word();

        public MainWindow()
        {
            InitializeComponent();
            localFileLabel.Select();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            Log.Write("DEBUG", "Программа закрыта");
        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Метод, который осуществляет переключение между источниками данных
        private void WorkWithSwitchDataSource(object sender, EventArgs e)
        {
            TextBox tbSender = null;
            ToolStripMenuItem tsmiSender = null;

            try
            {
                tbSender = (TextBox)sender;
            }
            catch
            {
                tsmiSender = (ToolStripMenuItem)sender;
            }

            if ((tbSender == webpageTextBox || tsmiSender == webpageTSMI) && webpageTextBox.Text != string.Empty)
            {
                goToStartProgram.Enabled = true;
                dataSourceType = "URL";
                localFileTextBox.BackColor = Color.Gainsboro;
                webpageTextBox.BackColor = Color.White;
                if (tsmiSender != null && (localFileTextBox.Focused || webpageTextBox.Focused)) webpageTextBox.Select();
            }
            if ((tbSender == localFileTextBox || tsmiSender == localFileTSMI) && localFileTextBox.Text != string.Empty)
            {
                goToStartProgram.Enabled = true;
                dataSourceType = "LocalFile";
                webpageTextBox.BackColor = Color.Gainsboro;
                localFileTextBox.BackColor = Color.White;
                if (tsmiSender != null && (localFileTextBox.Focused || webpageTextBox.Focused)) localFileTextBox.Select();
            }

            if (localFileTextBox.Text == string.Empty && webpageTextBox.Text == string.Empty)
            {
                webpageTextBox.BackColor = Color.White;
                localFileTextBox.BackColor = Color.White;
                dataSourceType = string.Empty;
            }
        }

        // Метод, который считывает URL/файл из источника данных 
        private void ReadHTMLCodeFromDataSource(object sender, EventArgs e)
        {
            htmlCode = string.Empty;
            if (dataSourceType == "URL")
            {
                try
                {
                    htmlCode = HTMLRead(webpageTextBox.Text).Trim();
                    Log.Write("INFO", $"Выбран веб-сайт: {webpageTextBox.Text}");
                    pathDataSource = webpageTextBox.Text;
                    CheckHTMLCode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введён недопустимый URL или отсутствует соединение с интернетом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Write("ERROR",  $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
                }
            }
            if (dataSourceType == "LocalFile")
            {
                try
                {
                    htmlCode = File.ReadAllText(localFileTextBox.Text).Trim();
                    Log.Write("INFO", $"Выбран локальный файл: {localFileTextBox.Text}");
                    pathDataSource = localFileTextBox.Text;
                    CheckHTMLCode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введён недопустимый путь файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Write("ERROR", $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
                }       
            }  
        }

        /// <summary>
        /// Метод, который проверяет переменную с URL/файлом на наличие данных
        /// Создаёт поток на обработку HTML кода
        /// </summary>
        public void CheckHTMLCode()
        {
            if (htmlCode != string.Empty)
            {
                try
                {
                    openFileTSMI.Enabled = false;
                    copyTSMI.Enabled = false;
                    saveInTSMI.Enabled = false;
                    settingsTMSI.Enabled = false;
                    groupBoxWithChoise.Enabled = false;
                    groupBoxWithTypeSort.Enabled = false;
                    goToStartProgram.Enabled = false;
                    goToPrintResult.Enabled = false;
                    goToSaveResult.Enabled = false;
                    wordCount.Enabled = false;

                    Thread threadCleaner = new Thread(CleanerCode);
                    threadCleaner.SetApartmentState(ApartmentState.STA);
                    threadCleaner.IsBackground = true;
                    threadCleaner.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Write("ERROR", $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("В указанном источнике данных отсутствуют данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write("ERROR", "В указанном источнике данных отсутствуют данные");
            }
        }

        /// <summary>
        /// Метод, который осуществляет считывание HTML кода с веб-страницы с использованием кодировки
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static string HTMLRead(string URL)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string codeURL = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return codeURL;
        }

        // Происходит смена типа или порядка сортировки данных
        private void WorkWithSwitchSort(object sender, EventArgs e)
        {
            RadioButton rbSender = null;
            ToolStripMenuItem tsmiSender = null;

            try
            {
                rbSender = (RadioButton)sender;
            }
            catch
            {
                tsmiSender = (ToolStripMenuItem)sender;
            }

            if (rbSender == sortingTypeUniqueness || tsmiSender == sortingTypeUniquenessTSMI)
            {
                if (tsmiSender != null) sortingTypeUniqueness.Checked = true;
                sortType = sortingTypeUniqueness.Text;
            }
            if (rbSender == sortingTypeAlphabetically || tsmiSender == sortingTypeAlphabeticallyTSMI)
            {
                if (tsmiSender != null) sortingTypeAlphabetically.Checked = true;
                sortType = sortingTypeAlphabetically.Text;
            }
            if (rbSender == sortingTypeLength || tsmiSender == sortingTypeLengthTSMI)
            {
                if (tsmiSender != null) sortingTypeLength.Checked = true;
                sortType = sortingTypeLength.Text;
            }
            if (rbSender == sortingOrderFromBiggest || tsmiSender == sortOrderFromBiggestTSMI)
            {
                if (tsmiSender != null) sortingOrderFromBiggest.Checked = true;
                sortOrder = sortingOrderFromBiggest.Text;
            }
            if (rbSender == sortingOrderFromLowest || tsmiSender == sortOrderFromLowestTSMI)
            {
                if (tsmiSender != null) sortingOrderFromLowest.Checked = true;
                sortOrder = sortingOrderFromLowest.Text;
            }
        }

        /// <summary>
        /// Потоковый метод, который очищает считанный HTML код от тегов, комментариев, знаков и прочего
        /// </summary>
        private void CleanerCode()
        {
            try
            {
                Log.Write("INFO", "Началась обработка HTML кода");
                DateTime timeStart = DateTime.Now;
                htmlCode = Regex.Replace(htmlCode, "<!--.*?-->", " ", RegexOptions.Singleline); // удаление HTML комментариев
                htmlCode = Regex.Replace(htmlCode, "<style.*?</style>", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); // удаление HTML стилей
                htmlCode = Regex.Replace(htmlCode, "<script.*?</script>", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); // удаление HTML скриптов
                htmlCode = Regex.Replace(htmlCode, "<[a-z!/].*?>", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); // удаление других HTML тегов
                if (removeURLSTSMI.Checked) htmlCode = Regex.Replace(htmlCode, @"\s*\S*[a-zа-я0-9][.][a-zа-я]\S*\s*", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase);  // удаление ссылок
                if (removeEmailsTSMI.Checked) htmlCode = Regex.Replace(htmlCode, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); // удаление emails
                if (removeDatesTSMI.Checked) htmlCode = Regex.Replace(htmlCode, @"\s+[0-9]+[:.,-][0-9]+", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); //удаление датировок
                if (removeSomeEnititesTSMI.Checked) // замена некоторых мнемоников на символы
                {
                    string[,] entities = new string[7, 3] { { "&minus;", "&#8722;", "−" },
                                                            { "&rsquo;", "&#8217;", "’" },
                                                            { "&none;", "&#&#45;", "-" },
                                                            { "&ndash;", "&#8211;", "–" },
                                                            { "&mdash;", "&#8212;", "—" },
                                                            { "&horbar;", "&#8213;", "―" },
                                                            { "&sol;", "&#47;", "/" }, };
                    for (int i = 0; i < 7; i++)
                    {
                        if (entities[i, 0] != "none") htmlCode = htmlCode.Replace(entities[i, 0], entities[i, 2]);
                        if (entities[i, 1] != "none") htmlCode = htmlCode.Replace(entities[i, 1], entities[i, 2]);
                    }
                }
                htmlCode = Regex.Replace(htmlCode, "&[a-z#].*?;", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); // удаление всех мнемоников
                htmlCode = Regex.Replace(htmlCode, @"[^a-z^а-я^0-9]+\s+", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase); // удаление лишних знаков
                htmlCode = Regex.Replace(htmlCode, @"\s+[^a-z^а-я^0-9]+", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                if (removeNumbersTSMI.Checked) // удаление чисел
                {
                    htmlCode = Regex.Replace(htmlCode, @"[^a-z^а-я^0-9]+\d\s+", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    htmlCode = Regex.Replace(htmlCode, @"\s+\d[^a-z^а-я^0-9]+", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    while (Regex.IsMatch(htmlCode, @"\s+\d+\s+")) htmlCode = Regex.Replace(htmlCode, @"\s+\d+\s+", " ", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                }
                htmlCode = Regex.Replace(htmlCode, @"\s+", " ", RegexOptions.Singleline | RegexOptions.Compiled); // замена множества пробелов на один

                string cleanedText = htmlCode.ToUpper().Trim();
                htmlCode = string.Empty;

                Log.Write("INFO", $"Завершена обработка HTML кода за: {DateTime.Now - timeStart}");

                // Отправление данных на сортировку и вывод рельзультата
                wrd.AddDataToList(cleanedText);
                wrd.SortData(sortType, sortOrder, true);
                wrd.CreateHiddenFile();
                OpenConsole();

                // Изменение GUI из потока
                goToStartProgram.BeginInvoke((Action)delegate ()
                {
                    openFileTSMI.Enabled = true;
                    copyTSMI.Enabled = true;
                    saveInTSMI.Enabled = true;
                    settingsTMSI.Enabled = true;
                    groupBoxWithChoise.Enabled = true;
                    groupBoxWithTypeSort.Enabled = true;
                    goToStartProgram.Enabled = true;
                    goToPrintResult.Enabled = true;
                    goToSaveResult.Enabled = true;
                    wordCount.Enabled = true;
                    dataProcessingTime.Visible = true;

                    wordCount.Value = wordCount.Maximum = wrd.Words.Count;
                    saveAllWords.Checked = true;

                    dataProcessingTime.Text = "время обработки: " + (DateTime.Now - timeStart).ToString(@"d\д\ hh\:mm\:ss\.fff").TrimStart('0', 'д').Trim();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write("ERROR", $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
            }
        }

        // 
        private void WorkWithSaveParameters(object sender, EventArgs e)
        {
            CheckBox cbSender = null;
            NumericUpDown nupSender = null;

            try
            {
                cbSender = (CheckBox)sender;
            }
            catch
            {
                nupSender = (NumericUpDown)sender;
            }

            if (cbSender == saveAllWords)
            {
                if (saveAllWords.Checked) wordCount.BackColor = Color.Gainsboro;
                else wordCount.BackColor = Color.White;

            }
            if (nupSender == wordCount)
            {
                wordCount.BackColor = Color.White;
                saveAllWords.Checked = false;
            }
        }

        // Вывод результата через консоль
        private void GoToOpenResult(object sender, EventArgs e)
        {
            SleepButton(sender);
            wrd.SortData(sortType, sortOrder, false);
            wrd.CreateHiddenFile();
            OpenConsole();
        }

        /// <summary>
        /// Открытие консольного приложения
        /// </summary>
        public void OpenConsole()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            proc.FileName = "Console.exe";
            try
            {
                Process.Start(proc);
            }
            catch
            {
                MessageBox.Show($"Не обнаружено консольное приложение {proc.FileName}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write("ERROR", $"Не обнаружено консольное приложение {proc.FileName}");
            }

            Log.Write("INFO", "Данные выведены в консольное приложение");
        }

        public int GetAmountWordsToSave()
        {
            int amountWords = 1;
            if (saveAllWords.Checked) amountWords = Convert.ToInt32(wordCount.Maximum);
            else amountWords = Convert.ToInt32(wordCount.Value.ToString());

            return amountWords;
        }

        /// <summary>
        /// Метод, который делает нажатую кнопку недоступной для использования в течение определённого времени
        /// </summary>
        /// <param name="sender"></param>
        public async void SleepButton(object sender)
        {
            Button bSender = (Button)sender;
            bSender.Enabled = false;
            await Task.Delay(750);
            bSender.Enabled = true;
        }

        // Сохранение результата
        private void GoToSaveResult(object sender, EventArgs e)
        {
            SleepButton(sender);
            wrd.SortData(sortType, sortOrder, false);
            wrd.CreateHiddenFile();

            int amountWords = GetAmountWordsToSave();

            string whereSave = string.Empty;
            if (saveInDatabase.Checked) whereSave = saveInDatabase.Text;
            if (saveInTextDocument.Checked) whereSave = saveInTextDocument.Text;
            if (saveInClipboard.Checked) whereSave = saveInClipboard.Text;

            wrd.SaveResult(whereSave, amountWords, pathDataSource, dataSourceType, sortType);
        }

        private void SaveResultFromTSMI(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmiSender = (ToolStripMenuItem)sender;
            int amountWords = GetAmountWordsToSave();

            if (tsmiSender == copyTSMI || tsmiSender == saveInClipboardTSMI) wrd.SaveResult(saveInClipboard.Text, amountWords, pathDataSource, dataSourceType, sortType);
            if (tsmiSender == saveInDatabaseTSMI) wrd.SaveResult(saveInDatabase.Text, amountWords, pathDataSource, dataSourceType, sortType);
            if (tsmiSender == saveInTextDocumentTSMI) wrd.SaveResult(saveInTextDocument.Text, amountWords, pathDataSource, dataSourceType, sortType);
        }

        private void GoToOpenFile(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "HTML file |*.html";
            if (res.ShowDialog() == DialogResult.OK) localFileTextBox.Text = res.FileName;
        }

        private void ComingSoon(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке", "В разработке", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutProgramTSMI(object sender, EventArgs e) // вывод "о программе"
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Log.Write("DEBUG", "Программа запущена");
        }
    }

    /// <summary>
    /// Класс, целью которого является работа с обработанной информацией
    /// </summary>
    public class Word
    {
        public List<Word> Words = new List<Word>();
        private string textWord;
        private int count;
        private string sortedType = string.Empty;
        private string sortedOrder = string.Empty;

        /// <summary>
        /// Метод, который осуществляет добавление информации в лист Words
        /// </summary>
        /// <param name="text"></param>
        public void AddDataToList(string text)
        {
            sortedType = string.Empty;
            sortedOrder = string.Empty;
            Words.Clear();

            try
            {
                string[] words = text.Split(' ');
                foreach (string word in words)
                {
                    // Ведём поиск индекса слова, которое присутствует в листе
                    var search = Words.Find(x => x.textWord == word);

                    // Если нет совпадения, то добавляем слово и количество повторов - единицу
                    // Если есть совпадение, то по индексу увеличиваем количество повторов на единицу
                    if (search == null) Words.Add(new Word() { textWord = word, count = 1 });
                    else Words[Words.IndexOf(search)].count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write("ERROR", $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
            }
        }

        /// <summary>
        /// Метод, который осуществляет сортировку информации прямо в листе в соответствии с выбранном вариантом сортировки
        /// </summary>
        /// <param name="sortType"></param>
        /// <param name="sortOrder"></param>
        /// <param name="sortAfterDataProcessing"></param>
        public void SortData(string sortType, string sortOrder, bool sortAfterDataProcessing)
        {
            // Условие, при котором избегается лишняя сортировка данных 
            if ((sortType != sortedType || sortOrder != sortedOrder) && (sortAfterDataProcessing || !sortAfterDataProcessing))
            {
                if (sortType == "по уникальности")
                {
                    if (sortOrder == " ↓ ") Words.Sort((w1, w2) => w2.count.CompareTo(w1.count));
                    if (sortOrder == " ↑ ") Words.Sort((w1, w2) => w1.count.CompareTo(w2.count));
                }
                if (sortType == "по алфавиту")
                {
                    if (sortOrder == " ↓ ") Words.Sort((w1, w2) => w1.textWord.CompareTo(w2.textWord));
                    if (sortOrder == " ↑ ") Words.Sort((w1, w2) => w2.textWord.CompareTo(w1.textWord));
                }
                if (sortType == "по длине")
                {
                    if (sortOrder == " ↓ ") Words.Sort((w1, w2) => w2.textWord.Length.CompareTo(w1.textWord.Length));
                    if (sortOrder == " ↑ ") Words.Sort((w1, w2) => w1.textWord.Length.CompareTo(w2.textWord.Length));
                }
                sortedType = sortType;
                sortedOrder = sortOrder;

                Log.Write("INFO", $"Данные отсортированы вариантом: {sortType}; порядок сортировки: {sortOrder}");
            }
        }

        /// <summary>
        /// Метод, который осуществляет сохранение информации в соответствии с выбранном вариантом сохранения
        /// </summary>
        /// <param name="whereSave"></param>
        /// <param name="amountWords"></param>
        /// <param name="pathFile"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="sortType"></param>
        public void SaveResult(string whereSave, int amountWords, string pathFile, string dataSourceType, string sortType)
        {
            if (whereSave == "В базу данных")
            {
                int IDSession = 0;
                string connectionString = @"Data Source=localhost;Initial Catalog=HTMLCodeReader;Integrated Security=True";

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Открываем асинхронное соединение с базой данных
                        Task connectionTask = null;
                        try
                        {
                            connectionTask = connection.OpenAsync();
                            Task.WaitAll(connectionTask);
                        }
                        catch
                        {
                            MessageBox.Show("Не удалось установить соединение с базой данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Log.Write("ERROR", "Не удалось установить соединение с базой данных");
                        }

                        // Если соединение произвелось успешно, то заполняем базу данных
                        if (!connectionTask.IsFaulted)
                        {
                            // Добавляем строку в таблицу Sessions
                            SqlCommand command = connection.CreateCommand();
                            string smalldatetime = string.Format("{0:yyyy.MM.dd HH:mm:ss}", DateTime.Now);
                            command.CommandText = $"INSERT INTO Sessions ([Path], [Data source type], [Sorting type], [Datetime]) VALUES('{pathFile}', '{dataSourceType}', '{sortType}', '{smalldatetime}')";
                            command.ExecuteNonQuery();

                            // Получаем код первичного ключа из новодобавленной строки
                            command.CommandText = $"SELECT [SessionID] FROM [Sessions]";
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                                while (reader.Read())
                                    IDSession = int.Parse(reader.GetValue(0).ToString());
                            reader.Close();

                            // Записываем слова в таблицу StatSession
                            for (int i = 0; i < amountWords; i++)
                            {
                                var wrd = Words[i];
                                command.CommandText = $"INSERT INTO [StatsSession] ([SessionID], [Word], [Count]) VALUES('{IDSession}', '{wrd.textWord}', '{wrd.count}')";
                                command.ExecuteNonQuery();
                            }
                            connection.Close();

                            MessageBox.Show($"Данные успешно были сохранены в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Log.Write("INFO", $"Данные сохранены следующим вариантом: {whereSave}; количество строк: {amountWords}; код сессии: {IDSession}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log.Write("ERROR", $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
                    }
                }
            }
            if (whereSave == "В текстовый документ")
            {
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saves");
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    string fileName = string.Format("{0:dd-MM-yyyy_HH-mm-ss}.txt", DateTime.Now);
                    string pathThisFile = Path.Combine(path, fileName);
                    string fullText = string.Empty;
                    for (int i = 0; i < amountWords; i++)
                    {
                        var wrd = Words[i];
                        fullText += $"{wrd.textWord} - {wrd.count}\n";
                    }
                    File.AppendAllText(pathThisFile, fullText, Encoding.GetEncoding("Windows-1251"));
                    File.SetAttributes(pathThisFile, FileAttributes.Compressed);

                    MessageBox.Show($"Данные успешно были сохранены в текстовый документ {pathThisFile}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log.Write("INFO", $"Данные сохранены следующим вариантом: {whereSave}; количество строк: {amountWords}; название документа: {fileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Write("ERROR", $"[{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}()] {ex.Message}");
                }
            }
            if (whereSave == "В буфер обмена")
            {
                string text = string.Empty;

                for (int i = 0; i < amountWords; i++)
                {
                    var wrd = Words[i];
                    text += $"{wrd.textWord} - {wrd.count}\n";
                }
                Clipboard.SetText(text);

                MessageBox.Show("Данные успешно были сохранены в буфер обмена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log.Write("INFO", $"Данные сохранены следующим вариантом: {whereSave}; количество строк: {amountWords}");
            }
        }

        /// <summary>
        /// Создание скрытого файла, в котором содержится информация о словах
        /// Необходимо для консольного приложения, которое выводит данные в соответствии с этим файлом
        /// </summary>
        public void CreateHiddenFile()
        {
            string path = "result.txt";
            FileStream fs = File.Open(path, File.Exists(path) ? FileMode.Truncate : FileMode.OpenOrCreate);
            File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.Compressed);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                foreach (var wrd in Words)
                    sw.WriteLine("{0} - {1}", wrd.textWord, wrd.count);
            fs.Close();
        }
    }
}

/// <summary>
/// Класс, метод которого является логирование действий приложения
/// </summary>
public class Log
{
    private static object sync = new object();
    public static void Write(string loggingLevel, string msg)
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            string filename = Path.Combine(path, string.Format("{0:dd.MM.yyy}.log", DateTime.Now));
            string fullText = string.Format("[{0:HH:mm:ss.fff}] [{1}] {2}\r", DateTime.Now, loggingLevel, msg);
            lock (sync)
            {
                File.AppendAllText(filename, fullText, Encoding.GetEncoding("Windows-1251"));
            }
            File.SetAttributes(filename, FileAttributes.Compressed);
        }
        catch { }
    }
}