using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class PReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDateFrom.Text = ((System.DateTime.Now).AddMonths(-1)).ToString("MM/dd/yyyy");
                txtDateTo.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd = new SqlCommand("select DISTINCT ADDRESS from PATIENT_INFO", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlADDRESS.DataSource = dt;
                ddlADDRESS.DataTextField = "ADDRESS";
                ddlADDRESS.DataValueField = "ADDRESS";
                ddlADDRESS.DataBind();
                ddlADDRESS.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT AGE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                ddlAGE.DataSource = dt;
                ddlAGE.DataTextField = "AGE";
                ddlAGE.DataValueField = "AGE";
                ddlAGE.DataBind();
                ddlAGE.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT CATEGORY from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlCATEGORY.DataSource = dt;
                ddlCATEGORY.DataTextField = "CATEGORY";
                ddlCATEGORY.DataValueField = "CATEGORY";
                ddlCATEGORY.DataBind();
                ddlCATEGORY.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT CHRONIC_MEDICAL_PROBLEM from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                ddlCHRONIC_MEDICAL_PROBLEM.DataSource = dt;
                ddlCHRONIC_MEDICAL_PROBLEM.DataTextField = "CHRONIC_MEDICAL_PROBLEM";
                ddlCHRONIC_MEDICAL_PROBLEM.DataValueField = "CHRONIC_MEDICAL_PROBLEM";
                ddlCHRONIC_MEDICAL_PROBLEM.DataBind();
                ddlCHRONIC_MEDICAL_PROBLEM.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT CITY from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlCITY.DataSource = dt;
                ddlCITY.DataTextField = "CITY";
                ddlCITY.DataValueField = "CITY";
                ddlCITY.DataBind();
                ddlCITY.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT CMP_SPECIFY from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlCMP_SPECIFY.DataSource = dt;
                ddlCMP_SPECIFY.DataTextField = "CMP_SPECIFY";
                ddlCMP_SPECIFY.DataValueField = "CMP_SPECIFY";
                ddlCMP_SPECIFY.DataBind();
                ddlCMP_SPECIFY.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT CONTACT from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlCONTACT.DataSource = dt;
                ddlCONTACT.DataTextField = "CONTACT";
                ddlCONTACT.DataValueField = "CONTACT";
                ddlCONTACT.DataBind();
                ddlCONTACT.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT DATE_OF_ADDMISSION from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                ddlDATE_OF_ADDMISSION.DataSource = dt;
                ddlDATE_OF_ADDMISSION.DataTextField = "DATE_OF_ADDMISSION";
                ddlDATE_OF_ADDMISSION.DataValueField = "DATE_OF_ADDMISSION";
                ddlDATE_OF_ADDMISSION.DataBind();
                ddlDATE_OF_ADDMISSION.Items.Insert(0, new ListItem("Select", "disabled"));



                cmd = new SqlCommand("select DISTINCT DATE_OF_BIRTH from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlDATE_OF_BIRTH.DataSource = dt;
                ddlDATE_OF_BIRTH.DataTextField = "DATE_OF_BIRTH";
                ddlDATE_OF_BIRTH.DataValueField = "DATE_OF_BIRTH";
                ddlDATE_OF_BIRTH.DataBind();
                ddlDATE_OF_BIRTH.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT DATE_OF_DISCHARGE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                ddlDATE_OF_DISCHARGE.DataSource = dt;
                ddlDATE_OF_DISCHARGE.DataTextField = "DATE_OF_DISCHARGE";
                ddlDATE_OF_DISCHARGE.DataValueField = "DATE_OF_DISCHARGE";
                ddlDATE_OF_DISCHARGE.DataBind();
                ddlDATE_OF_DISCHARGE.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT DRUG_TYPE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                ddlDRUG_TYPE.DataSource = dt;
                ddlDRUG_TYPE.DataTextField = "DRUG_TYPE";
                ddlDRUG_TYPE.DataValueField = "DRUG_TYPE";
                ddlDRUG_TYPE.DataBind();
                ddlDRUG_TYPE.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT EDUCATION from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlEDUCATION.DataSource = dt;
                ddlEDUCATION.DataTextField = "EDUCATION";
                ddlEDUCATION.DataValueField = "EDUCATION";
                ddlEDUCATION.DataBind();
                ddlEDUCATION.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.DataSource = dt;
                ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.DataTextField = "EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS";
                ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.DataValueField = "EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS";
                ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.DataBind();
                ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.DataSource = dt;
                ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.DataTextField = "EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE";
                ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.DataValueField = "EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE";
                ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.DataBind();
                ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.DataSource = dt;
                ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.DataTextField = "EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS";
                ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.DataValueField = "EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS";
                ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.DataBind();
                ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT FATHER_NAME from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlFATHER_NAME.DataSource = dt;
                ddlFATHER_NAME.DataTextField = "FATHER_NAME";
                ddlFATHER_NAME.DataValueField = "FATHER_NAME";
                ddlFATHER_NAME.DataBind();
                ddlFATHER_NAME.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT HAS_ANY_ONE_ABUSED_YOU from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlHAS_ANY_ONE_ABUSED_YOU.DataSource = dt;
                ddlHAS_ANY_ONE_ABUSED_YOU.DataTextField = "HAS_ANY_ONE_ABUSED_YOU";
                ddlHAS_ANY_ONE_ABUSED_YOU.DataValueField = "HAS_ANY_ONE_ABUSED_YOU";
                ddlHAS_ANY_ONE_ABUSED_YOU.DataBind();
                ddlHAS_ANY_ONE_ABUSED_YOU.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.DataSource = dt;
                ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.DataTextField = "HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME";
                ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.DataValueField = "HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME";
                ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.DataBind();
                ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT HC_SPECIFY from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlHC_SPECIFY.DataSource = dt;
                ddlHC_SPECIFY.DataTextField = "HC_SPECIFY";
                ddlHC_SPECIFY.DataValueField = "HC_SPECIFY";
                ddlHC_SPECIFY.DataBind();
                ddlHC_SPECIFY.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.DataSource = dt;
                ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.DataTextField = "HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE";
                ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.DataValueField = "HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE";
                ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.DataBind();
                ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT LDA_SPECIFIER from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                ddlLDA_SPECIFIER.DataSource = dt;
                ddlLDA_SPECIFIER.DataTextField = "LDA_SPECIFIER";
                ddlLDA_SPECIFIER.DataValueField = "LDA_SPECIFIER";
                ddlLDA_SPECIFIER.DataBind();
                ddlLDA_SPECIFIER.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.DataSource = dt;
                ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.DataTextField = "LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL";
                ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.DataValueField = "LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL";
                ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.DataBind();
                ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT MARITAL_STATUS from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlMARITAL_STATUS.DataSource = dt;
                ddlMARITAL_STATUS.DataTextField = "MARITAL_STATUS";
                ddlMARITAL_STATUS.DataValueField = "MARITAL_STATUS";
                ddlMARITAL_STATUS.DataBind();
                ddlMARITAL_STATUS.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT MONTH from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlMONTH.DataSource = dt;
                ddlMONTH.DataTextField = "MONTH";
                ddlMONTH.DataValueField = "MONTH";
                ddlMONTH.DataBind();
                ddlMONTH.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT NAME from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlNAME.DataSource = dt;
                ddlNAME.DataTextField = "NAME";
                ddlNAME.DataValueField = "NAME";
                ddlNAME.DataBind();
                ddlNAME.Items.Insert(0, new ListItem("Select", "disabled"));


                cmd = new SqlCommand("select DISTINCT OCCUPATION from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlOCCUPATION.DataSource = dt;
                ddlOCCUPATION.DataTextField = "OCCUPATION";
                ddlOCCUPATION.DataValueField = "OCCUPATION";
                ddlOCCUPATION.DataBind();
                ddlOCCUPATION.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT PLAN_TO_HURT_OR_KILL_SOMEONE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlPLAN_TO_HURT_OR_KILL_SOMEONE.DataSource = dt;
                ddlPLAN_TO_HURT_OR_KILL_SOMEONE.DataTextField = "PLAN_TO_HURT_OR_KILL_SOMEONE";
                ddlPLAN_TO_HURT_OR_KILL_SOMEONE.DataValueField = "PLAN_TO_HURT_OR_KILL_SOMEONE";
                ddlPLAN_TO_HURT_OR_KILL_SOMEONE.DataBind();
                ddlPLAN_TO_HURT_OR_KILL_SOMEONE.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT REASON_BEHIND_RELAPSE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlREASON_BEHIND_RELAPSE.DataSource = dt;
                ddlREASON_BEHIND_RELAPSE.DataTextField = "REASON_BEHIND_RELAPSE";
                ddlREASON_BEHIND_RELAPSE.DataValueField = "REASON_BEHIND_RELAPSE";
                ddlREASON_BEHIND_RELAPSE.DataBind();
                ddlREASON_BEHIND_RELAPSE.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT REASON_FOR_SUBSTANCE_USE from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlREASON_FOR_SUBSTANCE_USE.DataSource = dt;
                ddlREASON_FOR_SUBSTANCE_USE.DataTextField = "REASON_FOR_SUBSTANCE_USE";
                ddlREASON_FOR_SUBSTANCE_USE.DataValueField = "REASON_FOR_SUBSTANCE_USE";
                ddlREASON_FOR_SUBSTANCE_USE.DataBind();
                ddlREASON_FOR_SUBSTANCE_USE.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT REGISTRATION_NO from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlREGISTRATION_NO.DataSource = dt;
                ddlREGISTRATION_NO.DataTextField = "REGISTRATION_NO";
                ddlREGISTRATION_NO.DataValueField = "REGISTRATION_NO";
                ddlREGISTRATION_NO.DataBind();
                ddlREGISTRATION_NO.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.DataSource = dt;
                ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.DataTextField = "REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION";
                ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.DataValueField = "REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION";
                ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.DataBind();
                ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT RELIGION from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlRELIGION.DataSource = dt;
                ddlRELIGION.DataTextField = "RELIGION";
                ddlRELIGION.DataValueField = "RELIGION";
                ddlRELIGION.DataBind();
                ddlRELIGION.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT R_O_A from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlR_O_A.DataSource = dt;
                ddlR_O_A.DataTextField = "R_O_A";
                ddlR_O_A.DataValueField = "R_O_A";
                ddlR_O_A.DataBind();
                ddlR_O_A.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT SERIOUS_PLAN_FOR_KILLING_SELF from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlSERIOUS_PLAN_FOR_KILLING_SELF.DataSource = dt;
                ddlSERIOUS_PLAN_FOR_KILLING_SELF.DataTextField = "SERIOUS_PLAN_FOR_KILLING_SELF";
                ddlSERIOUS_PLAN_FOR_KILLING_SELF.DataValueField = "SERIOUS_PLAN_FOR_KILLING_SELF";
                ddlSERIOUS_PLAN_FOR_KILLING_SELF.DataBind();
                ddlSERIOUS_PLAN_FOR_KILLING_SELF.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT SF_SPECIFY from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlSF_SPECIFY.DataSource = dt;
                ddlSF_SPECIFY.DataTextField = "SF_SPECIFY";
                ddlSF_SPECIFY.DataValueField = "SF_SPECIFY";
                ddlSF_SPECIFY.DataBind();
                ddlSF_SPECIFY.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT SUCIDE_ATTEMPTS from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlSUCIDE_ATTEMPTS.DataSource = dt;
                ddlSUCIDE_ATTEMPTS.DataTextField = "SUCIDE_ATTEMPTS";
                ddlSUCIDE_ATTEMPTS.DataValueField = "SUCIDE_ATTEMPTS";
                ddlSUCIDE_ATTEMPTS.DataBind();
                ddlSUCIDE_ATTEMPTS.Items.Insert(0, new ListItem("Select", "disabled"));

                cmd = new SqlCommand("select DISTINCT TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.DataSource = dt;
                ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.DataTextField = "TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS";
                ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.DataValueField = "TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS";
                ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.DataBind();
                ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.Items.Insert(0, new ListItem("Select", "disabled"));
                cmd = new SqlCommand("select DISTINCT YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY from PATIENT_INFO", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.DataSource = dt;
                ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.DataTextField = "YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY";
                ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.DataValueField = "YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY";
                ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.DataBind();
                ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.Items.Insert(0, new ListItem("Select", "disabled"));

            }

        }


        protected void btnshowreport_Click(object sender, EventArgs e)
        {
            lbldatetoday.Text = System.DateTime.Now.ToString();
            lbldatefrom.Text = txtDateFrom.Text;
            lbldateto.Text = txtDateTo.Text;
            var isDischarged = cbIsDischarged.Checked;
            var isActive = cbIsActive.Checked;


            String filter = "";

            if (txtDateFrom.Text != "")
            {
                filter += " AND DATE_OF_ADDMISSION >= '" + txtDateFrom.Text + "'";
            }
            if (txtDateTo.Text != "")
            {
                filter += " AND DATE_OF_ADDMISSION <= '" + txtDateTo.Text + "'";
            }
            if (ddlADDRESS.SelectedItem.Value != "disabled")
            {
                filter += " AND ADDRESS = '" + ddlADDRESS.SelectedItem.Text + "'";
            }
            if (ddlAGE.SelectedItem.Value != "disabled")
            {
                filter += " AND AGE = '" + ddlAGE.SelectedItem.Text + "'";
            }
            if (ddlCATEGORY.SelectedItem.Value != "disabled")
            {
                filter += " AND CATEGORY = '" + ddlCATEGORY.SelectedItem.Text + "'";
            }
            if (ddlCHRONIC_MEDICAL_PROBLEM.SelectedItem.Value != "disabled")
            {
                filter += " AND CHRONIC_MEDICAL_PROBLEM = '" + ddlCHRONIC_MEDICAL_PROBLEM.SelectedItem.Text + "'";
            }
            if (ddlCITY.SelectedItem.Value != "disabled")
            {
                filter += " AND CITY = '" + ddlCITY.SelectedItem.Text + "'";
            }
            if (ddlCMP_SPECIFY.SelectedItem.Value != "disabled")
            {
                filter += " AND CITY = '" + ddlCMP_SPECIFY.SelectedItem.Text + "'";
            }
            if (ddlCONTACT.SelectedItem.Value != "disabled")
            {
                filter += " AND CONTACT = '" + ddlCONTACT.SelectedItem.Text + "'";
            }
            if (ddlDATE_OF_ADDMISSION.SelectedItem.Value != "disabled")
            {
                filter += " AND DATE_OF_ADDMISSION = '" + ddlDATE_OF_ADDMISSION.SelectedItem.Text + "'";
            }

            if (ddlDATE_OF_BIRTH.SelectedItem.Value != "disabled")
            {
                filter += " AND DATE_OF_BIRTH = '" + ddlDATE_OF_BIRTH.SelectedItem.Text + "'";
            }

            if (ddlDATE_OF_DISCHARGE.SelectedItem.Value != "disabled")
            {
                filter += " AND DATE_OF_DISCHARGE = '" + ddlDATE_OF_DISCHARGE.SelectedItem.Text + "'";
            }
            if (ddlDRUG_TYPE.SelectedItem.Value != "disabled")
            {
                filter += " AND DRUG_TYPE = '" + ddlDRUG_TYPE.SelectedItem.Text + "'";
            }
            if (ddlEDUCATION.SelectedItem.Value != "disabled")
            {
                filter += " AND DRUG_TYPE = '" + ddlEDUCATION.SelectedItem.Text + "'";
            }
            if (ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.SelectedItem.Value != "disabled")
            {
                filter += " AND EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS = '" + ddlEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.SelectedItem.Text + "'";
            }

            if (ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.SelectedItem.Value != "disabled")
            {
                filter += " AND EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE = '" + ddlEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.SelectedItem.Text + "'";
            }

            if (ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.SelectedItem.Value != "disabled")
            {
                filter += " AND EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS = '" + ddlEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.SelectedItem.Text + "'";
            }

            if (ddlFATHER_NAME.SelectedItem.Value != "disabled")
            {
                filter += " AND FATHER_NAME = '" + ddlFATHER_NAME.SelectedItem.Text + "'";
            }
            if (ddlHAS_ANY_ONE_ABUSED_YOU.SelectedItem.Value != "disabled")
            {
                filter += " AND HAS_ANY_ONE_ABUSED_YOU = '" + ddlHAS_ANY_ONE_ABUSED_YOU.SelectedItem.Text + "'";
            }
            if (ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.SelectedItem.Value != "disabled")
            {
                filter += " AND HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME = '" + ddlHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.SelectedItem.Text + "'";
            }

            if (ddlHC_SPECIFY.SelectedItem.Value != "disabled")
            {
                filter += " AND HC_SPECIFY = '" + ddlHC_SPECIFY.SelectedItem.Text + "'";
            }
            if (ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.SelectedItem.Value != "disabled")
            {
                filter += " AND HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE = '" + ddlHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.SelectedItem.Text + "'";
            }

            if (ddlLDA_SPECIFIER.SelectedItem.Value != "disabled")
            {
                filter += " AND LDA_SPECIFIER = '" + ddlLDA_SPECIFIER.SelectedItem.Text + "'";
            }

            if (ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.SelectedItem.Value != "disabled")
            {
                filter += " AND LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL = '" + ddlLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.SelectedItem.Text + "'";
            }

            if (ddlMARITAL_STATUS.SelectedItem.Value != "disabled")
            {
                filter += " AND MARITAL_STATUS = '" + ddlMARITAL_STATUS.SelectedItem.Text + "'";
            }

            if (ddlMONTH.SelectedItem.Value != "disabled")
            {
                filter += " AND MARITAL_STATUS = '" + ddlMONTH.SelectedItem.Text + "'";
            }

            if (ddlNAME.SelectedItem.Value != "disabled")
            {
                filter += " AND NAME = '" + ddlNAME.SelectedItem.Text + "'";
            }

            if (ddlOCCUPATION.SelectedItem.Value != "disabled")
            {
                filter += " AND OCCUPATION = '" + ddlOCCUPATION.SelectedItem.Text + "'";
            }

            if (ddlPLAN_TO_HURT_OR_KILL_SOMEONE.SelectedItem.Value != "disabled")
            {
                filter += " AND PLAN_TO_HURT_OR_KILL_SOMEONE = '" + ddlPLAN_TO_HURT_OR_KILL_SOMEONE.SelectedItem.Text + "'";
            }

            if (ddlREASON_BEHIND_RELAPSE.SelectedItem.Value != "disabled")
            {
                filter += " AND REASON_BEHIND_RELAPSE = '" + ddlREASON_BEHIND_RELAPSE.SelectedItem.Text + "'";
            }

            if (ddlREASON_FOR_SUBSTANCE_USE.SelectedItem.Value != "disabled")
            {
                filter += " AND REASON_FOR_SUBSTANCE_USE = '" + ddlREASON_FOR_SUBSTANCE_USE.SelectedItem.Text + "'";
            }

            if (ddlREGISTRATION_NO.SelectedItem.Value != "disabled")
            {
                filter += " AND REGISTRATION_NO = '" + ddlREGISTRATION_NO.SelectedItem.Text + "'";
            }

            if (ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.SelectedItem.Value != "disabled")
            {
                filter += " AND REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION = '" + ddlREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.SelectedItem.Text + "'";
            }

            if (ddlRELIGION.SelectedItem.Value != "disabled")
            {
                filter += " AND RELIGION = '" + ddlRELIGION.SelectedItem.Text + "'";
            }
            if (ddlR_O_A.SelectedItem.Value != "disabled")
            {
                filter += " AND R_O_A = '" + ddlR_O_A.SelectedItem.Text + "'";
            }

            if (ddlSERIOUS_PLAN_FOR_KILLING_SELF.SelectedItem.Value != "disabled")
            {
                filter += " AND SERIOUS_PLAN_FOR_KILLING_SELF = '" + ddlSERIOUS_PLAN_FOR_KILLING_SELF.SelectedItem.Text + "'";
            }

            if (ddlSF_SPECIFY.SelectedItem.Value != "disabled")
            {
                filter += " AND  SF_SPECIFY = '" + ddlSF_SPECIFY.SelectedItem.Text + "'";
            }
            if (ddlSUCIDE_ATTEMPTS.SelectedItem.Value != "disabled")
            {
                filter += " AND  SUCIDE_ATTEMPTS = '" + ddlSUCIDE_ATTEMPTS.SelectedItem.Text + "'";
            }
            if (ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.SelectedItem.Value != "disabled")
            {
                filter += " AND  TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS = '" + ddlTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.SelectedItem.Text + "'";
            }
            if (ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.SelectedItem.Value != "disabled")
            {
                filter += " AND  YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY = '" + ddlYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.SelectedItem.Text + "'";
            }

            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

            SqlCommand cmd = new SqlCommand("select * from PATIENT_INFO where 1=1 " + filter + "", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);


            cmd = new SqlCommand("select * from Patient_Setting", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            DataTable mydt;
            mydt = dt.Copy();
            if (mydt.Columns.Contains("USER_FID"))
            {
                mydt.Columns.Remove("USER_FID");
            }
            mydt.AcceptChanges();
            if (mydt.Columns.Contains("PATIENT_ID"))
            {
                mydt.Columns.Remove("PATIENT_ID");
            }
            mydt.AcceptChanges();
            if (mydt.Columns.Contains("IsActive"))
            {
                mydt.Columns.Remove("IsActive");
            }
            mydt.AcceptChanges();
            for (int i = 0; i < dt.Columns.Count - 2; i++)
            {
                if (dt.Columns[i].ToString() == dtp.Columns[i].ToString())
                {
                    string name = dtp.Columns[i].ToString();
                    cmd = new SqlCommand("select * from Patient_Setting where " + name + "=1 OR " + name + "=0", con);
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dtr = new DataTable();
                    da.Fill(dtr);
                    if (bool.Parse(dtr.Rows[0][name].ToString()))
                    {


                    }
                    else
                    {
                        if (mydt.Columns.Contains(name))
                        {
                            mydt.Columns.Remove(name);
                        }
                        mydt.AcceptChanges();
                    }
                }
            }

            DataColumn dc = new DataColumn("Sr#");
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dc.AutoIncrementStep = 1;
            dc.DataType = typeof(Int32);
            mydt.Columns.Add(dc);
            mydt.Columns["Sr#"].SetOrdinal(0);
            int index = 0;
            foreach (DataRow row in mydt.Rows)
            {
                row.SetField(dc, ++index);
            }

            Session["PatPrint"] = mydt;
            IncomeGridView.DataSource = mydt;
            IncomeGridView.DataBind();



        }

        protected void btnprintReport_Click(object sender, EventArgs e)
        {


            String[] info = { txtDateFrom.Text, txtDateTo.Text };
            Session["info"] = info;
            Response.Redirect("SalaryPrint.aspx");
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //required to avoid the runtime error "  
            //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."  
        }
        protected void btnexcel_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Vithal" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);


            IncomeGridView.GridLines = GridLines.Both;
            IncomeGridView.HeaderStyle.Font.Bold = true;
            IncomeGridView.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();
        }
    }
}