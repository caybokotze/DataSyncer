using System;
using System.Data;

namespace Jessidatasyncer.Mappings
{
    public class Roag_MapUserTableColumns
    {
        public static void CreateMySqlColumns(ref DataTable mySqlColumns)
        {
            mySqlColumns.Columns.Add("id", typeof(String));
            mySqlColumns.Columns.Add("firstname", typeof(String));
            mySqlColumns.Columns.Add("lastname", typeof(String));
            mySqlColumns.Columns.Add("id_number", typeof(String));
            mySqlColumns.Columns.Add("email", typeof(String));
            mySqlColumns.Columns.Add("password", typeof(String));
            
            //mySqlColumns.Columns.Add("confirmation_code", typeof(String));
            //mySqlColumns.Columns.Add("confirmed", typeof(Int32)); //tiny
            
            mySqlColumns.Columns.Add("created_at", typeof(DateTime));
            mySqlColumns.Columns.Add("updated_at", typeof(DateTime));
            mySqlColumns.Columns.Add("gender_id", typeof(Int32));
            mySqlColumns.Columns.Add("dob", typeof(DateTime));
            mySqlColumns.Columns.Add("day_contact", typeof(String));
            mySqlColumns.Columns.Add("day_contact_tel", typeof(String));
            mySqlColumns.Columns.Add("day_building_complex", typeof(String));
            mySqlColumns.Columns.Add("day_street", typeof(String));
            mySqlColumns.Columns.Add("day_suburb_id", typeof(Int32));
            mySqlColumns.Columns.Add("day_town_id", typeof(Int32));
            mySqlColumns.Columns.Add("day_province_id", typeof(Int32));
            mySqlColumns.Columns.Add("day_country_id", typeof(Int32));
            mySqlColumns.Columns.Add("day_postcode", typeof(String));
            mySqlColumns.Columns.Add("postal_1", typeof(String));
            //mySqlColumns.Columns.Add("postal_2", typeof(String));
            //mySqlColumns.Columns.Add("postcode", typeof(String));
            //mySqlColumns.Columns.Add("suburb_id", typeof(Int32));
            //mySqlColumns.Columns.Add("town_id", typeof(Int32));
            //mySqlColumns.Columns.Add("province_id", typeof(Int32));
            //mySqlColumns.Columns.Add("country_id", typeof(Int32));
            mySqlColumns.Columns.Add("tel_cell", typeof(String));
            mySqlColumns.Columns.Add("tel_work", typeof(String));
            mySqlColumns.Columns.Add("tel_home", typeof(String));
            mySqlColumns.Columns.Add("fax", typeof(String));
            mySqlColumns.Columns.Add("med_aid_name", typeof(String));
            mySqlColumns.Columns.Add("med_aid_no", typeof(String));
            mySqlColumns.Columns.Add("med_aid_id", typeof(Int32));
            mySqlColumns.Columns.Add("blood_type_id", typeof(Int32));
            mySqlColumns.Columns.Add("em_contact", typeof(String));
            mySqlColumns.Columns.Add("em_contact_no", typeof(String));
            mySqlColumns.Columns.Add("em_contact_2", typeof(String));
            mySqlColumns.Columns.Add("em_contact_2_no", typeof(String));
            //mySqlColumns.Columns.Add("doctor", typeof(String));
            //mySqlColumns.Columns.Add("doctor_tel", typeof(String));
            mySqlColumns.Columns.Add("allergies", typeof(String));
            mySqlColumns.Columns.Add("medical_conditions", typeof(String));
            //mySqlColumns.Columns.Add("club_roag", typeof(Int32));//tiny
            //ySqlColumns.Columns.Add("cycling_club_id", typeof(Int32));
            //mySqlColumns.Columns.Add("csa_no", typeof(String));
            //mySqlColumns.Columns.Add("canoeing_club_id", typeof(Int32));
            //mySqlColumns.Columns.Add("canoeing_sa_no", typeof(String));
            //mySqlColumns.Columns.Add("running_club_id", typeof(Int32));
            //mySqlColumns.Columns.Add("asa_no", typeof(String));
            //mySqlColumns.Columns.Add("swimming_club_id", typeof(Int32));
            //mySqlColumns.Columns.Add("swim_sa_no", typeof(String));
            //mySqlColumns.Columns.Add("trail_run_club_id", typeof(Int32));
            //mySqlColumns.Columns.Add("trail_sa_no", typeof(String));
            //mySqlColumns.Columns.Add("school_id", typeof(Int32));
            //mySqlColumns.Columns.Add("school_name", typeof(String));
            //mySqlColumns.Columns.Add("champion_chip", typeof(String));
            //mySqlColumns.Columns.Add("winning_time", typeof(String));
            //mySqlColumns.Columns.Add("elite", typeof(String));
            //mySqlColumns.Columns.Add("spectrum", typeof(String));
            //mySqlColumns.Columns.Add("ppa", typeof(String));
            //mySqlColumns.Columns.Add("avendurance", typeof(String));
            mySqlColumns.Columns.Add("sa_seeding", typeof(String));
            mySqlColumns.Columns.Add("shirt_size_id", typeof(Int32));
            mySqlColumns.Columns.Add("guardian_type_id", typeof(Int32));
            mySqlColumns.Columns.Add("guardian_name", typeof(String));
            mySqlColumns.Columns.Add("guardian_surname", typeof(String));
            mySqlColumns.Columns.Add("guardian_id", typeof(String));
            mySqlColumns.Columns.Add("guardian_val", typeof(Int32));//tiny
            mySqlColumns.Columns.Add("auto_generate", typeof(Int32));//tiny
            mySqlColumns.Columns.Add("allow_email", typeof(Int32));//tiny
            mySqlColumns.Columns.Add("number_board", typeof(Int32));//tiny
            //mySqlColumns.Columns.Add("roag_chip", typeof(Int32));//tiny
            //mySqlColumns.Columns.Add("roag_chip_no", typeof(String));
            mySqlColumns.Columns.Add("register_date", typeof(DateTime));
            //mySqlColumns.Columns.Add("avatar", typeof(String));
            //mySqlColumns.Columns.Add("allow_em_contact_info", typeof(Int32));//tiny
            //mySqlColumns.Columns.Add("rec_newsletter", typeof(Int32));//tiny
            //mySqlColumns.Columns.Add("team_vitality_member", typeof(Int32));//tiny
            //mySqlColumns.Columns.Add("send_data_to_vitality", typeof(Int32));//tiny
            //add missing.
            mySqlColumns.Columns.Add("status", typeof(Int32));
            mySqlColumns.Columns.Add("remember_token", typeof(String));
            mySqlColumns.Columns.Add("deleted_at", typeof(String));
            
        }
    }
}