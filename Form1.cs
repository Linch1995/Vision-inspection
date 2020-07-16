using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Management;


/*--------------------------------待完善BUG----------------------------------
 1,未连接相机最大化窗口或者改变窗口大小时调用Windows_change.change重置显示区域大小时会出错
 2.
 
 */

namespace Vision_inspection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //创建一个全局常量
        public static Form1 setForm1;
        //记录窗口状态，用于判断当前是否最大化
        bool windos_max = false;
        // Local iconic variables 
        public static HObject ho_Image_0 = null, ho_Image_1 = null;
        // Local control variables 
        public static HTuple hv_AcqHandle_0 = null, hv_AcqHandle_1 = null, hv_AcqHandle_2 = null, hv_AcqHandle_3 = null;
        HTuple hv_WindowHandle_0 = null, hv_WindowHandle_1 = null;
        HTuple hv_Width_0 = new HTuple(), hv_Height_0 = new HTuple();
        HTuple hv_Width_1 = new HTuple(), hv_Height_1 = new HTuple();
        //用于记录四个相机句柄和显示窗口的句柄,方便定时器调用
        public HTuple Camera_Handle_0 = null, ha_windowsHandle_0 = null,
                      Camera_Handle_1 = null, ha_windowsHandle_1 = null,
                      Camera_Handle_2 = null, ha_windowsHandle_2 = null,
                      Camera_Handle_3 = null, ha_windowsHandle_3 = null;
        //定义一个枚举，表示拖动方向
        public enum MouseDirection
        {
            Herizontal,//水平方向拖动，只改变窗体的宽度        
            Vertical,//垂直方向拖动，只改变窗体的高度 
            Declining,//倾斜方向，同时改变窗体的宽度和高度        
            None//不做标志，即不拖动窗体改变大小 
        }
        bool isMouseDown = false; //表示鼠标当前是否处于按下状态，初始值为否 
        public bool ha_isfangda = false;    //用于记录当前窗口是否处于放大状态，初始值为否
        //用于记录四个显示窗口是否处于放大状态，初始值为否
        public bool ha_wind0_isfangda = false, ha_wind1_isfangda = false, ha_wind2_isfangda = false, ha_wind3_isfangda = false;
        MouseDirection direction = MouseDirection.None;//表示拖动的方向，起始为None，表示不拖动

        //-------------------------------------窗体加载------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //将当前窗体实例复制给全局常量Form 这样其他类才能更改控件属性
            setForm1 = this;

            Get_imgs.Connect_camera_0();
            Get_imgs.Get_camera_list();
            Get_imgs.Get_images(Camera_Handle_0, ha_windowsHandle_0);


        }
        //--------------------------------------定时器-----------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {

            Get_imgs.Get_images(Camera_Handle_0, ha_windowsHandle_0);
            //获取日期+时间
            date_time.Text = DateTime.Now.ToString();
        }

        //------------------------------关闭窗口按钮---------------------------------
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------自定义鼠标拖拽移动窗体-------------------------------------
        int startX = 0, StartY = 0;

        private void camera_set_0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0");
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)   //判断是否按下鼠标左键

            {
                startX = e.X;
                StartY = e.Y;
            }
        }
        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - StartY;
            }
        }

        //-----------------------------------最大化按钮------------------------------------------
        public void 最大化_Click(object sender, EventArgs e)
        {
            if (windos_max)
            {
                //还原窗体大小
                this.WindowState = FormWindowState.Normal;
                windos_max = false;
            }
            else
            {
                //窗体最大化
                this.WindowState = FormWindowState.Maximized;
                windos_max = true;
            }
            //窗体大小改变后调用此方法改变内部控件大小
            windows_chge();

        }
        //--------------------------------------最小化窗体-----------------------------------
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //------------------------------------双击工具栏最大化和还原------------------------------------------
        private void toolStrip1_DoubleClick(object sender, EventArgs e)
        {
            if (windos_max)
            {
                //还原窗体大小
                this.WindowState = FormWindowState.Normal;
                windos_max = false;
            }
            else
            {
                //窗体最大化
                this.WindowState = FormWindowState.Maximized;
                windos_max = true;
            }
            //窗体大小改变后调用此方法改变内部控件大小
            windows_chge();
        }

        private void info_list_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            this.columnHeader1.Width = 42;
            this.columnHeader2.Width = 42;
            this.columnHeader3.Width = 200;
        }

        //--------------------------------------拖拽改变窗体大小--------------------------------------
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标按下 
            isMouseDown = true;
        }

        // 鼠标弹起
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            isMouseDown = false;
            //既然鼠标弹起了，那么就不能再改变窗体尺寸，拖拽方向置 none
            direction = MouseDirection.None;
            //改变窗体大小后改变里面控件大小
            //Ha_window_1.Width = this.Width - camera_set.Width;
            //Ha_window_1.Height = this.Height - 30;
        }
        //-----------------------------------------单击图像窗口时将图像窗口放大--------------------------------------
        private void ha_windos_0_HMouseUp(object sender, HMouseEventArgs e)
        {
            //获取当前控件的name
/*            HWindowControl ha_windows = sender as HWindowControl;
            ha_isfangda = Windows_change.fangda(ha_windows.Name, ha_isfangda);*/
        }

        private void ha_windos_1_HMouseUp(object sender, HMouseEventArgs e)
        {
            //获取当前控件的name
/*            HWindowControl ha_windows = sender as HWindowControl;
            ha_isfangda = Windows_change.fangda(ha_windows.Name, ha_isfangda);*/
        }

        private void ha_windos_2_HMouseUp(object sender, HMouseEventArgs e)
        {
            //获取当前控件的name
/*            HWindowControl ha_windows = sender as HWindowControl;
            ha_isfangda = Windows_change.fangda(ha_windows.Name, ha_isfangda);*/
        }

        private void ha_windos_3_HMouseUp(object sender, HMouseEventArgs e)
        {
            //获取当前控件的name
/*            HWindowControl ha_windows = sender as HWindowControl;
            ha_isfangda = Windows_change.fangda(ha_windows.Name, ha_isfangda);*/
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标移动过程中，坐标时刻在改变 
            //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Declining 
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE;
                direction = MouseDirection.Declining;
            }
            //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Herizontal
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE;
                direction = MouseDirection.Herizontal;
            }
            //同理当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Vertical
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS;
                direction = MouseDirection.Vertical;

            }
            //否则，以外的窗体区域，鼠标星座均为单向箭头（默认）             
            else
                this.Cursor = Cursors.Arrow;
            //设定好方向后，调用下面方法，改变窗体大小  
            ResizeWindow();
        }

        //----------------------------------------------------拖拽改变窗体大小方法--------------------------------------------------
        private void ResizeWindow()
        {

            //这个判断很重要，只有在鼠标按下时才能拖拽改变窗体大小，如果不作判断，那么鼠标弹起和按下时，窗体都可以改变 
            if (!isMouseDown)
                return;
            //MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标this.left和this.top的参考点也是屏幕，属性MousePosition是该程序的重点
            if (direction == MouseDirection.Declining)
            {
                //此行代码在mousemove事件中已经写过，在此再写一遍，并不多余，一定要写
                this.Cursor = Cursors.SizeNWSE;
                //下面是改变窗体宽和高的代码，不明白的可以仔细思考一下
                this.Width = MousePosition.X - this.Left;
                this.Height = MousePosition.Y - this.Top;
                //判断窗口大小是否小于默认值
                if (this.Width <= 900)
                {
                    this.Width = 900;
                }
                if (this.Height <= 535)
                {
                    this.Height = 535;
                }
                //窗体大小改变后调用此方法改变内部控件大小
                windows_chge();
            }
            //改变宽度
            if (direction == MouseDirection.Herizontal)
            {
                this.Cursor = Cursors.SizeWE;
                this.Width = MousePosition.X - this.Left;
                if (this.Width <= 900)
                {
                    this.Width = 900;
                }
                //窗体大小改变后调用此方法改变内部控件大小
                windows_chge();

            }
            else if (direction == MouseDirection.Vertical) //改变高度
            {
                this.Cursor = Cursors.SizeNS;
                this.Height = MousePosition.Y - this.Top;
                if (this.Height <= 535)
                {
                    this.Height = 535;
                }
                //窗体大小改变后调用此方法改变内部控件大小
                windows_chge();
            }
            //即使鼠标按下，但是不在窗口右和下边缘，那么也不能改变窗口大小
            else
                this.Cursor = Cursors.Arrow;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            camera_set.SelectedTab = camera_set_set;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            camera_set.SelectedTab = camera_set_init;
        }

        /// <summary>
        /// 窗体大小改变后里面控件随着改变
        /// </summary>
        public void windows_chge()
        {
            //获取当前窗体宽度和高度
            int width = this.Width, height = this.Height;
            //实例化一个Windos_change类并调用
            Windows_change windows_change1 = new Windows_change();
            windows_change1.change(width, height);

        }
    }
}
