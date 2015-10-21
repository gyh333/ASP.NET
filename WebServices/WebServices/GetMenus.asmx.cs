using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// GetMenus 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.jokeny.cn/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class GetMenus : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Menus> GetTopMenuses()
        {
            return new List<Menus>()
            {
                new Menus(){Mid = 1,MName = "酸菜鱼",Price = 28},
                new Menus(){Mid = 2,MName = "香辣鸡",Price = 58},
                new Menus(){Mid = 3,MName = "鱼香茄子",Price = 10},
            };
        }
    }

    public class Menus
    {
        public int Mid { get; set; }
        public string MName { get; set; }
        public decimal Price { get; set; }
    }
}
