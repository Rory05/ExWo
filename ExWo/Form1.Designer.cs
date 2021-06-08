
namespace Exсel_Word
{
    partial class ExWo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExWo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChBLetter = new System.Windows.Forms.RadioButton();
            this.ChBDF = new System.Windows.Forms.RadioButton();
            this.ChBDeputy = new System.Windows.Forms.RadioButton();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.CreateLetter = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.deputy = new MetroSet_UI.Controls.MetroSetButton();
            this.GO = new MetroSet_UI.Controls.MetroSetButton();
            this.example = new MetroSet_UI.Controls.MetroSetButton();
            this.folderbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.exelbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.About = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1.SuspendLayout();
            this.CreateLetter.SuspendLayout();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(173, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Файл з інформацією";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Папка для збереження нових файлів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Приклад створюваного файлу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(173, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Список депутатів";
            // 
            // ChBLetter
            // 
            this.ChBLetter.AutoSize = true;
            this.ChBLetter.BackColor = System.Drawing.Color.White;
            this.ChBLetter.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBLetter.ForeColor = System.Drawing.Color.Black;
            this.ChBLetter.Location = new System.Drawing.Point(3, 379);
            this.ChBLetter.Name = "ChBLetter";
            this.ChBLetter.Size = new System.Drawing.Size(92, 29);
            this.ChBLetter.TabIndex = 14;
            this.ChBLetter.TabStop = true;
            this.ChBLetter.Text = "Листи";
            this.ChBLetter.UseVisualStyleBackColor = false;
            // 
            // ChBDF
            // 
            this.ChBDF.AutoSize = true;
            this.ChBDF.BackColor = System.Drawing.Color.White;
            this.ChBDF.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBDF.ForeColor = System.Drawing.Color.Black;
            this.ChBDF.Location = new System.Drawing.Point(141, 379);
            this.ChBDF.Name = "ChBDF";
            this.ChBDF.Size = new System.Drawing.Size(188, 29);
            this.ChBDF.TabIndex = 15;
            this.ChBDF.TabStop = true;
            this.ChBDF.Text = "ДФ(громадянам)";
            this.ChBDF.UseVisualStyleBackColor = false;
            // 
            // ChBDeputy
            // 
            this.ChBDeputy.AutoSize = true;
            this.ChBDeputy.BackColor = System.Drawing.Color.White;
            this.ChBDeputy.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBDeputy.ForeColor = System.Drawing.Color.Black;
            this.ChBDeputy.Location = new System.Drawing.Point(356, 379);
            this.ChBDeputy.Name = "ChBDeputy";
            this.ChBDeputy.Size = new System.Drawing.Size(145, 29);
            this.ChBDeputy.TabIndex = 16;
            this.ChBDeputy.TabStop = true;
            this.ChBDeputy.Text = "Депутатам";
            this.ChBDeputy.UseVisualStyleBackColor = false;
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Mary\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Custom;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLight";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.CreateLetter);
            this.metroSetTabControl1.Controls.Add(this.About);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 84);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(521, 581);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 18;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLight";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Black;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // CreateLetter
            // 
            this.CreateLetter.BaseColor = System.Drawing.Color.White;
            this.CreateLetter.Controls.Add(this.deputy);
            this.CreateLetter.Controls.Add(this.GO);
            this.CreateLetter.Controls.Add(this.example);
            this.CreateLetter.Controls.Add(this.folderbtn);
            this.CreateLetter.Controls.Add(this.exelbtn);
            this.CreateLetter.Controls.Add(this.ChBDeputy);
            this.CreateLetter.Controls.Add(this.label1);
            this.CreateLetter.Controls.Add(this.ChBDF);
            this.CreateLetter.Controls.Add(this.label2);
            this.CreateLetter.Controls.Add(this.ChBLetter);
            this.CreateLetter.Controls.Add(this.label3);
            this.CreateLetter.Controls.Add(this.label4);
            this.CreateLetter.Font = null;
            this.CreateLetter.ImageIndex = 0;
            this.CreateLetter.ImageKey = null;
            this.CreateLetter.IsDerivedStyle = true;
            this.CreateLetter.Location = new System.Drawing.Point(4, 54);
            this.CreateLetter.Name = "CreateLetter";
            this.CreateLetter.Size = new System.Drawing.Size(513, 523);
            this.CreateLetter.Style = MetroSet_UI.Enums.Style.Custom;
            this.CreateLetter.StyleManager = this.styleManager1;
            this.CreateLetter.TabIndex = 0;
            this.CreateLetter.Text = "Створення листів";
            this.CreateLetter.ThemeAuthor = "Narwin";
            this.CreateLetter.ThemeName = "MetroLight";
            this.CreateLetter.ToolTipText = null;
            // 
            // deputy
            // 
            this.deputy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deputy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deputy.DisabledForeColor = System.Drawing.Color.Gray;
            this.deputy.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deputy.HoverBorderColor = System.Drawing.Color.Transparent;
            this.deputy.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.deputy.HoverTextColor = System.Drawing.Color.White;
            this.deputy.IsDerivedStyle = true;
            this.deputy.Location = new System.Drawing.Point(3, 283);
            this.deputy.Name = "deputy";
            this.deputy.NormalBorderColor = System.Drawing.Color.Transparent;
            this.deputy.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.deputy.NormalTextColor = System.Drawing.Color.White;
            this.deputy.PressBorderColor = System.Drawing.Color.Transparent;
            this.deputy.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(170)))));
            this.deputy.PressTextColor = System.Drawing.Color.White;
            this.deputy.Size = new System.Drawing.Size(155, 62);
            this.deputy.Style = MetroSet_UI.Enums.Style.Custom;
            this.deputy.StyleManager = this.styleManager1;
            this.deputy.TabIndex = 10;
            this.deputy.Text = "Відкрити файл";
            this.deputy.ThemeAuthor = "Narwin";
            this.deputy.ThemeName = "MetroLight";
            this.deputy.Click += new System.EventHandler(this.deputy_Click);
            // 
            // GO
            // 
            this.GO.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GO.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GO.DisabledForeColor = System.Drawing.Color.Gray;
            this.GO.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GO.HoverBorderColor = System.Drawing.Color.Transparent;
            this.GO.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.GO.HoverTextColor = System.Drawing.Color.White;
            this.GO.IsDerivedStyle = true;
            this.GO.Location = new System.Drawing.Point(141, 424);
            this.GO.Name = "GO";
            this.GO.NormalBorderColor = System.Drawing.Color.Transparent;
            this.GO.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.GO.NormalTextColor = System.Drawing.Color.White;
            this.GO.PressBorderColor = System.Drawing.Color.Transparent;
            this.GO.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(170)))));
            this.GO.PressTextColor = System.Drawing.Color.White;
            this.GO.Size = new System.Drawing.Size(177, 85);
            this.GO.Style = MetroSet_UI.Enums.Style.Custom;
            this.GO.StyleManager = this.styleManager1;
            this.GO.TabIndex = 17;
            this.GO.Text = "Почати створення!";
            this.GO.ThemeAuthor = "Narwin";
            this.GO.ThemeName = "MetroLight";
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // example
            // 
            this.example.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.example.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.example.DisabledForeColor = System.Drawing.Color.Gray;
            this.example.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example.HoverBorderColor = System.Drawing.Color.Transparent;
            this.example.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.example.HoverTextColor = System.Drawing.Color.White;
            this.example.IsDerivedStyle = true;
            this.example.Location = new System.Drawing.Point(3, 197);
            this.example.Name = "example";
            this.example.NormalBorderColor = System.Drawing.Color.Transparent;
            this.example.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.example.NormalTextColor = System.Drawing.Color.White;
            this.example.PressBorderColor = System.Drawing.Color.Transparent;
            this.example.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(170)))));
            this.example.PressTextColor = System.Drawing.Color.White;
            this.example.Size = new System.Drawing.Size(155, 62);
            this.example.Style = MetroSet_UI.Enums.Style.Custom;
            this.example.StyleManager = this.styleManager1;
            this.example.TabIndex = 9;
            this.example.Text = "Відкрити файл";
            this.example.ThemeAuthor = "Narwin";
            this.example.ThemeName = "MetroLight";
            this.example.Click += new System.EventHandler(this.example_Click);
            // 
            // folderbtn
            // 
            this.folderbtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.folderbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.folderbtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.folderbtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderbtn.HoverBorderColor = System.Drawing.Color.Transparent;
            this.folderbtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.folderbtn.HoverTextColor = System.Drawing.Color.White;
            this.folderbtn.IsDerivedStyle = true;
            this.folderbtn.Location = new System.Drawing.Point(3, 107);
            this.folderbtn.Name = "folderbtn";
            this.folderbtn.NormalBorderColor = System.Drawing.Color.Transparent;
            this.folderbtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.folderbtn.NormalTextColor = System.Drawing.Color.White;
            this.folderbtn.PressBorderColor = System.Drawing.Color.Transparent;
            this.folderbtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(170)))));
            this.folderbtn.PressTextColor = System.Drawing.Color.White;
            this.folderbtn.Size = new System.Drawing.Size(155, 62);
            this.folderbtn.Style = MetroSet_UI.Enums.Style.Custom;
            this.folderbtn.StyleManager = this.styleManager1;
            this.folderbtn.TabIndex = 5;
            this.folderbtn.Text = "Відкрити папку";
            this.folderbtn.ThemeAuthor = "Narwin";
            this.folderbtn.ThemeName = "MetroLight";
            this.folderbtn.Click += new System.EventHandler(this.folderbtn_Click);
            // 
            // exelbtn
            // 
            this.exelbtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.exelbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.exelbtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.exelbtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exelbtn.HoverBorderColor = System.Drawing.Color.Transparent;
            this.exelbtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.exelbtn.HoverTextColor = System.Drawing.Color.White;
            this.exelbtn.IsDerivedStyle = true;
            this.exelbtn.Location = new System.Drawing.Point(3, 22);
            this.exelbtn.Name = "exelbtn";
            this.exelbtn.NormalBorderColor = System.Drawing.Color.Transparent;
            this.exelbtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.exelbtn.NormalTextColor = System.Drawing.Color.White;
            this.exelbtn.PressBorderColor = System.Drawing.Color.Transparent;
            this.exelbtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(170)))));
            this.exelbtn.PressTextColor = System.Drawing.Color.White;
            this.exelbtn.Size = new System.Drawing.Size(155, 62);
            this.exelbtn.Style = MetroSet_UI.Enums.Style.Custom;
            this.exelbtn.StyleManager = this.styleManager1;
            this.exelbtn.TabIndex = 0;
            this.exelbtn.Text = "Відкрити файл";
            this.exelbtn.ThemeAuthor = "Narwin";
            this.exelbtn.ThemeName = "MetroLight";
            this.exelbtn.Click += new System.EventHandler(this.exelbtn_Click);
            // 
            // About
            // 
            this.About.BaseColor = System.Drawing.Color.White;
            this.About.Controls.Add(this.metroSetLabel2);
            this.About.Controls.Add(this.metroSetLabel1);
            this.About.Cursor = System.Windows.Forms.Cursors.Default;
            this.About.Font = null;
            this.About.ImageIndex = 0;
            this.About.ImageKey = null;
            this.About.IsDerivedStyle = true;
            this.About.Location = new System.Drawing.Point(4, 54);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(513, 523);
            this.About.Style = MetroSet_UI.Enums.Style.Custom;
            this.About.StyleManager = this.styleManager1;
            this.About.TabIndex = 1;
            this.About.Text = "Справка";
            this.About.ThemeAuthor = "Narwin";
            this.About.ThemeName = "MetroLight";
            this.About.ToolTipText = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(4, 23);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(452, 167);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = resources.GetString("metroSetLabel2.Text");
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(4, 500);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(237, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "© Лісова Марія, Київ, 2021";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(438, 8);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 19;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLight";
            // 
            // ExWo
            // 
            this.AccessibleName = "ExWo";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(550, 680);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(170)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExWo";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SmallLineColor1 = System.Drawing.Color.SpringGreen;
            this.SmallLineColor2 = System.Drawing.Color.DodgerBlue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Custom;
            this.StyleManager = this.styleManager1;
            this.Tag = "ExWo";
            this.Text = "ExWo";
            this.TextColor = System.Drawing.Color.Black;
            this.ThemeAuthor = null;
            this.ThemeName = "MetroLight";
            this.metroSetTabControl1.ResumeLayout(false);
            this.CreateLetter.ResumeLayout(false);
            this.CreateLetter.PerformLayout();
            this.About.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ChBLetter;
        private System.Windows.Forms.RadioButton ChBDF;
        private System.Windows.Forms.RadioButton ChBDeputy;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage CreateLetter;
        private MetroSet_UI.Child.MetroSetSetTabPage About;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetButton exelbtn;
        private MetroSet_UI.Controls.MetroSetButton deputy;
        private MetroSet_UI.Controls.MetroSetButton example;
        private MetroSet_UI.Controls.MetroSetButton folderbtn;
        private MetroSet_UI.Controls.MetroSetButton GO;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    }
}

