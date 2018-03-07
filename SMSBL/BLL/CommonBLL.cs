using SMSBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using SMSBL;

namespace SMSBL.BLL
{
    public class CommonBLL
    {
        
        public static  string CommonDataInsert(CommonModel obj)
        {
            string result = "";

                string ConnectionString = "data source=.;initial catalog=SMS;user id=sa;password=Pakistan1947;";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    //Create the SqlCommand object
                    SqlCommand cmd = new SqlCommand("SelectedTableData_Insert", conn);

                    //Specify that the SqlCommand is a stored procedure
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    //Add the input parameters to the command object
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@TableNo", obj.TableNo);

                    //Add the output parameter to the command object
                    SqlParameter outPutParameter = new SqlParameter();
                    outPutParameter.ParameterName = "@ID";
                    outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                    outPutParameter.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outPutParameter);

                    //Open the connection and execute the query
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    //Retrieve the value of the output parameter
                    result = outPutParameter.Value.ToString();
                    conn.Close();
            }
            
            return result;
        }       
        public static void CommonDataUpdate(CommonModel obj)
    {
        string ConnectionString = "data source=.;initial catalog=SMS;user id=sa;password=Pakistan1947;";
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        {
            //Create the SqlCommand object
            SqlCommand cmd = new SqlCommand("SelectedTableData_Update", conn);

            //Specify that the SqlCommand is a stored procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Add the input parameters to the command object
            cmd.Parameters.AddWithValue("@ID", obj.ID);
            cmd.Parameters.AddWithValue("@Name", obj.Name);
            cmd.Parameters.AddWithValue("@Description", obj.Description);
            cmd.Parameters.AddWithValue("@TableNo", obj.TableNo);

            //Open the connection and execute the query
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
        public static  List<CommonList> GetSizeList()
        {
            SMSEntities db = new SMSEntities();
            List<CommonList> list = new List<CommonList>();

            list = db.Sizes
                       .Where(x => x.IsDeleted == false)
                       .Select(x => new CommonList
                       {
                           ID = x.ID,
                           Name = x.Name,
                           Description = x.Description
                       }).ToList();
            return list;
        }
        public static List<CommonList> GetColorList()
        {
            SMSEntities db = new SMSEntities();
            List<CommonList> list = new List<CommonList>();

            list = db.Colors
                        .Where(x => x.IsDeleted == false)                         
                        .Select(x => new CommonList
                        {
                            ID = x.ID,
                            Name = x.Name,
                            Description = x.Description
                        }).ToList();
            return list;
        }
        public static List<CommonList> GetCategoryForList()
        {
            SMSEntities db = new SMSEntities();
            List<CommonList> list = new List<CommonList>();
            //list = (from listObj in db.CategoriesFors
            //        where listObj.IsDeleted == false
            //        select new CommonList
            //        {
            //            ID = listObj.ID,
            //            Name = listObj.Name,
            //            Description = listObj.Description
            //        }).ToList();

            list = db.CategoriesFors
                        .Where(x => x.IsDeleted == false)
                        .Select(x=> new CommonList
                        {
                            ID =x.ID,
                            Name =x.Name,
                            Description =x.Description
                        }).ToList();
            return list;
        }
        public static List<CommonList> GetShoeTypeList()
        {
            SMSEntities db = new SMSEntities();
            List<CommonList> list = new List<CommonList>();
            list = db.ProductCategories
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new CommonList
                        {
                            ID = x.ID,
                            Name = x.Name,
                            Description = x.Description
                        }).ToList();
            return list;
        }
        public static List<CommonList> GetCompanyList()
        {
            SMSEntities db = new SMSEntities();
            List<CommonList> list = new List<CommonList>();
            list = db.Companies
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new CommonList
                        {
                            ID = x.ID,
                            Name = x.Name,
                            Description = x.Description
                        }).ToList();
            return list;
        }
        public static List<CommonList> GetExpenseTypeList()
        {
            SMSEntities db = new SMSEntities();
            List<CommonList> list = new List<CommonList>();
            list = db.ExpenseTypes
                        .Where(x => x.IsDeleted == false)
                        .Select(x => new CommonList
                        {
                            ID = x.ID,
                            Name = x.Name,
                            Description = x.Description
                        }).ToList();
            return list;
        }
    }
}
