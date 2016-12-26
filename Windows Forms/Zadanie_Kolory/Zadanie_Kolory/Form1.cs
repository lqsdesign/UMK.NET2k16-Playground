using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_Kolory
{
    public partial class Form1 : Form
    {
        int radio_active = 0, radio_qty = 1;
        Panel colorPanel6 = new Panel();
        Panel colorPanel5 = new Panel();
        Panel colorPanel4 = new Panel();
        Panel colorPanel3 = new Panel();
        Panel colorPanel2 = new Panel();
        Panel colorPanel1 = new Panel();


        public Form1()
        {
            InitializeComponent();

            trackBar1_ValueChanged(null, null);
        }

        public void PanelConstructor()
        {
            colorPanel1.Visible = false;
            colorPanel2.Visible = false;
            colorPanel3.Visible = false;
            colorPanel4.Visible = false;
            colorPanel5.Visible = false;
            colorPanel6.Visible = false;
        }

        public string HexColor()
        {
            return trackBar1.Value.ToString("X2")+trackBar2.Value.ToString("X2")+ trackBar3.Value.ToString("X2");
        }

        private void SetRadioActive()
        {
            if (radioButton1.Checked == true)
            {
                radio_active = 0;
                int R = int.Parse(radioButton1.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(radioButton1.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(radioButton1.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                trackBar1.Value = R;
                trackBar2.Value = G;
                trackBar3.Value = B;
            }
            else if (radioButton2.Checked == true)
            {
                radio_active = 1;
                int R = int.Parse(radioButton2.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(radioButton2.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(radioButton2.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                trackBar1.Value = R;
                trackBar2.Value = G;
                trackBar3.Value = B;
            }
            else if (radioButton3.Checked == true)
            {
                radio_active = 2;
                int R = int.Parse(radioButton3.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(radioButton3.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(radioButton3.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                trackBar1.Value = R;
                trackBar2.Value = G;
                trackBar3.Value = B;
            }
            else if (radioButton4.Checked == true)
            {
                radio_active = 3;
                int R = int.Parse(radioButton4.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(radioButton4.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(radioButton4.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                trackBar1.Value = R;
                trackBar2.Value = G;
                trackBar3.Value = B;
            }
            else if (radioButton5.Checked == true)
            {
                radio_active = 4;
                int R = int.Parse(radioButton5.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(radioButton5.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(radioButton5.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                trackBar1.Value = R;
                trackBar2.Value = G;
                trackBar3.Value = B;
            }
            else if (radioButton6.Checked == true)
            {
                radio_active = 5;
                int R = int.Parse(radioButton6.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                int G = int.Parse(radioButton6.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                int B = int.Parse(radioButton6.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                trackBar1.Value = R;
                trackBar2.Value = G;
                trackBar3.Value = B;
            }          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] radioB = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            if (radio_qty < 6)
            {
                radioB[radio_qty].Text = "#" + HexColor();
                radioB[radio_qty].Visible = true;
                radioB[radio_qty].Checked = true;
                
                radio_qty++;
                
            }
            trackBar1_ValueChanged(null, null);
        } //button +

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetRadioActive();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        } //button close

        private void button4_Click(object sender, EventArgs e)
        {
            RadioButton[] radioB = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            radio_qty = 1;
            radio_active = 0;
            radioB[0].Checked = true;
            for (int i = 1; i < 6; i++){ radioB[i].Visible = false;}
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;

        } //button reset

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            RadioButton[] radioB = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            label1.Text = "R:" + trackBar1.Value.ToString();
            label2.Text = "G:" + trackBar2.Value.ToString();
            label3.Text = "B:" + trackBar3.Value.ToString();

            radioB[radio_active].Text = "#" + HexColor();

            for (int i = 0; i< radio_qty; i++)
            {
                CreatePanel(i);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioButton[] radioB = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            switch (radio_active)
                {
                case 0:
                    if (radio_qty > 1)
                    {
                        radio_qty--;
                        radioB[radio_qty].Visible = false;
                        TransferValue(radioButton1, radioButton2);
                        TransferValue(radioButton2, radioButton3);
                        TransferValue(radioButton3, radioButton4);
                        TransferValue(radioButton4, radioButton5);
                        TransferValue(radioButton5, radioButton6);
                        radioButton1.Checked = false;
                        radioButton1.Checked = true;
                    }
                    break;
                case 1:
                    radio_qty--;
                    radioB[radio_qty].Visible = false;
                    TransferValue(radioButton2, radioButton3);
                    TransferValue(radioButton3, radioButton4);
                    TransferValue(radioButton4, radioButton5);
                    TransferValue(radioButton5, radioButton6);
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radio_qty--;
                    radioB[radio_qty].Visible = false;
                    TransferValue(radioButton3, radioButton4);
                    TransferValue(radioButton4, radioButton5);
                    TransferValue(radioButton5, radioButton6);
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radio_qty--;
                    radioB[radio_qty].Visible = false;
                    TransferValue(radioButton4, radioButton5);
                    TransferValue(radioButton5, radioButton6);
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radio_qty--;
                    radioB[radio_qty].Visible = false;
                    TransferValue(radioButton5, radioButton6);
                    radioButton4.Checked = true;
                    break;
                case 5:
                    radio_qty--;
                    radioB[radio_qty].Visible = false;
                    radioButton5.Checked = true;
                    break;
                }
        } //button -

        private string TransferValue(RadioButton a, RadioButton b)
        {
            a.Text = b.Text;
            b.Text = "#000000";
            return a.Text;
        }

        private void button6_Click(object sender, EventArgs e) //button random
        {
            Random rng = new Random();
            trackBar1.Value = rng.Next(255);
            trackBar2.Value = rng.Next(255);
            trackBar3.Value = rng.Next(255);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string paleta = "";
            RadioButton[] radioB = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            
            for (int i = 0; i < radio_qty; i++)
            {
                paleta = paleta + radioB[i].Text + Environment.NewLine;
            }
            Clipboard.SetText(paleta);
        } //button export

        private void CreatePanel(int _i=0)
        {
            RadioButton[] radioB = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
            Panel[] panelArr = { colorPanel1, colorPanel2, colorPanel3, colorPanel4, colorPanel5, colorPanel6 };
            int red = int.Parse(radioB[_i].Text.Substring(1,2), System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(radioB[_i].Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(radioB[_i].Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);

            panelArr[_i].Left = 12+ (576/radio_qty)*_i;
            panelArr[_i].Top = 12;
            panelArr[_i].Width = 576 / radio_qty;
            panelArr[_i].Height = 109;
            panelArr[_i].BackColor = Color.FromArgb(red, green, blue);
            panelArr[_i].Parent = this;
            panelArr[_i].Visible = true;
        }
    }
}
