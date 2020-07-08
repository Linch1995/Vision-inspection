using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;

namespace Vision_inspection
{
    class Get_image
    {
        public static void OpenFramegrabber( ) 
        {
            HTuple hv_Information = null, hv_ValueList = null;
            HTuple[] hv_Acq_s = {"hv_AcqHandle_0", "hv_AcqHandle_1", "hv_AcqHandle_2", "hv_AcqHandle_3" };
            string[] ha_windos_s = { "ha_windos_0", "ha_windos_1", "ha_windos_2", "ha_windos_3" };
            //获取当前设备相机列表
            HOperatorSet.InfoFramegrabber("DirectShow", "device", out hv_Information, out hv_ValueList);
            //HOperatorSet.GenEmptyObj(out ho_Image);
            Form1 form1 = new Form1();

            for (int i = 0; i < hv_ValueList.Length; i++)
            {
                HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "gray",-1, "false", "default", hv_ValueList[i], 0, -1, out hv_Acq_s[0]);
                HOperatorSet.GrabImageStart(hv_ValueList[i], -1);
                //设置窗体背景颜色
                HOperatorSet.SetWindowAttr("background_color", "black");
                            //开始采集图像-每隔100ms采集一次
            //timer1.Enabled = true;
            
            //打开一个显示窗体
            //HOperatorSet.OpenWindow(0, 0, ha_windos_0.Width, ha_windos_0.Height, ha_windos_0.HalconWindow, "", "", out hv_WindowHandle);
            //HDevWindowStack.Push(hv_WindowHandle);
            }


        }
    }
}
