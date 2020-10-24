using System;

public class ResponseData
{
    public Item[] items { get; set; }
    public int found { get; set; }
    public int pages { get; set; }
    public int per_page { get; set; }
    public int page { get; set; }
    public object clusters { get; set; }
    public object arguments { get; set; }
    public string alternate_url { get; set; }
}

public class Item
{
    public string id { get; set; }
    public bool premium { get; set; }
    public string name { get; set; }
    public object department { get; set; }
    public bool has_test { get; set; }
    public bool response_letter_required { get; set; }
    public Area area { get; set; }
    public Salary salary { get; set; }
    public Type type { get; set; }
    public object response_url { get; set; }
    public object sort_point_distance { get; set; }
    public Employer employer { get; set; }
    public DateTime published_at { get; set; }
    public DateTime created_at { get; set; }
    public bool archived { get; set; }
    public string apply_alternate_url { get; set; }
    public object insider_interview { get; set; }
    public string url { get; set; }
    public string alternate_url { get; set; }
    public object[] relations { get; set; }
    public Snippet snippet { get; set; }
    public object contacts { get; set; }
    public Schedule schedule { get; set; }
    public object[] working_days { get; set; }
    public object[] working_time_intervals { get; set; }
    public object[] working_time_modes { get; set; }
    public bool accept_temporary { get; set; }
}

public class Area
{
    public string id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
}

public class Salary
{
    public int? from { get; set; }
    public int? to { get; set; }
    public string currency { get; set; }
    public bool? gross { get; set; }
}

public class Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employer
{
    public string id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string alternate_url { get; set; }
    public Logo_Urls logo_urls { get; set; }
    public string vacancies_url { get; set; }
    public bool trusted { get; set; }
}

public class Logo_Urls
{
    public string _90 { get; set; }
    public string _240 { get; set; }
    public string original { get; set; }
}

public class Snippet
{
    public string requirement { get; set; }
    public string responsibility { get; set; }
}

public class Schedule
{
    public string id { get; set; }
    public string name { get; set; }
}


public class hh_dictionary
{
    public Vacancy_Label[] vacancy_label { get; set; }
    public Resume_Access_Type[] resume_access_type { get; set; }
    public Vacancy_Search_Order[] vacancy_search_order { get; set; }
    public Vacancy_Search_Fields[] vacancy_search_fields { get; set; }
    public Vacancy_Type[] vacancy_type { get; set; }
    public Gender[] gender { get; set; }
    public Preferred_Contact_Type[] preferred_contact_type { get; set; }
    public Travel_Time[] travel_time { get; set; }
    public Relocation_Type[] relocation_type { get; set; }
    public Business_Trip_Readiness[] business_trip_readiness { get; set; }
    public Resume_Contacts_Site_Type[] resume_contacts_site_type { get; set; }
    public Employer_Type[] employer_type { get; set; }
    public Employer_Relation[] employer_relation { get; set; }
    public Negotiations_State[] negotiations_state { get; set; }
    public Applicant_Negotiation_Status[] applicant_negotiation_status { get; set; }
    public Negotiations_Participant_Type[] negotiations_participant_type { get; set; }
    public Negotiations_Order[] negotiations_order { get; set; }
    public Resume_Moderation_Note[] resume_moderation_note { get; set; }
    public Vacancy_Relation[] vacancy_relation { get; set; }
    public Resume_Status[] resume_status { get; set; }
    public Resume_Search_Logic[] resume_search_logic { get; set; }
    public Resume_Search_Fields[] resume_search_fields { get; set; }
    public Messaging_Status[] messaging_status { get; set; }
    public Employer_Active_Vacancies_Order[] employer_active_vacancies_order { get; set; }
    public Employer_Archived_Vacancies_Order[] employer_archived_vacancies_order { get; set; }
    public Employer_Hidden_Vacancies_Order[] employer_hidden_vacancies_order { get; set; }
    public Applicant_Comments_Order[] applicant_comments_order { get; set; }
    public Vacancy_Not_Prolonged_Reason[] vacancy_not_prolonged_reason { get; set; }
    public Vacancy_Site[] vacancy_site { get; set; }
    public Resume_Hidden_Fields[] resume_hidden_fields { get; set; }
    public Experience[] experience { get; set; }
    public Employment[] employment { get; set; }
    public Schedule[] schedule { get; set; }
    public Education_Level[] education_level { get; set; }
    public Currency[] currency { get; set; }
    public Vacancy_Billing_Type[] vacancy_billing_type { get; set; }
    public Applicant_Comment_Access_Type[] applicant_comment_access_type { get; set; }
    public Vacancy_Cluster[] vacancy_cluster { get; set; }
    public Driver_License_Types[] driver_license_types { get; set; }
    public Language_Level[] language_level { get; set; }
    public Working_Days[] working_days { get; set; }
    public Working_Time_Intervals[] working_time_intervals { get; set; }
    public Working_Time_Modes[] working_time_modes { get; set; }
    public Resume_Search_Label[] resume_search_label { get; set; }
    public Resume_Search_Relocation[] resume_search_relocation { get; set; }
    public Resume_Search_Order[] resume_search_order { get; set; }
    public Resume_Search_Experience_Period[] resume_search_experience_period { get; set; }
}

