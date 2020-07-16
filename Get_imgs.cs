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
            for (int i = 0; i < camera_dirlist.Length; i++)
            {
                //MessageBox.Show(camera_dirlist[0].ToString());
                
            }
            return camera_dirlist;

        }

        public static void Open_camera_0(out HTuple Camera_Handle_0, out HTuple ha_windowsHandle_0)
        {
            //打开相机
            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "gray", -1, "false", "default", "[0] ", 0, -1, out Camera_Handle_0);
            //HOperatorSet.OpenFramegrabber("File", 1, 1, 0, 0, 0, 0, "default", -1, "default",-1, "false", "D:/桌面/222.jpg", "default", 1, -1, out Camera_Handle_0);
            HOperatorSet.GrabImageStart(Camera_Handle_0, -1);
            //设置窗体背景颜色
            HOperatorSet.SetWindowAttr("background_color", "white");
            //打开一个显示窗体
            HOperatorSet.OpenWindow(0, 0, Form1.setForm1.ha_windos_0.Width, Form1.setForm1.ha_windos_0.Height, Form1.setForm1.ha_windos_0.HalconWindow, "", "", out ha_windowsHandle_0);
            //显示图像
            HDevWindowStack.Push(ha_windowsHandle_0);

        }

        

        public static void Connect_camera_0 ( )
        {
            HTuple Camera_Handle_0 = null, ha_windowsHandle_0 = null;
            Open_camera_0(out Camera_Handle_0, out ha_windowsHandle_0);
            Form1.setForm1.Camera_Handle_0 = Camera_Handle_0;
            Form1.setForm1.ha_windowsHandle_0 = ha_windowsHandle_0;
            Form1.setForm1.timer1.Start();
        }
        
        public static void Get_images(HTuple Camera_Handle_0, HTuple ha_windowsHandle_0)
        {
            HObject ho_Image_0 = null, ho_SymbolXLDs = null; ;
            HTuple img_width_0, img_height_0, hv_DataCodeHandle = null;
            HTuple hv_ResultHandles = new HTuple(), hv_DecodedDataStrings = new HTuple();

            HOperatorSet.CreateDataCode2dModel("QR Code", new HTuple(), new HTuple(), out hv_DataCodeHandle);
            //ho_Image_0.Dispose();
            //从设备获取图像
            HOperatorSet.GrabImageAsync(out ho_Image_0, Camera_Handle_0, -1);
            //获取图像大小
            HOperatorSet.GetImageSize(ho_Image_0, out img_width_0, out img_height_0);

            HOperatorSet.FindDataCode2d(ho_Image_0, out ho_SymbolXLDs, hv_DataCodeHandle, new HTuple(), new HTuple(), out hv_ResultHandles, out hv_DecodedDataStrings);
            Form1.setForm1.ha_windos0_info.Text = hv_DecodedDataStrings.ToString();
            if (HDevWindowStack.IsOpen())
            {
                //对图像进行缩放以适应窗体大小
                HOperatorSet.SetPart(ha_windowsHandle_0, -20, 0, img_height_0 + 20 , img_width_0);
                //显示图像
                HOperatorSet.DispObj(ho_Image_0, ha_windowsHandle_0);
                HOperatorSet.DispObj(ho_SymbolXLDs, HDevWindowStack.GetActive());
            }

        }

    }
}
