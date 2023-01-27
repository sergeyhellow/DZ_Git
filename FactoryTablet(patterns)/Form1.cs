using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryTablet_patterns_
{
    public partial class Form1 : Form
    {

        DeviceBuildier DeviceBuildier;
        Worker worker = new Worker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {

                case "Pad":
                    DeviceBuildier = new PadBuildier(new Pad());
                    var pad = worker.MakeDevise(DeviceBuildier, name_textBox.Text, screentextBox2.Text, Model_textBox.Text, body_textBox3.Text);
                    updateLabel(pad, label1);
                    break;

                case "Phone":
                    DeviceBuildier = new PhoneBuildier(new Pad());
                    var phone = worker.MakeDevise(DeviceBuildier, name_textBox.Text, screentextBox2.Text, Model_textBox.Text, body_textBox3.Text);
                    updateLabel(phone, label1);
                    break;

            }



        }

     

        
        private void updateLabel(IDevice device, System.Windows.Forms.Label label)
        {
            label.Text = device.Name + Environment.NewLine;
            label.Text += device.Screen + Environment.NewLine;
            label.Text += device.Body + Environment.NewLine;
            label.Text += device.Model + Environment.NewLine;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeviceStorrage.Instance.MakeReport());
        }
    }
}
