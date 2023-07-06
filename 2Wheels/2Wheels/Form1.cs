namespace _2Wheels
{
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Diagnostics.Eventing.Reader;
    using System.Runtime.InteropServices;
    public partial class Form1 : Form
    {
        //Pentru manipulare pozitie fereastra
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Color selectedButtonColor = Color.DarkCyan;
        Color buttonColor = Color.DarkSlateGray;

        int vehiculSelectat = 0;
        private BazaDate bd;
        public Form1()
        {
            InitializeComponent();
            cmbPerioada.DataSource = new object[] { "1", "2", "3" };
            bd = new BazaDate("127.0.0.1", "5432", "twowheels", "postgres", "123");
            bd.connect();
            grdFlota.DataSource = bd.returnDataTable("SELECT flota.id, vehicule.nume FROM FLOTA LEFT JOIN VEHICULE on FLOTA.VEHICUL = VEHICULE.VEHICUL");
            grdFlota.Columns["id"].HeaderText = "Cod Vehicul";
            grdFlota.Columns["nume"].HeaderText = "Tip Vehicul";
            DataTable dtVehicule = bd.returnDataTable("SELECT * FROM VEHICULE");
            cmbTip.DataSource = dtVehicule;
            cmbTip.DisplayMember = "nume";
            cmbTip.ValueMember = "vehicul";
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInchiriere_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnInchiriere.BackColor = selectedButtonColor;
            btnHistory.BackColor = buttonColor;
            btnOngoing.BackColor = buttonColor;
            btnFlota.BackColor = buttonColor;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnInchiriere.BackColor = buttonColor;
            btnHistory.BackColor = selectedButtonColor;
            btnOngoing.BackColor = buttonColor;
            btnFlota.BackColor = buttonColor;

            grdHistory.DataSource = bd.returnDataTable("select clienti.nume, clienti.prenume, inchirieri.ora_plecare, inchirieri.ore, flota.id, vehicule.nume from inchirieri left join CLIENTI on clienti.cnp = inchirieri.cnp left join flota on inchirieri.unitate_flota = flota.id_numeric left join vehicule on vehicule.vehicul = flota.vehicul where (ora_plecare  + interval '1 hour' * ore < NOW()::time) order by ora_plecare  asc");

            grdHistory.Columns["nume"].HeaderText = "Nume Client";
            grdHistory.Columns["prenume"].HeaderText = "Prenume Client";
            grdHistory.Columns["ora_plecare"].HeaderText = "Ora Plecare";
            grdHistory.Columns["ore"].HeaderText = "Perioada (ore)";
            grdHistory.Columns["id"].HeaderText = "Cod Vehicul";
            grdHistory.Columns["nume1"].HeaderText = "Tip Vehicul";

        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            btnInchiriere.BackColor = buttonColor;
            btnHistory.BackColor = buttonColor;
            btnOngoing.BackColor = selectedButtonColor;
            btnFlota.BackColor = buttonColor;
            grdOngoing.DataSource = bd.returnDataTable("select clienti.nume, clienti.prenume, inchirieri.ora_plecare, inchirieri.ore,(ora_plecare  + interval '1 hour' * ore) as sosire, flota.id, vehicule.nume from inchirieri left join CLIENTI on clienti.cnp = inchirieri.cnp left join flota on inchirieri.unitate_flota = flota.id_numeric left join vehicule on vehicule.vehicul = flota.vehicul where (ora_plecare  + interval '1 hour' * ore > NOW()::time) order by ora_plecare  asc");

            grdOngoing.Columns["nume"].HeaderText = "Nume Client";
            grdOngoing.Columns["prenume"].HeaderText = "Prenume Client";
            grdOngoing.Columns["ora_plecare"].HeaderText = "Ora Plecare";
            grdOngoing.Columns["ore"].HeaderText = "Perioada (ore)";
            grdOngoing.Columns["sosire"].HeaderText = "Ora sosire maxima";
            grdOngoing.Columns["id"].HeaderText = "Cod Vehicul";
            grdOngoing.Columns["nume1"].HeaderText = "Tip Vehicul";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBicla_Click(object sender, EventArgs e)
        {
            btnBicla.BackColor = selectedButtonColor;
            btnTroti.BackColor = buttonColor;
            vehiculSelectat = 0;
        }

        private void btnTroti_Click(object sender, EventArgs e)
        {

            btnBicla.BackColor = buttonColor;
            btnTroti.BackColor = selectedButtonColor;
            vehiculSelectat = 1;
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            if (!ValCNP.validare(txtCNP.Text))
                txtCNP.BackColor = Color.OrangeRed;
            else
            {
                txtCNP.BackColor = Color.White;
                DataTable clientExistent = bd.returnDataTable("SELECT * FROM CLIENTI WHERE CNP = '" + txtCNP.Text.Trim() + "'");
                if (clientExistent.Rows.Count > 0)
                {
                    txtNume.Text = clientExistent.Rows[0]["nume"].ToString().Trim();
                    txtPrenume.Text = clientExistent.Rows[0]["prenume"].ToString().Trim();
                    txtSerieBuletin.Text = txtNume.Text = clientExistent.Rows[0]["serie_buletin"].ToString().Trim();
                    dtpDataNastere.Value = DateTime.Parse(clientExistent.Rows[0]["data_nasterii"].ToString().Trim());
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!ValCNP.verificaDate(this))
            {
                return;
            }
            try
            {
                bd.execNonQuery("INSERT INTO clienti (cnp, nume, prenume, serie_buletin, data_nasterii) VALUES ('" + txtCNP.Text.Trim() + "', '" + txtNume.Text.Trim() + "', '" + txtPrenume.Text.Trim() + "', '" + txtSerieBuletin.Text.Trim() + "', '" + dtpDataNastere.Value.Date.ToString("{^yyyy-MM-dd}") + "')");
            }
            catch (Exception ex)
            {

            }
            string firstAvailabileVehicle = bd.returnString("select MIN(flota.id_numeric) from flota where flota.id_numeric not in (select inchirieri.unitate_flota  from inchirieri where ora_plecare  + interval '1 hour' * ore > NOW()::time) and flota.vehicul =" + vehiculSelectat.ToString());
            if (firstAvailabileVehicle.Trim().Equals(""))
            {
                MsgBox eroare = new MsgBox("Nu mai sunt vehicule disponibile!", "OK!", true);
                return;
            }
            bd.execNonQuery("INSERT INTO inchirieri (cnp, ora_plecare, ore, unitate_flota) VALUES ('" + txtCNP.Text.Trim() + "', NOW(), " + cmbPerioada.Text + ", " + firstAvailabileVehicle.Trim() + ")");
            string codVehicul = bd.returnString("SELECT id from flota where id_numeric = " + firstAvailabileVehicle.Trim());
            MsgBox succes = new MsgBox("Predati spre inchiriere vehiculul cu codul " + codVehicul, "OK!", false);
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFlota_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            btnInchiriere.BackColor = buttonColor;
            btnHistory.BackColor = buttonColor;
            btnOngoing.BackColor = buttonColor;
            btnFlota.BackColor = selectedButtonColor;
        }

        private void grdFlota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddVehicul_Click(object sender, EventArgs e)
        {
            try
            {
                bd.execNonQuery("INSERT INTO flota (ID,vehicul) values ('" + txtCod.Text.Trim() + "'," + cmbTip.SelectedValue + ")");
                grdFlota.DataSource = bd.returnDataTable("SELECT flota.id, vehicule.nume FROM FLOTA LEFT JOIN VEHICULE on FLOTA.VEHICUL = VEHICULE.VEHICUL");
            }
            catch { MsgBox err = new MsgBox("Cod vehicul duplicat", "OK!", true); }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}