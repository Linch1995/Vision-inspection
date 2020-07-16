using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vision_inspection
{
    class Read_QRCode
    {
        public void Read_QR()
        {
            HTuple hv_DataCodeHandle = null, hv_AcqHandle = null;
            HObject ho_Image = null, ho_SymbolXLDs = null;
            HTuple hv_ResultHandles = new HTuple(), hv_DecodedDataStrings = new HTuple();

            HOperatorSet.CreateDataCode2dModel("QR Code", new HTuple(), new HTuple(), out hv_DataCodeHandle);
            ho_Image.Dispose();
            HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
            ho_SymbolXLDs.Dispose();
            HOperatorSet.FindDataCode2d(ho_Image, out ho_SymbolXLDs, hv_DataCodeHandle,new HTuple(), new HTuple(), out hv_ResultHandles, out hv_DecodedDataStrings);
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
                HOperatorSet.DispObj(ho_SymbolXLDs, HDevWindowStack.GetActive());
            }

        }
    }
}
