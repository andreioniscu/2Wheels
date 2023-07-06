namespace _2Wheels
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
            TabPage history;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topBar = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnminimized = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            btnFlota = new Button();
            btnOngoing = new Button();
            btnHistory = new Button();
            btnInchiriere = new Button();
            tabControl1 = new TabControl();
            newRental = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTroti = new Button();
            btnBicla = new Button();
            panel5 = new Panel();
            panel11 = new Panel();
            btnStart = new Button();
            panel12 = new Panel();
            panel8 = new Panel();
            cmbPerioada = new ComboBox();
            panel10 = new Panel();
            panel9 = new Panel();
            label8 = new Label();
            dtpDataNastere = new DateTimePicker();
            label7 = new Label();
            txtSerieBuletin = new TextBox();
            label6 = new Label();
            txtCNP = new TextBox();
            label5 = new Label();
            txtPrenume = new TextBox();
            label4 = new Label();
            txtNume = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            ongoing = new TabPage();
            grdOngoing = new DataGridView();
            tabPage1 = new TabPage();
            grdFlota = new DataGridView();
            panel13 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel17 = new Panel();
            cmbTip = new ComboBox();
            label10 = new Label();
            panel16 = new Panel();
            txtCod = new TextBox();
            label9 = new Label();
            btnAddVehicul = new Button();
            panel15 = new Panel();
            panel14 = new Panel();
            grdHistory = new DataGridView();
            history = new TabPage();
            history.SuspendLayout();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            newRental.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ongoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdOngoing).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdFlota).BeginInit();
            panel13.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdHistory).BeginInit();
            SuspendLayout();
            // 
            // history
            // 
            history.Controls.Add(grdHistory);
            history.Location = new Point(4, 5);
            history.Name = "history";
            history.Padding = new Padding(3);
            history.Size = new Size(1713, 976);
            history.TabIndex = 1;
            history.Text = "tabPage2";
            history.UseVisualStyleBackColor = true;
            // 
            // topBar
            // 
            topBar.BackColor = Color.DarkCyan;
            topBar.Controls.Add(label1);
            topBar.Controls.Add(panel4);
            topBar.Controls.Add(panel3);
            topBar.Controls.Add(pictureBox1);
            topBar.Controls.Add(panel2);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(2021, 97);
            topBar.TabIndex = 0;
            topBar.Paint += topBar_Paint;
            topBar.MouseMove += topBar_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 14);
            label1.Name = "label1";
            label1.Size = new Size(891, 65);
            label1.TabIndex = 5;
            label1.Text = "2Wheels - Inchirieri vehicule cu doua roti";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(107, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(43, 83);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(107, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1687, 14);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnminimized);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1794, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 97);
            panel2.TabIndex = 0;
            // 
            // btnminimized
            // 
            btnminimized.BackColor = Color.Turquoise;
            btnminimized.Dock = DockStyle.Right;
            btnminimized.FlatStyle = FlatStyle.Flat;
            btnminimized.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            btnminimized.ForeColor = Color.White;
            btnminimized.Location = new Point(3, 0);
            btnminimized.Name = "btnminimized";
            btnminimized.Size = new Size(112, 97);
            btnminimized.TabIndex = 1;
            btnminimized.Text = "_";
            btnminimized.UseVisualStyleBackColor = false;
            btnminimized.Click += btnminimized_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(115, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 97);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnFlota);
            panel1.Controls.Add(btnOngoing);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnInchiriere);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 985);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnFlota
            // 
            btnFlota.BackColor = Color.DarkSlateGray;
            btnFlota.Dock = DockStyle.Top;
            btnFlota.FlatAppearance.BorderSize = 0;
            btnFlota.FlatStyle = FlatStyle.Flat;
            btnFlota.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnFlota.ForeColor = Color.White;
            btnFlota.Location = new Point(0, 303);
            btnFlota.Name = "btnFlota";
            btnFlota.Size = new Size(300, 101);
            btnFlota.TabIndex = 3;
            btnFlota.Text = "Flota";
            btnFlota.UseVisualStyleBackColor = false;
            btnFlota.Click += btnFlota_Click;
            // 
            // btnOngoing
            // 
            btnOngoing.BackColor = Color.DarkSlateGray;
            btnOngoing.Dock = DockStyle.Top;
            btnOngoing.FlatAppearance.BorderSize = 0;
            btnOngoing.FlatStyle = FlatStyle.Flat;
            btnOngoing.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnOngoing.ForeColor = Color.White;
            btnOngoing.Location = new Point(0, 202);
            btnOngoing.Name = "btnOngoing";
            btnOngoing.Size = new Size(300, 101);
            btnOngoing.TabIndex = 2;
            btnOngoing.Text = "In curs";
            btnOngoing.UseVisualStyleBackColor = false;
            btnOngoing.Click += btnOngoing_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DarkSlateGray;
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(0, 101);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(300, 101);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "Istoric";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnInchiriere
            // 
            btnInchiriere.BackColor = Color.DarkCyan;
            btnInchiriere.Dock = DockStyle.Top;
            btnInchiriere.FlatAppearance.BorderSize = 0;
            btnInchiriere.FlatStyle = FlatStyle.Flat;
            btnInchiriere.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnInchiriere.ForeColor = Color.White;
            btnInchiriere.Location = new Point(0, 0);
            btnInchiriere.Name = "btnInchiriere";
            btnInchiriere.Size = new Size(300, 101);
            btnInchiriere.TabIndex = 0;
            btnInchiriere.Text = "Inchiriere Noua";
            btnInchiriere.UseVisualStyleBackColor = false;
            btnInchiriere.Click += btnInchiriere_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(newRental);
            tabControl1.Controls.Add(history);
            tabControl1.Controls.Add(ongoing);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(300, 97);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1721, 985);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            // 
            // newRental
            // 
            newRental.Controls.Add(tableLayoutPanel1);
            newRental.Controls.Add(panel5);
            newRental.Location = new Point(4, 5);
            newRental.Name = "newRental";
            newRental.Padding = new Padding(3);
            newRental.Size = new Size(1713, 976);
            newRental.TabIndex = 0;
            newRental.Text = "tabPage1";
            newRental.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnTroti, 0, 1);
            tableLayoutPanel1.Controls.Add(btnBicla, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(516, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1194, 970);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnTroti
            // 
            btnTroti.BackColor = Color.DarkSlateGray;
            btnTroti.Dock = DockStyle.Fill;
            btnTroti.FlatAppearance.BorderSize = 0;
            btnTroti.FlatStyle = FlatStyle.Flat;
            btnTroti.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnTroti.ForeColor = Color.White;
            btnTroti.Location = new Point(3, 488);
            btnTroti.Name = "btnTroti";
            btnTroti.Size = new Size(1188, 479);
            btnTroti.TabIndex = 3;
            btnTroti.Text = "Trotineta";
            btnTroti.UseVisualStyleBackColor = false;
            btnTroti.Click += btnTroti_Click;
            // 
            // btnBicla
            // 
            btnBicla.BackColor = Color.DarkCyan;
            btnBicla.Dock = DockStyle.Fill;
            btnBicla.FlatAppearance.BorderSize = 0;
            btnBicla.FlatStyle = FlatStyle.Flat;
            btnBicla.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnBicla.ForeColor = Color.White;
            btnBicla.Location = new Point(3, 3);
            btnBicla.Name = "btnBicla";
            btnBicla.Size = new Size(1188, 479);
            btnBicla.TabIndex = 1;
            btnBicla.Text = "Bicicleta";
            btnBicla.UseVisualStyleBackColor = false;
            btnBicla.Click += btnBicla_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(dtpDataNastere);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtSerieBuletin);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtCNP);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtPrenume);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtNume);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(513, 970);
            panel5.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(btnStart);
            panel11.Controls.Add(panel12);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 398);
            panel11.Name = "panel11";
            panel11.Size = new Size(513, 396);
            panel11.TabIndex = 13;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSlateGray;
            btnStart.Dock = DockStyle.Fill;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(0, 10);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(511, 384);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start Inchiriere";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(511, 10);
            panel12.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkCyan;
            panel8.Controls.Add(cmbPerioada);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 794);
            panel8.Name = "panel8";
            panel8.Size = new Size(513, 176);
            panel8.TabIndex = 12;
            // 
            // cmbPerioada
            // 
            cmbPerioada.Dock = DockStyle.Fill;
            cmbPerioada.FormattingEnabled = true;
            cmbPerioada.Location = new Point(18, 70);
            cmbPerioada.Name = "cmbPerioada";
            cmbPerioada.Size = new Size(477, 33);
            cmbPerioada.TabIndex = 10;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(495, 70);
            panel10.Name = "panel10";
            panel10.Size = new Size(18, 106);
            panel10.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 70);
            panel9.Name = "panel9";
            panel9.Size = new Size(18, 106);
            panel9.TabIndex = 8;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(513, 70);
            label8.TabIndex = 7;
            label8.Text = "Perioada de inchiriere";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click_1;
            // 
            // dtpDataNastere
            // 
            dtpDataNastere.Dock = DockStyle.Top;
            dtpDataNastere.Location = new Point(0, 367);
            dtpDataNastere.Name = "dtpDataNastere";
            dtpDataNastere.Size = new Size(513, 31);
            dtpDataNastere.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 342);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 10;
            label7.Text = "Data Nasterii";
            // 
            // txtSerieBuletin
            // 
            txtSerieBuletin.Dock = DockStyle.Top;
            txtSerieBuletin.Location = new Point(0, 311);
            txtSerieBuletin.Name = "txtSerieBuletin";
            txtSerieBuletin.Size = new Size(513, 31);
            txtSerieBuletin.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 286);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 8;
            label6.Text = "Serie buletin";
            // 
            // txtCNP
            // 
            txtCNP.Dock = DockStyle.Top;
            txtCNP.Location = new Point(0, 255);
            txtCNP.Name = "txtCNP";
            txtCNP.Size = new Size(513, 31);
            txtCNP.TabIndex = 7;
            txtCNP.TextChanged += txtCNP_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 230);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 6;
            label5.Text = "CNP";
            // 
            // txtPrenume
            // 
            txtPrenume.Dock = DockStyle.Top;
            txtPrenume.Location = new Point(0, 199);
            txtPrenume.Name = "txtPrenume";
            txtPrenume.Size = new Size(513, 31);
            txtPrenume.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 174);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 4;
            label4.Text = "Prenume";
            label4.Click += label4_Click;
            // 
            // txtNume
            // 
            txtNume.Dock = DockStyle.Top;
            txtNume.Location = new Point(0, 143);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(513, 31);
            txtNume.TabIndex = 3;
            txtNume.TextChanged += txtNume_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Nume";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(513, 118);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 104);
            panel7.Name = "panel7";
            panel7.Size = new Size(513, 14);
            panel7.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(513, 118);
            label2.TabIndex = 0;
            label2.Text = "Date Buletin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ongoing
            // 
            ongoing.Controls.Add(grdOngoing);
            ongoing.Location = new Point(4, 5);
            ongoing.Name = "ongoing";
            ongoing.Padding = new Padding(3);
            ongoing.Size = new Size(1713, 976);
            ongoing.TabIndex = 2;
            ongoing.Text = "tabPage3";
            ongoing.UseVisualStyleBackColor = true;
            // 
            // grdOngoing
            // 
            grdOngoing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdOngoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOngoing.Dock = DockStyle.Fill;
            grdOngoing.Location = new Point(3, 3);
            grdOngoing.Name = "grdOngoing";
            grdOngoing.RowHeadersWidth = 62;
            grdOngoing.RowTemplate.Height = 33;
            grdOngoing.Size = new Size(1707, 970);
            grdOngoing.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grdFlota);
            tabPage1.Controls.Add(panel13);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1713, 976);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "tabFlota";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdFlota
            // 
            grdFlota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdFlota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdFlota.Dock = DockStyle.Fill;
            grdFlota.Location = new Point(3, 3);
            grdFlota.Name = "grdFlota";
            grdFlota.RowHeadersWidth = 62;
            grdFlota.RowTemplate.Height = 33;
            grdFlota.Size = new Size(1707, 792);
            grdFlota.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.DarkCyan;
            panel13.Controls.Add(tableLayoutPanel2);
            panel13.Controls.Add(btnAddVehicul);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel14);
            panel13.Dock = DockStyle.Bottom;
            panel13.ForeColor = SystemColors.ControlLight;
            panel13.Location = new Point(3, 795);
            panel13.Name = "panel13";
            panel13.Size = new Size(1707, 178);
            panel13.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel17, 1, 0);
            tableLayoutPanel2.Controls.Add(panel16, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(34, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1407, 148);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // panel17
            // 
            panel17.Controls.Add(cmbTip);
            panel17.Controls.Add(label10);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(706, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(698, 142);
            panel17.TabIndex = 1;
            // 
            // cmbTip
            // 
            cmbTip.Dock = DockStyle.Fill;
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(0, 32);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(698, 33);
            cmbTip.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.No;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(131, 32);
            label10.TabIndex = 5;
            label10.Text = "Tip Vehicul";
            // 
            // panel16
            // 
            panel16.Controls.Add(txtCod);
            panel16.Controls.Add(label9);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(3, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(697, 142);
            panel16.TabIndex = 0;
            // 
            // txtCod
            // 
            txtCod.Dock = DockStyle.Top;
            txtCod.Location = new Point(0, 32);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(697, 31);
            txtCod.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(267, 32);
            label9.TabIndex = 5;
            label9.Text = "Cod Identificare Vehicul";
            // 
            // btnAddVehicul
            // 
            btnAddVehicul.BackColor = Color.DarkSlateGray;
            btnAddVehicul.Dock = DockStyle.Right;
            btnAddVehicul.FlatStyle = FlatStyle.Flat;
            btnAddVehicul.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddVehicul.Location = new Point(1441, 30);
            btnAddVehicul.Name = "btnAddVehicul";
            btnAddVehicul.Size = new Size(266, 148);
            btnAddVehicul.TabIndex = 3;
            btnAddVehicul.Text = "Adaugare";
            btnAddVehicul.UseVisualStyleBackColor = false;
            btnAddVehicul.Click += btnAddVehicul_Click;
            // 
            // panel15
            // 
            panel15.BackColor = Color.DarkCyan;
            panel15.Dock = DockStyle.Top;
            panel15.ForeColor = SystemColors.ControlLight;
            panel15.Location = new Point(34, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(1673, 30);
            panel15.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.BackColor = Color.DarkCyan;
            panel14.Dock = DockStyle.Left;
            panel14.ForeColor = SystemColors.ControlLight;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(34, 178);
            panel14.TabIndex = 1;
            // 
            // grdHistory
            // 
            grdHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdHistory.Dock = DockStyle.Fill;
            grdHistory.Location = new Point(3, 3);
            grdHistory.Name = "grdHistory";
            grdHistory.RowHeadersWidth = 62;
            grdHistory.RowTemplate.Height = 33;
            grdHistory.Size = new Size(1707, 970);
            grdHistory.TabIndex = 3;
            grdHistory.CellContentClick += grdHistory_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2021, 1082);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            history.ResumeLayout(false);
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            newRental.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel11.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ongoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdOngoing).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdFlota).EndInit();
            panel13.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBar;
        private Panel panel2;
        private Button btnClose;
        private Button btnminimized;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnOngoing;
        private Button btnHistory;
        private Button btnInchiriere;
        private TabControl tabControl1;
        private TabPage newRental;
        private TabPage history;
        private TabPage ongoing;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBicla;
        private Panel panel5;
        public DateTimePicker dtpDataNastere;
        private Label label7;
        public TextBox txtSerieBuletin;
        private Label label6;
        public TextBox txtCNP;
        private Label label5;
        public TextBox txtPrenume;
        private Label label4;
        public TextBox txtNume;
        private Label label3;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private Panel panel8;
        private Button btnStart;
        public ComboBox cmbPerioada;
        private Panel panel10;
        private Panel panel9;
        private Label label8;
        private Panel panel11;
        private Panel panel12;
        private Button btnTroti;
        private Button btnFlota;
        private TabPage tabPage1;
        private DataGridView grdFlota;
        private Panel panel13;
        private Panel panel15;
        private Panel panel14;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel17;
        private ComboBox cmbTip;
        private Label label10;
        private Panel panel16;
        private TextBox txtCod;
        private Label label9;
        private Button btnAddVehicul;
        private DataGridView grdOngoing;
        private DataGridView grdHistory;
    }
}