using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//NUGETから「GhostscriptSharp」をインストール
using GhostscriptSharp;

namespace WindowsFormsPdfConv
{
    public partial class FormExportPdfImageEx : Form
    {
        public FormExportPdfImageEx()
        {
            InitializeComponent();
        }

        private void buttonExportPdfImage_Click(object sender, EventArgs e)
        {
            //ディレクトリ内のファイル一覧を取得
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(textBoxDirPath.Text);
            System.IO.FileInfo[] files = di.GetFiles("*.pdf", System.IO.SearchOption.AllDirectories);
            foreach (System.IO.FileInfo f in files)
            {
                try
                {
                    string fileName = f.Name;
                    string dirPass = textBoxDirPath.Text;
                    string filePass = dirPass + fileName;

                    //画像を抽出
                    string imgFileName = getImageFromPdf(dirPass, fileName);
                }
                catch (Exception exp)
                {
                    outLogMsg("-", "Pdfファイル情報読み取り時にエラー発生 : " + exp.Message);
                }

            }
        }

        //Pdfから画像を取得する
        private string getImageFromPdf(string baseFilePass, string pdfFielName)
        {
            //拡張子無しでファイル名を取得する
            string imgFileName = Path.GetFileNameWithoutExtension(pdfFielName) + ".png";

            try
            {
                //Pdfから画像を取得
                GhostscriptSettings settings = new GhostscriptSettings();
                settings.Page.AllPages = true; //全ページ出力
                settings.Page.Start = 1;       //出力開始ページ
                settings.Page.End = 1;         //出力終了ページ
                settings.Size.Native = GhostscriptSharp.Settings.GhostscriptPageSizes.a0; //出力サイズ指定
                settings.Device = GhostscriptSharp.Settings.GhostscriptDevices.png256; //出力ファイルフォーマット指定(pngで指定)
                settings.Resolution = new Size(600, 600); //出力Dpi

                string inputPath = baseFilePass + "\\" + pdfFielName;
                string outputPath = baseFilePass + "\\" + imgFileName;
                GhostscriptWrapper.GenerateOutput(inputPath, outputPath, settings); // Create the initial thumbnail

                //ファイルが生成されない場合はパスを返さない
                if (!System.IO.File.Exists(outputPath))
                {
                    imgFileName = "";
                    outLogMsg(pdfFielName, "Pdf埋め込み画像なし");
                } else
                {
                    outLogMsg(pdfFielName, "Pdf画像変換完了");
                }
            }
            catch (Exception exp)
            {
                imgFileName = "";
                outLogMsg(pdfFielName, "Pdf画像取得実施エラー : " + exp.Message);
            }

            return imgFileName;
        }

        //ログ情報を出力
        private void outLogMsg(string fileName,  string message)
        {
            //画面ログに出力
            string msg = fileName + " : " + message;

            listBoxExpPdfImg.Items.Add(msg);
            listBoxExpPdfImg.Update();
        }
    }
}
