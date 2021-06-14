using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maticsoft.Common
{
    //待扩展
    public static class IMG
    {
        public static string GetBig(string rel) {
            string name = "big_" + rel.Substring(rel.LastIndexOf("/") + 1);

            return rel.Substring(0, rel.LastIndexOf("/") + 1) + name;
        }
        public static string GetMini(string rel)
        {
            string name = "mini_" + rel.Substring(rel.LastIndexOf("/") + 1);

            return rel.Substring(0, rel.LastIndexOf("/") + 1) + name;
        }
        public static string GetW(string rel)
        {
            string name = "w_" + rel.Substring(rel.LastIndexOf("/") + 1);

            return rel.Substring(0, rel.LastIndexOf("/") + 1) + name;
        }

    }
}
