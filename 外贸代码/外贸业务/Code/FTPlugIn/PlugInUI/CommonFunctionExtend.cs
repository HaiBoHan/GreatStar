using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.UI.ControlModel;
using System.Web.UI.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using System.Web.UI;
using UFSoft.UBF.UI.IView;

namespace UFIDA.U9.Cust.GS.FT.PlugInUI
{
    public class CommonFunctionExtend
    {

        /// <summary>
        /// ���ÿؼ��ڿ�Ƭ�����еĲ���
        /// </summary>
        /// <param name="container">��Ƭ����</param>
        /// <param name="ctrl">���ӵĿؼ�</param>
        /// <param name="x">���ֺ�����</param>
        /// <param name="y">����������</param>
        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y)
        {
            Layout(container, ctrl, x, y, 1, 1, Unit.Pixel(0), Unit.Pixel(0), true);
        }

        /// <summary>
        /// ���ÿؼ��ڿ�Ƭ�����еĲ���
        /// </summary>
        /// <param name="container">��Ƭ����</param>
        /// <param name="ctrl">���ӵĿؼ�</param>
        /// <param name="x">���ֺ�����</param>
        /// <param name="y">����������</param>
        /// <param name="width">�ؼ���</param>
        /// <param name="height">�ؼ���</param>
        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y, int width, int height)
        {
            Layout(container, ctrl, x, y, 1, 1, Unit.Pixel(width), Unit.Pixel(height), false);
        }


        /// <summary>
        /// ���ÿؼ��ڿ�Ƭ�����еĲ���
        /// </summary>
        /// <param name="container">��Ƭ����</param>
        /// <param name="ctrl">���ӵĿؼ�</param>
        /// <param name="x">���ֺ�����</param>
        /// <param name="y">����������</param>
        /// <param name="xspan">��Ԫ�������</param>
        /// <param name="yspan">��Ԫ��������</param>
        /// <param name="width">�ؼ���</param>
        /// <param name="height">�ؼ���</param>
        /// <param name="isAutoSize">�Ƿ�����Ӧ��С</param>
        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y, int xspan, int yspan,
            Unit width, Unit height, bool isAutoSize)
        {
            IGridLayout gl = container.Layout as IGridLayout;
            if (gl == null) return;
            GridLayoutInfo glInfo = new GridLayoutInfo((uint)x, (uint)y, (uint)xspan, (uint)yspan, width, height);
            glInfo.AutoSize = isAutoSize;
            gl.Controls.Add((Control)ctrl, glInfo);

        }

        /// <summary>
        /// �ڸ������в��ҿؼ�
        /// </summary>
        /// <param name="parentControl">������</param>
        /// <param name="control">�ؼ�</param>
        /// <returns>�ҵ��Ŀؼ�</returns>
        public static IUFControl FindControl(IPart part, string parentControl, string control)
        {
            IUFCard card = (IUFCard)part.GetUFControlByName(part.TopLevelContainer, parentControl);
            if (card == null)
                return null;

            foreach (IUFControl ctrl in card.Controls)
            {
                if (ctrl.ID.Equals(control, StringComparison.OrdinalIgnoreCase))
                {
                    return ctrl;
                }
            }
            return null;

        }
        public static UFSoft.UBF.UI.ControlModel.IUFControl FindControl(UFSoft.UBF.UI.IView.IPart part, string control)
        {
            try
            {
                UFSoft.UBF.UI.ControlModel.IUFControl ctrl = part.GetUFControlByName(part.TopLevelContainer, control);
                return ctrl;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}
