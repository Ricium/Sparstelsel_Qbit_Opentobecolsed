using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace SparStelsel.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [System.Web.Mvc.Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Security Question")]
        public string SecurityQuestion { get; set; }

        [Required]
        [Display(Name = "Security Answer")]
        public string SecurityAnswer { get; set; }

        public string[] roles { get; set; }
    }

    public class RoleModel
    {
        [Required]
        [Display(Name = "Role name")]
        public string RoleName { get; set; }
    }


    public class AccountFunctions
    {
        public void SetUserLogin(string UserName)
        {
            string Companies = "";
            string[] userroles = Roles.GetRolesForUser(UserName);
            List<int> list = GetCompaniesFromRoles(userroles);
            Companies = ListToCommaString<int>(list);

            HttpContext.Current.Session["Username"] = UserName;
            HttpContext.Current.Session["Companies"] = Companies;
        }

        public List<int> GetCompaniesFromRoles(string[] roles)
        {
            List<int> companies = new List<int>();

            foreach (string role in roles)
            {
                if((role[0].Equals('c')) && (role[1].Equals('_')))
                {
                    companies.Add(GetCompanyFromRole(role));
                }
            }

            return companies;
        }

        public List<string> GetCompaniesFromRoles(string[] roles, bool dummy)
        {
            List<string> companies = new List<string>();

            foreach (string role in roles)
            {
                if ((role[0].Equals('c')) && (role[1].Equals('_')))
                {
                    companies.Add(GetCompanyFromRole(role,true));
                }
            }

            return companies;
        }

        public List<string> GetRolesOnly(string[] allroles)
        {
            List<string> roles = new List<string>();

            foreach (string role in allroles)
            {
                if (!((role[0].Equals('c')) && (role[1].Equals('_'))))
                {
                    if(!role.Equals("superuser"))
                    {
                        roles.Add(role); 
                    }                    
                }
            }

            return roles;
        }


        public int GetCompanyFromRole(string role)
        {
            int ret = 0;

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.AuthConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM Company WHERE RoleLink ='" + role + "'", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ret = Convert.ToInt32(drI["CompanyID"]);
                }
            }
            drI.Close();
            con.Close();
            drI.Dispose();
            con.Dispose();

            return ret;
        }

        public string GetCompanyFromRole(string role, bool dummy)
        {
            string ret = "";

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.AuthConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM Company WHERE RoleLink ='" + role + "'", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ret = drI["RoleLink"].ToString();
                }
            }
            drI.Close();
            con.Close();
            drI.Dispose();
            con.Dispose();

            return ret;
        }

        public string ListToCommaString<T>(List<T> list)
        {
            string ret = "";
            foreach (T item in list)
            {
                ret = ret + item.ToString() + ",";
            }

            //...Remove last comma and return
            if (ret.Length == 0)
                return "";
            else
                return ret.Substring(0, ret.Length - 1);
        }
    }

}
