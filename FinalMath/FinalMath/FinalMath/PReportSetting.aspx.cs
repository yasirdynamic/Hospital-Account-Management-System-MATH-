using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class PReportSetting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!IsPostBack)
            {
                SqlConnection con1 = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd1 = new SqlCommand("select * from Patient_Setting", con1);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                dt = new DataTable();
                da1.Fill(dt);

                if (bool.Parse(dt.Rows[0]["ADDRESS"].ToString()))
                {
                    chkADDRESS.Checked = true;

                }
                if (bool.Parse(dt.Rows[0]["AGE"].ToString()))
                {
                    chkAGE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["CATEGORY"].ToString()))
                {
                    chkCATEGORY.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["CHRONIC_MEDICAL_PROBLEM"].ToString()))
                {
                    chkCHRONIC_MEDICAL_PROBLEM.Checked = true;
                }

                if (bool.Parse(dt.Rows[0]["CITY"].ToString()))
                {
                    chkCITY.Checked = true;
                }

                if (bool.Parse(dt.Rows[0]["CMP_SPECIFY"].ToString()))
                {
                    chkCMP_SPECIFY.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["CONTACT"].ToString()))
                {
                    chkCONTACT.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["DATE_OF_ADDMISSION"].ToString()))
                {
                    chkDATE_OF_ADDMISSION.Checked = true;
                }

                if (bool.Parse(dt.Rows[0]["DATE_OF_BIRTH"].ToString()))
                {
                    chkDATE_OF_BIRTH.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["DATE_OF_DISCHARGE"].ToString()))
                {
                    chkDATE_OF_DISCHARGE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["DRUG_TYPE"].ToString()))
                {
                    chkDRUG_TYPE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["EDUCATION"].ToString()))
                {
                    chkEDUCATION.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS"].ToString()))
                {
                    chkEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE"].ToString()))
                {
                    chkEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS"].ToString()))
                {
                    chkEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["FATHER_NAME"].ToString()))
                {
                    chkFATHER_NAME.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["FATHER_NAME"].ToString()))
                {
                    chkFATHER_NAME.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME"].ToString()))
                {
                    chkHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["HC_SPECIFY"].ToString()))
                {
                    chkHC_SPECIFY.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE"].ToString()))
                {
                    chkHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["LDA_SPECIFIER"].ToString()))
                {
                    chkLDA_SPECIFIER.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL"].ToString()))
                {
                    chkLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["MARITAL_STATUS"].ToString()))
                {
                    chkMARITAL_STATUS.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["MONTH"].ToString()))
                {
                    chkMONTH.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["NAME"].ToString()))
                {
                    chkNAME.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["OCCUPATION"].ToString()))
                {
                    chkOCCUPATION.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["PLAN_TO_HURT_OR_KILL_SOMEONE"].ToString()))
                {
                    chkPLAN_TO_HURT_OR_KILL_SOMEONE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["REASON_BEHIND_RELAPSE"].ToString()))
                {
                    chkREASON_BEHIND_RELAPSE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["REASON_FOR_SUBSTANCE_USE"].ToString()))
                {
                    chkREASON_FOR_SUBSTANCE_USE.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["REGISTRATION_NO"].ToString()))
                {
                    chkREGISTRATION_NO.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION"].ToString()))
                {
                    chkREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.Checked = true;
                }

                if (bool.Parse(dt.Rows[0]["RELIGION"].ToString()))
                {
                    chkRELIGION.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["R_O_A"].ToString()))
                {
                    chkR_O_A.Checked = true;
                }

                if (bool.Parse(dt.Rows[0]["SERIOUS_PLAN_FOR_KILLING_SELF"].ToString()))
                {
                    chkSERIOUS_PLAN_FOR_KILLING_SELF.Checked = true;
                }

                if (bool.Parse(dt.Rows[0]["SF_SPECIFY"].ToString()))
                {
                    chkSF_SPECIFY.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["SUCIDE_ATTEMPTS"].ToString()))
                {
                    chkSUCIDE_ATTEMPTS.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS"].ToString()))
                {
                    chkTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.Checked = true;
                }
                if (bool.Parse(dt.Rows[0]["YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY"].ToString()))
                {
                    chkYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.Checked = true;
                }

            }


        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            String filter = "";

            if (chkADDRESS.Checked)
            {
                filter += " , ADDRESS = '" + 1 + "'";
            }
            else
            {
                filter += " , ADDRESS = '" + 0 + "'";
            }
            if (chkAGE.Checked)
            {
                filter += " , AGE = '" + 1 + "'";
            }
            else
            {
                filter += " , AGE = '" + 0 + "'";
            }
            if (chkCATEGORY.Checked)
            {
                filter += " , CATEGORY = '" + 1 + "'";
            }
            else
            {
                filter += " , CATEGORY = '" + 0 + "'";
            }
            if (chkCHRONIC_MEDICAL_PROBLEM.Checked)
            {
                filter += " , CHRONIC_MEDICAL_PROBLEM = '" + 1 + "'";
            }
            else
            {
                filter += " , CHRONIC_MEDICAL_PROBLEM = '" + 0 + "'";
            }
            if (chkCITY.Checked)
            {
                filter += " , CITY = '" + 1 + "'";
            }
            else
            {
                filter += " , CITY = '" + 0 + "'";
            }
            if (chkCMP_SPECIFY.Checked)
            {
                filter += " , CMP_SPECIFY = '" + 1 + "'";
            }
            else
            {
                filter += " , CMP_SPECIFY = '" + 0 + "'";
            }
            if (chkCONTACT.Checked)
            {
                filter += " , CONTACT = '" + 1 + "'";
            }
            else
            {
                filter += " , CONTACT = '" + 0 + "'";
            }
            if (chkDATE_OF_ADDMISSION.Checked)
            {
                filter += " , DATE_OF_ADDMISSION = '" + 1 + "'";
            }
            else
            {
                filter += " , DATE_OF_ADDMISSION = '" + 0 + "'";
            }

            if (chkDATE_OF_BIRTH.Checked)
            {
                filter += " , DATE_OF_BIRTH = '" + 1 + "'";
            }
            else
            {
                filter += " , DATE_OF_BIRTH = '" + 0 + "'";
            }

            if (chkDATE_OF_DISCHARGE.Checked)
            {
                filter += " , DATE_OF_DISCHARGE = '" + 1 + "'";
            }
            else
            {
                filter += " , DATE_OF_DISCHARGE = '" + 0 + "'";
            }
            if (chkDRUG_TYPE.Checked)
            {
                filter += " , DRUG_TYPE = '" + 1 + "'";
            }
            else
            {
                filter += " , DRUG_TYPE = '" + 0 + "'";
            }
            if (chkEDUCATION.Checked)
            {
                filter += " , EDUCATION = '" + 1 + "'";
            }
            else
            {
                filter += " , EDUCATION = '" + 0 + "'";
            }
            if (chkEXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS.Checked)
            {
                filter += " , EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS = '" + 1 + "'";
            }
            else
            {
                filter += " , EXPERIENCED_SERIOUS_ANXIOUSNESS_OR_TENSE_ANXIETY_OR_PANIC_ATTACKS = '" + 0 + "'";
            }

            if (chkEXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE.Checked)
            {
                filter += " , EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE = '" + 1 + "'";
            }
            else
            {
                filter += " , EXPERIENCED_SERIOUS_DEPRESSION_MOOD_SWINGS_WHICH_INTERFARE_WITH_LIFE = '" + 0 + "'";
            }

            if (chkEXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS.Checked)
            {
                filter += " , EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS = '" + 1 + "'";
            }
            else
            {
                filter += " , EXPERIENCES_TROUBLE_CONCENTRATING_UNDERSTANDING_REMEMBERING_VISUAL_OR_AUDIO_HALLUCINATIONS = '" + 0 + "'";
            }

            if (chkFATHER_NAME.Checked)
            {
                filter += " , FATHER_NAME = '" + 1 + "'";
            }
            else
            {
                filter += " , FATHER_NAME = '" + 0 + "'";
            }
            if (chkHAS_ANY_ONE_ABUSED_YOU.Checked)
            {
                filter += " , HAS_ANY_ONE_ABUSED_YOU = '" + 1 + "'";
            }
            else
            {
                filter += " , HAS_ANY_ONE_ABUSED_YOU = '" + 0 + "'";
            }
            if (chkHAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME.Checked)
            {
                filter += " , HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME = '" + 1 + "'";
            }
            else
            {
                filter += " , HAVING_EVER_BEEN_ARRESTED_AND_CHARGED_FOR_ANY_CRIME = '" + 0 + "'";
            }

            if (chkHC_SPECIFY.Checked)
            {
                filter += " , HC_SPECIFY = '" + 1 + "'";
            }
            else
            {
                filter += " , HC_SPECIFY = '" + 0 + "'";
            }
            if (chkHOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE.Checked)
            {
                filter += " , HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE = '" + 1 + "'";
            }
            else
            {
                filter += " , HOW_MANY_TIMES_BEFORE_TREATED_FOR_SUBSTANCE_USE = '" + 0 + "'";
            }

            if (chkLDA_SPECIFIER.Checked)
            {
                filter += " , LDA_SPECIFIER = '" + 1 + "'";
            }
            else
            {
                filter += " , LDA_SPECIFIER = '" + 0 + "'";
            }

            if (chkLIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL.Checked)
            {
                filter += " , LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL = '" + 1 + "'";
            }
            else
            {
                filter += " , LIVES_WITH_ANY_ONE_WHO_ABUSES_DRUGS_ALCOHAL = '" + 0 + "'";
            }

            if (chkMARITAL_STATUS.Checked)
            {
                filter += " , MARITAL_STATUS = '" + 1 + "'";
            }
            else
            {
                filter += " , MARITAL_STATUS = '" + 0 + "'";
            }

            if (chkMONTH.Checked)
            {
                filter += " , MONTH = '" + 1 + "'";
            }
            else
            {
                filter += " , MONTH = '" + 0 + "'";
            }

            if (chkNAME.Checked)
            {
                filter += " , NAME = '" + 1 + "'";
            }
            else
            {
                filter += " , NAME = '" + 0 + "'";
            }

            if (chkOCCUPATION.Checked)
            {
                filter += " , OCCUPATION = '" + 1 + "'";
            }
            else
            {
                filter += " , OCCUPATION = '" + 0 + "'";
            }

            if (chkPLAN_TO_HURT_OR_KILL_SOMEONE.Checked)
            {
                filter += " , PLAN_TO_HURT_OR_KILL_SOMEONE = '" + 1 + "'";
            }
            else
            {
                filter += " , PLAN_TO_HURT_OR_KILL_SOMEONE = '" + 0 + "'";
            }
            if (chkREASON_BEHIND_RELAPSE.Checked)
            {
                filter += " , REASON_BEHIND_RELAPSE = '" + 1 + "'";
            }
            else
            {
                filter += " , REASON_BEHIND_RELAPSE = '" + 0 + "'";
            }
            if (chkREASON_FOR_SUBSTANCE_USE.Checked)
            {
                filter += " , REASON_FOR_SUBSTANCE_USE = '" + 1 + "'";
            }
            else
            {
                filter += " , REASON_FOR_SUBSTANCE_USE = '" + 0 + "'";
            }
            if (chkREGISTRATION_NO.Checked)
            {
                filter += " , REGISTRATION_NO = '" + 1 + "'";
            }
            else
            {
                filter += " , REGISTRATION_NO = '" + 0 + "'";
            }
            if (chkREGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION.Checked)
            {
                filter += " , REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION = '" + 1 + "'";
            }
            else
            {
                filter += " , REGULARLY_TAKING_OR_SHOULD_BE_TAKING_PRESCRIBED_MEDICATION = '" + 0 + "'";
            }

            if (chkRELIGION.Checked)
            {
                filter += " , RELIGION = '" + 1 + "'";
            }
            else
            {
                filter += " , RELIGION = '" + 0 + "'";
            }
            if (chkR_O_A.Checked)
            {
                filter += " , R_O_A = '" + 1 + "'";
            }
            else
            {
                filter += " , R_O_A = '" + 0 + "'";
            }

            if (chkSERIOUS_PLAN_FOR_KILLING_SELF.Checked)
            {
                filter += " , SERIOUS_PLAN_FOR_KILLING_SELF = '" + 1 + "'";
            }
            else
            {
                filter += " , SERIOUS_PLAN_FOR_KILLING_SELF = '" + 0 + "'";
            }

            if (chkSF_SPECIFY.Checked)
            {
                filter += " ,  SF_SPECIFY = '" + 1 + "'";
            }
            else
            {
                filter += " ,  SF_SPECIFY = '" + 0 + "'";
            }
            if (chkSUCIDE_ATTEMPTS.Checked)
            {
                filter += " ,  SUCIDE_ATTEMPTS = '" + 1 + "'";
            }
            else
            {
                filter += " ,  SUCIDE_ATTEMPTS = '" + 0 + "'";
            }
            if (chkTEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS.Checked)
            {
                filter += " ,  TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS = '" + 1 + "'";
            }
            else
            {
                filter += " ,  TEMPER_OR_VIOLENT_BEHAVIOUR_CONTROL_PROBLEMS = '" + 0 + "'";
            }
            if (chkYOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY.Checked)
            {
                filter += " ,  YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY = '" + 1 + "'";
            }
            else
            {
                filter += " ,  YOU_HAD_EXPERIENCED_SERIOUS_PROBLEM_WITH_YOUR_FAMILY_OTHER_SIGNIFICANT_FAMILY = '" + 0 + "'";
            }
            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("update Patient_Setting set Patient_Id=0 " + filter + " where ID=1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}