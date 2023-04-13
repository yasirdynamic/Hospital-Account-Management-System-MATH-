<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="salaryreport.aspx.cs" Inherits="FinalMath.salaryreport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0 text-dark">Salary Report</h1>
                </div>
                <!-- /.col -->
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Home</a></li>
                        <li class="breadcrumb-item active">Salary Report</li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>

    <section class="content">
        <div class="container-fluid">

            <div class="row">
                <div class="col-sm-12">
                    <div class="card-box">

                        <div style="margin: 10px">

                            <table width="100%" border="1" class="table table-striped table-bordered table-hover table-checkable order-column valign-middle" id="example4">
                                <tr>
                                    <td align="center" style="font-size: xx-large; font-family: Impact, Haettenschweiler, 'Arial Narrow Bold', sans-serif" colspan="8">Salary Report</td>
                                </tr>
                                <tr>
                                    <td>Date From</td>
                                    <td>(MM/DD/YYYY)<br />
                                        <asp:TextBox ID="txtDateFrom" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Date To</td>
                                    <td>(MM/DD/YYYY)<br />
                                        <asp:TextBox ID="txtDateTo" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Select Type</td>
                                    <td>
                                        <br />
                                        <asp:DropDownList ID="ddltype" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">

                                            <asp:ListItem value="-1">All</asp:ListItem>
                                            <asp:ListItem>Permanent</asp:ListItem>
                                            <asp:ListItem>Daily Wages</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Select Employee</td>
                                    <td>
                                        <asp:DropDownList ID="ddlemp" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="-1">All</asp:ListItem>
                                        </asp:DropDownList></td>
                                    <td align="center">
                                        <asp:Button ID="btnprintReport" runat="server" Text="Print" CssClass="btn btn-danger" OnClick="btnprintReport_Click" />
                                        <asp:Button ID="btnshowreport" runat="server" OnClick="btnshowreport_Click" Text="Generate Report" CssClass="btn btn-primary" />
                                    </td>
                                </tr>

                            </table>

                            <div class="table-scrollable">
                                <table
                                    class="table table-striped table-bordered table-hover table-checkable order-column valign-middle"
                                    id="example4" style="width: 100%">

                                    <tbody>
                                        <asp:GridView ID="IncomeGridView" Width="100%" ShowFooter="true" AutoGenerateColumns="False" CssClass="table-bordered" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <alternatingrowstyle backcolor="White" />
                                            <editrowstyle backcolor="#2461BF" />
                                            <footerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
                                            <headerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
                                            <pagerstyle backcolor="#2461BF" forecolor="White" horizontalalign="Center" />
                                            <rowstyle backcolor="#EFF3FB" />
                                            <selectedrowstyle backcolor="#D1DDF1" font-bold="True" forecolor="#333333" />
                                            <sortedascendingcellstyle backcolor="#F5F7FB" />
                                            <sortedascendingheaderstyle backcolor="#6D95E1" />
                                            <sorteddescendingcellstyle backcolor="#E9EBEF" />
                                            <sorteddescendingheaderstyle backcolor="#4870BE" />
                                            <columns>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Date</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblOrderID" runat="server" Text='<%# Eval("SALARY_DATE", "{0:dd, MMM yyyy}") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Name</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label61" runat="server" Text='<%#Bind("EMPLOYEE_NAME") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        Total
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Desg</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1302" runat="server" Text='<%#Bind("EMPLOYEE_DESIGNATION") %>'></asp:Label>

                                                    </ItemTemplate>

                                                </asp:TemplateField>
                                                 <asp:TemplateField>
                                                    <HeaderTemplate>Type</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label11213" runat="server" Text='<%#Bind("EMPLOYEE_TYPE") %>'></asp:Label>

                                                    </ItemTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Basic Salary</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label73" runat="server" Text='<%# Convert.ToInt32(Eval("EMPLOYEE_MONTHLY_SALARY")).ToString("#,##0")%>' ></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbltotalbasicsal" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Allownces</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label94" runat="server" Text='<%# Convert.ToInt32(Eval("EMPLOYEE_ALLOWENCES")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbltotalallownces" runat="server"></asp:Label>

                                                    </FooterTemplate>
                                                </asp:TemplateField>

                                                 <asp:TemplateField>
                                                    <HeaderTemplate>Total Salary </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label130226111" runat="server" Text='<%# Convert.ToInt32(Eval("BA_TOTAL_SALARY")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lblbasal" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>


                                                <asp:TemplateField>
                                                    <HeaderTemplate>Extra Duty</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1105" runat="server" Text='<%# Convert.ToInt32(Eval("EXTRA_DUTY")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbltotalextraduties" runat="server"></asp:Label>

                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                               
                                                <asp:TemplateField>
                                                    <HeaderTemplate>G.Total Salary </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label130226" runat="server" Text='<%# Convert.ToInt32(Eval("TOTAL_SALARY")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbltotaltotalsal" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Advance Amount</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label155207" runat="server" Text='<%# Convert.ToInt32(Eval("ADVANCE_AMOUNT")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>                                                        
                                                        <asp:Label ID="lbltotaladvamount" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Absent Days</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1208" runat="server" Text='<%#Bind("ABSENT_DAYS") %>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>                                                       
                                                        <asp:Label ID="lbltotalabsdays" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Absent Days Amount</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label19" runat="server" Text='<%# Convert.ToInt32(Eval("ABSENT_AMOUNT")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>                                                        
                                                        <asp:Label ID="lbltotalabsamount" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>By Cheque </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblbal0" runat="server" Text='<%# Convert.ToInt32(Eval("BY_CHEQUE")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>                                                        
                                                        <asp:Label ID="lbltotalcheq" runat="server"></asp:Label>

                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>By Cash </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label311" runat="server" Text='<%# Convert.ToInt32(Eval("BY_CASH")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>                                                        
                                                        <asp:Label ID="lbltotalcash" runat="server"></asp:Label>

                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Net Salary </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label522" runat="server" Text='<%# Convert.ToInt32(Eval("NET_SALARY")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>                                                     
                                                        <asp:Label ID="lbltotalnetsal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Signature</HeaderTemplate>
                                                    <ItemTemplate>
                                                      
                                                    </ItemTemplate>
                                                         </asp:TemplateField>
                                                <%--                                             <asp:TemplateField>
                                                    <HeaderTemplate>Balance </HeaderTemplate>
                                                    <ItemTemplate>
                                                             <asp:Label ID="lblbal" runat="server" Text='<%#Bind("balance") %>'></asp:Label>
 
                                                    </ItemTemplate>                                                   
                                                </asp:TemplateField>--%>
                                            </columns>
                                        </asp:GridView>



                                        <%--  <asp:GridView ID="ExpGridview" Visible="false" Width="100%" ShowFooter="true" AutoGenerateColumns="False" CssClass="table-bordered"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                     <Columns>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Date</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblOrderID" runat="server" Text='<%#Bind("Date") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Voucher No</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label6" runat="server" Text='<%#Bind("VOUCHER") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Vendor</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label7" runat="server" Text='<%#Bind("VENDOR") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Head</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label9" runat="server" Text='<%#Bind("HEAD") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Payment Mode</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label110" runat="server" Text='<%#Bind("Mode") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Amount</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label120" runat="server" Text='<%#Bind("Amount") %>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                       Total Expense:  Rs. <asp:Label ID="lblqty" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Description</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label130" runat="server" Text='<%#Bind("Desc") %>'></asp:Label>

                                                    </ItemTemplate>
                                                   
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Doc</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Image ID="Image" runat="server" CssClass="image img-circle" Width="100" Height="100" ImageUrl='<%#Bind("Doc") %>'/>
                                                       
                                                    </ItemTemplate>
                                                   
                                                </asp:TemplateField>
                                              <asp:TemplateField>
                                                    <HeaderTemplate>User </HeaderTemplate>
                                                    <ItemTemplate>
                                                             <asp:Label ID="lblsd" runat="server" Text='<%#Bind("username") %>'></asp:Label>
 
                                                    </ItemTemplate>
                                                   
                                                </asp:TemplateField>
                                            </Columns>
                                </asp:GridView>
                                        --%>
                                    </tbody>
                                </table>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>



</asp:Content>
