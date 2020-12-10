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
            this.paintSurface.Location = new System.Drawing.Point(87, 59);
            this.paintSurface.Margin = new System.Windows.Forms.Padding(2);
            this.paintSurface.MaximumSize = new System.Drawing.Size(1366, 768);
            this.paintSurface.Name = "paintSurface";
            this.paintSurface.Size = new System.Drawing.Size(1136, 564);
            this.paintSurface.TabIndex = 0;
            this.paintSurface.TabStop = false;
            this.paintSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseDown);
            this.paintSurface.MouseLeave += new System.EventHandler(this.paintSurface_MouseLeave);
            this.paintSurface.MouseHover += new System.EventHandler(this.paintSurface_MouseHover);
            this.paintSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseMove);
            this.paintSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseUp);
            // 
            // save
            // 
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(62, 5);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(51, 24);
            this.save.TabIndex = 0;
            this.save.Tag = "save";
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.LightSlateGray;
            this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencil.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pencil.FlatAppearance.BorderSize = 2;
            this.pencil.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil.Location = new System.Drawing.Point(5, 5);
            this.pencil.Margin = new System.Windows.Forms.Padding(2);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(32, 33);
            this.pencil.TabIndex = 1;
            this.pencil.Tag = "Pencil";
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.LightSlateGray;
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangle.FlatAppearance.BorderSize = 2;
            this.rectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Location = new System.Drawing.Point(41, 42);
            this.rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(32, 32);
            this.rectangle.TabIndex = 2;
            this.rectangle.Tag = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.LightSlateGray;
            this.square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square.BackgroundImage")));
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.square.FlatAppearance.BorderSize = 2;
            this.square.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Location = new System.Drawing.Point(5, 42);
            this.square.Margin = new System.Windows.Forms.Padding(2);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(32, 32);
            this.square.TabIndex = 3;
            this.square.Tag = "Square";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // cyrcle
            // 
            this.cyrcle.BackColor = System.Drawing.Color.LightSlateGray;
            this.cyrcle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cyrcle.BackgroundImage")));
            this.cyrcle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cyrcle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cyrcle.FlatAppearance.BorderSize = 2;
            this.cyrcle.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.cyrcle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cyrcle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cyrcle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyrcle.Location = new System.Drawing.Point(41, 78);
            this.cyrcle.Margin = new System.Windows.Forms.Padding(2);
            this.cyrcle.Name = "cyrcle";
            this.cyrcle.Size = new System.Drawing.Size(32, 32);
            this.cyrcle.TabIndex = 4;
            this.cyrcle.Tag = "Cyrcle";
            this.cyrcle.UseVisualStyleBackColor = false;
            this.cyrcle.Click += new System.EventHandler(this.cyrcle_Click);
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.Color.LightSlateGray;
            this.ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse.BackgroundImage")));
            this.ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ellipse.FlatAppearance.BorderSize = 2;
            this.ellipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipse.Location = new System.Drawing.Point(5, 78);
            this.ellipse.Margin = new System.Windows.Forms.Padding(2);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(32, 32);
            this.ellipse.TabIndex = 5;
            this.ellipse.Tag = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // triangleDraw
            // 
            this.triangleDraw.BackColor = System.Drawing.Color.LightSlateGray;
            this.triangleDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangleDraw.BackgroundImage")));
            this.triangleDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangleDraw.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.triangleDraw.FlatAppearance.BorderSize = 2;
            this.triangleDraw.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.triangleDraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.triangleDraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.triangleDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleDraw.Location = new System.Drawing.Point(41, 114);
            this.triangleDraw.Margin = new System.Windows.Forms.Padding(2);
            this.triangleDraw.Name = "triangleDraw";
            this.triangleDraw.Size = new System.Drawing.Size(32, 32);
            this.triangleDraw.TabIndex = 6;
            this.triangleDraw.Tag = "Triangle";
            this.triangleDraw.UseVisualStyleBackColor = false;
            this.triangleDraw.Click += new System.EventHandler(this.triangleDraw_Click);
            // 
            // sasTriangle
            // 
            this.sasTriangle.BackColor = System.Drawing.Color.LightSlateGray;
            this.sasTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sasTriangle.BackgroundImage")));
            this.sasTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sasTriangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sasTriangle.FlatAppearance.BorderSize = 2;
            this.sasTriangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.sasTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sasTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.sasTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sasTriangle.Location = new System.Drawing.Point(5, 114);
            this.sasTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.sasTriangle.Name = "sasTriangle";
            this.sasTriangle.Size = new System.Drawing.Size(32, 32);
            this.sasTriangle.TabIndex = 7;
            this.sasTriangle.Tag = "SasTriangle";
            this.sasTriangle.UseVisualStyleBackColor = false;
            this.sasTriangle.Click += new System.EventHandler(this.sasTriangle_Click);
            // 
            // button33
            // 
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.Location = new System.Drawing.Point(117, 5);
            this.button33.Margin = new System.Windows.Forms.Padding(2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(56, 56);
            this.button33.TabIndex = 8;
            this.button33.Text = "Clear";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.clear_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(7, 5);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(51, 24);
            this.ImageBox.TabIndex = 9;
            this.ImageBox.Text = "Open";
            this.ImageBox.UseVisualStyleBackColor = true;
            // 
            // randomNAngle
            // 
            this.randomNAngle.BackColor = System.Drawing.Color.LightSlateGray;
            this.randomNAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomNAngle.BackgroundImage")));
            this.randomNAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomNAngle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.randomNAngle.FlatAppearance.BorderSize = 2;
            this.randomNAngle.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.randomNAngle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.randomNAngle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.randomNAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomNAngle.Location = new System.Drawing.Point(5, 150);
            this.randomNAngle.Margin = new System.Windows.Forms.Padding(2);
            this.randomNAngle.Name = "randomNAngle";
            this.randomNAngle.Size = new System.Drawing.Size(32, 32);
            this.randomNAngle.TabIndex = 11;
            this.randomNAngle.Tag = "RandomNAngle";
            this.randomNAngle.UseVisualStyleBackColor = false;
            // 
            // nAngle
            // 
            this.nAngle.BackColor = System.Drawing.Color.LightSlateGray;
            this.nAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nAngle.BackgroundImage")));
            this.nAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nAngle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nAngle.FlatAppearance.BorderSize = 2;
            this.nAngle.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.nAngle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nAngle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.nAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nAngle.Location = new System.Drawing.Point(41, 150);
            this.nAngle.Margin = new System.Windows.Forms.Padding(2);
            this.nAngle.Name = "nAngle";
            this.nAngle.Size = new System.Drawing.Size(32, 32);
            this.nAngle.TabIndex = 10;
            this.nAngle.Tag = "NAngle";
            this.nAngle.UseVisualStyleBackColor = false;
            this.nAngle.Click += new System.EventHandler(this.nAngle_Click);
            // 
            // laser
            // 
            this.laser.BackColor = System.Drawing.Color.LightSlateGray;
            this.laser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laser.BackgroundImage")));
            this.laser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.laser.FlatAppearance.BorderSize = 2;
            this.laser.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.laser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.laser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.laser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laser.Location = new System.Drawing.Point(41, 5);
            this.laser.Margin = new System.Windows.Forms.Padding(2);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(32, 33);
            this.laser.TabIndex = 12;
            this.laser.Tag = "Eraser";
            this.laser.UseVisualStyleBackColor = false;
            this.laser.Click += new System.EventHandler(this.laser_Click);
            // 
            // sizePen
            // 
            this.sizePen.LargeChange = 2;
            this.sizePen.Location = new System.Drawing.Point(298, 16);
            this.sizePen.Margin = new System.Windows.Forms.Padding(2);
            this.sizePen.Maximum = 30;
            this.sizePen.Minimum = 1;
            this.sizePen.Name = "sizePen";
            this.sizePen.Size = new System.Drawing.Size(78, 45);
            this.sizePen.TabIndex = 5;
            this.sizePen.TickFrequency = 3;
            this.sizePen.Value = 1;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.LightSlateGray;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line.FlatAppearance.BorderSize = 2;
            this.line.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(41, 186);
            this.line.Margin = new System.Windows.Forms.Padding(2);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(32, 32);
            this.line.TabIndex = 14;
            this.line.Tag = "Line";
            this.line.UseVisualStyleBackColor = false;
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


