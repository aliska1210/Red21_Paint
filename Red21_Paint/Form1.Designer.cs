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
      this.openFile = new System.Windows.Forms.Button();
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
      this.deleteLayer = new System.Windows.Forms.Button();
      this.newLayer = new System.Windows.Forms.Button();
      this.pipette = new System.Windows.Forms.Button();
      this.Layer = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.layerPaintSurface = new System.Windows.Forms.PictureBox();
      this.colorDialog2 = new System.Windows.Forms.ColorDialog();
      this.background_color = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.heightCanvas = new System.Windows.Forms.NumericUpDown();
      this.widthCanvas = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.paintSurface)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizePen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumberOfCorners)).BeginInit();
      this.panel1.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layerPaintSurface)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.heightCanvas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.widthCanvas)).BeginInit();
      this.SuspendLayout();
      // 
      // paintSurface
      // 
      this.paintSurface.BackColor = System.Drawing.Color.White;
      this.paintSurface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.paintSurface.Location = new System.Drawing.Point(119, 81);
      this.paintSurface.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.paintSurface.MaximumSize = new System.Drawing.Size(1257, 2239);
      this.paintSurface.Name = "paintSurface";
      this.paintSurface.Size = new System.Drawing.Size(1208, 736);
      this.paintSurface.TabIndex = 0;
      this.paintSurface.TabStop = false;
      this.paintSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseDown);
      this.paintSurface.MouseHover += new System.EventHandler(this.paintSurface_MouseHover);
      this.paintSurface.MouseLeave += new System.EventHandler(this.paintSurface_MouseLeave);
      this.paintSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseMove);
      this.paintSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseUp);
      // 
      // save
      // 
      this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.save.Location = new System.Drawing.Point(68, 1);
      this.save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.save.Name = "save";
      this.save.Size = new System.Drawing.Size(63, 28);
      this.save.TabIndex = 0;
      this.save.Tag = "save";
      this.save.Text = "Save";
      this.save.UseVisualStyleBackColor = true;
      this.save.Click += new System.EventHandler(this.save_Click);
      // 
      // pencil
      // 
      this.pencil.BackColor = System.Drawing.SystemColors.Control;
      this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
      this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pencil.FlatAppearance.BorderSize = 0;
      this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.pencil.Location = new System.Drawing.Point(4, 9);
      this.pencil.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.pencil.Name = "pencil";
      this.pencil.Size = new System.Drawing.Size(48, 44);
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
      this.rectangle.Location = new System.Drawing.Point(55, 55);
      this.rectangle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.rectangle.Name = "rectangle";
      this.rectangle.Size = new System.Drawing.Size(48, 44);
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
      this.square.Location = new System.Drawing.Point(4, 55);
      this.square.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.square.Name = "square";
      this.square.Size = new System.Drawing.Size(48, 44);
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
      this.cyrcle.Location = new System.Drawing.Point(4, 101);
      this.cyrcle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.cyrcle.Name = "cyrcle";
      this.cyrcle.Size = new System.Drawing.Size(48, 44);
      this.cyrcle.TabIndex = 4;
      this.cyrcle.Tag = "Cyrcle";
      this.cyrcle.UseVisualStyleBackColor = false;
      this.cyrcle.Click += new System.EventHandler(this.circle_Click);
      // 
      // ellipse
      // 
      this.ellipse.BackColor = System.Drawing.SystemColors.Control;
      this.ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse.BackgroundImage")));
      this.ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ellipse.FlatAppearance.BorderSize = 0;
      this.ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ellipse.Location = new System.Drawing.Point(55, 101);
      this.ellipse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.ellipse.Name = "ellipse";
      this.ellipse.Size = new System.Drawing.Size(48, 44);
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
      this.triangleDraw.Location = new System.Drawing.Point(4, 146);
      this.triangleDraw.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.triangleDraw.Name = "triangleDraw";
      this.triangleDraw.Size = new System.Drawing.Size(48, 44);
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
      this.sasTriangle.Location = new System.Drawing.Point(55, 146);
      this.sasTriangle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.sasTriangle.Name = "sasTriangle";
      this.sasTriangle.Size = new System.Drawing.Size(48, 44);
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
      this.button33.Location = new System.Drawing.Point(5, 10);
      this.button33.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.button33.Name = "button33";
      this.button33.Size = new System.Drawing.Size(91, 71);
      this.button33.TabIndex = 8;
      this.button33.UseVisualStyleBackColor = false;
      this.button33.Click += new System.EventHandler(this.clear_Click);
      // 
      // openFile
      // 
      this.openFile.Location = new System.Drawing.Point(5, 1);
      this.openFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.openFile.Name = "openFile";
      this.openFile.Size = new System.Drawing.Size(63, 28);
      this.openFile.TabIndex = 9;
      this.openFile.Text = "Open";
      this.openFile.UseVisualStyleBackColor = true;
      this.openFile.Click += new System.EventHandler(this.openFile_Click);
      // 
      // randomNAngle
      // 
      this.randomNAngle.BackColor = System.Drawing.SystemColors.Control;
      this.randomNAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomNAngle.BackgroundImage")));
      this.randomNAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.randomNAngle.FlatAppearance.BorderSize = 0;
      this.randomNAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.randomNAngle.Location = new System.Drawing.Point(4, 192);
      this.randomNAngle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.randomNAngle.Name = "randomNAngle";
      this.randomNAngle.Size = new System.Drawing.Size(48, 44);
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
      this.nAngle.Location = new System.Drawing.Point(55, 192);
      this.nAngle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.nAngle.Name = "nAngle";
      this.nAngle.Size = new System.Drawing.Size(48, 44);
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
      this.laser.Location = new System.Drawing.Point(55, 9);
      this.laser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.laser.Name = "laser";
      this.laser.Size = new System.Drawing.Size(48, 44);
      this.laser.TabIndex = 12;
      this.laser.Tag = "Laser";
      this.laser.UseVisualStyleBackColor = false;
      this.laser.Click += new System.EventHandler(this.laser_Click);
      // 
      // sizePen
      // 
      this.sizePen.BackColor = System.Drawing.SystemColors.Control;
      this.sizePen.LargeChange = 2;
      this.sizePen.Location = new System.Drawing.Point(360, 26);
      this.sizePen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.sizePen.Maximum = 30;
      this.sizePen.Minimum = 1;
      this.sizePen.Name = "sizePen";
      this.sizePen.Size = new System.Drawing.Size(115, 56);
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
      this.line.Location = new System.Drawing.Point(55, 239);
      this.line.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.line.Name = "line";
      this.line.Size = new System.Drawing.Size(48, 44);
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
      this.NumberOfCorners.Size = new System.Drawing.Size(62, 22);
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
      this.buttonChooseColor.Location = new System.Drawing.Point(3, 34);
      this.buttonChooseColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonChooseColor.Name = "buttonChooseColor";
      this.buttonChooseColor.Size = new System.Drawing.Size(112, 106);
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
      this.button25.Location = new System.Drawing.Point(103, 11);
      this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button25.Name = "button25";
      this.button25.Size = new System.Drawing.Size(75, 69);
      this.button25.TabIndex = 16;
      this.button25.UseVisualStyleBackColor = false;
      this.button25.Click += new System.EventHandler(this.edit_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Control;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Controls.Add(this.deleteLayer);
      this.panel1.Controls.Add(this.newLayer);
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
      this.panel1.Location = new System.Drawing.Point(3, 146);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(107, 383);
      this.panel1.TabIndex = 17;
      // 
      // deleteLayer
      // 
      this.deleteLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.deleteLayer.Location = new System.Drawing.Point(63, 348);
      this.deleteLayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.deleteLayer.Name = "deleteLayer";
      this.deleteLayer.Size = new System.Drawing.Size(32, 33);
      this.deleteLayer.TabIndex = 25;
      this.deleteLayer.Text = "x";
      this.deleteLayer.UseVisualStyleBackColor = true;
      // 
      // newLayer
      // 
      this.newLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.newLayer.Location = new System.Drawing.Point(7, 348);
      this.newLayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.newLayer.Name = "newLayer";
      this.newLayer.Size = new System.Drawing.Size(32, 33);
      this.newLayer.TabIndex = 24;
      this.newLayer.Text = "+";
      this.newLayer.UseVisualStyleBackColor = true;
      this.newLayer.Click += new System.EventHandler(this.newLayer_Click);
      // 
      // pipette
      // 
      this.pipette.BackColor = System.Drawing.SystemColors.Control;
      this.pipette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipette.BackgroundImage")));
      this.pipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pipette.FlatAppearance.BorderSize = 0;
      this.pipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.pipette.Location = new System.Drawing.Point(3, 241);
      this.pipette.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.pipette.Name = "pipette";
      this.pipette.Size = new System.Drawing.Size(48, 44);
      this.pipette.TabIndex = 23;
      this.pipette.Tag = "pipette";
      this.pipette.UseVisualStyleBackColor = false;
      this.pipette.Click += new System.EventHandler(this.pipette_Click);
      // 
      // Layer
      // 
      this.Layer.AutoSize = true;
      this.Layer.BackColor = System.Drawing.Color.Transparent;
      this.Layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Layer.Location = new System.Drawing.Point(17, 327);
      this.Layer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Layer.Name = "Layer";
      this.Layer.Size = new System.Drawing.Size(61, 24);
      this.Layer.TabIndex = 22;
      this.Layer.Text = "Layer";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.BackColor = System.Drawing.Color.Transparent;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(5, 303);
      this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBox1.Name = "isFilledCheckBox";
      this.checkBox1.Size = new System.Drawing.Size(69, 21);
      this.checkBox1.TabIndex = 18;
      this.checkBox1.Text = "isFilled";
      this.checkBox1.UseVisualStyleBackColor = false;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoScroll = true;
      this.flowLayoutPanel1.BackColor = System.Drawing.Color.Azure;
      this.flowLayoutPanel1.Controls.Add(this.layerPaintSurface);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 538);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(104, 174);
      this.flowLayoutPanel1.TabIndex = 19;
      // 
      // layerPaintSurface
      // 
      this.layerPaintSurface.Location = new System.Drawing.Point(4, 4);
      this.layerPaintSurface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.layerPaintSurface.Name = "layerPaintSurface";
      this.layerPaintSurface.Size = new System.Drawing.Size(96, 50);
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
      this.background_color.Location = new System.Drawing.Point(189, -26);
      this.background_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.background_color.Name = "background_color";
      this.background_color.Size = new System.Drawing.Size(148, 149);
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
      this.panel2.Location = new System.Drawing.Point(139, -10);
      this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(504, 85);
      this.panel2.TabIndex = 22;
      // 
      // heightCanvas
      // 
      this.heightCanvas.Location = new System.Drawing.Point(665, 31);
      this.heightCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.heightCanvas.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.heightCanvas.Name = "heightCanvas";
      this.heightCanvas.Size = new System.Drawing.Size(97, 22);
      this.heightCanvas.TabIndex = 25;
      this.heightCanvas.Value = new decimal(new int[] {
            1820,
            0,
            0,
            0});
      // 
      // widthCanvas
      // 
      this.widthCanvas.Location = new System.Drawing.Point(771, 31);
      this.widthCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.widthCanvas.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.widthCanvas.Name = "widthCanvas";
      this.widthCanvas.Size = new System.Drawing.Size(97, 22);
      this.widthCanvas.TabIndex = 26;
      this.widthCanvas.Value = new decimal(new int[] {
            944,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.Control;
      this.label1.Location = new System.Drawing.Point(689, 2);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(131, 25);
      this.label1.TabIndex = 27;
      this.label1.Text = "Canvas size";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.SlateGray;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1344, 832);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.widthCanvas);
      this.Controls.Add(this.heightCanvas);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.buttonChooseColor);
      this.Controls.Add(this.openFile);
      this.Controls.Add(this.paintSurface);
      this.Controls.Add(this.save);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximumSize = new System.Drawing.Size(1814, 933);
      this.MinimumSize = new System.Drawing.Size(1059, 727);
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
      ((System.ComponentModel.ISupportInitialize)(this.heightCanvas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.widthCanvas)).EndInit();
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
        private System.Windows.Forms.Button openFile;
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
        private System.Windows.Forms.Button deleteLayer;
        private System.Windows.Forms.Button newLayer;
        private System.Windows.Forms.NumericUpDown heightCanvas;
        private System.Windows.Forms.NumericUpDown widthCanvas;
        private System.Windows.Forms.Label label1;
    }
}


