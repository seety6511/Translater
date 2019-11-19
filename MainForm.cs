using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translerater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static string jsonPath = "C:\\Users\\ATENTS\\source\\repos\\Translerater\\Translerater\\key\\TestProject-7a58ef1e004b.json";
        static string projectId = "testproject-1574121435570";

        GoogleCredential credential;
        TranslationClient client;
        void CredentialCreate()
        {
            if (credential == null)
                credential = GoogleCredential.FromFile(jsonPath);
            if (client == null)
                client = TranslationClient.Create(credential);
        }

        //50만자 제한
        bool TextLengthCheck(string text)
        {
            return text.Length <= 500000;
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            AfterTranslate.Text = Translate(BeforeTranslate.Text);
        }

        string Translate(string before)
        {
            CredentialCreate();
            var text = before;
            if (TextLengthCheck(text))
            {
                var leng = DetectLanguage(text);

                if (!(leng.Language == "ko" || leng.Language == "en"))
                {
                    LanguageException();
                    return string.Empty;
                }

                string last = string.Empty;
                switch (leng.Language)
                {
                    case "ko":
                        last = "en";
                        break;
                    case "en":
                        last = "ko";
                        break;
                }
                var response = client.TranslateText(text, "ja");
                response = client.TranslateText(response.TranslatedText, last);
                return response.TranslatedText;
            }
            else
            {
                LengthOver();
            }
            return string.Empty;
        }

        void LanguageException()
        {
            MessageBox.Show("영어나 한글이 아닙니다.", "언어 감지 실패");
        }

        void LengthOver()
        {
            MessageBox.Show("문자열이 너무 깁니다.", "최대 문자 수 초과");
        }

        public Detection DetectLanguage(string t)
        {
            var detection = client.DetectLanguage(text: t);
            Console.WriteLine(
                $"{detection.Language}\tConfidence: {detection.Confidence}");
            return detection;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(filePath == string.Empty)
            {
                NotSelectFile();
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string select_path = dialog.SelectedPath;

            //if (saveFileDialog1.FileName != "")
            //{
            //    System.IO.FileStream fs =
            //        (System.IO.FileStream)saveFileDialog1.
            //    var text = System.IO.File.ReadAllText(filePath);
            //    var result = Translate(text);
            //    var arr = StringToByte(result);
            //    fs.Write(arr,0,arr.Length-1);
            //    fs.Close();
            //}
            FilePath.Text = string.Empty;
            filePath = string.Empty;
        }
        private string ByteToString(byte[] strByte)
        {
            return Encoding.Default.GetString(strByte);
        }

        private byte[] StringToByte(string str) {
            return Encoding.UTF8.GetBytes(str);
        }

        void NotSelectFile()
        {
            MessageBox.Show("번역할 파일이 선택되지 않았습니다.", "번역할 파일 미 선택");
        }

        string filePath;
        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "text|*.txt";
            openFile.Title = "번역하고싶은 텍스트 파일 선택";
            openFile.ShowDialog();

            filePath = openFile.FileName;
            FilePath.Text = filePath;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(800, 450);
            form.ResumeLayout(false);
            form.PerformLayout();
            form.Show();
        }
    }
}
