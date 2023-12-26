
namespace Presensi
{
    partial class Admin
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
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_clearEvent = new System.Windows.Forms.Button();
            this.btn_deleteEvent = new System.Windows.Forms.Button();
            this.btn_updateEvent = new System.Windows.Forms.Button();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.cb_assignedID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.tb_namaEvent = new System.Windows.Forms.TextBox();
            this.tb_id2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_exportAtt = new System.Windows.Forms.Button();
            this.btn_updateAtt = new System.Windows.Forms.Button();
            this.btn_clearAtt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_id3 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(528, 331);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(202, 26);
            this.tb_password.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 632);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.tb_id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.tb_username);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cb_tier);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_password);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(774, 438);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 28);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(528, 255);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(202, 26);
            this.tb_id.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(483, 438);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 28);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(633, 438);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 28);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(528, 293);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(202, 26);
            this.tb_username.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(338, 438);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 28);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // cb_tier
            // 
            this.cb_tier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tier.FormattingEnabled = true;
            this.cb_tier.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_tier.Location = new System.Drawing.Point(528, 365);
            this.cb_tier.Name = "cb_tier";
            this.cb_tier.Size = new System.Drawing.Size(202, 28);
            this.cb_tier.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tier:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_clearEvent);
            this.tabPage2.Controls.Add(this.btn_deleteEvent);
            this.tabPage2.Controls.Add(this.btn_updateEvent);
            this.tabPage2.Controls.Add(this.btn_addEvent);
            this.tabPage2.Controls.Add(this.cb_assignedID);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtp1);
            this.tabPage2.Controls.Add(this.tb_namaEvent);
            this.tabPage2.Controls.Add(this.tb_id2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Event";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_clearEvent
            // 
            this.btn_clearEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearEvent.Location = new System.Drawing.Point(774, 438);
            this.btn_clearEvent.Name = "btn_clearEvent";
            this.btn_clearEvent.Size = new System.Drawing.Size(75, 28);
            this.btn_clearEvent.TabIndex = 13;
            this.btn_clearEvent.Text = "Clear";
            this.btn_clearEvent.UseVisualStyleBackColor = true;
            this.btn_clearEvent.Click += new System.EventHandler(this.btn_clearEvent_Click);
            // 
            // btn_deleteEvent
            // 
            this.btn_deleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteEvent.Location = new System.Drawing.Point(633, 438);
            this.btn_deleteEvent.Name = "btn_deleteEvent";
            this.btn_deleteEvent.Size = new System.Drawing.Size(75, 28);
            this.btn_deleteEvent.TabIndex = 12;
            this.btn_deleteEvent.Text = "Delete";
            this.btn_deleteEvent.UseVisualStyleBackColor = true;
            this.btn_deleteEvent.Click += new System.EventHandler(this.btn_deleteEvent_Click);
            // 
            // btn_updateEvent
            // 
            this.btn_updateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateEvent.Location = new System.Drawing.Point(483, 438);
            this.btn_updateEvent.Name = "btn_updateEvent";
            this.btn_updateEvent.Size = new System.Drawing.Size(75, 28);
            this.btn_updateEvent.TabIndex = 11;
            this.btn_updateEvent.Text = "Update";
            this.btn_updateEvent.UseVisualStyleBackColor = true;
            this.btn_updateEvent.Click += new System.EventHandler(this.btn_updateEvent_Click);
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEvent.Location = new System.Drawing.Point(338, 438);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(75, 28);
            this.btn_addEvent.TabIndex = 10;
            this.btn_addEvent.Text = "Add";
            this.btn_addEvent.UseVisualStyleBackColor = true;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // cb_assignedID
            // 
            this.cb_assignedID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_assignedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_assignedID.FormattingEnabled = true;
            this.cb_assignedID.Location = new System.Drawing.Point(528, 331);
            this.cb_assignedID.Name = "cb_assignedID";
            this.cb_assignedID.Size = new System.Drawing.Size(202, 28);
            this.cb_assignedID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tanggal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Assigned ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID:";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(528, 368);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(202, 20);
            this.dtp1.TabIndex = 4;
            // 
            // tb_namaEvent
            // 
            this.tb_namaEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namaEvent.Location = new System.Drawing.Point(528, 293);
            this.tb_namaEvent.Name = "tb_namaEvent";
            this.tb_namaEvent.Size = new System.Drawing.Size(202, 26);
            this.tb_namaEvent.TabIndex = 2;
            // 
            // tb_id2
            // 
            this.tb_id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id2.Location = new System.Drawing.Point(528, 255);
            this.tb_id2.Name = "tb_id2";
            this.tb_id2.ReadOnly = true;
            this.tb_id2.Size = new System.Drawing.Size(202, 26);
            this.tb_id2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1226, 169);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_exportAtt);
            this.tabPage3.Controls.Add(this.btn_updateAtt);
            this.tabPage3.Controls.Add(this.btn_clearAtt);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cb_status);
            this.tabPage3.Controls.Add(this.tb_id3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 606);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Attendance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_exportAtt
            // 
            this.btn_exportAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportAtt.Location = new System.Drawing.Point(720, 361);
            this.btn_exportAtt.Name = "btn_exportAtt";
            this.btn_exportAtt.Size = new System.Drawing.Size(75, 28);
            this.btn_exportAtt.TabIndex = 11;
            this.btn_exportAtt.Text = "Export";
            this.btn_exportAtt.UseVisualStyleBackColor = true;
            this.btn_exportAtt.Click += new System.EventHandler(this.btn_exportAtt_Click);
            // 
            // btn_updateAtt
            // 
            this.btn_updateAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateAtt.Location = new System.Drawing.Point(558, 361);
            this.btn_updateAtt.Name = "btn_updateAtt";
            this.btn_updateAtt.Size = new System.Drawing.Size(75, 28);
            this.btn_updateAtt.TabIndex = 10;
            this.btn_updateAtt.Text = "Update";
            this.btn_updateAtt.UseVisualStyleBackColor = true;
            this.btn_updateAtt.Click += new System.EventHandler(this.btn_updateAtt_Click);
            // 
            // btn_clearAtt
            // 
            this.btn_clearAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearAtt.Location = new System.Drawing.Point(394, 361);
            this.btn_clearAtt.Name = "btn_clearAtt";
            this.btn_clearAtt.Size = new System.Drawing.Size(75, 28);
            this.btn_clearAtt.TabIndex = 9;
            this.btn_clearAtt.Text = "Clear";
            this.btn_clearAtt.UseVisualStyleBackColor = true;
            this.btn_clearAtt.Click += new System.EventHandler(this.btn_clearAtt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(409, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID:";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Bolos"});
            this.cb_status.Location = new System.Drawing.Point(528, 293);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(202, 28);
            this.cb_status.TabIndex = 4;
            // 
            // tb_id3
            // 
            this.tb_id3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id3.Location = new System.Drawing.Point(528, 255);
            this.tb_id3.Name = "tb_id3";
            this.tb_id3.ReadOnly = true;
            this.tb_id3.Size = new System.Drawing.Size(202, 26);
            this.tb_id3.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1226, 169);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(1170, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 28);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(19, 12);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(52, 17);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "label5";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tier;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cb_assignedID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox tb_namaEvent;
        private System.Windows.Forms.TextBox tb_id2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_clearEvent;
        private System.Windows.Forms.Button btn_deleteEvent;
        private System.Windows.Forms.Button btn_updateEvent;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_clearAtt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_id3;
        private System.Windows.Forms.Button btn_updateAtt;
        private System.Windows.Forms.Button btn_exportAtt;
    }
}