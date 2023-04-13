<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="FinalMath.Invoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="printablediv">

        <div class="content-header">
            <div class="container-fluid">
                <div class="row mb-2">
                    <div class="col-sm-6">
                        <h1 class="m-0 text-dark">Report</h1>
                    </div>
                    <!-- /.col -->
                    <div class="col-sm-6">
                        <ol class="breadcrumb float-sm-right">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item active">Invoice</li>
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
                            <!-- Main content -->
                            <section class="invoice">
                                <!-- title row -->
                                <div class="row" style="padding: 20px">
                                    <div class="col-12">
                                        <h2 class="page-header">
                                            <i>
                                                <img src="images/softicon.jpg" width="40" height="40" /></i>Mian Afzal Trust Hospital.
         
                               
                                        </h2>
                                    </div>
                                    <!-- /.col -->
                                </div>
                                <!-- info row -->
                                <div class="row invoice-info" style="padding: 20px">
                                    <div class="col-sm-4 invoice-col">


                                        <address>
                                            <strong>Mian Afzal Trust Hospital.</strong><br>
                                            Aroop Morr, Sialkot Road Gujranwala, Pakistan.<br>
                                            Phone: +92-55-3493795<br>
                                            Email: mianafzaltrust@gmail.com
       
                                        </address>
                                    </div>


                                    <!-- /.col -->
                                    <div class="col-sm-4 invoice-col">
                                        <b>Print Date:<asp:Label ID="lbldatetoday" runat="server"></asp:Label></b>
                                        <br>
                                        <b>Date From:</b><asp:Label ID="lbldatefrom" runat="server" Text="Label"></asp:Label>
                                        <br>
                                        <b>Date To:</b>
                                        <asp:Label ID="lbldateto" runat="server" Text="Label"></asp:Label><br>
                                        <b>Report Type:</b>
                                        <asp:Label ID="lbltype" runat="server" Text="Label"></asp:Label>
                                    </div>
                                    <div class="col-sm-4 invoice-col">

                                        <strong>Report for Head:<asp:Label ID="lblheadtype" runat="server"></asp:Label></strong>
                                        <br />
                                        <strong>Report for Vendor:<asp:Label ID="lblvendor" runat="server"></asp:Label></strong>

                                        <br />
                                        <strong>Report for Bank/Cash :<asp:Label ID="lblpaytype" runat="server"></asp:Label></strong>

                                    </div>
                                    <!-- /.col -->
                                </div>
                                <!-- /.row -->

                                <div class="row">
                                    <div class="col-12 table-responsive" style="padding: 20px">
                                        <table class="table table-striped">
                                            <thead>
                                                <tr>
                                                    <th>Date</th>
                                                    <th>Voucher</th>
                                                    <th>Description</th>
                                                    <th>Vendor</th>
                                                    <th>Head</th>
                                                    <th>Payment Mode</th>
                                                    <th>Debit</th>
                                                    <th>Credit</th>
                                                    <th>Balance</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <asp:Repeater ID="PrintRepeater" runat="server">
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="lbldate" runat="server" Text='<%#Bind("Date") %>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblvoucher" runat="server" Text='<%#Bind("Voucher") %>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lbldesc" runat="server" Text='<%#Bind("Desc") %>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblvendor1" runat="server" Text='<%#Bind("Vendor") %>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblhead" runat="server" Text='<%#Bind("Head") %>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblpaymentmode" runat="server" Text='<%#Bind("Mode") %>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="Label15520" runat="server" Text='<%# Convert.ToInt32(Eval("DrRs")).ToString("#,##0")%>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="Label1" runat="server" Text='<%# Convert.ToInt32(Eval("CrRs")).ToString("#,##0")%>'></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="Label2" runat="server" Text='<%# Convert.ToInt32(Eval("bal")).ToString("#,##0")%>'></asp:Label></td>

                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>


                                            </tbody>
                                        </table>
                                    </div>
                                    <!-- /.col -->
                                </div>
                                <!-- /.row -->

                                <div class="row">
                                    <div class="col-6">
                                        <%-- <p class="lead">Payment Methods:</p>
                                    <img src="../../dist/img/credit/visa.png" alt="Visa">
                                    <img src="../../dist/img/credit/mastercard.png" alt="Mastercard">
                                    <img src="../../dist/img/credit/american-express.png" alt="American Express">
                                    <img src="../../dist/img/credit/paypal2.png" alt="Paypal">

                                    <p class="text-muted well well-sm shadow-none" style="margin-top: 10px;">
                                        Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles, weebly ning heekya handango imeem
                    plugg
                    dopplr jibjab, movity jajah plickers sifteo edmodo ifttt zimbra.
                 
                                    </p>--%>
                                    </div>
                                    <div class="col-6">


                                        <div class="table-responsive" style="padding: 20px">
                                            <table class="table">
                                                 <tr>
                                                    <th style="width: 50%">Total Credit:</th>
                                                    <td>Rs.
                                                        <asp:Label ID="lblincome" runat="server" Text="0"></asp:Label></td>
                                                </tr>
                                            
                                                <tr>
                                                    <th style="width: 50%">Total Debit:</th>
                                                    <td>Rs.
                                                        <asp:Label ID="lblexpense" runat="server" Text="0"></asp:Label></td>


                                                </tr>
                                                   <tr>
                                                    <th style="width: 50%">Closing Balance:</th>
                                                    <td>Rs.
                                                        <asp:Label ID="lblopenbal" runat="server"></asp:Label></td>
                                                </tr>
                                                <%-- <tr>
                                        <th>Tax (9.3%)</th>
                                        <td>$10.34</td>
                                    </tr>
                                    <tr>
                                        <th>Shipping:</th>
                                        <td>$5.80</td>
                                    </tr>
                                    <tr>
                                        <th>Total:</th>
                                        <td>$265.24</td>
                                    </tr>
                                                --%>
                                            </table>

                                            <div class="float-right">
                                                <input type="button" value="Print" class="btn btn-danger" onclick="javascript: printDiv('printablediv')" />
                                                <asp:Button ID="btnback" OnClick="btnback_Click" runat="server" Text="Back" class="btn btn-warning" />

                                            </div>
                                        </div>
                                    </div>
                                </div>



                            </section>
                        </div>
                    </div>

                </div>
            </div>

        </section>
    </div>
    <script language="javascript" type="text/javascript">
        {
            function printDiv(divID) {
                //Get the HTML of div
                var divElements = document.getElementById(divID).innerHTML;
                //Get the HTML of whole page
                var oldPage = document.body.innerHTML;

                //Reset the page's HTML with div's HTML only
                document.body.innerHTML =
                    "<body>" +
                    divElements + "</body>";
                window.print();
            }
        }
    </script>
</asp:Content>
