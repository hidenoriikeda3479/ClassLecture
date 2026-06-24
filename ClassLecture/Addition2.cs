namespace ClassLecture
{
    public partial class Addition2 : Form
    {
        public Addition2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 足し算２
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show(AddNumbers(textBox1.Text, textBox2.Text));
        }

        /// <summary>
        /// 足し算を行う
        /// </summary>
        /// <param name="leftTxt">左辺</param>
        /// <param name="rightTxt">右辺</param>
        /// <returns>計算結果</returns>
        private string AddNumbers(string leftTxt,string rightTxt)
        {
            return (int.Parse(leftTxt) + int.Parse(rightTxt)).ToString();
        }
    }
}
