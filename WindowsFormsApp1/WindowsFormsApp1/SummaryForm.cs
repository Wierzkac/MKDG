using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SummaryForm : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;

        int histogramWidth;
        int histogramHeight;
        double[][] histogram;

        double shortPrimitiveEmphasis = 0;
        double longPrimitiveEmphasis = 0;
        double greyLevelUniformity = 0;
        double primitiveLengthUniformity = 0;
        double primitivePercentage = 0;
        string directionOfAnalisys;

        public SummaryForm()
        {
            InitializeComponent();
        }
        public SummaryForm(Bitmap original, Bitmap processed, int width, int height, double[][] table, double shortPrimitive, double longPrimitive, double greyUniformity, double primitiveUniformity, double primitivepercentage, string direction)
        {
            originalImage = original;
            processedImage = processed;

            histogramWidth = width;
            histogramHeight = height;
            histogram = table;

            shortPrimitiveEmphasis = shortPrimitive;
            longPrimitiveEmphasis = longPrimitive;
            greyLevelUniformity = greyUniformity;
            primitiveLengthUniformity = primitiveUniformity;
            primitivePercentage = primitivepercentage;

            directionOfAnalisys = direction;

            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            DataGridViewColumn[] cols = new DataGridViewColumn[histogramWidth];
            for (int j = 0; j < histogramWidth; j++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Name = "sequenceLength" + (j + 1);
                col.HeaderText = "" + (j + 1);
                col.FillWeight = 10;
                cols[j] = col;
            }
            dataGridView.Columns.AddRange(cols);
            for (int i = 0; i < histogramHeight; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "Próg " + ((i + 1) * 256 / histogramHeight - 256 / histogramHeight/2);
                dataGridView.Rows.Add(row);
            }
            for (int j = 0; j < histogramWidth; j++)
                for (int i = 0; i < histogramHeight; i++)
                    dataGridView.Rows[i].Cells[j].Value = histogram[i][j];
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            originalPictureBox.Image = originalImage;
            processedPictureBox.Image = processedImage;

            WriteParametersToLabels();
        }
        private void WriteParametersToLabels()
        {
            shortPrimitiveEmphasisLabel.Text = ((decimal)shortPrimitiveEmphasis).ToString("0." + new string('#', 339));
            longPrimitiveEmphasisLabel.Text = longPrimitiveEmphasis.ToString();
            greyLevelUniformityLabel.Text = greyLevelUniformity.ToString();
            primitiveLengthUniformityLabel.Text = primitiveLengthUniformity.ToString();
            primitivePercentageLabel.Text = primitivePercentage.ToString() + "%";
            tresholdsNumberLabel.Text = histogramHeight.ToString();
            directionLabel.Text = directionOfAnalisys;
        }
    }
}
