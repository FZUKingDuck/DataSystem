using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSystem {
    /// <summary>
    /// 用于保存当前用户
    /// </summary>
    class Customer {
        static private string userid;
        static private int job;
        static private string inputid;

        #region Geter/Seter
        public static string Userid {
            get => userid;
            set => userid = value;
        }
        public static int Job {
            get => job;
            set => job = value;
        }
        public static string Inputid {
            get => inputid;
            set => inputid = value;
        }

        #endregion
        #region 静态方法
        /// <summary>
        /// 静态方法，判断是否为管理员登陆
        /// </summary>
        /// <returns></returns>
        static public bool isAdmin() {
            if (Job != 1)
                return false;
            else
                return true;
        }
        #endregion



    }
}
