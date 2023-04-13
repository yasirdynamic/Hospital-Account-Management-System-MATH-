<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminShortReport.aspx.cs" Inherits="FinalMath.AdminShortReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Invoice</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Bootstrap 4 -->

    <!-- Font Awesome -->
    <link rel="stylesheet" href="Content/Admin/plugins/fontawesome-free/css/all.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="Content/Admin/dist/css/adminlte.min.css">

    <!-- Google Font: Source Sans Pro -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div  id="printablediv">
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
                                        <i class="fas fa-globe"></i>Mian Afzal Trust Hospital.
         
                               
                                    </h2>
                                </div>
                                <!-- /.col -->
                            </div>
                            <!-- info row -->
                            <div class="row invoice-info" style="padding: 20px">
                                <div class="col-sm-4 invoice-col">


                                    <address>
                                        <strong>Mian Afzal Trust Hospital.</strong><br>
                                        Aroop Moorr Gujranwala<br>
                                        Phone: +92-55-3493795<br>
                                        Email: abc@gmail.com
       
                                    </address>
                                </div>
                                <%--<!-- /.col -->
                        <div class="col-sm-4 invoice-col">
        To
        <address>
          <strong>John Doe</strong><br>
          795 Folsom Ave, Suite 600<br>
          San Francisco, CA 94107<br>
          Phone: (555) 539-1037<br>
          Email: john.doe@example.com
        </address>
      </div>--%>
                                <!-- /.col -->
                                <div class="col-sm-4 invoice-col">
                                    <b>Print Date:<asp:Label ID="lbldatetoday" runat="server"></asp:Label></b>
                                    <br>
                                    <b>Date From:</b><asp:Label ID="lbldatefrom" runat="server" Text="Label"></asp:Label>
                                    <br>
                                    <b>Date To:</b>
                                    <asp:Label ID="lbldateto" runat="server" Text="Label"></asp:Label><br>
                                    <b>Report Type:</b>
                                    <asp:Label ID="lbltype" runat="server" Text="Short Summary"></asp:Label>
                                </div>
                                <!-- /.col -->
                            </div>
                            <!-- /.row -->
                            <div class="row">
                                <div class="col-12 table-responsive" style="padding-left: 20px">
                                    <h4>Credit</h4>
                                </div>
                            </div>
                            <!-- Table row -->
                            <div class="row" style="padding-top: -40px">
                                <div class="col-12 table-responsive" style="padding: 20px">
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>Receipts</th>
                                                <th>Amount</th>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="PrintRepeaterCR" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lbldate" runat="server" Text='<%#Bind("HEAD_NAME") %>'></asp:Label></td>
                                                        <td>
                                                            <asp:Label ID="lblvoucher" runat="server" Text='<%#Bind("CrRs") %>'></asp:Label></td>
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
                                <div class="col-12 table-responsive" style="padding-left: 20px">
                                    <h4>Debit</h4>
                                </div>
                            </div>
                            <!-- Table row -->
                            <div class="row" style="padding-top: -40px">
                                <div class="col-12 table-responsive" style="padding: 20px">
                                    <table class="table table-striped">
                                        <thead>
                                            <tr>
                                                <th>Payments</th>
                                                <th>Amount</th>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="RepeaterDR" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lbldate" runat="server" Text='<%#Bind("HEAD_NAME") %>'></asp:Label></td>
                                                        <td>
                                                            <asp:Label ID="lblvoucher" runat="server" Text='<%#Bind("DrRs") %>'></asp:Label></td>

                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>


                                        </tbody>
                                    </table>
                                </div>
                                <!-- /.col -->
                            </div>
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
                                                <th style="width: 50%">Total Debit:</th>
                                                <td>Rs.
                                                    <asp:Label ID="lbltotal" runat="server" Text="0"></asp:Label></td>


                                            </tr>
                                            <tr>
                                                <th style="width: 50%">Total Credit:</th>
                                                <td>Rs.
                                                    <asp:Label ID="lbltotal1" runat="server" Text="0"></asp:Label></td>
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
                                             <asp:Button ID="btnback" OnClick="btnback_Click1" runat="server" Text="Back" class="btn btn-warning" />

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
        </div>
    </form>
</body>
</html>
