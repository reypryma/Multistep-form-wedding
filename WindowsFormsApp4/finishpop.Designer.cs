namespace WindowsFormsApp4
{
    partial class FinishForm
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishForm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.imageIcon = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 0.3F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.TimeStep = 0.2F;
            // 
            // imageIcon
            // 
            this.imageIcon.ActiveImage = null;
            this.imageIcon.AllowAnimations = true;
            this.imageIcon.AllowBuffering = false;
            this.imageIcon.AllowZooming = true;
            this.imageIcon.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.imageIcon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.imageIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageIcon.ErrorImage")));
            this.imageIcon.FadeWhenInactive = false;
            this.imageIcon.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageIcon.Image = ((System.Drawing.Image)(resources.GetObject("imageIcon.Image")));
            this.imageIcon.ActiveImage = null;
            this.imageIcon.ImageLocation = null;
            this.imageIcon.ImageMargin = 40;
            this.imageIcon.ImageSize = new System.Drawing.Size(417, 305);
            this.imageIcon.ImageZoomSize = new System.Drawing.Size(457, 345);
            this.imageIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageIcon.InitialImage")));
            this.imageIcon.Location = new System.Drawing.Point(4, -1);
            this.imageIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageIcon.Name = "imageIcon";
            this.imageIcon.Rotation = 0;
            this.imageIcon.ShowActiveImage = true;
            this.imageIcon.ShowCursorChanges = true;
            this.imageIcon.ShowImageBorders = true;
            this.imageIcon.ShowSizeMarkers = false;
            this.imageIcon.Size = new System.Drawing.Size(457, 345);
            this.imageIcon.TabIndex = 1;
            this.imageIcon.ToolTipText = "";
            this.imageIcon.WaitOnLoad = false;
            this.imageIcon.ImageMargin = 40;
            this.imageIcon.ZoomSpeed = 10;
            // 
            // btnok
            // 
            this.btnok.AllowToggling = false;
            this.btnok.AnimationSpeed = 200;
            this.btnok.AutoGenerateColors = false;
            this.btnok.BackColor = System.Drawing.Color.Transparent;
            this.btnok.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnok.ButtonText = "Terima kasih";
            this.btnok.ButtonTextMarginLeft = 0;
            this.btnok.ColorContrastOnClick = 45;
            this.btnok.ColorContrastOnHover = 45;
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnok.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.btnok, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnok.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnok.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnok.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnok.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnok.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.IconMarginLeft = 11;
            this.btnok.IconPadding = 10;
            this.btnok.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnok.IdleBorderRadius = 3;
            this.btnok.IdleBorderThickness = 1;
            this.btnok.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnok.IdleIconLeftImage = null;
            this.btnok.IdleIconRightImage = null;
            this.btnok.IndicateFocus = false;
            this.btnok.Location = new System.Drawing.Point(127, 350);
            this.btnok.Name = "btnok";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnok.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnok.OnPressedState = stateProperties6;
            this.btnok.Size = new System.Drawing.Size(210, 45);
            this.btnok.TabIndex = 0;
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.TextMarginLeft = 0;
            this.btnok.UseDefaultRadiusAndThickness = true;
            this.btnok.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 0;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuTextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuTextBox1.DefaultText = "Penginputan Form Berhasil, Semoga Pernikahannya\r\nBahagia dan Sejahtera selamanya";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[] {
        "Penginputan Form Berhasil, Semoga Pernikahannya",
        "Bahagia dan Sejahtera selamanya"};
            this.bunifuTextBox1.Location = new System.Drawing.Point(75, 248);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = true;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Teal;
            this.bunifuTextBox1.PlaceholderText = "Enter text";
            this.bunifuTextBox1.ReadOnly = true;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(315, 96);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 2;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Enter text";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // FinishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 416);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.imageIcon);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "finishpop";
            this.Load += new System.EventHandler(this.FinishForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnok;
        private Bunifu.UI.WinForms.BunifuImageButton imageIcon;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
    }
}