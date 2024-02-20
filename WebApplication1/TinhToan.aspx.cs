using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TinhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double s1 = Double.Parse(txtso1.Text);
            double s2 = Double.Parse(txtso2.Text);

            double cong = s1 + s2;
            txtkq.Text = cong.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double s1 = Double.Parse(txtso1.Text);
            double s2 = Double.Parse(txtso2.Text);

            double tru = s1 - s2;
            txtkq.Text = tru.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double s1 = Double.Parse(txtso1.Text);
            double s2 = Double.Parse(txtso2.Text);

            double nhan = s1 * s2;
            txtkq.Text = nhan.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double s1 = Double.Parse(txtso1.Text);
            double s2 = Double.Parse(txtso2.Text);

            double chia = s1 / s2;
            txtkq.Text = chia.ToString();
        }
    }
}