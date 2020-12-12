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
            this.Layer = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layerPaintSurface = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.background_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pipette = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizePen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCorners)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerPaintSurface)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintSurface
            // 
            this.paintSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintSurface.BackColor = System.Drawing.Color.White;
            this.paintSurface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintSurface.Location = new System.Drawing.Point(88, 66);
            this.paintSurface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paintSurface.MaximumSize = new System.Drawing.Size(1820, 944);
            this.paintSurface.Name = "paintSurface";
            this.paintSurface.Size = new System.Drawing.Size(1103, 669);
            this.paintSurface.TabIndex = 0;
            this.paintSurface.TabStop = false;
            this.paintSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseDown);
            this.paintSurface.MouseHover += new System.EventHandler(this.paintSurface_MouseHover);
            this.paintSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseMove);
            this.paintSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseUp);
            // 
            // save
            // 
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(51, 1);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(47, 23);
            this.save.TabIndex = 0;
            this.save.Tag = "save";
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.SystemColors.Control;
            this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencil.FlatAppearance.BorderSize = 0;
            this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil.Location = new System.Drawing.Point(3, 7);
            this.pencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(36, 36);
            this.pencil.TabIndex = 1;
            this.pencil.Tag = "Pencil";
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Location = new System.Drawing.Point(41, 45);
            this.rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(36, 36);
            this.rectangle.TabIndex = 2;
            this.rectangle.Tag = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.Control;
            this.square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square.BackgroundImage")));
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Location = new System.Drawing.Point(3, 45);
            this.square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(36, 36);
            this.square.TabIndex = 3;
            this.square.Tag = "Square";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // cyrcle
            // 
            this.cyrcle.BackColor = System.Drawing.SystemColors.Control;
            this.cyrcle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cyrcle.BackgroundImage")));
            this.cyrcle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cyrcle.FlatAppearance.BorderSize = 0;
            this.cyrcle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyrcle.Location = new System.Drawing.Point(3, 82);
            this.cyrcle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cyrcle.Name = "cyrcle";
            this.cyrcle.Size = new System.Drawing.Size(36, 36);
            this.cyrcle.TabIndex = 4;
            this.cyrcle.Tag = "Cyrcle";
            this.cyrcle.UseVisualStyleBackColor = false;
            this.cyrcle.Click += new System.EventHandler(this.cyrcle_Click);
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.SystemColors.Control;
            this.ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse.BackgroundImage")));
            this.ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipse.FlatAppearance.BorderSize = 0;
            this.ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipse.Location = new System.Drawing.Point(41, 82);
            this.ellipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(36, 36);
            this.ellipse.TabIndex = 5;
            this.ellipse.Tag = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // triangleDraw
            // 
            this.triangleDraw.BackColor = System.Drawing.SystemColors.Control;
            this.triangleDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangleDraw.BackgroundImage")));
            this.triangleDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangleDraw.FlatAppearance.BorderSize = 0;
            this.triangleDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleDraw.Location = new System.Drawing.Point(3, 119);
            this.triangleDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleDraw.Name = "triangleDraw";
            this.triangleDraw.Size = new System.Drawing.Size(36, 36);
            this.triangleDraw.TabIndex = 6;
            this.triangleDraw.Tag = "Triangle";
            this.triangleDraw.UseVisualStyleBackColor = false;
            this.triangleDraw.Click += new System.EventHandler(this.triangleDraw_Click);
            // 
            // sasTriangle
            // 
            this.sasTriangle.BackColor = System.Drawing.SystemColors.Control;
            this.sasTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sasTriangle.BackgroundImage")));
            this.sasTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sasTriangle.FlatAppearance.BorderSize = 0;
            this.sasTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sasTriangle.Location = new System.Drawing.Point(41, 119);
            this.sasTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sasTriangle.Name = "sasTriangle";
            this.sasTriangle.Size = new System.Drawing.Size(36, 36);
            this.sasTriangle.TabIndex = 7;
            this.sasTriangle.Tag = "SasTriangle";
            this.sasTriangle.UseVisualStyleBackColor = false;
            this.sasTriangle.Click += new System.EventHandler(this.sasTriangle_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Transparent;
            this.button33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button33.BackgroundImage")));
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(4, 8);
            this.button33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(68, 58);
            this.button33.TabIndex = 8;
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.clear_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(4, 1);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(47, 23);
            this.ImageBox.TabIndex = 9;
            this.ImageBox.Text = "Open";
            this.ImageBox.UseVisualStyleBackColor = true;
            // 
            // randomNAngle
            // 
            this.randomNAngle.BackColor = System.Drawing.SystemColors.Control;
            this.randomNAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomNAngle.BackgroundImage")));
            this.randomNAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomNAngle.FlatAppearance.BorderSize = 0;
            this.randomNAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomNAngle.Location = new System.Drawing.Point(3, 156);
            this.randomNAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomNAngle.Name = "randomNAngle";
            this.randomNAngle.Size = new System.Drawing.Size(36, 36);
            this.randomNAngle.TabIndex = 11;
            this.randomNAngle.Tag = "RandomNAngle";
            this.randomNAngle.UseVisualStyleBackColor = false;
            // 
            // nAngle
            // 
            this.nAngle.BackColor = System.Drawing.SystemColors.Control;
            this.nAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nAngle.BackgroundImage")));
            this.nAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nAngle.FlatAppearance.BorderSize = 0;
            this.nAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nAngle.Location = new System.Drawing.Point(41, 156);
            this.nAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nAngle.Name = "nAngle";
            this.nAngle.Size = new System.Drawing.Size(36, 36);
            this.nAngle.TabIndex = 10;
            this.nAngle.Tag = "NAngle";
            this.nAngle.UseVisualStyleBackColor = false;
            this.nAngle.Click += new System.EventHandler(this.nAngle_Click);
            // 
            // laser
            // 
            this.laser.BackColor = System.Drawing.SystemColors.Control;
            this.laser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laser.BackgroundImage")));
            this.laser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laser.FlatAppearance.BorderSize = 0;
            this.laser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laser.Location = new System.Drawing.Point(41, 7);
            this.laser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(36, 36);
            this.laser.TabIndex = 12;
            this.laser.Tag = "Laser";
            this.laser.UseVisualStyleBackColor = false;
            this.laser.Click += new System.EventHandler(this.laser_Click);
            // 
            // sizePen
            // 
            this.sizePen.BackColor = System.Drawing.SystemColors.Control;
            this.sizePen.LargeChange = 2;
            this.sizePen.Location = new System.Drawing.Point(270, 21);
            this.sizePen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizePen.Maximum = 30;
            this.sizePen.Minimum = 1;
            this.sizePen.Name = "sizePen";
            this.sizePen.Size = new System.Drawing.Size(86, 45);
            this.sizePen.TabIndex = 5;
            this.sizePen.TickFrequency = 3;
            this.sizePen.Value = 1;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.Control;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(41, 194);
            this.line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(36, 36);
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
            this.buttonChooseColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonChooseColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChooseColor.BackgroundImage")));
            this.buttonChooseColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChooseColor.FlatAppearance.BorderSize = 0;
            this.buttonChooseColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseColor.Location = new System.Drawing.Point(2, 28);
            this.buttonChooseColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(84, 86);
            this.buttonChooseColor.TabIndex = 15;
            this.buttonChooseColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonChooseColor.UseVisualStyleBackColor = false;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(77, 9);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(56, 56);
            this.button25.TabIndex = 16;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pipette);
            this.panel1.Controls.Add(this.Layer);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.laser);
            this.panel1.Controls.Add(this.randomNAngle);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.nAngle);
            this.panel1.Controls.Add(this.sasTriangle);
            this.panel1.Controls.Add(this.triangleDraw);
            this.panel1.Controls.Add(this.ellipse);
            this.panel1.Controls.Add(this.cyrcle);
            this.panel1.Controls.Add(this.square);
            this.panel1.Controls.Add(this.pencil);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Location = new System.Drawing.Point(2, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 288);
            this.panel1.TabIndex = 17;
            // 
            // Layer
            // 
            this.Layer.AutoSize = true;
            this.Layer.BackColor = System.Drawing.Color.Transparent;
            this.Layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Layer.Location = new System.Drawing.Point(13, 266);
            this.Layer.Name = "Layer";
            this.Layer.Size = new System.Drawing.Size(49, 18);
            this.Layer.TabIndex = 22;
            this.Layer.Text = "Layer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(4, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "ColorPack";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel1.Controls.Add(this.layerPaintSurface);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 413);
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
            // background_color
            // 
            this.background_color.BackColor = System.Drawing.Color.Transparent;
            this.background_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background_color.BackgroundImage")));
            this.background_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_color.FlatAppearance.BorderSize = 0;
            this.background_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.background_color.Location = new System.Drawing.Point(142, -21);
            this.background_color.Name = "background_color";
            this.background_color.Size = new System.Drawing.Size(111, 121);
            this.background_color.TabIndex = 21;
            this.background_color.UseVisualStyleBackColor = false;
            this.background_color.Click += new System.EventHandler(this.background_color_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.background_color);
            this.panel2.Controls.Add(this.sizePen);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button33);
            this.panel2.Location = new System.Drawing.Point(104, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 69);
            this.panel2.TabIndex = 22;
            // 
            // pipette
            // 
            this.pipette.BackColor = System.Drawing.SystemColors.Control;
            this.pipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipette.FlatAppearance.BorderSize = 0;
            this.pipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipette.Location = new System.Drawing.Point(2, 196);
            this.pipette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipette.Name = "pipette";
            this.pipette.Size = new System.Drawing.Size(36, 36);
            this.pipette.TabIndex = 23;
            this.pipette.Tag = "pipette";
            this.pipette.Text = "Пипетка";
            this.pipette.UseVisualStyleBackColor = false;
            this.pipette.Click += new System.EventHandler(this.pipette_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.paintSurface);
            this.Controls.Add(this.save);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layerPaintSurface)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button background_color;
        private System.Windows.Forms.PictureBox layerPaintSurface;
        private System.Windows.Forms.Label Layer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pipette;
    }
}


