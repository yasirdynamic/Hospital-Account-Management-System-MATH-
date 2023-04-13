<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Salary.aspx.cs" Inherits="FinalMath.Salary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1>Salary Sheet</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="#">Home</a></li>
                        <li class="breadcrumb-item active">Salary_Sheet</li>
                    </ol>
                </div>
            </div>
        </div>
        <!-- /.container-fluid -->
    </section>
    <section class="content">
        <div class="container-fluid">
            <div class="card card-default">
                <div class="card card-danger">
                    <div class="card-header">
                        <h3 class="card-title">Salary Sheet</h3>
                    </div>
                    <div class="card-body">

                        <div class="form-group">
                            <div class="alert alert-default-success">
                                <asp:Label ID="lblmsg" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>

                        <div class="form-group">
                            Salary Date:<asp:Label ID="Label4" runat="server" ForeColor="Red" Text="(First Select Date )"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="txtdate" required="true" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            Select Employee:
                   <div class="col-md-10">
                       <asp:DropDownList CssClass="form-control select2" AutoPostBack="true" OnSelectedIndexChanged="ddlemp_SelectedIndexChanged" Height="50" ID="ddlemp" runat="server"></asp:DropDownList>
                   </div>
                        </div>
                        <div class="form-group">
                            Employee Type:
                    <div class="col-md-10">
                        <asp:TextBox ID="txtemp_type" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                        </div>
                        <div class="form-group">
                            Basic Salary:
                   <div class="col-md-10">
                       <asp:TextBox ID="txtbasicsal" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>

                   </div>
                        </div>
                        <div class="form-group">
                            Allownces:
                    <div class="col-md-10">
                        <asp:TextBox ID="txtallow" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                        </div>
                        <div class="form-group">
                            Total Salary:
                    <div class="col-md-10">
                        <asp:TextBox ID="txttotalsal" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                        </div>
                        <div class="form-group">
                            Extra Duty:<asp:Label ID="Label1" runat="server" ForeColor="Red" Text="(Press Enter button after enter value)"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="txtextraduty" AutoPostBack="true" OnTextChanged="txtextraduty_TextChanged" TextMode="Number" Text="0" min="0" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            G.Total Salary:
                    <div class="col-md-10">
                        <asp:TextBox ID="txtgtotal" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                        </div>

                        <div class="form-group">
                            ADVANCE_AMOUNT:<asp:Label ID="Label2" runat="server" ForeColor="Red" Text="(Press Enter button after enter value)"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="txtadvanceamount" Text="0" TextMode="Number" min="0" CssClass="form-control" OnTextChanged="txtadvanceamount_TextChanged" AutoPostBack="true"  runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            ABSENT_DAYS :<asp:Label ID="Label3" runat="server" ForeColor="Red" Text="(Press Enter button after enter value)"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="txtdays" OnTextChanged="txtdays_TextChanged" AutoPostBack="true" Text="0" TextMode="Number" min="0" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            ABSENT_DAYS_Amount:
                    <div class="col-md-10">
                        <asp:TextBox ID="txtabscentamount" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>


                    </div>
                        </div>

                        <div class="form-group">
                            BY_CHEQUE:
                    <div class="col-md-10">
                        <asp:TextBox ID="txtbycheque" Text="0" TextMode="Number" min="0" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                        </div>

                        <div class="form-group">
                            By_Cash:
                     <div class="col-md-10">
                         <asp:TextBox ID="txtbycash" Text="0" TextMode="Number" min="0" CssClass="form-control" runat="server"></asp:TextBox>
                     </div>
                        </div>

                        <div class="form-group">
                            Net Salary:
                    <div class="col-md-10">
                        <asp:TextBox ID="txtnetsal" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>


                    </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-12">
                                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-block btn-danger" OnClick="btnSave_Click" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>

</asp:Content>
