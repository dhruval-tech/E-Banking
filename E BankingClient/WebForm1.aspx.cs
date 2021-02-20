using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_BankingClient.ServiceReference1;
using E_BankingClient.ServiceReference2;

namespace E_BankingClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference2.Service1Client proxy;
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    proxy = new ServiceReference2.Service1Client();
                    GridViewStudentDetails.DataSource = proxy.GetEmployees();
                    GridViewStudentDetails.DataBind();
                }
                catch (FaultException<ExceptionMessage> exceptionFromService)
                {
                    lblMsg.Text = "Error while loading Employee details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
                catch (Exception exception)
                {
                    lblMsg.Text = "Error while loading Employee details :" + exception.Message;
                }
            }
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpId = 0;
                if (txtEmpId.Text != null && txtEmpId.Text != string.Empty)
                {
                    EmpId = Convert.ToInt32(txtEmpId.Text);
                }
                string Name = txtName.Text.Trim();
                string Salary = txtSalary.Text.Trim();
                string DeptId = txtDeptId.Text.Trim();
                string DeptName = txtDeptName.Text.Trim();

                proxy = new ServiceReference2.Service1Client();
                ServiceReference2.Employees newStudent =
                new ServiceReference2.Employees()
                {
                    EmpId = EmpId,
                    Name = Name,
                    Salary = Salary,
                    DeptId = DeptId,
                    DeptName = DeptName
                };

                proxy.InsertEmpDetails(newStudent);

                GridViewStudentDetails.DataSource = proxy.GetEmployees();
                GridViewStudentDetails.DataBind();
                lblMsg.Text = "Record Saved Successfully";
            }
            catch (FaultException<ExceptionMessage> exceptionFromService)
            {
                if (ButtonInsert.Visible == true)
                {
                    lblMsg.Text = "Error while adding new customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
                else
                {
                    lblMsg.Text = "Error while updating customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
            }
            catch (Exception exception)
            {
                if (ButtonInsert.Visible == true)
                {
                    lblMsg.Text = "Error while adding new customer details :" + exception.Message;
                }
                else
                {
                    lblMsg.Text = "Error while updating customer details :" + exception.Message;
                }
            }

            ResetAll();
        }
        private void ResetAll()
        {
            ButtonInsert.Visible = true;
            ButtonUpdate.Visible = false;
            ButtonDelete.Visible = false;
            ButtonCancel.Visible = false;
            txtName.Text = "";
            txtSalary.Text = "";
            txtDeptId.Text = "";
            txtDeptName.Text = "";
        }
        protected void GridViewStudentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmpId.Text = GridViewStudentDetails.DataKeys[GridViewStudentDetails.SelectedRow.RowIndex].Value.ToString();
            txtName.Text = (GridViewStudentDetails.SelectedRow.FindControl("lblFirstName") as Label).Text;
            txtSalary.Text = (GridViewStudentDetails.SelectedRow.FindControl("lblLastName") as Label).Text;
            txtDeptId.Text = (GridViewStudentDetails.SelectedRow.FindControl("lblRegisterNo") as Label).Text;
            txtDeptName.Text = (GridViewStudentDetails.SelectedRow.FindControl("lblDepartment") as Label).Text;
            //make invisible Insert button during update/delete
            ButtonInsert.Visible = false;
            ButtonUpdate.Visible = true;
            ButtonDelete.Visible = true;
            ButtonCancel.Visible = true;
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpId = 0;
                if (txtEmpId.Text != null && txtEmpId.Text != string.Empty)
                {
                    EmpId = Convert.ToInt32(txtEmpId.Text);
                }
                

                proxy = new ServiceReference2.Service1Client();
                

                proxy.DeleteEmpDetails(EmpId);

                GridViewStudentDetails.DataSource = proxy.GetEmployees();
                GridViewStudentDetails.DataBind();
                lblMsg.Text = "Record Saved Successfully";
            }
            catch (FaultException<ExceptionMessage> exceptionFromService)
            {
                if (ButtonInsert.Visible == true)
                {
                    lblMsg.Text = "Error while adding new customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
                else
                {
                    lblMsg.Text = "Error while updating customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
            }
            catch (Exception exception)
            {
                if (ButtonInsert.Visible == true)
                {
                    lblMsg.Text = "Error while adding new customer details :" + exception.Message;
                }
                else
                {
                    lblMsg.Text = "Error while updating customer details :" + exception.Message;
                }
            }

            ResetAll();

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {

        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpId = 0;
                if (txtEmpId.Text != null && txtEmpId.Text != string.Empty)
                {
                    EmpId = Convert.ToInt32(txtEmpId.Text);
                }
                string Name = txtName.Text.Trim();
                string Salary = txtSalary.Text.Trim();
                string DeptId = txtDeptId.Text.Trim();
                string DeptName = txtDeptName.Text.Trim();

                proxy = new ServiceReference2.Service1Client();
                ServiceReference2.Employees newStudent =
                new ServiceReference2.Employees()
                {
                    EmpId = EmpId,
                    Name = Name,
                    Salary = Salary,
                    DeptId = DeptId,
                    DeptName = DeptName
                };

                proxy.UpdateEmpDetails(newStudent);

                GridViewStudentDetails.DataSource = proxy.GetEmployees();
                GridViewStudentDetails.DataBind();
                lblMsg.Text = "Record Saved Successfully";
            }
            catch (FaultException<ExceptionMessage> exceptionFromService)
            {
                if (ButtonInsert.Visible == true)
                {
                    lblMsg.Text = "Error while adding new customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
                else
                {
                    lblMsg.Text = "Error while updating customer details :" + exceptionFromService.Detail.errorMessageOfAction;
                }
            }
            catch (Exception exception)
            {
                if (ButtonInsert.Visible == true)
                {
                    lblMsg.Text = "Error while adding new customer details :" + exception.Message;
                }
                else
                {
                    lblMsg.Text = "Error while updating customer details :" + exception.Message;
                }
            }

            ResetAll();
        }
    }
    
    //= new ServiceReference2.Service1Client(); 

}