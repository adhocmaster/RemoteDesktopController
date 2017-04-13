using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using RDPCOMAPILib;
using AxRDPCOMAPILib;

using System.Threading;

using System.Security.Permissions;
using Microsoft.Win32;
using System.Diagnostics;



namespace WPFRemoteController
{
    public class Form1 : Form
    {
        private Button button1;
        private TextBox textConnectionString;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        //private AxMSTSCLib.AxMsTscAxNotSafeForScripting axRDPViewer;

        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer;
        private Label label2;

        KeyboardMouseControl keyMouse = new KeyboardMouseControl();

        public Form1()
        {
            InitializeComponent();

        }

        
        public static void Connect(string invitation, AxRDPViewer display, string userName, string password)
        {
            display.Connect(invitation, userName, password);
        }

        public static void disconnect(AxRDPViewer display)
        {
            display.Disconnect();
        }

        
        
        public void takeControl()
        {
            try
            {
                Connect(textConnectionString.Text, this.axRDPViewer, "", "");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to the Server");
            }
        }
        

        private void textConnectionString_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

               
        private void axRDPViewer_Enter(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axRDPViewer = new AxRDPCOMAPILib.AxRDPViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.textConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // axRDPViewer
            // 
            this.axRDPViewer.Enabled = true;
            this.axRDPViewer.Location = new System.Drawing.Point(22, 12);
            this.axRDPViewer.Name = "axRDPViewer";
            this.axRDPViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRDPViewer.OcxState")));
            this.axRDPViewer.Size = new System.Drawing.Size(860, 354);
            this.axRDPViewer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textConnectionString
            // 
            this.textConnectionString.Location = new System.Drawing.Point(127, 443);
            this.textConnectionString.Name = "textConnectionString";
            this.textConnectionString.Size = new System.Drawing.Size(273, 20);
            this.textConnectionString.TabIndex = 2;
            this.textConnectionString.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connection String";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Enable Mouse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(757, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Enable Keyboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Disable Mouse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(757, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Disable Keyboard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Press esc anytime to enable mouse and keyboard";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textConnectionString);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axRDPViewer);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            takeControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keyMouse.mouseEnable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            keyMouse.keyEnable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            keyMouse.mouseDisable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            keyMouse.keyDisable();
        }

       
    }
}
