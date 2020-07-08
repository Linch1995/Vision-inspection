using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vision_inspection
{
    /// <summary>
    /// 窗体大小改变后里面控件随着改变
    /// </summary>
    class Windows_change
        {
        /// <summary>
        /// 改变窗体大小后改变里面控件大小
        /// </summary>
        /// <param name="width">当前主窗口的宽度</param>
        /// <param name="height">当前主窗口的高度</param>
        public void change(int width, int height)
        {

            //改变四个ha_windows窗口容器的大小
            Form1.setForm1.ha_windos_box.Width = width - Form1.setForm1.camera_set.Width;
            Form1.setForm1.ha_windos_box.Height = height - 30;
            //改变右下角信息列表的高度
            Form1.setForm1.info_list.Height = height - Form1.setForm1.camera_set.Height - 45;

            //改变四个图像窗口的宽度
            Form1.setForm1.ha_windos_0.Width = Form1.setForm1.ha_windos_box.Width / 2 - 3;
            Form1.setForm1.ha_windos_1.Width = Form1.setForm1.ha_windos_box.Width / 2 - 3;
            Form1.setForm1.ha_windos_2.Width = Form1.setForm1.ha_windos_box.Width / 2 - 3;
            Form1.setForm1.ha_windos_3.Width = Form1.setForm1.ha_windos_box.Width / 2 - 3;

            //改变四个图像窗口的高度
            Form1.setForm1.ha_windos_0.Height = Form1.setForm1.ha_windos_box.Height / 2 - 1;
            Form1.setForm1.ha_windos_1.Height = Form1.setForm1.ha_windos_box.Height / 2 - 1;
            Form1.setForm1.ha_windos_2.Height = Form1.setForm1.ha_windos_box.Height / 2 - 1;
            Form1.setForm1.ha_windos_3.Height = Form1.setForm1.ha_windos_box.Height / 2 - 1;


            //重置图像显示区域的大小
            HOperatorSet.SetWindowExtents(HDevWindowStack.GetActive(), 0, 0, Form1.setForm1.ha_windos_box.Width / 2 - 3, Form1.setForm1.ha_windos_box.Height / 2 - 1);

        }
        /// <summary>
        /// 单击后放大所选窗口
        /// </summary>
        /// <param name="ha_name"></param>
        /// <param name="isfangda"></param>
        public static bool fangda(string ha_name, bool isfangda)
        {
            int ha_box_w = Form1.setForm1.ha_windos_box.Width;
            int ha_box_h = Form1.setForm1.ha_windos_box.Height;
            //通过输入的参数判断点击的是第几个串口
            switch (ha_name)
            {
                //改变窗口大小使其在容器内最大化
                case "ha_windos_0":
                    if (isfangda)
                    {
                        Form1.setForm1.ha_windos_0.Width = ha_box_w / 2 - 3;
                        Form1.setForm1.ha_windos_0.Height = ha_box_h / 2 - 1;
                        //重置图像显示区域的大小
                        HOperatorSet.SetWindowExtents(HDevWindowStack.GetActive(), 0, 0, Form1.setForm1.ha_windos_box.Width / 2 - 3, Form1.setForm1.ha_windos_box.Height / 2 - 1);
                        //显示其他显示窗口
                        Form1.setForm1.ha_windos_1.Visible = true;
                        Form1.setForm1.ha_windos_2.Visible = true;
                        Form1.setForm1.ha_windos_3.Visible = true;
                        Form1.setForm1.ha_wind0_isfangda = true;
                        return isfangda = false;
                    }
                    else
                    {
                        Form1.setForm1.ha_windos_0.Width = ha_box_w;
                        Form1.setForm1.ha_windos_0.Height = ha_box_h;
                        //重置图像显示区域的大小
                        HOperatorSet.SetWindowExtents(HDevWindowStack.GetActive(), 0, 0, Form1.setForm1.ha_windos_box.Width, Form1.setForm1.ha_windos_box.Height);
                        //隐藏其他显示窗口
                        Form1.setForm1.ha_windos_1.Visible = false;
                        Form1.setForm1.ha_windos_2.Visible = false;
                        Form1.setForm1.ha_windos_3.Visible = false;
                        Form1.setForm1.ha_wind0_isfangda = false;
                        return isfangda = true;
                    }
                    break;
                case "ha_windos_1":
                    if (isfangda)
                    {
                        //设置窗口左上角坐标和容器左上角相同，使其放大后仍然再容器内，下同
                        Form1.setForm1.ha_windos_1.Location = new Point(Form1.setForm1.ha_windos_1.Location.X, ha_box_w / 2 + 2);
                        Form1.setForm1.ha_windos_1.Location = new Point(Form1.setForm1.ha_windos_1.Location.Y, 3);
                        Form1.setForm1.ha_windos_1.Width = ha_box_w / 2 - 3;
                        Form1.setForm1.ha_windos_1.Height = ha_box_h / 2 - 1;
                        //显示其他显示窗口
                        Form1.setForm1.ha_windos_0.Visible = true;
                        Form1.setForm1.ha_windos_2.Visible = true;
                        Form1.setForm1.ha_windos_3.Visible = true;
                        return isfangda = false;
                    }
                    else
                    {
                        Form1.setForm1.ha_windos_1.Location = new Point(Form1.setForm1.ha_windos_1.Location.X, 0);
                        Form1.setForm1.ha_windos_1.Location = new Point(Form1.setForm1.ha_windos_1.Location.Y, 3);
                        Form1.setForm1.ha_windos_1.Width = ha_box_w;
                        Form1.setForm1.ha_windos_1.Height = ha_box_h;
                        //隐藏其他显示窗口
                        Form1.setForm1.ha_windos_0.Visible = false;
                        Form1.setForm1.ha_windos_2.Visible = false;
                        Form1.setForm1.ha_windos_3.Visible = false;
                        return isfangda = true;
                    }
                    break;
                case "ha_windos_2":
                    if (isfangda)
                    {
                        Form1.setForm1.ha_windos_2.Location = new Point(Form1.setForm1.ha_windos_2.Location.X, 0);
                        Form1.setForm1.ha_windos_2.Location = new Point(Form1.setForm1.ha_windos_2.Location.Y, ha_box_h / 2 + 6);
                        Form1.setForm1.ha_windos_2.Width = ha_box_w / 2 - 3;
                        Form1.setForm1.ha_windos_2.Height = ha_box_h / 2 - 1;
                        //显示其他显示窗口
                        Form1.setForm1.ha_windos_0.Visible = true;
                        Form1.setForm1.ha_windos_1.Visible = true;
                        Form1.setForm1.ha_windos_3.Visible = true;
                        return isfangda = false;
                    }
                    else
                    {
                        Form1.setForm1.ha_windos_2.Location = new Point(Form1.setForm1.ha_windos_2.Location.X, 0);
                        Form1.setForm1.ha_windos_2.Location = new Point(Form1.setForm1.ha_windos_2.Location.Y, 3);
                        Form1.setForm1.ha_windos_2.Width = ha_box_w;
                        Form1.setForm1.ha_windos_2.Height = ha_box_h;
                        //隐藏其他显示窗口
                        Form1.setForm1.ha_windos_0.Visible = false;
                        Form1.setForm1.ha_windos_1.Visible = false;
                        Form1.setForm1.ha_windos_3.Visible = false;
                        return isfangda = true;
                    }
                    break;
                case "ha_windos_3":
                    if (isfangda)
                    {
                        Form1.setForm1.ha_windos_3.Location = new Point(Form1.setForm1.ha_windos_3.Location.X, ha_box_w /2 + 2);
                        Form1.setForm1.ha_windos_3.Location = new Point(Form1.setForm1.ha_windos_3.Location.Y, ha_box_h / 2 + 6);
                        Form1.setForm1.ha_windos_3.Width = ha_box_w / 2 - 3;
                        Form1.setForm1.ha_windos_3.Height = ha_box_h / 2 - 1;
                        //显示其他显示窗口
                        Form1.setForm1.ha_windos_0.Visible = true;
                        Form1.setForm1.ha_windos_1.Visible = true;
                        Form1.setForm1.ha_windos_2.Visible = true;
                        return isfangda = false;
                    }
                    else
                    {
                        Form1.setForm1.ha_windos_3.Location = new Point(Form1.setForm1.ha_windos_3.Location.X, 0);
                        Form1.setForm1.ha_windos_3.Location = new Point(Form1.setForm1.ha_windos_3.Location.Y, 3);
                        Form1.setForm1.ha_windos_3.Width = ha_box_w;
                        Form1.setForm1.ha_windos_3.Height = ha_box_h;
                        //隐藏其他显示窗口
                        Form1.setForm1.ha_windos_0.Visible = false;
                        Form1.setForm1.ha_windos_1.Visible = false;
                        Form1.setForm1.ha_windos_2.Visible = false;
                        return isfangda = true;
                    }
                    break;
                //输入参数上面没有定义时抛出错误
                default:
                    MessageBox.Show("访问错误！请重试！","Error");
                    return isfangda = false;
                    break;
            }

        }
    }
}
