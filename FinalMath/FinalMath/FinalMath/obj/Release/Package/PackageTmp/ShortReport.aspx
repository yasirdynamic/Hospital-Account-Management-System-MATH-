<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="ShortReport.aspx.cs" Inherits="FinalMath.ShortReport1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <section class="content">
        <div class="container-fluid">


            <div class="row">
                <div class="col-md-6">

                    <div class="card card-danger">
                        <div class="card-header">
                            <h3 class="card-title">INCOME</h3>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Date:</label>

                                        <div class="input-group date" id="reservationdate" data-target-input="nearest">
                                            <div class="input-group-append" data-target="#reservationdate" data-toggle="datetimepicker">
                                                <div class="input-group-text ui-datepicker-current"><i class="fa fa-calendar"></i></div>
                                            </div>
                                            <asp:TextBox ID="txtincdate"  ValidationGroup="vg" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>


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
                                        <label>Vounder:</label>

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
                                        <label>User:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single "></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlincuser" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

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
                                 <div class="col-md-12">
                                    <div class="form-group">
                                        <label>Attach Doc:</label>

                                        <div class="input-group">


                                            <asp:FileUpload ID="fileuploaderinc" runat="server" />
                                        </div>
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
                            <h3 class="card-title">EXPENSE</h3>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label>Date:</label>

                                        <div class="input-group date" id="reservationdate" data-target-input="nearest">
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
                                        <label>User:</label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="far  select2-selection--single "></i></span>
                                            </div>
                                            <asp:DropDownList ID="ddlexpuser" CssClass="form-control select2bs4" runat="server"></asp:DropDownList>

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
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>Attach Doc:</label>

                                        <div class="input-group">


                                            <asp:FileUpload ID="fileiploaderexp" runat="server" />
                                        </div>
                                    </div>

                                 </div></div>
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
                                  <center> <asp:Button ID="btnexpsave" OnClick="btnexpsave_Click" runat="server" Width="300" CssClass="btn btn-primary " Text="Save" /></center>     
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

