using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;
using System.Collections.Generic;
using System.Linq;

namespace EditableDetails {
    public partial class _Default : System.Web.UI.Page {

        public List<Parent> ParentData {
            get {
                if (Session["ParentData"] == null)
                    Session["ParentData"] = DataHelper.CreateMasterData(5);
                return (List<Parent>)Session["ParentData"];
            }
            set {
                Session["ParentData"] = value;
            }
        }

        public List<Child> ChildData {
            get {
                if (Session["ChildData"] == null)
                    Session["ChildData"] = DataHelper.CreateChildData(50, ParentData.Count);
                return (List<Child>)Session["ChildData"];
            }
            set {
                Session["ChildData"] = value;
            }
        }

        protected void Page_Init(object sender, EventArgs e) {
            masterGrid.DataSource = ParentData;
            masterGrid.DataBind();
        }

        protected void detailGrid_BeforePerformDataSelect(object sender, EventArgs e) {
            ASPxGridView detailGrid = (ASPxGridView)sender;
            int id = (int)detailGrid.GetMasterRowKeyValue();

            var result = from q in ChildData
                         where q.ParentID == id
                         select q;

            detailGrid.DataSource = result;
        }


    }


}
