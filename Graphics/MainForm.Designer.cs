namespace GraphicsNamespace
{
    partial class MainForm
    {
        /// <summary>
        /// ������������ ���������� ������������.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ���������� ��� ������������ �������.
        /// </summary>
        /// <param name="disposing">�������, ���� ����������� ������ ������ ���� ������; ����� �����.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region ���, ������������� ��������� ������������� ���� Windows

        /// <summary>
        /// ��������� ����� ��� ��������� ������������ � �� ��������� 
        /// ���������� ����� ������ � ������� ��������� ����.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxMainField = new System.Windows.Forms.PictureBox();
            this.groupBoxChangeScale = new System.Windows.Forms.GroupBox();
            this.numericUpDownScaleY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownScaleX = new System.Windows.Forms.NumericUpDown();
            this.listBoxEquations = new System.Windows.Forms.ListBox();
            this.groupBoxSelectedEquation = new System.Windows.Forms.GroupBox();
            this.groupBoxSelDF = new System.Windows.Forms.GroupBox();
            this.numericUpDownSelStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSelToX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSelColor = new System.Windows.Forms.Button();
            this.buttonUnselectEquation = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSaveSelected = new System.Windows.Forms.Button();
            this.textBoxSelVerticalOffset = new System.Windows.Forms.TextBox();
            this.textBoxSelCoef2 = new System.Windows.Forms.TextBox();
            this.textBoxSelCoef1 = new System.Windows.Forms.TextBox();
            this.labelSelVerticalOffset = new System.Windows.Forms.Label();
            this.labelSelCoef2 = new System.Windows.Forms.Label();
            this.labelSelCoef1 = new System.Windows.Forms.Label();
            this.groupBoxNewEquation = new System.Windows.Forms.GroupBox();
            this.groupBoxNewDF = new System.Windows.Forms.GroupBox();
            this.numericUpDownNewStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewToX = new System.Windows.Forms.NumericUpDown();
            this.labelNewStartX = new System.Windows.Forms.Label();
            this.labelNewEndX = new System.Windows.Forms.Label();
            this.buttonAddNewEquation = new System.Windows.Forms.Button();
            this.textBoxNewVerticalOffset = new System.Windows.Forms.TextBox();
            this.textBoxNewCoef2 = new System.Windows.Forms.TextBox();
            this.textBoxNewCoef1 = new System.Windows.Forms.TextBox();
            this.labelNewVerticalOffset = new System.Windows.Forms.Label();
            this.labelNewCoef2 = new System.Windows.Forms.Label();
            this.labelNewCoef1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectNewEquationType = new System.Windows.Forms.ComboBox();
            this.buttonCreateDefaultEquations = new System.Windows.Forms.Button();
            this.buttonColorOfAxis = new System.Windows.Forms.Button();
            this.buttonColorOfLines = new System.Windows.Forms.Button();
            this.groupBoxFieldSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxWorkWithPoint = new System.Windows.Forms.GroupBox();
            this.buttonGetAxisCollisionPoints = new System.Windows.Forms.Button();
            this.buttonFuncValueInPoint = new System.Windows.Forms.Button();
            this.buttonIsUpperOrLower = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPointY = new System.Windows.Forms.TextBox();
            this.textBoxPointX = new System.Windows.Forms.TextBox();
            this.buttonDeleteAxisCollisionPoints = new System.Windows.Forms.Button();
            this.groupBoxAxisCollision = new System.Windows.Forms.GroupBox();
            this.buttonDeleteFuncValueInPoint = new System.Windows.Forms.Button();
            this.groupBoxFindMinAndMax = new System.Windows.Forms.GroupBox();
            this.buttonFindMinAndMax = new System.Windows.Forms.Button();
            this.textBoxFindMinAndMax_Min = new System.Windows.Forms.TextBox();
            this.textBoxFindMinAndMax_Max = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownAxisCollisionPointsAccuracy = new System.Windows.Forms.NumericUpDown();
            this.buttonMinAndMaxPoints_Delete = new System.Windows.Forms.Button();
            this.groupBoxBuildOwnEquation = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBuildOwnEquationX = new System.Windows.Forms.TextBox();
            this.textBoxBuildOwnEquationY = new System.Windows.Forms.TextBox();
            this.buttonAddOwnEquationPoint = new System.Windows.Forms.Button();
            this.buttonFinishOwnEquationBuild = new System.Windows.Forms.Button();
            this.groupBoxEquationFromExpression = new System.Windows.Forms.GroupBox();
            this.textBoxEquationExpression = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCreateEquationFromExpression = new System.Windows.Forms.Button();
            this.groupBoxMovePointByWay = new System.Windows.Forms.GroupBox();
            this.buttonStartMovingPoint = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMovingPointSpeed = new System.Windows.Forms.TextBox();
            this.timerPointMover = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMovePointStartX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxMovePointFinishX = new System.Windows.Forms.TextBox();
            this.groupBoxFileSaving = new System.Windows.Forms.GroupBox();
            this.buttonSaveAsImage = new System.Windows.Forms.Button();
            this.buttonSaveBinary = new System.Windows.Forms.Button();
            this.buttonLoadBinary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainField)).BeginInit();
            this.groupBoxChangeScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleX)).BeginInit();
            this.groupBoxSelectedEquation.SuspendLayout();
            this.groupBoxSelDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelToX)).BeginInit();
            this.groupBoxNewEquation.SuspendLayout();
            this.groupBoxNewDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewToX)).BeginInit();
            this.groupBoxFieldSettings.SuspendLayout();
            this.groupBoxWorkWithPoint.SuspendLayout();
            this.groupBoxAxisCollision.SuspendLayout();
            this.groupBoxFindMinAndMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisCollisionPointsAccuracy)).BeginInit();
            this.groupBoxBuildOwnEquation.SuspendLayout();
            this.groupBoxEquationFromExpression.SuspendLayout();
            this.groupBoxMovePointByWay.SuspendLayout();
            this.groupBoxFileSaving.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMainField
            // 
            this.pictureBoxMainField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxMainField.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxMainField.Name = "pictureBoxMainField";
            this.pictureBoxMainField.Size = new System.Drawing.Size(801, 801);
            this.pictureBoxMainField.TabIndex = 0;
            this.pictureBoxMainField.TabStop = false;
            this.pictureBoxMainField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBoxChangeScale
            // 
            this.groupBoxChangeScale.Controls.Add(this.numericUpDownScaleY);
            this.groupBoxChangeScale.Controls.Add(this.label2);
            this.groupBoxChangeScale.Controls.Add(this.label1);
            this.groupBoxChangeScale.Controls.Add(this.numericUpDownScaleX);
            this.groupBoxChangeScale.Location = new System.Drawing.Point(816, 8);
            this.groupBoxChangeScale.Name = "groupBoxChangeScale";
            this.groupBoxChangeScale.Size = new System.Drawing.Size(440, 100);
            this.groupBoxChangeScale.TabIndex = 1;
            this.groupBoxChangeScale.TabStop = false;
            this.groupBoxChangeScale.Text = "Масштабирование";
            // 
            // numericUpDownScaleY
            // 
            this.numericUpDownScaleY.Location = new System.Drawing.Point(96, 64);
            this.numericUpDownScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScaleY.Name = "numericUpDownScaleY";
            this.numericUpDownScaleY.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownScaleY.TabIndex = 3;
            this.numericUpDownScaleY.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownScaleY.ValueChanged += new System.EventHandler(this.NumericUpDownScaleY_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Масштаб Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Масштаб X";
            // 
            // numericUpDownScaleX
            // 
            this.numericUpDownScaleX.Location = new System.Drawing.Point(96, 32);
            this.numericUpDownScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScaleX.Name = "numericUpDownScaleX";
            this.numericUpDownScaleX.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownScaleX.TabIndex = 0;
            this.numericUpDownScaleX.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownScaleX.ValueChanged += new System.EventHandler(this.NumericUpDownScaleX_ValueChanged);
            // 
            // listBoxEquations
            // 
            this.listBoxEquations.FormattingEnabled = true;
            this.listBoxEquations.ItemHeight = 16;
            this.listBoxEquations.Location = new System.Drawing.Point(816, 480);
            this.listBoxEquations.Name = "listBoxEquations";
            this.listBoxEquations.Size = new System.Drawing.Size(440, 180);
            this.listBoxEquations.TabIndex = 2;
            this.listBoxEquations.SelectedIndexChanged += new System.EventHandler(this.listBoxEquations_SelectedIndexChanged);
            // 
            // groupBoxSelectedEquation
            // 
            this.groupBoxSelectedEquation.Controls.Add(this.groupBoxSelDF);
            this.groupBoxSelectedEquation.Controls.Add(this.buttonSelColor);
            this.groupBoxSelectedEquation.Controls.Add(this.buttonUnselectEquation);
            this.groupBoxSelectedEquation.Controls.Add(this.buttonDelete);
            this.groupBoxSelectedEquation.Controls.Add(this.buttonSaveSelected);
            this.groupBoxSelectedEquation.Controls.Add(this.textBoxSelVerticalOffset);
            this.groupBoxSelectedEquation.Controls.Add(this.textBoxSelCoef2);
            this.groupBoxSelectedEquation.Controls.Add(this.textBoxSelCoef1);
            this.groupBoxSelectedEquation.Controls.Add(this.labelSelVerticalOffset);
            this.groupBoxSelectedEquation.Controls.Add(this.labelSelCoef2);
            this.groupBoxSelectedEquation.Controls.Add(this.labelSelCoef1);
            this.groupBoxSelectedEquation.Location = new System.Drawing.Point(1272, 480);
            this.groupBoxSelectedEquation.Name = "groupBoxSelectedEquation";
            this.groupBoxSelectedEquation.Size = new System.Drawing.Size(440, 180);
            this.groupBoxSelectedEquation.TabIndex = 3;
            this.groupBoxSelectedEquation.TabStop = false;
            this.groupBoxSelectedEquation.Text = "Настройка выбранного графика";
            // 
            // groupBoxSelDF
            // 
            this.groupBoxSelDF.Controls.Add(this.numericUpDownSelStartX);
            this.groupBoxSelDF.Controls.Add(this.numericUpDownSelToX);
            this.groupBoxSelDF.Controls.Add(this.label4);
            this.groupBoxSelDF.Controls.Add(this.label5);
            this.groupBoxSelDF.Location = new System.Drawing.Point(184, 24);
            this.groupBoxSelDF.Name = "groupBoxSelDF";
            this.groupBoxSelDF.Size = new System.Drawing.Size(248, 88);
            this.groupBoxSelDF.TabIndex = 10;
            this.groupBoxSelDF.TabStop = false;
            this.groupBoxSelDF.Text = "Область рассчёта";
            this.groupBoxSelDF.Visible = false;
            // 
            // numericUpDownSelStartX
            // 
            this.numericUpDownSelStartX.Location = new System.Drawing.Point(112, 24);
            this.numericUpDownSelStartX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSelStartX.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDownSelStartX.Name = "numericUpDownSelStartX";
            this.numericUpDownSelStartX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSelStartX.TabIndex = 9;
            this.numericUpDownSelStartX.Value = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDownSelStartX.ValueChanged += new System.EventHandler(this.numericUpDownSelStartX_ValueChanged);
            // 
            // numericUpDownSelToX
            // 
            this.numericUpDownSelToX.Location = new System.Drawing.Point(112, 56);
            this.numericUpDownSelToX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSelToX.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDownSelToX.Name = "numericUpDownSelToX";
            this.numericUpDownSelToX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSelToX.TabIndex = 9;
            this.numericUpDownSelToX.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSelToX.ValueChanged += new System.EventHandler(this.numericUpDownSelStartX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начальный X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Конечный X";
            // 
            // buttonSelColor
            // 
            this.buttonSelColor.Location = new System.Drawing.Point(304, 120);
            this.buttonSelColor.Name = "buttonSelColor";
            this.buttonSelColor.Size = new System.Drawing.Size(128, 48);
            this.buttonSelColor.TabIndex = 13;
            this.buttonSelColor.Text = "Цвет";
            this.buttonSelColor.UseVisualStyleBackColor = true;
            this.buttonSelColor.Visible = false;
            this.buttonSelColor.Click += new System.EventHandler(this.buttonSelColor_Click);
            // 
            // buttonUnselectEquation
            // 
            this.buttonUnselectEquation.Location = new System.Drawing.Point(184, 120);
            this.buttonUnselectEquation.Name = "buttonUnselectEquation";
            this.buttonUnselectEquation.Size = new System.Drawing.Size(112, 48);
            this.buttonUnselectEquation.TabIndex = 12;
            this.buttonUnselectEquation.Text = "Отменить";
            this.buttonUnselectEquation.UseVisualStyleBackColor = true;
            this.buttonUnselectEquation.Visible = false;
            this.buttonUnselectEquation.Click += new System.EventHandler(this.buttonUnselectEquation_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(8, 144);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(168, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSaveSelected
            // 
            this.buttonSaveSelected.Location = new System.Drawing.Point(8, 120);
            this.buttonSaveSelected.Name = "buttonSaveSelected";
            this.buttonSaveSelected.Size = new System.Drawing.Size(168, 23);
            this.buttonSaveSelected.TabIndex = 12;
            this.buttonSaveSelected.Text = "Сохранить";
            this.buttonSaveSelected.UseVisualStyleBackColor = true;
            this.buttonSaveSelected.Visible = false;
            this.buttonSaveSelected.Click += new System.EventHandler(this.buttonSaveSelected_Click);
            // 
            // textBoxSelVerticalOffset
            // 
            this.textBoxSelVerticalOffset.Location = new System.Drawing.Point(88, 96);
            this.textBoxSelVerticalOffset.Name = "textBoxSelVerticalOffset";
            this.textBoxSelVerticalOffset.Size = new System.Drawing.Size(88, 22);
            this.textBoxSelVerticalOffset.TabIndex = 9;
            this.textBoxSelVerticalOffset.Text = "0";
            this.textBoxSelVerticalOffset.Visible = false;
            this.textBoxSelVerticalOffset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelCoef1_KeyDown);
            // 
            // textBoxSelCoef2
            // 
            this.textBoxSelCoef2.Location = new System.Drawing.Point(88, 64);
            this.textBoxSelCoef2.Name = "textBoxSelCoef2";
            this.textBoxSelCoef2.Size = new System.Drawing.Size(88, 22);
            this.textBoxSelCoef2.TabIndex = 10;
            this.textBoxSelCoef2.Text = "0";
            this.textBoxSelCoef2.Visible = false;
            this.textBoxSelCoef2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelCoef1_KeyDown);
            // 
            // textBoxSelCoef1
            // 
            this.textBoxSelCoef1.Location = new System.Drawing.Point(88, 32);
            this.textBoxSelCoef1.Name = "textBoxSelCoef1";
            this.textBoxSelCoef1.Size = new System.Drawing.Size(88, 22);
            this.textBoxSelCoef1.TabIndex = 11;
            this.textBoxSelCoef1.Text = "0";
            this.textBoxSelCoef1.Visible = false;
            this.textBoxSelCoef1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelCoef1_KeyDown);
            // 
            // labelSelVerticalOffset
            // 
            this.labelSelVerticalOffset.AutoSize = true;
            this.labelSelVerticalOffset.Location = new System.Drawing.Point(8, 99);
            this.labelSelVerticalOffset.Name = "labelSelVerticalOffset";
            this.labelSelVerticalOffset.Size = new System.Drawing.Size(77, 17);
            this.labelSelVerticalOffset.TabIndex = 8;
            this.labelSelVerticalOffset.Text = "Смещение";
            this.labelSelVerticalOffset.Visible = false;
            // 
            // labelSelCoef2
            // 
            this.labelSelCoef2.AutoSize = true;
            this.labelSelCoef2.Location = new System.Drawing.Point(8, 67);
            this.labelSelCoef2.Name = "labelSelCoef2";
            this.labelSelCoef2.Size = new System.Drawing.Size(51, 17);
            this.labelSelCoef2.TabIndex = 7;
            this.labelSelCoef2.Text = "Коэф2";
            this.labelSelCoef2.Visible = false;
            // 
            // labelSelCoef1
            // 
            this.labelSelCoef1.AutoSize = true;
            this.labelSelCoef1.Location = new System.Drawing.Point(8, 35);
            this.labelSelCoef1.Name = "labelSelCoef1";
            this.labelSelCoef1.Size = new System.Drawing.Size(51, 17);
            this.labelSelCoef1.TabIndex = 6;
            this.labelSelCoef1.Text = "Коэф1";
            this.labelSelCoef1.Visible = false;
            // 
            // groupBoxNewEquation
            // 
            this.groupBoxNewEquation.Controls.Add(this.groupBoxNewDF);
            this.groupBoxNewEquation.Controls.Add(this.buttonAddNewEquation);
            this.groupBoxNewEquation.Controls.Add(this.textBoxNewVerticalOffset);
            this.groupBoxNewEquation.Controls.Add(this.textBoxNewCoef2);
            this.groupBoxNewEquation.Controls.Add(this.textBoxNewCoef1);
            this.groupBoxNewEquation.Controls.Add(this.labelNewVerticalOffset);
            this.groupBoxNewEquation.Controls.Add(this.labelNewCoef2);
            this.groupBoxNewEquation.Controls.Add(this.labelNewCoef1);
            this.groupBoxNewEquation.Controls.Add(this.label3);
            this.groupBoxNewEquation.Controls.Add(this.comboBoxSelectNewEquationType);
            this.groupBoxNewEquation.Location = new System.Drawing.Point(816, 112);
            this.groupBoxNewEquation.Name = "groupBoxNewEquation";
            this.groupBoxNewEquation.Size = new System.Drawing.Size(896, 192);
            this.groupBoxNewEquation.TabIndex = 4;
            this.groupBoxNewEquation.TabStop = false;
            this.groupBoxNewEquation.Text = "Создать новый график";
            // 
            // groupBoxNewDF
            // 
            this.groupBoxNewDF.Controls.Add(this.numericUpDownNewStartX);
            this.groupBoxNewDF.Controls.Add(this.numericUpDownNewToX);
            this.groupBoxNewDF.Controls.Add(this.labelNewStartX);
            this.groupBoxNewDF.Controls.Add(this.labelNewEndX);
            this.groupBoxNewDF.Location = new System.Drawing.Point(456, 48);
            this.groupBoxNewDF.Name = "groupBoxNewDF";
            this.groupBoxNewDF.Size = new System.Drawing.Size(240, 96);
            this.groupBoxNewDF.TabIndex = 10;
            this.groupBoxNewDF.TabStop = false;
            this.groupBoxNewDF.Text = "Область рассчёта";
            this.groupBoxNewDF.Visible = false;
            // 
            // numericUpDownNewStartX
            // 
            this.numericUpDownNewStartX.Location = new System.Drawing.Point(112, 32);
            this.numericUpDownNewStartX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownNewStartX.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDownNewStartX.Name = "numericUpDownNewStartX";
            this.numericUpDownNewStartX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNewStartX.TabIndex = 9;
            this.numericUpDownNewStartX.Value = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownNewToX
            // 
            this.numericUpDownNewToX.Location = new System.Drawing.Point(112, 64);
            this.numericUpDownNewToX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownNewToX.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDownNewToX.Name = "numericUpDownNewToX";
            this.numericUpDownNewToX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNewToX.TabIndex = 9;
            this.numericUpDownNewToX.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelNewStartX
            // 
            this.labelNewStartX.AutoSize = true;
            this.labelNewStartX.Location = new System.Drawing.Point(8, 35);
            this.labelNewStartX.Name = "labelNewStartX";
            this.labelNewStartX.Size = new System.Drawing.Size(96, 17);
            this.labelNewStartX.TabIndex = 7;
            this.labelNewStartX.Text = "Начальный X";
            // 
            // labelNewEndX
            // 
            this.labelNewEndX.AutoSize = true;
            this.labelNewEndX.Location = new System.Drawing.Point(8, 67);
            this.labelNewEndX.Name = "labelNewEndX";
            this.labelNewEndX.Size = new System.Drawing.Size(88, 17);
            this.labelNewEndX.TabIndex = 8;
            this.labelNewEndX.Text = "Конечный X";
            // 
            // buttonAddNewEquation
            // 
            this.buttonAddNewEquation.Location = new System.Drawing.Point(8, 148);
            this.buttonAddNewEquation.Name = "buttonAddNewEquation";
            this.buttonAddNewEquation.Size = new System.Drawing.Size(880, 32);
            this.buttonAddNewEquation.TabIndex = 6;
            this.buttonAddNewEquation.Text = "Добавить этот график";
            this.buttonAddNewEquation.UseVisualStyleBackColor = true;
            this.buttonAddNewEquation.Click += new System.EventHandler(this.buttonAddNewEquation_Click);
            // 
            // textBoxNewVerticalOffset
            // 
            this.textBoxNewVerticalOffset.Location = new System.Drawing.Point(104, 120);
            this.textBoxNewVerticalOffset.Name = "textBoxNewVerticalOffset";
            this.textBoxNewVerticalOffset.Size = new System.Drawing.Size(336, 22);
            this.textBoxNewVerticalOffset.TabIndex = 5;
            this.textBoxNewVerticalOffset.Text = "0";
            this.textBoxNewVerticalOffset.Visible = false;
            // 
            // textBoxNewCoef2
            // 
            this.textBoxNewCoef2.Location = new System.Drawing.Point(104, 88);
            this.textBoxNewCoef2.Name = "textBoxNewCoef2";
            this.textBoxNewCoef2.Size = new System.Drawing.Size(336, 22);
            this.textBoxNewCoef2.TabIndex = 5;
            this.textBoxNewCoef2.Text = "0";
            this.textBoxNewCoef2.Visible = false;
            // 
            // textBoxNewCoef1
            // 
            this.textBoxNewCoef1.Location = new System.Drawing.Point(104, 56);
            this.textBoxNewCoef1.Name = "textBoxNewCoef1";
            this.textBoxNewCoef1.Size = new System.Drawing.Size(336, 22);
            this.textBoxNewCoef1.TabIndex = 5;
            this.textBoxNewCoef1.Text = "0";
            this.textBoxNewCoef1.Visible = false;
            // 
            // labelNewVerticalOffset
            // 
            this.labelNewVerticalOffset.AutoSize = true;
            this.labelNewVerticalOffset.Location = new System.Drawing.Point(8, 123);
            this.labelNewVerticalOffset.Name = "labelNewVerticalOffset";
            this.labelNewVerticalOffset.Size = new System.Drawing.Size(77, 17);
            this.labelNewVerticalOffset.TabIndex = 4;
            this.labelNewVerticalOffset.Text = "Смещение";
            this.labelNewVerticalOffset.Visible = false;
            // 
            // labelNewCoef2
            // 
            this.labelNewCoef2.AutoSize = true;
            this.labelNewCoef2.Location = new System.Drawing.Point(8, 91);
            this.labelNewCoef2.Name = "labelNewCoef2";
            this.labelNewCoef2.Size = new System.Drawing.Size(51, 17);
            this.labelNewCoef2.TabIndex = 3;
            this.labelNewCoef2.Text = "Коэф2";
            this.labelNewCoef2.Visible = false;
            // 
            // labelNewCoef1
            // 
            this.labelNewCoef1.AutoSize = true;
            this.labelNewCoef1.Location = new System.Drawing.Point(8, 59);
            this.labelNewCoef1.Name = "labelNewCoef1";
            this.labelNewCoef1.Size = new System.Drawing.Size(51, 17);
            this.labelNewCoef1.TabIndex = 2;
            this.labelNewCoef1.Text = "Коэф1";
            this.labelNewCoef1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тип нового графика";
            // 
            // comboBoxSelectNewEquationType
            // 
            this.comboBoxSelectNewEquationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectNewEquationType.FormattingEnabled = true;
            this.comboBoxSelectNewEquationType.Items.AddRange(new object[] {
            "y = a",
            "y = kx + b",
            "y = ax^2 + bx + c",
            "y = a / x + b",
            "y = sqrt(a*x) + b"});
            this.comboBoxSelectNewEquationType.Location = new System.Drawing.Point(152, 22);
            this.comboBoxSelectNewEquationType.Name = "comboBoxSelectNewEquationType";
            this.comboBoxSelectNewEquationType.Size = new System.Drawing.Size(736, 24);
            this.comboBoxSelectNewEquationType.TabIndex = 0;
            this.comboBoxSelectNewEquationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectNewEquationType_SelectedIndexChanged);
            // 
            // buttonCreateDefaultEquations
            // 
            this.buttonCreateDefaultEquations.Location = new System.Drawing.Point(8, 16);
            this.buttonCreateDefaultEquations.Name = "buttonCreateDefaultEquations";
            this.buttonCreateDefaultEquations.Size = new System.Drawing.Size(424, 40);
            this.buttonCreateDefaultEquations.TabIndex = 5;
            this.buttonCreateDefaultEquations.Text = "Создать стандартные графики";
            this.buttonCreateDefaultEquations.UseVisualStyleBackColor = true;
            this.buttonCreateDefaultEquations.Click += new System.EventHandler(this.buttonCreateDefaultEquations_Click);
            // 
            // buttonColorOfAxis
            // 
            this.buttonColorOfAxis.Location = new System.Drawing.Point(8, 64);
            this.buttonColorOfAxis.Name = "buttonColorOfAxis";
            this.buttonColorOfAxis.Size = new System.Drawing.Size(216, 32);
            this.buttonColorOfAxis.TabIndex = 6;
            this.buttonColorOfAxis.Text = "Цвет осей";
            this.buttonColorOfAxis.UseVisualStyleBackColor = true;
            this.buttonColorOfAxis.Click += new System.EventHandler(this.buttonColorOfAxis_Click);
            // 
            // buttonColorOfLines
            // 
            this.buttonColorOfLines.Location = new System.Drawing.Point(232, 64);
            this.buttonColorOfLines.Name = "buttonColorOfLines";
            this.buttonColorOfLines.Size = new System.Drawing.Size(200, 32);
            this.buttonColorOfLines.TabIndex = 6;
            this.buttonColorOfLines.Text = "Цвет разметки";
            this.buttonColorOfLines.UseVisualStyleBackColor = true;
            this.buttonColorOfLines.Click += new System.EventHandler(this.buttonColorOfLines_Click);
            // 
            // groupBoxFieldSettings
            // 
            this.groupBoxFieldSettings.Controls.Add(this.buttonCreateDefaultEquations);
            this.groupBoxFieldSettings.Controls.Add(this.buttonColorOfLines);
            this.groupBoxFieldSettings.Controls.Add(this.buttonColorOfAxis);
            this.groupBoxFieldSettings.Location = new System.Drawing.Point(1272, 8);
            this.groupBoxFieldSettings.Name = "groupBoxFieldSettings";
            this.groupBoxFieldSettings.Size = new System.Drawing.Size(440, 100);
            this.groupBoxFieldSettings.TabIndex = 7;
            this.groupBoxFieldSettings.TabStop = false;
            this.groupBoxFieldSettings.Text = "Настройка поля";
            // 
            // groupBoxWorkWithPoint
            // 
            this.groupBoxWorkWithPoint.Controls.Add(this.buttonFuncValueInPoint);
            this.groupBoxWorkWithPoint.Controls.Add(this.buttonDeleteFuncValueInPoint);
            this.groupBoxWorkWithPoint.Controls.Add(this.buttonIsUpperOrLower);
            this.groupBoxWorkWithPoint.Controls.Add(this.label7);
            this.groupBoxWorkWithPoint.Controls.Add(this.label6);
            this.groupBoxWorkWithPoint.Controls.Add(this.textBoxPointY);
            this.groupBoxWorkWithPoint.Controls.Add(this.textBoxPointX);
            this.groupBoxWorkWithPoint.Location = new System.Drawing.Point(816, 664);
            this.groupBoxWorkWithPoint.Name = "groupBoxWorkWithPoint";
            this.groupBoxWorkWithPoint.Size = new System.Drawing.Size(440, 144);
            this.groupBoxWorkWithPoint.TabIndex = 8;
            this.groupBoxWorkWithPoint.TabStop = false;
            this.groupBoxWorkWithPoint.Text = " Работа с точкой";
            this.groupBoxWorkWithPoint.Visible = false;
            // 
            // buttonGetAxisCollisionPoints
            // 
            this.buttonGetAxisCollisionPoints.Location = new System.Drawing.Point(256, 19);
            this.buttonGetAxisCollisionPoints.Name = "buttonGetAxisCollisionPoints";
            this.buttonGetAxisCollisionPoints.Size = new System.Drawing.Size(184, 23);
            this.buttonGetAxisCollisionPoints.TabIndex = 5;
            this.buttonGetAxisCollisionPoints.Text = "Найти";
            this.buttonGetAxisCollisionPoints.UseVisualStyleBackColor = true;
            this.buttonGetAxisCollisionPoints.Click += new System.EventHandler(this.buttonGetAxisCollisionPoints_Click);
            // 
            // buttonFuncValueInPoint
            // 
            this.buttonFuncValueInPoint.Location = new System.Drawing.Point(8, 72);
            this.buttonFuncValueInPoint.Name = "buttonFuncValueInPoint";
            this.buttonFuncValueInPoint.Size = new System.Drawing.Size(424, 23);
            this.buttonFuncValueInPoint.TabIndex = 5;
            this.buttonFuncValueInPoint.Text = "Значение функции";
            this.buttonFuncValueInPoint.UseVisualStyleBackColor = true;
            this.buttonFuncValueInPoint.Click += new System.EventHandler(this.buttonFuncValueInPoint_Click);
            // 
            // buttonIsUpperOrLower
            // 
            this.buttonIsUpperOrLower.Location = new System.Drawing.Point(8, 104);
            this.buttonIsUpperOrLower.Name = "buttonIsUpperOrLower";
            this.buttonIsUpperOrLower.Size = new System.Drawing.Size(210, 24);
            this.buttonIsUpperOrLower.TabIndex = 4;
            this.buttonIsUpperOrLower.Text = "Выше или ниже?";
            this.buttonIsUpperOrLower.UseVisualStyleBackColor = true;
            this.buttonIsUpperOrLower.Click += new System.EventHandler(this.buttonIsUpperOrLower_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Коорд Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Коорд X";
            // 
            // textBoxPointY
            // 
            this.textBoxPointY.Location = new System.Drawing.Point(288, 37);
            this.textBoxPointY.Name = "textBoxPointY";
            this.textBoxPointY.Size = new System.Drawing.Size(136, 22);
            this.textBoxPointY.TabIndex = 1;
            this.textBoxPointY.Text = "0";
            // 
            // textBoxPointX
            // 
            this.textBoxPointX.Location = new System.Drawing.Point(72, 37);
            this.textBoxPointX.Name = "textBoxPointX";
            this.textBoxPointX.Size = new System.Drawing.Size(136, 22);
            this.textBoxPointX.TabIndex = 0;
            this.textBoxPointX.Text = "0";
            // 
            // buttonDeleteAxisCollisionPoints
            // 
            this.buttonDeleteAxisCollisionPoints.Location = new System.Drawing.Point(256, 43);
            this.buttonDeleteAxisCollisionPoints.Name = "buttonDeleteAxisCollisionPoints";
            this.buttonDeleteAxisCollisionPoints.Size = new System.Drawing.Size(184, 23);
            this.buttonDeleteAxisCollisionPoints.TabIndex = 9;
            this.buttonDeleteAxisCollisionPoints.Text = "Удалить";
            this.buttonDeleteAxisCollisionPoints.UseVisualStyleBackColor = true;
            this.buttonDeleteAxisCollisionPoints.Click += new System.EventHandler(this.buttonDeleteAxisCollisionPoints_Click);
            // 
            // groupBoxAxisCollision
            // 
            this.groupBoxAxisCollision.Controls.Add(this.numericUpDownAxisCollisionPointsAccuracy);
            this.groupBoxAxisCollision.Controls.Add(this.label10);
            this.groupBoxAxisCollision.Controls.Add(this.buttonGetAxisCollisionPoints);
            this.groupBoxAxisCollision.Controls.Add(this.buttonDeleteAxisCollisionPoints);
            this.groupBoxAxisCollision.Location = new System.Drawing.Point(1264, 664);
            this.groupBoxAxisCollision.Name = "groupBoxAxisCollision";
            this.groupBoxAxisCollision.Size = new System.Drawing.Size(448, 72);
            this.groupBoxAxisCollision.TabIndex = 10;
            this.groupBoxAxisCollision.TabStop = false;
            this.groupBoxAxisCollision.Text = "Точки пересечения с осями";
            this.groupBoxAxisCollision.Visible = false;
            // 
            // buttonDeleteFuncValueInPoint
            // 
            this.buttonDeleteFuncValueInPoint.Location = new System.Drawing.Point(224, 104);
            this.buttonDeleteFuncValueInPoint.Name = "buttonDeleteFuncValueInPoint";
            this.buttonDeleteFuncValueInPoint.Size = new System.Drawing.Size(210, 24);
            this.buttonDeleteFuncValueInPoint.TabIndex = 9;
            this.buttonDeleteFuncValueInPoint.Text = "Удалить точку";
            this.buttonDeleteFuncValueInPoint.UseVisualStyleBackColor = true;
            this.buttonDeleteFuncValueInPoint.Click += new System.EventHandler(this.buttonDeleteFuncValueInPoint_Click);
            // 
            // groupBoxFindMinAndMax
            // 
            this.groupBoxFindMinAndMax.Controls.Add(this.buttonMinAndMaxPoints_Delete);
            this.groupBoxFindMinAndMax.Controls.Add(this.buttonFindMinAndMax);
            this.groupBoxFindMinAndMax.Controls.Add(this.label8);
            this.groupBoxFindMinAndMax.Controls.Add(this.textBoxFindMinAndMax_Min);
            this.groupBoxFindMinAndMax.Controls.Add(this.label9);
            this.groupBoxFindMinAndMax.Controls.Add(this.textBoxFindMinAndMax_Max);
            this.groupBoxFindMinAndMax.Location = new System.Drawing.Point(1264, 736);
            this.groupBoxFindMinAndMax.Name = "groupBoxFindMinAndMax";
            this.groupBoxFindMinAndMax.Size = new System.Drawing.Size(448, 72);
            this.groupBoxFindMinAndMax.TabIndex = 10;
            this.groupBoxFindMinAndMax.TabStop = false;
            this.groupBoxFindMinAndMax.Text = "Найти минимум и максимум на промежутке";
            this.groupBoxFindMinAndMax.Visible = false;
            // 
            // buttonFindMinAndMax
            // 
            this.buttonFindMinAndMax.Location = new System.Drawing.Point(192, 24);
            this.buttonFindMinAndMax.Name = "buttonFindMinAndMax";
            this.buttonFindMinAndMax.Size = new System.Drawing.Size(248, 24);
            this.buttonFindMinAndMax.TabIndex = 5;
            this.buttonFindMinAndMax.Text = "Найти";
            this.buttonFindMinAndMax.UseVisualStyleBackColor = true;
            this.buttonFindMinAndMax.Click += new System.EventHandler(this.buttonFindMinAndMax_Click);
            // 
            // textBoxFindMinAndMax_Min
            // 
            this.textBoxFindMinAndMax_Min.Location = new System.Drawing.Point(128, 24);
            this.textBoxFindMinAndMax_Min.Name = "textBoxFindMinAndMax_Min";
            this.textBoxFindMinAndMax_Min.Size = new System.Drawing.Size(56, 22);
            this.textBoxFindMinAndMax_Min.TabIndex = 0;
            this.textBoxFindMinAndMax_Min.Text = "0";
            // 
            // textBoxFindMinAndMax_Max
            // 
            this.textBoxFindMinAndMax_Max.Location = new System.Drawing.Point(128, 48);
            this.textBoxFindMinAndMax_Max.Name = "textBoxFindMinAndMax_Max";
            this.textBoxFindMinAndMax_Max.Size = new System.Drawing.Size(56, 22);
            this.textBoxFindMinAndMax_Max.TabIndex = 1;
            this.textBoxFindMinAndMax_Max.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Левая Граница";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Правая Граница";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 40);
            this.label10.TabIndex = 10;
            this.label10.Text = "Точность определения \r\n(знаков после запятой)";
            // 
            // numericUpDownAxisCollisionPointsAccuracy
            // 
            this.numericUpDownAxisCollisionPointsAccuracy.Location = new System.Drawing.Point(176, 32);
            this.numericUpDownAxisCollisionPointsAccuracy.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAxisCollisionPointsAccuracy.Name = "numericUpDownAxisCollisionPointsAccuracy";
            this.numericUpDownAxisCollisionPointsAccuracy.Size = new System.Drawing.Size(72, 22);
            this.numericUpDownAxisCollisionPointsAccuracy.TabIndex = 11;
            // 
            // buttonMinAndMaxPoints_Delete
            // 
            this.buttonMinAndMaxPoints_Delete.Location = new System.Drawing.Point(192, 48);
            this.buttonMinAndMaxPoints_Delete.Name = "buttonMinAndMaxPoints_Delete";
            this.buttonMinAndMaxPoints_Delete.Size = new System.Drawing.Size(248, 23);
            this.buttonMinAndMaxPoints_Delete.TabIndex = 6;
            this.buttonMinAndMaxPoints_Delete.Text = "Удалить";
            this.buttonMinAndMaxPoints_Delete.UseVisualStyleBackColor = true;
            this.buttonMinAndMaxPoints_Delete.Click += new System.EventHandler(this.buttonMinAndMaxPoints_Delete_Click);
            // 
            // groupBoxBuildOwnEquation
            // 
            this.groupBoxBuildOwnEquation.Controls.Add(this.buttonFinishOwnEquationBuild);
            this.groupBoxBuildOwnEquation.Controls.Add(this.buttonAddOwnEquationPoint);
            this.groupBoxBuildOwnEquation.Controls.Add(this.textBoxBuildOwnEquationY);
            this.groupBoxBuildOwnEquation.Controls.Add(this.textBoxBuildOwnEquationX);
            this.groupBoxBuildOwnEquation.Controls.Add(this.label12);
            this.groupBoxBuildOwnEquation.Controls.Add(this.label11);
            this.groupBoxBuildOwnEquation.Location = new System.Drawing.Point(816, 304);
            this.groupBoxBuildOwnEquation.Name = "groupBoxBuildOwnEquation";
            this.groupBoxBuildOwnEquation.Size = new System.Drawing.Size(440, 88);
            this.groupBoxBuildOwnEquation.TabIndex = 11;
            this.groupBoxBuildOwnEquation.TabStop = false;
            this.groupBoxBuildOwnEquation.Text = "Построить график по точкам";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Координата X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Координата Y";
            // 
            // textBoxBuildOwnEquationX
            // 
            this.textBoxBuildOwnEquationX.Location = new System.Drawing.Point(112, 24);
            this.textBoxBuildOwnEquationX.Name = "textBoxBuildOwnEquationX";
            this.textBoxBuildOwnEquationX.Size = new System.Drawing.Size(100, 22);
            this.textBoxBuildOwnEquationX.TabIndex = 2;
            this.textBoxBuildOwnEquationX.Text = "0";
            // 
            // textBoxBuildOwnEquationY
            // 
            this.textBoxBuildOwnEquationY.Location = new System.Drawing.Point(112, 54);
            this.textBoxBuildOwnEquationY.Name = "textBoxBuildOwnEquationY";
            this.textBoxBuildOwnEquationY.Size = new System.Drawing.Size(100, 22);
            this.textBoxBuildOwnEquationY.TabIndex = 2;
            this.textBoxBuildOwnEquationY.Text = "0";
            // 
            // buttonAddOwnEquationPoint
            // 
            this.buttonAddOwnEquationPoint.Location = new System.Drawing.Point(224, 23);
            this.buttonAddOwnEquationPoint.Name = "buttonAddOwnEquationPoint";
            this.buttonAddOwnEquationPoint.Size = new System.Drawing.Size(208, 23);
            this.buttonAddOwnEquationPoint.TabIndex = 3;
            this.buttonAddOwnEquationPoint.Text = "Добавить точку";
            this.buttonAddOwnEquationPoint.UseVisualStyleBackColor = true;
            this.buttonAddOwnEquationPoint.Click += new System.EventHandler(this.buttonAddOwnEquationPoint_Click);
            // 
            // buttonFinishOwnEquationBuild
            // 
            this.buttonFinishOwnEquationBuild.Location = new System.Drawing.Point(224, 53);
            this.buttonFinishOwnEquationBuild.Name = "buttonFinishOwnEquationBuild";
            this.buttonFinishOwnEquationBuild.Size = new System.Drawing.Size(208, 23);
            this.buttonFinishOwnEquationBuild.TabIndex = 4;
            this.buttonFinishOwnEquationBuild.Text = "Завершить создание";
            this.buttonFinishOwnEquationBuild.UseVisualStyleBackColor = true;
            this.buttonFinishOwnEquationBuild.Visible = false;
            this.buttonFinishOwnEquationBuild.Click += new System.EventHandler(this.buttonFinishOwnEquationBuild_Click);
            // 
            // groupBoxEquationFromExpression
            // 
            this.groupBoxEquationFromExpression.Controls.Add(this.buttonCreateEquationFromExpression);
            this.groupBoxEquationFromExpression.Controls.Add(this.label13);
            this.groupBoxEquationFromExpression.Controls.Add(this.textBoxEquationExpression);
            this.groupBoxEquationFromExpression.Location = new System.Drawing.Point(1272, 304);
            this.groupBoxEquationFromExpression.Name = "groupBoxEquationFromExpression";
            this.groupBoxEquationFromExpression.Size = new System.Drawing.Size(440, 88);
            this.groupBoxEquationFromExpression.TabIndex = 12;
            this.groupBoxEquationFromExpression.TabStop = false;
            this.groupBoxEquationFromExpression.Text = "Произвольная функция";
            // 
            // textBoxEquationExpression
            // 
            this.textBoxEquationExpression.Location = new System.Drawing.Point(96, 40);
            this.textBoxEquationExpression.Name = "textBoxEquationExpression";
            this.textBoxEquationExpression.Size = new System.Drawing.Size(176, 22);
            this.textBoxEquationExpression.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Выражение";
            // 
            // buttonCreateEquationFromExpression
            // 
            this.buttonCreateEquationFromExpression.Location = new System.Drawing.Point(280, 34);
            this.buttonCreateEquationFromExpression.Name = "buttonCreateEquationFromExpression";
            this.buttonCreateEquationFromExpression.Size = new System.Drawing.Size(136, 32);
            this.buttonCreateEquationFromExpression.TabIndex = 2;
            this.buttonCreateEquationFromExpression.Text = "Создать график";
            this.buttonCreateEquationFromExpression.UseVisualStyleBackColor = true;
            this.buttonCreateEquationFromExpression.Click += new System.EventHandler(this.buttonCreateEquationFromExpression_Click);
            // 
            // groupBoxMovePointByWay
            // 
            this.groupBoxMovePointByWay.Controls.Add(this.textBoxMovePointFinishX);
            this.groupBoxMovePointByWay.Controls.Add(this.label16);
            this.groupBoxMovePointByWay.Controls.Add(this.textBoxMovePointStartX);
            this.groupBoxMovePointByWay.Controls.Add(this.label15);
            this.groupBoxMovePointByWay.Controls.Add(this.textBoxMovingPointSpeed);
            this.groupBoxMovePointByWay.Controls.Add(this.label14);
            this.groupBoxMovePointByWay.Controls.Add(this.buttonStartMovingPoint);
            this.groupBoxMovePointByWay.Location = new System.Drawing.Point(816, 392);
            this.groupBoxMovePointByWay.Name = "groupBoxMovePointByWay";
            this.groupBoxMovePointByWay.Size = new System.Drawing.Size(440, 80);
            this.groupBoxMovePointByWay.TabIndex = 13;
            this.groupBoxMovePointByWay.TabStop = false;
            this.groupBoxMovePointByWay.Text = "Движение точки по функции";
            this.groupBoxMovePointByWay.Visible = false;
            // 
            // buttonStartMovingPoint
            // 
            this.buttonStartMovingPoint.Location = new System.Drawing.Point(227, 45);
            this.buttonStartMovingPoint.Name = "buttonStartMovingPoint";
            this.buttonStartMovingPoint.Size = new System.Drawing.Size(200, 32);
            this.buttonStartMovingPoint.TabIndex = 0;
            this.buttonStartMovingPoint.Text = "Запуск";
            this.buttonStartMovingPoint.UseVisualStyleBackColor = true;
            this.buttonStartMovingPoint.Click += new System.EventHandler(this.buttonStartMovingPoint_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Скорость";
            // 
            // textBoxMovingPointSpeed
            // 
            this.textBoxMovingPointSpeed.Location = new System.Drawing.Point(88, 48);
            this.textBoxMovingPointSpeed.Name = "textBoxMovingPointSpeed";
            this.textBoxMovingPointSpeed.Size = new System.Drawing.Size(120, 22);
            this.textBoxMovingPointSpeed.TabIndex = 2;
            // 
            // timerPointMover
            // 
            this.timerPointMover.Tick += new System.EventHandler(this.timerPointMover_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Старт X";
            // 
            // textBoxMovePointStartX
            // 
            this.textBoxMovePointStartX.Location = new System.Drawing.Point(88, 21);
            this.textBoxMovePointStartX.Name = "textBoxMovePointStartX";
            this.textBoxMovePointStartX.Size = new System.Drawing.Size(120, 22);
            this.textBoxMovePointStartX.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(232, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Финиш X";
            // 
            // textBoxMovePointFinishX
            // 
            this.textBoxMovePointFinishX.Location = new System.Drawing.Point(307, 21);
            this.textBoxMovePointFinishX.Name = "textBoxMovePointFinishX";
            this.textBoxMovePointFinishX.Size = new System.Drawing.Size(120, 22);
            this.textBoxMovePointFinishX.TabIndex = 2;
            // 
            // groupBoxFileSaving
            // 
            this.groupBoxFileSaving.Controls.Add(this.buttonLoadBinary);
            this.groupBoxFileSaving.Controls.Add(this.buttonSaveBinary);
            this.groupBoxFileSaving.Controls.Add(this.buttonSaveAsImage);
            this.groupBoxFileSaving.Location = new System.Drawing.Point(1272, 400);
            this.groupBoxFileSaving.Name = "groupBoxFileSaving";
            this.groupBoxFileSaving.Size = new System.Drawing.Size(440, 72);
            this.groupBoxFileSaving.TabIndex = 14;
            this.groupBoxFileSaving.TabStop = false;
            this.groupBoxFileSaving.Text = "Сохранение";
            // 
            // buttonSaveAsImage
            // 
            this.buttonSaveAsImage.Location = new System.Drawing.Point(8, 32);
            this.buttonSaveAsImage.Name = "buttonSaveAsImage";
            this.buttonSaveAsImage.Size = new System.Drawing.Size(144, 23);
            this.buttonSaveAsImage.TabIndex = 0;
            this.buttonSaveAsImage.Text = "PNG";
            this.buttonSaveAsImage.UseVisualStyleBackColor = true;
            this.buttonSaveAsImage.Click += new System.EventHandler(this.buttonSaveAsImage_Click);
            // 
            // buttonSaveBinary
            // 
            this.buttonSaveBinary.Location = new System.Drawing.Point(152, 32);
            this.buttonSaveBinary.Name = "buttonSaveBinary";
            this.buttonSaveBinary.Size = new System.Drawing.Size(136, 23);
            this.buttonSaveBinary.TabIndex = 0;
            this.buttonSaveBinary.Text = "SaveBinary";
            this.buttonSaveBinary.UseVisualStyleBackColor = true;
            this.buttonSaveBinary.Click += new System.EventHandler(this.buttonSaveBinary_Click);
            // 
            // buttonLoadBinary
            // 
            this.buttonLoadBinary.Location = new System.Drawing.Point(288, 32);
            this.buttonLoadBinary.Name = "buttonLoadBinary";
            this.buttonLoadBinary.Size = new System.Drawing.Size(144, 23);
            this.buttonLoadBinary.TabIndex = 0;
            this.buttonLoadBinary.Text = "LoadBinary";
            this.buttonLoadBinary.UseVisualStyleBackColor = true;
            this.buttonLoadBinary.Click += new System.EventHandler(this.buttonLoadBinary_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 817);
            this.Controls.Add(this.groupBoxFileSaving);
            this.Controls.Add(this.groupBoxMovePointByWay);
            this.Controls.Add(this.groupBoxEquationFromExpression);
            this.Controls.Add(this.groupBoxBuildOwnEquation);
            this.Controls.Add(this.groupBoxFindMinAndMax);
            this.Controls.Add(this.groupBoxAxisCollision);
            this.Controls.Add(this.groupBoxWorkWithPoint);
            this.Controls.Add(this.groupBoxFieldSettings);
            this.Controls.Add(this.groupBoxNewEquation);
            this.Controls.Add(this.groupBoxSelectedEquation);
            this.Controls.Add(this.listBoxEquations);
            this.Controls.Add(this.groupBoxChangeScale);
            this.Controls.Add(this.pictureBoxMainField);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainField)).EndInit();
            this.groupBoxChangeScale.ResumeLayout(false);
            this.groupBoxChangeScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleX)).EndInit();
            this.groupBoxSelectedEquation.ResumeLayout(false);
            this.groupBoxSelectedEquation.PerformLayout();
            this.groupBoxSelDF.ResumeLayout(false);
            this.groupBoxSelDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelToX)).EndInit();
            this.groupBoxNewEquation.ResumeLayout(false);
            this.groupBoxNewEquation.PerformLayout();
            this.groupBoxNewDF.ResumeLayout(false);
            this.groupBoxNewDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewToX)).EndInit();
            this.groupBoxFieldSettings.ResumeLayout(false);
            this.groupBoxWorkWithPoint.ResumeLayout(false);
            this.groupBoxWorkWithPoint.PerformLayout();
            this.groupBoxAxisCollision.ResumeLayout(false);
            this.groupBoxFindMinAndMax.ResumeLayout(false);
            this.groupBoxFindMinAndMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisCollisionPointsAccuracy)).EndInit();
            this.groupBoxBuildOwnEquation.ResumeLayout(false);
            this.groupBoxBuildOwnEquation.PerformLayout();
            this.groupBoxEquationFromExpression.ResumeLayout(false);
            this.groupBoxEquationFromExpression.PerformLayout();
            this.groupBoxMovePointByWay.ResumeLayout(false);
            this.groupBoxMovePointByWay.PerformLayout();
            this.groupBoxFileSaving.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        



        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainField;
        private System.Windows.Forms.GroupBox groupBoxChangeScale;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleX;
        private System.Windows.Forms.ListBox listBoxEquations;
        private System.Windows.Forms.GroupBox groupBoxSelectedEquation;
        private System.Windows.Forms.GroupBox groupBoxNewEquation;
        private System.Windows.Forms.ComboBox comboBoxSelectNewEquationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddNewEquation;
        private System.Windows.Forms.TextBox textBoxNewVerticalOffset;
        private System.Windows.Forms.TextBox textBoxNewCoef2;
        private System.Windows.Forms.TextBox textBoxNewCoef1;
        private System.Windows.Forms.Label labelNewVerticalOffset;
        private System.Windows.Forms.Label labelNewCoef2;
        private System.Windows.Forms.Label labelNewCoef1;
        private System.Windows.Forms.TextBox textBoxSelVerticalOffset;
        private System.Windows.Forms.TextBox textBoxSelCoef2;
        private System.Windows.Forms.TextBox textBoxSelCoef1;
        private System.Windows.Forms.Label labelSelVerticalOffset;
        private System.Windows.Forms.Label labelSelCoef2;
        private System.Windows.Forms.Label labelSelCoef1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSaveSelected;
        private System.Windows.Forms.Button buttonUnselectEquation;
        private System.Windows.Forms.Button buttonSelColor;
        private System.Windows.Forms.Button buttonCreateDefaultEquations;
        private System.Windows.Forms.Button buttonColorOfAxis;
        private System.Windows.Forms.Button buttonColorOfLines;
        private System.Windows.Forms.GroupBox groupBoxFieldSettings;
        private System.Windows.Forms.Label labelNewEndX;
        private System.Windows.Forms.Label labelNewStartX;
        private System.Windows.Forms.NumericUpDown numericUpDownNewToX;
        private System.Windows.Forms.NumericUpDown numericUpDownNewStartX;
        private System.Windows.Forms.GroupBox groupBoxNewDF;
        private System.Windows.Forms.GroupBox groupBoxSelDF;
        private System.Windows.Forms.NumericUpDown numericUpDownSelStartX;
        private System.Windows.Forms.NumericUpDown numericUpDownSelToX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxWorkWithPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPointY;
        private System.Windows.Forms.TextBox textBoxPointX;
        private System.Windows.Forms.Button buttonFuncValueInPoint;
        private System.Windows.Forms.Button buttonIsUpperOrLower;
        private System.Windows.Forms.Button buttonGetAxisCollisionPoints;
        private System.Windows.Forms.Button buttonDeleteAxisCollisionPoints;
        private System.Windows.Forms.GroupBox groupBoxAxisCollision;
        private System.Windows.Forms.Button buttonDeleteFuncValueInPoint;
        private System.Windows.Forms.GroupBox groupBoxFindMinAndMax;
        private System.Windows.Forms.Button buttonFindMinAndMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFindMinAndMax_Min;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFindMinAndMax_Max;
        private System.Windows.Forms.NumericUpDown numericUpDownAxisCollisionPointsAccuracy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonMinAndMaxPoints_Delete;
        private System.Windows.Forms.GroupBox groupBoxBuildOwnEquation;
        private System.Windows.Forms.TextBox textBoxBuildOwnEquationY;
        private System.Windows.Forms.TextBox textBoxBuildOwnEquationX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonFinishOwnEquationBuild;
        private System.Windows.Forms.Button buttonAddOwnEquationPoint;
        private System.Windows.Forms.GroupBox groupBoxEquationFromExpression;
        private System.Windows.Forms.Button buttonCreateEquationFromExpression;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEquationExpression;
        private System.Windows.Forms.GroupBox groupBoxMovePointByWay;
        private System.Windows.Forms.TextBox textBoxMovingPointSpeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonStartMovingPoint;
        private System.Windows.Forms.Timer timerPointMover;
        private System.Windows.Forms.TextBox textBoxMovePointStartX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMovePointFinishX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBoxFileSaving;
        private System.Windows.Forms.Button buttonLoadBinary;
        private System.Windows.Forms.Button buttonSaveBinary;
        private System.Windows.Forms.Button buttonSaveAsImage;
    }
}

