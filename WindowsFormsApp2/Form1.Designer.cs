using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        //Initilize elements
        public static Label StatusLabel;
        public static Label ServerLabel;
        public static Label DBLabel;
        public static Label TableLabel;
        public static TextBox ServerNameTb;
        public static TextBox ComandTb;
        public static ComboBox DbCb;
        public static ComboBox TableCb;
        public static Button ConnectBtn;
        public static Button TestBtn;
        public static Button DoBtn;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // Form1
            this.Size = new Size(400, 400);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);

            //ServerLabel create 
            ServerLabel = new Label();
            ServerLabel.Text = "Server name:";
            ServerLabel.Location = new Point(10, 10);
            //DbLabel create
            DBLabel = new Label();
            DBLabel.Text = "Data base:";
            DBLabel.Location = new Point(10, 50);
            //TadleLabel create
            TableLabel = new Label();
            TableLabel.Text = "Table:";
            TableLabel.Location = new Point(10, 90);
            //StatusLabel create
            StatusLabel = new Label();
            StatusLabel.Text = "Status:\r\n";
            StatusLabel.Location = new Point(300, 290);
            StatusLabel.Size = new Size(60, 60);
            //ServerNameTb create
            ServerNameTb = new TextBox();
            ServerNameTb.Text = "Server1";
            ServerNameTb.Size = new Size(200, 50);
            ServerNameTb.Location = new Point(110, 10);
            ServerNameTb.MaxLength = 25;
            //ComandTb create
            ComandTb = new TextBox();
            ComandTb.Size = new Size(200, 200);
            ComandTb.Multiline = true;
            ComandTb.Location = new Point(20, 150);
            //ConnectBtn create
            ConnectBtn = new Button();
            ConnectBtn.Text = "Connect";
            ConnectBtn.Size = new Size(60, 20);
            ConnectBtn.Location = new Point(320, 10);
            ConnectBtn.Click += ConnectBtn_click;
            //TestBtn create
            TestBtn = new Button();
            TestBtn.Text = "Test";
            TestBtn.Size = new Size(60, 20);
            TestBtn.Location = new Point(290, 220);
            //TestBtn.Click += testBtn_click;
            //DoBtn create
            DoBtn = new Button();
            DoBtn.Text = "Do";
            DoBtn.Size = new Size(60, 20);
            DoBtn.Location = new Point(290, 250);
            DoBtn.Click += DoBtn_Click;
            //DbCb
            DbCb = new ComboBox();
            DbCb.Size = new Size(200, 20);
            DbCb.Location = new Point(110, 50);
            DbCb.SelectedIndexChanged += DbCb_SelectedIndexChanged;
            //TableCb
            TableCb = new ComboBox();
            TableCb.Size = new Size(200, 20);
            TableCb.Location = new Point(110, 90);
            TableCb.SelectedIndexChanged += TableCb_SelectedIndexChanged;
            //Add to Form1
            this.Controls.Add(ServerLabel);
            this.Controls.Add(DBLabel);
            this.Controls.Add(TableLabel);
            this.Controls.Add(StatusLabel);
            this.Controls.Add(ServerNameTb);
            this.Controls.Add(ComandTb);
            this.Controls.Add(ConnectBtn);
            this.Controls.Add(TestBtn);
            this.Controls.Add(DoBtn);
            this.Controls.Add(DbCb);
            this.Controls.Add(TableCb);
        }

        
        #endregion
    }
}

