using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LostandFound.Models;
using System.Web.ModelBinding;

namespace LostandFound
{
    public partial class ItemList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Item> GetItem([QueryString("id")] int? categoryId)
        {
            var _db = new LostandFound.Models.LFContext();
            IQueryable<Item> query = _db.Items;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}