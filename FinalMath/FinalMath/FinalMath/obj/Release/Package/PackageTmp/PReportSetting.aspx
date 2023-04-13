<%@ Page Title="" Language="C#" MasterPageFile="~/Report.Master" AutoEventWireup="true" CodeBehind="PReportSetting.aspx.cs" Inherits="FinalMath.PReportSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="content-header">
            <div class="container-fluid">
                <div class="row mb-2">
                    <div class="col-sm-6">
                        <h1 class="m-0 text-dark">Patient Report Setting</h1>
                    </div>
                    <!-- /.col -->
                    <div class="col-sm-6">
                        <ol class="breadcrumb float-sm-right">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item active">Patient Report Setting</li>
                        </ol>
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </div>
        <asp:Panel ID="Panel1" runat="server">
           
        </asp:Panel>

        <section class="content">
            <div class="container-fluid">

                <div class="row">
                    <div class="col-sm-12">
                        <div class="card-box">

                            <div style="margin: 10px">

                                <table width="100%" style="font-size:small;font-weight:bold" border="1" class="table table-striped table-bordered table-hover table-checkable order-column valign-middle" id="example4">

                                    <tr>
            <td>REGISTRATION_NO<br />
                <asp:CheckBox ID="chkREGISTRATION_NO" runat="server"></asp:CheckBox>

            </td>
            <td>NAME
                
                                             <asp:CheckBox ID="chkNAME" runat="server">                                                 
                                             </asp:CheckBox>

            </td>
            <td>FATHER_NAME
                                             <asp:CheckBox ID="chkFATHER_NAME" runat="server"></asp:CheckBox>

            </td>
            <td>DATE_OF_BIRTH
                                             <asp:CheckBox ID="chkDATE_OF_BIRTH" runat="server"></asp:CheckBox>

            </td>
            <td>DATE_OF<br />_ADDMISSION
                                             <asp:CheckBox ID="chkDATE_OF_ADDMISSION" runat="server"></asp:CheckBox>

            </td>
        </tr>
        <tr>

            <td>DATE_OF_DISCHARGE
                                             <asp:CheckBox ID="chkDATE_OF_DISCHARGE" runat="server"></asp:CheckBox>

            </td>
            <td>MONTH
                                             <asp:CheckBox ID="chkMONTH" runat="server"></asp:CheckBox>

            </td>
            <td>CONTACT
                                             <asp:CheckBox ID="chkCONTACT" runat="server"></asp:CheckBox>

            </td>
            <td>CATEGORY
                                             <asp:CheckBox ID="chkCATEGORY" runat="server"></asp:CheckBox>

            </td>
            <td>AGE
                                             <asp:CheckBox ID="chkAGE" runat="server"></asp:CheckBox>

            </td>

        </tr>
        <tr>
            <td>CITY
                                             <asp:CheckBox ID="chkCITY" runat="server"></asp:CheckBox>

            </td>
            <td>ADDRESS
                                             <asp:CheckBox ID="chkADDRESS" runat="server"></asp:CheckBox>

            </td>
            <td>RELIGION
                                             <asp:CheckBox ID="chkRELIGION" runat="server"></asp:CheckBox>

            </td>
            <td>CHRONIC_MEDICAL_PROBLEM
                                             <asp:CheckBox ID="chkCHRONIC_MEDICAL_PROBLEM" runat="server"></asp:CheckBox>

            </td>
            <td>CMP_SPECIFY
                                             <asp:CheckBox ID="chkCMP_SPECIFY" runat="server"></asp:CheckBox>

            </td>
        </tr>
        <tr>
            <td>REGULARLY_TAKING<br />_OR_SHOULD_BE_TAKING<br />_PRESCRIBED_MEDICATION
                                             <asp:CheckBox ID="chkREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION" runat="server"></asp:CheckBox>

            </td>
            <td>EDUCATION
                                             <asp:CheckBox ID="chkEDUCATION" runat="server"></asp:CheckBox>

            </td>
            <td>OCCUPATION
                                             <asp:CheckBox ID="chkOCCUPATION" runat="server"></asp:CheckBox>

            </td>
            <td>DRUG_TYPE
                                             <asp:CheckBox ID="chkDRUG_TYPE" runat="server"></asp:CheckBox>

            </td>
            <td>R_O_A
                                             <asp:CheckBox ID="chkR_O_A" runat="server"></asp:CheckBox>

            </td>
        </tr>
        <tr>
            <td>REASON_FOR_SUBSTANCE_USE
                                             <asp:CheckBox ID="chkREASON_FOR_SUBSTANCE_USE" runat="server"></asp:CheckBox>

            </td>

            <td>HOW_MANY_TIMES_<br />BEFORE_TREATED_FOR_<br />SUBSTANCE_USE
                                             <asp:CheckBox ID="chkHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE" runat="server"></asp:CheckBox>

            </td>
            <td>REASON_BEHIND_RELAPSE
                                             <asp:CheckBox ID="chkREASON_BEHIND_RELAPSE" runat="server"></asp:CheckBox>

            </td>
            <td>HAVING_EVER<br />_BEEN_ARRESTED<br />_AND_CHARGED_FOR_<br />ANY_CRIME
                                             <asp:CheckBox ID="chkHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME" runat="server"></asp:CheckBox>

            </td>
            <td>HC_SPECIFY
                                             <asp:CheckBox ID="chkHC_SPECIFY" runat="server"></asp:CheckBox>

            </td>
            </tr>
                                    <tr>
            <td>MARITAL_STATUS
                                             <asp:CheckBox ID="chkMARITAL_STATUS" runat="server"></asp:CheckBox>

            </td>
            <td>LIVES_WITH_ANY<br />_ONE_WHO_ABUSES<br />_DRUGS_ALCOHAL
                                             <asp:CheckBox ID="chkLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL" runat="server"></asp:CheckBox>

            </td>
            <td>LDA_SPECIFIER
                                             <asp:CheckBox ID="chkLDA_SPECIFIER" runat="server"></asp:CheckBox>

            </td>

            <td>YOU_HAD_EXPERIENCED_<br />SERIOUS_PROBLEM_WITH_<br />YOUR_FAMILY_OTHER<br />_SIGNIFICANT_FAMILY
                                             <asp:CheckBox ID="chkYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY" runat="server"></asp:CheckBox>

            </td>

            <td>SF_SPECIFY
                                             <asp:CheckBox ID="chkSF_SPECIFY" runat="server"></asp:CheckBox>

            </td>
                                        </tr>
                                    <tr>
            <td>HAS_ANY_ONE_ABUSED_YOU
                                             <asp:CheckBox ID="chkHAS_ANY_ONE_ABUSED_YOU" runat="server"></asp:CheckBox>

            </td>
            <td>EXPERIENCED_SERIOUS_<br />DEPRESSION_MOOD_SWINGS<br />_WHICH_INTERFARE_WITH_LIFE
                                             <asp:CheckBox ID="chkEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE" runat="server"></asp:CheckBox>

            </td>
            <td>EXPERIENCED_SERIOUS<br />_ANXIOUSNESS_OR_TENSE_ANXIETY_<br />OR_PANIC_ATTACKS
                                             <asp:CheckBox ID="chkEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS" runat="server"></asp:CheckBox>

            </td>
            <td>EXPERIENCES_TROUBLE<br />_CONCENTRATING_<br />UNDERSTANDING_REMEMBERING_VISUAL_OR<br />_AUDIO_HALLUCINATIONS
                                             <asp:CheckBox ID="chkEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS" runat="server"></asp:CheckBox>

            </td>
                                           <td>TEMPER_OR<br />_VIOLENT_<br />BEHAVIOUR<br />_CONTROL<br />_PROBLEMS
                                             <asp:CheckBox ID="chkTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS" runat="server"></asp:CheckBox>

            </td>
                                        </tr>
                                    <tr>

         
            <td>PLAN_TO_HURT<br />_OR_KILL_SOMEONE
                                             <asp:CheckBox ID="chkPLAN_TO_HURT_OR_KILL_SOMEONE" runat="server"></asp:CheckBox>

            </td>
            <td>SERIOUS_PLAN_FOR_KILLING_SELF
                                             <asp:CheckBox ID="chkSERIOUS_PLAN_FOR_KILLING_SELF" runat="server"></asp:CheckBox>

            </td>
            <td>SUCIDE_ATTEMPTS
                                             <asp:CheckBox ID="chkSUCIDE_ATTEMPTS" runat="server"></asp:CheckBox>

            </td>
        </tr>
    </table>
</div></div></div></div>
    <div class="row" align="center">
        <div class="col-md-4">

        </div>
         <div class="col-md-4">
             <asp:Button ID="btnsave" class="btn btn-primary" runat="server" Text="Save Changes" OnClick="btnsave_Click"  />
          
        </div>
         <div class="col-md-4">

        </div>
       
    </div></div></section>

</asp:Content>

