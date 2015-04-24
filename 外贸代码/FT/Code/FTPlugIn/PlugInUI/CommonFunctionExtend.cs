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
        /// 设置控件在卡片容器中的布局
        /// </summary>
        /// <param name="container">卡片容器</param>
        /// <param name="ctrl">增加的控件</param>
        /// <param name="x">布局横坐标</param>
        /// <param name="y">布局纵坐标</param>
        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y)
        {
            Layout(container, ctrl, x, y, 1, 1, Unit.Pixel(0), Unit.Pixel(0), true);
        }

        /// <summary>
        /// 设置控件在卡片容器中的布局
        /// </summary>
        /// <param name="container">卡片容器</param>
        /// <param name="ctrl">增加的控件</param>
        /// <param name="x">布局横坐标</param>
        /// <param name="y">布局纵坐标</param>
        /// <param name="width">控件宽</param>
        /// <param name="height">控件高</param>
        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y, int width, int height)
        {
            Layout(container, ctrl, x, y, 1, 1, Unit.Pixel(width), Unit.Pixel(height), false);
        }


        /// <summary>
        /// 设置控件在卡片容器中的布局
        /// </summary>
        /// <param name="container">卡片容器</param>
        /// <param name="ctrl">增加的控件</param>
        /// <param name="x">布局横坐标</param>
        /// <param name="y">布局纵坐标</param>
        /// <param name="xspan">单元格横向跨度</param>
        /// <param name="yspan">单元格纵向跨度</param>
        /// <param name="width">控件宽</param>
        /// <param name="height">控件高</param>
        /// <param name="isAutoSize">是否自适应大小</param>
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
        /// 在父容器中查找控件
        /// </summary>
        /// <param name="parentControl">父容器</param>
        /// <param name="control">控件</param>
        /// <returns>找到的控件</returns>
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
