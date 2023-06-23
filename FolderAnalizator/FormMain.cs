using System;
using System.Windows.Forms;
using System.IO;
using FolderScanner;
using FolderScanner.Models;
using System.Threading;

namespace FolderAnalizator
{
    public partial class FormMain : Form
    {
        private FolderFactory _factory { get; set; }
        private Folder _folder { get; set; }
        private FolderStatistic _statistic;
        private Thread _thread { get; set; }

        public FormMain()
        {
            InitializeComponent();

            _factory = new FolderFactory();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            if(_thread != null)
            {
                MessageBox.Show("Дождитесь завершения сканирования",
                                   "Внимание",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show("Ожидайте завершения сканирования",
                       "Внимание",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

            StatusScan.Text = "Сканирование началось....";

            _thread = new Thread(Scan);
            _thread.IsBackground = true;
            _thread.Start();
        }

        private void Scan()
        {
            try
            {
                _folder = _factory.GetFolder(Directory.GetCurrentDirectory());
                _statistic = _factory.GetFolderStatistic();

                RenderUI();

                _thread = null;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderUI()
        {
            this.Invoke(new MethodInvoker(() =>
            {
                FolderRender.Render(_folder, TreeFolder);
                TreeFolder.ExpandAll();
                StatusScan.Text = "Сканирование завершено";
                ShowStatistic();
            }));
        }

        private void ShowStatistic()
        {
            StatisticRender.RenderSize(LstSize, _statistic);
            StatisticRender.RenderType(LstType, _statistic.CountType);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
        }
       
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TreeFolder.Update();
            TreeFolder.Nodes.Clear();
            TreeFolder.EndUpdate();
        }

    }
}
