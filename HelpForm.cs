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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Text =
                        "구글 API 활용한 번역 툴 (50만자 제한) 입니다." +
                        "\n영 -> 한, 한 -> 영 변환만 가능합니다.";
                    break;
                case 1:
                    textBox1.Text =
                        "번역하고픈 문장을 왼쪽 텍스트 박스에 입력하거나," +
                        "\n텍스트 파일을 선택하고, 번역 버튼을 누르면 " +
                        "\n오른쪽 텍스트 박스에 결과가 나옵니다.";
                    break;
                case 2:
                    textBox1.Text =
                        "저장버튼을 누르면 번역된 결과를 텍스트 파일로 저장할 수 있습니다.";
                    break;
                case 3:
                    textBox1.Text =
                        "지우기 버튼을 누르면 현재 입력된 모든 값들을 초기화 합니다.";
                    break;
                case 4:
                    textBox1.Text =
                        "텍스트 파일을 선택해 번역할 수 있습니다.";
                    break;
            }
        }
    }
}
