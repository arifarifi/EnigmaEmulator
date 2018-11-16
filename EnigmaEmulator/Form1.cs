using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaEmulator
{
    public partial class Form1 : Form
    {

        private Rotor rr, rm, rl, reflector;

        private void btnRotor1Down_Click(object sender, EventArgs e)
        {
            rr.MoveBack();
        }

        private void btnRotor2Down_Click(object sender, EventArgs e)
        {
            rm.MoveBack();
        }

        private void btnRotor2Up_Click(object sender, EventArgs e)
        {
            rm.Move();
        }

        private void btnRotor3Down_Click(object sender, EventArgs e)
        {
            rl.MoveBack();
        }

        private void btnRotor3Up_Click(object sender, EventArgs e)
        {
            rl.Move();
        }

        private void btnRotor1Up_Click(object sender, EventArgs e)
        {
            rr.Move();
        }

        private void cmbR2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indeksi1 = cmbR1.SelectedIndex;
            int indeksi2 = cmbR2.SelectedIndex;
            int indeksi3 = cmbR3.SelectedIndex;
            int reflektori = cmbReflector.SelectedIndex;

            string[] rotors = new string[]{"EKMFLGDQVZNTOWYHXUSPAIBRCJ", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "BDFHJLCPRTXVZNYEIWGAKMUSQO",
            "ESOVPZJAYQUIRHXLNFTGKDCMWB","VZBRGITYUPSDNHLXAWMJQOFECK"};
            string[] notches = new string[] { "Q", "E", "V", "J", "Z" };
            string[] reflectors = new string[] { "YRUHQSLDPXNGOKMIEBFZCWVJAT", "FVPJIAOYEDRZXWGCTKUQSBNMHL" };

            ChangeRotors(rotors[indeksi1].ToString(), notches[indeksi1].ToString().ToCharArray()[0],
                rotors[indeksi2].ToString(), notches[indeksi2].ToString().ToCharArray()[0],
                rotors[indeksi3].ToString(), notches[indeksi3].ToString().ToCharArray()[0],
                reflectors[reflektori].ToString());
        }

        private void cmbR3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indeksi1 = cmbR1.SelectedIndex;
            int indeksi2 = cmbR2.SelectedIndex;
            int indeksi3 = cmbR3.SelectedIndex;
            int reflektori = cmbReflector.SelectedIndex;

            string[] rotors = new string[]{"EKMFLGDQVZNTOWYHXUSPAIBRCJ", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "BDFHJLCPRTXVZNYEIWGAKMUSQO",
            "ESOVPZJAYQUIRHXLNFTGKDCMWB","VZBRGITYUPSDNHLXAWMJQOFECK"};
            string[] notches = new string[] { "Q", "E", "V", "J", "Z" };
            string[] reflectors = new string[] { "YRUHQSLDPXNGOKMIEBFZCWVJAT", "FVPJIAOYEDRZXWGCTKUQSBNMHL" };

            ChangeRotors(rotors[indeksi1].ToString(), notches[indeksi1].ToString().ToCharArray()[0],
                rotors[indeksi2].ToString(), notches[indeksi2].ToString().ToCharArray()[0],
                rotors[indeksi3].ToString(), notches[indeksi3].ToString().ToCharArray()[0],
                reflectors[reflektori].ToString());
        }

        private void cmbReflector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indeksi1 = cmbR1.SelectedIndex;
            int indeksi2 = cmbR2.SelectedIndex;
            int indeksi3 = cmbR3.SelectedIndex;
            int reflektori = cmbReflector.SelectedIndex;

            string[] rotors = new string[]{"EKMFLGDQVZNTOWYHXUSPAIBRCJ", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "BDFHJLCPRTXVZNYEIWGAKMUSQO",
            "ESOVPZJAYQUIRHXLNFTGKDCMWB","VZBRGITYUPSDNHLXAWMJQOFECK"};
            string[] notches = new string[] { "Q", "E", "V", "J", "Z" };
            string[] reflectors = new string[] { "YRUHQSLDPXNGOKMIEBFZCWVJAT", "FVPJIAOYEDRZXWGCTKUQSBNMHL" };

            ChangeRotors(rotors[indeksi1].ToString(), notches[indeksi1].ToString().ToCharArray()[0],
                rotors[indeksi2].ToString(), notches[indeksi2].ToString().ToCharArray()[0],
                rotors[indeksi3].ToString(), notches[indeksi3].ToString().ToCharArray()[0],
                reflectors[reflektori].ToString());
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char vchar = e.KeyChar;
            e.KeyChar = Char.ToUpper(vchar);
            if(!Char.IsLetter(vchar) && !Char.IsControl(vchar))
            {
                e.Handled = true;
            }
            if (txtInput.Text.Length != 0 && txtOutput.Text.Length != 0) 
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1, 1);
                    rr.MoveBack();
                }
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) && !e.Control)
            {
                rr.Move();
                rr.PutDataIn((char)e.KeyValue);
                txtOutput.AppendText("" + rr.GetDataOut());
            }
        }

        public Form1()
        {
            InitializeComponent();
            
            cmbR1.SelectedIndex = 2;
            cmbR2.SelectedIndex = 1;
            cmbR3.SelectedIndex = 0;
            cmbReflector.SelectedIndex = 0;

            rr = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", lblRotor1, 'V');
            rm = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", lblRotor2, 'E');
            rl = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", lblRotor3, 'Q');
            reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');


            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);
        }

        private void cmbR1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indeksi1 = cmbR1.SelectedIndex;
            int indeksi2 = cmbR2.SelectedIndex;
            int indeksi3 = cmbR3.SelectedIndex;
            int reflektori = cmbReflector.SelectedIndex;

            string[] rotors = new string[]{"EKMFLGDQVZNTOWYHXUSPAIBRCJ", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "BDFHJLCPRTXVZNYEIWGAKMUSQO",
            "ESOVPZJAYQUIRHXLNFTGKDCMWB","VZBRGITYUPSDNHLXAWMJQOFECK"};
            string[] notches = new string[] { "Q", "E", "V", "J", "Z" };
            string[] reflectors = new string[] { "YRUHQSLDPXNGOKMIEBFZCWVJAT", "FVPJIAOYEDRZXWGCTKUQSBNMHL" };

            ChangeRotors(rotors[indeksi1].ToString(), notches[indeksi1].ToString().ToCharArray()[0],
                rotors[indeksi2].ToString(), notches[indeksi2].ToString().ToCharArray()[0],
                rotors[indeksi3].ToString(), notches[indeksi3].ToString().ToCharArray()[0],
                reflectors[reflektori].ToString());
        }

        public void ChangeRotors(string rot1, char rotNotch1, string rot2,
        char rotNotch2, string rot3, char rotNotch3,string refl)
        {
            rr = null;
            rm = null;
            rl = null;

            rr = new Rotor(rot1, lblRotor1, rotNotch3);
            rm = new Rotor(rot2, lblRotor2, rotNotch2);
            rl = new Rotor(rot3, lblRotor3, rotNotch1);
            reflector = new Rotor(refl, null, '\0');

            rr.ResetOffset();
            rm.ResetOffset();
            rl.ResetOffset();

            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);

            lblRotor1.Text = "A";
            lblRotor2.Text = "A";
            lblRotor3.Text = "A";
        }
    }
    
    public class Rotor
    {
        private string layout;
        private byte offset;
        private Rotor previous, next;
        private Label lbl;
        private char cIn = '\0', notchPos;

        public Rotor(string layout,Label lbl,char notchPos)
        {
            this.layout = layout;
            this.previous = previous;
            this.next = next;
            this.lbl = lbl;
            this.notchPos = notchPos;
            offset = 0;
        }
        public string GetLayout()
        {
            return this.layout;
        }
        public void SetNextRotor(Rotor next)
        {
            this.next = next;
        }
        public void SetPreviousRotor(Rotor previous)
        {
            this.previous = previous;
        }
        public char GetInverseCharAt(string ch)
        {
            int pozita = layout.IndexOf(ch);

            if (offset > pozita)
            {
                pozita = 26 - (offset - pozita);
            }
            else
            {
                pozita = pozita - offset;
            }

            if (previous != null)
            {
                pozita = (pozita + previous.GetOffset()) % 26;
            }

            return (char)(65 + pozita);
        }

        private int GetOffset()
        {
            return offset;
        }
        public char GetNotchPos()
        {
            return notchPos;
        }

        public void ResetOffset()
        {
            offset = 0;
        }

        public bool HasNext()
        {
            return next != null;
        }

        public bool HasPrevious()
        {
            return previous != null;
        }
        public void Move()
        {
            if(next==null)
            {
                return;
            }
            offset++;
            if (offset == 26)
            {
                offset = 0;
            }
            if(next!=null && (offset+66)==((notchPos-64)%26)+66)
            {
                next.Move();
            }
            lbl.Text = "" + ((char)(65 + offset));
        }
        public void MoveBack()
        {
            if(offset == 0)
            {
                offset = 26;
            }
            offset--;

            lbl.Text = "" + ((char)(65 + offset));
        }
        public void PutDataIn(char s)
        {
            cIn = s;
            char c = s;
            c = (char)(((c - 65) + offset) % 26 + 65);

            if (next != null)
            {
                c = layout.Substring((c - 65), 1).ToArray()[0];
                if ((((c - 65) + (-offset)) % 26 + 65) >= 65)
                {
                    c=(char)(((c-65) + (-offset)) % 26 + 65);
                }
                else
                {
                    c = (char)(((c - 65) + (26 + (-offset))) % 26 + 65);
                }
                next.PutDataIn(c);
            }
        }
        public char GetDataOut()
        {
            char c = '\0';

            if(next!=null)
            {
                c = next.GetDataOut();
                c = GetInverseCharAt("" + c);
            }
            else
            {
                c = layout.Substring((cIn - 65), 1).ToArray()[0];
                c = (char)(((c - 65) + previous.offset) % 26 + 65);
            }

            return c;
        }
    }

    
}
