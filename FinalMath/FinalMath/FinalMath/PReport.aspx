<%@ Page Title="" Language="C#" MasterPageFile="~/Report.Master" AutoEventWireup="true" CodeBehind="PReport.aspx.cs" Inherits="FinalMath.PReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="content-header">
            <div class="container-fluid">
                <div class="row mb-2">
                    <div class="col-sm-6">
                        <h1 class="m-0 text-dark">Patient Report</h1>
                    </div>
                    <!-- /.col -->
                    <div class="col-sm-6">
                        <ol class="breadcrumb float-sm-right">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item active">Patient Report</li>
                        </ol>
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </div>
       
        <section class="content">
            <div class="container-fluid" >

                <div class="row">
                    <div class="col-sm-12">
                        <div class="card-box">

                            <div style="margin: 10px">

                                <table width="100%" style="font-size:small;font-weight:bold" border="1" class="table table-striped table-bordered table-hover table-checkable order-column valign-middle" id="example4">
                                    <tr>
                                        <td align="center" style="font-size: xx-large; font-family: Impact, Haettenschweiler, 'Arial Narrow Bold', sans-serif" colspan="8">Patient Report</td>
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
                                        <td align="center">
                                            <script>
        function printDiv() {
            var divContents = document.getElementById("GFG").innerHTML;
            //Get the HTML of whole page
            var oldPage = document.body.innerHTML;

            //Reset the page's HTML with div's HTML only
            document.body.innerHTML =
                "<body>" +
            divContents + "</body>";
            window.print();
        }
                                            </script>
                                                <asp:CheckBox ID="cbIsDischarged" runat="server" />  isDischarged &nbsp;&nbsp;
                                            <asp:CheckBox ID="cbIsActive" runat="server" />  isActive
                                            <input type="button" value="Print" onclick="printDiv()" class="btn btn-danger"> 
                                           <asp:Button ID="btnexcel" runat="server" Text="Excel Print" CssClass="btn btn-success" OnClick="btnexcel_Click" />
                                            
                                            <%--<asp:Button ID="btnprintReport" runat="server" Text="Print" CssClass="btn btn-danger" OnClick="btnprintReport_Click" />--%>
                                            <asp:Button ID="btnshowreport" runat="server" OnClick="btnshowreport_Click" Text="Generate Report" CssClass="btn btn-primary" />
                                        </td>
                                    </tr>
                                    <tr>
                                         <td>
                                             REGISTRATION_NO<br />
                                             <asp:DropDownList ID="ddlREGISTRATION_NO" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                         <td>
                                             NAME
                                             <br />
                                             <asp:DropDownList ID="ddlNAME" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            FATHER_NAME
                                            <br />
                                             <asp:DropDownList ID="ddlFATHER_NAME" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            DATE_OF_BIRTH
                                            <br />
                                             <asp:DropDownList ID="ddlDATE_OF_BIRTH" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            DATE_OF_ADDMISSION
                                            <br />
                                             <asp:DropDownList ID="ddlDATE_OF_ADDMISSION"  CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                    </tr>

                                    <tr>
                                        
                                        <td>
                                            DATE_OF_DISCHARGE<br />
                                             <asp:DropDownList ID="ddlDATE_OF_DISCHARGE" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            MONTH<br />
                                             <asp:DropDownList ID="ddlMONTH" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            CONTACT<br />
                                             <asp:DropDownList ID="ddlCONTACT" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            CATEGORY<br />
                                             <asp:DropDownList ID="ddlCATEGORY" CssClass="select2"   Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            AGE<br />
                                             <asp:DropDownList ID="ddlAGE" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>

                                    </tr>
                                     <tr>
                                        <td>
                                            CITY<br />
                                             <asp:DropDownList ID="ddlCITY" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            ADDRESS<br />
                                             <asp:DropDownList ID="ddlADDRESS" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            RELIGION<br />
                                             <asp:DropDownList ID="ddlRELIGION" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            CHRONIC_MEDICAL_PROBLEM<br />
                                             <asp:DropDownList ID="ddlCHRONIC_MEDICAL_PROBLEM" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            CMP_SPECIFY<br />
                                             <asp:DropDownList ID="ddlCMP_SPECIFY" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                         </tr>
                                     <tr>
                                        <td>
                                            
                                            REGULARLY<br />_TAKING_OR_SHOULD_BE<br />_TAKING_PRESCRIBED<br />_MEDICATION
                                            
                                             <asp:DropDownList ID="ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            EDUCATION<br />
                                             <asp:DropDownList ID="ddlEDUCATION" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            OCCUPATION<br />
                                             <asp:DropDownList ID="ddlOCCUPATION" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            DRUG_TYPE<br />
                                             <asp:DropDownList ID="ddlDRUG_TYPE" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            R_O_A<br />
                                             <asp:DropDownList ID="ddlR_O_A" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                         </tr>
                                          <tr>
                                        <td>
                                            REASON_FOR_SUBSTANCE_USE<br />
                                             <asp:DropDownList ID="ddlREASON_FOR_SUBSTANCE_USE" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        
                                        <td>
                                            HOW_MANY_TIMES_BEFORE<br />_TREATED_FOR_SUBSTANCE_USE<br />
                                             <asp:DropDownList ID="ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>REASON_BEHIND_RELAPSE<br />
                                             <asp:DropDownList ID="ddlREASON_BEHIND_RELAPSE" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            HAVING_EVER_BEEN_ARRESTED<br />_AND_CHARGED_FOR_ANY_CRIME<br />
                                             <asp:DropDownList ID="ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            HC_SPECIFY<br />
                                             <asp:DropDownList ID="ddlHC_SPECIFY" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                              </tr>
                                          <tr>
                                        <td>
                                            MARITAL_STATUS<br />
                                             <asp:DropDownList ID="ddlMARITAL_STATUS" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            LIVES_WITH_ANY_ONE_<br />WHO_ABUSES_DRUGS_ALCOHAL<br />
                                             <asp:DropDownList ID="ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                            LDA_SPECIFIER<br />
                                             <asp:DropDownList ID="ddlLDA_SPECIFIER" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>

                                        <td>
                                           YOU_HAD_EXPERIENCED_SERIOUS<br />_PROBLEM_WITH_YOUR_FAMILY<br />_OTHER_SIGNIFICANT_FAMILY<br />
                                             <asp:DropDownList ID="ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>

                                        <td>
                                           SF_SPECIFY<br />
                                             <asp:DropDownList ID="ddlSF_SPECIFY"  CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                               </tr>
                                          <tr>
                                         <td>
                                           HAS_ANY_ONE_ABUSED_YOU<br />
                                             <asp:DropDownList ID="ddlHAS_ANY_ONE_ABUSED_YOU" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                         <td>
                                           EXPERIENCED<br />_SERIOUS_DEPRESSION<br />_MOOD_SWINGS<br />_WHICH_INTERFARE<br />_WITH_LIFE<br />
                                             <asp:DropDownList ID="ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                         <td>
                                           EXPERIENCED<br />_SERIOUS_ANXIOUSNESS<br />_OR_TENSE_ANXIETY<br />_OR_PANIC_ATTACKS<br />
                                             <asp:DropDownList ID="ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS" CssClass="select2" Width="150px"  runat="server"></asp:DropDownList>

                                         </td>
                                         <td>
                                          EXPERIENCES_<br />TROUBLE_CONCENTRATING<br />_UNDERSTANDING_<br />REMEMBERING_VISUAL_<br />OR_AUDIO_HALLUCINATIONS<br />
                                             <asp:DropDownList ID="ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>

                                        <td>
                                           TEMPER_<br />OR_VIOLENT_BEHAVIOUR<br />_CONTROL_PROBLEMS<br />
                                             <asp:DropDownList ID="ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                               </tr>
                                          <tr>
                                        <td>
                                          PLAN_TO_HURT<br />_OR_KILL_SOMEONE<br />
                                             <asp:DropDownList ID="ddlPLAN_TO_HURT_OR_KILL_SOMEONE" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                          SERIOUS_PLAN<br />_FOR_KILLING_SELF<br />
                                             <asp:DropDownList ID="ddlSERIOUS_PLAN_FOR_KILLING_SELF" CssClass="select2" Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                        <td>
                                        <td>
                                          SUCIDE_ATTEMPTS<br />
                                             <asp:DropDownList ID="ddlSUCIDE_ATTEMPTS" CssClass="select2"  Width="150px" runat="server"></asp:DropDownList>

                                         </td>
                                    </tr>

                                </table>

                                <div class="table-scrollable" id="GFG">
                                     
                                         
                                    <div class="col-12">
                                        <h2 class="page-header">
                                            <i>
                                                <img src="images/softicon.jpg" width="40" height="40" /></i>Mian Afzal Trust Hospital.
         
                               
                                        </h2>
                                    </div>
                                   
                                   <div class="row">
                                    <div class="col-md-6">
                                        <address>
                                            <strong>Mian Afzal Trust Hospital.</strong><br>
                                            Aroop Morr, Sialkot Road Gujranwala, Pakistan.<br>
                                            Phone: +92-55-3493795<br>
                                            Email: mianafzaltrust@gmail.com
       
                                        </address>
                                    </div>
                                    <div class="col-md-6">
                                        <b>Print Date:<asp:Label ID="lbldatetoday" runat="server"></asp:Label></b>
                                        <br>
                                        <b>Date From:</b><asp:Label ID="lbldatefrom" runat="server" Text="Label"></asp:Label>
                                        <br>
                                        <b>Date To:</b>
                                        <asp:Label ID="lbldateto" runat="server" Text="Label"></asp:Label><br>
                                        <b>Report Type:</b>
                                        <asp:Label ID="lbltype" runat="server" Text="Patient Report"></asp:Label>
                                    </div>
                                </div>
                                            

                                    <table
                                        class="table table-striped table-bordered table-hover table-checkable order-column valign-middle"
                                         style="width: 100%">

                                        <tbody>
                                            <asp:GridView  ID="IncomeGridView" BorderWidth="1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Both">
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
                                    </asp:GridView>
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
