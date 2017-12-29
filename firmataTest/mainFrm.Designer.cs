namespace firmataTest
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.bridgeTimer = new System.Windows.Forms.Timer(this.components);
      this.tabGauges = new System.Windows.Forms.TabControl();
      this.turnCoordinatorTab = new System.Windows.Forms.TabPage();
      this.turnCoordinatorBallPosEnabled = new System.Windows.Forms.CheckBox();
      this.turnBallPosOffsetValue = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.turnBallPosMapOutputMaxText = new System.Windows.Forms.TextBox();
      this.turnBallPosMapOutputMinText = new System.Windows.Forms.TextBox();
      this.turnBallPosMapInputMaxText = new System.Windows.Forms.TextBox();
      this.turnBallPosMapInputMinText = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.turnBallPosPinNr = new System.Windows.Forms.NumericUpDown();
      this.label16 = new System.Windows.Forms.Label();
      this.turnBallPosModifiedValueLabel = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.turnBallPosValueLabel = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.turnCoordinatorTurnRateEnabled = new System.Windows.Forms.CheckBox();
      this.turnRateOffsetValue = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.turnRateMapOutputMaxText = new System.Windows.Forms.TextBox();
      this.turnRateMapOutputMinText = new System.Windows.Forms.TextBox();
      this.turnRateMapInputMaxText = new System.Windows.Forms.TextBox();
      this.turnRateMapInputMinText = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.turnRatePinNr = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.turnRateModifiedValueLabel = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.turnRateValueLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.firmataPortsSelection = new System.Windows.Forms.ComboBox();
      this.button4 = new System.Windows.Forms.Button();
      this.TASEnabled = new System.Windows.Forms.CheckBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label17 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.TASMapOutputMaxText = new System.Windows.Forms.TextBox();
      this.TASMapOutputMinText = new System.Windows.Forms.TextBox();
      this.TASMapInputMaxText = new System.Windows.Forms.TextBox();
      this.TASMapInputMinText = new System.Windows.Forms.TextBox();
      this.label24 = new System.Windows.Forms.Label();
      this.TASpinnr = new System.Windows.Forms.NumericUpDown();
      this.label25 = new System.Windows.Forms.Label();
      this.TASModValueLabel = new System.Windows.Forms.Label();
      this.label27 = new System.Windows.Forms.Label();
      this.TASValueLabel = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label26 = new System.Windows.Forms.Label();
      this.label28 = new System.Windows.Forms.Label();
      this.label30 = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.startStopLabel = new System.Windows.Forms.Label();
      this.tabGauges.SuspendLayout();
      this.turnCoordinatorTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.turnBallPosOffsetValue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnBallPosPinNr)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnRateOffsetValue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnRatePinNr)).BeginInit();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TASpinnr)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(143, 317);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(132, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Start Bridge";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(16, 387);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(132, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Test LED Pin 13 On";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(16, 416);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(132, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Test LED Pin 13 Off";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // bridgeTimer
      // 
      this.bridgeTimer.Tick += new System.EventHandler(this.bridgeTimer_Tick);
      // 
      // tabGauges
      // 
      this.tabGauges.Controls.Add(this.turnCoordinatorTab);
      this.tabGauges.Controls.Add(this.tabPage1);
      this.tabGauges.Controls.Add(this.tabPage2);
      this.tabGauges.Location = new System.Drawing.Point(12, 12);
      this.tabGauges.Name = "tabGauges";
      this.tabGauges.SelectedIndex = 0;
      this.tabGauges.Size = new System.Drawing.Size(896, 297);
      this.tabGauges.TabIndex = 5;
      // 
      // turnCoordinatorTab
      // 
      this.turnCoordinatorTab.Controls.Add(this.turnCoordinatorBallPosEnabled);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosOffsetValue);
      this.turnCoordinatorTab.Controls.Add(this.label1);
      this.turnCoordinatorTab.Controls.Add(this.label11);
      this.turnCoordinatorTab.Controls.Add(this.label12);
      this.turnCoordinatorTab.Controls.Add(this.label13);
      this.turnCoordinatorTab.Controls.Add(this.label14);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosMapOutputMaxText);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosMapOutputMinText);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosMapInputMaxText);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosMapInputMinText);
      this.turnCoordinatorTab.Controls.Add(this.label15);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosPinNr);
      this.turnCoordinatorTab.Controls.Add(this.label16);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosModifiedValueLabel);
      this.turnCoordinatorTab.Controls.Add(this.label18);
      this.turnCoordinatorTab.Controls.Add(this.turnBallPosValueLabel);
      this.turnCoordinatorTab.Controls.Add(this.label20);
      this.turnCoordinatorTab.Controls.Add(this.turnCoordinatorTurnRateEnabled);
      this.turnCoordinatorTab.Controls.Add(this.turnRateOffsetValue);
      this.turnCoordinatorTab.Controls.Add(this.label10);
      this.turnCoordinatorTab.Controls.Add(this.label9);
      this.turnCoordinatorTab.Controls.Add(this.label8);
      this.turnCoordinatorTab.Controls.Add(this.label7);
      this.turnCoordinatorTab.Controls.Add(this.label6);
      this.turnCoordinatorTab.Controls.Add(this.turnRateMapOutputMaxText);
      this.turnCoordinatorTab.Controls.Add(this.turnRateMapOutputMinText);
      this.turnCoordinatorTab.Controls.Add(this.turnRateMapInputMaxText);
      this.turnCoordinatorTab.Controls.Add(this.turnRateMapInputMinText);
      this.turnCoordinatorTab.Controls.Add(this.label5);
      this.turnCoordinatorTab.Controls.Add(this.turnRatePinNr);
      this.turnCoordinatorTab.Controls.Add(this.label3);
      this.turnCoordinatorTab.Controls.Add(this.turnRateModifiedValueLabel);
      this.turnCoordinatorTab.Controls.Add(this.label4);
      this.turnCoordinatorTab.Controls.Add(this.turnRateValueLabel);
      this.turnCoordinatorTab.Controls.Add(this.label2);
      this.turnCoordinatorTab.Location = new System.Drawing.Point(4, 22);
      this.turnCoordinatorTab.Name = "turnCoordinatorTab";
      this.turnCoordinatorTab.Padding = new System.Windows.Forms.Padding(3);
      this.turnCoordinatorTab.Size = new System.Drawing.Size(888, 271);
      this.turnCoordinatorTab.TabIndex = 0;
      this.turnCoordinatorTab.Text = "Turn Coordinator Gauge";
      this.turnCoordinatorTab.UseVisualStyleBackColor = true;
      // 
      // turnCoordinatorBallPosEnabled
      // 
      this.turnCoordinatorBallPosEnabled.AutoSize = true;
      this.turnCoordinatorBallPosEnabled.Location = new System.Drawing.Point(377, 228);
      this.turnCoordinatorBallPosEnabled.Name = "turnCoordinatorBallPosEnabled";
      this.turnCoordinatorBallPosEnabled.Size = new System.Drawing.Size(65, 17);
      this.turnCoordinatorBallPosEnabled.TabIndex = 36;
      this.turnCoordinatorBallPosEnabled.Text = "Enabled";
      this.turnCoordinatorBallPosEnabled.UseVisualStyleBackColor = true;
      // 
      // turnBallPosOffsetValue
      // 
      this.turnBallPosOffsetValue.Location = new System.Drawing.Point(526, 187);
      this.turnBallPosOffsetValue.Name = "turnBallPosOffsetValue";
      this.turnBallPosOffsetValue.Size = new System.Drawing.Size(58, 20);
      this.turnBallPosOffsetValue.TabIndex = 35;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(374, 189);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 34;
      this.label1.Text = "Offset:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(632, 155);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(39, 13);
      this.label11.TabIndex = 33;
      this.label11.Text = "Output";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(632, 129);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(31, 13);
      this.label12.TabIndex = 32;
      this.label12.Text = "Input";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(527, 110);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(51, 13);
      this.label13.TabIndex = 31;
      this.label13.Text = "Maximum";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(409, 110);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(48, 13);
      this.label14.TabIndex = 30;
      this.label14.Text = "Minimum";
      // 
      // turnBallPosMapOutputMaxText
      // 
      this.turnBallPosMapOutputMaxText.Location = new System.Drawing.Point(526, 152);
      this.turnBallPosMapOutputMaxText.Name = "turnBallPosMapOutputMaxText";
      this.turnBallPosMapOutputMaxText.Size = new System.Drawing.Size(100, 20);
      this.turnBallPosMapOutputMaxText.TabIndex = 29;
      this.turnBallPosMapOutputMaxText.Text = "110";
      // 
      // turnBallPosMapOutputMinText
      // 
      this.turnBallPosMapOutputMinText.Location = new System.Drawing.Point(412, 152);
      this.turnBallPosMapOutputMinText.Name = "turnBallPosMapOutputMinText";
      this.turnBallPosMapOutputMinText.Size = new System.Drawing.Size(100, 20);
      this.turnBallPosMapOutputMinText.TabIndex = 28;
      this.turnBallPosMapOutputMinText.Text = "70";
      // 
      // turnBallPosMapInputMaxText
      // 
      this.turnBallPosMapInputMaxText.Location = new System.Drawing.Point(526, 126);
      this.turnBallPosMapInputMaxText.Name = "turnBallPosMapInputMaxText";
      this.turnBallPosMapInputMaxText.Size = new System.Drawing.Size(100, 20);
      this.turnBallPosMapInputMaxText.TabIndex = 27;
      this.turnBallPosMapInputMaxText.Text = "127";
      // 
      // turnBallPosMapInputMinText
      // 
      this.turnBallPosMapInputMinText.Location = new System.Drawing.Point(412, 126);
      this.turnBallPosMapInputMinText.Name = "turnBallPosMapInputMinText";
      this.turnBallPosMapInputMinText.Size = new System.Drawing.Size(100, 20);
      this.turnBallPosMapInputMinText.TabIndex = 26;
      this.turnBallPosMapInputMinText.Text = "-127";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(374, 82);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(51, 13);
      this.label15.TabIndex = 25;
      this.label15.Text = "Mapping:";
      // 
      // turnBallPosPinNr
      // 
      this.turnBallPosPinNr.Location = new System.Drawing.Point(526, 55);
      this.turnBallPosPinNr.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
      this.turnBallPosPinNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.turnBallPosPinNr.Name = "turnBallPosPinNr";
      this.turnBallPosPinNr.Size = new System.Drawing.Size(58, 20);
      this.turnBallPosPinNr.TabIndex = 24;
      this.turnBallPosPinNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(374, 55);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(107, 13);
      this.label16.TabIndex = 23;
      this.label16.Text = "Turn Ball Firmata Pin:";
      // 
      // turnBallPosModifiedValueLabel
      // 
      this.turnBallPosModifiedValueLabel.AutoSize = true;
      this.turnBallPosModifiedValueLabel.Location = new System.Drawing.Point(523, 25);
      this.turnBallPosModifiedValueLabel.Name = "turnBallPosModifiedValueLabel";
      this.turnBallPosModifiedValueLabel.Size = new System.Drawing.Size(27, 13);
      this.turnBallPosModifiedValueLabel.TabIndex = 22;
      this.turnBallPosModifiedValueLabel.Text = "N/A";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(374, 25);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(138, 13);
      this.label18.TabIndex = 21;
      this.label18.Text = "Turn Ball Position Modified: ";
      // 
      // turnBallPosValueLabel
      // 
      this.turnBallPosValueLabel.AutoSize = true;
      this.turnBallPosValueLabel.Location = new System.Drawing.Point(523, 12);
      this.turnBallPosValueLabel.Name = "turnBallPosValueLabel";
      this.turnBallPosValueLabel.Size = new System.Drawing.Size(27, 13);
      this.turnBallPosValueLabel.TabIndex = 20;
      this.turnBallPosValueLabel.Text = "N/A";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label20.Location = new System.Drawing.Point(374, 12);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(92, 13);
      this.label20.TabIndex = 19;
      this.label20.Text = "Turn Ball Position:";
      // 
      // turnCoordinatorTurnRateEnabled
      // 
      this.turnCoordinatorTurnRateEnabled.AutoSize = true;
      this.turnCoordinatorTurnRateEnabled.Location = new System.Drawing.Point(21, 228);
      this.turnCoordinatorTurnRateEnabled.Name = "turnCoordinatorTurnRateEnabled";
      this.turnCoordinatorTurnRateEnabled.Size = new System.Drawing.Size(65, 17);
      this.turnCoordinatorTurnRateEnabled.TabIndex = 18;
      this.turnCoordinatorTurnRateEnabled.Text = "Enabled";
      this.turnCoordinatorTurnRateEnabled.UseVisualStyleBackColor = true;
      // 
      // turnRateOffsetValue
      // 
      this.turnRateOffsetValue.Location = new System.Drawing.Point(137, 187);
      this.turnRateOffsetValue.Name = "turnRateOffsetValue";
      this.turnRateOffsetValue.Size = new System.Drawing.Size(58, 20);
      this.turnRateOffsetValue.TabIndex = 17;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(18, 189);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(38, 13);
      this.label10.TabIndex = 16;
      this.label10.Text = "Offset:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(243, 155);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(39, 13);
      this.label9.TabIndex = 15;
      this.label9.Text = "Output";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(243, 129);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(31, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "Input";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(138, 110);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(51, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Maximum";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(28, 110);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Minimum";
      // 
      // turnRateMapOutputMaxText
      // 
      this.turnRateMapOutputMaxText.Location = new System.Drawing.Point(137, 152);
      this.turnRateMapOutputMaxText.Name = "turnRateMapOutputMaxText";
      this.turnRateMapOutputMaxText.Size = new System.Drawing.Size(100, 20);
      this.turnRateMapOutputMaxText.TabIndex = 11;
      this.turnRateMapOutputMaxText.Text = "0";
      // 
      // turnRateMapOutputMinText
      // 
      this.turnRateMapOutputMinText.Location = new System.Drawing.Point(31, 152);
      this.turnRateMapOutputMinText.Name = "turnRateMapOutputMinText";
      this.turnRateMapOutputMinText.Size = new System.Drawing.Size(100, 20);
      this.turnRateMapOutputMinText.TabIndex = 10;
      this.turnRateMapOutputMinText.Text = "180";
      // 
      // turnRateMapInputMaxText
      // 
      this.turnRateMapInputMaxText.Location = new System.Drawing.Point(137, 126);
      this.turnRateMapInputMaxText.Name = "turnRateMapInputMaxText";
      this.turnRateMapInputMaxText.Size = new System.Drawing.Size(100, 20);
      this.turnRateMapInputMaxText.TabIndex = 9;
      this.turnRateMapInputMaxText.Text = "2500";
      // 
      // turnRateMapInputMinText
      // 
      this.turnRateMapInputMinText.Location = new System.Drawing.Point(31, 126);
      this.turnRateMapInputMinText.Name = "turnRateMapInputMinText";
      this.turnRateMapInputMinText.Size = new System.Drawing.Size(100, 20);
      this.turnRateMapInputMinText.TabIndex = 8;
      this.turnRateMapInputMinText.Text = "-2500";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 82);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(51, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Mapping:";
      // 
      // turnRatePinNr
      // 
      this.turnRatePinNr.Location = new System.Drawing.Point(137, 53);
      this.turnRatePinNr.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
      this.turnRatePinNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.turnRatePinNr.Name = "turnRatePinNr";
      this.turnRatePinNr.Size = new System.Drawing.Size(58, 20);
      this.turnRatePinNr.TabIndex = 6;
      this.turnRatePinNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 55);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Turn Rate Firmata Pin:";
      // 
      // turnRateModifiedValueLabel
      // 
      this.turnRateModifiedValueLabel.AutoSize = true;
      this.turnRateModifiedValueLabel.Location = new System.Drawing.Point(134, 25);
      this.turnRateModifiedValueLabel.Name = "turnRateModifiedValueLabel";
      this.turnRateModifiedValueLabel.Size = new System.Drawing.Size(27, 13);
      this.turnRateModifiedValueLabel.TabIndex = 4;
      this.turnRateModifiedValueLabel.Text = "N/A";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 25);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(104, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Turn Rate Modified: ";
      // 
      // turnRateValueLabel
      // 
      this.turnRateValueLabel.AutoSize = true;
      this.turnRateValueLabel.Location = new System.Drawing.Point(134, 12);
      this.turnRateValueLabel.Name = "turnRateValueLabel";
      this.turnRateValueLabel.Size = new System.Drawing.Size(27, 13);
      this.turnRateValueLabel.TabIndex = 1;
      this.turnRateValueLabel.Text = "N/A";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(18, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Turn Rate Raw:";
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.TASEnabled);
      this.tabPage1.Controls.Add(this.numericUpDown1);
      this.tabPage1.Controls.Add(this.label17);
      this.tabPage1.Controls.Add(this.label19);
      this.tabPage1.Controls.Add(this.label21);
      this.tabPage1.Controls.Add(this.label22);
      this.tabPage1.Controls.Add(this.label23);
      this.tabPage1.Controls.Add(this.TASMapOutputMaxText);
      this.tabPage1.Controls.Add(this.TASMapOutputMinText);
      this.tabPage1.Controls.Add(this.TASMapInputMaxText);
      this.tabPage1.Controls.Add(this.TASMapInputMinText);
      this.tabPage1.Controls.Add(this.label24);
      this.tabPage1.Controls.Add(this.TASpinnr);
      this.tabPage1.Controls.Add(this.label25);
      this.tabPage1.Controls.Add(this.TASModValueLabel);
      this.tabPage1.Controls.Add(this.label27);
      this.tabPage1.Controls.Add(this.TASValueLabel);
      this.tabPage1.Controls.Add(this.label29);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(888, 271);
      this.tabPage1.TabIndex = 1;
      this.tabPage1.Text = "TAS";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // firmataPortsSelection
      // 
      this.firmataPortsSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.firmataPortsSelection.FormattingEnabled = true;
      this.firmataPortsSelection.Location = new System.Drawing.Point(16, 317);
      this.firmataPortsSelection.Name = "firmataPortsSelection";
      this.firmataPortsSelection.Size = new System.Drawing.Size(121, 21);
      this.firmataPortsSelection.TabIndex = 6;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(281, 317);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(132, 23);
      this.button4.TabIndex = 7;
      this.button4.Text = "Stop Bridge";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // TASEnabled
      // 
      this.TASEnabled.AutoSize = true;
      this.TASEnabled.Location = new System.Drawing.Point(21, 228);
      this.TASEnabled.Name = "TASEnabled";
      this.TASEnabled.Size = new System.Drawing.Size(65, 17);
      this.TASEnabled.TabIndex = 36;
      this.TASEnabled.Text = "Enabled";
      this.TASEnabled.UseVisualStyleBackColor = true;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(137, 187);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
      this.numericUpDown1.TabIndex = 35;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(18, 189);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(38, 13);
      this.label17.TabIndex = 34;
      this.label17.Text = "Offset:";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(243, 155);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(39, 13);
      this.label19.TabIndex = 33;
      this.label19.Text = "Output";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(243, 129);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(31, 13);
      this.label21.TabIndex = 32;
      this.label21.Text = "Input";
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Location = new System.Drawing.Point(138, 110);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(51, 13);
      this.label22.TabIndex = 31;
      this.label22.Text = "Maximum";
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(28, 110);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(48, 13);
      this.label23.TabIndex = 30;
      this.label23.Text = "Minimum";
      // 
      // TASMapOutputMaxText
      // 
      this.TASMapOutputMaxText.Location = new System.Drawing.Point(137, 152);
      this.TASMapOutputMaxText.Name = "TASMapOutputMaxText";
      this.TASMapOutputMaxText.Size = new System.Drawing.Size(100, 20);
      this.TASMapOutputMaxText.TabIndex = 29;
      this.TASMapOutputMaxText.Text = "180";
      // 
      // TASMapOutputMinText
      // 
      this.TASMapOutputMinText.Location = new System.Drawing.Point(31, 152);
      this.TASMapOutputMinText.Name = "TASMapOutputMinText";
      this.TASMapOutputMinText.Size = new System.Drawing.Size(100, 20);
      this.TASMapOutputMinText.TabIndex = 28;
      this.TASMapOutputMinText.Text = "0";
      // 
      // TASMapInputMaxText
      // 
      this.TASMapInputMaxText.Location = new System.Drawing.Point(137, 126);
      this.TASMapInputMaxText.Name = "TASMapInputMaxText";
      this.TASMapInputMaxText.Size = new System.Drawing.Size(100, 20);
      this.TASMapInputMaxText.TabIndex = 27;
      this.TASMapInputMaxText.Text = "200";
      // 
      // TASMapInputMinText
      // 
      this.TASMapInputMinText.Location = new System.Drawing.Point(31, 126);
      this.TASMapInputMinText.Name = "TASMapInputMinText";
      this.TASMapInputMinText.Size = new System.Drawing.Size(100, 20);
      this.TASMapInputMinText.TabIndex = 26;
      this.TASMapInputMinText.Text = "0";
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(18, 82);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(51, 13);
      this.label24.TabIndex = 25;
      this.label24.Text = "Mapping:";
      // 
      // TASpinnr
      // 
      this.TASpinnr.Location = new System.Drawing.Point(137, 53);
      this.TASpinnr.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
      this.TASpinnr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.TASpinnr.Name = "TASpinnr";
      this.TASpinnr.Size = new System.Drawing.Size(58, 20);
      this.TASpinnr.TabIndex = 24;
      this.TASpinnr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Location = new System.Drawing.Point(18, 55);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(86, 13);
      this.label25.TabIndex = 23;
      this.label25.Text = "TAS Firmata Pin:";
      // 
      // TASModValueLabel
      // 
      this.TASModValueLabel.AutoSize = true;
      this.TASModValueLabel.Location = new System.Drawing.Point(134, 25);
      this.TASModValueLabel.Name = "TASModValueLabel";
      this.TASModValueLabel.Size = new System.Drawing.Size(27, 13);
      this.TASModValueLabel.TabIndex = 22;
      this.TASModValueLabel.Text = "N/A";
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.Location = new System.Drawing.Point(18, 25);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(77, 13);
      this.label27.TabIndex = 21;
      this.label27.Text = "TAS Modified :";
      // 
      // TASValueLabel
      // 
      this.TASValueLabel.AutoSize = true;
      this.TASValueLabel.Location = new System.Drawing.Point(134, 12);
      this.TASValueLabel.Name = "TASValueLabel";
      this.TASValueLabel.Size = new System.Drawing.Size(27, 13);
      this.TASValueLabel.TabIndex = 20;
      this.TASValueLabel.Text = "N/A";
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label29.Location = new System.Drawing.Point(18, 12);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(56, 13);
      this.label29.TabIndex = 19;
      this.label29.Text = "TAS Raw:";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.label30);
      this.tabPage2.Controls.Add(this.label28);
      this.tabPage2.Controls.Add(this.label26);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(888, 271);
      this.tabPage2.TabIndex = 2;
      this.tabPage2.Text = "About";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Location = new System.Drawing.Point(18, 21);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(159, 13);
      this.label26.TabIndex = 0;
      this.label26.Text = "FSUIPC - Firmata Bridge Version";
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.Location = new System.Drawing.Point(18, 34);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(233, 13);
      this.label28.TabIndex = 1;
      this.label28.Text = "Developed by Tom Van den Bon (@geekc0der)";
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Location = new System.Drawing.Point(18, 47);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(234, 13);
      this.label30.TabIndex = 2;
      this.label30.Text = "https://github.com/tomvdb/fsuipc-firmata-bridge";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 504);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(920, 22);
      this.statusStrip1.TabIndex = 8;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // startStopLabel
      // 
      this.startStopLabel.AutoSize = true;
      this.startStopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startStopLabel.ForeColor = System.Drawing.Color.Red;
      this.startStopLabel.Location = new System.Drawing.Point(419, 320);
      this.startStopLabel.Name = "startStopLabel";
      this.startStopLabel.Size = new System.Drawing.Size(54, 13);
      this.startStopLabel.TabIndex = 9;
      this.startStopLabel.Text = "Stopped";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(920, 526);
      this.Controls.Add(this.startStopLabel);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.firmataPortsSelection);
      this.Controls.Add(this.tabGauges);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "FSUIPC - Firmata Bridge";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabGauges.ResumeLayout(false);
      this.turnCoordinatorTab.ResumeLayout(false);
      this.turnCoordinatorTab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.turnBallPosOffsetValue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnBallPosPinNr)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnRateOffsetValue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnRatePinNr)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TASpinnr)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Timer bridgeTimer;
    private System.Windows.Forms.TabControl tabGauges;
    private System.Windows.Forms.TabPage turnCoordinatorTab;
    private System.Windows.Forms.CheckBox turnCoordinatorTurnRateEnabled;
    private System.Windows.Forms.NumericUpDown turnRateOffsetValue;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox turnRateMapOutputMaxText;
    private System.Windows.Forms.TextBox turnRateMapOutputMinText;
    private System.Windows.Forms.TextBox turnRateMapInputMaxText;
    private System.Windows.Forms.TextBox turnRateMapInputMinText;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown turnRatePinNr;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label turnRateModifiedValueLabel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label turnRateValueLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox firmataPortsSelection;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.CheckBox turnCoordinatorBallPosEnabled;
    private System.Windows.Forms.NumericUpDown turnBallPosOffsetValue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox turnBallPosMapOutputMaxText;
    private System.Windows.Forms.TextBox turnBallPosMapOutputMinText;
    private System.Windows.Forms.TextBox turnBallPosMapInputMaxText;
    private System.Windows.Forms.TextBox turnBallPosMapInputMinText;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.NumericUpDown turnBallPosPinNr;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label turnBallPosModifiedValueLabel;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label turnBallPosValueLabel;
    private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox TASEnabled;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TASMapOutputMaxText;
        private System.Windows.Forms.TextBox TASMapOutputMinText;
        private System.Windows.Forms.TextBox TASMapInputMaxText;
        private System.Windows.Forms.TextBox TASMapInputMinText;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown TASpinnr;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label TASModValueLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label TASValueLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label startStopLabel;
    }
}

