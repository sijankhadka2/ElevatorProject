
namespace OOPsAssignment
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updoors_open = new System.Windows.Forms.Timer(this.components);
            this.updoors_close = new System.Windows.Forms.Timer(this.components);
            this.downdoors_open = new System.Windows.Forms.Timer(this.components);
            this.downdoors_close = new System.Windows.Forms.Timer(this.components);
            this.go_up = new System.Windows.Forms.Timer(this.components);
            this.go_down = new System.Windows.Forms.Timer(this.components);
            this.logDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new OOPsAssignment.AppData();
            this.log_DetailsTableAdapter = new OOPsAssignment.AppDataTableAdapters.Log_DetailsTableAdapter();
            this.exit = new System.Windows.Forms.Button();
            this.timer_close = new System.Windows.Forms.Timer(this.components);
            this.G_display = new System.Windows.Forms.PictureBox();
            this.F_display = new System.Windows.Forms.PictureBox();
            this.request_F = new System.Windows.Forms.Button();
            this.request_G = new System.Windows.Forms.Button();
            this.lift_display = new System.Windows.Forms.PictureBox();
            this.btn_opendoor = new System.Windows.Forms.Button();
            this.btn_closedoors = new System.Windows.Forms.Button();
            this.btn_groundFloor = new System.Windows.Forms.Button();
            this.btn_firstFloor = new System.Windows.Forms.Button();
            this.door_downR = new System.Windows.Forms.PictureBox();
            this.door_upR = new System.Windows.Forms.PictureBox();
            this.door_downL = new System.Windows.Forms.PictureBox();
            this.door_upL = new System.Windows.Forms.PictureBox();
            this.liftbox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_downR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_downL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // updoors_open
            // 
            this.updoors_open.Interval = 1;
            this.updoors_open.Tick += new System.EventHandler(this.updoors_open_Tick);
            // 
            // updoors_close
            // 
            this.updoors_close.Interval = 1;
            this.updoors_close.Tick += new System.EventHandler(this.updoors_close_Tick);
            // 
            // downdoors_open
            // 
            this.downdoors_open.Interval = 1;
            this.downdoors_open.Tick += new System.EventHandler(this.downdoors_open_Tick);
            // 
            // downdoors_close
            // 
            this.downdoors_close.Interval = 1;
            this.downdoors_close.Tick += new System.EventHandler(this.downdoors_close_Tick);
            // 
            // go_up
            // 
            this.go_up.Interval = 1;
            this.go_up.Tick += new System.EventHandler(this.go_up_Tick);
            // 
            // go_down
            // 
            this.go_down.Interval = 1;
            this.go_down.Tick += new System.EventHandler(this.go_down_Tick);
            // 
            // logDetailsBindingSource
            // 
            this.logDetailsBindingSource.DataMember = "Log_Details";
            this.logDetailsBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // log_DetailsTableAdapter
            // 
            this.log_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1062, 85);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(68, 35);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer_close
            // 
            this.timer_close.Interval = 5000;
            this.timer_close.Tick += new System.EventHandler(this.timer_close_Tick);
            // 
            // G_display
            // 
            this.G_display.BackColor = System.Drawing.SystemColors.Desktop;
            this.G_display.Location = new System.Drawing.Point(95, 426);
            this.G_display.Margin = new System.Windows.Forms.Padding(2);
            this.G_display.Name = "G_display";
            this.G_display.Size = new System.Drawing.Size(47, 23);
            this.G_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.G_display.TabIndex = 14;
            this.G_display.TabStop = false;
            // 
            // F_display
            // 
            this.F_display.BackColor = System.Drawing.SystemColors.Desktop;
            this.F_display.Location = new System.Drawing.Point(95, 113);
            this.F_display.Margin = new System.Windows.Forms.Padding(2);
            this.F_display.Name = "F_display";
            this.F_display.Size = new System.Drawing.Size(47, 23);
            this.F_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F_display.TabIndex = 14;
            this.F_display.TabStop = false;
            // 
            // request_F
            // 
            this.request_F.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.request_F.BackgroundImage = global::OOPsAssignment.Properties.Resources.direction_north;
            this.request_F.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.request_F.Location = new System.Drawing.Point(372, 554);
            this.request_F.Margin = new System.Windows.Forms.Padding(2);
            this.request_F.Name = "request_F";
            this.request_F.Size = new System.Drawing.Size(42, 44);
            this.request_F.TabIndex = 13;
            this.request_F.UseVisualStyleBackColor = false;
            this.request_F.Click += new System.EventHandler(this.request_F_Click);
            // 
            // request_G
            // 
            this.request_G.BackgroundImage = global::OOPsAssignment.Properties.Resources.direction_south;
            this.request_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.request_G.Location = new System.Drawing.Point(371, 193);
            this.request_G.Margin = new System.Windows.Forms.Padding(2);
            this.request_G.Name = "request_G";
            this.request_G.Size = new System.Drawing.Size(43, 44);
            this.request_G.TabIndex = 12;
            this.request_G.UseVisualStyleBackColor = true;
            this.request_G.Click += new System.EventHandler(this.request_G_Click);
            // 
            // lift_display
            // 
            this.lift_display.BackColor = System.Drawing.SystemColors.Desktop;
            this.lift_display.Location = new System.Drawing.Point(498, 85);
            this.lift_display.Margin = new System.Windows.Forms.Padding(2);
            this.lift_display.Name = "lift_display";
            this.lift_display.Size = new System.Drawing.Size(106, 140);
            this.lift_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lift_display.TabIndex = 11;
            this.lift_display.TabStop = false;
            // 
            // btn_opendoor
            // 
            this.btn_opendoor.BackgroundImage = global::OOPsAssignment.Properties.Resources.open_door;
            this.btn_opendoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_opendoor.Location = new System.Drawing.Point(568, 426);
            this.btn_opendoor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_opendoor.Name = "btn_opendoor";
            this.btn_opendoor.Size = new System.Drawing.Size(48, 46);
            this.btn_opendoor.TabIndex = 7;
            this.btn_opendoor.UseVisualStyleBackColor = true;
            this.btn_opendoor.Click += new System.EventHandler(this.btn_opendoor_Click);
            // 
            // btn_closedoors
            // 
            this.btn_closedoors.BackgroundImage = global::OOPsAssignment.Properties.Resources.close_door;
            this.btn_closedoors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_closedoors.Location = new System.Drawing.Point(488, 426);
            this.btn_closedoors.Margin = new System.Windows.Forms.Padding(2);
            this.btn_closedoors.Name = "btn_closedoors";
            this.btn_closedoors.Size = new System.Drawing.Size(52, 46);
            this.btn_closedoors.TabIndex = 6;
            this.btn_closedoors.UseVisualStyleBackColor = true;
            this.btn_closedoors.Click += new System.EventHandler(this.btn_closedoors_Click);
            // 
            // btn_groundFloor
            // 
            this.btn_groundFloor.BackgroundImage = global::OOPsAssignment.Properties.Resources.groundFloor;
            this.btn_groundFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_groundFloor.Location = new System.Drawing.Point(529, 335);
            this.btn_groundFloor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_groundFloor.Name = "btn_groundFloor";
            this.btn_groundFloor.Size = new System.Drawing.Size(44, 46);
            this.btn_groundFloor.TabIndex = 5;
            this.btn_groundFloor.UseVisualStyleBackColor = true;
            this.btn_groundFloor.Click += new System.EventHandler(this.btn_groundFloor_Click);
            // 
            // btn_firstFloor
            // 
            this.btn_firstFloor.AutoSize = true;
            this.btn_firstFloor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_firstFloor.BackgroundImage = global::OOPsAssignment.Properties.Resources.firstFloor;
            this.btn_firstFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_firstFloor.Location = new System.Drawing.Point(529, 258);
            this.btn_firstFloor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_firstFloor.Name = "btn_firstFloor";
            this.btn_firstFloor.Size = new System.Drawing.Size(44, 46);
            this.btn_firstFloor.TabIndex = 4;
            this.btn_firstFloor.UseVisualStyleBackColor = false;
            this.btn_firstFloor.Click += new System.EventHandler(this.btn_firstFloor_Click);
            // 
            // door_downR
            // 
            this.door_downR.Image = global::OOPsAssignment.Properties.Resources.door_panel_R;
            this.door_downR.Location = new System.Drawing.Point(276, 462);
            this.door_downR.Margin = new System.Windows.Forms.Padding(2);
            this.door_downR.Name = "door_downR";
            this.door_downR.Size = new System.Drawing.Size(77, 274);
            this.door_downR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_downR.TabIndex = 3;
            this.door_downR.TabStop = false;
            // 
            // door_upR
            // 
            this.door_upR.Image = global::OOPsAssignment.Properties.Resources.door_panel_R;
            this.door_upR.Location = new System.Drawing.Point(276, 85);
            this.door_upR.Margin = new System.Windows.Forms.Padding(2);
            this.door_upR.Name = "door_upR";
            this.door_upR.Size = new System.Drawing.Size(77, 274);
            this.door_upR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_upR.TabIndex = 3;
            this.door_upR.TabStop = false;
            // 
            // door_downL
            // 
            this.door_downL.Image = global::OOPsAssignment.Properties.Resources.door_panel;
            this.door_downL.Location = new System.Drawing.Point(201, 462);
            this.door_downL.Margin = new System.Windows.Forms.Padding(2);
            this.door_downL.Name = "door_downL";
            this.door_downL.Size = new System.Drawing.Size(77, 274);
            this.door_downL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_downL.TabIndex = 2;
            this.door_downL.TabStop = false;
            // 
            // door_upL
            // 
            this.door_upL.Image = global::OOPsAssignment.Properties.Resources.door_panel;
            this.door_upL.Location = new System.Drawing.Point(201, 85);
            this.door_upL.Margin = new System.Windows.Forms.Padding(2);
            this.door_upL.Name = "door_upL";
            this.door_upL.Size = new System.Drawing.Size(77, 274);
            this.door_upL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_upL.TabIndex = 2;
            this.door_upL.TabStop = false;
            // 
            // liftbox
            // 
            this.liftbox.Image = global::OOPsAssignment.Properties.Resources.inside_life;
            this.liftbox.Location = new System.Drawing.Point(201, 462);
            this.liftbox.Margin = new System.Windows.Forms.Padding(2);
            this.liftbox.Name = "liftbox";
            this.liftbox.Size = new System.Drawing.Size(152, 274);
            this.liftbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liftbox.TabIndex = 8;
            this.liftbox.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OOPsAssignment.Properties.Resources.door_frame;
            this.pictureBox5.Location = new System.Drawing.Point(189, 447);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(178, 289);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPsAssignment.Properties.Resources.door_frame;
            this.pictureBox1.Location = new System.Drawing.Point(189, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OOPsAssignment.Properties.Resources.plank;
            this.pictureBox3.Location = new System.Drawing.Point(471, 71);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(158, 488);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OOPsAssignment.Properties.Resources.bg_elevatorl;
            this.pictureBox4.Location = new System.Drawing.Point(36, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(393, 330);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::OOPsAssignment.Properties.Resources.bg_elevatorl;
            this.pictureBox7.Location = new System.Drawing.Point(36, 401);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(393, 320);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 419);
            this.textBox1.TabIndex = 21;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(784, 506);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 22;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.G_display);
            this.Controls.Add(this.F_display);
            this.Controls.Add(this.request_F);
            this.Controls.Add(this.request_G);
            this.Controls.Add(this.lift_display);
            this.Controls.Add(this.btn_opendoor);
            this.Controls.Add(this.btn_closedoors);
            this.Controls.Add(this.btn_groundFloor);
            this.Controls.Add(this.btn_firstFloor);
            this.Controls.Add(this.door_downR);
            this.Controls.Add(this.door_upR);
            this.Controls.Add(this.door_downL);
            this.Controls.Add(this.door_upL);
            this.Controls.Add(this.liftbox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_downR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_downL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_upL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox door_upL;
        private System.Windows.Forms.PictureBox door_upR;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox door_downL;
        private System.Windows.Forms.PictureBox door_downR;
        private System.Windows.Forms.Button btn_firstFloor;
        private System.Windows.Forms.Button btn_groundFloor;
        private System.Windows.Forms.Button btn_closedoors;
        private System.Windows.Forms.Button btn_opendoor;
        private System.Windows.Forms.Timer updoors_open;
        private System.Windows.Forms.Timer updoors_close;
        private System.Windows.Forms.Timer downdoors_open;
        private System.Windows.Forms.Timer downdoors_close;
        private System.Windows.Forms.Timer go_up;
        private System.Windows.Forms.Timer go_down;
        private System.Windows.Forms.PictureBox liftbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox lift_display;
        private System.Windows.Forms.Button request_G;
        private System.Windows.Forms.Button request_F;
        private System.Windows.Forms.PictureBox F_display;
        private System.Windows.Forms.PictureBox G_display;
        private AppData appData;
        private System.Windows.Forms.BindingSource logDetailsBindingSource;
        private AppDataTableAdapters.Log_DetailsTableAdapter log_DetailsTableAdapter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer_close;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button refresh;
    }
}

