namespace WindowsFormsApp1
{
    partial class MainApplication
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OpenImageButton = new System.Windows.Forms.Button();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.processingPictureBox = new System.Windows.Forms.PictureBox();
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.treshholdUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.shortPrimitiveEmphasisLabel = new System.Windows.Forms.Label();
            this.longPrimitiveEmphasisLabel = new System.Windows.Forms.Label();
            this.greyLevelUniformityLabel = new System.Windows.Forms.Label();
            this.primitiveLengthUniformityLabel = new System.Windows.Forms.Label();
            this.primitivePercentageLabel = new System.Windows.Forms.Label();
            this.summaryButton = new System.Windows.Forms.Button();
            this.histogramButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treshholdUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenImageButton.Location = new System.Drawing.Point(3, 616);
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(75, 23);
            this.OpenImageButton.TabIndex = 0;
            this.OpenImageButton.Text = "Otwórz...";
            this.OpenImageButton.UseVisualStyleBackColor = true;
            this.OpenImageButton.Click += new System.EventHandler(this.OpenImageButton_Click);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(565, 643);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 1;
            this.originalPictureBox.TabStop = false;
            // 
            // processingPictureBox
            // 
            this.processingPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processingPictureBox.Location = new System.Drawing.Point(775, 3);
            this.processingPictureBox.Name = "processingPictureBox";
            this.processingPictureBox.Size = new System.Drawing.Size(566, 643);
            this.processingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processingPictureBox.TabIndex = 2;
            this.processingPictureBox.TabStop = false;
            // 
            // directionComboBox
            // 
            this.directionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.directionComboBox.DisplayMember = "0";
            this.directionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Items.AddRange(new object[] {
            "pozioma",
            "pionowa",
            "w obu kierunkach"});
            this.directionComboBox.Location = new System.Drawing.Point(72, 18);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(107, 21);
            this.directionComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Analiza";
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.processButton.Enabled = false;
            this.processButton.Location = new System.Drawing.Point(69, 114);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 13;
            this.processButton.Text = "----->";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Liczba progów:";
            // 
            // treshholdUpDown
            // 
            this.treshholdUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.treshholdUpDown.Location = new System.Drawing.Point(107, 67);
            this.treshholdUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.treshholdUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.treshholdUpDown.Name = "treshholdUpDown";
            this.treshholdUpDown.Size = new System.Drawing.Size(72, 20);
            this.treshholdUpDown.TabIndex = 15;
            this.treshholdUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Short primitive emphasis:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Long primitive emphasis:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Gray-level uniformity:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Primitive length uniformity:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Primitive percentage:";
            // 
            // shortPrimitiveEmphasisLabel
            // 
            this.shortPrimitiveEmphasisLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shortPrimitiveEmphasisLabel.AutoSize = true;
            this.shortPrimitiveEmphasisLabel.Location = new System.Drawing.Point(25, 320);
            this.shortPrimitiveEmphasisLabel.Name = "shortPrimitiveEmphasisLabel";
            this.shortPrimitiveEmphasisLabel.Size = new System.Drawing.Size(13, 13);
            this.shortPrimitiveEmphasisLabel.TabIndex = 21;
            this.shortPrimitiveEmphasisLabel.Text = "0";
            // 
            // longPrimitiveEmphasisLabel
            // 
            this.longPrimitiveEmphasisLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.longPrimitiveEmphasisLabel.AutoSize = true;
            this.longPrimitiveEmphasisLabel.Location = new System.Drawing.Point(25, 370);
            this.longPrimitiveEmphasisLabel.Name = "longPrimitiveEmphasisLabel";
            this.longPrimitiveEmphasisLabel.Size = new System.Drawing.Size(13, 13);
            this.longPrimitiveEmphasisLabel.TabIndex = 22;
            this.longPrimitiveEmphasisLabel.Text = "0";
            // 
            // greyLevelUniformityLabel
            // 
            this.greyLevelUniformityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greyLevelUniformityLabel.AutoSize = true;
            this.greyLevelUniformityLabel.Location = new System.Drawing.Point(25, 420);
            this.greyLevelUniformityLabel.Name = "greyLevelUniformityLabel";
            this.greyLevelUniformityLabel.Size = new System.Drawing.Size(13, 13);
            this.greyLevelUniformityLabel.TabIndex = 23;
            this.greyLevelUniformityLabel.Text = "0";
            // 
            // primitiveLengthUniformityLabel
            // 
            this.primitiveLengthUniformityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.primitiveLengthUniformityLabel.AutoSize = true;
            this.primitiveLengthUniformityLabel.Location = new System.Drawing.Point(25, 470);
            this.primitiveLengthUniformityLabel.Name = "primitiveLengthUniformityLabel";
            this.primitiveLengthUniformityLabel.Size = new System.Drawing.Size(13, 13);
            this.primitiveLengthUniformityLabel.TabIndex = 24;
            this.primitiveLengthUniformityLabel.Text = "0";
            // 
            // primitivePercentageLabel
            // 
            this.primitivePercentageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.primitivePercentageLabel.AutoSize = true;
            this.primitivePercentageLabel.Location = new System.Drawing.Point(25, 520);
            this.primitivePercentageLabel.Name = "primitivePercentageLabel";
            this.primitivePercentageLabel.Size = new System.Drawing.Size(13, 13);
            this.primitivePercentageLabel.TabIndex = 25;
            this.primitivePercentageLabel.Text = "0";
            // 
            // summaryButton
            // 
            this.summaryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(25, 224);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(154, 30);
            this.summaryButton.TabIndex = 26;
            this.summaryButton.Text = "Otwórz podsumowanie";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // histogramButton
            // 
            this.histogramButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.histogramButton.Enabled = false;
            this.histogramButton.Location = new System.Drawing.Point(25, 169);
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(154, 30);
            this.histogramButton.TabIndex = 27;
            this.histogramButton.Text = "Otwórz histogram";
            this.histogramButton.UseVisualStyleBackColor = true;
            this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.directionComboBox);
            this.panel1.Controls.Add(this.histogramButton);
            this.panel1.Controls.Add(this.processButton);
            this.panel1.Controls.Add(this.summaryButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.primitivePercentageLabel);
            this.panel1.Controls.Add(this.treshholdUpDown);
            this.panel1.Controls.Add(this.primitiveLengthUniformityLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.greyLevelUniformityLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.longPrimitiveEmphasisLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.shortPrimitiveEmphasisLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(574, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 643);
            this.panel1.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.processingPictureBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1344, 649);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OpenImageButton);
            this.panel2.Controls.Add(this.originalPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 643);
            this.panel2.TabIndex = 30;
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 649);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1360, 688);
            this.Name = "MainApplication";
            this.Text = "Main application";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treshholdUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button OpenImageButton;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox processingPictureBox;
        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown treshholdUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label shortPrimitiveEmphasisLabel;
        private System.Windows.Forms.Label longPrimitiveEmphasisLabel;
        private System.Windows.Forms.Label greyLevelUniformityLabel;
        private System.Windows.Forms.Label primitiveLengthUniformityLabel;
        private System.Windows.Forms.Label primitivePercentageLabel;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button histogramButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}

