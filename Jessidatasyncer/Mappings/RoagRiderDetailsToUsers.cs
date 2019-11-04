using System;
using System.Data;
using System.Globalization;

namespace Jessidatasyncer.Mappings
{
    public class RoagRiderDetailsToUsers
    {
        public static void MapRecords(ref DataRow mySqlRow, ref DataRow msSqlRow)
        {
            mySqlRow["id"] = msSqlRow["id"];
            mySqlRow["id"] = msSqlRow["RoagID"];
            mySqlRow["firstname"] = msSqlRow["FirstName"];
            mySqlRow["lastname"] = msSqlRow["LastName"]; 
            mySqlRow["id_number"] = msSqlRow["IDNumber"];
            mySqlRow["email"] = msSqlRow["Email"];
            mySqlRow["password"] = msSqlRow["Password"];
            //mySqlRow["confirmation_code"] = GetUniqID();
            mySqlRow["confirmed"] = true;
            mySqlRow["created_at"] = DateTime.Now;
            mySqlRow["updated_at"] = msSqlRow["LastUpdated"];
            mySqlRow["gender_id"] = msSqlRow["GenderID"];
            mySqlRow["dob"] = msSqlRow["DOB"];

            if (!msSqlRow.IsNull("DayContact"))
            {
                mySqlRow["day_contact"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["DayContact"]).Trim();
            }
            mySqlRow["day_contact_tel"] = msSqlRow["DayContactTel"];
            if (!msSqlRow.IsNull("DayBuildingComplex"))
            {
                mySqlRow["day_building_complex"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["DayBuildingComplex"]).Trim();
            }
            mySqlRow["day_street"] = msSqlRow["DayStreet"];
            mySqlRow["day_suburb_id"] = msSqlRow["DaySuburbID"];
            mySqlRow["day_town_id"] = msSqlRow["DayTownID"];
            mySqlRow["day_province_id"] = (int)msSqlRow["DayProvinceID"] > 0 ? msSqlRow["DayProvinceID"] : 10;
            mySqlRow["day_country_id"] = msSqlRow["DayCountryID"];
            mySqlRow["day_postcode"] = msSqlRow["DayPostCode"];
            if (!msSqlRow.IsNull("Postal1"))
            {
                mySqlRow["postal_1"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["Postal1"]).Trim();
            }
            if (!msSqlRow.IsNull("Postal2"))
            {
                mySqlRow["postal_2"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["Postal2"]).Trim();
            }
            mySqlRow["postcode"] = msSqlRow["Postcode"];
            mySqlRow["suburb_id"] = msSqlRow["DaySuburbID"];
            mySqlRow["town_id"] = msSqlRow["DayTownID"];
            mySqlRow["province_id"] = (int)msSqlRow["ProvinceID"] > 0 ? msSqlRow["ProvinceID"] : 10;
            mySqlRow["country_id"] = msSqlRow["CountryID"];
            mySqlRow["tel_cell"] = msSqlRow["TelCell"];
            mySqlRow["tel_work"] = msSqlRow["TelWork"];
            mySqlRow["tel_home"] = msSqlRow["TelHome"];
            mySqlRow["fax"] = msSqlRow["Fax"];
            if (!msSqlRow.IsNull("MedAidName"))
            {
                mySqlRow["med_aid_name"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["MedAidName"]).Trim();
            }
            mySqlRow["med_aid_no"] = msSqlRow["MedAidNo"];
            mySqlRow["med_aid_id"] = msSqlRow["MedAidID"];
            mySqlRow["blood_type_id"] = msSqlRow["BloodTypeID"];
            if (!msSqlRow.IsNull("EmContact"))
            {
                mySqlRow["em_contact"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["EmContact"]).Trim();
            }
            mySqlRow["em_contact_no"] = msSqlRow["EmContactNo"];
            mySqlRow["em_contact_2"] = msSqlRow["EmContact2"];
            mySqlRow["em_contact_2_no"] = msSqlRow["EmContactNo2"];
            if (!msSqlRow.IsNull("Doctor"))
            {
                mySqlRow["doctor"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["Doctor"]).Trim();
            }
            mySqlRow["doctor_tel"] = msSqlRow["DoctorTel"];
            mySqlRow["allergies"] = msSqlRow["Allergies"];
            mySqlRow["medical_conditions"] = msSqlRow["MedicalConditions"];
            mySqlRow["club_roag"] = msSqlRow["ClubRoag"];
            mySqlRow["cycling_club_id"] = msSqlRow["CyclingClubID"];
            mySqlRow["csa_no"] = msSqlRow["CSA"];
            mySqlRow["canoeing_club_id"] = msSqlRow["CanoeingClubID"];
            mySqlRow["canoeing_sa_no"] = msSqlRow["CaSaNo"];
            mySqlRow["running_club_id"] = msSqlRow["RunningClubID"];
            mySqlRow["asa_no"] = msSqlRow["ASANo"];
            mySqlRow["swimming_club_id"] = msSqlRow["SwimmingClubID"];
            mySqlRow["swim_sa_no"] = msSqlRow["SwimSANo"];
            mySqlRow["trail_run_club_id"] = msSqlRow["TrailRunClubID"];
            mySqlRow["trail_sa_no"] = msSqlRow["TRASANo"];
            mySqlRow["school_id"] = msSqlRow["SchoolID"];
            if (!msSqlRow.IsNull("SchoolName"))
            {
                mySqlRow["school_name"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["SchoolName"]).Trim();
            }
            mySqlRow["champion_chip"] = msSqlRow["ChampionChip"];
            mySqlRow["winning_time"] = msSqlRow["WinningTime"];
            mySqlRow["elite"] = msSqlRow["Elite"];
            mySqlRow["spectrum"] = msSqlRow["Spectrum"];
            mySqlRow["ppa"] = msSqlRow["PPA"];
            mySqlRow["avendurance"] = msSqlRow["Avendurance"];
            mySqlRow["sa_seeding"] = msSqlRow["SASeeding"];
            mySqlRow["shirt_size_id"] = msSqlRow["ShirtSizeID"];
            mySqlRow["guardian_type_id"] = msSqlRow["GaurdianTypeID"];
            if (!msSqlRow.IsNull("GaurdianName"))
            {
                mySqlRow["guardian_name"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["GaurdianName"]).Trim();
            }
            if (!msSqlRow.IsNull("GaurdianSurname"))
            {
                mySqlRow["guardian_surname"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((string)msSqlRow["GaurdianSurname"]).ToString().Trim();
            }
            mySqlRow["guardian_id"] = msSqlRow["GaurdianID"];
            mySqlRow["guardian_val"] = msSqlRow["GaurdianVal"];
            mySqlRow["auto_generate"] = msSqlRow["Autogenerate"];
            mySqlRow["allow_email"] = msSqlRow["AllowEmail"];
            mySqlRow["number_board"] = msSqlRow["NumberBoard"];
            mySqlRow["roag_chip"] = msSqlRow["RoagChip"];
            mySqlRow["roag_chip_no"] = msSqlRow["RoagChipNo"];
            mySqlRow["register_date"] = msSqlRow["RegisterDate"];
            mySqlRow["avatar"] = msSqlRow["Avatar"];
            mySqlRow["allow_em_contact_info"] = msSqlRow["AllowEmContactInfo"];
            mySqlRow["rec_newsletter"] = msSqlRow["RecNewsletter"];
            mySqlRow["team_vitality_member"] = msSqlRow["TeamVitalityMember"];
            mySqlRow["send_data_to_vitality"] = msSqlRow["SendDataToVitality"];
            mySqlRow["status"] = 1;
            mySqlRow["remember_token"] = null;
            mySqlRow["deleted_at"] = null;
        }
    }
}