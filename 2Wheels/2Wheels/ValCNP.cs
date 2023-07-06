using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2Wheels
{
    public static class ValCNP
    {
        public static bool validare(string cnp)
        {
            if (cnp.Trim().Length != 13)
                return false;
            Regex doarNumere = new Regex("^\\d+$");
            if (!doarNumere.IsMatch(cnp)) 
                return false;
            string control = "279146358279";
            int sumaControl = 0;
            for (int i = 0; i<12; i++)
            {
                sumaControl += Int32.Parse(cnp[i].ToString()) * Int32.Parse(control[i].ToString());
            }
            int cifraControl = (sumaControl % 11 == 10) ? 1 : sumaControl % 11;
            int ultimaCifraCNP = Int32.Parse(cnp[12].ToString());
            return ultimaCifraCNP == cifraControl;
        }

        public static bool verificaDate(Form1 formaCuDate)
        {
            if (formaCuDate.txtNume.Text.Trim().Length == 0)
            {
                MsgBox eroare = new MsgBox("Nume vid invalid!", "Inapoi", true);
                return false;
            }
            if (formaCuDate.txtPrenume.Text.Trim().Length == 0)
            {
                MsgBox eroare = new MsgBox("Prenume vid invalid!", "Inapoi", true);
                return false;
            }
            if (formaCuDate.txtCNP.Text.Trim().Length == 0)
            {
                MsgBox eroare = new MsgBox("CNP vid invalid!", "Inapoi", true);
                return false;
            }


            if (formaCuDate.txtSerieBuletin.Text.Trim().Length == 0)
            {
                MsgBox eroare = new MsgBox("Serie buletin vida invalid!", "Inapoi", true);
                return false;
            }

            if ((DateTime.Now.Date - formaCuDate.dtpDataNastere.Value.Date).Days / 365 < 18)
            {
                MsgBox eroare = new MsgBox("Minorii nu pot inchiria vehicule!", "Inapoi", true);
                return false;
            }
            return true;
        }

    }
}
