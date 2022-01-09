namespace VolgaIT_Kochetkov
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInDatabaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInTextDocumentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInClipboardTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.choiceSourceDataTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.webpageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.localFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sortTypesTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingTypeUniquenessTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingTypeAlphabeticallyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingTypeLengthTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.порядокСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortOrderFromBiggestTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sortOrderFromLowestTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsFiltrationTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeURLSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNumbersTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmailsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSomeEnititesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.scale70TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.scale100TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.scale150TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.scale200TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.scale250TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.scale300TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundStyleTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.darkTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.goToStartProgram = new System.Windows.Forms.Button();
            this.webpageTextBox = new System.Windows.Forms.TextBox();
            this.localFileTextBox = new System.Windows.Forms.TextBox();
            this.webpageLabel = new System.Windows.Forms.Label();
            this.goToOverviewPath = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxWithChoise = new System.Windows.Forms.GroupBox();
            this.localFileLabel = new System.Windows.Forms.Label();
            this.groupBoxWithOptionsSave = new System.Windows.Forms.GroupBox();
            this.saveInClipboard = new System.Windows.Forms.RadioButton();
            this.goToSaveResult = new System.Windows.Forms.Button();
            this.wordCount = new System.Windows.Forms.NumericUpDown();
            this.saveAllWords = new System.Windows.Forms.CheckBox();
            this.saveInDatabase = new System.Windows.Forms.RadioButton();
            this.saveInTextDocument = new System.Windows.Forms.RadioButton();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.groupBoxWithTypeSort = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label_hehe = new System.Windows.Forms.Label();
            this.sortingOrderFromLowest = new System.Windows.Forms.RadioButton();
            this.sortingOrderFromBiggest = new System.Windows.Forms.RadioButton();
            this.sortingTypeLength = new System.Windows.Forms.RadioButton();
            this.sortingTypeUniqueness = new System.Windows.Forms.RadioButton();
            this.sortingTypeAlphabetically = new System.Windows.Forms.RadioButton();
            this.goToPrintResult = new System.Windows.Forms.Button();
            this.dataProcessingTime = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBoxWithChoise.SuspendLayout();
            this.groupBoxWithOptionsSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordCount)).BeginInit();
            this.groupBoxWithTypeSort.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.settingsTMSI,
            this.viewTMSI,
            this.aboutProgramTSMI});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(661, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileTSMI
            // 
            this.fileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileTSMI,
            this.copyTSMI,
            this.saveInTSMI,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileTSMI.Name = "fileTSMI";
            this.fileTSMI.Size = new System.Drawing.Size(48, 20);
            this.fileTSMI.Text = "Файл";
            // 
            // openFileTSMI
            // 
            this.openFileTSMI.Name = "openFileTSMI";
            this.openFileTSMI.Size = new System.Drawing.Size(151, 22);
            this.openFileTSMI.Text = "Открыть";
            this.openFileTSMI.Click += new System.EventHandler(this.GoToOpenFile);
            // 
            // copyTSMI
            // 
            this.copyTSMI.Enabled = false;
            this.copyTSMI.Name = "copyTSMI";
            this.copyTSMI.Size = new System.Drawing.Size(151, 22);
            this.copyTSMI.Text = "Скопировать";
            this.copyTSMI.Click += new System.EventHandler(this.SaveResultFromTSMI);
            // 
            // saveInTSMI
            // 
            this.saveInTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInDatabaseTSMI,
            this.saveInTextDocumentTSMI,
            this.saveInClipboardTSMI});
            this.saveInTSMI.Enabled = false;
            this.saveInTSMI.Name = "saveInTSMI";
            this.saveInTSMI.Size = new System.Drawing.Size(151, 22);
            this.saveInTSMI.Text = "Сохранить в...";
            // 
            // saveInDatabaseTSMI
            // 
            this.saveInDatabaseTSMI.Name = "saveInDatabaseTSMI";
            this.saveInDatabaseTSMI.Size = new System.Drawing.Size(187, 22);
            this.saveInDatabaseTSMI.Text = "SQL Server";
            this.saveInDatabaseTSMI.Click += new System.EventHandler(this.SaveResultFromTSMI);
            // 
            // saveInTextDocumentTSMI
            // 
            this.saveInTextDocumentTSMI.Name = "saveInTextDocumentTSMI";
            this.saveInTextDocumentTSMI.Size = new System.Drawing.Size(187, 22);
            this.saveInTextDocumentTSMI.Text = "Текстовый документ";
            this.saveInTextDocumentTSMI.Click += new System.EventHandler(this.SaveResultFromTSMI);
            // 
            // saveInClipboardTSMI
            // 
            this.saveInClipboardTSMI.Name = "saveInClipboardTSMI";
            this.saveInClipboardTSMI.Size = new System.Drawing.Size(187, 22);
            this.saveInClipboardTSMI.Text = "Буфер обмена";
            this.saveInClipboardTSMI.Click += new System.EventHandler(this.SaveResultFromTSMI);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.AppExit);
            // 
            // settingsTMSI
            // 
            this.settingsTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choiceSourceDataTMSI,
            this.sortTypesTMSI,
            this.порядокСортировкиToolStripMenuItem,
            this.toolStripMenuItem2,
            this.settingsFiltrationTMSI});
            this.settingsTMSI.Name = "settingsTMSI";
            this.settingsTMSI.Size = new System.Drawing.Size(79, 20);
            this.settingsTMSI.Text = "Настройки";
            // 
            // choiceSourceDataTMSI
            // 
            this.choiceSourceDataTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webpageTSMI,
            this.localFileTSMI});
            this.choiceSourceDataTMSI.Name = "choiceSourceDataTMSI";
            this.choiceSourceDataTMSI.Size = new System.Drawing.Size(240, 22);
            this.choiceSourceDataTMSI.Text = "Выбор источника данных";
            // 
            // webpageTSMI
            // 
            this.webpageTSMI.Name = "webpageTSMI";
            this.webpageTSMI.Size = new System.Drawing.Size(169, 22);
            this.webpageTSMI.Text = "Веб-страница";
            this.webpageTSMI.Click += new System.EventHandler(this.WorkWithSwitchDataSource);
            // 
            // localFileTSMI
            // 
            this.localFileTSMI.Name = "localFileTSMI";
            this.localFileTSMI.Size = new System.Drawing.Size(169, 22);
            this.localFileTSMI.Text = "Локальный файл";
            this.localFileTSMI.Click += new System.EventHandler(this.WorkWithSwitchDataSource);
            // 
            // sortTypesTMSI
            // 
            this.sortTypesTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortingTypeUniquenessTSMI,
            this.sortingTypeAlphabeticallyTSMI,
            this.sortingTypeLengthTSMI});
            this.sortTypesTMSI.Name = "sortTypesTMSI";
            this.sortTypesTMSI.Size = new System.Drawing.Size(240, 22);
            this.sortTypesTMSI.Text = "Варианты сортировки данных";
            // 
            // sortingTypeUniquenessTSMI
            // 
            this.sortingTypeUniquenessTSMI.Name = "sortingTypeUniquenessTSMI";
            this.sortingTypeUniquenessTSMI.Size = new System.Drawing.Size(168, 22);
            this.sortingTypeUniquenessTSMI.Text = "по уникальности";
            this.sortingTypeUniquenessTSMI.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortingTypeAlphabeticallyTSMI
            // 
            this.sortingTypeAlphabeticallyTSMI.Name = "sortingTypeAlphabeticallyTSMI";
            this.sortingTypeAlphabeticallyTSMI.Size = new System.Drawing.Size(168, 22);
            this.sortingTypeAlphabeticallyTSMI.Text = "по алфавиту";
            this.sortingTypeAlphabeticallyTSMI.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortingTypeLengthTSMI
            // 
            this.sortingTypeLengthTSMI.Name = "sortingTypeLengthTSMI";
            this.sortingTypeLengthTSMI.Size = new System.Drawing.Size(168, 22);
            this.sortingTypeLengthTSMI.Text = "по длине";
            this.sortingTypeLengthTSMI.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // порядокСортировкиToolStripMenuItem
            // 
            this.порядокСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortOrderFromBiggestTSMI,
            this.sortOrderFromLowestTSMI});
            this.порядокСортировкиToolStripMenuItem.Name = "порядокСортировкиToolStripMenuItem";
            this.порядокСортировкиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.порядокСортировкиToolStripMenuItem.Text = "Порядок сортировки";
            // 
            // sortOrderFromBiggestTSMI
            // 
            this.sortOrderFromBiggestTSMI.Name = "sortOrderFromBiggestTSMI";
            this.sortOrderFromBiggestTSMI.Size = new System.Drawing.Size(166, 22);
            this.sortOrderFromBiggestTSMI.Text = "от наибольшего";
            this.sortOrderFromBiggestTSMI.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortOrderFromLowestTSMI
            // 
            this.sortOrderFromLowestTSMI.Name = "sortOrderFromLowestTSMI";
            this.sortOrderFromLowestTSMI.Size = new System.Drawing.Size(166, 22);
            this.sortOrderFromLowestTSMI.Text = "от наименьшего";
            this.sortOrderFromLowestTSMI.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // settingsFiltrationTMSI
            // 
            this.settingsFiltrationTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeURLSTSMI,
            this.removeDatesTSMI,
            this.removeNumbersTSMI,
            this.removeEmailsTSMI,
            this.removeSomeEnititesTSMI});
            this.settingsFiltrationTMSI.Name = "settingsFiltrationTMSI";
            this.settingsFiltrationTMSI.Size = new System.Drawing.Size(240, 22);
            this.settingsFiltrationTMSI.Text = "Параметры фильтрации кода";
            // 
            // removeURLSTSMI
            // 
            this.removeURLSTSMI.Checked = true;
            this.removeURLSTSMI.CheckOnClick = true;
            this.removeURLSTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeURLSTSMI.Name = "removeURLSTSMI";
            this.removeURLSTSMI.Size = new System.Drawing.Size(359, 22);
            this.removeURLSTSMI.Text = "Удаление URL";
            // 
            // removeDatesTSMI
            // 
            this.removeDatesTSMI.Checked = true;
            this.removeDatesTSMI.CheckOnClick = true;
            this.removeDatesTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeDatesTSMI.Name = "removeDatesTSMI";
            this.removeDatesTSMI.Size = new System.Drawing.Size(359, 22);
            this.removeDatesTSMI.Text = "Удаление числовых датировок";
            // 
            // removeNumbersTSMI
            // 
            this.removeNumbersTSMI.Checked = true;
            this.removeNumbersTSMI.CheckOnClick = true;
            this.removeNumbersTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeNumbersTSMI.Name = "removeNumbersTSMI";
            this.removeNumbersTSMI.Size = new System.Drawing.Size(359, 22);
            this.removeNumbersTSMI.Text = "Удаление отдельных чисел";
            // 
            // removeEmailsTSMI
            // 
            this.removeEmailsTSMI.Checked = true;
            this.removeEmailsTSMI.CheckOnClick = true;
            this.removeEmailsTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeEmailsTSMI.Name = "removeEmailsTSMI";
            this.removeEmailsTSMI.Size = new System.Drawing.Size(359, 22);
            this.removeEmailsTSMI.Text = "Удаление электронных адресов";
            // 
            // removeSomeEnititesTSMI
            // 
            this.removeSomeEnititesTSMI.Checked = true;
            this.removeSomeEnititesTSMI.CheckOnClick = true;
            this.removeSomeEnititesTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeSomeEnititesTSMI.Name = "removeSomeEnititesTSMI";
            this.removeSomeEnititesTSMI.Size = new System.Drawing.Size(359, 22);
            this.removeSomeEnititesTSMI.Text = "Замена некоторых мнемоников на соотв. символы";
            // 
            // viewTMSI
            // 
            this.viewTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleTMSI,
            this.backgroundStyleTMSI});
            this.viewTMSI.Name = "viewTMSI";
            this.viewTMSI.Size = new System.Drawing.Size(39, 20);
            this.viewTMSI.Text = "Вид";
            // 
            // scaleTMSI
            // 
            this.scaleTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scale70TSMI,
            this.scale100TSMI,
            this.scale150TSMI,
            this.scale200TSMI,
            this.scale250TSMI,
            this.scale300TSMI});
            this.scaleTMSI.Name = "scaleTMSI";
            this.scaleTMSI.Size = new System.Drawing.Size(139, 22);
            this.scaleTMSI.Text = "Масштаб";
            // 
            // scale70TSMI
            // 
            this.scale70TSMI.Name = "scale70TSMI";
            this.scale70TSMI.Size = new System.Drawing.Size(102, 22);
            this.scale70TSMI.Text = "70%";
            this.scale70TSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // scale100TSMI
            // 
            this.scale100TSMI.Name = "scale100TSMI";
            this.scale100TSMI.Size = new System.Drawing.Size(102, 22);
            this.scale100TSMI.Text = "100%";
            this.scale100TSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // scale150TSMI
            // 
            this.scale150TSMI.Name = "scale150TSMI";
            this.scale150TSMI.Size = new System.Drawing.Size(102, 22);
            this.scale150TSMI.Text = "150%";
            this.scale150TSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // scale200TSMI
            // 
            this.scale200TSMI.Name = "scale200TSMI";
            this.scale200TSMI.Size = new System.Drawing.Size(102, 22);
            this.scale200TSMI.Text = "200%";
            this.scale200TSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // scale250TSMI
            // 
            this.scale250TSMI.Name = "scale250TSMI";
            this.scale250TSMI.Size = new System.Drawing.Size(102, 22);
            this.scale250TSMI.Text = "250%";
            this.scale250TSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // scale300TSMI
            // 
            this.scale300TSMI.Name = "scale300TSMI";
            this.scale300TSMI.Size = new System.Drawing.Size(102, 22);
            this.scale300TSMI.Text = "300%";
            this.scale300TSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // backgroundStyleTMSI
            // 
            this.backgroundStyleTMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteTSMI,
            this.darkTSMI});
            this.backgroundStyleTMSI.Name = "backgroundStyleTMSI";
            this.backgroundStyleTMSI.Size = new System.Drawing.Size(139, 22);
            this.backgroundStyleTMSI.Text = "Стиль фона";
            // 
            // whiteTSMI
            // 
            this.whiteTSMI.Name = "whiteTSMI";
            this.whiteTSMI.Size = new System.Drawing.Size(122, 22);
            this.whiteTSMI.Text = "Светлый";
            this.whiteTSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // darkTSMI
            // 
            this.darkTSMI.Name = "darkTSMI";
            this.darkTSMI.Size = new System.Drawing.Size(122, 22);
            this.darkTSMI.Text = "Тёмный";
            this.darkTSMI.Click += new System.EventHandler(this.ComingSoon);
            // 
            // aboutProgramTSMI
            // 
            this.aboutProgramTSMI.Name = "aboutProgramTSMI";
            this.aboutProgramTSMI.Size = new System.Drawing.Size(94, 20);
            this.aboutProgramTSMI.Text = "О программе";
            this.aboutProgramTSMI.Click += new System.EventHandler(this.AboutProgramTSMI);
            // 
            // goToStartProgram
            // 
            this.goToStartProgram.Enabled = false;
            this.goToStartProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToStartProgram.Location = new System.Drawing.Point(12, 285);
            this.goToStartProgram.Name = "goToStartProgram";
            this.goToStartProgram.Size = new System.Drawing.Size(407, 43);
            this.goToStartProgram.TabIndex = 9;
            this.goToStartProgram.Text = "Начать обработку";
            this.goToStartProgram.UseVisualStyleBackColor = true;
            this.goToStartProgram.Click += new System.EventHandler(this.ReadHTMLCodeFromDataSource);
            // 
            // webpageTextBox
            // 
            this.webpageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webpageTextBox.Location = new System.Drawing.Point(137, 33);
            this.webpageTextBox.MaxLength = 128;
            this.webpageTextBox.Name = "webpageTextBox";
            this.webpageTextBox.Size = new System.Drawing.Size(204, 22);
            this.webpageTextBox.TabIndex = 1;
            this.webpageTextBox.Click += new System.EventHandler(this.WorkWithSwitchDataSource);
            this.webpageTextBox.TextChanged += new System.EventHandler(this.WorkWithSwitchDataSource);
            // 
            // localFileTextBox
            // 
            this.localFileTextBox.AccessibleDescription = "";
            this.localFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localFileTextBox.Location = new System.Drawing.Point(137, 68);
            this.localFileTextBox.MaxLength = 128;
            this.localFileTextBox.Name = "localFileTextBox";
            this.localFileTextBox.Size = new System.Drawing.Size(204, 22);
            this.localFileTextBox.TabIndex = 2;
            this.localFileTextBox.Click += new System.EventHandler(this.WorkWithSwitchDataSource);
            this.localFileTextBox.TextChanged += new System.EventHandler(this.WorkWithSwitchDataSource);
            // 
            // webpageLabel
            // 
            this.webpageLabel.AutoSize = true;
            this.webpageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webpageLabel.Location = new System.Drawing.Point(32, 36);
            this.webpageLabel.Name = "webpageLabel";
            this.webpageLabel.Size = new System.Drawing.Size(99, 16);
            this.webpageLabel.TabIndex = 4;
            this.webpageLabel.Text = "Веб-страница";
            // 
            // goToOverviewPath
            // 
            this.goToOverviewPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goToOverviewPath.BackgroundImage")));
            this.goToOverviewPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goToOverviewPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToOverviewPath.Location = new System.Drawing.Point(347, 66);
            this.goToOverviewPath.Name = "goToOverviewPath";
            this.goToOverviewPath.Size = new System.Drawing.Size(25, 25);
            this.goToOverviewPath.TabIndex = 3;
            this.goToOverviewPath.UseVisualStyleBackColor = true;
            this.goToOverviewPath.Click += new System.EventHandler(this.GoToOpenFile);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxWithChoise
            // 
            this.groupBoxWithChoise.Controls.Add(this.localFileLabel);
            this.groupBoxWithChoise.Controls.Add(this.localFileTextBox);
            this.groupBoxWithChoise.Controls.Add(this.webpageLabel);
            this.groupBoxWithChoise.Controls.Add(this.goToOverviewPath);
            this.groupBoxWithChoise.Controls.Add(this.webpageTextBox);
            this.groupBoxWithChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWithChoise.Location = new System.Drawing.Point(12, 43);
            this.groupBoxWithChoise.Name = "groupBoxWithChoise";
            this.groupBoxWithChoise.Size = new System.Drawing.Size(407, 109);
            this.groupBoxWithChoise.TabIndex = 0;
            this.groupBoxWithChoise.TabStop = false;
            this.groupBoxWithChoise.Text = "Выбор источника данных";
            // 
            // localFileLabel
            // 
            this.localFileLabel.AutoSize = true;
            this.localFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localFileLabel.Location = new System.Drawing.Point(13, 71);
            this.localFileLabel.Name = "localFileLabel";
            this.localFileLabel.Size = new System.Drawing.Size(118, 16);
            this.localFileLabel.TabIndex = 6;
            this.localFileLabel.Text = "Локальный файл";
            // 
            // groupBoxWithOptionsSave
            // 
            this.groupBoxWithOptionsSave.Controls.Add(this.saveInClipboard);
            this.groupBoxWithOptionsSave.Controls.Add(this.goToSaveResult);
            this.groupBoxWithOptionsSave.Controls.Add(this.wordCount);
            this.groupBoxWithOptionsSave.Controls.Add(this.saveAllWords);
            this.groupBoxWithOptionsSave.Controls.Add(this.saveInDatabase);
            this.groupBoxWithOptionsSave.Controls.Add(this.saveInTextDocument);
            this.groupBoxWithOptionsSave.Controls.Add(this.wordCountLabel);
            this.groupBoxWithOptionsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWithOptionsSave.Location = new System.Drawing.Point(434, 43);
            this.groupBoxWithOptionsSave.Name = "groupBoxWithOptionsSave";
            this.groupBoxWithOptionsSave.Size = new System.Drawing.Size(215, 236);
            this.groupBoxWithOptionsSave.TabIndex = 0;
            this.groupBoxWithOptionsSave.TabStop = false;
            this.groupBoxWithOptionsSave.Text = "Параметры сохранения";
            // 
            // saveInClipboard
            // 
            this.saveInClipboard.AutoSize = true;
            this.saveInClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInClipboard.Location = new System.Drawing.Point(13, 151);
            this.saveInClipboard.Name = "saveInClipboard";
            this.saveInClipboard.Size = new System.Drawing.Size(133, 20);
            this.saveInClipboard.TabIndex = 15;
            this.saveInClipboard.Text = "В буфер обмена";
            this.saveInClipboard.UseVisualStyleBackColor = true;
            // 
            // goToSaveResult
            // 
            this.goToSaveResult.Enabled = false;
            this.goToSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToSaveResult.Location = new System.Drawing.Point(18, 187);
            this.goToSaveResult.Name = "goToSaveResult";
            this.goToSaveResult.Size = new System.Drawing.Size(179, 33);
            this.goToSaveResult.TabIndex = 16;
            this.goToSaveResult.Text = "Сохранить";
            this.goToSaveResult.UseVisualStyleBackColor = true;
            this.goToSaveResult.Click += new System.EventHandler(this.GoToSaveResult);
            // 
            // wordCount
            // 
            this.wordCount.BackColor = System.Drawing.Color.Gainsboro;
            this.wordCount.Enabled = false;
            this.wordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordCount.Location = new System.Drawing.Point(139, 30);
            this.wordCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.wordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(61, 22);
            this.wordCount.TabIndex = 11;
            this.wordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordCount.ValueChanged += new System.EventHandler(this.WorkWithSaveParameters);
            // 
            // saveAllWords
            // 
            this.saveAllWords.AutoSize = true;
            this.saveAllWords.Checked = true;
            this.saveAllWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveAllWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveAllWords.Location = new System.Drawing.Point(13, 58);
            this.saveAllWords.Name = "saveAllWords";
            this.saveAllWords.Size = new System.Drawing.Size(191, 20);
            this.saveAllWords.TabIndex = 12;
            this.saveAllWords.Text = "СОХРАНИТЬ ВСЕ СЛОВА";
            this.saveAllWords.UseVisualStyleBackColor = true;
            this.saveAllWords.CheckedChanged += new System.EventHandler(this.WorkWithSaveParameters);
            // 
            // saveInDatabase
            // 
            this.saveInDatabase.AutoSize = true;
            this.saveInDatabase.Checked = true;
            this.saveInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInDatabase.Location = new System.Drawing.Point(13, 99);
            this.saveInDatabase.Name = "saveInDatabase";
            this.saveInDatabase.Size = new System.Drawing.Size(120, 20);
            this.saveInDatabase.TabIndex = 13;
            this.saveInDatabase.TabStop = true;
            this.saveInDatabase.Text = "В базу данных";
            this.saveInDatabase.UseVisualStyleBackColor = true;
            // 
            // saveInTextDocument
            // 
            this.saveInTextDocument.AutoSize = true;
            this.saveInTextDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInTextDocument.Location = new System.Drawing.Point(13, 125);
            this.saveInTextDocument.Name = "saveInTextDocument";
            this.saveInTextDocument.Size = new System.Drawing.Size(173, 20);
            this.saveInTextDocument.TabIndex = 14;
            this.saveInTextDocument.Text = "В текстовый документ";
            this.saveInTextDocument.UseVisualStyleBackColor = true;
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordCountLabel.Location = new System.Drawing.Point(10, 32);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(123, 16);
            this.wordCountLabel.TabIndex = 7;
            this.wordCountLabel.Text = "Количество слов:";
            // 
            // groupBoxWithTypeSort
            // 
            this.groupBoxWithTypeSort.Controls.Add(this.panel);
            this.groupBoxWithTypeSort.Controls.Add(this.sortingTypeLength);
            this.groupBoxWithTypeSort.Controls.Add(this.sortingTypeUniqueness);
            this.groupBoxWithTypeSort.Controls.Add(this.sortingTypeAlphabetically);
            this.groupBoxWithTypeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWithTypeSort.Location = new System.Drawing.Point(12, 168);
            this.groupBoxWithTypeSort.Name = "groupBoxWithTypeSort";
            this.groupBoxWithTypeSort.Size = new System.Drawing.Size(407, 111);
            this.groupBoxWithTypeSort.TabIndex = 0;
            this.groupBoxWithTypeSort.TabStop = false;
            this.groupBoxWithTypeSort.Text = "Вариант сортировки данных";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label_hehe);
            this.panel.Controls.Add(this.sortingOrderFromLowest);
            this.panel.Controls.Add(this.sortingOrderFromBiggest);
            this.panel.Location = new System.Drawing.Point(245, 15);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(156, 90);
            this.panel.TabIndex = 0;
            // 
            // label_hehe
            // 
            this.label_hehe.AutoSize = true;
            this.label_hehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hehe.Location = new System.Drawing.Point(36, 3);
            this.label_hehe.Name = "label_hehe";
            this.label_hehe.Size = new System.Drawing.Size(85, 32);
            this.label_hehe.TabIndex = 0;
            this.label_hehe.Text = "Порядок\r\nсортировки";
            this.label_hehe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortingOrderFromLowest
            // 
            this.sortingOrderFromLowest.AutoSize = true;
            this.sortingOrderFromLowest.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortingOrderFromLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingOrderFromLowest.Location = new System.Drawing.Point(81, 41);
            this.sortingOrderFromLowest.Name = "sortingOrderFromLowest";
            this.sortingOrderFromLowest.Size = new System.Drawing.Size(46, 24);
            this.sortingOrderFromLowest.TabIndex = 8;
            this.sortingOrderFromLowest.TabStop = true;
            this.sortingOrderFromLowest.Text = " ↑ ";
            this.sortingOrderFromLowest.UseVisualStyleBackColor = true;
            this.sortingOrderFromLowest.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortingOrderFromBiggest
            // 
            this.sortingOrderFromBiggest.AutoSize = true;
            this.sortingOrderFromBiggest.Checked = true;
            this.sortingOrderFromBiggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingOrderFromBiggest.Location = new System.Drawing.Point(29, 41);
            this.sortingOrderFromBiggest.Name = "sortingOrderFromBiggest";
            this.sortingOrderFromBiggest.Size = new System.Drawing.Size(46, 24);
            this.sortingOrderFromBiggest.TabIndex = 7;
            this.sortingOrderFromBiggest.TabStop = true;
            this.sortingOrderFromBiggest.Text = " ↓ ";
            this.sortingOrderFromBiggest.UseVisualStyleBackColor = true;
            this.sortingOrderFromBiggest.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortingTypeLength
            // 
            this.sortingTypeLength.AutoSize = true;
            this.sortingTypeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingTypeLength.Location = new System.Drawing.Point(11, 78);
            this.sortingTypeLength.Name = "sortingTypeLength";
            this.sortingTypeLength.Size = new System.Drawing.Size(85, 20);
            this.sortingTypeLength.TabIndex = 6;
            this.sortingTypeLength.TabStop = true;
            this.sortingTypeLength.Text = "по длине";
            this.sortingTypeLength.UseVisualStyleBackColor = true;
            this.sortingTypeLength.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortingTypeUniqueness
            // 
            this.sortingTypeUniqueness.AutoSize = true;
            this.sortingTypeUniqueness.Checked = true;
            this.sortingTypeUniqueness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingTypeUniqueness.Location = new System.Drawing.Point(11, 26);
            this.sortingTypeUniqueness.Name = "sortingTypeUniqueness";
            this.sortingTypeUniqueness.Size = new System.Drawing.Size(137, 20);
            this.sortingTypeUniqueness.TabIndex = 4;
            this.sortingTypeUniqueness.TabStop = true;
            this.sortingTypeUniqueness.Text = "по уникальности";
            this.sortingTypeUniqueness.UseVisualStyleBackColor = true;
            this.sortingTypeUniqueness.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // sortingTypeAlphabetically
            // 
            this.sortingTypeAlphabetically.AutoSize = true;
            this.sortingTypeAlphabetically.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingTypeAlphabetically.Location = new System.Drawing.Point(11, 52);
            this.sortingTypeAlphabetically.Name = "sortingTypeAlphabetically";
            this.sortingTypeAlphabetically.Size = new System.Drawing.Size(111, 20);
            this.sortingTypeAlphabetically.TabIndex = 5;
            this.sortingTypeAlphabetically.TabStop = true;
            this.sortingTypeAlphabetically.Text = "по алфавиту";
            this.sortingTypeAlphabetically.UseVisualStyleBackColor = true;
            this.sortingTypeAlphabetically.Click += new System.EventHandler(this.WorkWithSwitchSort);
            // 
            // goToPrintResult
            // 
            this.goToPrintResult.Enabled = false;
            this.goToPrintResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToPrintResult.Location = new System.Drawing.Point(434, 285);
            this.goToPrintResult.Name = "goToPrintResult";
            this.goToPrintResult.Size = new System.Drawing.Size(215, 43);
            this.goToPrintResult.TabIndex = 10;
            this.goToPrintResult.Text = "Результат";
            this.goToPrintResult.UseVisualStyleBackColor = true;
            this.goToPrintResult.Click += new System.EventHandler(this.GoToOpenResult);
            // 
            // dataProcessingTime
            // 
            this.dataProcessingTime.AutoSize = true;
            this.dataProcessingTime.ForeColor = System.Drawing.Color.Gray;
            this.dataProcessingTime.Location = new System.Drawing.Point(259, 156);
            this.dataProcessingTime.Name = "dataProcessingTime";
            this.dataProcessingTime.Size = new System.Drawing.Size(164, 13);
            this.dataProcessingTime.TabIndex = 16;
            this.dataProcessingTime.Text = "время обработки: 00:00:00.000";
            this.dataProcessingTime.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 339);
            this.Controls.Add(this.dataProcessingTime);
            this.Controls.Add(this.goToPrintResult);
            this.Controls.Add(this.groupBoxWithTypeSort);
            this.Controls.Add(this.goToStartProgram);
            this.Controls.Add(this.groupBoxWithOptionsSave);
            this.Controls.Add(this.groupBoxWithChoise);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML code reader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxWithChoise.ResumeLayout(false);
            this.groupBoxWithChoise.PerformLayout();
            this.groupBoxWithOptionsSave.ResumeLayout(false);
            this.groupBoxWithOptionsSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordCount)).EndInit();
            this.groupBoxWithTypeSort.ResumeLayout(false);
            this.groupBoxWithTypeSort.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileTSMI;
        private System.Windows.Forms.ToolStripMenuItem openFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveInTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsTMSI;
        private System.Windows.Forms.ToolStripMenuItem viewTMSI;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button goToStartProgram;
        private System.Windows.Forms.TextBox webpageTextBox;
        private System.Windows.Forms.TextBox localFileTextBox;
        private System.Windows.Forms.Label webpageLabel;
        private System.Windows.Forms.ToolStripMenuItem copyTSMI;
        private System.Windows.Forms.ToolStripMenuItem scaleTMSI;
        private System.Windows.Forms.ToolStripMenuItem saveInDatabaseTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveInTextDocumentTSMI;
        private System.Windows.Forms.ToolStripMenuItem settingsFiltrationTMSI;
        private System.Windows.Forms.Button goToOverviewPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxWithChoise;
        private System.Windows.Forms.Label localFileLabel;
        private System.Windows.Forms.GroupBox groupBoxWithOptionsSave;
        private System.Windows.Forms.Button goToSaveResult;
        private System.Windows.Forms.ToolStripMenuItem saveInClipboardTSMI;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.ToolStripMenuItem scale70TSMI;
        private System.Windows.Forms.ToolStripMenuItem scale100TSMI;
        private System.Windows.Forms.ToolStripMenuItem scale150TSMI;
        private System.Windows.Forms.ToolStripMenuItem scale200TSMI;
        private System.Windows.Forms.ToolStripMenuItem scale250TSMI;
        private System.Windows.Forms.ToolStripMenuItem scale300TSMI;
        private System.Windows.Forms.GroupBox groupBoxWithTypeSort;
        private System.Windows.Forms.Button goToPrintResult;
        private System.Windows.Forms.ToolStripMenuItem sortTypesTMSI;
        private System.Windows.Forms.ToolStripMenuItem sortingTypeUniquenessTSMI;
        private System.Windows.Forms.ToolStripMenuItem sortingTypeAlphabeticallyTSMI;
        private System.Windows.Forms.ToolStripMenuItem sortingTypeLengthTSMI;
        private System.Windows.Forms.ToolStripMenuItem backgroundStyleTMSI;
        private System.Windows.Forms.ToolStripMenuItem whiteTSMI;
        private System.Windows.Forms.ToolStripMenuItem darkTSMI;
        private System.Windows.Forms.ToolStripMenuItem choiceSourceDataTMSI;
        private System.Windows.Forms.ToolStripMenuItem webpageTSMI;
        private System.Windows.Forms.ToolStripMenuItem localFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeURLSTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeDatesTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeNumbersTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeEmailsTSMI;
        private System.Windows.Forms.ToolStripMenuItem removeSomeEnititesTSMI;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label_hehe;
        private System.Windows.Forms.ToolStripMenuItem порядокСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortOrderFromBiggestTSMI;
        private System.Windows.Forms.ToolStripMenuItem sortOrderFromLowestTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.CheckBox saveAllWords;
        public System.Windows.Forms.NumericUpDown wordCount;
        public System.Windows.Forms.RadioButton saveInDatabase;
        public System.Windows.Forms.RadioButton saveInClipboard;
        public System.Windows.Forms.RadioButton saveInTextDocument;
        public System.Windows.Forms.RadioButton sortingTypeAlphabetically;
        public System.Windows.Forms.RadioButton sortingTypeUniqueness;
        public System.Windows.Forms.RadioButton sortingTypeLength;
        public System.Windows.Forms.RadioButton sortingOrderFromLowest;
        public System.Windows.Forms.RadioButton sortingOrderFromBiggest;
        private System.Windows.Forms.Label dataProcessingTime;
    }
}

