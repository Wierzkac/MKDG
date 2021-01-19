namespace WindowsFormsApp1
{
    partial class SummaryForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.directionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tresholdsNumberLabel = new System.Windows.Forms.Label();
            this.primitivePercentageLabel = new System.Windows.Forms.Label();
            this.primitiveLengthUniformityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.greyLevelUniformityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.longPrimitiveEmphasisLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.shortPrimitiveEmphasisLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView, 3);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.Size = new System.Drawing.Size(1178, 136);
            this.dataGridView.TabIndex = 0;
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedPictureBox.Location = new System.Drawing.Point(703, 145);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(478, 463);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processedPictureBox.TabIndex = 2;
            this.processedPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.00338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.11824F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.79392F));
            this.tableLayoutPanel1.Controls.Add(this.originalPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processedPictureBox, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.32215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.67785F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 611);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(3, 145);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(515, 463);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 38;
            this.originalPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.directionLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tresholdsNumberLabel);
            this.panel1.Controls.Add(this.primitivePercentageLabel);
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
            this.panel1.Location = new System.Drawing.Point(524, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 463);
            this.panel1.TabIndex = 37;
            // 
            // directionLabel
            // 
            this.directionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directionLabel.Location = new System.Drawing.Point(60, 33);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(15, 16);
            this.directionLabel.TabIndex = 39;
            this.directionLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Analiza ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ilość progów:";
            // 
            // tresholdsNumberLabel
            // 
            this.tresholdsNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tresholdsNumberLabel.AutoSize = true;
            this.tresholdsNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tresholdsNumberLabel.Location = new System.Drawing.Point(16, 103);
            this.tresholdsNumberLabel.Name = "tresholdsNumberLabel";
            this.tresholdsNumberLabel.Size = new System.Drawing.Size(15, 16);
            this.tresholdsNumberLabel.TabIndex = 37;
            this.tresholdsNumberLabel.Text = "0";
            // 
            // primitivePercentageLabel
            // 
            this.primitivePercentageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.primitivePercentageLabel.AutoSize = true;
            this.primitivePercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.primitivePercentageLabel.Location = new System.Drawing.Point(16, 353);
            this.primitivePercentageLabel.Name = "primitivePercentageLabel";
            this.primitivePercentageLabel.Size = new System.Drawing.Size(15, 16);
            this.primitivePercentageLabel.TabIndex = 35;
            this.primitivePercentageLabel.Text = "0";
            // 
            // primitiveLengthUniformityLabel
            // 
            this.primitiveLengthUniformityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.primitiveLengthUniformityLabel.AutoSize = true;
            this.primitiveLengthUniformityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.primitiveLengthUniformityLabel.Location = new System.Drawing.Point(16, 303);
            this.primitiveLengthUniformityLabel.Name = "primitiveLengthUniformityLabel";
            this.primitiveLengthUniformityLabel.Size = new System.Drawing.Size(15, 16);
            this.primitiveLengthUniformityLabel.TabIndex = 34;
            this.primitiveLengthUniformityLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Short primitive emphasis:";
            // 
            // greyLevelUniformityLabel
            // 
            this.greyLevelUniformityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greyLevelUniformityLabel.AutoSize = true;
            this.greyLevelUniformityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greyLevelUniformityLabel.Location = new System.Drawing.Point(16, 253);
            this.greyLevelUniformityLabel.Name = "greyLevelUniformityLabel";
            this.greyLevelUniformityLabel.Size = new System.Drawing.Size(15, 16);
            this.greyLevelUniformityLabel.TabIndex = 33;
            this.greyLevelUniformityLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(13, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Long primitive emphasis:";
            // 
            // longPrimitiveEmphasisLabel
            // 
            this.longPrimitiveEmphasisLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.longPrimitiveEmphasisLabel.AutoSize = true;
            this.longPrimitiveEmphasisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.longPrimitiveEmphasisLabel.Location = new System.Drawing.Point(16, 203);
            this.longPrimitiveEmphasisLabel.Name = "longPrimitiveEmphasisLabel";
            this.longPrimitiveEmphasisLabel.Size = new System.Drawing.Size(15, 16);
            this.longPrimitiveEmphasisLabel.TabIndex = 32;
            this.longPrimitiveEmphasisLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(13, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Gray-level uniformity:";
            // 
            // shortPrimitiveEmphasisLabel
            // 
            this.shortPrimitiveEmphasisLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shortPrimitiveEmphasisLabel.AutoSize = true;
            this.shortPrimitiveEmphasisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shortPrimitiveEmphasisLabel.Location = new System.Drawing.Point(16, 153);
            this.shortPrimitiveEmphasisLabel.Name = "shortPrimitiveEmphasisLabel";
            this.shortPrimitiveEmphasisLabel.Size = new System.Drawing.Size(15, 16);
            this.shortPrimitiveEmphasisLabel.TabIndex = 31;
            this.shortPrimitiveEmphasisLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(13, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Primitive length uniformity:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(13, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Primitive percentage:";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "SummaryForm";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Label primitivePercentageLabel;
        private System.Windows.Forms.Label primitiveLengthUniformityLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label greyLevelUniformityLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label longPrimitiveEmphasisLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label shortPrimitiveEmphasisLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tresholdsNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label directionLabel;
    }
}