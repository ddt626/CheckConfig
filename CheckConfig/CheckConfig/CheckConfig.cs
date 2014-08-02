using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CheckConfig
{
	public partial class CheckConfig : Form
	{
        private string blockListPath = System.Windows.Forms.Application.StartupPath + @"\BlockList\";

		public CheckConfig()
		{
			InitializeComponent();
            initCbConfig();
		}

		private void pickFloder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog path = new FolderBrowserDialog();
			path.ShowDialog();
			pathTxt.Text = path.SelectedPath;
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
            List<string> inVaildateList = new List<string>();
			List<string> blockList = this.getBlockList(cbConfig.Text);

            if (!isVaildate(blockList,out inVaildateList))
            {
                foreach (var item in inVaildateList)
                {
                    MessagelistBox.Items.Add(item);

                }
            }
		}

		private List<string> getBlockList(string configName)
		{
			string text = File.ReadAllText(blockListPath + string.Format(@"\{0}.txt", configName));
			text = text.Replace("\r\n", string.Empty);
            List<string> blockList = text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            return blockList;
		}

        private void initCbConfig()
        {
            var files = from file in Directory.EnumerateFiles(blockListPath, "*.txt", SearchOption.TopDirectoryOnly)
                        select new
                        {
                            File = file
                        };
            var filesToArray = files.ToArray();
            for (int i = 0; i < files.Count(); i++)
            {
                var fileName = Path.GetFileNameWithoutExtension(filesToArray[i].File);
                if (i == 0)
                {
                    cbConfig.Text = fileName;
                }

                cbConfig.Items.Add(fileName);

            }
        }

        private bool isVaildate(List<string> blockList, out List<string> inVaildateList)
        {
            bool result = true;
            inVaildateList = new List<string>();

            if (!string.IsNullOrEmpty(pathTxt.Text))
            {
                var files = from file in Directory.EnumerateFiles(pathTxt.Text, "*.config", SearchOption.AllDirectories)
                            select new
                            {
                                File = file
                            };

                foreach (var f in files)
                {
                    foreach (var item in blockList)
                    {
                        if (f.File.Replace("\\", "/").IndexOf(item) >= 0)
                        {
                            blockList.Remove(item);
                            inVaildateList.Add(item);
                            result = false;
                            break;
                        }
                    }
                }
            }

            return result;
        }
	}
}
