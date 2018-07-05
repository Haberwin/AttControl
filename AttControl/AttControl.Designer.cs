namespace AttControl
{
    partial class AttControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Port1 = new System.Windows.Forms.ComboBox();
            this.AttO = new System.Windows.Forms.GroupBox();
            this.CurrentAtt1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeGap1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EndAtt1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartAtt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AttGap1 = new System.Windows.Forms.ComboBox();
            this.Rate1 = new System.Windows.Forms.TextBox();
            this.Cycles = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ATT1BT = new System.Windows.Forms.Button();
            this.ATT2BT = new System.Windows.Forms.Button();
            this.ATTN = new System.Windows.Forms.GroupBox();
            this.CurrentAtt2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeGap2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndAtt2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartAtt2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AttGap2 = new System.Windows.Forms.ComboBox();
            this.Rate2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Port2 = new System.Windows.Forms.ComboBox();
            this.RefreshBT = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CycleBt = new System.Windows.Forms.Button();
            this.AttO.SuspendLayout();
            this.ATTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // Port1
            // 
            this.Port1.FormattingEnabled = true;
            this.Port1.Location = new System.Drawing.Point(140, 33);
            this.Port1.Name = "Port1";
            this.Port1.Size = new System.Drawing.Size(121, 27);
            this.Port1.TabIndex = 2;
            // 
            // AttO
            // 
            this.AttO.Controls.Add(this.CurrentAtt1);
            this.AttO.Controls.Add(this.label17);
            this.AttO.Controls.Add(this.label14);
            this.AttO.Controls.Add(this.label13);
            this.AttO.Controls.Add(this.label10);
            this.AttO.Controls.Add(this.TimeGap1);
            this.AttO.Controls.Add(this.label9);
            this.AttO.Controls.Add(this.EndAtt1);
            this.AttO.Controls.Add(this.label4);
            this.AttO.Controls.Add(this.label3);
            this.AttO.Controls.Add(this.StartAtt1);
            this.AttO.Controls.Add(this.label2);
            this.AttO.Controls.Add(this.AttGap1);
            this.AttO.Controls.Add(this.Rate1);
            this.AttO.Controls.Add(this.label1);
            this.AttO.Controls.Add(this.Port1);
            this.AttO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttO.Location = new System.Drawing.Point(62, 20);
            this.AttO.Name = "AttO";
            this.AttO.Size = new System.Drawing.Size(293, 391);
            this.AttO.TabIndex = 3;
            this.AttO.TabStop = false;
            this.AttO.Text = "ATT1";
            // 
            // CurrentAtt1
            // 
            this.CurrentAtt1.AutoSize = true;
            this.CurrentAtt1.BackColor = System.Drawing.Color.Salmon;
            this.CurrentAtt1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAtt1.Location = new System.Drawing.Point(226, 326);
            this.CurrentAtt1.Name = "CurrentAtt1";
            this.CurrentAtt1.Size = new System.Drawing.Size(35, 37);
            this.CurrentAtt1.TabIndex = 16;
            this.CurrentAtt1.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Salmon;
            this.label17.Location = new System.Drawing.Point(6, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 19);
            this.label17.TabIndex = 15;
            this.label17.Text = "当前衰减值";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "衰减间隔";
            // 
            // TimeGap1
            // 
            this.TimeGap1.FormattingEnabled = true;
            this.TimeGap1.Items.AddRange(new object[] {
            "500ms",
            "1000ms"});
            this.TimeGap1.Location = new System.Drawing.Point(140, 269);
            this.TimeGap1.Name = "TimeGap1";
            this.TimeGap1.Size = new System.Drawing.Size(121, 27);
            this.TimeGap1.TabIndex = 11;
            this.TimeGap1.Text = "500ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "结束衰减";
            // 
            // EndAtt1
            // 
            this.EndAtt1.Location = new System.Drawing.Point(140, 171);
            this.EndAtt1.Name = "EndAtt1";
            this.EndAtt1.Size = new System.Drawing.Size(121, 26);
            this.EndAtt1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "衰减步进";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "初始衰减";
            // 
            // StartAtt1
            // 
            this.StartAtt1.Location = new System.Drawing.Point(140, 128);
            this.StartAtt1.Name = "StartAtt1";
            this.StartAtt1.Size = new System.Drawing.Size(121, 26);
            this.StartAtt1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud rate";
            // 
            // AttGap1
            // 
            this.AttGap1.FormattingEnabled = true;
            this.AttGap1.Items.AddRange(new object[] {
            "0.5dB",
            "1dB",
            "2dB",
            "3dB"});
            this.AttGap1.Location = new System.Drawing.Point(140, 219);
            this.AttGap1.Name = "AttGap1";
            this.AttGap1.Size = new System.Drawing.Size(121, 27);
            this.AttGap1.TabIndex = 4;
            this.AttGap1.Text = "1dB";
            // 
            // Rate1
            // 
            this.Rate1.Location = new System.Drawing.Point(140, 78);
            this.Rate1.Name = "Rate1";
            this.Rate1.Size = new System.Drawing.Size(121, 26);
            this.Rate1.TabIndex = 3;
            this.Rate1.Text = "115200";
            // 
            // Cycles
            // 
            this.Cycles.AutoSize = true;
            this.Cycles.BackColor = System.Drawing.Color.Lime;
            this.Cycles.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cycles.Location = new System.Drawing.Point(383, 325);
            this.Cycles.Name = "Cycles";
            this.Cycles.Size = new System.Drawing.Size(34, 38);
            this.Cycles.TabIndex = 17;
            this.Cycles.Text = "0";
            this.Cycles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Salmon;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(384, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 196);
            this.label18.TabIndex = 17;
            this.label18.Text = "当前循环次数";
            // 
            // ATT1BT
            // 
            this.ATT1BT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATT1BT.Location = new System.Drawing.Point(62, 427);
            this.ATT1BT.Name = "ATT1BT";
            this.ATT1BT.Size = new System.Drawing.Size(293, 77);
            this.ATT1BT.TabIndex = 5;
            this.ATT1BT.Text = "Start";
            this.ATT1BT.UseVisualStyleBackColor = true;
            this.ATT1BT.Click += new System.EventHandler(this.ATT1BT_Click);
            // 
            // ATT2BT
            // 
            this.ATT2BT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATT2BT.Location = new System.Drawing.Point(448, 427);
            this.ATT2BT.Name = "ATT2BT";
            this.ATT2BT.Size = new System.Drawing.Size(293, 77);
            this.ATT2BT.TabIndex = 7;
            this.ATT2BT.Text = "Start";
            this.ATT2BT.UseVisualStyleBackColor = true;
            this.ATT2BT.Click += new System.EventHandler(this.ATT2BT_Click);
            // 
            // ATTN
            // 
            this.ATTN.Controls.Add(this.CurrentAtt2);
            this.ATTN.Controls.Add(this.label21);
            this.ATTN.Controls.Add(this.label16);
            this.ATTN.Controls.Add(this.label5);
            this.ATTN.Controls.Add(this.TimeGap2);
            this.ATTN.Controls.Add(this.label6);
            this.ATTN.Controls.Add(this.EndAtt2);
            this.ATTN.Controls.Add(this.label7);
            this.ATTN.Controls.Add(this.label8);
            this.ATTN.Controls.Add(this.StartAtt2);
            this.ATTN.Controls.Add(this.label11);
            this.ATTN.Controls.Add(this.AttGap2);
            this.ATTN.Controls.Add(this.Rate2);
            this.ATTN.Controls.Add(this.label12);
            this.ATTN.Controls.Add(this.Port2);
            this.ATTN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATTN.Location = new System.Drawing.Point(448, 20);
            this.ATTN.Name = "ATTN";
            this.ATTN.Size = new System.Drawing.Size(293, 391);
            this.ATTN.TabIndex = 6;
            this.ATTN.TabStop = false;
            this.ATTN.Text = "ATT2";
            // 
            // CurrentAtt2
            // 
            this.CurrentAtt2.AutoSize = true;
            this.CurrentAtt2.BackColor = System.Drawing.Color.Salmon;
            this.CurrentAtt2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAtt2.Location = new System.Drawing.Point(226, 322);
            this.CurrentAtt2.Name = "CurrentAtt2";
            this.CurrentAtt2.Size = new System.Drawing.Size(35, 37);
            this.CurrentAtt2.TabIndex = 18;
            this.CurrentAtt2.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Salmon;
            this.label21.Location = new System.Drawing.Point(6, 336);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 19);
            this.label21.TabIndex = 17;
            this.label21.Text = "当前衰减值";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(116, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 19);
            this.label16.TabIndex = 14;
            this.label16.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "衰减间隔";
            // 
            // TimeGap2
            // 
            this.TimeGap2.FormattingEnabled = true;
            this.TimeGap2.Items.AddRange(new object[] {
            "500ms",
            "1000ms"});
            this.TimeGap2.Location = new System.Drawing.Point(140, 269);
            this.TimeGap2.Name = "TimeGap2";
            this.TimeGap2.Size = new System.Drawing.Size(121, 27);
            this.TimeGap2.TabIndex = 11;
            this.TimeGap2.Text = "500ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "结束衰减";
            // 
            // EndAtt2
            // 
            this.EndAtt2.Location = new System.Drawing.Point(140, 171);
            this.EndAtt2.Name = "EndAtt2";
            this.EndAtt2.Size = new System.Drawing.Size(121, 26);
            this.EndAtt2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "衰减步进";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "初始衰减";
            // 
            // StartAtt2
            // 
            this.StartAtt2.Location = new System.Drawing.Point(140, 128);
            this.StartAtt2.Name = "StartAtt2";
            this.StartAtt2.Size = new System.Drawing.Size(121, 26);
            this.StartAtt2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Baud rate";
            // 
            // AttGap2
            // 
            this.AttGap2.FormattingEnabled = true;
            this.AttGap2.Items.AddRange(new object[] {
            "0.5dB",
            "1dB",
            "2dB",
            "3dB"});
            this.AttGap2.Location = new System.Drawing.Point(140, 219);
            this.AttGap2.Name = "AttGap2";
            this.AttGap2.Size = new System.Drawing.Size(121, 27);
            this.AttGap2.TabIndex = 4;
            this.AttGap2.Text = "1dB";
            // 
            // Rate2
            // 
            this.Rate2.Location = new System.Drawing.Point(140, 78);
            this.Rate2.Name = "Rate2";
            this.Rate2.Size = new System.Drawing.Size(121, 26);
            this.Rate2.TabIndex = 3;
            this.Rate2.Text = "115200";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Port";
            // 
            // Port2
            // 
            this.Port2.FormattingEnabled = true;
            this.Port2.Location = new System.Drawing.Point(140, 33);
            this.Port2.Name = "Port2";
            this.Port2.Size = new System.Drawing.Size(121, 27);
            this.Port2.TabIndex = 2;
            // 
            // RefreshBT
            // 
            this.RefreshBT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBT.Location = new System.Drawing.Point(796, 12);
            this.RefreshBT.Name = "RefreshBT";
            this.RefreshBT.Size = new System.Drawing.Size(304, 53);
            this.RefreshBT.TabIndex = 8;
            this.RefreshBT.Text = "Refresh Port";
            this.RefreshBT.UseVisualStyleBackColor = true;
            this.RefreshBT.Click += new System.EventHandler(this.RefreshBT_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.Location = new System.Drawing.Point(796, 92);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(304, 486);
            this.Log.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(555, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "-";
            // 
            // CycleBt
            // 
            this.CycleBt.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CycleBt.Location = new System.Drawing.Point(236, 510);
            this.CycleBt.Name = "CycleBt";
            this.CycleBt.Size = new System.Drawing.Size(346, 106);
            this.CycleBt.TabIndex = 18;
            this.CycleBt.Text = "循环测试";
            this.CycleBt.UseVisualStyleBackColor = true;
            this.CycleBt.Click += new System.EventHandler(this.CycleBt_Click);
            // 
            // AttControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 620);
            this.Controls.Add(this.CycleBt);
            this.Controls.Add(this.Cycles);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.RefreshBT);
            this.Controls.Add(this.ATT2BT);
            this.Controls.Add(this.ATTN);
            this.Controls.Add(this.ATT1BT);
            this.Controls.Add(this.AttO);
            this.Name = "AttControl";
            this.Text = "AttControl";
            this.Load += new System.EventHandler(this.AttControl_Load);
            this.AttO.ResumeLayout(false);
            this.AttO.PerformLayout();
            this.ATTN.ResumeLayout(false);
            this.ATTN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Port1;
        private System.Windows.Forms.GroupBox AttO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AttGap1;
        private System.Windows.Forms.TextBox Rate1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TimeGap1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EndAtt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartAtt1;
        private System.Windows.Forms.Button ATT1BT;
        private System.Windows.Forms.Button ATT2BT;
        private System.Windows.Forms.GroupBox ATTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TimeGap2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndAtt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StartAtt2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox AttGap2;
        private System.Windows.Forms.TextBox Rate2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Port2;
        private System.Windows.Forms.Button RefreshBT;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label CurrentAtt1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CurrentAtt2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label Cycles;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button CycleBt;
    }
}

