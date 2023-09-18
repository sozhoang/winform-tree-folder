namespace ApplicationOfDP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvTreeFolder = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btShow = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.txtNumItems = new System.Windows.Forms.TextBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbImage = new System.Windows.Forms.CheckBox();
            this.cbVideo = new System.Windows.Forms.CheckBox();
            this.cbWord = new System.Windows.Forms.CheckBox();
            this.cbExcel = new System.Windows.Forms.CheckBox();
            this.cbPDF = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tvTreeFolder
            // 
            this.tvTreeFolder.BackColor = System.Drawing.Color.White;
            this.tvTreeFolder.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tvTreeFolder.ImageIndex = 0;
            this.tvTreeFolder.ImageList = this.imageList1;
            this.tvTreeFolder.Location = new System.Drawing.Point(54, 138);
            this.tvTreeFolder.Name = "tvTreeFolder";
            this.tvTreeFolder.SelectedImageIndex = 0;
            this.tvTreeFolder.Size = new System.Drawing.Size(642, 385);
            this.tvTreeFolder.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-icon-big-256.png");
            this.imageList1.Images.SetKeyName(1, "jpg.png");
            this.imageList1.Images.SetKeyName(2, "docx.png");
            this.imageList1.Images.SetKeyName(3, "xlsx.png");
            this.imageList1.Images.SetKeyName(4, "pptx.png");
            this.imageList1.Images.SetKeyName(5, "txt.png");
            this.imageList1.Images.SetKeyName(6, "pdf.png");
            this.imageList1.Images.SetKeyName(7, "unknown.jpg");
            this.imageList1.Images.SetKeyName(8, "mp4.png");
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btShow.Location = new System.Drawing.Point(756, 59);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(90, 30);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "OK";
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPath.Location = new System.Drawing.Point(54, 59);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(642, 30);
            this.txtPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path: ";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClose.Location = new System.Drawing.Point(756, 526);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(90, 34);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // txtNumItems
            // 
            this.txtNumItems.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumItems.Location = new System.Drawing.Point(54, 540);
            this.txtNumItems.Name = "txtNumItems";
            this.txtNumItems.Size = new System.Drawing.Size(642, 20);
            this.txtNumItems.TabIndex = 5;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(756, 138);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(89, 24);
            this.cbAll.TabIndex = 6;
            this.cbAll.Text = "All Items";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbImage
            // 
            this.cbImage.AutoSize = true;
            this.cbImage.Location = new System.Drawing.Point(756, 198);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(73, 24);
            this.cbImage.TabIndex = 7;
            this.cbImage.Text = "Image";
            this.cbImage.UseVisualStyleBackColor = true;
            this.cbImage.CheckedChanged += new System.EventHandler(this.cbImage_CheckedChanged);
            // 
            // cbVideo
            // 
            this.cbVideo.AutoSize = true;
            this.cbVideo.Location = new System.Drawing.Point(756, 258);
            this.cbVideo.Name = "cbVideo";
            this.cbVideo.Size = new System.Drawing.Size(70, 24);
            this.cbVideo.TabIndex = 8;
            this.cbVideo.Text = "Video";
            this.cbVideo.UseVisualStyleBackColor = true;
            this.cbVideo.CheckedChanged += new System.EventHandler(this.cbVideo_CheckedChanged);
            // 
            // cbWord
            // 
            this.cbWord.AutoSize = true;
            this.cbWord.Location = new System.Drawing.Point(756, 318);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(67, 24);
            this.cbWord.TabIndex = 9;
            this.cbWord.Text = "Word";
            this.cbWord.UseVisualStyleBackColor = true;
            this.cbWord.CheckedChanged += new System.EventHandler(this.cbWord_CheckedChanged);
            // 
            // cbExcel
            // 
            this.cbExcel.AutoSize = true;
            this.cbExcel.Location = new System.Drawing.Point(756, 378);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Size = new System.Drawing.Size(65, 24);
            this.cbExcel.TabIndex = 10;
            this.cbExcel.Text = "Excel";
            this.cbExcel.UseVisualStyleBackColor = true;
            this.cbExcel.CheckedChanged += new System.EventHandler(this.cbExcel_CheckedChanged);
            // 
            // cbPDF
            // 
            this.cbPDF.AutoSize = true;
            this.cbPDF.Location = new System.Drawing.Point(756, 438);
            this.cbPDF.Name = "cbPDF";
            this.cbPDF.Size = new System.Drawing.Size(57, 24);
            this.cbPDF.TabIndex = 11;
            this.cbPDF.Text = "PDF";
            this.cbPDF.UseVisualStyleBackColor = true;
            this.cbPDF.CheckedChanged += new System.EventHandler(this.cbPDF_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 579);
            this.Controls.Add(this.cbPDF);
            this.Controls.Add(this.cbExcel);
            this.Controls.Add(this.cbWord);
            this.Controls.Add(this.cbVideo);
            this.Controls.Add(this.cbImage);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.txtNumItems);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.tvTreeFolder);
            this.Name = "Form1";
            this.Text = "Tree Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView tvTreeFolder;
        private Button btShow;
        private TextBox txtPath;
        private Label label1;
        private Button btClose;
        private TextBox txtNumItems;
        private ImageList imageList1;
        private CheckBox cbAll;
        private CheckBox cbImage;
        private CheckBox cbVideo;
        private CheckBox cbWord;
        private CheckBox cbExcel;
        private CheckBox cbPDF;
    }
}