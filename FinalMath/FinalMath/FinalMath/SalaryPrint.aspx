<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="SalaryPrint.aspx.cs" Inherits="FinalMath.SalaryPrint" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="printablediv">

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
                                    </div>
                                    <div class="col-sm-4 invoice-col">

                                        <strong>Report for Employee:<asp:Label ID="lblemp" runat="server"></asp:Label></strong>
                                        <br />
                                        <strong>Type:<asp:Label ID="lbltype" runat="server"></asp:Label></strong>
                                    </div>
                                    <!-- /.col -->
                                </div>
                                <div class="row">
                                    <div class="col-12 table-responsive" style="padding: 20px">
                                        <table class="table table-striped">
                                            <%--<thead>
                                                <tr>
                                                    <th>Date</th>
                                                    <th>Name</th>
                                                    <th>Designation</th>
                                                    <th>Basic Salary</th>
                                                    <th>Allownces</th>
                                                    <th>Extra Duty</th>
                                                    <th>Total Salary</th>
                                                    <th>Advance Amount</th>
                                                    <th>Absent Days</th>
                                                    <th>Absent Days Amount</th>
                                                    <th>By Cheque</th>
                                                    <th>By Cash</th>
                                                    <th>Net Salary</th>
                                                    <th>Signature</th>
                                                </tr>
                                            </thead>
                                            --%><tbody>
                                                <%-- <asp:Repeater ID="PrintRepeater" runat="server">
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

                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>--%>

                                               <asp:GridView ID="IncomeGridView" Width="100%" ShowFooter="true" AutoGenerateColumns="False" CssClass="table-bordered" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                                                    <th style="width: 50%">Finance Director:</th>
                                                    <td>
                                                        <asp:Label ID="lbltotal" runat="server"></asp:Label></td>


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
