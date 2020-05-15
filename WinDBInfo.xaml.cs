using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDataGRidText
{
    /// <summary>
    /// WinDBInfo.xaml 的交互逻辑
    /// </summary>
    public partial class WinDBInfo : Window
    {
        public WinDBInfo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //获取数据
            //链接数据库
            //创建一个连接字符串
            string strCon = ConfigurationManager.ConnectionStrings["mysqlconn"].ConnectionString;
            //创建一个连接对象
            MySqlConnection cn = new MySqlConnection(strCon);
            //提供一个命令字符串
            string strSql = "select*from UserInfo";
            //创建一个命令对象
            MySqlCommand cmd = new MySqlCommand(strSql, cn);
            //创建一个适配器
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //将数据通过数据适配器，填充到数据表中
            DataTable dt = new DataTable();
            da.Fill(dt);
            Debug.WriteLine("数据的行数：" + dt.Rows.Count);

            //将datatable里面的数据，全部转化为list<UserInfo>
        }
    }
}
