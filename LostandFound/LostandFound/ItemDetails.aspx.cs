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
    public partial class ItemDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Item> GetItem([QueryString("itemID")] int? itemId)
        {
            var _db = new LostandFound.Models.LFContext();
            IQueryable<Item> query = _db.Items;
            if (itemId.HasValue && itemId > 0)
            {
                query = query.Where(p => p.ItemID == itemId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}