using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int histogramWidth;
        int histogramHeight;
        double[][] histogram;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int width, int height, double[][] histogram)
        {
            this.histogram = histogram;
            this.histogramHeight = height;
            this.histogramWidth = width;
            InitializeComponent();

            dataGridView.ColumnAdded += dataGridViewName_ColumnAdded;

            for (int j = 0; j < width; j++)
            {
                dataGridView.Columns.Add("sequenceLength" + (j + 1), "" + (j + 1));
            }
            for (int i = 0; i < height; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "Próg " + ((i + 1) * 256 / histogramHeight - 256 / histogramHeight / 2);
                dataGridView.Rows.Add(row);
            }
            for (int j = 0; j < width; j++)
                for (int i = 0; i < height; i++)
                    dataGridView.Rows[i].Cells[j].Value = histogram[i][j];
        }
        private void dataGridViewName_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 10;
        }
    }
}
