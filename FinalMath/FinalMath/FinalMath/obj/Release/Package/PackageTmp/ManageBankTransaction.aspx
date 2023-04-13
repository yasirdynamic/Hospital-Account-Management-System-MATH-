<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="ManageBankTransaction.aspx.cs" Inherits="FinalMath.ManageBankTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <section class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="alert alert-warning alert-dismissible">
                  <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                  <h5><i class="icon fas fa-exclamation-triangle"></i> Alert! This <asp:Label ID="lblvouchername" runat="server" ></asp:Label> has Been Enter for <asp:Label ID="lblvoucher" runat="server" Text="0"></asp:Label>  Time</h5>               
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">

                    <div class="card card-danger">
                        <div class="card-header">
                            <h3 class="card-title">Bank Withdraw/Online Deposite as Income</h3>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        
                                        <asp:RadioButton ID="btnauto" OnCheckedChanged="btnauto_CheckedChanged" AutoPostBack="true" Checked="true" GroupName="gn"  runat="server" />&nbsp;&nbsp;&nbsp;Auto&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButton ID="btnmanual" GroupName="gn" AutoPostBack="true" OnCheckedChanged="btnmanual_CheckedChanged" runat="server"  />&nbsp;&nbsp;&nbsp;Manual

                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Date:</label>

                                        <div class="input-group date" id="reservationdate" data-target-input="nearest">
                                            <div class="input-group-append" data-target="#reservationdate" data-toggle="datetimepicker">
                                                <div class="input-group-text ui-datepicker-current"><i class="fa fa-calendar"></i></div>
                                            </div>
                                            <asp:TextBox ID="txtincdate" ValidationGroup="vg" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>


                                        </div>
                                    </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label>Voucher No:</label>

                                            <div class="input-group">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="far fa fa-laptop"></i></span>
                                                </div>
                                                <asp:TextBox ID="txtincvoucher" CssClass="form-control" TextMode="Number" min="0" runat="server"></asp:TextBox>

                                            </div>
                                        </div>


                                    </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Head:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far select2-selection--single"></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlinchead" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>


                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Paymen Mode:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single"></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlincpaymentmode" CssClass="form-control select2-blue select2bs4" runat="server"></asp:DropDownList>

                                        </div>
                                    </div>


                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Vendor:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single"></i></span>
                                            </div>

                                            <asp:DropDownList ID="ddlincvendor" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

                                        </div>
                                    </div>


                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>DisType:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single "></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddldistype" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

                                        </div>
                                    </div>


                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>Amount:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far fa fa-dollar-sign"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtincamount" CssClass="form-control" TextMode="Number" min="0" runat="server"></asp:TextBox>
                                        </div>
                                    </div>


                                </div>

                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Attach Doc:</label>

                                        <div class="input-group">


                                            <asp:FileUpload ID="fileuploaderinc" runat="server" />
                                        </div>
                                    </div>


                                </div>
                                 <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Type:</label>
                                       <br /> <asp:RadioButton ID="rbtnwith" GroupName="same1" Checked="true" runat="server" />Withdraw
                                            <asp:RadioButton ID="rbtndep" GroupName="same1" runat="server" />Online Deposit                                                
                                        
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>Description:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far fa fa-pencil-alt"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtincdesc" CssClass="form-control" TextMode="multiline" min="0" runat="server"></asp:TextBox>

                                        </div>
                                    </div>


                                </div>

                            </div>

                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <center> <asp:Button ID="btnincsave" OnClick="btnincsave_Click"  runat="server" Width="300" CssClass="btn btn-danger " Text="Save" /></center>
                                    </div>


                                </div>

                            </div>

                        </div>

                    </div>





                </div>

                <div class="col-md-6">
                    <div class="card card-primary">
                        <div class="card-header">
                            <h3 class="card-title">Bank Deposits/EXPENSE</h3>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                         <br />
                              
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Date:</label>

                                        <div class="input-group date" id="reservationdate2" data-target-input="nearest">
                                            <div class="input-group-append" data-target="#reservationdate" data-toggle="datetimepicker">
                                                <div class="input-group-text ui-datepicker-current"><i class="fa fa-calendar"></i></div>
                                            </div>
                                            <asp:TextBox ID="txtexpdate" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>


                                        </div>
                                    </div>


                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Voucher No:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far fa fa-laptop"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtexpvoucher" CssClass="form-control" TextMode="Number" min="0" runat="server"></asp:TextBox>

                                        </div>
                                    </div>


                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Head:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far select2-selection--single"></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlexphead" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>


                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Paymen Mode:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single"></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlexppaymentmode" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

                                        </div>
                                    </div>


                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Vounder:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single"></i></span>
                                            </div>

                                            <asp:DropDownList ID="ddlexpvendor" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

                                        </div>
                                    </div>


                                </div>
                                <div class="col-md-6">
                                   <div class="form-group">
                                        <label>DisType:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single "></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlexpdistype" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

                                        </div>
                                    </div>


                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>Amount:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far fa fa-dollar-sign"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtexpamount" CssClass="form-control" TextMode="Number" min="0" runat="server"></asp:TextBox>
                                        </div>
                                    </div>


                                </div>

                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Attach Doc:</label>
                                        <div class="input-group">
                                            <asp:FileUpload ID="fileiploaderexp" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Expense Type:</label>
                                       <br /> <asp:RadioButton ID="rdobtnexpen" GroupName="same" runat="server" />Expense
                                            <asp:RadioButton ID="rdobtndesposit" GroupName="same" runat="server" />Deposit
                                                
                                        
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>Description:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far fa fa-pencil-alt"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtexpdesc" CssClass="form-control" TextMode="multiline" min="0" runat="server"></asp:TextBox>

                                        </div>
                                    </div>


                                </div>

                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <center> <asp:Button ID="btnexpsave"  OnClick="btnexpsave_Click" runat="server" Width="300" CssClass="btn btn-primary " Text="Save" /></center>
                                    </div>


                                </div>

                            </div>

                        </div>
                    </div>

                </div>

            </div>

        </div>
    </section>

</asp:Content>
