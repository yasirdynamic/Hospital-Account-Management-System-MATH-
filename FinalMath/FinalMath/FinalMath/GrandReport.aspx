<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="GrandReport.aspx.cs" Inherits="FinalMath.GrandReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <!-- Content Header (Page header) -->
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0 text-dark">Dashboard</h1>
                </div>
                <!-- /.col -->
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Home</a></li>
                        <li class="breadcrumb-item active" style="display:block"> <asp:Button runat="server" Text="Take Backup" CssClass="btn btn-primary" ID="btnBackup" OnClick="btnBackup_Click"/></li>
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
                                    <td align="center" style="font-size: xx-large; font-family: Impact, Haettenschweiler, 'Arial Narrow Bold', sans-serif" colspan="8">Grand Report</td>
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
                                    <td>Voucher No</td>
                                    <td><br />
                                        <asp:TextBox ID="txtvoucher" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 28px">Head</td>
                                    <td style="height: 28px">
                                        <asp:DropDownList ID="ddlchead" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="-1">All</asp:ListItem>
                                        </asp:DropDownList></td>
                                    <td style="height: 28px">Bank Trans Type</td>
                                    <td style="height: 28px">
                                        <asp:DropDownList ID="ddldepexp" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="-1">All</asp:ListItem>
                                            <asp:ListItem Value="-0">Deposit</asp:ListItem>
                                            <asp:ListItem Value="1">Expense</asp:ListItem>
                                            <asp:ListItem Value="2">Withdraw</asp:ListItem>
                                            <asp:ListItem Value="3">Online Income</asp:ListItem>
                                        </asp:DropDownList></td>
                                    <td style="height: 28px">Vendor</td>
                                    <td style="height: 28px">
                                        <asp:DropDownList ID="ddlvendor" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="-1">All</asp:ListItem>
                                        </asp:DropDownList></td>


                                </tr>
                                <tr>
                                     <td style="height: 28px">Income/Expense</td>
                                    <td style="height: 28px">
                                        <asp:DropDownList ID="ddlincomeandexpense" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="-1">All</asp:ListItem>
                                            <asp:ListItem>income</asp:ListItem>
                                            <asp:ListItem>expense</asp:ListItem>
                                        </asp:DropDownList></td>
                                
                                    <td>Payment Mode</td>
                                    <td>
                                        <asp:DropDownList ID="ddlpaymentmode" runat="server" CssClass="form-control select2bs4" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="-1">All</asp:ListItem>
                                        </asp:DropDownList></td>
                                    <td align="center" colspan="2">
                                        <asp:Button ID="btnprintReport" runat="server" Text="Print" CssClass="btn btn-danger" OnClick="btnprintReport_Click" />
                                        <asp:Button ID="btnexcel" runat="server" Text="XLS" OnClick="btnexcel_Click" CssClass="btn btn-success" />
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
                                                        <asp:Label ID="lblOrderID" runat="server" Text='<%# Eval("Date", "{0:dd, MMM yyyy}") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Voucher No</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label6" runat="server" Text='<%#Bind("Voucher") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Description</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label130" runat="server" Text='<%#Bind("Desc") %>'></asp:Label>

                                                    </ItemTemplate>

                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderTemplate>Vendor</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label7" runat="server" Text='<%#Bind("Vendor") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Head</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label9" runat="server" Text='<%#Bind("Head") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Payment Mode</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label110" runat="server" Text='<%#Bind("Mode") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderTemplate>Doc</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Image ID="Image" runat="server" CssClass="image img-circle" Width="100" Height="100" ImageUrl='<%#Bind("Doc") %>' />

                                                    </ItemTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Payment Type</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label117770" runat="server" Text='<%#Bind("exp_type") %>'></asp:Label>

                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderTemplate>User </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label13022" runat="server" Text='<%#Bind("username") %>'></asp:Label>

                                                    </ItemTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Dr.Rs</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label15520" runat="server" Text='<%# Convert.ToInt32(Eval("DrRs")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        Total Dr.Rs:
                                                        <asp:Label ID="lblqty1" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Cr.Rs</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label120" runat="server" Text='<%# Convert.ToInt32(Eval("CrRs")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        Total Cr.Rs:
                                                        <asp:Label ID="lblqty" runat="server"></asp:Label>

                                                    </FooterTemplate>

                                                </asp:TemplateField>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>Balance </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblbal" runat="server" Text='<%# Convert.ToInt32(Eval("bal")).ToString("#,##0")%>'></asp:Label>

                                                    </ItemTemplate>
                                                     <FooterTemplate>
                                                        Total Balance:
                                                        <asp:Label ID="lbltbal" runat="server"></asp:Label>

                                                    </FooterTemplate>
                                                </asp:TemplateField>

                                                <%--                                             <asp:TemplateField>
                                                    <HeaderTemplate>Balance </HeaderTemplate>
                                                    <ItemTemplate>
                                                             <asp:Label ID="lblbal" runat="server" Text='<%#Bind("balance") %>'></asp:Label>
 
                                                    </ItemTemplate>                                                   
                                                </asp:TemplateField>--%>
                                            </Columns>
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

