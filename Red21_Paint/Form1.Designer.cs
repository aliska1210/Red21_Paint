namespace Red21_Paint
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


        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paintSurface = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.cyrcle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.triangleDraw = new System.Windows.Forms.Button();
            this.sasTriangle = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.Button();
            this.randomNAngle = new System.Windows.Forms.Button();
            this.nAngle = new System.Windows.Forms.Button();
            this.laser = new System.Windows.Forms.Button();
            this.sizePen = new System.Windows.Forms.TrackBar();
            this.line = new System.Windows.Forms.Button();
            this.NumberOfCorners = new System.Windows.Forms.NumericUpDown();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button25 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layerPaintSurface = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.background_color = new System.Windows.Forms.Button();
            this.Layer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paintSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizePen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCorners)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerPaintSurface)).BeginInit();
            this.SuspendLayout();
            // 
            // paintSurface
            // 
            this.paintSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.paintSurface.BackColor = System.Drawing.Color.White;
      this.paintSurface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.paintSurface.Location = new System.Drawing.Point(81, 73);
      this.paintSurface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.paintSurface.MaximumSize = new System.Drawing.Size(1820, 944);
      this.paintSurface.Name = "paintSurface";
      this.paintSurface.Size = new System.Drawing.Size(1103, 669);
      this.paintSurface.TabIndex = 0;
      this.paintSurface.TabStop = false;
      this.paintSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseDown);
      this.paintSurface.MouseLeave += new System.EventHandler(this.paintSurface_MouseLeave);
      this.paintSurface.MouseHover += new System.EventHandler(this.paintSurface_MouseHover);
      this.paintSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseMove);
      this.paintSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseUp);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button1.Location = new System.Drawing.Point(4, 0);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(37, 34);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = false;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Red;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button2.Location = new System.Drawing.Point(29, 0);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(35, 34);
      this.button2.TabIndex = 1;
      this.button2.UseVisualStyleBackColor = false;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button4.Location = new System.Drawing.Point(55, 0);
      this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(35, 34);
      this.button4.TabIndex = 2;
      this.button4.UseVisualStyleBackColor = false;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button3.Location = new System.Drawing.Point(81, 0);
      this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(35, 34);
      this.button3.TabIndex = 3;
      this.button3.UseVisualStyleBackColor = false;
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.Yellow;
      this.button6.FlatAppearance.BorderSize = 0;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button6.Location = new System.Drawing.Point(107, 0);
      this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(35, 34);
      this.button6.TabIndex = 4;
      this.button6.UseVisualStyleBackColor = false;
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button5.Location = new System.Drawing.Point(131, 0);
      this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(35, 34);
      this.button5.TabIndex = 5;
      this.button5.UseVisualStyleBackColor = false;
      // 
      // button12
      // 
      this.button12.BackColor = System.Drawing.Color.Pink;
      this.button12.FlatAppearance.BorderSize = 0;
      this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button12.Location = new System.Drawing.Point(156, 0);
      this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(35, 34);
      this.button12.TabIndex = 6;
      this.button12.UseVisualStyleBackColor = false;
      // 
      // button11
      // 
      this.button11.BackColor = System.Drawing.Color.OrangeRed;
      this.button11.FlatAppearance.BorderSize = 0;
      this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button11.Location = new System.Drawing.Point(181, 0);
      this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(35, 34);
      this.button11.TabIndex = 7;
      this.button11.UseVisualStyleBackColor = false;
      // 
      // button10
      // 
      this.button10.BackColor = System.Drawing.Color.SpringGreen;
      this.button10.FlatAppearance.BorderSize = 0;
      this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button10.Location = new System.Drawing.Point(205, 0);
      this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(35, 34);
      this.button10.TabIndex = 8;
      this.button10.UseVisualStyleBackColor = false;
      // 
      // button9
      // 
      this.button9.BackColor = System.Drawing.Color.Olive;
      this.button9.FlatAppearance.BorderSize = 0;
      this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button9.Location = new System.Drawing.Point(232, 0);
      this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(35, 34);
      this.button9.TabIndex = 9;
      this.button9.UseVisualStyleBackColor = false;
      // 
      // button8
      // 
      this.button8.BackColor = System.Drawing.Color.DarkCyan;
      this.button8.FlatAppearance.BorderSize = 0;
      this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button8.Location = new System.Drawing.Point(257, 0);
      this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(35, 34);
      this.button8.TabIndex = 10;
      this.button8.UseVisualStyleBackColor = false;
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.Purple;
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button7.Location = new System.Drawing.Point(283, 0);
      this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(35, 34);
      this.button7.TabIndex = 11;
      this.button7.UseVisualStyleBackColor = false;
      // 
      // button24
      // 
      this.button24.BackColor = System.Drawing.Color.White;
      this.button24.FlatAppearance.BorderSize = 0;
      this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button24.Location = new System.Drawing.Point(4, 25);
      this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button24.Name = "button24";
      this.button24.Size = new System.Drawing.Size(35, 34);
      this.button24.TabIndex = 12;
      this.button24.UseVisualStyleBackColor = false;
      // 
      // button23
      // 
      this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.button23.FlatAppearance.BorderSize = 0;
      this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button23.Location = new System.Drawing.Point(29, 25);
      this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button23.Name = "button23";
      this.button23.Size = new System.Drawing.Size(35, 34);
      this.button23.TabIndex = 13;
      this.button23.UseVisualStyleBackColor = false;
      // 
      // button22
      // 
      this.button22.BackColor = System.Drawing.Color.Gray;
      this.button22.FlatAppearance.BorderSize = 0;
      this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button22.Location = new System.Drawing.Point(55, 25);
      this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button22.Name = "button22";
      this.button22.Size = new System.Drawing.Size(35, 34);
      this.button22.TabIndex = 14;
      this.button22.UseVisualStyleBackColor = false;
      // 
      // button21
      // 
      this.button21.BackColor = System.Drawing.Color.Silver;
      this.button21.FlatAppearance.BorderSize = 0;
      this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button21.Location = new System.Drawing.Point(80, 25);
      this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button21.Name = "button21";
      this.button21.Size = new System.Drawing.Size(35, 34);
      this.button21.TabIndex = 15;
      this.button21.UseVisualStyleBackColor = false;
      // 
      // button20
      // 
      this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.button20.FlatAppearance.BorderSize = 0;
      this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button20.Location = new System.Drawing.Point(105, 25);
      this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button20.Name = "button20";
      this.button20.Size = new System.Drawing.Size(35, 34);
      this.button20.TabIndex = 16;
      this.button20.UseVisualStyleBackColor = false;
      // 
      // button19
      // 
      this.button19.BackColor = System.Drawing.Color.Brown;
      this.button19.FlatAppearance.BorderSize = 0;
      this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button19.Location = new System.Drawing.Point(131, 25);
      this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button19.Name = "button19";
      this.button19.Size = new System.Drawing.Size(35, 34);
      this.button19.TabIndex = 17;
      this.button19.UseVisualStyleBackColor = false;
      // 
      // button18
      // 
      this.button18.BackColor = System.Drawing.Color.DarkRed;
      this.button18.FlatAppearance.BorderSize = 0;
      this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button18.Location = new System.Drawing.Point(156, 25);
      this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button18.Name = "button18";
      this.button18.Size = new System.Drawing.Size(35, 34);
      this.button18.TabIndex = 18;
      this.button18.UseVisualStyleBackColor = false;
      // 
      // button17
      // 
      this.button17.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.button17.FlatAppearance.BorderSize = 0;
      this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button17.Location = new System.Drawing.Point(181, 25);
      this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button17.Name = "button17";
      this.button17.Size = new System.Drawing.Size(35, 34);
      this.button17.TabIndex = 19;
      this.button17.UseVisualStyleBackColor = false;
      // 
      // button16
      // 
      this.button16.BackColor = System.Drawing.Color.SaddleBrown;
      this.button16.FlatAppearance.BorderSize = 0;
      this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button16.Location = new System.Drawing.Point(207, 25);
      this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button16.Name = "button16";
      this.button16.Size = new System.Drawing.Size(35, 34);
      this.button16.TabIndex = 20;
      this.button16.UseVisualStyleBackColor = false;
      // 
      // button15
      // 
      this.button15.BackColor = System.Drawing.Color.OliveDrab;
      this.button15.FlatAppearance.BorderSize = 0;
      this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button15.Location = new System.Drawing.Point(233, 25);
      this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button15.Name = "button15";
      this.button15.Size = new System.Drawing.Size(35, 34);
      this.button15.TabIndex = 21;
      this.button15.UseVisualStyleBackColor = false;
      // 
      // button14
      // 
      this.button14.BackColor = System.Drawing.Color.YellowGreen;
      this.button14.FlatAppearance.BorderSize = 0;
      this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button14.Location = new System.Drawing.Point(259, 25);
      this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button14.Name = "button14";
      this.button14.Size = new System.Drawing.Size(35, 34);
      this.button14.TabIndex = 22;
      this.button14.UseVisualStyleBackColor = false;
      // 
      // button13
      // 
      this.button13.BackColor = System.Drawing.Color.MediumAquamarine;
      this.button13.FlatAppearance.BorderSize = 0;
      this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button13.Location = new System.Drawing.Point(283, 25);
      this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button13.Name = "button13";
      this.button13.Size = new System.Drawing.Size(35, 34);
      this.button13.TabIndex = 23;
      this.button13.UseVisualStyleBackColor = false;
      // 
      // ColorBox
      // 
      this.ColorBox.Controls.Add(this.button13);
      this.ColorBox.Controls.Add(this.button14);
      this.ColorBox.Controls.Add(this.button15);
      this.ColorBox.Controls.Add(this.button16);
      this.ColorBox.Controls.Add(this.button17);
      this.ColorBox.Controls.Add(this.button18);
      this.ColorBox.Controls.Add(this.button19);
      this.ColorBox.Controls.Add(this.button20);
      this.ColorBox.Controls.Add(this.button21);
      this.ColorBox.Controls.Add(this.button22);
      this.ColorBox.Controls.Add(this.button23);
      this.ColorBox.Controls.Add(this.button24);
      this.ColorBox.Controls.Add(this.button7);
      this.ColorBox.Controls.Add(this.button8);
      this.ColorBox.Controls.Add(this.button9);
      this.ColorBox.Controls.Add(this.button10);
      this.ColorBox.Controls.Add(this.button11);
      this.ColorBox.Controls.Add(this.button12);
      this.ColorBox.Controls.Add(this.button5);
      this.ColorBox.Controls.Add(this.button6);
      this.ColorBox.Controls.Add(this.button3);
      this.ColorBox.Controls.Add(this.button4);
      this.ColorBox.Controls.Add(this.button2);
      this.ColorBox.Controls.Add(this.button1);
      this.ColorBox.Location = new System.Drawing.Point(61, 2);
      this.ColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ColorBox.Name = "ColorBox";
      this.ColorBox.Size = new System.Drawing.Size(415, 63);
      this.ColorBox.TabIndex = 1;
      // 
      // save
      // 
      this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.save.Location = new System.Drawing.Point(5, 37);
      this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.save.Name = "save";
      this.save.Size = new System.Drawing.Size(68, 34);
      this.save.TabIndex = 0;
      this.save.Tag = "save";
      this.save.Text = "Save";
      this.save.UseVisualStyleBackColor = true;
      // 
      // pencil
      // 
      this.pencil.BackColor = System.Drawing.SystemColors.Control;
      this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.pencil.Location = new System.Drawing.Point(4, 71);
      this.pencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pencil.Name = "pencil";
      this.pencil.Size = new System.Drawing.Size(68, 58);
      this.pencil.TabIndex = 1;
      this.pencil.Tag = "Pencil";
      this.pencil.Text = "Pencil";
      this.pencil.UseVisualStyleBackColor = false;
      this.pencil.Click += new System.EventHandler(this.pencil_Click);
      // 
      // rectangle
      // 
      this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rectangle.Location = new System.Drawing.Point(4, 124);
      this.rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rectangle.Name = "rectangle";
      this.rectangle.Size = new System.Drawing.Size(68, 58);
      this.rectangle.TabIndex = 2;
      this.rectangle.Tag = "Rectangle";
      this.rectangle.Text = "Rectangle";
      this.rectangle.UseVisualStyleBackColor = true;
      this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
      // 
      // square
      // 
      this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.square.Location = new System.Drawing.Point(4, 177);
      this.square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.square.Name = "square";
      this.square.Size = new System.Drawing.Size(68, 58);
      this.square.TabIndex = 3;
      this.square.Tag = "Square";
      this.square.Text = "Square";
      this.square.UseVisualStyleBackColor = true;
      // 
      // cyrcle
      // 
      this.cyrcle.Location = new System.Drawing.Point(4, 230);
      this.cyrcle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cyrcle.Name = "cyrcle";
      this.cyrcle.Size = new System.Drawing.Size(68, 58);
      this.cyrcle.TabIndex = 4;
      this.cyrcle.Tag = "Cyrcle";
      this.cyrcle.Text = "Cyrcle";
      this.cyrcle.UseVisualStyleBackColor = true;
      this.cyrcle.Click += new System.EventHandler(this.cyrcle_Click);
      // 
      // ellipse
      // 
      this.ellipse.Location = new System.Drawing.Point(4, 283);
      this.ellipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ellipse.Name = "ellipse";
      this.ellipse.Size = new System.Drawing.Size(68, 58);
      this.ellipse.TabIndex = 5;
      this.ellipse.Tag = "Ellipse";
      this.ellipse.Text = "Ellipse";
      this.ellipse.UseVisualStyleBackColor = true;
      this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
      // 
      // triangleDraw
      // 
      this.triangleDraw.Location = new System.Drawing.Point(4, 336);
      this.triangleDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.triangleDraw.Name = "triangleDraw";
      this.triangleDraw.Size = new System.Drawing.Size(68, 58);
      this.triangleDraw.TabIndex = 6;
      this.triangleDraw.Tag = "Triangle";
      this.triangleDraw.Text = "Triangle";
      this.triangleDraw.UseVisualStyleBackColor = true;
      this.triangleDraw.Click += new System.EventHandler(this.triangleDraw_Click);
      // 
      // sasTriangle
      // 
      this.sasTriangle.Location = new System.Drawing.Point(4, 390);
      this.sasTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.sasTriangle.Name = "sasTriangle";
      this.sasTriangle.Size = new System.Drawing.Size(68, 58);
      this.sasTriangle.TabIndex = 7;
      this.sasTriangle.Tag = "SasTriangle";
      this.sasTriangle.Text = "SasT";
      this.sasTriangle.UseVisualStyleBackColor = true;
      this.sasTriangle.Click += new System.EventHandler(this.sasTriangle_Click);
      // 
      // button33
      // 
      this.button33.FlatAppearance.BorderSize = 0;
      this.button33.Location = new System.Drawing.Point(376, 6);
      this.button33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button33.Name = "button33";
      this.button33.Size = new System.Drawing.Size(68, 58);
      this.button33.TabIndex = 8;
      this.button33.Text = "Clear";
      this.button33.UseVisualStyleBackColor = true;
      this.button33.Click += new System.EventHandler(this.clear_Click);
      // 
      // ImageBox
      // 
      this.ImageBox.Location = new System.Drawing.Point(4, 7);
      this.ImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ImageBox.Name = "ImageBox";
      this.ImageBox.Size = new System.Drawing.Size(68, 30);
      this.ImageBox.TabIndex = 9;
      this.ImageBox.Text = "Open";
      this.ImageBox.UseVisualStyleBackColor = true;
      // 
      // randomNAngle
      // 
      this.randomNAngle.Location = new System.Drawing.Point(4, 495);
      this.randomNAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.randomNAngle.Name = "randomNAngle";
      this.randomNAngle.Size = new System.Drawing.Size(68, 58);
      this.randomNAngle.TabIndex = 11;
      this.randomNAngle.Tag = "RandomNAngle";
      this.randomNAngle.Text = "RandNAngle";
      this.randomNAngle.UseVisualStyleBackColor = true;
      // 
      // nAngle
      // 
      this.nAngle.Location = new System.Drawing.Point(4, 442);
      this.nAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.nAngle.Name = "nAngle";
      this.nAngle.Size = new System.Drawing.Size(68, 58);
      this.nAngle.TabIndex = 10;
      this.nAngle.Tag = "NAngle";
      this.nAngle.Text = "NAngle";
      this.nAngle.UseVisualStyleBackColor = true;
  
      // 
      // laser
      // 
      this.laser.FlatAppearance.BorderSize = 0;
      this.laser.Location = new System.Drawing.Point(433, 6);
      this.laser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.laser.Name = "laser";
      this.laser.Size = new System.Drawing.Size(68, 58);
      this.laser.TabIndex = 12;
      this.laser.Tag = "Laser";
      this.laser.Text = "Laser";
      this.laser.UseVisualStyleBackColor = true;
      this.laser.Click += new System.EventHandler(this.laser_Click);
      // 
      // sizePen
      // 
      this.sizePen.LargeChange = 2;
      this.sizePen.Location = new System.Drawing.Point(503, 6);
      this.sizePen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.sizePen.Maximum = 30;
      this.sizePen.Minimum = 1;
      this.sizePen.Name = "sizePen";
      this.sizePen.Size = new System.Drawing.Size(104, 56);
      this.sizePen.TabIndex = 5;
      this.sizePen.TickFrequency = 3;
      this.sizePen.Value = 1;
      // 
      // line
      // 
      this.line.Location = new System.Drawing.Point(4, 548);
      this.line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.line.Name = "line";
      this.line.Size = new System.Drawing.Size(68, 58);
      this.line.TabIndex = 14;
      this.line.Tag = "Line";
      this.line.Text = "Line";
      this.line.UseVisualStyleBackColor = true;
      this.line.Click += new System.EventHandler(this.line_Click);
      // 
      // NumberOfCorners
      // 
      this.NumberOfCorners.Location = new System.Drawing.Point(799, 17);
      this.NumberOfCorners.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfCorners.Name = "NumberOfCorners";
            this.NumberOfCorners.Size = new System.Drawing.Size(62, 20);
            this.NumberOfCorners.TabIndex = 15;
            this.NumberOfCorners.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfCorners.ValueChanged += new System.EventHandler(this.NumberOfCorners_ValueChanged);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChooseColor.BackgroundImage")));
            this.buttonChooseColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChooseColor.FlatAppearance.BorderSize = 0;
            this.buttonChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseColor.Location = new System.Drawing.Point(3, 59);
            this.buttonChooseColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(84, 86);
            this.buttonChooseColor.TabIndex = 15;
            this.buttonChooseColor.Text = "Choose Color";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // button25
            // 
            this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(177, 4);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(56, 56);
            this.button25.TabIndex = 16;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.laser);
            this.panel1.Controls.Add(this.randomNAngle);
            this.panel1.Controls.Add(this.nAngle);
            this.panel1.Controls.Add(this.sasTriangle);
            this.panel1.Controls.Add(this.triangleDraw);
            this.panel1.Controls.Add(this.ellipse);
            this.panel1.Controls.Add(this.cyrcle);
            this.panel1.Controls.Add(this.square);
            this.panel1.Controls.Add(this.pencil);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Location = new System.Drawing.Point(3, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 226);
            this.panel1.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(3, 381);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "ColorPacked";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel1.Controls.Add(this.layerPaintSurface);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 420);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(78, 141);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // layerPaintSurface
            // 
            this.layerPaintSurface.Location = new System.Drawing.Point(3, 3);
            this.layerPaintSurface.Name = "layerPaintSurface";
            this.layerPaintSurface.Size = new System.Drawing.Size(72, 41);
            this.layerPaintSurface.TabIndex = 0;
            this.layerPaintSurface.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(994, 61);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(15, 489);
            this.vScrollBar1.TabIndex = 20;
            // 
            // background_color
            // 
            this.background_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background_color.BackgroundImage")));
            this.background_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_color.FlatAppearance.BorderSize = 0;
            this.background_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.background_color.Location = new System.Drawing.Point(237, 3);
            this.background_color.Name = "background_color";
            this.background_color.Size = new System.Drawing.Size(56, 56);
            this.background_color.TabIndex = 21;
            this.background_color.UseVisualStyleBackColor = true;
            this.background_color.Click += new System.EventHandler(this.background_color_Click);
            // 
            // Layer
            // 
            this.Layer.AutoSize = true;
            this.Layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Layer.Location = new System.Drawing.Point(18, 399);
            this.Layer.Name = "Layer";
            this.Layer.Size = new System.Drawing.Size(49, 18);
            this.Layer.TabIndex = 22;
            this.Layer.Text = "Layer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 557);
            this.Controls.Add(this.Layer);
            this.Controls.Add(this.background_color);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.sizePen);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.paintSurface);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red21_Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paintSurface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizePen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCorners)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layerPaintSurface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button cyrcle;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button triangleDraw;
        private System.Windows.Forms.Button sasTriangle;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button ImageBox;
        private System.Windows.Forms.Button randomNAngle;
        private System.Windows.Forms.Button nAngle;
        private System.Windows.Forms.Button laser;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.TrackBar sizePen;
        public System.Windows.Forms.PictureBox paintSurface;
        private System.Windows.Forms.NumericUpDown NumberOfCorners;
    private System.Windows.Forms.Button buttonChooseColor;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button background_color;
        private System.Windows.Forms.PictureBox layerPaintSurface;
        private System.Windows.Forms.Label Layer;
    }
}


