using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vision_inspection
{
    class Get_imgs
    {
        public static HTuple Get_camera_list()
        {
            HTuple hv_Information = null, camera_dirlist = null;

            //获取当前设备相机列表
            HOperatorSet.InfoFramegrabber("DirectShow", "device", out hv_Information, out camera_dirlist);
            //加载设备列表
            /*            for (int i = 0; i < camera_dirlist.Length; i++)
                        {


                        }*/
            return camera_dirlist;

        }
        public static void Open_camera_0(out HTuple Camera_Handle_0, out HTuple ha_windowsHandle_0)
        {
            //打开相机
            //HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "gray", -1, "false", "default", "[0]", 0, -1, out Camera_Handle_0);
            HOperatorSet.OpenFramegrabber("File", 1, 1, 0, 0, 0, 0, "default", -1, "default",-1, "false", "D:/桌面/微信截图_20200630164048.png", "default", 1, -1, out Camera_Handle_0);
            HOperatorSet.GrabImageStart(Camera_Handle_0, -1);
            //设置窗体背景颜色
            HOperatorSet.SetWindowAttr("background_color", "white");
            //打开一个显示窗体
            HOperatorSet.OpenWindow(0, 0, Form1.setForm1.ha_windos_0.Width, Form1.setForm1.ha_windos_0.Height, Form1.setForm1.ha_windos_0.HalconWindow, "", "", out ha_windowsHandle_0);
            //显示图像
            HDevWindowStack.Push(ha_windowsHandle_0);


        }
        public static void Open_camera_1(out HTuple Camera_Handle_1, out HTuple ha_windowsHandle_1)
        {
            //打开相机
            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "gray", -1, "false", "default", "[0]", 0, -1, out Camera_Handle_1);
            HOperatorSet.GrabImageStart(Camera_Handle_1, -1);
            //设置窗体背景颜色
            HOperatorSet.SetWindowAttr("background_color", "white");
            //打开一个显示窗体
            HOperatorSet.OpenWindow(0, 0, Form1.setForm1.ha_windos_0.Width, Form1.setForm1.ha_windos_0.Height, Form1.setForm1.ha_windos_0.HalconWindow, "", "", out ha_windowsHandle_1);
            //显示图像
            HDevWindowStack.Push(ha_windowsHandle_1);

        }
        public static void Open_camera_2(out HTuple Camera_Handle_2, out HTuple ha_windowsHandle_2)
        {
            //打开相机
            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "gray", -1, "false", "default", "[0]", 0, -1, out Camera_Handle_2);
            HOperatorSet.GrabImageStart(Camera_Handle_2, -1);
            //设置窗体背景颜色
            HOperatorSet.SetWindowAttr("background_color", "white");
            //打开一个显示窗体
            HOperatorSet.OpenWindow(0, 0, Form1.setForm1.ha_windos_0.Width, Form1.setForm1.ha_windos_0.Height, Form1.setForm1.ha_windos_0.HalconWindow, "", "", out ha_windowsHandle_2);
            //显示图像
            HDevWindowStack.Push(ha_windowsHandle_2);

        }
        public static void Open_camera_3(out HTuple Camera_Handle_3, out HTuple ha_windowsHandle_3)
        {
            //打开相机
            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "gray", -1, "false", "default", "[0]", 0, -1, out Camera_Handle_3);
            HOperatorSet.GrabImageStart(Camera_Handle_3, -1);
            //设置窗体背景颜色
            HOperatorSet.SetWindowAttr("background_color", "white");
            //打开一个显示窗体
            HOperatorSet.OpenWindow(0, 0, Form1.setForm1.ha_windos_0.Width, Form1.setForm1.ha_windos_0.Height, Form1.setForm1.ha_windos_0.HalconWindow, "", "", out ha_windowsHandle_3);
            //显示图像
            HDevWindowStack.Push(ha_windowsHandle_3);

        }

        public static void Connect_camera_0 ( )
        {
            HTuple Camera_Handle_0 = null, ha_windowsHandle_0 = null;
            Open_camera_0(out Camera_Handle_0, out ha_windowsHandle_0);
            Form1.setForm1.Camera_Handle_0 = Camera_Handle_0;
            Form1.setForm1.ha_windowsHandle_0 = ha_windowsHandle_0;
            Form1.setForm1.timer_0.Start();
        }
        
        public static void Get_images(HTuple Camera_Handle_0, HTuple ha_windowsHandle_0)
        {
            HObject ho_Image_0 = null;
            HTuple img_width_0, img_height_0;
            //从设备获取图像
            HOperatorSet.GrabImageAsync(out ho_Image_0, Camera_Handle_0, -1);
            //获取图像大小
            HOperatorSet.GetImageSize(ho_Image_0, out img_width_0, out img_height_0);
            if (HDevWindowStack.IsOpen())
            {
                //对图像进行缩放以适应窗体大小
                HOperatorSet.SetPart(ha_windowsHandle_0, 0, 50, img_width_0 - 160, img_height_0);
                //显示图像
                HOperatorSet.DispObj(ho_Image_0, ha_windowsHandle_0);
            }

        }

    }
}
