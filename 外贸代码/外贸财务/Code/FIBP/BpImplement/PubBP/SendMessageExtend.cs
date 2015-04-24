using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFIDA.U9.Cust.GS.FI.FIBP.PubBP
{
   public partial class  SendMessageExtend
    {
        /// <summary>
        /// 发送消息  注意: 在bp调用 ，用户要设置联系人和用户组的内容，标题不能为空
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="title">标题</param>
        /// <param name="receivers">接收对象</param>
        /// <param name="priortity">消息紧急程度</param>
        public static void SendMessage(string message, string title, List<long> receivers, UFIDA.U9.BS.Notification.PriorityEnum priortity)
        {
            UFIDA.U9.BS.Notification.MessageFramework.Sender.SendMessageSubject senderMsgSubject =
                new UFIDA.U9.BS.Notification.MessageFramework.Sender.SendMessageSubject();
            //UFIDA.U9.Base.UserRole.User user = UFIDA.U9.Base.UserRole.User.Finder.Find("Name ='" + createby + "'");
            // List<long> receivers = new List<long>(); //发送对象
            if (receivers.Count > 0)
            {
                //receivers.Add(user.ID);
                UFIDA.U9.BS.Notification.MessageFramework.Msg.TextMessage textMsg =
                new UFIDA.U9.BS.Notification.MessageFramework.Msg.TextMessage();
                textMsg.Content = message; //消息内容 
                textMsg.Subject = title; //消息主题 
                textMsg.Priority = priortity;//设置消息的重要性
                textMsg.SourceOrg = Base.Context.LoginOrg.ID;//来源组织
                //textMsg.SourceOrg = 101;//门户组织

                senderMsgSubject.SendMessage(receivers, textMsg);

            }
        }
    }
}
