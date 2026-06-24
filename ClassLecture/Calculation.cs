using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLecture
{
    /// <summary>
    /// 計算クラス
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// 足し算を行う
        /// </summary>
        /// <param name="leftTxt">左辺</param>
        /// <param name="rightTxt">右辺</param>
        /// <returns>計算結果</returns>
        public string AddNumbers(string leftTxt, string rightTxt)
        {
            return (int.Parse(leftTxt) + int.Parse(rightTxt)).ToString();
        }
    }
}
