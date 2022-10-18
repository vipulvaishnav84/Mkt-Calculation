using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mkt_Calculation.mktcalculationcls;



namespace Mkt_Calculation
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        public void GetDataSeetings()
        {

            tbCelsius1.Text = Properties.Settings.Default.CelesiusData1.ToString();
            tbCelsius2.Text = Properties.Settings.Default.CelesiusData2.ToString();
            tbCelsius3.Text = Properties.Settings.Default.CelesiusData3.ToString();
            tbCelsius4.Text = Properties.Settings.Default.CelesiusData4.ToString();
            tbCelsius5.Text = Properties.Settings.Default.CelesiusData5.ToString();
            tbCelsius6.Text = Properties.Settings.Default.CelesiusData6.ToString();
            tbCelsius7.Text = Properties.Settings.Default.CelesiusData7.ToString();
            tbCelsius8.Text = Properties.Settings.Default.CelesiusData8.ToString();
            tbCelsius9.Text = Properties.Settings.Default.CelesiusData9.ToString();
            tbCelsius10.Text = Properties.Settings.Default.CelesiusData10.ToString();
            tbCelsius11.Text = Properties.Settings.Default.CelesiusData11.ToString();
            tbCelsius12.Text = Properties.Settings.Default.CelesiusData12.ToString();
            tbCelsius13.Text = Properties.Settings.Default.CelesiusData13.ToString();
            tbCelsius14.Text = Properties.Settings.Default.CelesiusData14.ToString();
            tbCelsius15.Text = Properties.Settings.Default.CelesiusData15.ToString();
            tbCelsius16.Text = Properties.Settings.Default.CelesiusData16.ToString();
            tbCelsius17.Text = Properties.Settings.Default.CelesiusData17.ToString();
            tbCelsius18.Text = Properties.Settings.Default.CelesiusData18.ToString();
            tbCelsius19.Text = Properties.Settings.Default.CelesiusData19.ToString();
            tbCelsius20.Text = Properties.Settings.Default.CelesiusData20.ToString();
            tbCelsius21.Text = Properties.Settings.Default.CelesiusData21.ToString();
            tbCelsius22.Text = Properties.Settings.Default.CelesiusData22.ToString();
            tbCelsius23.Text = Properties.Settings.Default.CelesiusData23.ToString();
            tbCelsius24.Text = Properties.Settings.Default.CelesiusData24.ToString();

        }


        public void SetDataSeetings()
        {

            Properties.Settings.Default.CelesiusData1 = Convert.ToDouble(tbCelsius1.Text);
            Properties.Settings.Default.CelesiusData2 = Convert.ToDouble(tbCelsius2.Text);
            Properties.Settings.Default.CelesiusData3 = Convert.ToDouble(tbCelsius3.Text);
            Properties.Settings.Default.CelesiusData4 = Convert.ToDouble(tbCelsius4.Text);
            Properties.Settings.Default.CelesiusData5 = Convert.ToDouble(tbCelsius5.Text);
            Properties.Settings.Default.CelesiusData6 = Convert.ToDouble(tbCelsius6.Text);
            Properties.Settings.Default.CelesiusData7 = Convert.ToDouble(tbCelsius7.Text);
            Properties.Settings.Default.CelesiusData8 = Convert.ToDouble(tbCelsius8.Text);
            Properties.Settings.Default.CelesiusData9 = Convert.ToDouble(tbCelsius9.Text);
            Properties.Settings.Default.CelesiusData10 = Convert.ToDouble(tbCelsius10.Text);
            Properties.Settings.Default.CelesiusData11 = Convert.ToDouble(tbCelsius11.Text);
            Properties.Settings.Default.CelesiusData12 = Convert.ToDouble(tbCelsius12.Text);
            Properties.Settings.Default.CelesiusData13 = Convert.ToDouble(tbCelsius13.Text);
            Properties.Settings.Default.CelesiusData14 = Convert.ToDouble(tbCelsius14.Text);
            Properties.Settings.Default.CelesiusData15 = Convert.ToDouble(tbCelsius15.Text);
            Properties.Settings.Default.CelesiusData16 = Convert.ToDouble(tbCelsius16.Text);
            Properties.Settings.Default.CelesiusData17 = Convert.ToDouble(tbCelsius17.Text);
            Properties.Settings.Default.CelesiusData18 = Convert.ToDouble(tbCelsius18.Text);
            Properties.Settings.Default.CelesiusData19 = Convert.ToDouble(tbCelsius19.Text);
            Properties.Settings.Default.CelesiusData20 = Convert.ToDouble(tbCelsius20.Text);
            Properties.Settings.Default.CelesiusData21 = Convert.ToDouble(tbCelsius21.Text);
            Properties.Settings.Default.CelesiusData22 = Convert.ToDouble(tbCelsius22.Text);
            Properties.Settings.Default.CelesiusData23 = Convert.ToDouble(tbCelsius23.Text);
            Properties.Settings.Default.CelesiusData24 = Convert.ToDouble(tbCelsius24.Text);

            Properties.Settings.Default.Save();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataSeetings();
            try
            {
                
                //GetDataSeetings();

                tbKelvin1.Text = CelsiustoKelvin(float.Parse(tbCelsius1.Text)).ToString();
                tbKelvin2.Text = CelsiustoKelvin(float.Parse(tbCelsius2.Text)).ToString();
                tbKelvin3.Text = CelsiustoKelvin(float.Parse(tbCelsius3.Text)).ToString();
                tbKelvin4.Text = CelsiustoKelvin(float.Parse(tbCelsius4.Text)).ToString();
                tbKelvin5.Text = CelsiustoKelvin(float.Parse(tbCelsius5.Text)).ToString();
                tbKelvin6.Text = CelsiustoKelvin(float.Parse(tbCelsius6.Text)).ToString();
                tbKelvin7.Text = CelsiustoKelvin(float.Parse(tbCelsius7.Text)).ToString();
                tbKelvin8.Text = CelsiustoKelvin(float.Parse(tbCelsius8.Text)).ToString();
                tbKelvin9.Text = CelsiustoKelvin(float.Parse(tbCelsius9.Text)).ToString();
                tbKelvin10.Text = CelsiustoKelvin(float.Parse(tbCelsius10.Text)).ToString();
                tbKelvin11.Text = CelsiustoKelvin(float.Parse(tbCelsius11.Text)).ToString();
                tbKelvin12.Text = CelsiustoKelvin(float.Parse(tbCelsius12.Text)).ToString();
                tbKelvin13.Text = CelsiustoKelvin(float.Parse(tbCelsius13.Text)).ToString();
                tbKelvin14.Text = CelsiustoKelvin(float.Parse(tbCelsius14.Text)).ToString();
                tbKelvin15.Text = CelsiustoKelvin(float.Parse(tbCelsius15.Text)).ToString();
                tbKelvin16.Text = CelsiustoKelvin(float.Parse(tbCelsius16.Text)).ToString();
                tbKelvin17.Text = CelsiustoKelvin(float.Parse(tbCelsius17.Text)).ToString();
                tbKelvin18.Text = CelsiustoKelvin(float.Parse(tbCelsius18.Text)).ToString();
                tbKelvin19.Text = CelsiustoKelvin(float.Parse(tbCelsius19.Text)).ToString();
                tbKelvin20.Text = CelsiustoKelvin(float.Parse(tbCelsius20.Text)).ToString();
                tbKelvin21.Text = CelsiustoKelvin(float.Parse(tbCelsius21.Text)).ToString();
                tbKelvin22.Text = CelsiustoKelvin(float.Parse(tbCelsius22.Text)).ToString();
                tbKelvin23.Text = CelsiustoKelvin(float.Parse(tbCelsius23.Text)).ToString();
                tbKelvin24.Text = CelsiustoKelvin(float.Parse(tbCelsius24.Text)).ToString();


                tbCalculationOfDenominator1.Text = CalculationOfDenominator(float.Parse(tbKelvin1.Text)).ToString();
                tbCalculationOfDenominator2.Text = CalculationOfDenominator(float.Parse(tbKelvin2.Text)).ToString();
                tbCalculationOfDenominator3.Text = CalculationOfDenominator(float.Parse(tbKelvin3.Text)).ToString();
                tbCalculationOfDenominator4.Text = CalculationOfDenominator(float.Parse(tbKelvin4.Text)).ToString();
                tbCalculationOfDenominator5.Text = CalculationOfDenominator(float.Parse(tbKelvin5.Text)).ToString();
                tbCalculationOfDenominator6.Text = CalculationOfDenominator(float.Parse(tbKelvin6.Text)).ToString();
                tbCalculationOfDenominator7.Text = CalculationOfDenominator(float.Parse(tbKelvin7.Text)).ToString();
                tbCalculationOfDenominator8.Text = CalculationOfDenominator(float.Parse(tbKelvin8.Text)).ToString();
                tbCalculationOfDenominator9.Text = CalculationOfDenominator(float.Parse(tbKelvin9.Text)).ToString();
                tbCalculationOfDenominator10.Text = CalculationOfDenominator(float.Parse(tbKelvin10.Text)).ToString();
                tbCalculationOfDenominator11.Text = CalculationOfDenominator(float.Parse(tbKelvin11.Text)).ToString();
                tbCalculationOfDenominator12.Text = CalculationOfDenominator(float.Parse(tbKelvin12.Text)).ToString();
                tbCalculationOfDenominator13.Text = CalculationOfDenominator(float.Parse(tbKelvin13.Text)).ToString();
                tbCalculationOfDenominator14.Text = CalculationOfDenominator(float.Parse(tbKelvin14.Text)).ToString();
                tbCalculationOfDenominator15.Text = CalculationOfDenominator(float.Parse(tbKelvin15.Text)).ToString();
                tbCalculationOfDenominator16.Text = CalculationOfDenominator(float.Parse(tbKelvin16.Text)).ToString();
                tbCalculationOfDenominator17.Text = CalculationOfDenominator(float.Parse(tbKelvin17.Text)).ToString();
                tbCalculationOfDenominator18.Text = CalculationOfDenominator(float.Parse(tbKelvin18.Text)).ToString();
                tbCalculationOfDenominator19.Text = CalculationOfDenominator(float.Parse(tbKelvin19.Text)).ToString();
                tbCalculationOfDenominator20.Text = CalculationOfDenominator(float.Parse(tbKelvin20.Text)).ToString();
                tbCalculationOfDenominator21.Text = CalculationOfDenominator(float.Parse(tbKelvin21.Text)).ToString();
                tbCalculationOfDenominator22.Text = CalculationOfDenominator(float.Parse(tbKelvin22.Text)).ToString();
                tbCalculationOfDenominator23.Text = CalculationOfDenominator(float.Parse(tbKelvin23.Text)).ToString();
                tbCalculationOfDenominator24.Text = CalculationOfDenominator(float.Parse(tbKelvin24.Text)).ToString();


                tbsumofallresults.Text = (Convert.ToDouble(tbCalculationOfDenominator1.Text) + Convert.ToDouble(tbCalculationOfDenominator2.Text) + 
                                          Convert.ToDouble(tbCalculationOfDenominator3.Text) + Convert.ToDouble(tbCalculationOfDenominator4.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator5.Text) + Convert.ToDouble(tbCalculationOfDenominator6.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator7.Text) + Convert.ToDouble(tbCalculationOfDenominator8.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator9.Text) + Convert.ToDouble(tbCalculationOfDenominator10.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator11.Text) + Convert.ToDouble(tbCalculationOfDenominator12.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator13.Text) + Convert.ToDouble(tbCalculationOfDenominator14.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator15.Text) + Convert.ToDouble(tbCalculationOfDenominator16.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator17.Text) + Convert.ToDouble(tbCalculationOfDenominator18.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator19.Text) + Convert.ToDouble(tbCalculationOfDenominator20.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator21.Text) + Convert.ToDouble(tbCalculationOfDenominator22.Text) +
                                         Convert.ToDouble(tbCalculationOfDenominator23.Text) +
                                        Convert.ToDouble(tbCalculationOfDenominator24.Text)).ToString();


                tbDivideTheresultOfTotalNumberOfReadings.Text = (Convert.ToDouble(tbsumofallresults.Text) / 24).ToString();



               string NL  = Math.Log(Convert.ToDouble(tbDivideTheresultOfTotalNumberOfReadings.Text)).ToString();

               double b = Convert.ToDouble(NL) * Convert.ToDouble("-1");
                
                tbNaturalLogarithm.Text = b.ToString();



                tbTemperatureinKelvin.Text = (CalculateNumerator / Convert.ToDouble(tbNaturalLogarithm.Text)).ToString();


                tbTemperatureinCelsius.Text = (Convert.ToDouble(tbTemperatureinKelvin.Text) - Convert.ToDouble("273.15")).ToString();

            }
            catch
            {

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Refresh This Data ?", "Refresh Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                  
                    Form1_Load(sender, e);
                }

            }
            catch
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Close This Application ?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    Application.Exit();
                    
                }

            }
            catch
            {

            }
        }

        void clearalldata()
        {
            tbCelsius1.Text = "";
            tbCelsius2.Text = "";
            tbCelsius3.Text = "";
            tbCelsius4.Text = "";
            tbCelsius5.Text = "";
            tbCelsius6.Text = "";
            tbCelsius7.Text = "";
            tbCelsius8.Text = "";
            tbCelsius9.Text = "";
            tbCelsius10.Text = "";
            tbCelsius11.Text = "";
            tbCelsius12.Text = "";
            tbCelsius13.Text = "";
            tbCelsius14.Text = "";
            tbCelsius15.Text = "";
            tbCelsius16.Text = "";
            tbCelsius17.Text = "";
            tbCelsius18.Text = "";
            tbCelsius19.Text = "";
            tbCelsius20.Text = "";
            tbCelsius21.Text = "";
            tbCelsius22.Text = "";
            tbCelsius23.Text = "";
            tbCelsius24.Text = "";

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Clear All Data ?", "Clear All Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    clearalldata();

                }

            }
            catch
            {

            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To save Your Celsius 24 Data ?", "save Your Celsius 24 Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    SetDataSeetings();
                    GetDataSeetings();

                }

            }
            catch
            {

            }
        }
    }
}
