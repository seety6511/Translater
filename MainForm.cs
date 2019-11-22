using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
        
namespace Translerater
{       
    public partial class MainForm : Form
    {   
        string filePath;
        string fileData;
        TranslationClient client;
        GoogleCredential credential;
        static string jsonPath = "testproject-1574121435570-7bc539479835.json";

        public MainForm()
        {
            InitializeComponent();
        }
        
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

        public Detection DetectLanguage(string t)
        {
            return client.DetectLanguage(text: t);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(filePath == string.Empty)
            {
                NotSelectFile();
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "텍스트 파일|*.txt|DAT 확장자|*.dat";
            dialog.ShowDialog();
            dialog.DefaultExt = "txt";
            string fileName = dialog.FileName;

            if (fileName != string.Empty)
            {
                var result = Translate(fileData);
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(result);
                sw.Close();
                fs.Close();
            }
            FilePath.Text = string.Empty;
            filePath = string.Empty;
            fileData = string.Empty;
            AfterTranslate.Text = string.Empty;
            BeforeTranslate.Text = string.Empty;
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "텍스트 파일|*.txt";
            openFile.Title = "번역하고싶은 텍스트 파일 선택";
            openFile.ShowDialog();

            filePath = openFile.FileName;
            FilePath.Text = filePath;

            if(filePath == string.Empty || Path.GetExtension(filePath)!=".txt")
            {
                ExtensionError();
                return;
            }
            var fd = File.ReadAllBytes(filePath);
            fileData = ByteToString(fd);
            BeforeTranslate.Text = fileData;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FilePath.Text = string.Empty;
            filePath = string.Empty;
            fileData = string.Empty;
            AfterTranslate.Text = string.Empty;
            BeforeTranslate.Text = string.Empty;
        }

        private byte[] StringToByte(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        private string ByteToString(byte[] strByte)
        {
            return Encoding.Default.GetString(strByte);
        }

        void LanguageException()
        {
            MessageBox.Show("영어나 한글이 아닙니다.", "언어 감지 실패");
        }

        void LengthOver()
        {
            MessageBox.Show("문자열이 너무 깁니다.", "최대 문자 수 초과");
        }

        void NotSelectFile()
        {
            MessageBox.Show("번역할 파일이 선택되지 않았습니다.", "번역할 파일 미 선택");
        }

        void ExtensionError()
        {
            MessageBox.Show("텍스트 파일이 아닙니다.", "확장자 에러");
        }

        string Translate(string before)
        {
            CredentialCreate();
            var text = before;
            if (TextLengthCheck(text))
            {
                var lang = DetectLanguage(text);
                string last = TranslateSelect(TranslateResult.Text);

                if (last == string.Empty)
                {
                    LanguageException();
                    return string.Empty;
                }

                TranslationResult response = null;
                if (last == "ko" || last == "en")
                    response = client.TranslateText(text, "ja");
                return client.TranslateText(response.TranslatedText, last).TranslatedText;
            }
            else
            {
                LengthOver();
            }
            return string.Empty;
        }

        string TranslateSelect(string lang)
        {
            switch (lang)
            {
                case "한국어":
                    return "ko";
                case "영어":
                    return "en";
                case "일어":
                    return "ja";
            }
            return string.Empty;
        }
    }
}       