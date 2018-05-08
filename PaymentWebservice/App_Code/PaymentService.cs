using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for PaymentService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class PaymentService : System.Web.Services.WebService
{

    string cs = ConfigurationManager.ConnectionStrings["PaymentConnection"].ConnectionString;


    public PaymentService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat=ResponseFormat.Json) ]
    public int UpdatePaymentDetails(serviceRequest data)
    {
        int paymentstatusid = data.paymentstatusid;
        int customerid = data.customerid;
        string orderguid = data.orderguid;
        DataSet dt = new DataSet();

        SqlConnection conn = new SqlConnection(cs);
        conn.Open();

     
        SqlCommand cmd = new SqlCommand("spUpdatePaymentByCustomerIDOrderGUID", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@customerID", customerid);
        cmd.Parameters.AddWithValue("@orderGUID", orderguid);
        cmd.Parameters.AddWithValue("@paymentStatusId", paymentstatusid);
        int retval = cmd.ExecuteNonQuery();

        return retval;
    }

    public class serviceRequest
    {
        //int paymentstatusid, int customerid, string orderguid
        public int paymentstatusid { get; set; }
        public int customerid { get; set; }
        public string orderguid { get; set; }
    }

}