public class Vacancy_Label
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Access_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Search_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Search_Fields
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Gender
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Preferred_Contact_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Travel_Time
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Relocation_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Business_Trip_Readiness
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Contacts_Site_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employer_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employer_Relation
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Negotiations_State
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Applicant_Negotiation_Status
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Negotiations_Participant_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Negotiations_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Moderation_Note
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Relation
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Status
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Search_Logic
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Search_Fields
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Messaging_Status
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employer_Active_Vacancies_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employer_Archived_Vacancies_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employer_Hidden_Vacancies_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Applicant_Comments_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Not_Prolonged_Reason
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Site
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Hidden_Fields
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Experience
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Employment
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Education_Level
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Currency
{
    public string code { get; set; }
    public string abbr { get; set; }
    public string name { get; set; }
    public bool _default { get; set; }
    public float rate { get; set; }
    public bool in_use { get; set; }
}

public class Vacancy_Billing_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Applicant_Comment_Access_Type
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Vacancy_Cluster
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Driver_License_Types
{
    public string id { get; set; }
}

public class Language_Level
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Working_Days
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Working_Time_Intervals
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Working_Time_Modes
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Search_Label
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Search_Relocation
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Search_Order
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Resume_Search_Experience_Period
{
    public string id { get; set; }
    public string name { get; set; }
}


public class VacData
{
    public string id { get; set; }
    public bool premium { get; set; }
    public Billing_Type billing_type { get; set; }
    public object[] relations { get; set; }
    public string name { get; set; }
    public object insider_interview { get; set; }
    public bool response_letter_required { get; set; }
    public Area area { get; set; }
    public Salary salary { get; set; }
    public Type type { get; set; }
    public bool allow_messages { get; set; }
    public Site site { get; set; }
    public Experience experience { get; set; }
    public Schedule schedule { get; set; }
    public Employment employment { get; set; }
    public object department { get; set; }
    public object contacts { get; set; }
    public string description { get; set; }
    public object branded_description { get; set; }
    public object vacancy_constructor_template { get; set; }
    public Key_skills[] key_skills { get; set; }
    public bool accept_handicapped { get; set; }
    public bool accept_kids { get; set; }
    public bool archived { get; set; }
    public object response_url { get; set; }
    public Specialization[] specializations { get; set; }
    public object code { get; set; }
    public bool hidden { get; set; }
    public bool quick_responses_allowed { get; set; }
    public object[] driver_license_types { get; set; }
    public bool accept_incomplete_resumes { get; set; }
    public Employer employer { get; set; }
    public DateTime published_at { get; set; }
    public DateTime created_at { get; set; }
    public object negotiations_url { get; set; }
    public object suitable_resumes_url { get; set; }
    public string apply_alternate_url { get; set; }
    public bool has_test { get; set; }
    public object test { get; set; }
    public string alternate_url { get; set; }
    public object[] working_days { get; set; }
    public object[] working_time_intervals { get; set; }
    public object[] working_time_modes { get; set; }
    public bool accept_temporary { get; set; }
}

public class Billing_Type
{
    public string id { get; set; }
    public string name { get; set; }
}
public class Key_skills
{
    public string name { get; set; }
}
public class Site
{
    public string id { get; set; }
    public string name { get; set; }
}



public class Specialization
{
    public string id { get; set; }
    public string name { get; set; }
    public string profarea_id { get; set; }
    public string profarea_name { get; set; }
}