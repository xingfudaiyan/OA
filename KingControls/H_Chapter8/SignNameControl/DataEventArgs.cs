using System;
using System.Collections.Generic;
using System.Text;

namespace KingControls
{
    /// <summary>
    /// Author: 【夜战鹰】【专注于DotNet技术】【ChengKing(ZhengJian)】
    /// 获得本书的更多章节:【http://blog.csdn.net/ChengKing/archive/2008/08/18/2792440.aspx】
    /// 声明: 【本链接为进阶Asp.net技术的一些文章】【转载时请保留本链接源】
    /// </summary>
    public delegate void DataEventHandler(object sender, DataEventArgs e);
    public class DataEventArgs : EventArgs
    {
        public DataEventArgs()
        {
        }

        private string strDataValue;
        public string DataValue
        {
            get { return strDataValue; }
            set { strDataValue = value; }
        }
    }
}
